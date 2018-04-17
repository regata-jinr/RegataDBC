Imports System.Data.SqlClient

Public Class Form_Add_New_Client
    Dim Country_Code As String

    Private Sub Form_AddNewClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "russian" Then
                Me.Text = "Информация о клиенте"

                L_Name_Country.Text = "Страна"
                L_Name_Client_ID.Text = "Номер клиента"
                L_Name_New_Client_ID.Text = "Номер нового клиентя"
                L_Name_Postal_Code.Text = "Индекс"
                L_Name_Republic.Text = "Республика"
                L_Name_Region.Text = "Область"
                L_Name_District.Text = "Район"
                L_Name_City.Text = "Город"
                L_Name_Street.Text = "Улица"
                L_Name_House.Text = "Дом"
                L_Name_Building.Text = "Строение"
                L_Name_Organization.Text = "Организация"
                L_Name_Title.Text = "Обр."
                L_Name_Gender.Text = "Пол"
                L_Name_Last_Name.Text = "Фамилия"
                L_Name_First_Name.Text = "Имя"
                L_Name_Middle_Name.Text = "Отчество"
                L_Name_Phone_Country_Code_Phone_1.Text = "Тел КС"
                L_Name_Code_Phone_1.Text = "Код"
                L_Name_Phone_1.Text = "Телефон 1"
                L_Name_Phone_Country_Code_Phone_2.Text = "Тел КС"
                L_Name_Code_Phone_2.Text = "Код"
                L_Name_Phone_2.Text = "Телефон 2"
                L_Name_Phone_Country_Code_Fax_1.Text = "Тел КС"
                L_Name_Code_Fax_1.Text = "Код"
                L_Name_Fax_1.Text = "Факс 1"
                L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Тел КС"
                L_Name_Code_Mobile_Phone_1.Text = "Код"
                L_Name_Mobile_Phone_1.Text = "Моб. тел. 1"
                L_Name_E_mail_1.Text = "e-mail 1"
                L_Name_E_mail_2.Text = "e-mail 2"
                L_Name_Notes.Text = "Примечания"

                B_Save_New_Client_ID.Text = "Сохранить информацию о клиенте"
                B_Fill_In_From_File.Text = "Заполнить из файла"
                B_Close.Text = "Закрыть"
            ElseIf Form_Main.language = "english" Then
                Me.Text = "Information about client"

                L_Name_Country.Text = "Country"
                L_Name_Client_ID.Text = "Client ID"
                L_Name_New_Client_ID.Text = "New сlient ID"
                L_Name_Postal_Code.Text = "Postal code"
                L_Name_Republic.Text = "Republic"
                L_Name_Region.Text = "Region"
                L_Name_District.Text = "District"
                L_Name_City.Text = "City"
                L_Name_Street.Text = "Street"
                L_Name_House.Text = "House"
                L_Name_Building.Text = "Building"
                L_Name_Organization.Text = "Organization"
                L_Name_Title.Text = "Title"
                L_Name_Gender.Text = "Gender"
                L_Name_Last_Name.Text = "Last name"
                L_Name_First_Name.Text = "Fist name"
                L_Name_Middle_Name.Text = "Middle name"
                L_Name_Phone_Country_Code_Phone_1.Text = "Phone CC"
                L_Name_Code_Phone_1.Text = "Code"
                L_Name_Phone_1.Text = "Phone 1"
                L_Name_Phone_Country_Code_Phone_2.Text = "Phone CC"
                L_Name_Code_Phone_2.Text = "Code"
                L_Name_Phone_2.Text = "Phone 2"
                L_Name_Phone_Country_Code_Fax_1.Text = "Phone CC"
                L_Name_Code_Fax_1.Text = "Code"
                L_Name_Fax_1.Text = "Fax 1"
                L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Phone CC"
                L_Name_Code_Mobile_Phone_1.Text = "Code"
                L_Name_Mobile_Phone_1.Text = "Mob. phone 1"
                L_Name_E_mail_1.Text = "e-mail 1"
                L_Name_E_mail_2.Text = "e-mail 2"
                L_Name_Notes.Text = "Notes"

                B_Save_New_Client_ID.Text = "Save new client ID"
                B_Fill_In_From_File.Text = "Fill in from file"
                B_Close.Text = "Close"
            End If
     
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader
            cmd.CommandText = "SELECT Country FROM dbo.Table_Country ORDER By Country"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()

            Table_CountryComboBox_ANC.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then Table_CountryComboBox_ANC.Items.Add(reader(0))
            End While
            sqlConnection1.Close()

            If Form_Sample_Set_Accept.Client_Action = "new client" Then
                Table_CountryComboBox_ANC.Enabled = True
                ListBox_ClientID.Enabled = True
                MaskedTextBox_NewClientID.Enabled = True
            End If
            If Form_Sample_Set_Accept.Client_Action = "correct client" Then
                Table_CountryComboBox_ANC.Text = Form_Sample_Set_Accept.ComboBox_Country.Text
                Table_CountryComboBox_ANC.Enabled = False
                ListBox_ClientID.Enabled = False
                MaskedTextBox_NewClientID.Enabled = False
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_AddNewClient_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_AddNewClient_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub CountryComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table_CountryComboBox_ANC.SelectionChangeCommitted
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            'Dim s As String
            's = Table_CountryComboBox_ANC.SelectedValue 'если этого не сделать, пропадёт выбранный элемент в списке стран
            'Table_CountryTableAdapter.Fill(NAA_DB_EXPDataSet.table_Country)
            'Table_CountryComboBox_ANC.SelectedValue = s

            ' поиск кода страны и телефонного кода страны по выбранной стране
            cmd.CommandText = "SELECT Country_Code, Phone_Country_Code FROM table_Country WHERE Country = '" + Table_CountryComboBox_ANC.SelectedItem + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.
            Country_Code = ""
            While reader.Read()
                Country_Code = reader(0)
                TextBox_E_mail_1.Text = "@." + reader(0).ToString.ToLower
                TextBox_E_mail_2.Text = "@." + reader(0).ToString.ToLower
                TextBox_Phone_Country_Code_Phone_1.Text = reader(1)
                TextBox_Phone_Country_Code_Phone_2.Text = reader(1)
                TextBox_Phone_Country_Code_Fax_1.Text = reader(1)
                TextBox_Phone_Country_Code_Mobile_Phone_1.Text = reader(1)
            End While
            sqlConnection1.Close()

            'поиск ID клиента по коду страны
            cmd.CommandText = "SELECT Client_ID FROM dbo.table_Client WHERE Country_Code = '" + Country_Code + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.
            ListBox_ClientID.Text = ""
            ListBox_ClientID.Items.Clear()
            While reader.Read()
                ListBox_ClientID.Items.Add(reader(0))
            End While
            sqlConnection1.Close()

            Dim value As Integer

            If ListBox_ClientID.Items.Count = 0 Then
                value = 1
                MaskedTextBox_NewClientID.Text = value.ToString
                'MaskedTextBox_NewClientID.Text = value.ToString("D" + 2.ToString())
                GoTo 1
            ElseIf ListBox_ClientID.Items.Count > 0 Then
                ListBox_ClientID.SelectedItem = ListBox_ClientID.Items(ListBox_ClientID.Items.Count - 1)
            End If

            'поиск максимального значения ID клиента по коду страны
            cmd.CommandText = "SELECT MAX(Client_ID) FROM dbo.Table_Client WHERE Country_Code = '" + Country_Code + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            'select max(serial_key) from test_for_find
            While reader.Read()
                value = reader(0) + 1 'следующий номер партии образцов
                If value > 99 Then
                    If Form_Main.language = "russian" Then
                        MsgBox("Максимальный номер партии не должен быть > 99!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "english" Then
                        MsgBox("Maximum sample set ID must not be > 99!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If

                If value < 10 Then
                    MaskedTextBox_NewClientID.Text = "0" + value.ToString
                Else
                    MaskedTextBox_NewClientID.Text = value.ToString
                End If

                'Dim decimalLength As Integer
                'decimalLength = value.ToString("D").Length + 1
                'If value >= 10 Then
                '    MaskedTextBox_NewClientID.Text = value
                'Else
                '    MaskedTextBox_NewClientID.Text = value.ToString("D" + decimalLength.ToString()) 'здесь добавляется ноль в начале номера, если номер меньше 10
                'End If
            End While
            sqlConnection1.Close()
1:
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в CountryComboBox_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in CountryComboBox_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

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

    Private Sub B_Save_new_client_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save_New_Client_ID.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            If Table_CountryComboBox_ANC.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите страну!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select country!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_NewClientID.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер нового клиента!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type new client ID!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            Dim value As Integer
            value = MaskedTextBox_NewClientID.Text
            If value = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Номер нового клиента должен быть > 0!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("New client ID must be > 0!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If value < 10 Then
                MaskedTextBox_NewClientID.Text = "0" + value.ToString
            End If
            If Form_Sample_Set_Accept.Client_Action = "new client" Then
                cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Client WHERE Client_ID='" + MaskedTextBox_NewClientID.Text + "' and Country_Code='" + Country_Code + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If reader(0) > 0 Then
                        If Form_Main.language = "russian" Then
                            MsgBox("Клиент с таким номером уже существует!", MsgBoxStyle.Exclamation, Me.Text)
                        ElseIf Form_Main.language = "english" Then
                            MsgBox("Сlient with this client ID already exist!", MsgBoxStyle.Exclamation, Me.Text)
                        End If
                        sqlConnection1.Close()
                        Exit Sub
                    End If
                End While
                sqlConnection1.Close()

                cmd.CommandText = "INSERT dbo.table_Client (Client_ID, Country_Code, Country, Postal_Code, Republic, Region, Area, City, Street, House, Building, Organization, Title, Gender, Last_Name, First_Name, Middle_Name, Phone_Country_Code_Phone_1, Code_Phone_1, Phone_1, Phone_Country_Code_Phone_2, Code_Phone_2, Phone_2, Phone_Country_Code_Fax_1, Code_Fax_1, Fax_1, Phone_Country_Code_Mobile_Phone_1, Code_Mobile_Phone_1, Mobile_Phone_1, E_mail_1, E_mail_2, Notes) " +
                    "VALUES ('" + MaskedTextBox_NewClientID.Text + "', '" + Country_Code + "', '" + Table_CountryComboBox_ANC.Text + "', '" +
                    TextBox_Postal_Code.Text + "', '" +
                    TextBox_Republic.Text + "', '" + TextBox_Region.Text + "', '" + TextBox_District.Text + "', '" +
                    TextBox_City.Text + "', '" + TextBox_Street.Text + "', '" +
                    TextBox_House.Text + "', '" + TextBox_Building.Text + "', '" + TextBox_Organization.Text + "', '" +
                    ComboBox_Title.Text + "', '" + ComboBox_Gender.Text + "', '" +
                    TextBox_Last_Name.Text + "', '" + TextBox_First_Name.Text + "', '" + TextBox_Middle_Name.Text + "', '" +
                    TextBox_Phone_Country_Code_Phone_1.Text + "', '" + TextBox_Code_Phone_1.Text + "', '" + TextBox_Phone_1.Text + "', '" +
                    TextBox_Phone_Country_Code_Phone_2.Text + "', '" + TextBox_Code_Phone_2.Text + "', '" + TextBox_Phone_2.Text + "', '" +
                    TextBox_Phone_Country_Code_Fax_1.Text + "', '" + TextBox_Code_Fax_1.Text + "', '" + TextBox_Fax_1.Text + "', '" +
                    TextBox_Phone_Country_Code_Mobile_Phone_1.Text + "', '" + TextBox_Code_Mobile_Phone_1.Text + "', '" +
                    TextBox_Mobile_Phone_1.Text + "', '" + TextBox_E_mail_1.Text + "', '" + TextBox_E_mail_2.Text + "', '" +
                    TextBox_Notes.Text + "')"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.ExecuteNonQuery()
                sqlConnection1.Close()
            End If

            If Form_Sample_Set_Accept.Client_Action = "correct client" Then

                cmd.CommandText = "UPDATE dbo.table_Client SET Postal_Code='" + TextBox_Postal_Code.Text +
                "', Republic='" + TextBox_Republic.Text + "', Region='" + TextBox_Region.Text +
                "', Area='" + TextBox_District.Text +
                "', City='" + TextBox_City.Text + "', Street='" + TextBox_Street.Text +
                "', House='" + TextBox_House.Text + "', Building='" + TextBox_Building.Text +
                "', Organization='" + TextBox_Organization.Text + "', Title='" + ComboBox_Title.Text +
                "', Gender='" + ComboBox_Gender.Text +
                "', Last_Name='" + TextBox_Last_Name.Text + "', First_Name='" + TextBox_First_Name.Text +
                "', Middle_Name='" + TextBox_Middle_Name.Text + "', Phone_Country_Code_Phone_1='" + TextBox_Phone_Country_Code_Phone_1.Text +
                "', Code_Phone_1='" + TextBox_Code_Phone_1.Text + "', Phone_1='" + TextBox_Phone_1.Text +
                "', Phone_Country_Code_Phone_2='" + TextBox_Phone_Country_Code_Phone_2.Text + "', Code_Phone_2='" + TextBox_Code_Phone_2.Text +
                "', Phone_2='" + TextBox_Phone_2.Text + "', Phone_Country_Code_Fax_1='" + TextBox_Phone_Country_Code_Fax_1.Text +
                "', Code_Fax_1='" + TextBox_Code_Fax_1.Text + "', Fax_1='" + TextBox_Fax_1.Text +
                "', Phone_Country_Code_Mobile_Phone_1='" + TextBox_Phone_Country_Code_Mobile_Phone_1.Text + "', Code_Mobile_Phone_1='" + TextBox_Code_Mobile_Phone_1.Text +
                "', Mobile_Phone_1='" + TextBox_Mobile_Phone_1.Text + "', E_mail_1='" + TextBox_E_mail_1.Text +
                "', E_mail_2='" + TextBox_E_mail_2.Text + "', Notes='" + TextBox_Notes.Text +
                "' WHERE Client_ID='" + MaskedTextBox_NewClientID.Text + "' and Country_Code='" + Form_Sample_Set_Accept.L_Country_Code.Text + "' and Country='" + Table_CountryComboBox_ANC.Text + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.ExecuteNonQuery()
                sqlConnection1.Close()
            End If

            Form_Sample_Set_Accept.ComboBox_Country.Text = ""

            Form_Sample_Set_Accept.ComboBox_Client_ID.Items.Clear()
            Form_Sample_Set_Accept.L_NSSID_Country_Code.Text = ""
            Form_Sample_Set_Accept.L_NSSID_Client_ID.Text = ""

            Form_Sample_Set_Accept.L_Country_Code.Text = ""
            Form_Sample_Set_Accept.L_Postal_Code.Text = ""
            Form_Sample_Set_Accept.L_Republic.Text = ""
            Form_Sample_Set_Accept.L_Region.Text = ""
            Form_Sample_Set_Accept.L_District.Text = ""
            Form_Sample_Set_Accept.L_City.Text = ""
            Form_Sample_Set_Accept.L_Street.Text = ""
            Form_Sample_Set_Accept.L_House.Text = ""
            Form_Sample_Set_Accept.L_Building.Text = ""
            Form_Sample_Set_Accept.L_Organization.Text = ""
            Form_Sample_Set_Accept.L_Title.Text = ""
            Form_Sample_Set_Accept.L_Gender.Text = ""
            Form_Sample_Set_Accept.L_Last_Name.Text = ""
            Form_Sample_Set_Accept.L_First_Name.Text = ""
            Form_Sample_Set_Accept.L_Phone_Country_Code_Phone_1.Text = ""
            Form_Sample_Set_Accept.L_Code_Phone_1.Text = ""
            Form_Sample_Set_Accept.L_Phone_1.Text = ""
            Form_Sample_Set_Accept.L_Phone_Country_Code_Phone_2.Text = ""
            Form_Sample_Set_Accept.L_Code_Phone_2.Text = ""
            Form_Sample_Set_Accept.L_Phone_2.Text = ""
            Form_Sample_Set_Accept.L_Phone_Country_Code_Fax_1.Text = ""
            Form_Sample_Set_Accept.L_Code_Fax_1.Text = ""
            Form_Sample_Set_Accept.L_Fax_1.Text = ""
            Form_Sample_Set_Accept.L_Phone_Country_Code_Mobile_Phone_1.Text = ""
            Form_Sample_Set_Accept.L_Code_Mobile_Phone_1.Text = ""
            Form_Sample_Set_Accept.L_Mobile_Phone_1.Text = ""
            Form_Sample_Set_Accept.L_E_mail_1.Text = ""
            Form_Sample_Set_Accept.L_E_mail_2.Text = ""
            Form_Sample_Set_Accept.L_Notes.Text = ""

            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Save_new_client_ID_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Save_new_client_ID_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Add_New_Client_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Sample_Set_Accept.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_Add_New_Client_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_Add_New_Client_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_From_File.Click
        Try
            'OpenFileDialog_Add_New_Client_From_File.InitialDirectory = "C:\"
            If OpenFileDialog_Add_New_Client_From_File.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите файл!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select file!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Add_New_Client_From_File.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(" ")
                    Dim currentRow As String
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        If Form_Sample_Set_Accept.Client_Action = "new client" Then
                            Table_CountryComboBox_ANC.Text = currentRow
                            CountryComboBox_SelectionChangeCommitted(sender, e)
                        End If

                        currentRow = MyReader.ReadLine
                        TextBox_Postal_Code.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Republic.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Region.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_District.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_City.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Street.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_House.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Building.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Organization.Text = currentRow

                        currentRow = MyReader.ReadLine
                        ComboBox_Title.Text = currentRow

                        currentRow = MyReader.ReadLine
                        ComboBox_Gender.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Last_Name.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_First_Name.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Middle_Name.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Phone_Country_Code_Phone_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Code_Phone_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Phone_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Phone_Country_Code_Phone_2.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Code_Phone_2.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Phone_2.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Phone_Country_Code_Fax_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Code_Fax_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Fax_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Phone_Country_Code_Mobile_Phone_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Code_Mobile_Phone_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Mobile_Phone_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_E_mail_1.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_E_mail_2.Text = currentRow

                        currentRow = MyReader.ReadLine
                        TextBox_Notes.Text = currentRow
                    End While
                End Using
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_From_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class