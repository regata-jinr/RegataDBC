Imports System.Data.SqlClient
Public Class Form_Sample_Preparation
    Private Sub Form_Sample_Preparation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        UPDATE    table_Sample
        'SET              P_Cleaning_Fact = @P_Cleaning_Fact, P_Drying_Fact = @P_Drying_Fact, P_Evaporation_Fact = @P_Evaporation_Fact, 
        '                      P_Freeze_Drying_Fact = @P_Freeze_Drying_Fact, P_Homogenizing_Fact = @P_Homogenizing_Fact, P_Pelletization_Fact = @P_Pelletization_Fact, 
        '                      P_Fragmentation_Fact = @P_Fragmentation_Fact, P_Weighting_SLI = @P_Weighting_SLI, P_Weighting_LLI = @P_Weighting_LLI, 
        '                      P_Date_Sample_Preparation = @P_Date_Sample_Preparation, P_Maked_By = @P_Maked_By
        'WHERE     (F_Country_Code = @F_Country_Code) AND (F_Client_ID = @F_Client_ID) AND (F_Year = @F_Year) AND (F_Sample_Set_ID = @F_Sample_Set_ID) AND
        '                       (F_Sample_Set_Index = @F_Sample_Set_Index) AND (A_Sample_ID = @A_Sample_ID)

        Try
            If Form_Main.language = "russian" Then
                Me.Text = "Пробоподготовка"
                Label_Name_Code.Text = "Страна-Клиент-Год-№ парт.-Ин. п."

                B_Check_Selected_Cleaning.Text = "Отметить выбранные 'Очистка'"
                B_Check_Selected_Drying.Text = "Отметить выбранные 'Сушка'"
                B_Check_Selected_Evaporation.Text = "Отметить выбранные 'Выпаривание'"
                B_Check_Selected_Freeze_Drying.Text = "Отметить выбранные 'Вымораживание'"
                B_Check_Selected_Homogenizing.Text = "Отметить выбранные 'Гомогенизация'"
                B_Check_Selected_Pelletization.Text = "Отметить выбранные 'Пеллетизация'"
                B_Check_Selected_Fragmentation.Text = "Отметить выбранные 'Измельчение'"
                B_Fill_Weighting_From_File.Text = "Заполнить вес из файла"
                B_Check_Selected_Maked_By.Text = "Заполнить выделенные 'Сделано'"

                B_Select_All.Text = "Выбрать все строки"
                B_Save.Text = "Сохранить"
                B_Close.Text = "Закрыть"

                OpenFileDialog_Weighting.Filter = "Весовые файлы (*.ves)|*.ves|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "english" Then
                Me.Text = "Sample preparation"
                Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"

                B_Check_Selected_Cleaning.Text = "Check selected 'Cleaning'"
                B_Check_Selected_Drying.Text = "Check selected 'Drying'"
                B_Check_Selected_Evaporation.Text = "Check selected 'Evaporation'"
                B_Check_Selected_Freeze_Drying.Text = "Check selected 'Freeze Drying'"
                B_Check_Selected_Homogenizing.Text = "Check selected 'Homogenizing'"
                B_Check_Selected_Pelletization.Text = "Check selected 'Pelletization'"
                B_Check_Selected_Fragmentation.Text = "Check selected 'Fragmentation'"
                B_Fill_Weighting_From_File.Text = "Fill in weights from file"
                B_Check_Selected_Maked_By.Text = "Check selected 'Maked by'"

                B_Select_All.Text = "Select all rows"
                B_Save.Text = "Save"
                B_Close.Text = "Close"

                OpenFileDialog_Weighting.Filter = "Files of weight (*.ves)|*.ves|All files (*.*)|*.*"
            End If


            With DataGridView_Table_Sample
                Dim g As Graphics = .CreateGraphics()
                Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))

                .Columns.Clear()
                '.RowHeadersWidth = 21

                If Form_Main.language = "russian" Then
                    .Columns.Add("A_Sample_ID", "№ образца")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("A_Sample_ID", "Sample ID")
                End If
                .Columns(0).DataPropertyName = "A_Sample_ID" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                '.Columns(0).Frozen = True
                .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("образца", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("A_Client_Sample_ID", "Клиентский № образца")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("A_Client_Sample_ID", "Client sample ID")
                End If
                .Columns(1).DataPropertyName = "A_Client_Sample_ID" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Клиентский", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Cleaning_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Cleaning_Fact.HeaderText = "Очистка"
                ElseIf Form_Main.language = "english" Then
                    P_Cleaning_Fact.HeaderText = "Cleaning"
                End If
                .Columns.Add(P_Cleaning_Fact)
                .Columns(2).DataPropertyName = "P_Cleaning_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(2).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Cleaning", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Drying_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Drying_Fact.HeaderText = "Сушка"
                ElseIf Form_Main.language = "english" Then
                    P_Drying_Fact.HeaderText = "Drying"
                End If
                .Columns.Add(P_Drying_Fact)
                .Columns(3).DataPropertyName = "P_Drying_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(3).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Drying", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Evaporation_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Evaporation_Fact.HeaderText = "Выпаривание"
                ElseIf Form_Main.language = "english" Then
                    P_Evaporation_Fact.HeaderText = "Evaporation"
                End If
                .Columns.Add(P_Evaporation_Fact)
                .Columns(4).DataPropertyName = "P_Evaporation_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(4).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Выпаривание", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Freeze_Drying_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Freeze_Drying_Fact.HeaderText = "Вымораживание"
                ElseIf Form_Main.language = "english" Then
                    P_Freeze_Drying_Fact.HeaderText = "Freeze drying"
                End If
                .Columns.Add(P_Freeze_Drying_Fact)
                .Columns(5).DataPropertyName = "P_Freeze_Drying_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(5).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Вымораживание", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Homogenizing_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Homogenizing_Fact.HeaderText = "Гомогенизация"
                ElseIf Form_Main.language = "english" Then
                    P_Homogenizing_Fact.HeaderText = "Homogenizing"
                End If
                .Columns.Add(P_Homogenizing_Fact)
                .Columns(6).DataPropertyName = "P_Homogenizing_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(6).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Гомогенизация", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Pelletization_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Pelletization_Fact.HeaderText = "Пеллетизация"
                ElseIf Form_Main.language = "english" Then
                    P_Pelletization_Fact.HeaderText = "Pelletization"
                End If
                .Columns.Add(P_Pelletization_Fact)
                .Columns(7).DataPropertyName = "P_Pelletization_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(7).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Пеллетизация", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Dim P_Fragmentation_Fact As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
                If Form_Main.language = "russian" Then
                    P_Fragmentation_Fact.HeaderText = "Измельчение"
                ElseIf Form_Main.language = "english" Then
                    P_Fragmentation_Fact.HeaderText = "Fragmentation"
                End If
                .Columns.Add(P_Fragmentation_Fact)
                .Columns(8).DataPropertyName = "P_Fragmentation_Fact" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(8).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Fragmentation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("P_Weighting_SLI", "Вес КЖИ, гр")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("P_Weighting_SLI", "Weight SLI, g")
                End If
                .Columns(9).DataPropertyName = "P_Weighting_SLI" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(9).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Вес КЖИ", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("P_Weighting_LLI", "Вес ДЖИ, гр")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("P_Weighting_LLI", "Weight LLI, g")
                End If
                .Columns(10).DataPropertyName = "P_Weighting_LLI" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(10).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Вес ДЖИ", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("P_Date_Sample_Preparation", "Дата пробоподготовки")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("P_Date_Sample_Preparation", "Sample preparation date")
                End If
                .Columns(11).DataPropertyName = "P_Date_Sample_Preparation" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(11).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("пробоподготовкий", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("P_Maked_By", "Сделал")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("P_Maked_By", "Maked by")
                End If
                .Columns(12).DataPropertyName = "P_Maked_By" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(12).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Alekseenok Yu.V.", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.AutoResizeColumns()

                If .RowCount > 0 Then
                    .FirstDisplayedScrollingRowIndex = .RowCount - 1
                    For i = 0 To .RowCount - 1
                        .Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Sample_Set.RowCount - 1).Selected = True
                End If
            End With
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_Sample_Preparation_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_Sample_Preparation_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save.Click
        '        UPDATE    table_Sample
        'SET              P_Cleaning_Fact = @P_Cleaning_Fact, P_Drying_Fact = @P_Drying_Fact, P_Evaporation_Fact = @P_Evaporation_Fact, 
        '                      P_Freeze_Drying_Fact = @P_Freeze_Drying_Fact, P_Homogenizing_Fact = @P_Homogenizing_Fact, P_Pelletization_Fact = @P_Pelletization_Fact, 
        '                      P_Fragmentation_Fact = @P_Fragmentation_Fact, P_Weighting_SLI = @P_Weighting_SLI, P_Weighting_LLI = @P_Weighting_LLI, 
        '                      P_Date_Sample_Preparation = @P_Date_Sample_Preparation, P_Maked_By = @P_Maked_By
        'WHERE     (A_Sample_ID = @A_Sample_ID) AND (F_Country_Code = @F_Country_Code) AND (F_Client_ID = @F_Client_ID) AND (F_Year = @F_Year) AND 
        '                      (F_Sample_Set_ID = @F_Sample_Set_ID) AND (F_Sample_Set_Index = @F_Sample_Set_Index)
        Try
            Me.Validate()
            Me.Table_Sample_Sample_Preparation_BindingSource.EndEdit()
            Me.Table_Sample_Sample_Preparation_TableAdapter.Update(Me.NAA_DB_EXPDataSet)
            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Save_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Save_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub B_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_All.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                DataGridView_Table_Sample.Rows.Item(i).Selected = True
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Select_All_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Select_All_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Cleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Cleaning.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(2).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Cleaning_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Cleaning_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Drying_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Drying.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(3).Value = 0 '3 - drying
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(3).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Drying_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Drying_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Evaporation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Evaporation.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(4).Value = 0 '4 - evaporation
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(4).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Evaporation_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Evaporation_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Freeze_Drying_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Freeze_Drying.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(5).Value = 0 '5 - freeze drying
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(5).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Freeze_Drying_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Freeze_Drying_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Homogenizing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Homogenizing.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(6).Value = 0 '6 - Homogenizing
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(6).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Homogenizing_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Homogenizing_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Pelletization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Pelletization.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(7).Value = 0 '7 - Pelletization
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(7).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Pelletization_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Pelletization_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Fragmentation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Fragmentation.Click
        Try
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(8).Value = 0 '8 - Fragmentation
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(8).Value = 1
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Fragmentation_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Fragmentation_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Check_Selected_Maked_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Check_Selected_Maked_By.Click
        Try
            If Received_ByComboBox.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите фамилию!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select family!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_Table_Sample.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(11).Value = "" '11 - Maked By
                If DataGridView_Table_Sample.Rows.Item(i).Selected = True Then DataGridView_Table_Sample.Rows.Item(i).Cells.Item(12).Value = Received_ByComboBox.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Check_Selected_Maked_By_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Check_Selected_Maked_By_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_Weighting_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_Weighting_From_File.Click
        Try
            Dim array_length_VES As Integer
            Dim Samples_Names(,) As String
            Dim Samples_Weights(,) As Single
            Dim row_count As Integer
            Dim correct_name As String

            correct_name = L_SS_Country_Code.Text + "-" + L_SS_Client_ID.Text + "-" + L_SS_Year.Text + "-" + L_SS_Sample_Set_ID.Text + "-" + L_SS_Sample_Set_Index.Text + ".ves"

            'correct_name = correct_name.ToUpper
            OpenFileDialog_Weighting.FileName = correct_name
            ''OpenDialog_Aktivn_Stand_Obr.FileName:="" не разкомментировать, иначе будут ошибки!
            If OpenFileDialog_Weighting.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите весовой файл!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select file with samples's weight!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                If OpenFileDialog_Weighting.SafeFileName.ToUpper <> correct_name.ToUpper Then
                    Dim response As MsgBoxResult
                    If Form_Main.language = "russian" Then
                        response = MsgBox("Неправильное имя файла! Продолжить?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text)
                        If response = System.Windows.Forms.DialogResult.Yes Then
                            GoTo 0
                        Else
                            Exit Sub
                        End If
                    ElseIf Form_Main.language = "english" Then
                        response = MsgBox("Not valid file name! Resume?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text)
                        If response = System.Windows.Forms.DialogResult.Yes Then
                            GoTo 0
                        Else
                            Exit Sub
                        End If
                    End If
                End If

0:              array_length_VES = 0
                array_length_VES = Form_Main.Fill_In_Weight_From_File_String_Quant(OpenFileDialog_Weighting.FileName)

                ReDim Samples_Names(array_length_VES, 2)
                ReDim Samples_Weights(array_length_VES, 2)

                Form_Main.Fill_In_Weight_From_File(OpenFileDialog_Weighting.FileName, row_count, Samples_Names, Samples_Weights)

                For i = 0 To DataGridView_Table_Sample.RowCount - 1
                    For j = 0 To row_count - 1
                        If DataGridView_Table_Sample.Rows.Item(i).Cells.Item(0).Value = Samples_Names(j, 0) Then
                            DataGridView_Table_Sample.Rows.Item(i).Cells.Item(9).Value = Samples_Weights(j, 0)
                            DataGridView_Table_Sample.Rows.Item(i).Cells.Item(10).Value = Samples_Weights(j, 1)
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_Weighting_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_Weighting_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Sample_Preparation_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Samples_List.Enabled = True
    End Sub

    Private Sub Table_SampleDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView_Table_Sample.DataError
        If Form_Main.language = "russian" Then
            MsgBox("Операция была отменена (ошибка в Table_SampleDataGridView_DataError!", MsgBoxStyle.Critical, Me.Text)
        ElseIf Form_Main.language = "english" Then
            MsgBox("Operation was cancelled (error in Table_SampleDataGridView_DataError!", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub
End Class