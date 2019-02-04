Imports System.Data.SqlClient
Imports System.Net
Imports System.IO
Imports Renci.SshNet

Public Class Form_ElsSum
    Private Sub Form_ElsSum_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub Form_ElsSum_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            sqlConnection1.Open()
            Using dataadapter As New SqlDataAdapter($"SELECT * from SamplesSummary WHERE CountryCode='{LablelElSumCountryCode.Text}' and ClientId='{LabelElSumClientId.Text}' and Year = '{LabelElSumYear.Text}' and SampleSetId = '{LabelElSumSetId.Text}' and SampleSetIndex = '{LabelElSumSetIndex.Text}'", sqlConnection1)
                Using ds As New DataSet()
                    Debug.WriteLine(dataadapter.SelectCommand.CommandText)
                    dataadapter.Fill(ds, "ElsSum")
                    DataGridViewElsSum.DataSource = ds
                    DataGridViewElsSum.DataMember = "ElsSum"
                    DataGridViewElsSum.Columns.RemoveAt(0)
                    DataGridViewElsSum.Columns.RemoveAt(0)
                    DataGridViewElsSum.Columns.RemoveAt(0)
                    DataGridViewElsSum.Columns.RemoveAt(0)
                    DataGridViewElsSum.Columns.RemoveAt(0)
                    DataGridViewElsSum.Columns(2).Visible = False
                    DataGridViewElsSum.Columns(3).Visible = False
                    DataGridViewElsSum.Columns(4).Visible = False

                    For Each row As DataGridViewRow In DataGridViewElsSum.Rows
                        If row.Cells("Группа элементов").Value = "'Все элементы" Or String.IsNullOrEmpty(row.Cells("Группа элементов").Value) Then
                            row.Cells("Элементы").Value = ""
                        Else
                            Dim cell As DataGridViewCell = row.Cells("Элементы")
                            cell.Value = ConcatNonZero(cell.Value)
                        End If
                        If String.IsNullOrEmpty(row.Cells("План. подготовка").Value) Then
                            row.Cells("План. подготовка").Value = ""
                        Else
                            Dim cell As DataGridViewCell = row.Cells("План. подготовка")
                            cell.Value = ConcatNonZero(cell.Value)
                        End If
                        If String.IsNullOrEmpty(row.Cells("Вып. подготовка").Value) Then
                            row.Cells("Вып. подготовка").Value = ""
                        Else
                            Dim cell As DataGridViewCell = row.Cells("Вып. подготовка")
                            cell.Value = ConcatNonZero(cell.Value)
                        End If
                    Next

                End Using
            End Using
            sqlConnection1.Close()
        End Using
    End Sub

    Function ConcatNonZero(ByVal iStr As String) As String
        Dim tempCell As String = ""
        If String.IsNullOrEmpty(iStr) Then Return ""
        For Each el As String In Split(iStr, "|")
            If el(0) = "1" Then tempCell += $"{el.Substring(1, el.Length - 1)}, "
        Next
        Return tempCell
    End Function

    Private Sub ButtonSpectraDWLD_Click(sender As Object, e As EventArgs) Handles ButtonSpectraDWLD.Click
        If Not (RadioButtonDFSLI.Checked Or RadioButtonDFLLI2.Checked Or RadioButtonDFLLI1.Checked) Then
            MessageBox.Show("Выберите тип измерений", "Загрузка файлов спектров", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If RadioButtonDFSLI.Checked Then
                DownloadSpectra(FormsFilesName("КЖИ"), "КЖИ")
            End If
            If RadioButtonDFLLI1.Checked Then
                DownloadSpectra(FormsFilesName("ДЖИ-1"), "ДЖИ-1")

            End If
            If RadioButtonDFLLI2.Checked Then
                DownloadSpectra(FormsFilesName("ДЖИ-2"), "ДЖИ-2")
            End If
        End If
    End Sub


    Sub DownloadSpectra(ByVal fileNames As ArrayList, ByVal type As String)
        Try
            Dim MissedFiles As String = ""
            ClearProgressBarAndStatusLabel()
            If fileNames.Count = 0 Then
                LabelStatus.Text = "Файлы спектров отсутствуют"
                Exit Sub
            End If
            LabelStatus.Text = "Инициализация скачивания спектров"
            FolderBrowserDialogSpectra.Description = $"Выберите папку для спектров {type}:"
            Dim user As String = ""
            Dim passw As String = ""
            Dim src As String = ""
            If FolderBrowserDialogSpectra.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then
                Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                    sqlConnection1.Open()
                    Using cmd As New System.Data.SqlClient.SqlCommand("select * from privinfo", sqlConnection1)
                        Using reader = cmd.ExecuteReader()
                            reader.Read()
                            If reader.HasRows Then
                                user = reader(0)
                                passw = reader(1)
                                src = reader(2)
                            End If
                        End Using
                    End Using
                    sqlConnection1.Close()
                End Using

                ProgressBarDwld.Maximum = fileNames.Count
                ProgressBarDwld.Show()
                LabelStatus.Text = "Соединение с FTP-сервером..."
                Using client As New SftpClient(src, 22, user, passw)
                    client.Connect()
                    LabelStatus.Text = "OK!"
                    Debug.WriteLine("OK!")
                    For Each file As String In fileNames
                        LabelStatus.Text = $"Загрузка файла: {Path.GetFileName(file)}"
                        Using fileStream As FileStream = IO.File.Create($"{FolderBrowserDialogSpectra.SelectedPath}\{Path.GetFileName(file)}")
                            If Not client.Exists(file) Then file = Path.ChangeExtension(file, "CNF")
                            If Not client.Exists(file) Then
                                MissedFiles += $"{Path.GetFileName(file)}, "
                                Continue For
                            End If
                            client.DownloadFile(file, fileStream)
                            ProgressBarDwld.Value += 1
                            fileStream.Close()
                            LabelStatus.Text = "OK!"
                            Debug.WriteLine("OK!")
                        End Using
                    Next
                    client.Disconnect()
                End Using

                If Not String.IsNullOrEmpty(MissedFiles) Then
                    MessageBox.Show($"Эти файлы{vbCrLf}{MissedFiles}{vbCrLf}не найдены. Возможно, они еще не загружены на сервер.", "Часть файлов не найдено", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    LabelStatus.Text = "Не все файлы были найдены!"
                Else
                    LabelStatus.Text = "Файлы успешно загружены!"

                End If

            End If
        Catch ex As Renci.SshNet.Common.SshOperationTimeoutException
            MsgBox("Timeout exceeded (30sec.)", MsgBoxStyle.Exclamation)
            LabelStatus.Text = "Ошибка подключения к FTP-серверу"
        Catch ex As Renci.SshNet.Common.SftpPathNotFoundException
            MsgBox("Запрашиваемый файл не найден. Возможно, спектры еще не перебросили или не набрали.", MsgBoxStyle.Exclamation)
        Catch ex As SqlException
            MsgBox($"Some problems with SQL-connection:\n{ex.Message}", MsgBoxStyle.Exclamation)
            LabelStatus.Text = "Ошибка получение данных аутентификации"
        End Try
    End Sub


    Function FormsFilesName(ByVal type As String) As ArrayList
        Dim FileNames As New ArrayList
        Dim typeFtp As New Dictionary(Of String, String)
        Dim mMonth As String = ""
        Dim mYear As String = ""
        typeFtp.Add("КЖИ", "kji")
        typeFtp.Add("ДЖИ-1", "dji-1")
        typeFtp.Add("ДЖИ-2", "dji-2")
        For Each row As DataGridViewRow In DataGridViewElsSum.Rows
            Dim cellFile As DataGridViewCell = row.Cells($"Файлы спектров {type}")
            If String.IsNullOrEmpty(cellFile.Value.ToString) Then Continue For
            Dim cellDate As DataGridViewCell = row.Cells($"{typeFtp(type)}-Date")
            If String.IsNullOrEmpty(cellDate.Value.ToString) Then Continue For
            Dim dt As DateTime = Convert.ToDateTime(cellDate.Value)
            FileNames.Add($"Spectra/{dt.Year}/{dt.Month.ToString("D2")}/{typeFtp(type)}/{cellFile.Value}.cnf")
        Next
        Return FileNames
    End Function

    Sub ClearProgressBarAndStatusLabel()
        LabelStatus.Text = ""
        ProgressBarDwld.Value = 0
    End Sub

    Private Sub ClearProgressBarAndStatusLabel(sender As Object, e As EventArgs) Handles RadioButtonDFSLI.CheckedChanged, RadioButtonDFLLI2.CheckedChanged, RadioButtonDFLLI1.CheckedChanged
        ClearProgressBarAndStatusLabel()
    End Sub
End Class

