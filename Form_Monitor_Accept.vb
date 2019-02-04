Imports System.Data.SqlClient

Public Class Form_Monitor_Accept
    Private Sub Form_Monitor_Accept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Try
                If Form_Main.language = "Русский" Then
                    Me.Text = "Список мониторов"

                    L_Name_Monitor_Set_Name.Text = "Имя партии мониторов"
                    L_Name_Monitor_Set_Number.Text = "Номер партии мониторов"
                    L_Name_Monitor_Set_Weight.Text = "Вес партии мониторов, гр"
                    L_Name_Weight_Balance.Text = "Баланс веса, гр"

                    B_Fill_Monitor_From_File.Text = "Заполнить вес мониторов из файла"
                    B_Close.Text = "Закрыть"

                    OpenFileDialog_Weighting_SLI_LLI.Filter = "Весовые файлы (*.ves)|*.ves|Все файлы (*.*)|*.*"
                ElseIf Form_Main.language = "English" Then
                    Me.Text = "Monitors list"

                    L_Name_Monitor_Set_Name.Text = "Monitor set name"
                    L_Name_Monitor_Set_Number.Text = "Monitor set number"
                    L_Name_Monitor_Set_Weight.Text = "Weight of monitors set, g"
                    L_Name_Weight_Balance.Text = "Weight balance, g"

                    B_Fill_Monitor_From_File.Text = "Fill in monitors weight from file"
                    B_Close.Text = "Close"

                    OpenFileDialog_Weighting_SLI_LLI.Filter = "Files of weight (*.ves)|*.ves|All files (*.*)|*.*"
                End If

                With Table_Monitor_DataGridView
                    Dim g As Graphics = .CreateGraphics()
                    Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))
                    .Columns.Clear()

                    If Form_Main.language = "Русский" Then
                        .Columns.Add("Monitor_Number", "№ монитора")
                    ElseIf Form_Main.language = "English" Then
                        .Columns.Add("Monitor_Number", "Monitor number")
                    End If
                    .Columns(0).DataPropertyName = "Monitor_Number" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                    .Columns(0).ReadOnly = True
                    .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("монитора", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                    If Form_Main.language = "Русский" Then
                        .Columns.Add("Monitor_SLI_Weight", "Вес КЖИ, гр")
                    ElseIf Form_Main.language = "English" Then
                        .Columns.Add("Monitor_SLI_Weight", "SLI weight, g")
                    End If
                    .Columns(1).DataPropertyName = "Monitor_SLI_Weight"
                    .Columns(1).ReadOnly = True
                    .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("weight, g", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                    If Form_Main.language = "Русский" Then
                        .Columns.Add("Monitor_LLI_Weight", "Вес ДЖИ, гр")
                    ElseIf Form_Main.language = "English" Then
                        .Columns.Add("Monitor_LLI_Weight", "LLI weight, g")
                    End If
                    .Columns(2).DataPropertyName = "Monitor_LLI_Weight"
                    .Columns(2).ReadOnly = True
                    .Columns(2).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("weight, g", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                    '.Columns.Clear()
                    '.Columns.AddRange(Monitor_Number, Monitor_SLI_Weight, Monitor_LLI_Weight) ' это делается, т.к. после загрузки VB добавляются все столбцы

                    'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor". При необходимости она может быть перемещена или удалена.
                    Table_MonitorTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                    Me.Table_MonitorTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value)

                    If .RowCount > 0 Then
                        .FirstDisplayedScrollingRowIndex = .RowCount - 1
                        For i = 0 To .RowCount - 1
                            .Rows.Item(i).Selected = False
                        Next
                        .Rows.Item(.RowCount - 1).Selected = True
                    End If
                End With
            Catch ex As Exception
                If Form_Main.language = "Русский" Then
                    MsgBox("Операция была отменена (ошибка в Form_Monitor_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
                End If
                Me.Close()
                Exit Sub
            End Try

            Dim weight_Monitor_Sum, weight_Monitor_Set As Single
            weight_Monitor_Sum = 0
            weight_Monitor_Set = 0

            Try
                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "SELECT Monitor_Set_Weight FROM dbo.table_Monitor_Set WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                    "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    weight_Monitor_Set = reader(0)
                End While
                sqlConnection1.Close()
            Catch ex As Exception
                If Form_Main.language = "Русский" Then
                    MsgBox("Операция была отменена (ошибка в Form_Monitor_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
                End If
                Me.Close()
                Exit Sub
            End Try

            If Table_Monitor_DataGridView.RowCount > 0 Then
                Try
                    Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                    Dim reader As SqlDataReader
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "SELECT Monitor_SLI_Weight, Monitor_LLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                        "' and Monitor_Set_Number=" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ""
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If IsDBNull(reader(0)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(0)
                        If IsDBNull(reader(1)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(1)
                    End While
                    sqlConnection1.Close()
                Catch ex As Exception
                    If Form_Main.language = "Русский" Then
                        MsgBox("Операция была отменена (ошибка в Form_Monitor_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
                    End If
                    Me.Close()
                    Exit Sub
                End Try
            End If

            L_Weight_Balance.Text = (weight_Monitor_Set - weight_Monitor_Sum).ToString
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Monitor_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Try
            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Monitor_Accept_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Monitor_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_Monitor_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_SLI_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim array_length_VES As Integer
            Dim Samples_Names(,) As String
            Dim Samples_Weights(,) As Single
            Dim Correct_Name As String
            Dim row_count As Integer
            Dim currentRow As String
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            Dim weight_Monitor_Sum, weight_Monitor_Set As Single
            weight_Monitor_Sum = 0
            weight_Monitor_Set = 0

            OpenFileDialog_Weighting_SLI_LLI.InitialDirectory = "C:\"
            Correct_Name = Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString + "-" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "_kji.ves"
            Correct_Name = Correct_Name.ToUpper
            OpenFileDialog_Weighting_SLI_LLI.FileName = Correct_Name
            ''OpenDialog_Aktivn_Stand_Obr.FileName:="" не разкомментировать, иначе будут ошибки!
            If OpenFileDialog_Weighting_SLI_LLI.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                MsgBox("Select weighting file!")
                Exit Sub
            Else
                If OpenFileDialog_Weighting_SLI_LLI.SafeFileName.ToUpper <> Correct_Name Then
                    If MessageBox.Show("Not valid file name! Resume?", "Warning!", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        GoTo 1
                    Else
                        Exit Sub
                    End If
                End If

1:              array_length_VES = 0
                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Weighting_SLI_LLI.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(" ")

                    currentRow = ""
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If currentRow = "индекс имя К Ж И Д Ж И" Then
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ")
                            End While
                            If currentRow = "пробы образца (в г) (в г)" Then
                                currentRow = MyReader.ReadLine
                                currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                While InStr(currentRow, "--") > 0
                                    currentRow = Replace(currentRow, "--", "-")
                                End While
                                If currentRow = "-" Then
                                    'MessageBox.Show("Похоже, правильный формат файла активностей исследуемого образца!")
                                    currentRow = MyReader.ReadLine
a1:                                 array_length_VES = array_length_VES + 1
                                    currentRow = MyReader.ReadLine
                                    If currentRow <> "" Then GoTo a1
                                End If
                            End If
                        End If
                    End While
                End Using

                ReDim Samples_Names(array_length_VES, 1)
                ReDim Samples_Weights(array_length_VES, 1)

                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Weighting_SLI_LLI.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(" ")

                    currentRow = ""
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If currentRow = "индекс имя К Ж И Д Ж И" Then
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ")
                            End While
                            If currentRow = "пробы образца (в г) (в г)" Then
                                currentRow = MyReader.ReadLine
                                currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                While InStr(currentRow, "--") > 0
                                    currentRow = Replace(currentRow, "--", "-")
                                End While
                                If currentRow = "-" Then
                                    'MessageBox.Show("Похоже, правильный формат файла активностей исследуемого образца!")

                                    row_count = 0
                                    currentRow = MyReader.ReadLine
b1:                                 currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                    While InStr(currentRow, "  ") > 0
                                        currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                                    End While
                                    If currentRow(currentRow.Count - 1) <> " " Then currentRow = currentRow + " " 'добавляем пробел в конец строки
                                    Samples_Names(row_count, 0) = Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) 'индекс пробы - первое слово до пробела
                                    currentRow = Replace(currentRow, Samples_Names(row_count, 0) + " ", "", , 1, )
                                    Samples_Names(row_count, 1) = Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) 'имя образца - первое слово до пробела
                                    currentRow = Replace(currentRow, Samples_Names(row_count, 1) + " ", "", , 1, )
                                    Samples_Weights(row_count, 0) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))
                                    currentRow = Replace(currentRow, Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) + " ", "")
                                    Samples_Weights(row_count, 1) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))

                                    row_count = row_count + 1
                                    currentRow = MyReader.ReadLine
                                    If currentRow <> "" Then GoTo b1
                                End If
                            End If
                        End If
                    End While
                End Using

                For i = 0 To row_count - 1
                    cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                        "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                        "' and Monitor_Number='" + Samples_Names(i, 1).ToString + "'"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()

                        If reader(0) = 0 Then 'строчки нет
                            sqlConnection1.Close()
                            cmd.CommandText = "INSERT dbo.table_Monitor (Monitor_Set_Name, Monitor_Set_Number, Monitor_Set_Weight, Monitor_Number, Monitor_SLI_Weight) VALUES ('" +
                                 Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString + "', " +
                                 Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ", " +
                                 Replace(Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(3).Value.ToString, ",", ".") + ", " +
                                 Samples_Names(i, 1).ToString + ", " + Replace(Samples_Weights(i, 0).ToString, ",", ".") + ")"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            cmd.ExecuteNonQuery()
                            sqlConnection1.Close()
                            GoTo c1

                        Else 'строчка есть
                            sqlConnection1.Close()
                            cmd.CommandText = "SELECT Monitor_SLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                        "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                        "' and Monitor_Number='" + Samples_Names(i, 1).ToString + "'"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            reader = cmd.ExecuteReader()
                            While reader.Read()
                                If IsDBNull(reader(0)) = True Then 'строчка нет, но SLI=NULL
                                    sqlConnection1.Close()
                                    cmd.CommandText = "UPDATE table_Monitor SET Monitor_SLI_Weight=" + Replace(Samples_Weights(i, 0).ToString, ",", ".") + " WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                                                                     "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                                                                     "' and Monitor_Number='" + Samples_Names(i, 1).ToString + "'"
                                    cmd.Connection = sqlConnection1
                                    sqlConnection1.Open()
                                    cmd.ExecuteNonQuery()
                                    sqlConnection1.Close()
                                    GoTo c1
                                End If
                            End While
                        End If
                    End While
                    sqlConnection1.Close()
c1:             Next
            End If

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor". При необходимости она может быть перемещена или удалена.
            Table_MonitorTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_MonitorTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value)

            If Table_Monitor_DataGridView.RowCount > 0 Then
                Table_Monitor_DataGridView.FirstDisplayedScrollingRowIndex = Table_Monitor_DataGridView.RowCount - 1
                For i = 0 To Table_Monitor_DataGridView.RowCount - 1
                    Table_Monitor_DataGridView.Rows.Item(i).Selected = False
                Next
                Try
                    Table_Monitor_DataGridView.Rows.Item(Table_Monitor_DataGridView.RowCount - 1).Selected = True
                Catch ex As Exception
                End Try
            End If

            cmd.CommandText = "SELECT Monitor_Set_Weight FROM dbo.table_Monitor_Set WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                weight_Monitor_Set = reader(0)
            End While
            sqlConnection1.Close()

            If Table_Monitor_DataGridView.RowCount > 0 Then
                cmd.CommandText = "SELECT Monitor_SLI_Weight, Monitor_LLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                    "' and Monitor_Set_Number=" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ""
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If IsDBNull(reader(0)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(0)
                    If IsDBNull(reader(1)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(1)
                End While
                sqlConnection1.Close()
            End If
            L_Weight_Balance.Text = (weight_Monitor_Set - weight_Monitor_Sum).ToString
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_SLI_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Fill_SLI_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    '    Private Sub B_Fill_LLI_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim array_length_VES As Integer
    '            Dim Samples_Names(,) As String
    '            Dim Samples_Weights(,) As Single
    '            Dim row_count As Integer
    '            Dim currentRow As String
    '            Dim correct_name As String
    '            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
    '            Dim reader As SqlDataReader
    '            Dim cmd As New System.Data.SqlClient.SqlCommand
    '            cmd.CommandType = System.Data.CommandType.Text
    '            Dim weight_Monitor_Sum, weight_Monitor_Set As Single
    '            weight_Monitor_Sum = 0
    '            weight_Monitor_Set = 0

    '            OpenFileDialog_Weighting_SLI_LLI.InitialDirectory = "C:\"
    '            correct_name = Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString + "-" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "_dji.ves"
    '            correct_name = correct_name.ToUpper
    '            OpenFileDialog_Weighting_SLI_LLI.FileName = correct_name
    '            ''OpenDialog_Aktivn_Stand_Obr.FileName:="" не разкомментировать, иначе будут ошибки!
    '            If OpenFileDialog_Weighting_SLI_LLI.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
    '                MsgBox("Select weighting file!")
    '                Exit Sub
    '            Else
    '                If OpenFileDialog_Weighting_SLI_LLI.SafeFileName.ToUpper <> correct_name Then
    '                    If MessageBox.Show("Not valid file name! Resume?", "Warning!", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
    '                        GoTo 2
    '                    Else
    '                        Exit Sub
    '                    End If
    '                End If
    '2:              array_length_VES = 0
    '                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog_Weighting_SLI_LLI.FileName, System.Text.Encoding.Default)
    '                    MyReader.TextFieldType = FileIO.FieldType.Delimited
    '                    MyReader.SetDelimiters(" ")

    '                    currentRow = ""
    '                    While Not MyReader.EndOfData
    '                        currentRow = MyReader.ReadLine
    '                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                        While InStr(currentRow, "  ") > 0
    '                            currentRow = Replace(currentRow, "  ", " ")
    '                        End While
    '                        If currentRow = "индекс имя К Ж И Д Ж И" Then
    '                            currentRow = MyReader.ReadLine
    '                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                            While InStr(currentRow, "  ") > 0
    '                                currentRow = Replace(currentRow, "  ", " ")
    '                            End While
    '                            If currentRow = "пробы образца (в г) (в г)" Then
    '                                currentRow = MyReader.ReadLine
    '                                currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                                While InStr(currentRow, "--") > 0
    '                                    currentRow = Replace(currentRow, "--", "-")
    '                                End While
    '                                If currentRow = "-" Then
    '                                    'MessageBox.Show("Похоже, правильный формат файла активностей исследуемого образца!")
    '                                    currentRow = MyReader.ReadLine
    'a2:                                 array_length_VES = array_length_VES + 1
    '                                    currentRow = MyReader.ReadLine
    '                                    If currentRow <> "" Then GoTo a2
    '                                End If
    '                            End If
    '                        End If
    '                    End While
    '                End Using

    '                ReDim Samples_Names(array_length_VES, 1)
    '                ReDim Samples_Weights(array_length_VES, 1)

    '                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog_Weighting_SLI_LLI.FileName, System.Text.Encoding.Default)
    '                    MyReader.TextFieldType = FileIO.FieldType.Delimited
    '                    MyReader.SetDelimiters(" ")

    '                    currentRow = ""
    '                    While Not MyReader.EndOfData
    '                        currentRow = MyReader.ReadLine
    '                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                        While InStr(currentRow, "  ") > 0
    '                            currentRow = Replace(currentRow, "  ", " ")
    '                        End While
    '                        If currentRow = "индекс имя К Ж И Д Ж И" Then
    '                            currentRow = MyReader.ReadLine
    '                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                            While InStr(currentRow, "  ") > 0
    '                                currentRow = Replace(currentRow, "  ", " ")
    '                            End While
    '                            If currentRow = "пробы образца (в г) (в г)" Then
    '                                currentRow = MyReader.ReadLine
    '                                currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                                While InStr(currentRow, "--") > 0
    '                                    currentRow = Replace(currentRow, "--", "-")
    '                                End While
    '                                If currentRow = "-" Then
    '                                    'MessageBox.Show("Похоже, правильный формат файла активностей исследуемого образца!")

    '                                    row_count = 0
    '                                    currentRow = MyReader.ReadLine
    'b2:                                 currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
    '                                    While InStr(currentRow, "  ") > 0
    '                                        currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
    '                                    End While
    '                                    If currentRow(currentRow.Count - 1) <> " " Then currentRow = currentRow + " " 'добавляем пробел в конец строки
    '                                    Samples_Names(row_count, 0) = Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) 'индекс пробы - первое слово до пробела
    '                                    currentRow = Replace(currentRow, Samples_Names(row_count, 0) + " ", "", , 1, )
    '                                    Samples_Names(row_count, 1) = Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) 'имя образца - первое слово до пробела
    '                                    currentRow = Replace(currentRow, Samples_Names(row_count, 1) + " ", "", , 1, )
    '                                    Samples_Weights(row_count, 0) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))
    '                                    currentRow = Replace(currentRow, Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) + " ", "")
    '                                    Samples_Weights(row_count, 1) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))

    '                                    row_count = row_count + 1
    '                                    currentRow = MyReader.ReadLine
    '                                    If currentRow <> "" Then GoTo b2
    '                                End If
    '                            End If
    '                        End If
    '                    End While
    '                End Using

    '                For i = 0 To row_count - 1
    '                    cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
    '                        "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
    '                        "' and Monitor_Number='" + Samples_Names(i, 1).ToString + "'"
    '                    cmd.Connection = sqlConnection1
    '                    sqlConnection1.Open()
    '                    reader = cmd.ExecuteReader()
    '                    While reader.Read()

    '                        If reader(0) = 0 Then 'строчки нет
    '                            sqlConnection1.Close()
    '                            cmd.CommandText = "INSERT dbo.table_Monitor (Monitor_Set_Name, Monitor_Set_Number, Monitor_Set_Weight, Monitor_Number, Monitor_LLI_Weight) VALUES ('" +
    '                                 Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString + "', " +
    '                                 Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ", " +
    '                                 Replace(Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(3).Value.ToString, ",", ".") + ", " +
    '                                 Samples_Names(i, 1).ToString + ", " + Replace(Samples_Weights(i, 1).ToString, ",", ".") + ")"
    '                            cmd.Connection = sqlConnection1
    '                            sqlConnection1.Open()
    '                            cmd.ExecuteNonQuery()
    '                            sqlConnection1.Close()
    '                            GoTo c2

    '                        Else 'строчка есть
    '                            sqlConnection1.Close()
    '                            cmd.CommandText = "SELECT Monitor_LLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
    '                        "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
    '                        "' and Monitor_Number='" + Samples_Names(i, 1).ToString + "'"
    '                            cmd.Connection = sqlConnection1
    '                            sqlConnection1.Open()
    '                            reader = cmd.ExecuteReader()
    '                            While reader.Read()
    '                                If IsDBNull(reader(0)) = True Then 'строчка нет, но SLI=NULL
    '                                    sqlConnection1.Close()
    '                                    cmd.CommandText = "UPDATE table_Monitor SET Monitor_LLI_Weight=" + Replace(Samples_Weights(i, 1).ToString, ",", ".") + " WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
    '                                                                     "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
    '                                                                     "' and Monitor_Number='" + Samples_Names(i, 1).ToString + "'"
    '                                    cmd.Connection = sqlConnection1
    '                                    sqlConnection1.Open()
    '                                    cmd.ExecuteNonQuery()
    '                                    sqlConnection1.Close()
    '                                    GoTo c2
    '                                End If
    '                            End While
    '                        End If
    '                    End While
    '                    sqlConnection1.Close()
    'c2:             Next
    '            End If

    '            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor". При необходимости она может быть перемещена или удалена.
    '            Table_MonitorTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
    '            Me.Table_MonitorTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value)

    '            If Table_Monitor_DataGridView.RowCount > 0 Then
    '                Table_Monitor_DataGridView.FirstDisplayedScrollingRowIndex = Table_Monitor_DataGridView.RowCount - 1
    '                For i = 0 To Table_Monitor_DataGridView.RowCount - 1
    '                    Table_Monitor_DataGridView.Rows.Item(i).Selected = False
    '                Next
    '                Try
    '                    Table_Monitor_DataGridView.Rows.Item(Table_Monitor_DataGridView.RowCount - 1).Selected = True
    '                Catch ex As Exception
    '                End Try
    '            End If

    '            cmd.CommandText = "SELECT Monitor_Set_Weight FROM dbo.table_Monitor_Set WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
    '                "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "'"
    '            cmd.Connection = sqlConnection1
    '            sqlConnection1.Open()
    '            reader = cmd.ExecuteReader()
    '            While reader.Read()
    '                weight_Monitor_Set = reader(0)
    '            End While
    '            sqlConnection1.Close()

    '            If Table_Monitor_DataGridView.RowCount > 0 Then
    '                cmd.CommandText = "SELECT Monitor_SLI_Weight, Monitor_LLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
    '                    "' and Monitor_Set_Number=" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ""
    '                cmd.Connection = sqlConnection1
    '                sqlConnection1.Open()
    '                reader = cmd.ExecuteReader()
    '                While reader.Read()
    '                    If IsDBNull(reader(0)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(0)
    '                    If IsDBNull(reader(1)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(1)
    '                End While
    '                sqlConnection1.Close()
    '            End If
    '            L_Weight_Balance.Text = (weight_Monitor_Set - weight_Monitor_Sum).ToString
    '        Catch ex As Exception
    '            If Form_Main.language = "Русский" Then
    '                MsgBox("Операция была отменена (ошибка в B_Fill_LLI_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
    '            ElseIf Form_Main.language = "English" Then
    '                MsgBox("Operation was cancelled (error in B_Fill_LLI_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
    '            End If
    '            Exit Sub
    '        End Try
    '    End Sub

    Private Sub B_Fill_Monitor_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_Monitor_From_File.Click
        Try
            Dim array_length_VES As Integer
            Dim Samples_Names(,) As String
            Dim Samples_Weights(,) As Single
            Dim row_count As Integer

            Dim correct_name As String
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            Dim weight_Monitor_Sum, weight_Monitor_Set As Single
            weight_Monitor_Sum = 0
            weight_Monitor_Set = 0

            OpenFileDialog_Weighting_SLI_LLI.InitialDirectory = "C:\"
            correct_name = "m-m-m-" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString + "-" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ".ves"
            'correct_name = correct_name.ToUpper
            OpenFileDialog_Weighting_SLI_LLI.FileName = correct_name
            ''OpenDialog_Aktivn_Stand_Obr.FileName:="" не разкомментировать, иначе будут ошибки!
            If OpenFileDialog_Weighting_SLI_LLI.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите весовой файл!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select file with samples's weight!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                If OpenFileDialog_Weighting_SLI_LLI.SafeFileName.ToUpper <> correct_name.ToUpper Then
                    Dim response As MsgBoxResult
                    If Form_Main.language = "Русский" Then
                        response = MsgBox("Неправильное имя файла! Продолжить?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text)
                        If response = System.Windows.Forms.DialogResult.Yes Then
                            GoTo 2
                        Else
                            Exit Sub
                        End If
                    ElseIf Form_Main.language = "English" Then
                        response = MsgBox("Not valid file name! Resume?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text)
                        If response = System.Windows.Forms.DialogResult.Yes Then
                            GoTo 2
                        Else
                            Exit Sub
                        End If
                    End If
                End If
2:              array_length_VES = 0
                array_length_VES = Form_Main.Fill_In_Weight_From_File_String_Quant(OpenFileDialog_Weighting_SLI_LLI.FileName)

                ReDim Samples_Names(array_length_VES, 1)
                ReDim Samples_Weights(array_length_VES, 1)

                Form_Main.Fill_In_Weight_From_File(OpenFileDialog_Weighting_SLI_LLI.FileName, row_count, Samples_Names, Samples_Weights)

                For i = 0 To row_count - 1
                    cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                        "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                        "' and Monitor_Number='" + Samples_Names(i, 0).ToString + "'"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()

                        If reader(0) = 0 Then 'строчки нет
                            sqlConnection1.Close()
                            cmd.CommandText = "INSERT dbo.table_Monitor (Monitor_Set_Name, Monitor_Set_Number, Monitor_Set_Weight, Monitor_Number, Monitor_SLI_Weight, Monitor_LLI_Weight) VALUES ('" +
                                 Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString + "', '" +
                                 Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "', " +
                                 Replace(Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(3).Value.ToString, ",", ".") + ", '" +
                                 Samples_Names(i, 0).ToString + "', " + Replace(Samples_Weights(i, 0).ToString, ",", ".") + ", " + Replace(Samples_Weights(i, 1).ToString, ",", ".") + ")"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            cmd.ExecuteNonQuery()
                            sqlConnection1.Close()
                            GoTo c2

                        Else 'строчка есть
                            sqlConnection1.Close()
                            cmd.CommandText = "UPDATE table_Monitor SET Monitor_SLI_Weight=" + Replace(Samples_Weights(i, 0).ToString, ",", ".") + ", Monitor_LLI_Weight=" + Replace(Samples_Weights(i, 1).ToString, ",", ".") + " WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                                 "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                                 "' and Monitor_Number='" + Samples_Names(i, 0).ToString + "'"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            cmd.ExecuteNonQuery()
                            sqlConnection1.Close()
                            GoTo c2
                            '    sqlConnection1.Close()
                            '    cmd.CommandText = "SELECT Monitor_LLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                            '"' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                            '"' and Monitor_Number='" + Samples_Names(i, 0).ToString + "'"
                            '    cmd.Connection = sqlConnection1
                            '    sqlConnection1.Open()
                            '    reader = cmd.ExecuteReader()
                            '    While reader.Read()
                            '        If IsDBNull(reader(0)) = True Then 'строчка есть, но SLI=NULL
                            '            sqlConnection1.Close()
                            '            cmd.CommandText = "UPDATE table_Monitor SET Monitor_LLI_Weight=" + Replace(Samples_Weights(i, 1).ToString, ",", ".") + " WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                            '                                             "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                            '                                             "' and Monitor_Number='" + Samples_Names(i, 0).ToString + "'"
                            '            cmd.Connection = sqlConnection1
                            '            sqlConnection1.Open()
                            '            cmd.ExecuteNonQuery()
                            '            sqlConnection1.Close()
                            '            GoTo c2
                            '        End If
                            '    End While
                        End If
                    End While
                    sqlConnection1.Close()
c2:             Next
            End If

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor". При необходимости она может быть перемещена или удалена.
            Table_MonitorTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_MonitorTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value, Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value)

            If Table_Monitor_DataGridView.RowCount > 0 Then
                Table_Monitor_DataGridView.FirstDisplayedScrollingRowIndex = Table_Monitor_DataGridView.RowCount - 1
                For i = 0 To Table_Monitor_DataGridView.RowCount - 1
                    Table_Monitor_DataGridView.Rows.Item(i).Selected = False
                Next
                Try
                    Table_Monitor_DataGridView.Rows.Item(Table_Monitor_DataGridView.RowCount - 1).Selected = True
                Catch ex As Exception
                End Try
            End If

            cmd.CommandText = "SELECT Monitor_Set_Weight FROM dbo.table_Monitor_Set WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                "' and Monitor_Set_Number='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                weight_Monitor_Set = reader(0)
            End While
            sqlConnection1.Close()

            If Table_Monitor_DataGridView.RowCount > 0 Then
                cmd.CommandText = "SELECT Monitor_SLI_Weight, Monitor_LLI_Weight FROM dbo.table_Monitor WHERE Monitor_Set_Name='" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                    "' and Monitor_Set_Number=" + Form_Main.Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value.ToString + ""
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If IsDBNull(reader(0)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(0)
                    If IsDBNull(reader(1)) = False Then weight_Monitor_Sum = weight_Monitor_Sum + reader(1)
                End While
                sqlConnection1.Close()
            End If
            L_Weight_Balance.Text = (weight_Monitor_Set - weight_Monitor_Sum).ToString
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_Monitor_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Fill_Monitor_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class