Imports System.Data.SqlClient
Imports SqlData

Public Class Form_Main
    Public us As String
    Public MyConnectionString As String
    Public arr() As Single
    Public Table_Elements(64) As String ' всего 65 элементов
    Public language = My.MySettings.Default.languaged
    Public SampleSetFormLoadFlag As Boolean = False
    Public fields As String = ""
    Public DataGridViewDescriptionFill As Boolean = False
    Public CountryCodeForOpenSet, ClientIDForOpenSet, YearForOpenSet, SampleSetIDForOpenSet, SampleSetIndexForOpenSet As String


    Sub DataSampleSetLoad(ByVal Field As String)
        Try
            ' Debug.WriteLine("DataSampleSetLoad:")
            SampleSetFormLoadFlag = False
            'Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            'Dim cmd As New System.Data.SqlClient.SqlCommand

            'cmd.CommandType = System.Data.CommandType.Text
            'fields = Field

            'cmd.CommandText = "select distinct sampSet.Country_Code, sampSet.Client_ID, sampSet.Year, sampSet.Sample_Set_ID, sampSet.Sample_Set_Index from SamplesSetForNaaDB as sampSet " + Field + " order by sampSet.Year desc, sampSet.Sample_Set_ID desc"

            'Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
            'Dim ds As New DataSet()

            'dataadapter.Fill(ds, "SampleInf")
            Dim testDS As New SqlGridView(MyConnectionString, "select distinct sampSet.Country_Code, sampSet.Client_ID, sampSet.Year, sampSet.Sample_Set_ID, sampSet.Sample_Set_Index from SamplesSetForNaaDB as sampSet order by sampSet.Year desc, sampSet.Sample_Set_ID desc")
            testDS.PartialFillingVertical(100)
            DataGridView_Sample_Set.DataSource = testDS.DataSource
            '  DataGridView_Sample_Set.DataMember = "SampleInf"
            DataGridView_Sample_Set.ReadOnly = True
            DataGridView_Sample_Set.AllowUserToAddRows = False
            DataGridView_Sample_Set.ClearSelection() ' вызывает срабатывание changeselection чтобы не было не выделенной строки при добавляем флаги SampleSetFormLoadFlag
            SampleSetFormLoadFlag = True

            'For i As Integer = 0 To (DataGridView_Sample_Set.RowCount - 1)
            '    DataGridView_Sample_Set.Rows.Item(i).Height = 24
            '    DataGridView_Sample_Set.Rows.Item(i).Selected = True
            '    ' Fill_In_Monitor()
            '    '  DataGridView_Sample_Set.Rows.Item(i).Selected = False
            'Next

            If DataGridView_Sample_Set.RowCount = 0 Then
                MsgBox("Таких значений нет")
                ' DataSampleSetLoad("")
                Exit Sub
            End If
            DataGridView_Sample_Set.Rows.Item(0).Selected = True
            DataGridView_Sample_Set.CurrentCell = DataGridView_Sample_Set.Rows(0).Cells(0)

            '  DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1
        Catch exS As SqlException
            LangException(language, exS.Message & vbCrLf & exS.ToString)
        Catch ex As Exception
            LangException(language, ex.Message & vbCrLf & ex.ToString)
            Exit Sub

        End Try

    End Sub

    Public Sub LangException(ByVal language As String, ByVal msg As String)
        If language = "russian" Then
            msg = "Операция была отменена (ошибка '" & msg & "' в DataGridView_Sample_Weight_CellClick_Respond())!"
        ElseIf language = "english" Then
            msg = "Operation was cancelled (error: '" & msg & "' in DataGridView_Sample_Weight_CellClick_Respond())!"
        End If
        MsgBox(msg, MsgBoxStyle.Critical, Me.Text)
    End Sub

    Private Sub B_New_Sample_Set_Accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_NewSampleSetIDAccept.Click
        Try
            Form_Sample_Set_Accept.Notes_Number = 1
            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_ReceivedBy". При необходимости она может быть перемещена или удалена.
            Form_Sample_Set_Accept.Table_Received_ByTableAdapter.Connection.ConnectionString = MyConnectionString
            Form_Sample_Set_Accept.Table_Received_ByTableAdapter.Fill(Form_Sample_Set_Accept.NAA_DB_EXPDataSet.table_Received_By)

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SampleSet". При необходимости она может быть перемещена или удалена.
            Form_Sample_Set_Accept.Table_Sample_SetTableAdapter.Connection.ConnectionString = MyConnectionString
            Form_Sample_Set_Accept.Table_Sample_SetTableAdapter.Fill(Form_Sample_Set_Accept.NAA_DB_EXPDataSet.table_Sample_Set)

            If Form_Sample_Set_Accept.Table_Sample_SetDataGridView.RowCount > 0 Then
                Form_Sample_Set_Accept.Table_Sample_SetDataGridView.FirstDisplayedScrollingRowIndex = Form_Sample_Set_Accept.Table_Sample_SetDataGridView.RowCount - 1
                For i = 0 To Form_Sample_Set_Accept.Table_Sample_SetDataGridView.RowCount - 1
                    Form_Sample_Set_Accept.Table_Sample_SetDataGridView.Rows.Item(i).Selected = False
                Next
                Form_Sample_Set_Accept.Table_Sample_SetDataGridView.Rows.Item(Form_Sample_Set_Accept.Table_Sample_SetDataGridView.RowCount - 1).Selected = True
            End If

            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader
            cmd.CommandText = "SELECT Country FROM dbo.Table_Country ORDER BY Country"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            Form_Sample_Set_Accept.ComboBox_Country.Text = ""
            Form_Sample_Set_Accept.ComboBox_Country.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then Form_Sample_Set_Accept.ComboBox_Country.Items.Add(reader(0))
            End While
            sqlConnection1.Close()

            Form_Sample_Set_Accept.MaskedTextBox_Sample_Set_Receipt_Date.Text = Format(Now(), "dd.MM.yyyy") 'если поставить маленькие буквы m, то пропишутся минуты
            Form_Sample_Set_Accept.L_NSSID_Year.Text = Format(Now(), "yy")

            Form_Sample_Set_Accept.ComboBox_Country.Text = ""
            Form_Sample_Set_Accept.ComboBox_Client_ID.Text = ""

            Form_Sample_Set_Accept.ComboBox_Table_ReceivedBy.Text = ""

            Form_Sample_Set_Accept.L_NSSID_Country_Code.Text = ""

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

            'L_NSSID_New_Sample_Set_ID.Text = MaskedTextBox_New_Sample_Set_ID.Text

            cmd.CommandText = "SELECT MAX(Sample_Set_ID) FROM dbo.Table_Sample_Set WHERE Year = '" + Form_Sample_Set_Accept.L_NSSID_Year.Text + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()

            'select max(serial_key) from test_for_find

            Dim value_ID As Integer
            Dim Sample_Set_ID_pred As String
            Dim value_Index As Char

            Sample_Set_ID_pred = ""

            While reader.Read()
                If IsDBNull(reader(0)) Then
                    value_ID = 1
                    Sample_Set_ID_pred = ""
                Else
                    value_ID = reader(0) + 1 'следующий номер партии образцов
                    Sample_Set_ID_pred = reader(0)
                    If value_ID > 99 Then
                        If language = "russian" Then
                            MsgBox("Максимальный номер партии образцов не должен быть > 99", MsgBoxStyle.Critical, Me.Text)
                        ElseIf language = "english" Then
                            MsgBox("Maximum sample set ID must not be > 99", MsgBoxStyle.Critical, Me.Text)
                        End If
                        Exit Sub
                    End If
                End If

                If value_ID < 10 Then
                    Form_Sample_Set_Accept.MaskedTextBox_New_Sample_Set_ID.Text = "0" + value_ID.ToString
                Else
                    Form_Sample_Set_Accept.MaskedTextBox_New_Sample_Set_ID.Text = value_ID.ToString
                End If
            End While
            sqlConnection1.Close()

            If Sample_Set_ID_pred = "" Then
                value_Index = "a"
            Else
                cmd.CommandText = "SELECT MAX(Sample_Set_Index) FROM dbo.Table_Sample_Set WHERE Year = '" + Form_Sample_Set_Accept.L_NSSID_Year.Text + "' and Sample_Set_ID = '" + Sample_Set_ID_pred.ToString + "'"
                cmd.CommandType = CommandType.Text
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If IsDBNull(reader(0)) Then
                        value_Index = "a"
                    Else
                        If Asc(reader(0)) < 122 Then
                            value_Index = Chr(Asc(reader(0)) + 1) 'следующая буква индекса номера партии образцов
                        ElseIf Asc(reader(0)) = 122 Then
                            value_Index = "a"
                        End If

                    End If
                End While
                sqlConnection1.Close()
            End If

            Form_Sample_Set_Accept.MaskedTextBox_New_Sample_Set_Index.Text = value_Index

            If Form_Sample_Set_Accept.Table_Sample_SetDataGridView.RowCount > 0 Then Form_Sample_Set_Accept.Table_Sample_SetDataGridView.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1

            Me.Enabled = False
            Form_Sample_Set_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_Sample_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub



    Private Sub Fill_In_Monitor() 'заполнение отображаемой информации в Label Monitor и раскраска DataGridView1
        Try
            L_Monitor.Text = ""
            Dim i As Integer
            Dim Country, Organzation, LastName, SampleType, SLIF, LLIF, Results, SLIDateString, LLIDateString, PrepFact, SLIFact, LLIFact, Notice, NoticeMod, ColorStr As String
            Dim ProcessedBy As String = ""
            Dim SLIDateAr As New ArrayList
            Dim LLIDateAr As New ArrayList
            Dim CountOfSample As Integer
            Country = ""
            Organzation = ""
            LastName = ""
            SampleType = ""
            SLIF = ""
            LLIF = ""
            Results = ""
            SLIDateString = ""
            LLIDateString = ""
            PrepFact = ""
            SLIFact = ""
            LLIFact = ""
            Notice = ""
            NoticeMod = ""
            ColorStr = ""
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            If DataGridView_Sample_Set.SelectedCells.Count = 0 Then Exit Sub 'чтобы избежать ошибки при сортировке срабатывает selectionChanged до выполнения тела события columnHeaderClick

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "select * from SamplesSetForNaaDB where Country_Code ='" + DataGridView_Sample_Set.SelectedCells.Item(0).Value + "' and  Client_ID = '" + DataGridView_Sample_Set.SelectedCells.Item(1).Value + "' and Year = '" + DataGridView_Sample_Set.SelectedCells.Item(2).Value + "' and Sample_Set_ID = '" + DataGridView_Sample_Set.SelectedCells.Item(3).Value + "' and Sample_Set_Index = '" + DataGridView_Sample_Set.SelectedCells.Item(4).Value + "'"

            CountOfSample = 0
            i = 1
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            'подумать над оптимизацией через циклы и индексы
            While reader.Read()
                ' If Not IsDBNull(reader(5)) Then
                Country = reader(5).ToString
                ' If Not IsDBNull(reader(6)) Then 
                Organzation = reader(6).ToString
                ' If Not IsDBNull(reader(7)) Then
                LastName = reader(7).ToString
                '  If Not IsDBNull(reader(8)) Then 
                CountOfSample += reader(8)
                If Not IsDBNull(reader(9)) Then SampleType = reader(9).ToString

                If Not IsDBNull(reader(10)) Then

                    If Not SLIDateAr.Contains(Format(reader(10), "dd.MM.yyyy").ToString()) Then
                        If i Mod 3 <> 0 Then
                            SLIDateAr.Add(Format(reader(10), "dd.MM.yyyy").ToString())
                            SLIDateString += Format(reader(10), "dd.MM.yyyy").ToString() + ", "
                        Else
                            SLIDateAr.Add(Format(reader(10), "dd.MM.yyyy").ToString())
                            SLIDateString += Format(reader(10), "dd.MM.yyyy").ToString() + vbCrLf
                        End If
                    End If
                Else
                    SLIDateAr.Add("")
                    SLIDateString += ""
                End If

                If Not IsDBNull(reader(11)) Then
                    If Not LLIDateAr.Contains(Format(reader(11), "dd.MM.yyyy").ToString()) Then
                        If i Mod 3 <> 0 Then
                            LLIDateAr.Add(Format(reader(11), "dd.MM.yyyy").ToString())
                            LLIDateString += Format(reader(11), "dd.MM.yyyy").ToString() + ", "
                        Else
                            LLIDateAr.Add(Format(reader(11), "dd.MM.yyyy").ToString())
                            LLIDateString += Format(reader(11), "dd.MM.yyyy").ToString() + vbCrLf
                        End If
                    End If
                Else
                    LLIDateAr.Add("")
                    LLIDateString += ""
                End If

                If Not IsDBNull(reader(12)) Then ProcessedBy = reader(12).ToString

                Results = reader(13).ToString
                PrepFact = reader(14).ToString
                SLIFact = reader(15).ToString
                LLIFact = reader(16).ToString
                ColorStr = reader(17).ToString
                If Not IsDBNull(reader(18)) Then
                    Notice = reader(18).ToString
                    For Each notc In Notice.Split(vbCrLf)
                        'TODO: check why for large string cond doesn't work 
                        If notc.Length > 40 Then
                            notc = notc.Substring(0, 40) + "..."
                        End If
                        NoticeMod += notc
                    Next

                End If
                i += 1
            End While
            reader.Close()
            sqlConnection1.Close()

            DataGridView_Sample_Set.SelectedRows.Item(0).DefaultCellStyle.BackColor = Color.FromName(ColorStr)


            If Results <> "" Then Results = "Yes"

            L_Monitor.Text = "Страна: " + Country + vbCrLf + "Организация: " + Organzation + vbCrLf + "Фамилия: " + LastName + vbCrLf + "Кол-во образцов: " + CountOfSample.ToString + vbCrLf + "Тип образцов: " + SampleType + vbCrLf + "Дата КЖИ: " + SLIDateString + vbCrLf + "Дата ДЖИ: " + LLIDateString + vbCrLf + "Обработчик: " + ProcessedBy + vbCrLf + "Результаты: " + Results + vbCrLf + "Комментарии:" + vbCrLf + NoticeMod

            SLIDateAr.Clear()
            LLIDateAr.Clear()

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try
    End Sub

    Public Sub Form_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "База данных НАА - " & Application.ProductVersion & "  " & us
        Try
            Form_Sample_Accept.OpenFileDialog_Fill_In_From_File.InitialDirectory = "C:\"
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)

            cmd.CommandText = "select * from SRM_Set_Last"

            Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
            Dim ds As New DataSet()

            dataadapter.Fill(ds, "SrmSetLast")
            Table_SRM_SetDataGridView.DataSource = ds
            Table_SRM_SetDataGridView.DataMember = "SrmSetLast"
            Table_SRM_SetDataGridView.ReadOnly = True
            Table_SRM_SetDataGridView.AllowUserToAddRows = False
            Table_SRM_SetDataGridView.ClearSelection()
            Table_SRM_SetDataGridView.Columns.Item(6).Visible = False

            If Table_SRM_SetDataGridView.RowCount > 1 Then
                Table_SRM_SetDataGridView.FirstDisplayedScrollingRowIndex = Table_SRM_SetDataGridView.RowCount - 1
                For i = 0 To Table_SRM_SetDataGridView.RowCount - 1
                    Table_SRM_SetDataGridView.Rows.Item(i).Selected = False
                Next
                Try
                    Table_SRM_SetDataGridView.Rows.Item(Table_SRM_SetDataGridView.RowCount - 1).Selected = True

                    fill_in_monitor_SRM()
                Catch ex As Exception
                    LangException(language, ex.Message & ex.ToString)
                End Try
            End If

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor_Set". При необходимости она может быть перемещена или удалена.
            Table_Monitor_Set_TableAdapter.Connection.ConnectionString = MyConnectionString
            Me.Table_Monitor_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor_Set)

            If Table_Monitor_SetDataGridView.RowCount > 1 Then
                Table_Monitor_SetDataGridView.FirstDisplayedScrollingRowIndex = Table_Monitor_SetDataGridView.RowCount - 1
                For i = 0 To Table_Monitor_SetDataGridView.RowCount - 1
                    Table_Monitor_SetDataGridView.Rows.Item(i).Selected = False
                Next
                Try
                    Table_Monitor_SetDataGridView.Rows.Item(Table_Monitor_SetDataGridView.RowCount - 1).Selected = True

                    fill_in_monitor_monitor()
                Catch ex As Exception
                    LangException(language, ex.Message & ex.ToString)
                End Try
            End If

            fill_in_monitor_monitor()

            cmd.CommandText = "SELECT Count(*) FROM table_Sample"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then
                    If language = "russian" Then
                        L_Count.Text = "Количество образцов в базе данных: " + reader(0).ToString
                    ElseIf language = "english" Then
                        L_Count.Text = "Samples in NAA DB: " + reader(0).ToString
                    End If
                End If
            End While
            sqlConnection1.Close()
            DataSampleSetLoad("")

            ' SampleSetFormLoadFlag = True
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Me.Close()
            'Form_Login.Close()
            Exit Sub
        End Try
        'Dim conn As New SqlConnection("Data Source=NF-100-205\SQLExpress,1433;Initial Catalog=NAA_DB_EXP;User ID=1v;Password=1")
        ''но возникает "Ошибка входа пользователя 'usr1'." при открытии соединения
        'conn.Open()
    End Sub

    Private Sub Table_Sample_Set_IDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.Table_Sample_Set_BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NAA_DB_EXPDataSet)
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Table_Sample_SetBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.Table_Sample_Set_BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NAA_DB_EXPDataSet)
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub B_Select_Sample_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_Sample_Set.Click
        Try
            Dim num As Integer
            num = DataGridView_Sample_Set.SelectedCells.Item(0).RowIndex ' номер строки с выделенной ячейкой

            If DataGridView_Sample_Set.Rows.Item(num).Cells.Item(0).Value = "" Then
                If language = "russian" Then
                    MsgBox("Выберите строку!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "english" Then
                    MsgBox("Select row!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            DataGridView_Sample_Set.Rows.Item(num).Selected = True ' выделяем всю строку (на тот случай, если выделены одна или несколько ячеек)

            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "SELECT A_Sample_ID FROM dbo.table_Sample WHERE F_Country_Code='" +
                DataGridView_Sample_Set.SelectedCells.Item(0).Value +
                "' and F_Client_ID='" + DataGridView_Sample_Set.SelectedCells.Item(1).Value +
                "' and F_Year='" + DataGridView_Sample_Set.SelectedCells.Item(2).Value +
                "' and F_Sample_Set_ID='" + DataGridView_Sample_Set.SelectedCells.Item(3).Value +
                "' and F_Sample_Set_Index='" + DataGridView_Sample_Set.SelectedCells.Item(4).Value + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            Form_Samples_List.ListBox_Sample_ID.Items.Clear()

            While reader.Read()
                If Not IsDBNull(reader(0)) Then Form_Samples_List.ListBox_Sample_ID.Items.Add(reader(0))
            End While
            sqlConnection1.Close()
            Form_Samples_List.ListBox_Sample_ID.SelectedIndex = Form_Samples_List.ListBox_Sample_ID.Items.Count - 1 'выделяем последний образец
            Form_Samples_List.L_SS_Country_Code.Text = DataGridView_Sample_Set.SelectedCells.Item(0).Value
            Form_Samples_List.L_SS_Client_ID.Text = DataGridView_Sample_Set.SelectedCells.Item(1).Value
            Form_Samples_List.L_SS_Year.Text = DataGridView_Sample_Set.SelectedCells.Item(2).Value
            Form_Samples_List.L_SS_Sample_Set_ID.Text = DataGridView_Sample_Set.SelectedCells.Item(3).Value
            Form_Samples_List.L_SS_Sample_Set_Index.Text = DataGridView_Sample_Set.SelectedCells.Item(4).Value

            Me.Enabled = False
            Form_Samples_List.Show()

            cmd.CommandText = "SELECT MAX(A_Sample_ID) FROM dbo.table_Sample WHERE F_Country_Code='" +
          DataGridView_Sample_Set.SelectedCells.Item(0).Value +
          "' and F_Client_ID='" + DataGridView_Sample_Set.SelectedCells.Item(1).Value +
          "' and F_Year='" + DataGridView_Sample_Set.SelectedCells.Item(2).Value +
          "' and F_Sample_Set_ID='" + DataGridView_Sample_Set.SelectedCells.Item(3).Value +
          "' and F_Sample_Set_Index='" + DataGridView_Sample_Set.SelectedCells.Item(4).Value + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If IsDBNull(reader(0)) Then
                    Form_Samples_List.MaskedTextBox_New_Sample_ID.Text = "01"
                ElseIf reader(0) < 9 Then
                    Form_Samples_List.MaskedTextBox_New_Sample_ID.Text = "0" + (reader(0) + 1).ToString
                Else
                    Form_Samples_List.MaskedTextBox_New_Sample_ID.Text = (reader(0) + 1).ToString
                End If

            End While
            sqlConnection1.Close()

            Form_Samples_List.L_SS_Country_Code.Text = DataGridView_Sample_Set.SelectedCells.Item(0).Value

            Me.Enabled = False
            Form_Samples_List.Show()

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_Samples_List.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub B_Physical_Environment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Physical_Environment.Click
        Try
            Me.Enabled = False
            Form_Physical_Environment.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Enabled = False
            Form_Samples_Search.Show()

            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader
            cmd.CommandText = "SELECT Country FROM dbo.Table_Country"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            Form_Samples_Search.ComboBox_Country.Text = ""
            Form_Samples_Search.ComboBox_Country.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then Form_Samples_Search.ComboBox_Country.Items.Add(reader(0))
            End While
            sqlConnection1.Close()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_New_SLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_SLI_Irradiation_Log.Click
        Try
            Dim SLI_Irradiation_Log As Date
            Try
                SLI_Irradiation_Log = MaskedTextBox_SLI_Irradiation_Log.Text
            Catch ex As Exception
                LangException(language, ex.Message & ex.ToString)
                Exit Sub
            End Try

            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader
            cmd.CommandText = "SELECT COUNT(*) FROM table_SLI_Irradiation_Log WHERE Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()

            While reader.Read()
                If reader(0) > 0 Then
                    If language = "russian" Then
                        MsgBox("This SLI irradiation log already exist!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf language = "english" Then
                        MsgBox("Такой журнал КЖИ уже существует!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    sqlConnection1.Close()
                    Exit Sub
                End If
            End While
            sqlConnection1.Close()

            Form_SLI_Irradiation_Log.MaskedTextBox_SLI_Irradiation_Log.Text = MaskedTextBox_SLI_Irradiation_Log.Text

            Me.Enabled = False
            Form_SLI_Irradiation_Log.Show()

            If language = "russian" Then
                Form_SLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "Все партии образцов"
            ElseIf language = "english" Then
                Form_SLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "All sample sets"
            End If
            Form_SLI_Irradiation_Log.ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_SLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "Все партии стандартов"
            ElseIf language = "english" Then
                Form_SLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "All SRM sets"
            End If
            Form_SLI_Irradiation_Log.ComboBox_SRM_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_SLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "Все партии мониторов"
            ElseIf language = "english" Then
                Form_SLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "All monitor sets"
            End If
            Form_SLI_Irradiation_Log.ComboBox_Monitor_Set_View_SelectionChangeCommitted(sender, e)

            Me.Enabled = False
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_SLI_Irradiation_Log.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_SLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_SLI_Irradiation_Log.Click
        Try
            If ListBox_SLI_Irradiation_Log_Date.Items.Count < 1 Then
                If language = "russian" Then
                    MsgBox("Пустой список журналов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "english" Then
                    MsgBox("Empty list of logs!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If ListBox_SLI_Irradiation_Log_Date.SelectedItems.Count = 0 Then
                If language = "russian" Then
                    MsgBox("Выберите журнал КЖИ!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "english" Then
                    MsgBox("Select LLI log!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            'Form_SLI_Table.DataGridView_SLI_Table.ColumnHeadersDefaultCellStyle.Alignment.MiddleCenter()
            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Sample". При необходимости она может быть перемещена или удалена.
            Form_SLI_Irradiation_Log.Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = MyConnectionString
            Dim s As String
            s = ListBox_SLI_Irradiation_Log_Date.SelectedItem.Name()
            Form_SLI_Irradiation_Log.Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(Form_SLI_Irradiation_Log.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, s)

            Form_SLI_Irradiation_Log.MaskedTextBox_SLI_Irradiation_Log.Text = s

            Me.Enabled = False
            Form_SLI_Irradiation_Log.Show()

            If language = "russian" Then
                Form_SLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "Партии образцов из журнала"
            ElseIf language = "english" Then
                Form_SLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "Sample sets from log"
            End If
            Form_SLI_Irradiation_Log.ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_SLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "Партии стандартов из журнала"
            ElseIf language = "english" Then
                Form_SLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "SRM sets from log"
            End If
            Form_SLI_Irradiation_Log.ComboBox_SRM_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_SLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "Партии мониторов из журнала"
            ElseIf language = "english" Then
                Form_SLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "Monitor sets from log"
            End If
            Form_SLI_Irradiation_Log.ComboBox_Monitor_Set_View_SelectionChangeCommitted(sender, e)

            Me.Enabled = False
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_SLI_Irradiation_Log.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_New_SRM_Set_Accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_SRM_Set_Accept.Click
        Try
            Me.Enabled = False
            Form_SRM_Set_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_SRM_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_SRM_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_SRM_Set.Click
        Try
            Form_SRM_Accept.L_SRM_Set_Name.Text = Table_SRM_SetDataGridView.SelectedCells.Item(0).Value
            Form_SRM_Accept.L_SRM_Set_Number.Text = Table_SRM_SetDataGridView.SelectedCells.Item(1).Value
            Form_SRM_Accept.L_SRM_Set_Weight.Text = Table_SRM_SetDataGridView.SelectedCells.Item(3).Value
            Me.Enabled = False
            Form_SRM_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_SRM_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try

    End Sub

    Private Sub B_New_Monitor_Set_Accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_Monitor_Set_Accept.Click
        Try
            Me.Enabled = False
            Form_Monitor_Set_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_Monitor_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_Monitor_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_Monitor_Set.Click
        Try
            Form_Monitor_Accept.L_Monitor_Set_Name.Text = Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value
            Form_Monitor_Accept.L_Monitor_Set_Number.Text = Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value
            Form_Monitor_Accept.L_Monitor_Set_Weight.Text = Table_Monitor_SetDataGridView.SelectedCells.Item(3).Value
            Me.Enabled = False
            Form_Monitor_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_Monitor_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub B_New_LLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_LLI_Irradiation_Log.Click
        Try
            Dim LLI_Irradiation_Log As Date
            Try
                LLI_Irradiation_Log = MaskedTextBox_LLI_Irradiation_Log.Text
            Catch ex As Exception
                If language = "russian" Then
                    MsgBox("Check date!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "english" Then
                    MsgBox("Проверьте дату!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End Try

            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            cmd.CommandText = "declare @maxln int; SELECT @maxln = max(loadNumber) from table_LLI_Irradiation_Log; update  table_LLI_Irradiation_Log set loadNumber = @maxln where Date_Start =  '" & MaskedTextBox_LLI_Irradiation_Log.Text & "';"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            sqlConnection1.Close()

            cmd.CommandText = " SELECT max(loadNumber) from table_LLI_Irradiation_Log"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' по-хорошему надо добавить проверку на число 
            While reader.Read()
                If Not IsDBNull(reader(0)) Then
                    Form_LLI_Irradiation_Log.TextBox_Download.Text = reader(0) + 1
                Else
                    Form_LLI_Irradiation_Log.TextBox_Download.Text = InputBox("Программа не может определить номер загрузки, пожалуйста, введите его самостоятельно.", "Ввод номера загрузки", "0")
                End If
            End While

            Form_LLI_Irradiation_Log.MaskedTextBox_LLI_Irradiation_Log.Text = MaskedTextBox_LLI_Irradiation_Log.Text

            Me.Enabled = False
            Form_LLI_Irradiation_Log.Show()

            If language = "russian" Then
                Form_LLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "Все партии образцов"
            ElseIf language = "english" Then
                Form_LLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "All sample sets"
            End If
            Form_LLI_Irradiation_Log.ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_LLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "Все партии стандартов"
            ElseIf language = "english" Then
                Form_LLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "All SRM sets"
            End If
            Form_LLI_Irradiation_Log.ComboBox_SRM_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_LLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "Все партии мониторов"
            ElseIf language = "english" Then
                Form_LLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "All monitor sets"
            End If
            Form_LLI_Irradiation_Log.ComboBox_Monitor_Set_View_SelectionChangeCommitted(sender, e)

            Me.Enabled = False
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_LLI_Irradiation_Log.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_LLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_LLI_Irradiation_Log.Click
        Try
            If ListBox_LLI_Irradiation_Log_Date.Items.Count < 1 Then
                If language = "russian" Then
                    MsgBox("Пустой список журналов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "english" Then
                    MsgBox("Empty list of logs!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If ListBox_LLI_Irradiation_Log_Date.SelectedItems.Count = 0 Then
                If language = "russian" Then
                    MsgBox("Выберите журнал ДЖИ!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "english" Then
                    MsgBox("Select LLI log!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            'Form_LLI_Table.DataGridView_LLI_Table.ColumnHeadersDefaultCellStyle.Alignment.MiddleCenter()
            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Sample". При необходимости она может быть перемещена или удалена.
            Form_LLI_Irradiation_Log.Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = MyConnectionString
            Dim jDate As String
            Dim number As String

            jDate = Split(ListBox_LLI_Irradiation_Log_Date.Text, "-")(0)
            number = Split(ListBox_LLI_Irradiation_Log_Date.Text, "-")(1)
            's1 = s(s.Count - 4) + s(s.Count - 3) + s(s.Count - 2) + s(s.Count - 1)
            Form_LLI_Irradiation_Log.Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(Form_LLI_Irradiation_Log.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, jDate, number)

            Form_LLI_Irradiation_Log.MaskedTextBox_LLI_Irradiation_Log.Text = ListBox_LLI_Irradiation_Log_Date.Text
            Form_LLI_Irradiation_Log.TextBox_Download.Text = number

            Me.Enabled = False
            Form_LLI_Irradiation_Log.Show()

            If language = "russian" Then
                Form_LLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "Партии образцов из журнала"
            ElseIf language = "english" Then
                Form_LLI_Irradiation_Log.ComboBox_Sample_Set_View.SelectedItem = "Sample sets from log"
            End If
            Form_LLI_Irradiation_Log.ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_LLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "Партии стандартов из журнала"
            ElseIf language = "english" Then
                Form_LLI_Irradiation_Log.ComboBox_SRM_Set_View.SelectedItem = "SRM sets from log"
            End If
            Form_LLI_Irradiation_Log.ComboBox_SRM_Set_View_SelectionChangeCommitted(sender, e)

            If language = "russian" Then
                Form_LLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "Партии мониторов из журнала"
            ElseIf language = "english" Then
                Form_LLI_Irradiation_Log.ComboBox_Monitor_Set_View.SelectedItem = "Monitor sets from log"
            End If
            Form_LLI_Irradiation_Log.ComboBox_Monitor_Set_View_SelectionChangeCommitted(sender, e)

            Me.Enabled = False
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_LLI_Irradiation_Log.Close()
            Exit Sub
        End Try
    End Sub

    Public Function Fill_In_Weight_From_File_String_Quant(ByVal file_name_p As String) As Integer
        Try
            Dim currentRow_p As String

            Dim cnt = 0
            Using MyReader As New FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                Dim readFlag As Boolean
                readFlag = False
                currentRow_p = ""
                While Not MyReader.EndOfData
                    currentRow_p = MyReader.ReadLine
                    If readFlag Then
                        cnt += 1
                        Continue While
                    End If
                    If currentRow_p.Contains("------") Then
                        readFlag = True
                    End If
                End While
            End Using
            Debug.WriteLine($"Count of samples: {cnt - 2}")
            Return cnt - 2 ' checking contains of "-----" returns headers from 2 rows
        Catch ex As Exception
            ' Fill_In_Weight_From_File_String_Quant = -1
            LangException(language, ex.Message & ex.ToString)
            Return 0
        End Try
    End Function

    Public Sub Fill_In_Weight_From_File(ByVal file_name_p As String, ByRef row_count_p As Integer, ByRef Samples_Names_p(,) As String, ByRef Samples_Weights_p(,) As Single)
        Try
            Dim currentRow_p As String

            Using MyReader As New FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                Dim readFlag As Boolean
                Dim parsedValue As String()
                Dim headersSkip As Integer
                headersSkip = 0
                readFlag = False
                currentRow_p = ""
                Debug.WriteLine("Rows for parsing:")
                While Not MyReader.EndOfData
                    currentRow_p = MyReader.ReadLine
                    If readFlag Then
                        If headersSkip > 1 Then
                            parsedValue = currentRow_p.Split(vbTab)
                            Debug.WriteLine($"Raw was parsed to the next values: 0:{parsedValue(0)}, 1:{parsedValue(1)}, 2:{parsedValue(2)}, 3:{parsedValue(3)}")
                            Samples_Names_p(row_count_p, 0) = parsedValue(0) 'индекс пробы - первое слово до пробела
                            Samples_Names_p(row_count_p, 1) = parsedValue(1)  'имя образца - первое слово до пробела
                            Samples_Weights_p(row_count_p, 0) = parsedValue(2)
                            Samples_Weights_p(row_count_p, 1) = parsedValue(3)
                            row_count_p += 1

                        End If
                        headersSkip += 1
                        Continue While
                    End If
                    If currentRow_p.Contains("-----") Then
                        readFlag = True
                    End If
                End While
            End Using
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Table_SRM_SetDataGridView_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Table_SRM_SetDataGridView.CellMouseUp
        fill_in_monitor_SRM()
    End Sub

    Private Sub fill_in_monitor_SRM()
        Try
            Dim i As Integer
            ListBox_Monitor_SRM.Items.Clear()
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If Table_SRM_SetDataGridView.SelectedRows.Count > 0 Then
                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_SLI_Irradiation_Log WHERE Country_Code='s' and Client_Id='s' and Year='s' and Sample_Set_Id='" + Table_SRM_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_SRM_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "russian" Then
                                ListBox_Monitor_SRM.Items.Add("Журнал КЖИ: ")
                            ElseIf language = "english" Then
                                ListBox_Monitor_SRM.Items.Add("SLI log: ")
                            End If
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()

                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_LLI_Irradiation_Log WHERE Country_Code='s' and Client_Id='s' and Year='s' and Sample_Set_Id='" + Table_SRM_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_SRM_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "russian" Then
                                ListBox_Monitor_SRM.Items.Add("Журнал ДЖИ: ")
                            ElseIf language = "english" Then
                                ListBox_Monitor_SRM.Items.Add("LLI log: ")
                            End If
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()
            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub fill_in_monitor_monitor()
        Try
            Dim i As Integer
            ListBox_Monitor_Monitor.Items.Clear()
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If Table_Monitor_SetDataGridView.SelectedRows.Count > 0 Then
                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_SLI_Irradiation_Log WHERE Country_Code='m' and Client_Id='m' and Year='m' and Sample_Set_Id='" + Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "russian" Then
                                ListBox_Monitor_Monitor.Items.Add("Журнал КЖИ: ")
                            ElseIf language = "english" Then
                                ListBox_Monitor_Monitor.Items.Add("SLI log: ")
                            End If
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()

                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_LLI_Irradiation_Log WHERE Country_Code='m' and Client_Id='m' and Year='m' and Sample_Set_Id='" + Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "russian" Then
                                ListBox_Monitor_Monitor.Items.Add("Журнал ДЖИ: ")
                            ElseIf language = "english" Then
                                ListBox_Monitor_Monitor.Items.Add("LLI log: ")
                            End If
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()
            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Table_Monitor_SetDataGridView_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Table_Monitor_SetDataGridView.CellMouseUp
        fill_in_monitor_monitor()
    End Sub

    Private Sub Table_SRM_SetDataGridView_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Table_SRM_SetDataGridView.SelectionChanged
        fill_in_monitor_SRM()
    End Sub

    Private Sub Table_Monitor_SetDataGridView_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Table_Monitor_SetDataGridView.SelectionChanged
        fill_in_monitor_monitor()
    End Sub

    Private Sub DataGridView_Sample_Set_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView_Sample_Set.SelectionChanged
        Try
            If SampleSetFormLoadFlag Then Fill_In_Monitor()
            'SampleSetFormLoadFlag = False
            'Fill_In_Monitor()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView_Sample_Set_ColumnHeaderMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Sample_Set.ColumnHeaderMouseClick

        Try
            '   SampleSetFormLoadFlag = False
            '  If DataGridView_Sample_Set.SelectedCells.Count > 0 Then

            For i = 0 To DataGridView_Sample_Set.RowCount - 1
                DataGridView_Sample_Set.Rows.Item(i).Selected = True
            Next
            DataGridView_Sample_Set.Rows.Item(DataGridView_Sample_Set.RowCount - 1).Selected = True
            DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1
            ' End If
            '  SampleSetFormLoadFlag = True
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub


    Private Sub SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView_Description.SelectionChanged

        If DataGridViewDescriptionFill Then
            If DataGridView_Description.CurrentRow.Index() = 0 Then
                DataSampleSetLoad("where Results is null and SamplPrep is null and SamplSLI is null and SamplLLI is null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 1 Then
                DataSampleSetLoad("where Results is null and SamplPrep is not null and SamplSLI is null and SamplLLI is null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 2 Then
                DataSampleSetLoad("where Results is null and SamplSLI is not null and SamplLLI is null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 3 Then
                DataSampleSetLoad("where Results is null and SamplSLI is null and SamplLLI is not null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 4 Then
                DataSampleSetLoad("where Results is not null and (SamplSLI is null or SamplLLI is null)")
            ElseIf DataGridView_Description.CurrentRow.Index() = 5 Then
                DataSampleSetLoad("where Results is not null and SamplSLI is not null and SamplLLI is not null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 6 Then
                DataSampleSetLoad("")
            End If

        End If

    End Sub

    Private Sub Form_Main_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            Change_Language()
            Dim i As Integer = 0
            Dim elements As String = "F,Na,Mg,Al,Si,S,Cl,K,Ca,Sc,Ti,V,Cr,Mn,Fe,Co,Ni,Cu,Zn,Ga,Ge,As,Se,Br,Rb,Sr,Y,Zr,Nb,Mo,Ru,Pd,Ag,Cd,In,Sn,Sb,I,Cs,Ba,La,Ce,Pr,Nd,Sm,Eu,Gd,Tb,Dy,Ho,Er,Tm,Yb,Lu,Hf,Ta,W,Re,Os,Ir,Pt,Au,Hg,Th,U"

            For Each elem In elements.Split(",")
                Table_Elements(i) = elem
                i += 1
            Next

            If language = "russian" Then
                DataGridView_Description.Columns.Item(0).HeaderText = "Цвет"
            ElseIf language = "english" Then
                DataGridView_Description.Columns.Item(0).HeaderText = "Color"
            End If
            If language = "russian" Then
                DataGridView_Description.Columns.Item(1).HeaderText = "Описание"
            ElseIf language = "english" Then
                DataGridView_Description.Columns.Item(1).HeaderText = "Description"
            End If
            DataGridView_Description.Rows.Add(7)
            DataGridView_Description.Rows.Item(0).Cells.Item(0).Style.BackColor = Color.LightPink
            If language = "russian" Then
                DataGridView_Description.Rows.Item(0).Cells.Item(1).Value = "партия принята"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(0).Cells.Item(1).Value = "sample set accepted"
            End If

            DataGridView_Description.Rows.Item(1).Cells.Item(0).Style.BackColor = Color.White
            If language = "russian" Then
                DataGridView_Description.Rows.Item(1).Cells.Item(1).Value = "проведена пробоподготовка"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(1).Cells.Item(1).Value = "sample preparation carried out"
            End If

            DataGridView_Description.Rows.Item(2).Cells.Item(0).Style.BackColor = Color.LemonChiffon
            If language = "russian" Then
                DataGridView_Description.Rows.Item(2).Cells.Item(1).Value = "облучение КЖИ"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(2).Cells.Item(1).Value = "irradiation SLI"
            End If

            DataGridView_Description.Rows.Item(3).Cells.Item(0).Style.BackColor = Color.Yellow
            If language = "russian" Then
                DataGridView_Description.Rows.Item(3).Cells.Item(1).Value = "облучение ДЖИ"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(3).Cells.Item(1).Value = "irradiation LLI"
            End If

            DataGridView_Description.Rows.Item(4).Cells.Item(0).Style.BackColor = Color.LightGreen
            If language = "russian" Then
                DataGridView_Description.Rows.Item(4).Cells.Item(1).Value = "КЖИ или ДЖИ плюс результаты"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(4).Cells.Item(1).Value = "SLI or LLI plus results"
            End If

            DataGridView_Description.Rows.Item(5).Cells.Item(0).Style.BackColor = Color.LimeGreen
            If language = "russian" Then
                DataGridView_Description.Rows.Item(5).Cells.Item(1).Value = "КЖИ и ДЖИ плюс результаты"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(5).Cells.Item(1).Value = "SLI and LLI plus results"
            End If

            DataGridView_Description.Rows.Item(6).Cells.Item(0).Style.BackColor = Color.Bisque
            If language = "russian" Then
                DataGridView_Description.Rows.Item(6).Cells.Item(1).Value = "Показать все"
            ElseIf language = "english" Then
                DataGridView_Description.Rows.Item(6).Cells.Item(1).Value = "Show all"
            End If

            DataGridView_Description.ClearSelection()
            DataGridViewDescriptionFill = True

            If language = "russian" Then
                ComboBox_Journal_Of_Irradiation_View.SelectedItem = "Текущий год"
            ElseIf language = "english" Then
                ComboBox_Journal_Of_Irradiation_View.SelectedItem = "Current year"
            End If

            ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub Change_Language()
        Try
            If language = "russian" Then

                ' L_Count.Text = "Количество образцов в базе данных:" ' не разкоментить, событие load наступает раньше события shown 
                B_Refresh.Text = "Обновить"
                L_Name_Sample_Set.Text = "Партии образцов"
                DataGridView_Sample_Set.Columns.Item(0).HeaderText = "Код страны"
                DataGridView_Sample_Set.Columns.Item(1).HeaderText = "Клиент. номер"
                DataGridView_Sample_Set.Columns.Item(2).HeaderText = "Год"
                DataGridView_Sample_Set.Columns.Item(3).HeaderText = "N партии образ."
                DataGridView_Sample_Set.Columns.Item(4).HeaderText = "инд. партии образ."
                ' DataGridView_Sample_Set.Columns.Item(5).HeaderText = "Кол-во образцов"
                B_NewSampleSetIDAccept.Text = "Приём новой партии образцов"
                B_Select_Sample_Set.Text = "Выбрать партию образцов"
                OpenSet.Text = "Просмотр информации о партии"
                LabelSearch.Text = "Поиск"

                L_Name_SLI_Irradiation_Log.Text = "Журналы облучения КЖИ"
                B_Select_SLI_Irradiation_Log.Text = "Выбр. жур. обл. КЖИ"
                B_New_SLI_Irradiation_Log.Text = "Новый жур. обл. КЖИ"
                L_Name_LLI_Irradiation_Log.Text = "Журналы облучения ДЖИ"
                B_Select_LLI_Irradiation_Log.Text = "Выбр. жур. обл. ДЖИ"
                B_New_LLI_Irradiation_Log.Text = "Новый жур. обл. ДЖИ"
                ComboBox_Journal_Of_Irradiation_View.Items.Clear()
                ComboBox_Journal_Of_Irradiation_View.Items.Add("Текущий год")
                ComboBox_Journal_Of_Irradiation_View.Items.Add("Все годы")

                L_Name_SRM_Set.Text = "Партии стандартов"
                Table_SRM_SetDataGridView.Columns.Item(0).HeaderText = "Имя"
                Table_SRM_SetDataGridView.Columns.Item(1).HeaderText = "Номер"
                Table_SRM_SetDataGridView.Columns.Item(2).HeaderText = "Тип"
                Table_SRM_SetDataGridView.Columns.Item(3).HeaderText = "Вес, гр"
                Table_SRM_SetDataGridView.Columns.Item(4).HeaderText = "Остаток(шт.)"
                Table_SRM_SetDataGridView.Columns.Item(5).HeaderText = "Дата покупки"

                L_Name_Monitor_Set.Text = "Партии мониторов"
                Table_Monitor_SetDataGridView.Columns.Item(0).HeaderText = "Имя"
                Table_Monitor_SetDataGridView.Columns.Item(1).HeaderText = "Номер"
                Table_Monitor_SetDataGridView.Columns.Item(2).HeaderText = "Тип"
                Table_Monitor_SetDataGridView.Columns.Item(3).HeaderText = "Вес, гр"
                Table_Monitor_SetDataGridView.Columns.Item(4).HeaderText = "Дата покупки"

                ButtonShowAllSrms.Text = "Показать весь список стандартов"
                B_New_SRM_Set_Accept.Text = "Приём новой партии стандартов"
                B_Select_SRM_Set.Text = "Выбрать партию стандартов"

                B_New_Monitor_Set_Accept.Text = "Приём новой партии мониторов"
                B_Select_Monitor_Set.Text = "Выбрать партию мониторов"

                B_Physical_Environment.Text = "Параметры окружающей среды"

            ElseIf language = "english" Then

                ' L_Count.Text = "Samples in NAA DB:" ' не разкоментить, событие load наступает раньше события shown 
                B_Refresh.Text = "Refresh"
                L_Name_Sample_Set.Text = "Sample sets"
                DataGridView_Sample_Set.Columns.Item(0).HeaderText = "Country code"
                DataGridView_Sample_Set.Columns.Item(1).HeaderText = "Client ID"
                DataGridView_Sample_Set.Columns.Item(2).HeaderText = "Year"
                DataGridView_Sample_Set.Columns.Item(3).HeaderText = "Samle set ID"
                DataGridView_Sample_Set.Columns.Item(4).HeaderText = "Samle set index"
                B_NewSampleSetIDAccept.Text = "New sample set acceptance"
                B_Select_Sample_Set.Text = "Select sample set"
                LabelSearch.Text = "Search"

                L_Name_SLI_Irradiation_Log.Text = "SLI irradiation logs"
                B_Select_SLI_Irradiation_Log.Text = "Select SLI irradiation log"
                B_New_SLI_Irradiation_Log.Text = "New SLI irradiation log"
                L_Name_LLI_Irradiation_Log.Text = "LLI irradiation logs"
                B_Select_LLI_Irradiation_Log.Text = "Select LLI irradiation log"
                B_New_LLI_Irradiation_Log.Text = "New LLI irradiation log"
                ComboBox_Journal_Of_Irradiation_View.Items.Clear()
                ComboBox_Journal_Of_Irradiation_View.Items.Add("Current year")
                ComboBox_Journal_Of_Irradiation_View.Items.Add("All years")
                OpenSet.Text = "View information about set"
                ButtonShowAllSrms.Text = "Show all SRMs"
                L_Name_SRM_Set.Text = "SRM sets"
                Table_SRM_SetDataGridView.Columns.Item(0).HeaderText = "Name"
                Table_SRM_SetDataGridView.Columns.Item(1).HeaderText = "Number"
                Table_SRM_SetDataGridView.Columns.Item(2).HeaderText = "Type"
                Table_SRM_SetDataGridView.Columns.Item(3).HeaderText = "Weight, g"
                Table_SRM_SetDataGridView.Columns.Item(4).HeaderText = "Balance(pcs)"
                Table_SRM_SetDataGridView.Columns.Item(5).HeaderText = "Purchasing date"

                L_Name_Monitor_Set.Text = "Monitor sets"
                Table_Monitor_SetDataGridView.Columns.Item(0).HeaderText = "Name"
                Table_Monitor_SetDataGridView.Columns.Item(1).HeaderText = "Number"
                Table_Monitor_SetDataGridView.Columns.Item(2).HeaderText = "Type"
                Table_Monitor_SetDataGridView.Columns.Item(3).HeaderText = "Weight, g"
                Table_Monitor_SetDataGridView.Columns.Item(4).HeaderText = "Purchasing date"

                B_New_SRM_Set_Accept.Text = "New SRM set acceptance"
                B_Select_SRM_Set.Text = "Select SRM set"

                B_New_Monitor_Set_Accept.Text = "New monitor set acceptance"
                B_Select_Monitor_Set.Text = "Select monitor set"

                B_Physical_Environment.Text = "Physical environment"
            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Refresh.Click
        Try
            Form_Main_Load(sender, e)
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub ListBox_SLI_Irradiation_Log_Date_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox_SLI_Irradiation_Log_Date.DrawItem

        If (e.State And DrawItemState.Selected) <> DrawItemState.Selected Then
            ListBox_SLI_Irradiation_Log_Date.DrawMode = DrawMode.OwnerDrawFixed
            e.DrawBackground()
            Dim myForeBrush As New SolidBrush(CType(ListBox_SLI_Irradiation_Log_Date.Items(e.Index), ListItem).ForeColor)
            Dim myBackBrush As New SolidBrush(CType(ListBox_SLI_Irradiation_Log_Date.Items(e.Index), ListItem).BackColor)

            e.Graphics.FillRectangle(myBackBrush, e.Bounds)
            e.Graphics.DrawString(CType(ListBox_SLI_Irradiation_Log_Date.Items(e.Index), ListItem).Name, e.Font, myForeBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        Else
            e.Graphics.FillRectangle(Brushes.MidnightBlue, e.Bounds)
            e.Graphics.DrawString(CType(ListBox_SLI_Irradiation_Log_Date.Items(e.Index), ListItem).Name, e.Font, Brushes.White, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        End If
        e.DrawFocusRectangle()
    End Sub

    Public Sub ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Journal_Of_Irradiation_View.SelectedIndexChanged
        Try
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            ' текущий год
            If ComboBox_Journal_Of_Irradiation_View.SelectedItem = "Текущий год" Or ComboBox_Journal_Of_Irradiation_View.SelectedItem = "Current year" Then
                ListBox_SLI_Irradiation_Log_Date.DrawMode = DrawMode.OwnerDrawFixed
                ListBox_SLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT DISTINCT Cast(a.Date_Start as nvarchar(10)) + ';' as dates FROM table_SLI_Irradiation_Log  as a where 's' not in (select distinct client_id from table_SLI_Irradiation_Log where Date_Start = a.Date_Start) and Year(a.Date_Start) = Year(GETDATE()) union SELECT DISTINCT Cast(Date_Start as nvarchar(10)) + ';' + Client_ID as dates FROM table_SLI_Irradiation_Log where Client_ID = 's' and Year(Date_Start) = Year(GETDATE()) ORDER BY dates;"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If Split(reader(0), ";")(1) <> "" Then
                            ListBox_SLI_Irradiation_Log_Date.Items.Add(New ListItem(Format(Convert.ToDateTime(Replace(reader(0), ";s", "")), "dd.MM.yyyy"), Color.Black, Color.PaleGoldenrod))
                        Else
                            ListBox_SLI_Irradiation_Log_Date.Items.Add(New ListItem(Format(Convert.ToDateTime(Replace(reader(0), ";", "")), "dd.MM.yyyy"), Color.Black, Color.White))
                        End If
                    End If
                End While
                sqlConnection1.Close()
                If ListBox_SLI_Irradiation_Log_Date.Items.Count > 0 Then
                    ListBox_SLI_Irradiation_Log_Date.ClearSelected()
                    ListBox_SLI_Irradiation_Log_Date.SetSelected(ListBox_SLI_Irradiation_Log_Date.Items.Count - 1, True)
                End If
                MaskedTextBox_SLI_Irradiation_Log.Text = Format(Now(), "dd.MM.yyyy")

                ListBox_LLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT DISTINCT Date_Start, loadNumber FROM table_LLI_Irradiation_Log ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If Format(reader(0), "yyyy") = Format(Now(), "yyyy") Then
                            ListBox_LLI_Irradiation_Log_Date.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString & "-" & reader(1))
                        End If
                    End If
                End While
                sqlConnection1.Close()
                If ListBox_LLI_Irradiation_Log_Date.Items.Count > 0 Then
                    ListBox_LLI_Irradiation_Log_Date.ClearSelected()
                    ListBox_LLI_Irradiation_Log_Date.SetSelected(ListBox_LLI_Irradiation_Log_Date.Items.Count - 1, True)
                End If
                MaskedTextBox_LLI_Irradiation_Log.Text = Format(Now(), "dd.MM.yyyy")

                ' все года
            ElseIf ComboBox_Journal_Of_Irradiation_View.SelectedItem = "Все годы" Or ComboBox_Journal_Of_Irradiation_View.SelectedItem = "All years" Then

                ListBox_SLI_Irradiation_Log_Date.DrawMode = DrawMode.OwnerDrawFixed
                ListBox_SLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT DISTINCT Cast(a.Date_Start as nvarchar(10)) + ';' as dates FROM table_SLI_Irradiation_Log  as a where 's' not in (select distinct client_id from table_SLI_Irradiation_Log where Date_Start = a.Date_Start) union SELECT DISTINCT Cast(Date_Start as nvarchar(10)) + ';' + Client_ID as dates FROM table_SLI_Irradiation_Log where Client_ID = 's' ORDER BY dates;"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If Split(reader(0), ";")(1) <> "" Then
                            ListBox_SLI_Irradiation_Log_Date.Items.Add(New ListItem(Convert.ToDateTime(Replace(reader(0), ";s", "")), Color.Black, Color.PaleGoldenrod))
                        Else
                            ListBox_SLI_Irradiation_Log_Date.Items.Add(New ListItem(Convert.ToDateTime(Replace(reader(0), ";", "")), Color.Black, Color.White))
                        End If
                    End If
                End While
                sqlConnection1.Close()
                If ListBox_SLI_Irradiation_Log_Date.Items.Count > 0 Then
                    ListBox_SLI_Irradiation_Log_Date.ClearSelected()
                    ListBox_SLI_Irradiation_Log_Date.SetSelected(ListBox_SLI_Irradiation_Log_Date.Items.Count - 1, True)
                End If
                MaskedTextBox_SLI_Irradiation_Log.Text = Format(Now(), "dd.MM.yyyy")

                ListBox_LLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT DISTINCT Date_Start, loadNumber FROM table_LLI_Irradiation_Log ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then ListBox_LLI_Irradiation_Log_Date.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString & "-" & reader(1))
                End While
                sqlConnection1.Close()
                If ListBox_LLI_Irradiation_Log_Date.Items.Count > 0 Then
                    ListBox_LLI_Irradiation_Log_Date.ClearSelected()
                    ListBox_LLI_Irradiation_Log_Date.SetSelected(ListBox_LLI_Irradiation_Log_Date.Items.Count - 1, True)
                End If
                MaskedTextBox_LLI_Irradiation_Log.Text = Format(Now(), "dd.MM.yyyy")

            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub OpenSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSet.Click
        If DataGridView_Sample_Set.SelectedRows.Count = 0 Then
            MsgBox("Выберете строку с номером партии.")
        Else
            CountryCodeForOpenSet = DataGridView_Sample_Set.SelectedRows(0).Cells(0).Value.ToString
            ClientIDForOpenSet = DataGridView_Sample_Set.SelectedRows(0).Cells(1).Value.ToString
            YearForOpenSet = DataGridView_Sample_Set.SelectedRows(0).Cells(2).Value.ToString
            SampleSetIDForOpenSet = DataGridView_Sample_Set.SelectedRows(0).Cells(3).Value.ToString
            SampleSetIndexForOpenSet = DataGridView_Sample_Set.SelectedRows(0).Cells(4).Value.ToString
            OpenSampleForm.Show()
        End If

    End Sub

    Private Sub ChangeLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeLang.Click

        If ChangeLang.Text = "russian" Then
            My.MySettings.Default.languaged = "english"
            ChangeLang.Text = "english"
            Application.Restart()
        ElseIf ChangeLang.Text = "english" Then
            My.MySettings.Default.languaged = "russian"
            ChangeLang.Text = "russian"
            Application.Restart()
        End If

    End Sub


    Public hist As String = ""
    Public firstFlag As Integer = 0

    'Private Sub CBFilter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    '    Try
    '        If SampleSetFormLoadFlag Then
    '            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
    '            Dim reader As SqlDataReader
    '            Dim cmd As New System.Data.SqlClient.SqlCommand
    '            cmd.CommandType = System.Data.CommandType.Text
    '            Dim qs As String = "select * from SampleSetForNaaDB as sampSet "
    '            If CBFilter.SelectedItem = "Показать все" Then
    '                hist = ""
    '                L_Name_Sample_Set_View.Text = "Выберите тип" & vbCrLf & "фильтра"
    '                DataSampleSetLoad(hist)
    '                ComboBox_Sample_Set_View.Text = ""
    '                ComboBox_Sample_Set_View.Items.Clear()
    '                firstFlag = 0
    '            ElseIf CBFilter.SelectedItem = "Обработано" Then
    '                ComboBox_Sample_Set_View.Text = ""
    '                L_Name_Sample_Set_View.Text = "Фамилия" & vbCrLf & "обработчика"

    '                ComboBox_Sample_Set_View.Items.Clear()
    '                cmd.CommandText = "select distinct b.R_Processed_By from (" & qs & fields & ") as b ORDER BY b.R_Processed_By"
    '                Debug.WriteLine(cmd.CommandText)
    '                'cmd.CommandText = "SELECT * FROM table_Received_By ORDER BY Received_By"
    '                cmd.Connection = sqlConnection1
    '                sqlConnection1.Open()
    '                reader = cmd.ExecuteReader()
    '                While reader.Read()
    '                    If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

    '                End While
    '                sqlConnection1.Close()

    '            ElseIf CBFilter.SelectedItem = "Код клиента" Then
    '                ComboBox_Sample_Set_View.Text = ""
    '                L_Name_Sample_Set_View.Text = "Фамилия " & "Код страны" & vbCrLf & "Код клиента"

    '                ComboBox_Sample_Set_View.Items.Clear()
    '                cmd.CommandText = "select distinct b.clientInfo from (" & qs & " join (select Country_Code as cc, Client_ID as ci, Last_Name + ';' + Country_Code + ';' + Client_ID as clientInfo from table_Client) as cl on cl.ci = sampSet.Client_ID and cl.cc = sampSet.Country_Code" & fields & ") as b ORDER BY b.clientInfo"

    '                cmd.Connection = sqlConnection1
    '                sqlConnection1.Open()
    '                reader = cmd.ExecuteReader()
    '                While reader.Read()
    '                    If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

    '                End While
    '                sqlConnection1.Close()

    '            ElseIf CBFilter.SelectedItem = "Страна" Then
    '                ComboBox_Sample_Set_View.Text = ""
    '                L_Name_Sample_Set_View.Text = "Страна"

    '                ComboBox_Sample_Set_View.Items.Clear()
    '                cmd.CommandText = "select distinct b.Country_Code from (" & qs & fields & ") as b ORDER BY b.Country_Code"

    '                cmd.Connection = sqlConnection1
    '                sqlConnection1.Open()
    '                reader = cmd.ExecuteReader()
    '                While reader.Read()
    '                    If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

    '                End While
    '                sqlConnection1.Close()

    '            ElseIf CBFilter.SelectedItem = "Год" Then
    '                ComboBox_Sample_Set_View.Text = ""
    '                L_Name_Sample_Set_View.Text = "Год"

    '                ComboBox_Sample_Set_View.Items.Clear()
    '                cmd.CommandText = "select distinct b.Year from (" & qs & fields & ") as b ORDER BY b.Year"
    '                '"select distinct Year from SampleSetForNaaDB ORDER BY Year"
    '                cmd.Connection = sqlConnection1
    '                sqlConnection1.Open()
    '                reader = cmd.ExecuteReader()
    '                While reader.Read()
    '                    If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

    '                End While
    '                sqlConnection1.Close()

    '            End If
    '            DataGridView_Sample_Set.Focus()
    '        End If
    '    Catch ex As Exception

    '        LangException(language, ex.Message & ex.ToString)
    '    End Try

    'End Sub


    'Private Sub ComboBox_Sample_Set_View_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    '    Try
    '        If L_Name_Sample_Set_View.Text = "Фамилия" & vbCrLf & "обработчика" Then
    '            Try
    '                If hist = "" Then
    '                    hist = hist & " where sampSet.R_Processed_By like  '%" + ComboBox_Sample_Set_View.SelectedItem + "%'"
    '                Else
    '                    hist = hist & " and sampSet.R_Processed_By like '%" + ComboBox_Sample_Set_View.SelectedItem + "%'"
    '                End If
    '                If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)

    '            Catch ex As Exception
    '                MsgBox("Партий с таким обработчиком не найдено.")
    '                DataSampleSetLoad("")
    '            End Try
    '        ElseIf L_Name_Sample_Set_View.Text = "Фамилия " & "Код страны" & vbCrLf & "Код клиента" Then
    '            If hist = "" Then
    '                hist = hist & " where sampSet.Client_ID = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(2) & "' and sampSet.Country_Code = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(1) & "'"
    '            Else
    '                hist = hist & " and sampSet.Client_ID = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(2) & "' and sampSet.Country_Code = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(1) & "'"
    '            End If

    '            If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)
    '        ElseIf L_Name_Sample_Set_View.Text = "Страна" Then
    '            If hist = "" Then
    '                hist = hist & " where sampSet.Country_Code = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
    '            Else
    '                hist = hist & " and sampSet.Country_Code = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
    '            End If

    '            If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)
    '        ElseIf L_Name_Sample_Set_View.Text = "Год" Then
    '            If hist = "" Then
    '                hist = hist & " where sampSet.Year = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
    '            Else
    '                hist = hist & " and sampSet.Year = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
    '            End If
    '            If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)
    '        End If
    '        DataGridView_Sample_Set.Focus()
    '    Catch ex As Exception
    '        LangException(language, ex.Message & ex.ToString)
    '    End Try
    'End Sub

End Class