Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports Renci.SshNet

Public Class Form_ElsSum



    Private Sub Form_ElsSum_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            sqlConnection1.Open()
            Using dataadapter As New SqlDataAdapter($"SELECT * from SamplesSummary WHERE CountryCode='{LablelElSumCountryCode.Text}' and ClientId='{LabelElSumClientId.Text}' and Year = '{LabelElSumYear.Text}' and SampleSetId = '{LabelElSumSetId.Text}' and SampleSetIndex = '{LabelElSumSetIndex.Text}'", sqlConnection1)
                Using ds As New DataSet()
                    Debug.WriteLine(dataadapter.SelectCommand.CommandText)
                    dataadapter.Fill(ds, "ElsSum")
                    DataGridViewElsSum.DataSource = ds
                    DataGridViewElsSum.DataMember = "ElsSum"
                    DataGridViewElsSum.Columns(0).Visible = False
                    DataGridViewElsSum.Columns(1).Visible = False
                    DataGridViewElsSum.Columns(2).Visible = False
                    DataGridViewElsSum.Columns(3).Visible = False
                    DataGridViewElsSum.Columns(4).Visible = False
                    DataGridViewElsSum.Columns(7).Visible = False
                    DataGridViewElsSum.Columns(8).Visible = False
                    DataGridViewElsSum.Columns(9).Visible = False
                    DataGridViewElsSum.Columns(10).Visible = False

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
                DownloadSpectra("КЖИ")
            End If
            If RadioButtonDFLLI1.Checked Then
                DownloadSpectra("ДЖИ-1")

            End If
            If RadioButtonDFLLI2.Checked Then
                DownloadSpectra("ДЖИ-2")
            End If
        End If
    End Sub


    Sub DownloadSpectra(ByVal type As String)
        Try
            ClearProgressBarAndStatusLabel()
            LabelStatus.Text = "Инициализация загрузки спектров..."

            Dim gYear As String = ""

            Dim fileNames = FormFinalFilesDict(type, gYear)
            Dim fileNamesServer = FindFiles(fileNames.Keys, gYear)

            If fileNamesServer.Count = 0 Then
                LabelStatus.Text = "Файлы спектров отсутствуют"
                Exit Sub
            End If

            If fileNames.Count <> fileNamesServer.Count Then
                LabelStatus.Text = "Не все файлы были найдены!"
            End If

            Dim missedFiles As String = ""

            FolderBrowserDialogSpectra.Description = $"Выберите папку для спектров {type}:"
            Dim user As String = ""
            Dim passw As String = ""
            Dim src As String = ""
            If FolderBrowserDialogSpectra.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then
                GetPswd(src, user, passw)
                ProgressBarDwld.Maximum = fileNames.Count
                ProgressBarDwld.Show()
                LabelStatus.Text = "Соединение с FTP-сервером..."
                Using client As New SftpClient(src, 22, user, passw)
                    client.Connect()
                    LabelStatus.Text = "OK!"
                    Debug.WriteLine("OK!")
                    For Each file As String In fileNames.Keys
                        LabelStatus.Text = $"Загрузка файла: {file}"
                        Directory.CreateDirectory($"{FolderBrowserDialogSpectra.SelectedPath}\{Path.GetDirectoryName(fileNames(file))}")
                        Debug.WriteLine($"Will be save to here: {FolderBrowserDialogSpectra.SelectedPath}\{fileNames(file)}")
                        If Not fileNamesServer.ContainsKey(file) Then
                            missedFiles += $"{Path.GetFileName(file)}, "
                            Continue For
                        End If
                        Using fileStream As FileStream = IO.File.Create($"{FolderBrowserDialogSpectra.SelectedPath}\{fileNames(file)}")
                            Debug.WriteLine($"Will be download from here: {fileNamesServer(file)}")
                            client.DownloadFile(fileNamesServer(file), fileStream)
                            ProgressBarDwld.Value += 1
                            fileStream.Close()
                            LabelStatus.Text = "OK!"
                        End Using
                    Next
                    client.Disconnect()
                End Using

                If Not String.IsNullOrEmpty(missedFiles) Then
                    MessageBox.Show($"Эти файлы{vbCrLf}{missedFiles}{vbCrLf}не найдены. Возможно, они еще не загружены на сервер.", "Часть файлов не найдено", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Debug.WriteLine($"Missed files: {vbCrLf}{missedFiles}")
                    LabelStatus.Text = "Не все файлы были найдены!"
                Else
                    LabelStatus.Text = "Файлы успешно загружены!"
                    ProgressBarDwld.Value = 0
                End If

            End If
        Catch ex As Renci.SshNet.Common.SshOperationTimeoutException
            MsgBox("Timeout exceeded (30sec.)", MsgBoxStyle.Exclamation)
            LabelStatus.Text = "Ошибка подключения к FTP-серверу"
        Catch ex As Renci.SshNet.Common.SftpPathNotFoundException
            MsgBox("Запрашиваемый файл не найден. Возможно, спектры еще не перебросили или не набрали.", MsgBoxStyle.Exclamation)
            LabelStatus.Text += " - файл не найден"
        Catch ex As SqlException
            MsgBox($"Some problems with SQL-connection:\n{ex.Message}", MsgBoxStyle.Exclamation)
            LabelStatus.Text = "Ошибка получение данных аутентификации"
        End Try
    End Sub

    Sub GetPswd(ByRef host As String, ByRef usr As String, ByRef pswd As String)
        Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            sqlConnection1.Open()
            Using cmd As New System.Data.SqlClient.SqlCommand("select * from privinfo", sqlConnection1)
                Using reader = cmd.ExecuteReader()
                    reader.Read()
                    If reader.HasRows Then
                        usr = reader(0)
                        pswd = reader(1)
                        host = reader(2)
                    End If
                End Using
            End Using
            sqlConnection1.Close()
        End Using
    End Sub

    Function FormFinalFilesDict(ByVal type As String, ByRef gYear As String) As Dictionary(Of String, String)
        Debug.WriteLine("Started to form final files array:")
        LabelStatus.Text = "Формирование имен загружаемых файлов..."
        Dim finArr = New Dictionary(Of String, String)
        Dim finSrmsArr = New Dictionary(Of String, String)
        Dim typeFtp As New Dictionary(Of String, String)
        Dim dtStrCont As String = ""
        Dim dt As New DateTime()
        typeFtp.Add("КЖИ", "kji")
        typeFtp.Add("ДЖИ-1", "dji-1")
        typeFtp.Add("ДЖИ-2", "dji-2")
        Dim setKey As String = $"{LablelElSumCountryCode.Text}-{LabelElSumClientId.Text}-{LabelElSumYear.Text}-{LabelElSumSetId.Text}-{LabelElSumSetIndex.Text}"

        For Each row As DataGridViewRow In DataGridViewElsSum.Rows
            Dim cellFile As DataGridViewCell = row.Cells($"Файлы спектров {type}")
            If String.IsNullOrEmpty(cellFile.Value.ToString) Then Continue For
            Dim cellDate As DataGridViewCell = row.Cells($"{typeFtp(type)}-Date")
            If String.IsNullOrEmpty(cellDate.Value.ToString) Then Continue For
            dt = Convert.ToDateTime(cellDate.Value)
            If (Not dtStrCont.Contains($"{dt.ToShortDateString}-{row.Cells("Container_Number").Value}")) Then dtStrCont += $"'{dt.ToShortDateString}-{row.Cells("Container_Number").Value}',"

            If type.Contains("ДЖИ") Then
                Debug.WriteLine($"{setKey}\{typeFtp(type)}\c-{row.Cells("Container_Number").Value}\samples\{row.Cells($"Файлы спектров {type}").Value}.cnf")
                finArr.Add(row.Cells($"Файлы спектров {type}").Value, $"{setKey}\{typeFtp(type)}\c-{row.Cells("Container_Number").Value}\samples\{row.Cells($"Файлы спектров {type}").Value}.cnf")
            Else
                Debug.WriteLine($"{setKey}\{typeFtp(type)}\samples\{row.Cells($"Файлы спектров {type}").Value}.cnf")
                finArr.Add(row.Cells($"Файлы спектров {type}").Value, $"{setKey}\{typeFtp(type)}\samples\{row.Cells($"Файлы спектров {type}").Value}.cnf")
                GetRelatedSLISRMs(finSrmsArr, setKey, dt)
            End If
        Next

        If type.Contains("ДЖИ") Then
            GetRelatedLLISRMs(finSrmsArr, setKey, typeFtp(type), dtStrCont.Substring(0, dtStrCont.Length - 1))
        End If

        gYear = Convert.ToDateTime(DataGridViewElsSum.Rows(0).Cells($"{typeFtp(type)}-Date").Value).Year.ToString()
        Debug.WriteLine($"Guessed year: {gYear}")
        Return finArr.Union(finSrmsArr).ToDictionary(Function(p) p.Key, Function(p) p.Value)
    End Function

    Function FindFiles(ByRef names As Dictionary(Of String, String).KeyCollection, ByVal gYear As String) As Dictionary(Of String, String)
        Debug.WriteLine("Started to searching files")
        LabelStatus.Text = "Поиск файлов на сервере..."
        Dim fullFileName = New Dictionary(Of String, String)
        Dim user As String = ""
        Dim passw As String = ""
        Dim src As String = ""

        GetPswd(src, user, passw)

        Using client As New SshClient(src, 22, user, passw)
            client.Connect()
            Dim terminal As SshCommand ' = client.RunCommand($"cd Spectra")
            For Each name As String In names
                terminal = client.RunCommand($"find /home/FTP/Spectra/{gYear} -name {Path.GetFileNameWithoutExtension(name)}*")
                If String.IsNullOrEmpty(terminal.Result) Then terminal = client.RunCommand($"find /home/FTP/Spectra/ -name {Path.GetFileNameWithoutExtension(name)}*")
                If Not String.IsNullOrEmpty(terminal.Result) Then
                    fullFileName.Add(name, terminal.Result.Substring(0, terminal.Result.Length - 1)) 'delete \n
                    Debug.WriteLine($"The file was found - {fullFileName.Last}")
                Else
                    Debug.WriteLine($"The file was not found - {Path.GetFileNameWithoutExtension(name)}")
                End If
            Next
            client.Disconnect()
        End Using
        Return fullFileName
    End Function

    Sub GetQueryResult(ByRef srmarr As Dictionary(Of String, String), ByVal query As String)
        Debug.WriteLine("Send query to DB:")
        Debug.WriteLine(query)
        Debug.WriteLine("Query result is:")
        Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            sqlConnection1.Open()
            Using cmd As New System.Data.SqlClient.SqlCommand(query, sqlConnection1)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        If srmarr.ContainsKey(reader(0)) Then Continue While
                        srmarr.Add(reader(0), reader(1))
                        Debug.WriteLine($"{reader(0)}")
                    End While
                End Using
            End Using
            sqlConnection1.Close()
        End Using
    End Sub


    Sub GetRelatedLLISRMs(ByRef srmarr As Dictionary(Of String, String), ByVal setKey As String, ByVal type As String, ByVal dt As String)
        GetQueryResult(srmarr, $"select distinct  Measured_LLI_{type.Replace("dji-", "")}_By, '{setKey}\' +'{type}\'+ 'c-'+ CONVERT(varchar(2),Container_Number) +'\' + 'SRMs\' + Measured_LLI_{type.Replace("dji-", "")}_By + '.cnf' from table_LLI_Irradiation_Log where Client_ID = 's' and  CONVERT(varchar(10),Date_Measurement_LLI_{type.Replace("dji-", "")}) + '-' + CONVERT(varchar(1),Container_Number) in (select CONVERT(varchar(10),Date_Measurement_LLI_{type.Replace("dji-", "")}) + '-' + CONVERT(varchar(1),Container_Number) as date_con from table_LLI_Irradiation_Log where Country_Code + '-' + Client_ID + '-' + Year + '-' + Sample_Set_ID  + '-' + Sample_Set_Index = '{setKey}')")
    End Sub

    Sub GetRelatedSLISRMs(ByRef srmarr As Dictionary(Of String, String), ByVal setKey As String, ByVal dt As DateTime)
        GetQueryResult(srmarr, $"Select  distinct File_First, '{setKey}\kji\SRMs\' + File_First + '.cnf' from table_SLI_Irradiation_Log where Country_Code = 's' and Date_Start between (select max(DateStart) from IBR2MCycles where DateStart <= '{dt.ToShortDateString()}') and (select min(DateFinish) from IBR2MCycles where DateFinish >= '{dt.ToShortDateString()}') and File_First is not null")
    End Sub

    'TODO implement interface with datarow
    'TODO split srm and sample in different functions
    'TODO implement this function with taking into account that you should also download spectra by selected datagridrows is journals forms

    Sub ClearProgressBarAndStatusLabel()
        LabelStatus.Text = ""
        ProgressBarDwld.Value = 0
    End Sub

    Private Sub ClearProgressBarAndStatusLabel(sender As Object, e As EventArgs) Handles RadioButtonDFSLI.CheckedChanged, RadioButtonDFLLI2.CheckedChanged, RadioButtonDFLLI1.CheckedChanged
        ClearProgressBarAndStatusLabel()
    End Sub




End Class

