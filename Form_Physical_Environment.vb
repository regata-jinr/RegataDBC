Imports System.Data.SqlClient

Public Class Form_Physical_Environment
    'Private Sub Table_Physical_EnvironmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Validate()
    '        Me.Table_Physical_EnvironmentBindingSource.EndEdit()
    '        Me.TableAdapterManager.UpdateAll(Me.NAA_DB_EXPDataSet)
    '    Catch ex As Exception
    '        If Form_Main.language = "Русский" Then
    '            MsgBox("Операция была отменена (ошибка в Table_Physical_EnvironmentBindingNavigatorSaveItem_Click)!", MsgBoxStyle.Critical, Me.Text)
    '        ElseIf Form_Main.language = "English" Then
    '            MsgBox("The operation was cancelled (error in Table_Physical_EnvironmentBindingNavigatorSaveItem_Click)!", MsgBoxStyle.Critical, Me.Text)
    '        End If
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub Form_Physical_Environment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "Русский" Then
                Me.Text = "Параметры окружающей среды"

                B_Insert_From_File.Text = "Вставить из файла"
                B_Close.Text = "Закрыть"
                OpenFileDialog_Insert_From_file.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "Physical environment"

                B_Insert_From_File.Text = "Insert from file"
                B_Close.Text = "Close"
                OpenFileDialog_Insert_From_file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            End If

            With Table_Physical_EnvironmentDataGridView

                '   Dim g As Graphics = .CreateGraphics()
                '   Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))

                ' .Columns.Clear()
                '  .RowHeadersWidth = 21

              
                '.Columns(0).DataPropertyName = "Data" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                '.Columns(0).ReadOnly = True
                '.Columns(0).Frozen = True
                ''  .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Дата", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                'If Form_Main.language = "Русский" Then
                '    .Columns.Add("Time", "Время")
                'ElseIf Form_Main.language = "English" Then
                '    .Columns.Add("Time", "Time")
                'End If
                '.Columns(1).DataPropertyName = "Time"
                '.Columns(1).ReadOnly = True
                '.Columns(1).Frozen = True
                '' .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Время", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                'If Form_Main.language = "Русский" Then
                '    .Columns.Add("Relative_Humidity", "Относительная влажность, %")
                'ElseIf Form_Main.language = "English" Then
                '    .Columns.Add("Relative_Humidity", "Relative humidity, %")
                'End If
                '.Columns(2).DataPropertyName = "Relative_Humidity"
                '.Columns(2).ReadOnly = True
                '.Columns(2).Frozen = True
                ''.Columns(2).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Относительная", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                'If Form_Main.language = "Русский" Then
                '    .Columns.Add("TemperatureD", "Температура, C")
                'ElseIf Form_Main.language = "English" Then
                '    .Columns.Add("Temperature", "Temperature, C")
                'End If
                '.Columns(3).DataPropertyName = "Temperature"
                '.Columns(3).ReadOnly = True
                '.Columns(3).Frozen = True
                ' .Columns(3).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Температура,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Physical_Environment". При необходимости она может быть перемещена или удалена.

                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "select *from table_Physical_Environment "

                Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "physEnv")
                Table_Physical_EnvironmentDataGridView.DataSource = ds
                Table_Physical_EnvironmentDataGridView.DataMember = "physEnv"

                If Form_Main.language = "Русский" Then
                    .Columns(0).HeaderText = "Дата"
                    .Columns(1).HeaderText = "Время"
                    .Columns(2).HeaderText = "Относительная влажность, %"
                    .Columns(3).HeaderText = "Температура, C"
                ElseIf Form_Main.language = "English" Then
                    .Columns(0).HeaderText = "Date"
                    .Columns(1).HeaderText = "Time"
                    .Columns(2).HeaderText = "Relative humidity, %"
                    .Columns(3).HeaderText = "Temperature, C"
                End If

                If .RowCount > 0 Then
                    .FirstDisplayedScrollingRowIndex = .RowCount - 1
                    For i = 0 To .RowCount - 1
                        .Rows.Item(i).Selected = False
                    Next
                    Try
                        .Rows.Item(.RowCount - 1).Selected = True
                    Catch ex As Exception
                    End Try
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Physical_Environment_Load)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_Physical_Environment_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Try
            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Close_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Close_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Insert_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Insert_From_File.Click
        Try
            Dim array_length_PE As Integer
            Dim Data_Time(,) As DateTime
            Dim Humidity_Temperature(,) As Single
            Dim row_count As Integer
            Dim current_value As String

            OpenFileDialog_Insert_From_file.InitialDirectory = "C:\"
            ''OpenDialog_Aktivn_Stand_Obr.FileName:="" не разкомментировать, иначе будут ошибки!
            If OpenFileDialog_Insert_From_file.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите файл!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select file!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                array_length_PE = 0
                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Insert_From_file.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(" ")
                    Dim currentRow As String
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If currentRow = "Дата Время RH, % Т, °C P, гПа" Then
                            MsgBox("Похоже, правильный формат файла активностей исследуемого образца!")
                            currentRow = MyReader.ReadLine
