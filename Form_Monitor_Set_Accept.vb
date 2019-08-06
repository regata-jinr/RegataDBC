Imports System.Data.SqlClient

Public Class Form_Monitor_Set_Accept

    Private Sub Form_Monitor_Set_Accept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "Русский" Then
                Me.Text = "Новая партия мониторов"

                L_Name_New_Monitor_Set_Name.Text = "Имя новой партии"
                L_Name_New_Monitor_Set_Number.Text = "Новый номер"
                L_Name_Monitor_Set_Type.Text = "Тип партии мониторов"
                L_Name_New_Monitor_Set_Weight.Text = "Вес партии, гр"
                L_Name_New_Monitor_Set_Purchasing_Date.Text = "Дата покупки"

                B_Save_New_Monitor_Set.Text = "Сохранить новую партию мониторов"
                B_Close.Text = "Закрыть"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "New monitor set"

                L_Name_New_Monitor_Set_Name.Text = "New monitor set name"
                L_Name_New_Monitor_Set_Number.Text = "New number"
                L_Name_Monitor_Set_Type.Text = "Type of monitor set"
                L_Name_New_Monitor_Set_Weight.Text = "Weight of set, g"
                L_Name_New_Monitor_Set_Purchasing_Date.Text = "Purchasing date"

                B_Save_New_Monitor_Set.Text = "Save new monitor set"
                B_Close.Text = "Close"
            End If

            With Table_Monitor_SetDataGridView
                Dim g As Graphics = .CreateGraphics()
                Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))
                .Columns.Clear()

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Name", "Имя")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Name", "Name")
                End If
                .Columns(0).DataPropertyName = "Monitor_Set_Name" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("NameName", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Number", "Номер")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Number", "Number")
                End If
                .Columns(1).DataPropertyName = "Monitor_Set_Number"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Number", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM_Set". При необходимости она может быть перемещена или удалена.
                Me.Table_Monitor_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_Monitor_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor_Set)

                If .RowCount > 1 Then
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
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Monitor_Set_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_Monitor_Set_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Monitor_Set_Accept_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Monitor_Set_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_Monitor_Set_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
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

    Private Sub B_Save_New_Monitor_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save_New_Monitor_Set.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If ComboBox_New_Monitor_Set_Name.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите имя партии мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select monitor set name!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_Monitor_Set_Number.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите номер партии мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type monitor set number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Monitor_Set WHERE Monitor_Set_Name='" + ComboBox_New_Monitor_Set_Name.Text + "' and Monitor_Set_Number=" + MaskedTextBox_New_Monitor_Set_Number.Text.Trim + ""
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If reader(0) > 0 Then
                    If Form_Main.language = "Русский" Then
                        MsgBox("Партия мониторов с таким номером уже существует!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("This monitor set already exist!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    sqlConnection1.Close()
                    Exit Sub
                End If
            End While
            sqlConnection1.Close()

            If ComboBox_Monitor_Set_Type.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите тип партии мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select type of monitor set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_Monitor_Set_Weight.Text = "   ," Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите вес партии мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type weight of monitor set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_Monitor_Set_Purchasing_Date.Text = "  .  ." Then
                If Form_Main.language = "Русский" Then
                    MsgBox("проверьте дату!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Check date!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If MaskedTextBox_New_Monitor_Set_Number.Text > 99 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Максимальный номер партии мониторов не должен быть > 99!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Maximum monitor set number must not be > 99!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_Monitor_Set_Number.Text < 10 Then
                MaskedTextBox_New_Monitor_Set_Number.Text = "0" + (CInt(MaskedTextBox_New_Monitor_Set_Number.Text)).ToString
            End If

            cmd.CommandText = "INSERT dbo.table_Monitor_Set (Monitor_Set_Name, Monitor_Set_Number, Monitor_Set_Type, Monitor_Set_Weight, Monitor_Set_Purchasing_Date) " +
                 "VALUES ('" + ComboBox_New_Monitor_Set_Name.Text + "', '" + MaskedTextBox_New_Monitor_Set_Number.Text + "', '" +
                             ComboBox_Monitor_Set_Type.Text + "', " +
                            Replace(MaskedTextBox_New_Monitor_Set_Weight.Text, ",", ".") + ", '" + MaskedTextBox_New_Monitor_Set_Purchasing_Date.Text + "')"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM_Set". При необходимости она может быть перемещена или удалена.
            'Form_Main.Table_Monitor_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Form_Main.Table_Monitor_Set_TableAdapter.Fill(Form_Main.NAA_DB_EXPDataSet.table_Monitor_Set)

            Form_Main.Table_Monitor_SetDataGridView.FirstDisplayedScrollingRowIndex = Form_Main.Table_Monitor_SetDataGridView.RowCount - 1
            For i = 0 To Form_Main.Table_Monitor_SetDataGridView.RowCount - 1
                Form_Main.Table_Monitor_SetDataGridView.Rows.Item(i).Selected = False
            Next

            Form_Main.Table_Monitor_SetDataGridView.Rows.Item(Form_Main.Table_Monitor_SetDataGridView.RowCount - 1).Selected = True

            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Save_New_Monitor_Set_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Save_New_Monitor_Set_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class