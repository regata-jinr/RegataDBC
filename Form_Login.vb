Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Squirrel
Imports System.Net
Imports System.Linq
Imports System.IO

Public Class Form_Login


    Async Function GetUpdate() As Task
        Try
            Dim restart As Boolean = False
            Dim latestExe As String = ""

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Using manager = Await UpdateManager.GitHubUpdateManager("https://github.com/regata-jinr/RegataDBC")
                Dim upd As UpdateInfo = Await manager.CheckForUpdate()

                If upd.ReleasesToApply.Any() Then
                    System.Diagnostics.Process.Start("https://github.com/regata-jinr/RegataDBC/releases/latest")

                    Dim LatestVersion = upd.ReleasesToApply.OrderBy(Function(x) x.Version).Last()
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

        Catch empty As InvalidOperationException
            ' in case of updates files don't exist
            MsgBox("Обновление не доступно. Обратитесть к администратору.", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try

            If CheckBoxKeep.Checked Then
                My.Settings.user = UsernameTextBox.Text
                My.Settings.password = PasswordTextBox.Text
            End If

            Form_Main.MyConnectionString = $"{My.Settings.NAA_DB_EXPConnectionString}User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text}"
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

        Await GetUpdate()

        If Not String.IsNullOrEmpty(My.Settings.user) And Not String.IsNullOrEmpty(My.Settings.password) Then
            UsernameTextBox.Text = My.Settings.user
            PasswordTextBox.Text = My.Settings.password
            CheckBoxKeep.Checked = True
            OK_Click(sender, e)
        End If



    End Sub
End Class

