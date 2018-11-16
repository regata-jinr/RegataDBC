Imports System.Data.SqlClient
Public Class Form_SRM_Set_Accept
    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Try
            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Save_New_SRM_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save_New_SRM_Set.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If TextBox_New_Monitor_Set_Name.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите имя партии стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type SRM set name!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_SRM_Set_Number.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер партии стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type SRM set number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_SRM_Set WHERE SRM_Set_Name='" + TextBox_New_Monitor_Set_Name.Text + "' and SRM_Set_Number=" + MaskedTextBox_New_SRM_Set_Number.Text.Trim + ""
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If reader(0) > 0 Then
                    If Form_Main.language = "russian" Then
                        MsgBox("Партия стандартов с таким номером уже существует!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "english" Then
                        MsgBox("This SRM set already exist!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    sqlConnection1.Close()
                    Exit Sub
                End If
            End While
            sqlConnection1.Close()

            If ComboBox_SRM_Set_Type.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите тип партии стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select type of SRM set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_SRM_Set_Weight.Text = "   ," Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите вес партии стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type weight of SRM set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_SRM_Set_Purchasing_Date.Text = "  .  ." Then
                If Form_Main.language = "russian" Then
                    MsgBox("проверьте дату!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Check date!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If MaskedTextBox_New_SRM_Set_Number.Text > 99 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Максимальный номер партии стандартов не должен быть > 99!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Maximum SRM set number must not be > 99!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_SRM_Set_Number.Text < 10 Then
                MaskedTextBox_New_SRM_Set_Number.Text = "0" + (CInt(MaskedTextBox_New_SRM_Set_Number.Text)).ToString
            End If
            cmd.CommandText = "INSERT dbo.table_SRM_Set (SRM_Set_Name, SRM_Set_Number, SRM_Set_Type, SRM_Set_Weight, SRM_Set_Purchasing_Date) " +
                 "VALUES ('" + TextBox_New_Monitor_Set_Name.Text + "', '" + MaskedTextBox_New_SRM_Set_Number.Text + "', '" +
                             ComboBox_SRM_Set_Type.Text + "', " +
                            Replace(MaskedTextBox_New_SRM_Set_Weight.Text, ",", ".") + ", '" + MaskedTextBox_New_SRM_Set_Purchasing_Date.Text + "')"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM_Set". При необходимости она может быть перемещена или удалена.
            'Form_Main.Table_SRM_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Form_Main.Table_SRM_Set_TableAdapter.Fill(Form_Main.NAA_DB_EXPDataSet.table_SRM_Set)

            Form_Main.Table_SRM_SetDataGridView.FirstDisplayedScrollingRowIndex = Form_Main.Table_SRM_SetDataGridView.RowCount - 1
            For i = 0 To Form_Main.Table_SRM_SetDataGridView.RowCount - 1
                Form_Main.Table_SRM_SetDataGridView.Rows.Item(i).Selected = False
            Next

            Form_Main.Table_SRM_SetDataGridView.Rows.Item(Form_Main.Table_SRM_SetDataGridView.RowCount - 1).Selected = True

            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Save_New_SRM_Set_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Save_New_SRM_Set_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_New_SRM_Set_Accept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "russian" Then
                Me.Text = "Новая партия стандартов"

                L_Name_New_SRM_Set_Name.Text = "Имя новой партии"
                L_Name_New_SRM_Set_Number.Text = "Новый номер"
                L_Name_SRM_Set_Type.Text = "Тип партии стандартов"
                L_Name_New_SRM_Set_Weight.Text = "Вес партии, гр"
                L_Name_SRM_New_Set_Purchasing_Date.Text = "Дата покупки"

                B_Save_New_SRM_Set.Text = "Сохранить новую партию стандартов"
                B_Close.Text = "Закрыть"
            ElseIf Form_Main.language = "english" Then
                Me.Text = "New SRM set"

                L_Name_New_SRM_Set_Name.Text = "New SRM set name"
                L_Name_New_SRM_Set_Number.Text = "New number"
                L_Name_SRM_Set_Type.Text = "Type of SRM set"
                L_Name_New_SRM_Set_Weight.Text = "Weight of set, g"
                L_Name_SRM_New_Set_Purchasing_Date.Text = "Purchasing date"

                B_Save_New_SRM_Set.Text = "Save new SRM set"
                B_Close.Text = "Close"
            End If

            With Table_SRM_SetDataGridView
                Dim g As Graphics = .CreateGraphics()
                Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))
                .Columns.Clear()

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Name", "Имя")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Set_Name", "Name")
                End If
                .Columns(0).DataPropertyName = "SRM_Set_Name" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("NameName", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Number", "Номер")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Set_Number", "Number")
                End If
                .Columns(1).DataPropertyName = "SRM_Set_Number"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Number", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM_Set". При необходимости она может быть перемещена или удалена.
                Table_SRM_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_SRM_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_SRM_Set)

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
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_New_SRM_Set_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_New_SRM_Set_Accept_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_New_SRM_Set_Accept_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_New_SRM_Set_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_New_SRM_Set_Accept_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class