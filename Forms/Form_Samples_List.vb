Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Samples_List
    Public sample_action As String

    Private Sub Table_SampleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.Table_SampleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NAA_DB_EXPDataSet)
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Table_SampleBindingNavigatorSaveItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Table_SampleBindingNavigatorSaveItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Insert_New_Sample_Into_Sample_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Insert_New_Sample_Into_Sample_Set.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            With MaskedTextBox_New_Sample_ID
                If .Text.Trim = "" Or .Text.Trim = "0" Or .Text.Trim = "00" Then
                    If Form_Main.language = "Русский" Then
                        MsgBox("Введите номер нового образца!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("Type new sample ID!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If
            End With

            If MaskedTextBox_New_Sample_ID.Text < 10 Then MaskedTextBox_New_Sample_ID.Text = "0" + MaskedTextBox_New_Sample_ID.Text.Trim("0")

            cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Sample WHERE F_Country_Code='" + L_SS_Country_Code.Text + "' and F_Client_ID='" + L_SS_Client_ID.Text +
                "' and F_Year='" + L_SS_Year.Text + "' and F_Sample_Set_ID='" + L_SS_Sample_Set_ID.Text +
                "' and F_Sample_Set_Index='" + L_SS_Sample_Set_Index.Text +
                "' and A_Sample_ID='" + MaskedTextBox_New_Sample_ID.Text.Trim + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If reader(0) > 0 Then
                    If Form_Main.language = "Русский" Then
                        MsgBox("Образец с таким номером уже существует!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("This sample ID already exist!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    sqlConnection1.Close()
                    Exit Sub
                End If
            End While
            sqlConnection1.Close()

            If MaskedTextBox_New_Sample_ID.Text < 10 Then MaskedTextBox_New_Sample_ID.Text = "0" + MaskedTextBox_New_Sample_ID.Text.Trim("0")

            Form_Sample_Accept.L_SS_Country_Code.Text = L_SS_Country_Code.Text
            Form_Sample_Accept.L_SS_Client_ID.Text = L_SS_Client_ID.Text
            Form_Sample_Accept.L_SS_Year.Text = L_SS_Year.Text
            Form_Sample_Accept.L_SS_Sample_Set_ID.Text = L_SS_Sample_Set_ID.Text
            Form_Sample_Accept.L_SS_Sample_Set_Index.Text = L_SS_Sample_Set_Index.Text

            Form_Sample_Accept.L_Sample_ID.Text = MaskedTextBox_New_Sample_ID.Text.Trim

            'Dim num As Integer
            'num = Table_Sample_SetDataGridView.SelectedCells.Item(0).RowIndex ' номер строки с выделенной ячейкой

            'If Table_Sample_SetDataGridView.Rows.Item(num).Cells.Item(0).Value = "" Then
            '    MsgBox("Select row!")
            '    Exit Sub
            'End If
            sample_action = "new sample"

            Me.Enabled = False
            Form_Sample_Accept.Show()

        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Insert_New_Sample_Into_Sample_Set_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Insert_New_Sample_Into_Sample_Set_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_Sample_Accept.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub B_Correct_Information_About_Sample_Acceptance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Correct_Information_About_Sample.Click
        Try
            If ListBox_Sample_ID.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите существующий образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select existing sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_Sample_ID.Text < 10 Then MaskedTextBox_New_Sample_ID.Text = "0" + MaskedTextBox_New_Sample_ID.Text.Trim("0")
            Form_Sample_Accept.L_SS_Country_Code.Text = L_SS_Country_Code.Text
            Form_Sample_Accept.L_SS_Client_ID.Text = L_SS_Client_ID.Text
            Form_Sample_Accept.L_SS_Year.Text = L_SS_Year.Text
            Form_Sample_Accept.L_SS_Sample_Set_ID.Text = L_SS_Sample_Set_ID.Text
            Form_Sample_Accept.L_SS_Sample_Set_Index.Text = L_SS_Sample_Set_Index.Text
            Form_Sample_Accept.L_Sample_ID.Text = ListBox_Sample_ID.Text
            sample_action = "existing sample"

            Me.Enabled = False
            Form_Sample_Accept.Show()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Correct_Information_About_Sample_Acceptance_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Correct_Information_About_Sample_Acceptance_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_Sample_Accept.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Sample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sample_action = ""
            If Form_Main.language = "Русский" Then
                Me.Text = "Список образцов"
                Label_Name_Code.Text = "Страна-Клиент-Год-№ парт.-Ин. п."
                L_Name_New_Sample_ID.Text = "Новый № обр."
                L_Name_Sample_ID.Text = "№ образ."
                B_Insert_All_Samples_Into_Sample_Set.Text = "Вставить все образцы в партию образцов"
                B_Insert_New_Sample_Into_Sample_Set.Text = "Вставить новый образец в партию образцов"
                B_Correct_Information_About_Sample.Text = "Изменить информацию об образце"
                B_Samples_Preparation.Text = "Пробоподготовка"
                B_NAA_Results.Text = "Результаты НАА"
                BShowSumAbEls.Text = "Информация по всем образцам"
                Button_ShowNotice.Text = "Комментарии к партии"
                B_Close.Text = "Закрыть"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "Samples list"
                Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
                L_Name_New_Sample_ID.Text = "New sample ID"
                L_Name_Sample_ID.Text = "Sample ID"
                B_Insert_All_Samples_Into_Sample_Set.Text = "Insert all samples into sample set"
                B_Insert_New_Sample_Into_Sample_Set.Text = "Insert new sample into sample set"
                B_Correct_Information_About_Sample.Text = "Change information about sample"
                B_Samples_Preparation.Text = "Samples preparation"
                B_NAA_Results.Text = "NAA results"
                BShowSumAbEls.Text = "Samples summary"
                Button_ShowNotice.Text = "Comments for set"
                B_Close.Text = "Close"
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Sample_Load)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_Sample_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_Sample_Preparation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Samples_Preparation.Click
        Try
            If ListBox_Sample_ID.Items.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Партия образцов не содержит ни одного образца. Выберите другую партию!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("This sample set has not any sample. Select another sample set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Me.Enabled = False
            Form_Sample_Preparation.Show()

            Form_Sample_Preparation.L_SS_Country_Code.Text = L_SS_Country_Code.Text
            Form_Sample_Preparation.L_SS_Client_ID.Text = L_SS_Client_ID.Text
            Form_Sample_Preparation.L_SS_Year.Text = L_SS_Year.Text
            Form_Sample_Preparation.L_SS_Sample_Set_ID.Text = L_SS_Sample_Set_ID.Text
            Form_Sample_Preparation.L_SS_Sample_Set_Index.Text = L_SS_Sample_Set_Index.Text

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Received_By". При необходимости она может быть перемещена или удалена.
            Form_Sample_Preparation.Table_Received_By_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Form_Sample_Preparation.Table_Received_By_TableAdapter.Fill(Form_Sample_Preparation.NAA_DB_EXPDataSet.table_Received_By)
            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Sample". При необходимости она может быть перемещена или удалена.
            Form_Sample_Preparation.Table_Sample_Sample_Preparation_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Form_Sample_Preparation.Table_Sample_Sample_Preparation_TableAdapter.Fill_Sample_Sample_Preparation(Form_Sample_Preparation.NAA_DB_EXPDataSet.table_Sample_Sample_Preparation, L_SS_Country_Code.Text, L_SS_Client_ID.Text, L_SS_Year.Text, L_SS_Sample_Set_ID.Text, L_SS_Sample_Set_Index.Text)

            Form_Sample_Preparation.Received_ByComboBox.Text = ""

            For i = 0 To Form_Sample_Preparation.DataGridView_Table_Sample.RowCount - 1
                If Form_Sample_Preparation.DataGridView_Table_Sample.Rows.Item(i).Cells.Item(11).Value.ToString = "" Then
                    Form_Sample_Preparation.DataGridView_Table_Sample.Rows.Item(i).Cells.Item(11).Value = Format(Now(), "dd.MM.yyyy") 'если поставить маленькие буквы m, то пропишутся минуты
                End If
                Form_Sample_Preparation.DataGridView_Table_Sample.Rows.Item(i).Selected = False
            Next
        Catch dataEx As System.Data.ConstraintException

        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Sample_Preparation_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Sample_Preparation_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_Sample_Preparation.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Samples_List_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Main.Enabled = True
    End Sub


    Private Sub B_NAA_Results_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_NAA_Results.Click
        Try
            Dim timer As New Stopwatch()
            timer.Start()
            If ListBox_Sample_ID.Items.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Партия образцов не содержит ни одного образца. Выберите другую партию!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("This sample set has not any sample. Select another sample set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Me.Enabled = False
            Form_NAA_Results.Show()

            Form_NAA_Results.L_SS_Country_Code.Text = L_SS_Country_Code.Text
            Form_NAA_Results.L_SS_Client_ID.Text = L_SS_Client_ID.Text
            Form_NAA_Results.L_SS_Year.Text = L_SS_Year.Text
            Form_NAA_Results.L_SS_Sample_Set_ID.Text = L_SS_Sample_Set_ID.Text
            Form_NAA_Results.L_SS_Sample_Set_Index.Text = L_SS_Sample_Set_Index.Text
            Form_NAA_Results.L_SS_Sample_ID.Text = ListBox_Sample_ID.SelectedItem

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "select * from NaaRes where F_Country_Code = '" & L_SS_Country_Code.Text & "' and F_Client_ID = '" & L_SS_Client_ID.Text & "' and F_Year = '" & L_SS_Year.Text & "' and F_Sample_Set_Id = '" & L_SS_Sample_Set_ID.Text & "' and F_Sample_Set_Index = '" & L_SS_Sample_Set_Index.Text & "'"

            Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
            Dim ds As New DataSet()

            Debug.WriteLine($"Pre fill  {timer.ElapsedMilliseconds / 1000}")

            dataadapter.Fill(ds, "SampleInf")
            Debug.WriteLine($"fill  {timer.ElapsedMilliseconds / 1000}")
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.ColumnHeadersVisible = False
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.DataSource = ds
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.DataMember = "SampleInf"
            Debug.WriteLine($"Source  {timer.ElapsedMilliseconds / 1000}")

            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Country_Code")
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Client_ID")
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Year")
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Sample_Set_Id")
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Sample_Set_Index")

            For k As Integer = 0 To 6
                Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(k).Frozen = True
            Next

            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.ReadOnly = True
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.AllowUserToAddRows = False

            Dim inum As Integer = 1
            Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.ColumnHeadersVisible = True
            Debug.WriteLine($"End  {timer.ElapsedMilliseconds / 1000}")

            'For j As Integer = 8 To 25 'Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Count - 1
            '    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(j).SortMode = DataGridViewColumnSortMode.NotSortable
            '    If inum <= 3 Then
            '        Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(j).DefaultCellStyle.BackColor = Color.SkyBlue
            '    Else
            '        Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(j).DefaultCellStyle.BackColor = Color.Tan
            '    End If
            '    inum += 1
            '    If inum = 7 Then inum = 1

            'Next

            'Form_NAA_Results.BackgroundWorkerNaaResults.RunWorkerAsync()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Me.Text)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_NAA_Results_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_NAA_Results_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_NAA_Results.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub B_Insert_All_Samples_Into_Sample_Set_Click(sender As System.Object, e As System.EventArgs) Handles B_Insert_All_Samples_Into_Sample_Set.Click
        Try

            With MaskedTextBox_New_Sample_ID
                If .Text.Trim = "" Or .Text.Trim = "0" Or .Text.Trim = "00" Then
                    If Form_Main.language = "Русский" Then
                        MsgBox("Введите номер нового образца!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("Type new sample ID!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If
            End With

            If ListBox_Sample_ID.Items.Count <> 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Партия образцов должна быть пустой!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Sample set must be empty!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If Form_Sample_Accept.OpenFileDialog_Fill_In_From_File.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите партию образцов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select file!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Extensions.CSV.CSVAdapter.LoadFileToDb(Form_Sample_Accept.OpenFileDialog_Fill_In_From_File.FileName, Form_Main.MyConnectionString, L_SS_Country_Code.Text, L_SS_Client_ID.Text, L_SS_Year.Text, L_SS_Sample_Set_ID.Text, L_SS_Sample_Set_Index.Text)
            End If
            Close()

            Form_Main.B_Select_Sample_Set.PerformClick()

        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Insert_All_Samples_Into_Sample_Set_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Insert_All_Samples_Into_Sample_Set_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_Sample_Accept.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button_ShowNotice_Click(sender As Object, e As EventArgs) Handles Button_ShowNotice.Click
        Form_Notice.Show()

        Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        cmd.CommandText = "select Note from table_Sample_Set where Country_Code = '" & L_SS_Country_Code.Text & "' and Client_ID = '" & L_SS_Client_ID.Text & "' and Year = '" & L_SS_Year.Text & "' and Sample_Set_Id = '" & L_SS_Sample_Set_ID.Text & "' and Sample_Set_Index = '" & L_SS_Sample_Set_Index.Text & "'"
        cmd.Connection = sqlConnection1
        sqlConnection1.Open()
        reader = cmd.ExecuteReader()
        reader.Read()
        Form_Notice.RichTextBoxFormNotice.Text = reader(0)
        sqlConnection1.Close()
    End Sub

    'TODO: translation 
    Private Sub BShowSumAbEls_Click(sender As Object, e As EventArgs) Handles BShowSumAbEls.Click
        Dim fels As New Form_ElsSum
        Debug.WriteLine("Start samples summary creation")
        fels.LablelElSumCountryCode.Text = L_SS_Country_Code.Text
        fels.LabelElSumClientId.Text = L_SS_Client_ID.Text
        fels.LabelElSumYear.Text = L_SS_Year.Text
        fels.LabelElSumSetId.Text = L_SS_Sample_Set_ID.Text
        fels.LabelElSumSetIndex.Text = L_SS_Sample_Set_Index.Text
        fels.Show()
    End Sub

End Class