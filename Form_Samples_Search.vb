Imports System.Data.SqlClient

Public Class Form_Samples_Search
    Dim Separate_Elements(64) As String

    Private Sub Form_Search_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Search_FormClosed)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_Search_FormClosed)!", MsgBoxStyle.Critical, Me.Text)
            End If
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

    Private Sub Form_Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "Русский" Then
                Me.Text = "Поиск образцов"

                L_Name_Sample_Set.Text = "Партия образцов"
                L_Name_Country.Text = "Страна"
                L_Name_Last_Name.Text = "Фамилия клиента"
                L_Name_Organization.Text = "Организация клиента"
                L_Name_Sample_Set_Scheme_Type.Text = "Тип схемы"
                L_Name_Client_S_ID.Text = "№ клиента"

                L_Name_NAA_Results.Text = "Результаты НАА"
                L_Name_NAA_Results_Scheme_Type.Text = "Тип схемы"
                L_Name_NAA_Results_Separate_Elements.Text = "Отдельные элементы"

                B_Run.Text = "Искать"
                B_Save.Text = "Сохранить результаты"
                B_Close.Text = "Закрыть"

                SaveFileDialog_Search_Results.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "Samples search"

                L_Name_Sample_Set.Text = "Sample set"
                L_Name_Country.Text = "Country"
                L_Name_Last_Name.Text = "Client's last name"
                L_Name_Organization.Text = "Client's organization"
                L_Name_Sample_Set_Scheme_Type.Text = "Scheme type"
                L_Name_Client_S_ID.Text = "Client ID"

                L_Name_NAA_Results.Text = "NAA results"
                L_Name_NAA_Results_Scheme_Type.Text = "Scheme type"
                L_Name_NAA_Results_Separate_Elements.Text = "Separate elements"

                B_Run.Text = "Run"
                B_Save.Text = "Save results"
                B_Close.Text = "Close"

                SaveFileDialog_Search_Results.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            End If

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Received_By". При необходимости она может быть перемещена или удалена.
            Me.Table_Received_ByTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Received_ByTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Received_By)
            ''TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Client". При необходимости она может быть перемещена или удалена.
            'Me.Table_ClientTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Client)
            ''TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Country". При необходимости она может быть перемещена или удалена.
            'Me.Table_CountryTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Country)
            'DataGridView_Table_Sample.Columns.Count = 6

            CheckedListBox_Sample_Set_Client.Items.Clear()

            'Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim cmd As New SqlCommand
            'Dim reader As SqlDataReader

            '' поиск кода страны по выбранной стране
            'cmd.CommandText = "SELECT Country FROM dbo.table_Country ORDER BY Country"
            'cmd.CommandType = CommandType.Text
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'reader = cmd.ExecuteReader()
            '' Data is accessible through the DataReader object here.

            'While reader.Read()
            '    If Not IsDBNull(reader(0)) Then
            '        If Not reader(0) = "" Then
            '            CheckedListBox_Sample_Set_Country.Items.Add(reader(0))
            '        End If
            '    End If
            'End While

            'sqlConnection1.Close()

            Separate_Elements(0) = "F"    '1
            Separate_Elements(1) = "Na"   '2
            Separate_Elements(2) = "Mg"   '3
            Separate_Elements(3) = "Al"   '4
            Separate_Elements(4) = "Si"   '5
            Separate_Elements(5) = "S"    '6
            Separate_Elements(6) = "Cl"   '7
            Separate_Elements(7) = "K"    '8
            Separate_Elements(8) = "Ca"   '9
            Separate_Elements(9) = "Sc"  '10
            Separate_Elements(10) = "Ti" '11
            Separate_Elements(11) = "V"  '12
            Separate_Elements(12) = "Cr" '13
            Separate_Elements(13) = "Mn" '14
            Separate_Elements(14) = "Fe" '15
            Separate_Elements(15) = "Co" '16
            Separate_Elements(16) = "Ni" '17
            Separate_Elements(17) = "Cu" '18
            Separate_Elements(18) = "Zn" '19
            Separate_Elements(19) = "Ga" '20
            Separate_Elements(20) = "Ge" '21
            Separate_Elements(21) = "As" '22
            Separate_Elements(22) = "Se" '23
            Separate_Elements(23) = "Br" '24
            Separate_Elements(24) = "Rb" '25
            Separate_Elements(25) = "Sr" '26
            Separate_Elements(26) = "Y"  '27
            Separate_Elements(27) = "Zr" '28
            Separate_Elements(28) = "Nb" '29
            Separate_Elements(29) = "Mo" '30
            Separate_Elements(30) = "Ru" '31
            Separate_Elements(31) = "Pd" '32
            Separate_Elements(32) = "Ag" '33
            Separate_Elements(33) = "Cd" '34
            Separate_Elements(34) = "In" '35
            Separate_Elements(35) = "Sn" '36
            Separate_Elements(36) = "Sb" '37
            Separate_Elements(37) = "I"  '38
            Separate_Elements(38) = "Cs" '39
            Separate_Elements(39) = "Ba" '40
            Separate_Elements(40) = "La" '41
            Separate_Elements(41) = "Ce" '42
            Separate_Elements(42) = "Pr" '43
            Separate_Elements(43) = "Nd" '44
            Separate_Elements(44) = "Sm" '45
            Separate_Elements(45) = "Eu" '46
            Separate_Elements(46) = "Gd" '47
            Separate_Elements(47) = "Tb" '48
            Separate_Elements(48) = "Dy" '49
            Separate_Elements(49) = "Ho" '50
            Separate_Elements(50) = "Er" '51
            Separate_Elements(51) = "Tm" '52
            Separate_Elements(52) = "Yb" '53
            Separate_Elements(53) = "Lu" '54
            Separate_Elements(54) = "Hf" '55
            Separate_Elements(55) = "Ta" '56
            Separate_Elements(56) = "W"  '57
            Separate_Elements(57) = "Re" '58
            Separate_Elements(58) = "Os" '59
            Separate_Elements(59) = "Ir" '60
            Separate_Elements(60) = "Pt" '61
            Separate_Elements(61) = "Au" '62
            Separate_Elements(62) = "Hg" '63
            Separate_Elements(63) = "Th" '64
            Separate_Elements(64) = "U"  '65

            'DataGridView_Table_Sample.ColumnCount = 242

            With DataGridView_Table_Sample
                'Dim g As Graphics = .CreateGraphics()
                'Dim offset As Integer = Convert.ToInt32(Math.Ceiling(g.MeasureString("  ", .ColumnHeadersDefaultCellStyle.Font).Width))
                .Columns.Clear()

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(0).HeaderText = "Страна"
                ElseIf Form_Main.language = "English" Then
                    .Columns(0).HeaderText = "Country"
                End If
                .Columns(0).ReadOnly = True

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(1).HeaderText = "Клиентский номер"
                ElseIf Form_Main.language = "English" Then
                    .Columns(1).HeaderText = "Client ID"
                End If
                .Columns(1).ReadOnly = True

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(2).HeaderText = "Год"
                ElseIf Form_Main.language = "English" Then
                    .Columns(2).HeaderText = "Year"
                End If
                .Columns(2).ReadOnly = True

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(3).HeaderText = "Номер партии"
                ElseIf Form_Main.language = "English" Then
                    .Columns(3).HeaderText = "Sample set ID"
                End If
                .Columns(3).ReadOnly = True

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(4).HeaderText = "Инд. партии образцов"
                ElseIf Form_Main.language = "English" Then
                    .Columns(4).HeaderText = "Sample set ind."
                End If
                .Columns(4).ReadOnly = True

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(5).HeaderText = "№ образца"
                ElseIf Form_Main.language = "English" Then
                    .Columns(5).HeaderText = "Sample ID"
                End If
                .Columns(5).ReadOnly = True

                .Columns.Add(New DataGridViewTextBoxColumn())
                If Form_Main.language = "Русский" Then
                    .Columns(6).HeaderText = "Файл спектра"
                ElseIf Form_Main.language = "English" Then
                    .Columns(6).HeaderText = "File spectrum"
                End If
                .Columns(6).ReadOnly = True

                For i = 0 To 64 'всего 65 элементов ' а не надо ли здесь поменять 4 * i + 2 на 4 * i + 3?
                    '.Columns.Add(New DataGridViewCheckBoxColumn())
                    '.Columns(5 + 4 * i + 2).HeaderText = Separate_Elements(i)
                    '.Columns(5 + 4 * i + 2).ReadOnly = True
                    .Columns.Add(New DataGridViewTextBoxColumn())
                    If Form_Main.language = "Русский" Then
                        .Columns(5 + 3 * i + 2).HeaderText = Separate_Elements(i) + ", конц., uгр/гр"
                    ElseIf Form_Main.language = "English" Then
                        .Columns(5 + 3 * i + 2).HeaderText = Separate_Elements(i) + ", conc., ugr/gr"
                    End If
                    .Columns(5 + 3 * i + 2).ReadOnly = True
                    .Columns.Add(New DataGridViewTextBoxColumn())
                    If Form_Main.language = "Русский" Then
                        .Columns(5 + 3 * i + 3).HeaderText = Separate_Elements(i) + ", погр., %"
                    ElseIf Form_Main.language = "English" Then
                        .Columns(5 + 3 * i + 3).HeaderText = Separate_Elements(i) + ", error, %"
                    End If
                    .Columns(5 + 3 * i + 3).ReadOnly = True
                    .Columns.Add(New DataGridViewTextBoxColumn())
                    If Form_Main.language = "Русский" Then
                        .Columns(5 + 3 * i + 4).HeaderText = Separate_Elements(i) + ", пр. обн., uгр/гр"
                    ElseIf Form_Main.language = "English" Then
                        .Columns(5 + 3 * i + 4).HeaderText = Separate_Elements(i) + ", det. lim., ugr/gr"
                    End If
                    .Columns(5 + 3 * i + 4).ReadOnly = True
                Next
                .AutoResizeColumns()
            End With

            L_Last_Name.Text = "-"
            L_Organization.Text = "-"
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Search_Load)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_Search_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox_Country_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Country.SelectedIndexChanged
        Try
            L_Last_Name.Text = "-"
            L_Organization.Text = "-"

            Dim Country_Code As String
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

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

            CheckedListBox_Sample_Set_Client.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then
                    CheckedListBox_Sample_Set_Client.Items.Add(reader(0))
                End If
            End While
            'If ComboBox_Client_ID.Items.Count > 0 Then ComboBox_Client_ID.Items.Add("")
            sqlConnection1.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_Country_SelectionChangeCommitted)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in ComboBox_Country_SelectionChangeCommitted)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Run_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Run.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            If ComboBox_Country.SelectedItem = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите страну!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select country!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim Query_Text, Country_Code As String
            Query_Text = "SELECT F_Country_Code, F_Client_ID, F_Year, F_Sample_SET_ID, F_Sample_SET_Index, A_Sample_ID, "

            Query_Text = Query_Text + " R_File_Spectrum, "

            For i = 0 To 64 'всего 65 элементов
                If i < 64 Then Query_Text = Query_Text + "R_" + Separate_Elements(i) + "_Concentaration, " + "R_" + Separate_Elements(i) + "_Error, " + "R_" + Separate_Elements(i) + "_Detection_Limit, "
                If i = 64 Then Query_Text = Query_Text + "R_" + Separate_Elements(i) + "_Concentaration, " + "R_" + Separate_Elements(i) + "_Error, " + "R_" + Separate_Elements(i) + "_Detection_Limit"
            Next



            Query_Text = Query_Text + " FROM table_Sample WHERE"

            Country_Code = ""
            If ComboBox_Country.Text <> "" Then
                ' поиск кода страны по выбранной стране
                cmd.CommandText = "SELECT Country_Code FROM table_Country WHERE Country = '" + ComboBox_Country.SelectedItem + "'"
                cmd.CommandType = CommandType.Text
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then Country_Code = reader(0)
                End While
                Query_Text = Query_Text + " F_Country_Code='" + Country_Code + "' AND"
            End If
            sqlConnection1.Close()


            'Query_Text = Query_Text + " ("











            For i = 0 To CheckedListBox_Sample_Set_Client.Items.Count - 1

                If CheckedListBox_Sample_Set_Client.GetItemChecked(i) = True Then
                    Query_Text = Query_Text + " ("

                    Query_Text = Query_Text + " F_Client_ID='" + CheckedListBox_Sample_Set_Client.Items.Item(i) + "' AND"

                    'Query_Text = Query_Text + " ("
                    For ii = 0 To CheckedListBox_NAA_Results_Separate_Elements.Items.Count - 1
                        If CheckedListBox_NAA_Results_Separate_Elements.GetItemChecked(ii) = True Then Query_Text = Query_Text + " R_" + Separate_Elements(ii) + "_Concentaration>'0' " + ComboBox_NAA_Results_Scheme_Type.Text
                    Next

                    ' это для отсечения последних при перечислении AND OR на конце
                    Query_Text = Query_Text.TrimEnd(" ", "A", "N", "D")
                    Query_Text = Query_Text.TrimEnd(" ", "O", "R")
                    Query_Text = Query_Text + ") "

                    '' это если страна(ы) выбраны, а элементы - нет и надо отсечь AND () на конце 
                    'Query_Text = Replace(Query_Text, "()", "")
                    'Query_Text = Query_Text.TrimEnd(" ", "A", "N", "D")
                    'Query_Text = Query_Text.TrimEnd(" ", "O", "R")


                    'Query_Text = Query_Text + ") "

                    Query_Text = Query_Text + ComboBox_Sample_Set_Scheme_Type.Text
                End If
                ' это для отсечения последних при перечислении AND OR на конце
                'Query_Text = Query_Text.TrimEnd(" ", "A", "N", "D")
                'Query_Text = Query_Text.TrimEnd(" ", "O", "R")
                ''Query_Text = Query_Text + ") "

                '' это если страна(ы) выбраны, а элементы - нет и надо отсечь AND () на конце 
                'Query_Text = Replace(Query_Text, "()", "")
                'Query_Text = Query_Text.TrimEnd(" ", "A", "N", "D")
                'Query_Text = Query_Text.TrimEnd(" ", "O", "R")
                ''Query_Text = Query_Text + " AND"
            Next









            Query_Text = Query_Text.TrimEnd(" ", "A", "N", "D")
            Query_Text = Query_Text.TrimEnd(" ", "O", "R")

            'Query_Text = Query_Text + ") "







            Query_Text = Query_Text + " ORDER BY F_Year, F_Sample_Set_ID"

            DataGridView_Table_Sample.Rows.Clear()

            cmd.CommandText = Query_Text
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()

            While reader.Read()
                DataGridView_Table_Sample.Rows.Add()
                For i = 0 To 201
                    If Not IsDBNull(reader(i)) Then
                        'If reader(i) <> "False" Then
                        DataGridView_Table_Sample(i, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(i)
                        'End If

                    End If
                Next
                'If Not IsDBNull(reader(0)) Then DataGridView_Table_Sample(0, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(0)
                'If Not IsDBNull(reader(1)) Then DataGridView_Table_Sample(1, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(1)
                'If Not IsDBNull(reader(2)) Then DataGridView_Table_Sample(2, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(2)
                'If Not IsDBNull(reader(3)) Then DataGridView_Table_Sample(3, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(3)
                'If Not IsDBNull(reader(4)) Then DataGridView_Table_Sample(4, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(4)
                'If Not IsDBNull(reader(5)) Then DataGridView_Table_Sample(5, DataGridView_Table_Sample.Rows.Count - 1).Value = reader(5)
            End While
            sqlConnection1.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Run_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Run_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save.Click
        Dim Data_From_DataGridView(,) As String
        ReDim Data_From_DataGridView(DataGridView_Table_Sample.Rows.Count + 1, DataGridView_Table_Sample.Columns.Count)
        Try
            SaveFileDialog_Search_Results.InitialDirectory = "C:\"

            SaveFileDialog_Search_Results.FileName = "Search_Results.xlsx"

            If SaveFileDialog_Search_Results.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 

                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                'Открыть новую книгу Excel
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.columns.horizontalalignment = -4152 'xlright выравнивание по правому краю ячейки
                oSheet.columns.ColumnWidth = 14 'ширина колонки 

                ' записываем заголовки
                For j = 0 To DataGridView_Table_Sample.Columns.Count - 1
                    Data_From_DataGridView(0, j) = DataGridView_Table_Sample.Columns(j).HeaderText
                Next

                ' записываем данные
                For i = 0 To DataGridView_Table_Sample.Rows.Count - 1
                    For j = 0 To DataGridView_Table_Sample.Columns.Count - 1
                        If IsNothing(DataGridView_Table_Sample.Rows(i).Cells(j).Value) Then
                            Data_From_DataGridView(i + 1, j) = ""
                        ElseIf DataGridView_Table_Sample.Rows(i).Cells(j).Value.ToString = "False" Then
                            Data_From_DataGridView(i + 1, j) = ""
                        Else
                            Data_From_DataGridView(i + 1, j) = DataGridView_Table_Sample.Rows(i).Cells(j).Value.ToString()
                        End If

                    Next
                Next

                'Передать массив на лист, начиная с ячейки A1
                oSheet.Range("A1").Resize(DataGridView_Table_Sample.Rows.Count + 1, DataGridView_Table_Sample.Columns.Count).Value = Data_From_DataGridView

                'Сохранить книгу и закрыть Excel
                Dim FI As IO.FileInfo = New IO.FileInfo(SaveFileDialog_Search_Results.FileName)
                Try
                    If FI.Exists Then
                        FI.Delete()
                    End If
                    oBook.SaveAs(SaveFileDialog_Search_Results.FileName)
                    oExcel.Quit()
                Catch ex As Exception
                    If Form_Main.language = "Русский" Then
                        MsgBox("Закройте файл Excel!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("Close the Excel file!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End Try
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub CheckedListBox_Sample_Set_Client_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CheckedListBox_Sample_Set_Client.SelectedIndexChanged
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader
            Dim Country_Code As String

            L_Last_Name.Text = ""
            L_Organization.Text = ""

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

            cmd.CommandText = "SELECT Last_Name, Organization FROM dbo.table_Client WHERE Client_ID = '" + CheckedListBox_Sample_Set_Client.SelectedItem + "' AND Country_Code = '" + Country_Code + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.

            While reader.Read()
                If Not IsDBNull(reader(0)) Then L_Last_Name.Text = reader(0)
                If Not IsDBNull(reader(1)) Then L_Organization.Text = reader(1)

            End While
            sqlConnection1.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в CheckedListBox_Sample_Set_Client_SelectedIndexChanged)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in CheckedListBox_Sample_Set_Client_SelectedIndexChanged)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class