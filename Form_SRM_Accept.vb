Imports System.Data.SqlClient

Public Class Form_SRM_Accept
    Private Sub Table_SRM_SetBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.Table_SRM_SetBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NAA_DB_EXPDataSet)
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Table_SRM_SetBindingNavigatorSaveItem_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Table_SRM_SetBindingNavigatorSaveItem_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_New_SRM_Accept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Try
                If Form_Main.language = "Русский" Then
                    Me.Text = "Список стандартов"

                    L_Name_SRM_Set_Name.Text = "Имя партии стандартов"
                    L_Name_SRM_Set_Number.Text = "Номер партии стандартов"
                    L_Name_SRM_Set_Weight.Text = "Вес партии стандартов, гр"
                    L_Name_Weight_Balance.Text = "Баланс веса, гр"

                    B_Fill_SRM_From_File.Text = "Заполнить вес стандартов из файла"
                    B_Close.Text = "Закрыть"

                    OpenFileDialog_Weighting_SLI_LLI.Filter = "Весовые файлы (*.ves)|*.ves|Все файлы (*.*)|*.*"
                ElseIf Form_Main.language = "English" Then
                    Me.Text = "SRM list"

                    L_Name_SRM_Set_Name.Text = "SRM set name"
                    L_Name_SRM_Set_Number.Text = "SRM set number"
                    L_Name_SRM_Set_Weight.Text = "Weight of SRM set, g"
                    L_Name_Weight_Balance.Text = "Weight balance, g"

                    B_Fill_SRM_From_File.Text = "Fill in SRM weight from file"
                    B_Close.Text = "Close"

                    OpenFileDialog_Weighting_SLI_LLI.Filter = "Files of weight (*.ves)|*.ves|All files (*.*)|*.*"
                End If

                With Table_SRMDataGridView
                    Dim g As Graphics = .CreateGraphics()
                    Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))
                    .Columns.Clear()

                    If Form_Main.language = "Русский" Then
                        .Columns.Add("SRM_Number", "№ стандарта")
                    ElseIf Form_Main.language = "English" Then
                        .Columns.Add("SRM_Number", "SRM number")
                    End If
                    .Columns(0).DataPropertyName = "SRM_Number" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                    .Columns(0).ReadOnly = True
                    .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("стандарта", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                    If Form_Main.language = "Русский" Then
                        .Columns.Add("SRM_SLI_Weight", "Вес КЖИ, гр")
                    ElseIf Form_Main.language = "English" Then
                        .Columns.Add("SRM_SLI_Weight", "SLI weight, g")
                    End If
                    .Columns(1).DataPropertyName = "SRM_SLI_Weight"
                    .Columns(1).ReadOnly = True
                    .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("weight, g", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                    If Form_Main.language = "Русский" Then
                        .Columns.Add("SRM_LLI_Weight", "Вес ДЖИ, гр")
                    ElseIf Form_Main.language = "English" Then
                        .Columns.Add("SRM_LLI_Weight", "LLI weight, g")
                    End If
                    .Columns(2).DataPropertyName = "SRM_LLI_Weight"
                    .Columns(2).ReadOnly = True
                    .Columns(2).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("weight, g", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                    '.Columns.Clear()
                    '.Columns.AddRange(SRM_Number, SRM_SLI_Weight, SRM_LLI_Weight) ' это делается, т.к. после загрузки VB добавляются все столбцы

                    'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM". При необходимости она может быть перемещена или удалена.
                    Table_SRMTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                    Me.Table_SRMTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_SRM, Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value, Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value)

                    If .RowCount > 0 Then
                        .FirstDisplayedScrollingRowIndex = .RowCount - 1
                        For i = 0 To .RowCount - 1
                            .Rows.Item(i).Selected = False
                        Next
                        .Rows.Item(.RowCount - 1).Selected = True
                    End If
                End With
            Catch ex As Exception
                ' MsgBox("The operation was cancelled!")
                Me.Close()
                Exit Sub
            End Try

            Dim weight_SRM_Sum, weight_SRM_Set As Single
            weight_SRM_Sum = 0
            weight_SRM_Set = 0

            Try
                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "SELECT SRM_Set_Weight FROM dbo.table_SRM_Set WHERE SRM_Set_Name='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                    "' and SRM_Set_Number='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    weight_SRM_Set = reader(0)
                End While
                sqlConnection1.Close()

            Catch ex As Exception
                ' MsgBox("The operation was cancelled!")
                Me.Close()
                Exit Sub
            End Try

            If Table_SRMDataGridView.RowCount > 0 Then
                Try
                    Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                    Dim reader As SqlDataReader
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "SELECT SRM_SLI_Weight, SRM_LLI_Weight FROM dbo.table_SRM WHERE SRM_Set_Name='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                        "' and SRM_Set_Number=" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString + ""
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If IsDBNull(reader(0)) = False Then weight_SRM_Sum = weight_SRM_Sum + reader(0)
                        If IsDBNull(reader(1)) = False Then weight_SRM_Sum = weight_SRM_Sum + reader(1)
                    End While
                    sqlConnection1.Close()

                Catch ex As Exception
                    ' MsgBox("The operation was cancelled!")
                    Me.Close()
                    Exit Sub
                End Try
            End If
            L_Weight_Balance.Text = (weight_SRM_Set - weight_SRM_Sum).ToString
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_New_SRM_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_New_SRM_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_New_SRM_Accept_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_New_SRM_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_New_SRM_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
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

    Private Sub B_Fill_SRM_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_SRM_From_File.Click
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
            Dim weight_SRM_Sum, weight_SRM_Set As Single
            weight_SRM_Sum = 0
            weight_SRM_Set = 0

            OpenFileDialog_Weighting_SLI_LLI.InitialDirectory = "C:\"
            correct_name = "s-s-s-" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString + "-" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString + ".ves"
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
                            GoTo 3
                        Else
                            Exit Sub
                        End If
                    ElseIf Form_Main.language = "English" Then
                        response = MsgBox("Not valid file name! Resume?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text)
                        If response = System.Windows.Forms.DialogResult.Yes Then
                            GoTo 3
                        Else
                            Exit Sub
                        End If
                    End If
                End If

3:              array_length_VES = 0
                array_length_VES = Form_Main.Fill_In_Weight_From_File_String_Quant(OpenFileDialog_Weighting_SLI_LLI.FileName)

                ReDim Samples_Names(array_length_VES, 1)
                ReDim Samples_Weights(array_length_VES, 1)

                Form_Main.Fill_In_Weight_From_File(OpenFileDialog_Weighting_SLI_LLI.FileName, row_count, Samples_Names, Samples_Weights)

                For i = 0 To row_count - 1
                    cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_SRM WHERE SRM_Set_Name='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                        "' and SRM_Set_Number='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                        "' and SRM_Number='" + Samples_Names(i, 0).ToString + "'"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()

                        If reader(0) = 0 Then 'строчки нет
                            sqlConnection1.Close()
                            cmd.CommandText = "INSERT dbo.table_SRM (SRM_Set_Name, SRM_Set_Number, SRM_Set_Weight, SRM_Number, SRM_SLI_Weight, SRM_LLI_Weight) VALUES ('" +
                                 Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString + "', '" +
                                 Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString + "', " +
                                 Replace(Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(3).Value.ToString, ",", ".") + ", '" +
                                 Samples_Names(i, 0).ToString + "', " + Replace(Samples_Weights(i, 0).ToString, ",", ".") + ", " + Replace(Samples_Weights(i, 1).ToString, ",", ".") + ")"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            cmd.ExecuteNonQuery()
                            sqlConnection1.Close()
                            Continue For

                        Else 'строчка есть
                            sqlConnection1.Close()
                            cmd.CommandText = "UPDATE table_SRM SET SRM_SLI_Weight=" + Replace(Samples_Weights(i, 0).ToString, ",", ".") + ", SRM_LLI_Weight=" + Replace(Samples_Weights(i, 1).ToString, ",", ".") + " WHERE SRM_Set_Name='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                                 "' and SRM_Set_Number='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString +
                                 "' and SRM_Number='" + Samples_Names(i, 0).ToString + "'"
                            cmd.Connection = sqlConnection1
                            sqlConnection1.Open()
                            cmd.ExecuteNonQuery()
                            sqlConnection1.Close()
                            Continue For
                        End If
                    End While
                    sqlConnection1.Close()
                Next
            End If

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM". При необходимости она может быть перемещена или удалена.
            Table_SRMTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_SRMTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_SRM, Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value, Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value)

            If Table_SRMDataGridView.RowCount > 0 Then
                Table_SRMDataGridView.FirstDisplayedScrollingRowIndex = Table_SRMDataGridView.RowCount - 1
                For i = 0 To Table_SRMDataGridView.RowCount - 1
                    Table_SRMDataGridView.Rows.Item(i).Selected = False
                Next
                Try
                    Table_SRMDataGridView.Rows.Item(Table_SRMDataGridView.RowCount - 1).Selected = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            cmd.CommandText = "SELECT SRM_Set_Weight FROM dbo.table_SRM_Set WHERE SRM_Set_Name='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                "' and SRM_Set_Number='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                weight_SRM_Set = reader(0)
            End While
            sqlConnection1.Close()

            If Table_SRMDataGridView.RowCount > 0 Then
                cmd.CommandText = "SELECT SRM_SLI_Weight, SRM_LLI_Weight FROM dbo.table_SRM WHERE SRM_Set_Name='" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(0).Value.ToString +
                    "' and SRM_Set_Number=" + Form_Main.Table_SRM_SetDataGridView.SelectedCells.Item(1).Value.ToString + ""
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If IsDBNull(reader(0)) = False Then weight_SRM_Sum = weight_SRM_Sum + reader(0)
                    If IsDBNull(reader(1)) = False Then weight_SRM_Sum = weight_SRM_Sum + reader(1)
                End While
                sqlConnection1.Close()
            End If
            L_Weight_Balance.Text = (weight_SRM_Set - weight_SRM_Sum).ToString
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_SRM_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Fill_SRM_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class