a:                          array_length_PE = array_length_PE + 1
                            currentRow = MyReader.ReadLine
                            If currentRow <> "" Then GoTo a
                        End If
                    End While
                End Using

                ReDim Data_Time(array_length_PE, 2)
                ReDim Humidity_Temperature(array_length_PE, 2)

                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Insert_From_file.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(" ")
                    Dim currentRow As String
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If currentRow = "Дата Время RH, % Т, °C P, гПа" Then
                            'MsgBox("Похоже, правильный формат файла активностей исследуемого образца!")
                            currentRow = MyReader.ReadLine
b:                          currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                            End While
                            If currentRow(currentRow.Count - 1) <> " " Then currentRow = currentRow + " " 'добавляем пробел в конец строки
                            current_value = Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) 'дата - первое слово до пробела
                            Data_Time(row_count, 0) = current_value
                            currentRow = Replace(currentRow, current_value + " ", "", , 1, )
                            current_value = Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) 'время- первое слово до пробела
                            Data_Time(row_count, 1) = current_value
                            currentRow = Replace(currentRow, current_value + " ", "", , 1, )
                            Humidity_Temperature(row_count, 0) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))
                            currentRow = Replace(currentRow, Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) + " ", "", , 1, )
                            Humidity_Temperature(row_count, 1) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))
                            row_count = row_count + 1
                            currentRow = MyReader.ReadLine
                            If currentRow <> "" Then GoTo b

                        End If
                    End While
                End Using

                For i = 0 To row_count - 1

                    Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                    Dim reader As SqlDataReader
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text

                    cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Physical_Environment WHERE Data='" + Data_Time(i, 0) + "' and Time='" + Data_Time(i, 1) + "'"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If reader(0) = 0 Then
                            sqlConnection1.Close()
                            cmd.CommandText = "INSERT dbo.table_Physical_Environment (Data, Time, Relative_Humidity, Temperature) " +
                                          "VALUES ('" + Data_Time(i, 0).ToString + "', '" + Data_Time(i, 1).ToString + "', " + Replace(Humidity_Temperature(i, 0).ToString, ",", ".") + ", " +
                                           Replace(Humidity_Temperature(i, 1).ToString, ",", ".") + ")"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            cmd.ExecuteNonQuery()
                            sqlConnection1.Close()

                            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Physical_Environment". При необходимости она может быть перемещена или удалена.
                            sqlConnection1.Open()
                            cmd.CommandType = System.Data.CommandType.Text

                            cmd.CommandText = "select *from table_Physical_Environment "

                            Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                            Dim ds As New DataSet()

                            dataadapter.Fill(ds, "physEnv")
                            Table_Physical_EnvironmentDataGridView.DataSource = ds
                            Table_Physical_EnvironmentDataGridView.DataMember = "physEnv"
                            sqlConnection1.Close()
                            GoTo c
                        End If
                    End While
                    sqlConnection1.Close()

                    'For j = 0 To Table_Physical_EnvironmentDataGridView.RowCount - 1
                    '    If Table_Physical_EnvironmentDataGridView.Rows.Item(i).Cells.Item(0).Value = Data_Time(j, 0) And Table_Physical_EnvironmentDataGridView.Rows.Item(i).Cells.Item(1).Value = Data_Time(j, 1) Then GoTo c
                    'Next
                    'Table_Physical_EnvironmentDataGridView.Rows.Add()
c:              Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Insert_From_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Insert_From_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Physical_Environment_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Physical_Environment_FormClosed)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_Physical_Environment_FormClosed)!", MsgBoxStyle.Critical, Me.Text)
            End If
        End Try
    End Sub
End Class