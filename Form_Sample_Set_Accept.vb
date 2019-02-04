Imports System.Data.SqlClient

Public Class Form_Sample_Set_Accept
    Dim Country_Code As String
    Public Notes_Number As Integer
    Public Client_Action As String

    Private Sub Form_NewSampleAccept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "Русский" Then
                Me.Text = "Приём новой партии образцов"
                L_Name_Country.Text = "Страна"
                L_Name_Client_ID.Text = "Номер клиента"

                L_Name_Country_Code.Text = "Код страны:"
                L_Name_Postal_Code.Text = "Индекс:"
                L_Name_Republic.Text = "Республика:"
                L_Name_Region.Text = "Область:"
                L_Name_District.Text = "Район:"
                L_Name_City.Text = "Город:"
                L_Name_Street.Text = "Улица:"
                L_Name_House.Text = "Дом:"
                L_Name_Building.Text = "Строение:"
                L_Name_Organization.Text = "Организация:"
                'L_Name_Title.Text = "Title:"
                L_Name_Gender.Text = "Пол:"
                L_Name_Last_Name.Text = "Фамилия:"
                L_Name_First_Name.Text = "Имя:"
                'L_Name_Middle_Name.Text = "Middle name:"
                'L_Name_Phone_Country_Code_Phone_1.Text = "Country code:"
                'L_Name_Code_Phone_1.Text = "Code:"
                L_Name_Phone_1.Text = "Телефон 1:"
                'L_Name_Phone_Country_Code_Phone_2.Text = "Country code:"
                'L_Name_Code_Phone_2.Text = "Code:"
                L_Name_Phone_2.Text = "Телефон 2:"
                'L_Name_Phone_Country_Code_Fax_1.Text = "Country code:"
                'L_Name_Code_Fax_1.Text = "Code:"
                L_Name_Fax_1.Text = "Факс 1:"
                'L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Country code:"
                'L_Name_Code_Mobile_Phone_1.Text = "Code:"
                L_Name_Mobile_Phone_1.Text = "Моб. тел. 1:"
                L_Name_E_mail_1.Text = "e-mail 1:"
                L_Name_E_mail_2.Text = "e-mail 2:"
                L_Name_Notes.Text = "Примечания:"

                B_NewClient.Text = "Добавить нового клиента"
                B_Correct_Client_Info.Text = "Изменить информацию о клиенте"
                L_Name_Sample_Set_List.Text = "Список партий образцов"
                L_Name_New_Sample_Set_ID.Text = "Номер новой партии"
                L_Name_New_Sample_Set_Index.Text = "Индекс новой партии"
                L_Name_SampleSetReceiptDate.Text = "Дата приёма партии образцов"
                L_Name_SampleSetReportDate.Text = "Дата возврата партии образцов"

                L_Name_Notes_1.Text = "Примечания"
                B_Fill_Notes_1.Text = "Заполнить примечания"

                L_Name_ReceivedBy.Text = "Принято"
                Label_Name_Code.Text = "Страна-Клиент-Год-№ парт.-Ин. п."
                B_SaveNewSampleAcceptance.Text = "Сохранить новую партию"
                B_Print_Preview_Form.Text = "Форма для печати"
                B_Close.Text = "Закрыть"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "New sample set acceptance"
                L_Name_Country.Text = "Country"
                L_Name_Client_ID.Text = "Client ID"

                L_Name_Country_Code.Text = "Country code:"
                L_Name_Postal_Code.Text = "Postal code:"
                L_Name_Republic.Text = "Republic:"
                L_Name_Region.Text = "Region:"
                L_Name_District.Text = "Area:"
                L_Name_City.Text = "City:"
                L_Name_Street.Text = "Street:"
                L_Name_House.Text = "House:"
                L_Name_Building.Text = "Building:"
                L_Name_Organization.Text = "Organization:"
                'L_Name_Title.Text = "Title:"
                L_Name_Gender.Text = "Gender:"
                L_Name_Last_Name.Text = "Last name:"
                L_Name_First_Name.Text = "Fist name:"
                'L_Name_Middle_Name.Text = "Middle name:"
                'L_Name_Phone_Country_Code_Phone_1.Text = "Country code:"
                'L_Name_Code_Phone_1.Text = "Code:"
                L_Name_Phone_1.Text = "Phone 1:"
                'L_Name_Phone_Country_Code_Phone_2.Text = "Country code:"
                'L_Name_Code_Phone_2.Text = "Code:"
                L_Name_Phone_2.Text = "Phone 2:"
                'L_Name_Phone_Country_Code_Fax_1.Text = "Country code:"
                'L_Name_Code_Fax_1.Text = "Code:"
                L_Name_Fax_1.Text = "Fax 1:"
                'L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Country code:"
                'L_Name_Code_Mobile_Phone_1.Text = "Code:"
                L_Name_Mobile_Phone_1.Text = "Mob. phone 1:"
                L_Name_E_mail_1.Text = "e-mail 1:"
                L_Name_E_mail_2.Text = "e-mail 2:"
                L_Name_Notes.Text = "Notes:"

                B_NewClient.Text = "Add new client"
                B_Correct_Client_Info.Text = "Change client info"
                L_Name_Sample_Set_List.Text = "Sample set list"
                L_Name_New_Sample_Set_ID.Text = "New sample set ID"
                L_Name_New_Sample_Set_Index.Text = "New sample set index"
                L_Name_SampleSetReceiptDate.Text = "Sample set acceptance date"
                L_Name_SampleSetReportDate.Text = "Sample set report date"

                L_Name_Notes_1.Text = "Notes"
                B_Fill_Notes_1.Text = "Fill the notes "

                L_Name_ReceivedBy.Text = "Received by"
                Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
                B_SaveNewSampleAcceptance.Text = "Save new sample set"
                B_Print_Preview_Form.Text = "Form for printing"
                B_Close.Text = "Close"
            End If
            With Table_Sample_SetDataGridView
                Dim g As Graphics = .CreateGraphics()
                Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))

                '.Columns.Clear()
                '.RowHeadersWidth = 21

                '    If Form_Main.language = "Русский" Then
                '        .Columns.Add("A_Year", "Год")
                '    ElseIf Form_Main.language = "English" Then
                '        .Columns.Add("A_Year", "Year")
                '    End If
                '    .Columns(0).DataPropertyName = "A_Year" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                '    .Columns(0).ReadOnly = True
                '    .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Year", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                If Form_Main.language = "Русский" Then
                    .Columns(0).HeaderText = "Год"
                ElseIf Form_Main.language = "English" Then
                    .Columns(0).HeaderText = "Year"
                End If
                .Columns(0).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("Year", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '    If Form_Main.language = "Русский" Then
                '        .Columns.Add("A_Sample_Set_ID", "Номер партии образцов")
                '    ElseIf Form_Main.language = "English" Then
                '        .Columns.Add("A_Sample_Set_ID", "Sample set ID")
                '    End If
                '    .Columns(1).DataPropertyName = "A_Sample_Set_ID" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                '    .Columns(1).ReadOnly = True
                If Form_Main.language = "Русский" Then
                    .Columns(1).HeaderText = "Номер партии образцов"
                ElseIf Form_Main.language = "English" Then
                    .Columns(1).HeaderText = "Sample set ID"
                End If
                .Columns(1).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '    If Form_Main.language = "Русский" Then
                '        .Columns.Add("A_Sample_Set_Index", "Индекс партии образцов")
                '    ElseIf Form_Main.language = "English" Then
                '        .Columns.Add("A_Sample_Set_Index", "Sample set index")
                '    End If
                '    .Columns(2).DataPropertyName = "A_Sample_Set_Index" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                '    .Columns(2).ReadOnly = True
                If Form_Main.language = "Русский" Then
                    .Columns(2).HeaderText = "Индекс партии образцов"
                ElseIf Form_Main.language = "English" Then
                    .Columns(2).HeaderText = "Sample set index"
                End If
                .Columns(2).Width = Convert.ToInt32(Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
            End With
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_NewSampleAccept_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_NewSampleAccept_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub Table_ClientIDComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            L_NSSID_Client_ID.Text = ComboBox_Client_ID.Text
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Table_ClientIDComboBox_SelectedIndexChanged!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Table_ClientIDComboBox_SelectedIndexChanged!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Table_ClientIDComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Client_ID.SelectionChangeCommitted
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            L_NSSID_Client_ID.Text = ComboBox_Client_ID.SelectedItem

            L_Country_Code.Text = ""
            L_Postal_Code.Text = ""
            L_Republic.Text = ""
            L_Region.Text = ""
            L_District.Text = ""
            L_City.Text = ""
            L_Street.Text = ""
            L_House.Text = ""
            L_Building.Text = ""
            L_Organization.Text = ""
            L_Title.Text = ""
            L_Gender.Text = ""
            L_Last_Name.Text = ""
            L_First_Name.Text = ""
            L_Phone_Country_Code_Phone_1.Text = ""
            L_Code_Phone_1.Text = ""
            L_Phone_1.Text = ""
            L_Phone_Country_Code_Phone_2.Text = ""
            L_Code_Phone_2.Text = ""
            L_Phone_2.Text = ""
            L_Phone_Country_Code_Fax_1.Text = ""
            L_Code_Fax_1.Text = ""
            L_Fax_1.Text = ""
            L_Phone_Country_Code_Mobile_Phone_1.Text = ""
            L_Code_Mobile_Phone_1.Text = ""
            L_Mobile_Phone_1.Text = ""
            L_E_mail_1.Text = ""
            L_E_mail_2.Text = ""
            L_Notes.Text = ""

            cmd.CommandText = "SELECT Country_Code, Postal_Code, Republic, Region, Area, City, Street, House, Building, Organization, Title, Gender, Last_Name, First_Name, Phone_Country_Code_Phone_1, Code_Phone_1, Phone_1, Phone_Country_Code_Phone_2, Code_Phone_2, Phone_2, Phone_Country_Code_Fax_1, Code_Fax_1, Fax_1, Phone_Country_Code_Mobile_Phone_1, Code_Mobile_Phone_1, Mobile_Phone_1, E_mail_1, E_mail_2, Notes FROM dbo.table_Client WHERE Client_ID = '" + ComboBox_Client_ID.SelectedItem + "' AND Country_Code = '" + Country_Code + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.

            While reader.Read()
                If Not IsDBNull(reader(0)) Then L_Country_Code.Text = reader(0)
                If Not IsDBNull(reader(1)) Then L_Postal_Code.Text = reader(1)
                If Not IsDBNull(reader(2)) Then L_Republic.Text = reader(2)
                If Not IsDBNull(reader(3)) Then L_Region.Text = reader(3)
                If Not IsDBNull(reader(4)) Then L_District.Text = reader(4)
                If Not IsDBNull(reader(5)) Then L_City.Text = reader(5)
                If Not IsDBNull(reader(6)) Then L_Street.Text = reader(6)
                If Not IsDBNull(reader(7)) Then L_House.Text = reader(7)
                If Not IsDBNull(reader(8)) Then L_Building.Text = reader(8)
                If Not IsDBNull(reader(9)) Then L_Organization.Text = reader(9)
                If Not IsDBNull(reader(10)) Then L_Title.Text = reader(10)
                If Not IsDBNull(reader(11)) Then L_Gender.Text = reader(11)
                If Not IsDBNull(reader(12)) Then L_Last_Name.Text = reader(12)
                If Not IsDBNull(reader(13)) Then L_First_Name.Text = reader(13)
                If Not IsDBNull(reader(14)) Then L_Phone_Country_Code_Phone_1.Text = reader(14)
                If Not IsDBNull(reader(15)) Then L_Code_Phone_1.Text = reader(15)
                If Not IsDBNull(reader(16)) Then L_Phone_1.Text = reader(16)
                If Not IsDBNull(reader(17)) Then L_Phone_Country_Code_Phone_2.Text = reader(17)
                If Not IsDBNull(reader(18)) Then L_Code_Phone_2.Text = reader(18)
                If Not IsDBNull(reader(19)) Then L_Phone_2.Text = reader(19)
                If Not IsDBNull(reader(20)) Then L_Phone_Country_Code_Fax_1.Text = reader(20)
                If Not IsDBNull(reader(21)) Then L_Code_Fax_1.Text = reader(21)
                If Not IsDBNull(reader(22)) Then L_Fax_1.Text = reader(22)
                If Not IsDBNull(reader(23)) Then L_Phone_Country_Code_Mobile_Phone_1.Text = reader(23)
                If Not IsDBNull(reader(24)) Then L_Code_Mobile_Phone_1.Text = reader(24)
                If Not IsDBNull(reader(25)) Then L_Mobile_Phone_1.Text = reader(25)
                If Not IsDBNull(reader(26)) Then L_E_mail_1.Text = reader(26)
                If Not IsDBNull(reader(27)) Then L_E_mail_2.Text = reader(27)
                If Not IsDBNull(reader(28)) Then L_Notes.Text = reader(28)
            End While
            sqlConnection1.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Table_ClientIDComboBox_SelectionChangeCommittedd!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Table_ClientIDComboBox_SelectionChangeCommittedd!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_NewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_NewClient.Click
        Try
            Form_Add_New_Client.Table_CountryComboBox_ANC.Text = ""
            Form_Add_New_Client.TextBox_E_mail_1.Text = "@"
            Form_Add_New_Client.TextBox_E_mail_2.Text = "@"
            Client_Action = "new client"
            Me.Enabled = False
            Form_Add_New_Client.Show()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_NewClient_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_NewClient_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub MaskedTextBox_NewSampleSetID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox_New_Sample_Set_ID.TextChanged
        Try
            L_NSSID_New_Sample_Set_ID.Text = MaskedTextBox_New_Sample_Set_ID.Text
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в MaskedTextBox_NewSampleSetID_TextChanged!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in MaskedTextBox_NewSampleSetID_TextChanged!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_SaveNewSampleAcceptance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_SaveNewSampleAcceptance.Click
        Dim ReceiptDate, ReportDate As Date
        Try
            ReceiptDate = MaskedTextBox_Sample_Set_Receipt_Date.Text
            ReportDate = MaskedTextBox_Sample_Set_Report_Date.Text
            If ReportDate < ReceiptDate Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Дата возврата не должна быть раньше даты приёма!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Report date must not by earlier receipt date!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Проверьте даты!", MsgBoxStyle.Exclamation, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Check dates!", MsgBoxStyle.Exclamation, Me.Text)
            End If
            Exit Sub
        End Try
        Try
            Dim value As Integer
            If L_NSSID_Country_Code.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите страну!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select country!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If L_NSSID_Client_ID.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите номер клиента!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select client ID!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Sample_Set_Report_Date.Text = "  .  ." Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите дату возврата партии образцов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type sample set report date!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_New_Sample_Set_ID.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите номер новой партии образцов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type new sample set ID!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            value = MaskedTextBox_New_Sample_Set_ID.Text
            If value = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Номер новой партии образцов должен быть > 0!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("New sample set ID must be > 0!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If value < 10 Then
                MaskedTextBox_New_Sample_Set_ID.Text = "0" + value.ToString
            End If
            If ComboBox_Table_ReceivedBy.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If


            'If ComboBox_Table_ReceivedBy.Text.Equals("Chepurchenko O.E.") Or (ComboBox_Table_ReceivedBy.Text.ToString <> "Alekseenok Yu.V.") Or (ComboBox_Table_ReceivedBy.Text.ToString <> "Vergel K.N.") Then
            '    If Form_Main.language = "Русский" Then
            '        MsgBox("Вы не можете добавлять партии. Обратитесь к Чепурченко О.Е.", MsgBoxStyle.Exclamation, Me.Text)
            '    ElseIf Form_Main.language = "English" Then
            '        MsgBox("You don't have rights for add sets!", MsgBoxStyle.Exclamation, Me.Text)
            '    End If
            '    Exit Sub
            'End If

                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Sample_Set WHERE Sample_Set_ID='" + MaskedTextBox_New_Sample_Set_ID.Text +
                                  "' and Sample_Set_Index='" + MaskedTextBox_New_Sample_Set_Index.Text + "' and Year='" + L_NSSID_Year.Text + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If reader(0) > 0 Then
                        If Form_Main.language = "Русский" Then
                            MsgBox("Партия образцов с таким номером уже существует!", MsgBoxStyle.Exclamation, Me.Text)
                        ElseIf Form_Main.language = "English" Then
                            MsgBox("This sample set ID already exist!", MsgBoxStyle.Exclamation, Me.Text)
                        End If
                        sqlConnection1.Close()
                        Exit Sub
                    End If
                End While
                sqlConnection1.Close()

            cmd.CommandText = "INSERT dbo.table_Sample_Set (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_Set_Receipt_Date, Sample_Set_Report_Date, Received_By, Note) " +
                     "VALUES ('" + Country_Code + "', '" + ComboBox_Client_ID.Text + "', '" + L_NSSID_Year.Text + "', '" +
                     MaskedTextBox_New_Sample_Set_ID.Text + "', '" + MaskedTextBox_New_Sample_Set_Index.Text + "', '" +
                     MaskedTextBox_Sample_Set_Receipt_Date.Text + "', '" +
                     MaskedTextBox_Sample_Set_Report_Date.Text + "', '" + ComboBox_Table_ReceivedBy.Text + "', '" +
                     TextBox_Notes_1.Text + "')"
            cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.ExecuteNonQuery()
                sqlConnection1.Close()

                'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SampleSetID". При необходимости она может быть перемещена или удалена.
                ' Form_Main.Table_Sample_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                'Form_Main.Table_Sample_Set_TableAdapter.Fill(Form_Main.NAA_DB_EXPDataSet.table_Sample_Set)
                Form_Main.DataSampleSetLoad("")

                'Form_Main.DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = Form_Main.DataGridView_Sample_Set.RowCount - 1
                'For i = 0 To Form_Main.DataGridView_Sample_Set.RowCount - 1
                '    Form_Main.DataGridView_Sample_Set.Rows.Item(i).Selected = False
                'Next
                'Form_Main.DataGridView_Sample_Set.Rows.Item(Form_Main.DataGridView_Sample_Set.RowCount - 1).Selected = True

                'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SampleSet". При необходимости она может быть перемещена или удалена.
                '  Table_Sample_SetTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                '   Me.Table_Sample_SetTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Sample_Set)
                '  Table_Sample_SetDataGridView.FirstDisplayedScrollingRowIndex = Table_Sample_SetDataGridView.RowCount - 1
                '   For i = 0 To Table_Sample_SetDataGridView.RowCount - 1
                'Table_Sample_SetDataGridView.Rows.Item(i).Selected = False
                '  Next
                '  Table_Sample_SetDataGridView.Rows.Item(Table_Sample_SetDataGridView.RowCount - 1).Selected = True


                If Form_Main.language = "Русский" Then
                    MsgBox("Сделано!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Done!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Me.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_SaveNewSampleAcceptance_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_SaveNewSampleAcceptance_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Table_CountryComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Country.SelectionChangeCommitted
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            L_Country_Code.Text = ""
            L_Postal_Code.Text = ""
            L_Republic.Text = ""
            L_Region.Text = ""
            L_City.Text = ""
            L_Street.Text = ""
            L_House.Text = ""
            L_Building.Text = ""
            L_Organization.Text = ""
            L_Title.Text = ""
            L_Last_Name.Text = ""
            L_First_Name.Text = ""
            L_Phone_Country_Code_Phone_1.Text = ""
            L_Code_Phone_1.Text = ""
            L_Phone_1.Text = ""
            L_Phone_Country_Code_Phone_2.Text = ""
            L_Code_Phone_2.Text = ""
            L_Phone_2.Text = ""
            L_Phone_Country_Code_Fax_1.Text = ""
            L_Code_Fax_1.Text = ""
            L_Fax_1.Text = ""
            L_Phone_Country_Code_Mobile_Phone_1.Text = ""
            L_Code_Mobile_Phone_1.Text = ""
            L_Mobile_Phone_1.Text = ""
            L_E_mail_1.Text = ""
            L_E_mail_2.Text = ""
            L_Notes.Text = ""

            L_NSSID_Client_ID.Text = ""

            'Dim s As String
            's = Table_CountryComboBox.  'если этого не сделать, пропадёт выбранный элемент в списке стран
            'Table_CountryTableAdapter.Fill(NAA_DB_EXPDataSet.table_Country)
            'Table_CountryComboBox.SelectedValue = s

            ' поиск кода страны по выбранной стране
            cmd.CommandText = "SELECT Country_Code FROM dbo.table_Country WHERE Country = '" + ComboBox_Country.SelectedItem + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.
            Country_Code = ""
            While reader.Read()
                If Not IsDBNull(reader(0)) Then Country_Code = reader(0)
            End While

            sqlConnection1.Close()

            'поиск ID клиента по коду страны
            cmd.CommandText = "SELECT Client_ID FROM dbo.table_Client WHERE Country_Code = '" + Country_Code + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.
            ComboBox_Client_ID.Text = ""
            ComboBox_Client_ID.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then ComboBox_Client_ID.Items.Add(reader(0))
            End While
            'If ComboBox_Client_ID.Items.Count > 0 Then ComboBox_Client_ID.Items.Add("")
            sqlConnection1.Close()

            L_NSSID_Country_Code.Text = Country_Code
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Table_CountryComboBox_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Table_CountryComboBox_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Print_Preview_Form_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Print_Preview_Form.Click
        Try
            'очищаем форму печати 
            
            Form_Sample_Set_Accept_Print_Form.L_Country.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Postal_Code.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Republic.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Region.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_District.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_City.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Street.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_House.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Building.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Organization.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Title.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Last_Name.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_First_Name.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Phone_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Code_Phone_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Phone_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Phone_2.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Code_Phone_2.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Phone_2.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Fax_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Code_Fax_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Fax_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Mobile_Phone_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Code_Mobile_Phone_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Mobile_Phone_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_E_mail_1.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_E_mail_2.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Notes.Text = ""

            Form_Sample_Set_Accept_Print_Form.L_Sample_Set_Receipt_Date.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Sample_Set_Report_Date.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_Notes_1.Text = ""

            Form_Sample_Set_Accept_Print_Form.L_Received_By.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_NSSID_Country_Code.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_NSSID_Client_ID.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_NSSID_Year.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_NSSID_New_Sample_Set_ID.Text = ""
            Form_Sample_Set_Accept_Print_Form.L_NSSID_New_Sample_Set_Index.Text = ""

            'заполняем форму печати
            Form_Sample_Set_Accept_Print_Form.L_Country.Text = ComboBox_Country.Text
            Form_Sample_Set_Accept_Print_Form.L_Postal_Code.Text = L_Postal_Code.Text
            Form_Sample_Set_Accept_Print_Form.L_Republic.Text = L_Republic.Text
            Form_Sample_Set_Accept_Print_Form.L_Region.Text = L_Region.Text
            Form_Sample_Set_Accept_Print_Form.L_District.Text = L_Region.Text
            Form_Sample_Set_Accept_Print_Form.L_City.Text = L_City.Text
            Form_Sample_Set_Accept_Print_Form.L_Street.Text = L_Street.Text
            Form_Sample_Set_Accept_Print_Form.L_House.Text = L_House.Text
            Form_Sample_Set_Accept_Print_Form.L_Building.Text = L_Building.Text
            Form_Sample_Set_Accept_Print_Form.L_Organization.Text = L_Organization.Text
            Form_Sample_Set_Accept_Print_Form.L_Title.Text = L_Title.Text
            Form_Sample_Set_Accept_Print_Form.L_Last_Name.Text = L_Last_Name.Text
            Form_Sample_Set_Accept_Print_Form.L_First_Name.Text = L_First_Name.Text
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Phone_1.Text = L_Phone_Country_Code_Phone_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Code_Phone_1.Text = L_Code_Phone_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Phone_1.Text = L_Phone_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Phone_2.Text = L_Phone_Country_Code_Phone_2.Text
            Form_Sample_Set_Accept_Print_Form.L_Code_Phone_2.Text = L_Code_Phone_2.Text
            Form_Sample_Set_Accept_Print_Form.L_Phone_2.Text = L_Phone_2.Text
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Fax_1.Text = L_Phone_Country_Code_Fax_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Code_Fax_1.Text = L_Code_Fax_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Fax_1.Text = L_Fax_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Phone_Country_Code_Mobile_Phone_1.Text = L_Phone_Country_Code_Mobile_Phone_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Code_Mobile_Phone_1.Text = L_Code_Mobile_Phone_1.Text
            Form_Sample_Set_Accept_Print_Form.L_Mobile_Phone_1.Text = L_Mobile_Phone_1.Text
            Form_Sample_Set_Accept_Print_Form.L_E_mail_1.Text = L_E_mail_1.Text
            Form_Sample_Set_Accept_Print_Form.L_E_mail_2.Text = L_E_mail_2.Text
            Form_Sample_Set_Accept_Print_Form.L_Notes.Text = L_Notes.Text

            Form_Sample_Set_Accept_Print_Form.L_Sample_Set_Receipt_Date.Text = MaskedTextBox_Sample_Set_Receipt_Date.Text
            Form_Sample_Set_Accept_Print_Form.L_Sample_Set_Report_Date.Text = MaskedTextBox_Sample_Set_Report_Date.Text
            Form_Sample_Set_Accept_Print_Form.L_Notes_1.Text = TextBox_Notes_1.Text

            Form_Sample_Set_Accept_Print_Form.L_Received_By.Text = ComboBox_Table_ReceivedBy.Text
            Form_Sample_Set_Accept_Print_Form.L_NSSID_Country_Code.Text = L_NSSID_Country_Code.Text
            Form_Sample_Set_Accept_Print_Form.L_NSSID_Client_ID.Text = L_NSSID_Client_ID.Text
            Form_Sample_Set_Accept_Print_Form.L_NSSID_Year.Text = L_NSSID_Year.Text
            Form_Sample_Set_Accept_Print_Form.L_NSSID_New_Sample_Set_ID.Text = L_NSSID_New_Sample_Set_ID.Text
            Form_Sample_Set_Accept_Print_Form.L_NSSID_New_Sample_Set_Index.Text = L_NSSID_New_Sample_Set_Index.Text

            Me.Enabled = False
            Form_Sample_Set_Accept_Print_Form.Show()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Print_Preview_Form_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Print_Preview_Form_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_Notes_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_Notes_1.Click
        Try
            Notes_Number = 1
            Form_Fill_Notes.Show()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_Notes_1_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Fill_Notes_1_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_New_Sample_Set_Accept_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в MaskedTextBox_New_Sample_Set_Index_TextChanged!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in MaskedTextBox_New_Sample_Set_Index_TextChanged!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Correct_Client_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Correct_Client_Info.Click
        Try
            Client_Action = "correct client"
            If ComboBox_Country.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите страну!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select country!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Client_ID.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите номер клиента!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select cleint ID!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            'L_Country_Code.Text = ""
            Form_Add_New_Client.TextBox_Postal_Code.Text = ""
            Form_Add_New_Client.TextBox_Republic.Text = ""
            Form_Add_New_Client.TextBox_Region.Text = ""
            Form_Add_New_Client.TextBox_District.Text = ""
            Form_Add_New_Client.TextBox_City.Text = ""
            Form_Add_New_Client.TextBox_Street.Text = ""
            Form_Add_New_Client.TextBox_House.Text = ""
            Form_Add_New_Client.TextBox_Building.Text = ""
            Form_Add_New_Client.TextBox_Organization.Text = ""
            Form_Add_New_Client.ComboBox_Title.Text = ""
            Form_Add_New_Client.ComboBox_Gender.Text = ""
            Form_Add_New_Client.TextBox_Last_Name.Text = ""
            Form_Add_New_Client.TextBox_First_Name.Text = ""
            Form_Add_New_Client.TextBox_Phone_Country_Code_Phone_1.Text = ""
            Form_Add_New_Client.TextBox_Code_Phone_1.Text = ""
            Form_Add_New_Client.TextBox_Phone_1.Text = ""
            Form_Add_New_Client.TextBox_Phone_Country_Code_Phone_2.Text = ""
            Form_Add_New_Client.TextBox_Code_Phone_2.Text = ""
            Form_Add_New_Client.TextBox_Phone_2.Text = ""
            Form_Add_New_Client.TextBox_Phone_Country_Code_Fax_1.Text = ""
            Form_Add_New_Client.TextBox_Code_Fax_1.Text = ""
            Form_Add_New_Client.TextBox_Fax_1.Text = ""
            Form_Add_New_Client.TextBox_Phone_Country_Code_Mobile_Phone_1.Text = ""
            Form_Add_New_Client.TextBox_Code_Mobile_Phone_1.Text = ""
            Form_Add_New_Client.TextBox_Mobile_Phone_1.Text = ""
            Form_Add_New_Client.TextBox_E_mail_1.Text = ""
            Form_Add_New_Client.TextBox_E_mail_2.Text = ""
            Form_Add_New_Client.TextBox_Notes.Text = ""

            'L_NSSID_Client_ID.Text = ""
            Form_Add_New_Client.Table_CountryComboBox_ANC.Text = ComboBox_Country.Text
            Form_Add_New_Client.MaskedTextBox_NewClientID.Text = ComboBox_Client_ID.Text

            cmd.CommandText = "SELECT Country_Code, Postal_Code, Republic, Region, Area, City, Street, House, Building, Organization, Title, Gender, Last_Name, First_Name, Middle_Name, Phone_Country_Code_Phone_1, Code_Phone_1, Phone_1, Phone_Country_Code_Phone_2, Code_Phone_2, Phone_2, Phone_Country_Code_Fax_1, Code_Fax_1, Fax_1, Phone_Country_Code_Mobile_Phone_1, Code_Mobile_Phone_1, Mobile_Phone_1, E_mail_1, E_mail_2, Notes FROM dbo.table_Client WHERE Client_ID = '" + ComboBox_Client_ID.SelectedItem + "' AND Country_Code = '" + Country_Code + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.

            While reader.Read()
                'If Not IsDBNull(reader(0)) Then L_Country_Code.Text = reader(0)
                If Not IsDBNull(reader(1)) Then Form_Add_New_Client.TextBox_Postal_Code.Text = reader(1)
                If Not IsDBNull(reader(2)) Then Form_Add_New_Client.TextBox_Republic.Text = reader(2)
                If Not IsDBNull(reader(3)) Then Form_Add_New_Client.TextBox_Region.Text = reader(3)
                If Not IsDBNull(reader(4)) Then Form_Add_New_Client.TextBox_District.Text = reader(4)
                If Not IsDBNull(reader(5)) Then Form_Add_New_Client.TextBox_City.Text = reader(5)
                If Not IsDBNull(reader(6)) Then Form_Add_New_Client.TextBox_Street.Text = reader(6)
                If Not IsDBNull(reader(7)) Then Form_Add_New_Client.TextBox_House.Text = reader(7)
                If Not IsDBNull(reader(8)) Then Form_Add_New_Client.TextBox_Building.Text = reader(8)
                If Not IsDBNull(reader(9)) Then Form_Add_New_Client.TextBox_Organization.Text = reader(9)
                If Not IsDBNull(reader(10)) Then Form_Add_New_Client.ComboBox_Title.Text = reader(10)
                If Not IsDBNull(reader(11)) Then Form_Add_New_Client.ComboBox_Gender.Text = reader(11)
                If Not IsDBNull(reader(12)) Then Form_Add_New_Client.TextBox_Last_Name.Text = reader(12)
                If Not IsDBNull(reader(13)) Then Form_Add_New_Client.TextBox_First_Name.Text = reader(13)
                If Not IsDBNull(reader(14)) Then Form_Add_New_Client.TextBox_Middle_Name.Text = reader(14)
                If Not IsDBNull(reader(15)) Then Form_Add_New_Client.TextBox_Phone_Country_Code_Phone_1.Text = reader(15)
                If Not IsDBNull(reader(16)) Then Form_Add_New_Client.TextBox_Code_Phone_1.Text = reader(16)
                If Not IsDBNull(reader(17)) Then Form_Add_New_Client.TextBox_Phone_1.Text = reader(17)
                If Not IsDBNull(reader(18)) Then Form_Add_New_Client.TextBox_Phone_Country_Code_Phone_2.Text = reader(18)
                If Not IsDBNull(reader(19)) Then Form_Add_New_Client.TextBox_Code_Phone_2.Text = reader(19)
                If Not IsDBNull(reader(20)) Then Form_Add_New_Client.TextBox_Phone_2.Text = reader(20)
                If Not IsDBNull(reader(21)) Then Form_Add_New_Client.TextBox_Phone_Country_Code_Fax_1.Text = reader(21)
                If Not IsDBNull(reader(22)) Then Form_Add_New_Client.TextBox_Code_Fax_1.Text = reader(22)
                If Not IsDBNull(reader(23)) Then Form_Add_New_Client.TextBox_Fax_1.Text = reader(23)
                If Not IsDBNull(reader(24)) Then Form_Add_New_Client.TextBox_Phone_Country_Code_Mobile_Phone_1.Text = reader(24)
                If Not IsDBNull(reader(25)) Then Form_Add_New_Client.TextBox_Code_Mobile_Phone_1.Text = reader(25)
                If Not IsDBNull(reader(26)) Then Form_Add_New_Client.TextBox_Mobile_Phone_1.Text = reader(26)
                If Not IsDBNull(reader(27)) Then Form_Add_New_Client.TextBox_E_mail_1.Text = reader(27)
                If Not IsDBNull(reader(28)) Then Form_Add_New_Client.TextBox_E_mail_2.Text = reader(28)
                If Not IsDBNull(reader(29)) Then Form_Add_New_Client.TextBox_Notes.Text = reader(29)
                Form_Add_New_Client.Show()
            End While
            sqlConnection1.Close()
            Me.Enabled = False
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Correct_Client_Info_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Correct_Client_Info_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub MaskedTextBox_New_Sample_Set_Index_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox_New_Sample_Set_Index.TextChanged
        Try
            L_NSSID_New_Sample_Set_Index.Text = MaskedTextBox_New_Sample_Set_Index.Text
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в MaskedTextBox_New_Sample_Set_Index_TextChanged!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in MaskedTextBox_New_Sample_Set_Index_TextChanged!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class