Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class Form_NAA_Results
    Public HidColumnsDict As New Dictionary(Of Integer, String)
    Public colorNames As New Dictionary(Of Integer, ClosedXML.Excel.XLColor)
    Private Sub Form_NAA_Results_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Samples_List.Enabled = True
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub B_Fill_In_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_From_File.Click
        Try
            If OpenFileDialog_Fill_In_From_File_NAA_Results.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите файл!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select file!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else

                Using workbook As New ClosedXML.Excel.XLWorkbook(OpenFileDialog_Fill_In_From_File_NAA_Results.FileName)

                    Dim workSheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet(1)
                    Dim dti As New DataTable

                    Dim StartColumn As Integer = 6 'start column for final table
                    Dim StartRow As Integer = 4 ' start row for final table
                    Dim ColumnForCountingNumber As Integer = 3 ' columns with headers such as Conc,... in final table 
                    Dim StartColumnForCounting As Integer = 6 ' columns with non empty value in final table
                    Dim cntRows As Integer = 0
                    If workSheet.Row(2).Cell(1).Value = "sample" Then
                        StartRow = 3 ' start row for final report
                        StartColumn = 9 'start column for final report
                        ColumnForCountingNumber = 2 ' columns with headers such as Conc,... in final report
                        StartColumnForCounting = 0
                    End If
                    Dim cntColumns As Integer = 0

                    ' doesnt work for finaltable
                    ' cntRows = workSheet.LastRowUsed.RowNumber 
                    ' cntColumns = workSheet.LastColumnUsed.ColumnNumber

                    For Each row As ClosedXML.Excel.IXLRow In workSheet.Rows()
                        If cntRows >= StartRow And row.Cell(1).Value = "" Then Exit For
                        cntRows += 1
                    Next

                    cntRows = cntRows - StartRow 'we have displacment in excel from 0,0

                    If cntRows <= 0 Then Debug.WriteLine("File doesn't contain data")
                    For Each column As ClosedXML.Excel.IXLColumn In workSheet.Columns()
                        If workSheet.Row(ColumnForCountingNumber).Cell(StartColumnForCounting + cntColumns + 1).Value.ToString <> "" Then
                            cntColumns += 1
                        Else
                            Exit For
                        End If
                    Next
                    cntColumns += StartColumnForCounting


                    Debug.WriteLine($"StartRow - {StartRow}{vbCrLf}cntRows - {cntRows}{vbCrLf}StartColumn - {StartColumn}{vbCrLf}cntColumns - {cntColumns}")
                    Dim elem As String = ""

                    dti.Columns.Add("Номер образца", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(0).ValueType)
                    dti.Columns.Add("Клиентский № образца", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(1).ValueType)
                    dti.Columns.Add("Место сбора", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(2).ValueType)
                    dti.Columns.Add("Широта", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(3).ValueType)
                    dti.Columns.Add("Долгота", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(4).ValueType)
                    dti.Columns.Add("Заметки", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(5).ValueType)
                    dti.Columns.Add("Файлы спектров", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(6).ValueType)
                    dti.Columns.Add("Обработано", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(7).ValueType)

                    For i = StartColumn To cntColumns
                        If i Mod 3 = 0 Then
                            elem = workSheet.Row(1).Cell(i).Value & ", "
                        End If

                        If workSheet.Row(StartRow - 1).Cell(i).Value = "Conc, ug/g" Then
                            dti.Columns.Add(elem & "концентрация, uгр/гр", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(9).ValueType)
                        ElseIf workSheet.Row(StartRow - 1).Cell(i).Value = "Err, %" Then
                            dti.Columns.Add(elem & "погрешность, %", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(10).ValueType)
                        ElseIf workSheet.Row(StartRow - 1).Cell(i).Value = "MDC, ug/g" Then
                            dti.Columns.Add(elem & "предел обнаружения, uгр/гр", DataGridView_Table_Sample_NAA_Results.Rows(0).Cells(11).ValueType)
                        End If
                    Next

                    Debug.WriteLine($"Temp table columns count is {dti.Columns.Count}")

                    Dim bodyRng = workSheet.Range(StartRow - 1, 1, cntRows, cntColumns)

                    If StartRow = 3 Then
                        For rown As Integer = 0 To cntRows
                            dti.Rows.Add()
                            For coln As Integer = 0 To cntColumns - 1
                                If workSheet.Row(rown + StartRow).Cell(coln + 1).Value.ToString = "" Then
                                    dti.Rows(rown)(coln) = DBNull.Value
                                Else
                                    dti.Rows(rown)(coln) = workSheet.Row(rown + StartRow).Cell(coln + 1).Value
                                End If
                            Next
                        Next
                    Else

                        Dim tempstr As String = ""
                        Dim filespect As String = ""

                        For rown As Integer = 0 To cntRows
                            dti.Rows.Add()
                            For coln As Integer = 0 To 7
                                If coln = 6 Then
                                    For n As Integer = 2 To 5
                                        tempstr = Path.GetFileNameWithoutExtension(workSheet.Row(rown + StartRow).Cell(n).Value)
                                        If tempstr = "" Then
                                            tempstr = "-------"
                                        End If
                                        filespect += tempstr + ","
                                    Next
                                    ' Debug.WriteLine((rown + 4).ToString & "  " & tempstr)
                                    dti.Rows(rown)(coln) = filespect.Substring(0, filespect.Length - 1)
                                    filespect = ""
                                Else
                                    ' MsgBox(DataGridView_Table_Sample_NAA_Results.Rows(rown).Cells(coln).Value
                                    ' Debug.WriteLine(DataGridView_Table_Sample_NAA_Results.Rows(rown).Cells(coln).Value)
                                    dti.Rows(rown)(coln) = DataGridView_Table_Sample_NAA_Results.Rows(rown).Cells(coln).Value
                                    ' MsgBox(dti.Rows(rown)(coln))
                                End If
                            Next
                        Next
                        For rown As Integer = 0 To cntRows
                            For coln As Integer = 8 To dti.Columns.Count - 1
                                If workSheet.Row(rown + StartRow).Cell(coln - 2).Value.ToString = "" Then
                                    dti.Rows(rown)(coln) = DBNull.Value
                                Else
                                    dti.Rows(rown)(coln) = workSheet.Row(rown + StartRow).Cell(coln - 2).Value
                                End If
                            Next
                        Next

                    End If

                    Dim dt As New DataTable()

                    For Each column As DataGridViewColumn In DataGridView_Table_Sample_NAA_Results.Columns
                        If dti.Columns.Contains(column.HeaderText) Then
                            For k As Integer = 0 To dti.Rows.Count - 1
                                DataGridView_Table_Sample_NAA_Results.Rows(k).Cells(column.Index).Value = dti(k)(dti.Columns.IndexOf(column.HeaderText))
                            Next
                        End If

                    Next
                    ComboBox_Person.Text = dti(0)(7).ToString
                    dti.Clear()

                End Using
            End If

        Catch ex As System.IO.IOException
            If Form_Main.language = "Русский" Then
                MsgBox("Файл уже открыт. Закройте его.", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The file Is Using. Please, Close it.", MsgBoxStyle.Critical, Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Enabled = True
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_From_File_Click)!", MsgBoxStyle.Critical, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Fill_In_From_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
    Private Sub Form_NAA_Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "select distinct a.R_Processed_By from SamplesSetForNaaDB as a ORDER BY a.R_Processed_By"
            'cmd.CommandText = "SELECT * FROM table_Received_By ORDER BY Received_By"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then ComboBox_Person.Items.Add(reader(0))

            End While
            sqlConnection1.Close()

            If Form_Main.language = "Русский" Then
                Me.Text = "Результаты НАА"

                L_Name_Code.Text = "Страна-Клиент-Год-№ парт.-Инд. парт."

                L_Name_Person.Text = "ФИО"


                cmd.CommandText = "select distinct Обработано from NaaRes where F_Country_Code = '" & Form_Samples_List.L_SS_Country_Code.Text & "' and F_Client_ID = '" & Form_Samples_List.L_SS_Client_ID.Text & "' and F_YEAR = '" & Form_Samples_List.L_SS_Year.Text & "' and F_Sample_Set_ID = '" & Form_Samples_List.L_SS_Sample_Set_ID.Text & "' and F_Sample_Set_index = '" & Form_Samples_List.L_SS_Sample_Set_Index.Text & "'"

                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        ComboBox_Person.Text = reader(0)
                        ComboBox_Person_SelectedValueChanged(sender, e)
                    End If

                End While
                sqlConnection1.Close()

                B_Fill_In_From_File.Text = "Заполнить из файла"
                Clear_Table.Text = "Очистить таблицу"
                B_Save.Text = "Сохранить в БД"
                B_Save_Final_Report.Text = "Сохранить финальный отчёт"
                B_Close.Text = "Закрыть"

                OpenFileDialog_Fill_In_From_File_NAA_Results.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
                SaveFileDialog_Final_Report.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "NAA results"

                L_Name_Code.Text = "Country-Client-Year-Set ID-Set index"

                L_Name_Person.Text = "Person"

                B_Fill_In_From_File.Text = "Fill in from file"
                Clear_Table.Text = "Clear table"
                B_Save.Text = "Save into DB"
                B_Save_Final_Report.Text = "Save final report"
                B_Close.Text = "Close"


                OpenFileDialog_Fill_In_From_File_NAA_Results.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                SaveFileDialog_Final_Report.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"



            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_NAA_Results_Load)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_NAA_Results_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save.Click

        Try
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "update  table_Sample set  R_Processed_By = '" & DataGridView_Table_Sample_NAA_Results.Rows.Item(0).Cells.Item(7).Value & "' where F_Country_Code = '" & L_SS_Country_Code.Text & "' and F_Client_ID = '" & L_SS_Client_ID.Text & "' and F_YEAR = '" & L_SS_Year.Text & "' and F_Sample_Set_ID = '" & L_SS_Sample_Set_ID.Text & "' and F_Sample_Set_index = '" & L_SS_Sample_Set_Index.Text & "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            Dim where As String = " where F_Country_Code = '" & L_SS_Country_Code.Text & "' and F_Client_ID = '" & L_SS_Client_ID.Text & "' and F_YEAR = '" & L_SS_Year.Text & "' and F_Sample_Set_ID = '" & L_SS_Sample_Set_ID.Text & "' and F_Sample_Set_index = '" & L_SS_Sample_Set_Index.Text & "' and [Номер образца] = '"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()

            Dim queryBody As String = ""

            For j As Integer = 0 To DataGridView_Table_Sample_NAA_Results.RowCount - 1
                For Each column As DataGridViewColumn In DataGridView_Table_Sample_NAA_Results.Columns
                    If column.Index >= 8 Then
                        If DataGridView_Table_Sample_NAA_Results.Rows(j).Cells(column.Index).Value.ToString = "" Then
                            queryBody += "[" & column.HeaderText & "]" & " = " & "null"
                        Else
                            queryBody += "[" & column.HeaderText & "]" & " = " & DataGridView_Table_Sample_NAA_Results.Rows(j).Cells(column.Index).Value.ToString.Replace(",", ".")
                        End If
                        If column.Index <> DataGridView_Table_Sample_NAA_Results.Columns.Count - 1 Then
                            queryBody += ","
                        End If
                    ElseIf column.Index = 6 Then
                        If DataGridView_Table_Sample_NAA_Results.Rows(j).Cells(column.Index).Value.ToString = "" Then
                            queryBody += "[" & column.HeaderText & "]" & " = " & "null"
                        Else
                            queryBody += "[" & column.HeaderText & "]" & " = '" & DataGridView_Table_Sample_NAA_Results.Rows(j).Cells(column.Index).Value.ToString & "'"
                        End If
                        If column.Index <> DataGridView_Table_Sample_NAA_Results.Columns.Count - 1 Then
                            queryBody += ","
                        End If

                    End If

                Next
                If queryBody <> "" Then
                    cmd.CommandText = "update NaaRes set " & queryBody & where & DataGridView_Table_Sample_NAA_Results.Rows(j).Cells(0).Value.ToString & "'"
                    cmd.ExecuteNonQuery()
                End If
                queryBody = ""
            Next
            sqlConnection1.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Clear_Table_Click(sender As System.Object, e As System.EventArgs) Handles Clear_Table.Click
        Try

            For k = 0 To DataGridView_Table_Sample_NAA_Results.Rows.Count - 1
                DataGridView_Table_Sample_NAA_Results.Rows.Item(k).Cells.Item(6).Value = DBNull.Value 'file spectrum
                DataGridView_Table_Sample_NAA_Results.Rows.Item(k).Cells.Item(7).Value = DBNull.Value 'ФИО
                For i = 8 To DataGridView_Table_Sample_NAA_Results.Columns.Count - 1
                    DataGridView_Table_Sample_NAA_Results.Rows.Item(k).Cells.Item(i).Value = DBNull.Value
                Next
            Next
            ComboBox_Person.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Clear_Table_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Clear_Table_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox_Person_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_Person.SelectedValueChanged
        Try

            For k = 0 To DataGridView_Table_Sample_NAA_Results.Rows.Count - 1
                If DataGridView_Table_Sample_NAA_Results.Rows.Item(k).Cells.Item(7).Value = "" Then
                    DataGridView_Table_Sample_NAA_Results.Rows.Item(k).Cells.Item(7).Value += ComboBox_Person.Text
                Else
                    DataGridView_Table_Sample_NAA_Results.Rows.Item(k).Cells.Item(7).Value += ";" & ComboBox_Person.Text
                End If

            Next
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_Person_SelectedValueChanged)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in ComboBox_Person_SelectedValueChanged)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Save_Final_Report_Click(sender As System.Object, e As System.EventArgs) Handles B_Save_Final_Report.Click
        Try
            Dim DI As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\CONFILES\")
            If DI.Exists Then
            Else
                MkDir("C:\GENIE2K\CONFILES\")
            End If
            SaveFileDialog_Final_Report.InitialDirectory = "C:\GENIE2K\CONFILES\"
            SaveFileDialog_Final_Report.FileName = "Final_report_" + L_SS_Country_Code.Text + "-" + L_SS_Client_ID.Text + "-" + L_SS_Year.Text + "-" + L_SS_Sample_Set_ID.Text + "-" + L_SS_Sample_Set_Index.Text + ".xlsx"
            If SaveFileDialog_Final_Report.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                Me.Enabled = False

                Dim dt As New DataTable()
                Dim contNum As Integer = 1
                Dim finish, len As Integer
                len = 0
                finish = 0

                For Each column As DataGridViewColumn In DataGridView_Table_Sample_NAA_Results.Columns
                    dt.Columns.Add(column.HeaderText, column.ValueType)
                Next


                For Each row As DataGridViewRow In DataGridView_Table_Sample_NAA_Results.Rows
                    dt.Rows.Add()
                    For Each cell As DataGridViewCell In row.Cells
                        dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value
                    Next
                Next

                If HidColumnsDict.Keys.Count = 0 Then
                    HidElemCalc()
                End If


                For Each Key In HidColumnsDict.Keys

                    dt.Columns.Remove(HidColumnsDict(Key))
                Next

                HidColumnsDict.Clear()

                colorNames.Add(40, ClosedXML.Excel.XLColor.SkyBlue)
                colorNames.Add(47, ClosedXML.Excel.XLColor.Tan)

                Dim inum As Integer = 1
                Using wb As New ClosedXML.Excel.XLWorkbook()
                    Dim ws = wb.Worksheets.Add(L_SS_Country_Code.Text + "-" + L_SS_Client_ID.Text + "-" + L_SS_Year.Text + "-" + L_SS_Sample_Set_ID.Text + "-" + L_SS_Sample_Set_Index.Text)
                    ws.Cell(3, 1).InsertData(dt.AsEnumerable())


                    Dim HeadersString As String = "sample,client sample ID,collection place,latitude,longitude,notes,files spectrum,processed by"
                    Dim i As Integer = 1
                    For Each word In HeadersString.Split(",")
                        ws.Cell(2, i).Value() = word
                        i += 1
                    Next


                    For j As Integer = 9 To dt.Columns.Count - 1
                        ' объединим три ячейки для элемента в заголовке
                        If j Mod 3 = 0 Then
                            ws.Range(1, j, 1, (j + 2)).Cell(1, 1).Value = dt.Columns(j).ColumnName.Split(",")(0)
                            ws.Range(1, j, 1, (j + 2)).Merge()
                            ws.Range(1, j, 1, (j + 2)).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                        End If
                        ' изменение названия в подзаголовке  величин
                        If dt.Columns(j - 1).ColumnName.Split(",")(1) = " концентрация" Then
                            ws.Cell(2, j).Value = "Conc, ug/g"
                        ElseIf dt.Columns(j - 1).ColumnName.Split(",")(1) = " погрешность" Then
                            ws.Cell(2, j).Value = "Err, %"
                        ElseIf dt.Columns(j - 1).ColumnName.Split(",")(1) = " предел обнаружения" Then
                            ws.Cell(2, j).Value = "MDC, ug/g"
                        End If
                        ' закраска с чередованием по три столбца
                        If inum <= 3 And j <> dt.Columns.Count - 1 Then
                            ws.Range(1, j, dt.Rows.Count + 2, (j + 3)).Style.Fill.BackgroundColor = colorNames(47)
                        ElseIf inum >= 3 And inum <= 7 And j <> dt.Columns.Count - 1 Then
                            ws.Range(1, j, dt.Rows.Count + 2, (j + 3)).Style.Fill.BackgroundColor = colorNames(40)

                        End If
                        inum += 1
                        If inum = 7 Then inum = 1

                    Next

                    If dt.Columns.Count > 8 Then
                        ws.Cell(2, dt.Columns.Count).Value = "MDC, ug/g"
                        ws.Range(1, dt.Columns.Count + 1, dt.Rows.Count + 2, dt.Columns.Count + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.NoColor
                    End If


                    Dim rngbord = ws.Range(1, 1, dt.Rows.Count + 2, dt.Columns.Count)
                    rngbord.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    rngbord.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    rngbord.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                    ws.Columns().Style.Alignment.WrapText = True
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(SaveFileDialog_Final_Report.FileName)
                End Using
            End If
            Me.Close()
        Catch ex As Exception
            Me.Enabled = True
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Save_Final_Report_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Save_Final_Report_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub




    Private Sub CBCol0_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBCol0.CheckedChanged
        If CBCol0.Checked = False Then
            DataGridView_Table_Sample_NAA_Results.Columns(1).Visible = True
        Else
            DataGridView_Table_Sample_NAA_Results.Columns(1).Visible = False
        End If
    End Sub

    Private Sub CBCol1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBCol1.CheckedChanged
        If CBCol1.Checked = False Then
            DataGridView_Table_Sample_NAA_Results.Columns(2).Visible = True
        Else
            DataGridView_Table_Sample_NAA_Results.Columns(2).Visible = False
        End If
    End Sub

    Private Sub CBCol2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBCol2.CheckedChanged
        If CBCol2.Checked = False Then
            DataGridView_Table_Sample_NAA_Results.Columns(3).Visible = True
        Else
            DataGridView_Table_Sample_NAA_Results.Columns(3).Visible = False
        End If
    End Sub

    Private Sub CBCol3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBCol3.CheckedChanged
        If CBCol3.Checked = False Then
            DataGridView_Table_Sample_NAA_Results.Columns(4).Visible = True
        Else
            DataGridView_Table_Sample_NAA_Results.Columns(4).Visible = False
        End If
    End Sub

    Private Sub CBCol4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBCol4.CheckedChanged
        If CBCol4.Checked = False Then
            DataGridView_Table_Sample_NAA_Results.Columns(5).Visible = True
        Else
            DataGridView_Table_Sample_NAA_Results.Columns(5).Visible = False
        End If
    End Sub

    Private Sub CBCol5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBCol5.CheckedChanged
        If CBCol5.Checked = False Then
            DataGridView_Table_Sample_NAA_Results.Columns(6).Visible = True
        Else
            DataGridView_Table_Sample_NAA_Results.Columns(6).Visible = False
        End If
    End Sub

    Private Sub CBHideAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBHideAll.CheckedChanged
        If CBHideAll.Checked = False Then

            For n As Integer = 1 To 6
                DataGridView_Table_Sample_NAA_Results.Columns(n).Visible = True
            Next
            CBCol0.Checked = False
            CBCol1.Checked = False
            CBCol2.Checked = False
            CBCol3.Checked = False
            CBCol4.Checked = False
            CBCol5.Checked = False
        Else
            For n As Integer = 1 To 6
                DataGridView_Table_Sample_NAA_Results.Columns(n).Visible = False

            Next
            CBCol0.Checked = True
            CBCol1.Checked = True
            CBCol2.Checked = True
            CBCol3.Checked = True
            CBCol4.Checked = True
            CBCol5.Checked = True
        End If
    End Sub

    Public groupsElem As New Dictionary(Of Integer, ArrayList)

    Sub HidElemCalc()
        groupsElem.Clear()
        For i As Integer = 8 To DataGridView_Table_Sample_NAA_Results.ColumnCount - 1
            Dim nums As New ArrayList
            For j As Integer = 0 To 2
                nums.Add(i + j)
            Next
            groupsElem.Add(i, nums)
            i += 2
        Next

        Dim allcellsum As String = ""

        HidColumnsDict.Clear()

        For Each key In groupsElem.Keys

            For Each value In groupsElem(key)
                For i As Integer = 0 To DataGridView_Table_Sample_NAA_Results.RowCount - 1
                    allcellsum = allcellsum & DataGridView_Table_Sample_NAA_Results.Rows(i).Cells(value).Value.ToString
                Next
            Next

            If allcellsum = "" Then
                For Each value In groupsElem(key)
                    HidColumnsDict(value) = DataGridView_Table_Sample_NAA_Results.Columns(value).HeaderText

                Next
            End If
            allcellsum = ""
        Next

    End Sub

    Private Sub HidEmptEl_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles HidEmptEl.CheckedChanged

        HidElemCalc()

        If HidEmptEl.Checked = True Then
            For Each elem In HidColumnsDict.Keys
                DataGridView_Table_Sample_NAA_Results.Columns(elem).Visible = False
            Next
        Else
            For Each elem In HidColumnsDict.Keys
                DataGridView_Table_Sample_NAA_Results.Columns(elem).Visible = True
            Next
        End If


    End Sub

    Public Sub ColorizeAll()
        Debug.WriteLine($"It's in background")

        Dim inum As Integer = 1
        For j As Integer = 24 To DataGridView_Table_Sample_NAA_Results.Columns.Count - 1
            Debug.WriteLine(j)
            DataGridView_Table_Sample_NAA_Results.Columns(j).SortMode = DataGridViewColumnSortMode.NotSortable
            If inum <= 3 Then
                DataGridView_Table_Sample_NAA_Results.Columns(j).DefaultCellStyle.BackColor = Color.SkyBlue
            Else
                DataGridView_Table_Sample_NAA_Results.Columns(j).DefaultCellStyle.BackColor = Color.Tan
            End If
            inum += 1
            If inum = 7 Then inum = 1

        Next
    End Sub

    Private Sub BackgroundWorkerNaaResults_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerNaaResults.DoWork
        ColorizeAll()
    End Sub
End Class