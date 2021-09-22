Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Squirrel
Imports System.Net
Imports System.Linq
Imports System.IO
Imports Extensions
Imports AdysTech.CredentialManager


Public Class Form_Login

    Async Function GetUpdate() As Task
        Try
            Dim restart As Boolean = False
            Dim latestExe As String = ""
            Dim verL As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Using manager = Await UpdateManager.GitHubUpdateManager("https://github.com/regata-jinr/RegataDBC")
                Dim upd As UpdateInfo = Await manager.CheckForUpdate()

                If upd.ReleasesToApply.Any() Then

                    Dim LatestVersion = upd.ReleasesToApply.OrderBy(Function(x) x.Version).Last()

                    Dim verR As String = LatestVersion.Version.Version.ToString()

                    If verR = verL Then Throw New ArgumentException()

                    System.Diagnostics.Process.Start("https://github.com/regata-jinr/RegataDBC/releases/latest")


                    Await manager.DownloadReleases(upd.ReleasesToApply)
                    Await manager.ApplyReleases(upd)
                    Await manager.UpdateApp()

                    latestExe = Path.Combine(manager.RootAppDirectory, String.Concat("app-", LatestVersion.Version.Version.Major, ".", LatestVersion.Version.Version.Minor, ".", LatestVersion.Version.Version.Build, "."), "NaaDB.exe")
                    restart = True
                End If
            End Using

            If restart Then
                UpdateManager.RestartApp(latestExe)
            End If
        Catch empty As ArgumentException

        Catch empty As InvalidOperationException
            ' in case of updates files don't exist
            'TODO: add handle running setup.exe from latest release page
            MsgBox("Обновление не доступно. Пожалуйста, обратитесь к администратору", MsgBoxStyle.Critical)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try

            If CheckBoxKeep.Checked Then
                Dim nc As NetworkCredential = New NetworkCredential()
                nc.UserName = UsernameTextBox.Text
                nc.Password = PasswordTextBox.Text
                CredentialManager.SaveCredentials($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name}_RDBC", nc)
            End If

            Form_Main.MyConnectionString = $"{My.Settings.NAA_DB_EXPConnectionString}User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text}"
#If DEBUG Then
            Form_Main.MyConnectionString = "Data Source=RUMLAB;Initial Catalog=NAA_DB;Integrated Security=True;User ID=bdrum" ' abdusamadzoda
            CreateObject("WScript.Shell").Popup("You are in the debug mode. Don't forget switch to release before publishing.", 3, "D E B U G   M O D E")
#End If
            Form_Main.us = UsernameTextBox.Text
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            sqlConnection1.Open()
            sqlConnection1.Close()
            Form_Main.Show()
            Me.Close()
        Catch sqlEx As SqlException
            Debug.WriteLine(sqlEx.ToString)
            MsgBox("Неправильное имя пользователя или пароль.", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox($"{ex.ToString}", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Async Sub Form_Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Settings.language = "Русский" Then
            Me.Text = "Клиент базы данных эксперимента РЕГАТА - " & Application.ProductVersion
            CheckBoxKeep.Text = "Запомнить"
        ElseIf My.Settings.language = "English" Then
            Me.Text = "Regata experiment data base client - " & Application.ProductVersion
            CheckBoxKeep.Text = "Keep fields"
        End If
#If Not DEBUG Then
        Await GetUpdate()
#End If

        Dim uc As ICredential = CredentialManager.GetICredential($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name}_RDBC")

        If uc IsNot Nothing Then
            Dim nc As NetworkCredential = uc.ToNetworkCredential()
            UsernameTextBox.Text = nc.UserName
            PasswordTextBox.Text = nc.Password
            CheckBoxKeep.Checked = True
            If Not String.IsNullOrEmpty(nc.Password) Then
                OK_Click(sender, e)
            End If
        End If

    End Sub
End Class

