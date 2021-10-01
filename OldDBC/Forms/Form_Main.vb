Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq



Public Class Form_Main
    Public us As String
    Public MyConnectionString As String
    Public arr() As Single
    Public Table_Elements(64) As String ' всего 65 элементов
    Public language = My.Settings.language
    Public SampleSetFormLoadFlag As Boolean = False
    Public fields As String = ""
    Public DataGridViewDescriptionFill As Boolean = False
    Public CountryCodeForOpenSet, ClientIDForOpenSet, YearForOpenSet, SampleSetIDForOpenSet, SampleSetIndexForOpenSet As String


    Sub DataSampleSetLoad(ByVal Field As String)
        Try
            ChangeLang.Text = language
            Debug.WriteLine("DataSampleSetLoad:")
            SampleSetFormLoadFlag = False
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Using cmd As New System.Data.SqlClient.SqlCommand

                cmd.CommandType = System.Data.CommandType.Text
                fields = Field

                cmd.CommandText = "select distinct sampSet.Country_Code, sampSet.Client_ID, sampSet.Year, sampSet.Sample_Set_ID,            sampSet.Sample_Set_Index from SamplesSetForNaaDB as sampSet " + Field + " order by sampSet.Year, sampSet.Sample_Set_ID, sampSet.Client_ID, sampSet.Country_Code, sampSet.Sample_Set_Index"

                Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "SampleInf")
                DataGridView_Sample_Set.DataSource = ds
                DataGridView_Sample_Set.DataMember = "SampleInf"
                DataGridView_Sample_Set.ReadOnly = True
                DataGridView_Sample_Set.AllowUserToAddRows = False
                DataGridView_Sample_Set.ClearSelection() ' вызывает срабатывание changeselection чтобы не было не выделенной строки при добавляем флаги SampleSetFormLoadFlag
                SampleSetFormLoadFlag = True

                Dim start As Integer = DataGridView_Sample_Set.RowCount - DataGridView_Sample_Set.DisplayedRowCount(True)
                Dim finish As Integer = DataGridView_Sample_Set.RowCount

                For i As Integer = start To finish - 1
                    Colorize(DataGridView_Sample_Set.Rows.Item(i))
                Next

                If DataGridView_Sample_Set.RowCount = 0 Then
                    MsgBox("Таких значений нет")
                    DataSampleSetLoad("")
                    ' Exit Sub
                End If

                DataGridView_Sample_Set.Rows.Item(DataGridView_Sample_Set.RowCount - 1).Selected = True
                DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1

                If Not BackgroundWorkerColorizer.IsBusy Then BackgroundWorkerColorizer.RunWorkerAsync()
            End Using
        Catch backgroundWorker As InvalidOperationException
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try


    End Sub

    Private Sub ColorizeAll()
        Try
            For Each row As DataGridViewRow In DataGridView_Sample_Set.Rows
                Colorize(row)
            Next
        Catch ex As ArgumentOutOfRangeException
            Debug.WriteLine("Too much activities in sorting")
        End Try

    End Sub

    Public Sub LangException(ByVal language As String, ByVal msg As String)
        If language = "Русский" Then
            msg = "Операция была отменена (ошибка '" & msg & "' в DataGridView_Sample_Weight_CellClick_Respond())!"
        ElseIf language = "English" Then
            msg = "Operation was cancelled (error: '" & msg & "' in DataGridView_Sample_Weight_CellClick_Respond())!"
        End If
        MsgBox(msg, MsgBoxStyle.Critical, Me.Text)
    End Sub

    Private Sub B_New_Sample_Set_Accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_NewSampleSetIDAccept.Click
        Try
            Form_Sample_Set_Accept.Notes_Number = 1
            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_ReceivedBy". При необходимости она может быть перемещена или удалена.
            Form_Sample_Set_Accept.Table_Received_ByTableAdapter.Connection.ConnectionString = MyConnectionString
            'Form_Sample_Set_Accept.Table_Received_ByTableAdapter.Fill(Form_Sample_Set_Accept.NAA_DB_EXPDataSet.table_Received_By)

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SampleSet". При необходимости она может быть перемещена или удалена.
            'Form_Sample_Set_Accept.Table_Sample_SetTableAdapter.Connection.ConnectionString = MyConnectionString
            'Form_Sample_Set_Accept.Table_Sample_SetTableAdapter.Fill(Form_Sample_Set_Accept.NAA_DB_EXPDataSet.table_Sample_Set)

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

            Form_Sample_Set_Accept.LabelSign.Text = ""

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
            'cmd.CommandType = CommandType.Text
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
                        If language = "Русский" Then
                            MsgBox("Максимальный номер партии образцов не должен быть > 99", MsgBoxStyle.Critical, Me.Text)
                        ElseIf language = "English" Then
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
    Private Sub Colorize(row As DataGridViewRow) 'раскраска DataGridView1
        Try
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "select color from SamplesSetForNaaDB where Country_Code ='" + row.Cells(0).Value + "' and  Client_ID = '" + row.Cells(1).Value + "' and Year = '" + row.Cells(2).Value + "' and Sample_Set_ID = '" + row.Cells(3).Value + "' and Sample_Set_Index = '" + row.Cells(4).Value + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            row.DefaultCellStyle.BackColor = Color.FromName(cmd.ExecuteScalar().ToString())
            sqlConnection1.Close()

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try
    End Sub




    Private Sub Fill_In_Monitor() 'заполнение отображаемой информации в Label Monitor и раскраска DataGridView1
        Debug.WriteLine("Fill In Monitor started:")
        Try
            L_Monitor.Text = ""
            Dim i As Integer
            Dim Country, Organzation, LastName, SampleType, SLIF, LLIF, Results, SLIDateString, LLIDateString, Notice, NoticeMod, WorkType, Note As String
            Dim ProcessedBy As String = ""
            Dim ReceivedBy As String = ""
            Dim SLIDateAr As New ArrayList
            Dim LLIDateAr As New ArrayList
            Dim CountOfSample As Integer
            Dim ProcessedSample As Integer = 0
            Dim SamplesDistribution As New Dictionary(Of String, Integer) From {{"accepted", 0}, {"prepared", 0}, {"SLI", 0}, {"LLI", 0}, {"SLI|LLI&Results", 0}, {"SLI&LLI&Results", 0}}
            Country = ""
            Organzation = ""
            LastName = ""
            SampleType = ""
            SLIF = ""
            LLIF = ""
            Results = ""
            SLIDateString = ""
            LLIDateString = ""
            Notice = ""
            NoticeMod = ""
            WorkType = ""
            Note = ""
            Dim TypeSet As HashSet(Of String) = New HashSet(Of String)
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand
            Dim reader As SqlDataReader

            If DataGridView_Sample_Set.SelectedCells.Count = 0 Then Exit Sub 'чтобы избежать ошибки при сортировке срабатывает selectionChanged до выполнения тела события columnHeaderClick

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = $"exec FormDataForMonitor '{DataGridView_Sample_Set.SelectedCells.Item(0).Value}', '{DataGridView_Sample_Set.SelectedCells.Item(1).Value}', '{DataGridView_Sample_Set.SelectedCells.Item(2).Value}', '{DataGridView_Sample_Set.SelectedCells.Item(3).Value}', '{DataGridView_Sample_Set.SelectedCells.Item(4).Value}'"
            'cmd.CommandText = "select * from SamplesSetForNaaDB where Country_Code ='" + DataGridView_Sample_Set.SelectedCells.Item(0).Value + "' and  Client_ID = '" + DataGridView_Sample_Set.SelectedCells.Item(1).Value + "' and Year = '" + DataGridView_Sample_Set.SelectedCells.Item(2).Value + "' and Sample_Set_ID = '" + DataGridView_Sample_Set.SelectedCells.Item(3).Value + "' and Sample_Set_Index = '" + DataGridView_Sample_Set.SelectedCells.Item(4).Value + "'"

            CountOfSample = 0
            i = 1
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            'подумать над оптимизацией через циклы и индексы
            While reader.Read()
                If Not IsDBNull(reader(5)) Then Country = reader(5).ToString
                If Not IsDBNull(reader(6)) Then Organzation = reader(6).ToString
                If Not IsDBNull(reader(7)) Then LastName = reader(7).ToString
                If Not IsDBNull(reader(8)) Then CountOfSample += reader(8)
                If Not IsDBNull(reader(9)) Then TypeSet.Add(reader(9).ToString)
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
                If Not IsDBNull(reader(13)) Then
                    Results = reader(13).ToString
                End If
                If Not IsDBNull(reader(14)) Then
                    SamplesDistribution("prepared") += reader(8)
                End If
                If Not IsDBNull(reader(15)) Then
                    SamplesDistribution("SLI") += reader(8)
                End If
                If Not IsDBNull(reader(16)) Then
                    SamplesDistribution("LLI") += reader(8)
                End If
                If ((Not IsDBNull(reader(15))) Or (Not IsDBNull(reader(16)))) And (Not IsDBNull(reader(13))) Then
                    SamplesDistribution("SLI|LLI&Results") += reader(8)
                End If
                If Not IsDBNull(reader(15)) And Not IsDBNull(reader(16)) And Not IsDBNull(reader(13)) Then
                    SamplesDistribution("SLI&LLI&Results") += reader(8)
                End If
                If Not IsDBNull(reader(18)) Then Notice = reader(18).ToString
                If Not IsDBNull(reader(20)) Then
                    ProcessedSample = reader(20)
                End If
                If Not IsDBNull(reader(21)) Then
                    WorkType = reader(21)
                End If
                If Not IsDBNull(reader(22)) Then
                    Note = reader(22)
                End If
                If Not IsDBNull(reader(26)) Then
                    ReceivedBy = reader(26)
                End If
                i += 1
            End While
            reader.Close()
            sqlConnection1.Close()

            SamplesDistribution("accepted") = CountOfSample

            If Results <> "" Then Results = "Yes"

            For k As Integer = 0 To TypeSet.Count - 1
                SampleType += $"{TypeSet.ToArray().GetValue(k)},"
            Next
            If Not String.IsNullOrEmpty(SampleType) Then SampleType = SampleType.Substring(0, SampleType.Length - 1)
            L_Monitor.Text = "Страна: " + Country + vbCrLf + "Организация: " + Organzation + vbCrLf + "Фамилия: " + LastName + vbCrLf + "Кол-во образцов: " + CountOfSample.ToString + vbCrLf + "Тип образцов: " + SampleType + vbCrLf + "Дата КЖИ: " + SLIDateString + vbCrLf + "Дата ДЖИ: " + LLIDateString + vbCrLf + "Обработчик: " + ProcessedBy + vbCrLf + "Результаты: " + Results + vbCrLf + "Обработано образцов: " + ProcessedSample.ToString + " из " + CountOfSample.ToString + vbCrLf + "Комментарии:" + vbCrLf + Notice + vbCrLf + "Внесено:" + ReceivedBy + vbCrLf + "Тип работ: " + WorkType + vbCrLf + "Примечание к партии: " + vbCrLf + Note

            SLIDateAr.Clear()
            LLIDateAr.Clear()

            If DataGridView_Description.RowCount > 0 Then
                DataGridView_Description.Rows(0).Cells(0).Value = SamplesDistribution("accepted")
                DataGridView_Description.Rows(1).Cells(0).Value = SamplesDistribution("prepared")
                DataGridView_Description.Rows(2).Cells(0).Value = SamplesDistribution("SLI")
                DataGridView_Description.Rows(3).Cells(0).Value = SamplesDistribution("LLI")
                DataGridView_Description.Rows(4).Cells(0).Value = SamplesDistribution("SLI|LLI&Results")
                DataGridView_Description.Rows(5).Cells(0).Value = SamplesDistribution("SLI&LLI&Results")

            End If

            DataGridView_Description.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView_Description.Columns(0).DefaultCellStyle.Font = New Font("Tahoma", 12, FontStyle.Regular)
            Colorize(DataGridView_Sample_Set.SelectedRows.Item(0))

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try
    End Sub

    Public Sub Form_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.language = "Русский" Then
            Me.Text = $"Клиент базы данных эксперимента РЕГАТА - {Application.ProductVersion}   {us}"
        ElseIf My.Settings.language = "English" Then
            Me.Text = $"Regata experiment data base client - {Application.ProductVersion}   {us}"
        End If
        Try
            InitializeComponent()
            CBFilter.Text = "Показать все"

            Using sqlConnection1 As New SqlConnection(MyConnectionString)
                Using cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)
                    cmd.CommandText = "select * from SRM_Set_Last"
                    Using dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                        Using ds As New DataSet()
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
                        End Using
                    End Using
                    Dim reader As SqlDataReader
                    cmd.CommandText = "SELECT Count(*) FROM table_Sample"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader(0)) Then
                            If language = "Русский" Then
                                L_Count.Text = "Количество образцов в базе данных: " + reader(0).ToString
                            ElseIf language = "English" Then
                                L_Count.Text = "Samples in NAA DB: " + reader(0).ToString
                            End If
                        End If
                    End While
                End Using
            End Using

            Using sqlConnection1 As New SqlConnection(MyConnectionString)
                Using cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)
                    cmd.CommandText = "select * from table_Monitor_Set"
                    Using dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                        Using ds As New DataSet()
                            dataadapter.Fill(ds, "MonitorSet")
                            Table_Monitor_SetDataGridView.DataSource = ds
                            Table_Monitor_SetDataGridView.DataMember = "MonitorSet"
                            Table_Monitor_SetDataGridView.ReadOnly = True
                            Table_Monitor_SetDataGridView.AllowUserToAddRows = False
                            Table_Monitor_SetDataGridView.ClearSelection()

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
                        End Using
                    End Using
                End Using
            End Using

            fill_in_monitor_monitor()

            DataSampleSetLoad("where color <> 'LimeGreen'")

            MaskedTextBoxDateOfNewJournal.Text = Now.Date.ToString("dd.MM.yyyy")

            OldCore.Utilities.Settings.ConnectionString = MyConnectionString
            OldCore.Utilities.Settings.AssemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name

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

    Private Sub B_Physical_Environment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Physical_Environment.Click
        Try
            Me.Enabled = False
            Form_Physical_Environment.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_New_SLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_SLI_Irradiation_Log.Click

        Try
            'Regata.Core.DataBase.RegataContext.ConString = MyConnectionString
            'Dim m As New Regata.Core.UI.WinForms.Forms.Irradiations.IrradiationRegister(DateTime.Now, Regata.Core.DataBase.Models.IrradiationType.sli)
            'm.mainForm.Show()
            'Regata.Core.Settings.GlobalSettings.User = us

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        Exit Sub
        End Try
    End Sub

    Private Sub B_Select_SLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_SLI_Irradiation_Log.Click
        Try
            Regata.Core.DataBase.RegataContext.ConString = MyConnectionString
            Dim s As String = ListBox_SLI_Irradiation_Log_Date.SelectedItem.Name()
            Dim d As DateTime = DateTime.Parse(s, System.Globalization.CultureInfo.CurrentCulture)
            'Dim m As New Regata.Core.UI.WinForms.Forms.Irradiations.IrradiationRegister(d, Regata.Core.DataBase.Models.IrradiationType.sli)
            'm.mainForm.Show()
            Dim m As New Regata.Core.UI.WinForms.Forms.Measurements.MeasurementsRegisterForm(d.Date, Regata.Core.DataBase.Models.MeasurementsType.sli)
            m.mainForm.Show()

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
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
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New SqlCommand

            cmd.CommandText = "SELECT max(loadNumber) from Irradiations"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            Dim maxLoadNumber = DirectCast(cmd.ExecuteScalar(), Integer)
            Regata.Core.DataBase.RegataContext.ConString = MyConnectionString
            Dim m As New Regata.Core.UI.WinForms.Forms.Irradiations.IrradiationRegister(DateTime.Now, Regata.Core.DataBase.Models.IrradiationType.lli, maxLoadNumber + 1)
            m.mainForm.Show()
            'Regata.Core.Settings.GlobalSettings.User = us

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_LLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_LLI_Irradiation_Log.Click
        Try
            Dim jDate As String
            Dim number As Integer

            jDate = Split(ListBox_LLI_Irradiation_Log_Date.Text, "-")(0)
            number = Integer.Parse(Split(ListBox_LLI_Irradiation_Log_Date.Text, "-")(1))
            Dim d As DateTime = DateTime.Parse(jDate, System.Globalization.CultureInfo.CurrentCulture)

            Regata.Core.DataBase.RegataContext.ConString = MyConnectionString
            Dim m As New Regata.Core.UI.WinForms.Forms.Measurements.MeasurementsRegisterForm(d.Date, Regata.Core.DataBase.Models.MeasurementsType.lli1)
            m.mainForm.Show()


        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
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
                            If language = "Русский" Then
                                ListBox_Monitor_SRM.Items.Add("Журнал КЖИ: ")
                            ElseIf language = "English" Then
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
                            If language = "Русский" Then
                                ListBox_Monitor_SRM.Items.Add("Журнал ДЖИ: ")
                            ElseIf language = "English" Then
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
                            If language = "Русский" Then
                                ListBox_Monitor_Monitor.Items.Add("Журнал КЖИ: ")
                            ElseIf language = "English" Then
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
                            If language = "Русский" Then
                                ListBox_Monitor_Monitor.Items.Add("Журнал ДЖИ: ")
                            ElseIf language = "English" Then
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
        Debug.WriteLine("DataGridView_Sample_Set HeaderClick event started")
        Try
            Dim start As Integer = DataGridView_Sample_Set.RowCount - DataGridView_Sample_Set.DisplayedRowCount(True)
            Dim finish As Integer = DataGridView_Sample_Set.RowCount

            For i As Integer = start To finish - 1
                Colorize(DataGridView_Sample_Set.Rows.Item(i))
            Next


            DataGridView_Sample_Set.Rows.Item(DataGridView_Sample_Set.RowCount - 1).Selected = True
            DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1

            If Not BackgroundWorkerColorizer.IsBusy Then
                BackgroundWorkerColorizer.RunWorkerAsync()
            End If

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub


    Private Sub SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView_Description.SelectionChanged

        If DataGridViewDescriptionFill Then
            If CBFilter.SelectedItem <> "Показать все" Then
                CBFilter.SelectedItem = "Показать все"
            End If
            If DataGridView_Description.CurrentRow.Index() = 0 Then
                '  DataSampleSetLoad("where Results is null and SamplPrep is null and SamplSLI is null and SamplLLI is null")
                DataSampleSetLoad("where color = 'LightPink'")
            ElseIf DataGridView_Description.CurrentRow.Index() = 1 Then
                ' DataSampleSetLoad("where Results is null and SamplPrep is not null and SamplSLI is null and SamplLLI is null")
                DataSampleSetLoad("where color = 'White'")
            ElseIf DataGridView_Description.CurrentRow.Index() = 2 Then
                DataSampleSetLoad("where SLIDate_Start is null and SLICompl=0")
                ' DataSampleSetLoad("where SLIDate_Start is null and LLIDate_Start is not null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 3 Then
                DataSampleSetLoad("where LLIDate_Start is null and LLICompl=0")
                ' DataSampleSetLoad("where LLIDate_Start is null and SLIDate_Start is not null")
            ElseIf DataGridView_Description.CurrentRow.Index() = 4 Then
                DataSampleSetLoad("where color = 'LightGreen'")
                ' DataSampleSetLoad("where Results is not null and (SamplSLI is null or SamplLLI is null)")
            ElseIf DataGridView_Description.CurrentRow.Index() = 5 Then
                DataSampleSetLoad("where color = 'LimeGreen'")
                ' DataSampleSetLoad("where Results is not null and SamplSLI is not null and SamplLLI is not null")
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

            If language = "Русский" Then
                DataGridView_Description.Columns.Item(0).HeaderText = "Цвет"
            ElseIf language = "English" Then
                DataGridView_Description.Columns.Item(0).HeaderText = "Color"
            End If
            If language = "Русский" Then
                DataGridView_Description.Columns.Item(1).HeaderText = "Описание"
            ElseIf language = "English" Then
                DataGridView_Description.Columns.Item(1).HeaderText = "Description"
            End If
            DataGridView_Description.Rows.Add(6)
            DataGridView_Description.Rows.Item(0).Cells.Item(0).Style.BackColor = Color.LightPink
            If language = "Русский" Then
                DataGridView_Description.Rows.Item(0).Cells.Item(1).Value = "партия принята"
            ElseIf language = "English" Then
                DataGridView_Description.Rows.Item(0).Cells.Item(1).Value = "sample set accepted"
            End If

            DataGridView_Description.Rows.Item(1).Cells.Item(0).Style.BackColor = Color.White
            If language = "Русский" Then
                DataGridView_Description.Rows.Item(1).Cells.Item(1).Value = "проведена пробоподготовка"
            ElseIf language = "English" Then
                DataGridView_Description.Rows.Item(1).Cells.Item(1).Value = "sample preparation carried out"
            End If

            DataGridView_Description.Rows.Item(2).Cells.Item(0).Style.BackColor = Color.LemonChiffon
            If language = "Русский" Then
                DataGridView_Description.Rows.Item(2).Cells.Item(1).Value = "облучение КЖИ"
            ElseIf language = "English" Then
                DataGridView_Description.Rows.Item(2).Cells.Item(1).Value = "irradiation SLI"
            End If

            DataGridView_Description.Rows.Item(3).Cells.Item(0).Style.BackColor = Color.Yellow
            If language = "Русский" Then
                DataGridView_Description.Rows.Item(3).Cells.Item(1).Value = "облучение ДЖИ"
            ElseIf language = "English" Then
                DataGridView_Description.Rows.Item(3).Cells.Item(1).Value = "irradiation LLI"
            End If

            DataGridView_Description.Rows.Item(4).Cells.Item(0).Style.BackColor = Color.LightGreen
            If language = "Русский" Then
                DataGridView_Description.Rows.Item(4).Cells.Item(1).Value = "КЖИ или ДЖИ плюс результаты"
            ElseIf language = "English" Then
                DataGridView_Description.Rows.Item(4).Cells.Item(1).Value = "SLI or LLI plus results"
            End If

            DataGridView_Description.Rows.Item(5).Cells.Item(0).Style.BackColor = Color.LimeGreen
            If language = "Русский" Then
                DataGridView_Description.Rows.Item(5).Cells.Item(1).Value = "КЖИ и ДЖИ плюс результаты"
            ElseIf language = "English" Then
                DataGridView_Description.Rows.Item(5).Cells.Item(1).Value = "SLI and LLI plus results"
            End If

            DataGridView_Description.ClearSelection()
            DataGridViewDescriptionFill = True

            If language = "Русский" Then
                ComboBox_Journal_Of_Irradiation_View.SelectedItem = "За текущий год"
            ElseIf language = "English" Then
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
            If language = "Русский" Then

                ResetLoginButton.Text = "Выйти"
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
                B_Select_Sample_Set.Text = "Образцы"
                OpenSet.Text = "Список для облучения"
                L_Name_Sample_Set_View.Text = "Выберите тип" & vbCrLf & "фильтра"

                L_Name_SLI_Irradiation_Log.Text = "Журналы облучения КЖИ"
                B_Select_SLI_Irradiation_Log.Text = "Выбр. жур. обл. КЖИ"
                B_New_SLI_Irradiation_Log.Text = "Новый жур. обл. КЖИ"
                L_Name_LLI_Irradiation_Log.Text = "Журналы облучения ДЖИ"
                B_Select_LLI_Irradiation_Log.Text = "Выбр. жур. обл. ДЖИ"
                B_New_LLI_Irradiation_Log.Text = "Новый жур. обл. ДЖИ"
                ComboBox_Journal_Of_Irradiation_View.Items.Clear()
                ComboBox_Journal_Of_Irradiation_View.Items.Add("За текущий год")
                ComboBox_Journal_Of_Irradiation_View.Items.Add("За все время")

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

            ElseIf language = "English" Then

                ' L_Count.Text = "Samples in NAA DB:" ' не разкоментить, событие load наступает раньше события shown 
                ResetLoginButton.Text = "Sign out"
                B_Refresh.Text = "Refresh"
                L_Name_Sample_Set.Text = "Sample sets"
                DataGridView_Sample_Set.Columns.Item(0).HeaderText = "Country code"
                DataGridView_Sample_Set.Columns.Item(1).HeaderText = "Client ID"
                DataGridView_Sample_Set.Columns.Item(2).HeaderText = "Year"
                DataGridView_Sample_Set.Columns.Item(3).HeaderText = "Samle set ID"
                DataGridView_Sample_Set.Columns.Item(4).HeaderText = "Samle set index"
                B_NewSampleSetIDAccept.Text = "New sample set acceptance"
                B_Select_Sample_Set.Text = "Samples"

                L_Name_Sample_Set_View.Text = "Choose type of" & vbCrLf & "filter"

                L_Name_SLI_Irradiation_Log.Text = "SLI irradiation logs"
                B_Select_SLI_Irradiation_Log.Text = "Select SLI irradiation log"
                B_New_SLI_Irradiation_Log.Text = "New SLI irradiation log"
                L_Name_LLI_Irradiation_Log.Text = "LLI irradiation logs"
                B_Select_LLI_Irradiation_Log.Text = "Select LLI irradiation log"
                B_New_LLI_Irradiation_Log.Text = "New LLI irradiation log"
                ComboBox_Journal_Of_Irradiation_View.Items.Clear()
                ComboBox_Journal_Of_Irradiation_View.Items.Add("Current year")
                ComboBox_Journal_Of_Irradiation_View.Items.Add("All time")
                OpenSet.Text = "Print irr. list"
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
            If ComboBox_Journal_Of_Irradiation_View.SelectedItem = "За текущий год" Or ComboBox_Journal_Of_Irradiation_View.SelectedItem = "Current year" Or ComboBox_Journal_Of_Irradiation_View.SelectedItem = Nothing Then
                ListBox_SLI_Irradiation_Log_Date.DrawMode = DrawMode.OwnerDrawFixed
                ListBox_SLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "  SELECT        DISTINCT convert(varchar, mr.IrradiationDate,23) +';' as dates    FROM Measurements  as a        join MeasurementsRegister as mr ON    mr.Id = a.RegId AND            mr.[Type] = 0    where     's' not in     (        select            distinct ClientNumber        from Measurements        where             a.RegId =  RegId and            [Type] = 0    ) and        Year(mr.IrradiationDate) = Year(GETDATE()) and        a.[Type] = 0 union    SELECT DISTINCT convert(varchar, mr.IrradiationDate,23) + ';' + ClientNumber as dates    FROM Measurements as m        join MeasurementsRegister as mr ON    mr.Id = RegId AND            mr.[Type] = 0    where     ClientNumber = 's' and        Year(mr.IrradiationDate) = Year(GETDATE()) and        m.[Type] = 0 ORDER BY dates;"
                '"SELECT DISTINCT convert(varchar, a.DateTimeStart,23) +';' as dates FROM Irradiations  as a where 's' not in (select distinct ClientNumber from Irradiations where convert(varchar, a.DateTimeStart,23) =  convert(varchar, DateTimeStart,23) and [Type] = 0) and Year(a.DateTimeStart) = Year(GETDATE()) and a.[Type] = 0 union SELECT DISTINCT convert(varchar, DateTimeStart,23) + ';' + ClientNumber as dates FROM Irradiations where ClientNumber = 's' and Year(DateTimeStart) = Year(GETDATE()) and [Type] = 0 ORDER BY dates;"

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
                MaskedTextBoxDateOfNewJournal.Text = Format(Now(), "dd.MM.yyyy")

                ListBox_LLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT DISTINCT convert(date, IrradiationDate) as date, loadNumber FROM MeasurementsRegister where [Type] = 1 and IrradiationDate is not null  and loadNumber is not null and  Year(IrradiationDate) = Year(GETDATE()) ORDER BY date"
                '"SELECT DISTINCT convert(date, DateTimeStart) as date, loadNumber FROM Irradiations where [Type] = 1 and DateTimeStart is not null  and loadNumber is not null and  Year(DateTimeStart) = Year(GETDATE()) ORDER BY date"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        ListBox_LLI_Irradiation_Log_Date.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString & "-" & reader(1))
                    End If
                End While
                sqlConnection1.Close()
                If ListBox_LLI_Irradiation_Log_Date.Items.Count > 0 Then
                    ListBox_LLI_Irradiation_Log_Date.ClearSelected()
                    ListBox_LLI_Irradiation_Log_Date.SetSelected(ListBox_LLI_Irradiation_Log_Date.Items.Count - 1, True)
                End If
                MaskedTextBoxDateOfNewJournal.Text = Format(Now(), "dd.MM.yyyy")

                ' все года
            ElseIf ComboBox_Journal_Of_Irradiation_View.SelectedItem = "За все время" Or ComboBox_Journal_Of_Irradiation_View.SelectedItem = "All time" Then

                ListBox_SLI_Irradiation_Log_Date.DrawMode = DrawMode.OwnerDrawFixed
                ListBox_SLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT        DISTINCT convert(varchar, mr.IrradiationDate,23) +';' as dates    FROM Measurements  as a        join MeasurementsRegister as mr ON    mr.Id = a.RegId AND            mr.[Type] = 0    where     's' not in     (        select            distinct ClientNumber        from Measurements        where             a.RegId =  RegId and            [Type] = 0    ) and        a.[Type] = 0 union    SELECT DISTINCT convert(varchar, mr.IrradiationDate,23) + ';' + ClientNumber as dates    FROM Measurements as m        join MeasurementsRegister as mr ON    mr.Id = RegId AND            mr.[Type] = 0    where     ClientNumber = 's' and  m.[Type] = 0 ORDER BY dates;"
                '"SELECT DISTINCT convert(varchar, a.DateTimeStart,23) +';' as dates FROM Irradiations  as a where 's' not in (select distinct ClientNumber from Irradiations where convert(varchar, a.DateTimeStart,23) =  convert(varchar, DateTimeStart,23) and [Type] = 0) and a.[Type] = 0 and DateTimeStart is not null union SELECT DISTINCT convert(varchar, DateTimeStart,23) + ';' + ClientNumber as dates FROM Irradiations where ClientNumber = 's' and [Type] = 0 and DateTimeStart is not null  ORDER BY dates;"
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
                MaskedTextBoxDateOfNewJournal.Text = Format(Now(), "dd.MM.yyyy")

                ListBox_LLI_Irradiation_Log_Date.Items.Clear()
                cmd.CommandText = "SELECT DISTINCT convert(date, IrradiationDate) as date, loadNumber FROM MeasurementsRegister where [Type] = 1 and IrradiationDate is not null  and loadNumber is not null ORDER BY date"
                '"SELECT DISTINCT convert(date, DateTimeStart) as date, loadNumber FROM Irradiations where [Type] = 1 and DateTimeStart is not null  and loadNumber is not null ORDER BY date"
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
                MaskedTextBoxDateOfNewJournal.Text = Format(Now(), "dd.MM.yyyy")

            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub OpenSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSet.Click

        Dim whereString As String = ""

        If DataGridView_Description.SelectedRows.Count <> 0 Then

            If DataGridView_Description.CurrentRow.Index() = 0 Then
                ' whereString = "where s.Results is null and a.SamplPrep is null and s.SamplSLI is null and s.SamplLLI is null"
                whereString = "where s.color='LightPink'"
            ElseIf DataGridView_Description.CurrentRow.Index() = 1 Then
                ' whereString = "where s.Results is null and s.SamplPrep is not null and s.SamplSLI is null and s.SamplLLI is null and s.PrepCompl=0"
                whereString = "where s.color='White'"
            ElseIf DataGridView_Description.CurrentRow.Index() = 2 Then
                '  whereString = "where s.SLIDate_Start is null and s.LLIDate_Start is not null and s.SLICompl=0"
                whereString = "where s.SLIDate_Start is null and s.SLICompl=0"
            ElseIf DataGridView_Description.CurrentRow.Index() = 3 Then
                ' whereString = "where s.LLIDate_Start is null and s.SLIDate_Start is not null and s.LLICompl=0"
                whereString = "where s.LLIDate_Start is null and s.LLICompl=0 "
            ElseIf DataGridView_Description.CurrentRow.Index() = 4 Then
                'whereString = "where s.Results is not null and (s.SamplSLI is null or s.SamplLLI is null)"
                whereString = "where s.color='LightGreen'"
            ElseIf DataGridView_Description.CurrentRow.Index() = 5 Then
                ' whereString = "where s.Results is not null and s.SamplSLI is not null and s.SamplLLI is not null"
                whereString = "where s.color='LimeGreen'"
            ElseIf DataGridView_Description.CurrentRow.Index() = 6 Then
                whereString = ""
            End If
        End If

        Dim sqlConnection1 As New SqlConnection(MyConnectionString)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = $"select s.Country_Code, s.Client_ID, s.Year, s.Sample_Set_ID, s.Sample_Set_Index, s.Last_Name, sampType = STUFF((SELECT distinct ','+ s1.A_Sample_Type from SamplesSetForNaaDB s1 where s1.Country_Code=s.Country_Code and s1.Client_ID = s.Client_ID and s.Year = s1.Year and S.Sample_Set_ID = s1.Sample_Set_ID and s.Sample_Set_Index = s1.Sample_Set_Index FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''), s.Note, s2.cnt as cnt from SamplesSetForNaaDB as s join (select Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, SUM(countOfSamples) as cnt from SamplesSetForNaaDB group by Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index) s2 on s.Country_Code=s2.Country_Code and s.Client_ID = s2.Client_ID and s.Year = s2.Year and S.Sample_Set_ID = s2.Sample_Set_ID and s.Sample_Set_Index = s2.Sample_Set_Index  {whereString} group by  s.Country_Code, s.Client_ID, s.Year, s.Sample_Set_ID, s.Sample_Set_Index, s.Last_Name, s.Note, s2.cnt order by s.Year, S.Sample_Set_ID, S.Sample_Set_Index"

        Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
        Dim ds1 As New DataSet()
        Debug.WriteLine(cmd.CommandText)
        dataadapter.Fill(ds1, "PrintView")
        OpenSampleForm.DataGridViewForPrint.DataSource = ds1
        OpenSampleForm.DataGridViewForPrint.DataMember = "PrintView"
        Debug.WriteLine(OpenSampleForm.DataGridViewForPrint.RowCount)
        OpenSampleForm.DataGridViewForPrint.Columns(0).HeaderText = "Код страны"
        OpenSampleForm.DataGridViewForPrint.Columns(1).HeaderText = "Номер клиента"
        OpenSampleForm.DataGridViewForPrint.Columns(2).HeaderText = "Год"
        OpenSampleForm.DataGridViewForPrint.Columns(3).HeaderText = "Номер партии"
        OpenSampleForm.DataGridViewForPrint.Columns(4).HeaderText = "Индекс партии"
        OpenSampleForm.DataGridViewForPrint.Columns(5).HeaderText = "Фамилия клиента"
        OpenSampleForm.DataGridViewForPrint.Columns(6).HeaderText = "Тип образцов"
        OpenSampleForm.DataGridViewForPrint.Columns(7).HeaderText = "Примечания"
        OpenSampleForm.DataGridViewForPrint.Columns(8).HeaderText = "Кол-во образцов"
        OpenSampleForm.Show()

    End Sub

    Private Sub ChangeLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeLang.Click
        If ChangeLang.Text = "Русский" Then
            My.Settings.language = "English"
            ChangeLang.Text = "English"
            Application.Restart()
        ElseIf ChangeLang.Text = "English" Then
            My.Settings.language = "Русский"
            ChangeLang.Text = "Русский"
            Application.Restart()
        End If
    End Sub

    Private Sub ButtonshowAll_Click(sender As Object, e As EventArgs) Handles ButtonshowAll.Click
        If CBFilter.SelectedItem <> "Показать все" Then
            CBFilter.SelectedItem = "Показать все"
        Else
            DataSampleSetLoad("")
        End If
        DataGridView_Description.ClearSelection()
    End Sub

    Public hist As String = ""

    Private Sub ButtonShowAllSrms_Click(sender As Object, e As EventArgs) Handles ButtonShowAllSrms.Click
        Dim sqlConnection1 As New SqlConnection(MyConnectionString)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text

        ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)

        cmd.CommandText = "select * from SRM_Set_All"

        Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
        Dim ds As New DataSet()

        dataadapter.Fill(ds, "SrmSetAll")
        Table_SRM_SetDataGridView.DataSource = ds
        Table_SRM_SetDataGridView.DataMember = "SrmSetAll"
        Change_Language()
    End Sub

    Private Sub ResetLoginButton_Click(sender As Object, e As EventArgs) Handles ResetLoginButton.Click
        AdysTech.CredentialManager.CredentialManager.RemoveCredentials($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name}_RDBC")

        Application.Restart()
    End Sub

    Private Sub CloseFormHandler(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub B_Select_Sample_Set_Click(sender As Object, e As EventArgs) Handles B_Select_Sample_Set.Click
        If DataGridView_Sample_Set.SelectedCells.Count = 0 Then Exit Sub

        OldCore.Utilities.Settings.ConnectionString = MyConnectionString
        OldCore.Utilities.Settings.AssemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name

        Try
            Dim showcontentform As New Extensions.NewForms.ShowSetContentForm(String.Join("-", DataGridView_Sample_Set.SelectedCells.Cast(Of DataGridViewCell).Where(Function(c As DataGridViewCell) c.Value <> Nothing).Select(Function(c As DataGridViewCell) c.Value.ToString()).ToArray()))
            showcontentform.Show()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If DataGridView_Sample_Set.SelectedCells.Count = 0 Then Exit Sub
            If DataGridView_Description.Rows(0).Cells(0).Value = 0 Then
                If language = "Русский" Then
                    MsgBox("Партия образцов не содержит ни одного образца. Выберите другую партию!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf language = "English" Then
                    MsgBox("This sample set has not any sample. Select another sample set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Form_NAA_Results.Show()

            Dim L_SS_Country_Code As String = DataGridView_Sample_Set.SelectedCells(0).Value
            Dim L_SS_Client_ID As String = DataGridView_Sample_Set.SelectedCells(1).Value
            Dim L_SS_Year As String = DataGridView_Sample_Set.SelectedCells(2).Value
            Dim L_SS_Sample_Set_ID As String = DataGridView_Sample_Set.SelectedCells(3).Value
            Dim L_SS_Sample_Set_Index As String = DataGridView_Sample_Set.SelectedCells(4).Value

            Form_NAA_Results.L_SS_Country_Code.Text = L_SS_Country_Code
            Form_NAA_Results.L_SS_Client_ID.Text = L_SS_Client_ID
            Form_NAA_Results.L_SS_Year.Text = L_SS_Year
            Form_NAA_Results.L_SS_Sample_Set_ID.Text = L_SS_Sample_Set_ID
            Form_NAA_Results.L_SS_Sample_Set_Index.Text = L_SS_Sample_Set_Index

            Using sqlConnection1 As New SqlConnection(MyConnectionString)
                Using cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "select * from NaaRes where F_Country_Code = '" & L_SS_Country_Code & "' and F_Client_ID = '" & L_SS_Client_ID & "' and F_Year = '" & L_SS_Year & "' and F_Sample_Set_Id = '" & L_SS_Sample_Set_ID & "' and F_Sample_Set_Index = '" & L_SS_Sample_Set_Index & "'"

                    Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                    Dim ds As New DataSet()

                    dataadapter.Fill(ds, "SampleInf")

                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.ColumnHeadersVisible = False
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.DataSource = ds
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.DataMember = "SampleInf"

                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Country_Code")
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Client_ID")
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Year")
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Sample_Set_Id")
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns.Remove("F_Sample_Set_Index")

                    For k As Integer = 0 To 6
                        Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(k).Frozen = True
                        Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(k).ReadOnly = True
                    Next

                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns(5).ReadOnly = False
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.AllowUserToAddRows = False

                    Dim inum As Integer = 1
                    Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.ColumnHeadersVisible = True
                End Using
            End Using

            ' FIXME: I have to deny sorting by the elements value, but it decrease perfomance too much
            'For Each dgvc As DataGridViewColumn In Form_NAA_Results.DataGridView_Table_Sample_NAA_Results.Columns
            '    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable
            'Next

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Me.Text)
            If language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_NAA_Results_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf language = "English" Then
                MsgBox("The operation was cancelled (error in B_NAA_Results_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_NAA_Results.Close()
            Exit Sub
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Notice.Show()
        Dim L_SS_Country_Code As String = DataGridView_Sample_Set.SelectedCells(0).Value
        Dim L_SS_Client_ID As String = DataGridView_Sample_Set.SelectedCells(1).Value
        Dim L_SS_Year As String = DataGridView_Sample_Set.SelectedCells(2).Value
        Dim L_SS_Sample_Set_ID As String = DataGridView_Sample_Set.SelectedCells(3).Value
        Dim L_SS_Sample_Set_Index As String = DataGridView_Sample_Set.SelectedCells(4).Value
        Dim sqlConnection1 As New SqlConnection(MyConnectionString)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        cmd.CommandText = "select Note from table_Sample_Set where Country_Code = '" & L_SS_Country_Code & "' and Client_ID = '" & L_SS_Client_ID & "' and Year = '" & L_SS_Year & "' and Sample_Set_Id = '" & L_SS_Sample_Set_ID & "' and Sample_Set_Index = '" & L_SS_Sample_Set_Index & "'"
        cmd.Connection = sqlConnection1
        sqlConnection1.Open()
        reader = cmd.ExecuteReader()
        reader.Read()
        Form_Notice.RichTextBoxFormNotice.Text = reader(0)
        sqlConnection1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DonSeeSetInTheListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonSeeSetInTheListToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/regata-jinr/RegataDBC#%D1%84%D0%B8%D0%BB%D1%8C%D1%82%D1%80%D0%B0%D1%86%D0%B8%D1%8F-%D0%BF%D0%B0%D1%80%D1%82%D0%B8%D0%B9")
    End Sub

    Private Sub HowToDownloadAllSpectraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToDownloadAllSpectraToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/regata-jinr/RegataDBC#%D0%B7%D0%B0%D0%B3%D1%80%D1%83%D0%B7%D0%BA%D0%B0-%D1%81%D0%BF%D0%B5%D0%BA%D1%82%D1%80%D0%BE%D0%B2-%D0%BF%D0%B0%D1%80%D1%82%D0%B8%D0%B8")
    End Sub

    Private Sub HowToDownloadSomeSpectraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToDownloadSomeSpectraToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/regata-jinr/RegataDBC#%D0%B7%D0%B0%D0%B3%D1%80%D1%83%D0%B7%D0%BA%D0%B0-%D0%B2%D1%8B%D0%B1%D1%80%D0%B0%D0%BD%D0%BD%D1%8B%D1%85-%D1%81%D0%BF%D0%B5%D0%BA%D1%82%D1%80%D0%BE%D0%B2")
    End Sub

    Private Sub HowToFindTheSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToFindTheSetToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/regata-jinr/RegataDBC#%D1%84%D0%B8%D0%BB%D1%8C%D1%82%D1%80%D0%B0%D1%86%D0%B8%D1%8F-%D0%BF%D0%B0%D1%80%D1%82%D0%B8%D0%B9")
    End Sub

    Private Sub ErrorJournalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorJournalToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/document/d/14e4ZUJlgrXMQ4VOL0Xopj1fB9Qgd8s1bWbHCoJSEzTU/edit?usp=sharing")
    End Sub

    Public firstFlag As Integer = 0

    Private Sub CBFilter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBFilter.SelectedIndexChanged
        Try
            If SampleSetFormLoadFlag Then
                Dim sqlConnection1 As New SqlConnection(MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text
                Dim qs As String = "select * from SamplesSetForNaaDB as sampSet "
                If CBFilter.SelectedItem = "Показать все" Then
                    hist = ""
                    L_Name_Sample_Set_View.Text = "Выберите тип" & vbCrLf & "фильтра"
                    DataSampleSetLoad(hist)
                    ComboBox_Sample_Set_View.Text = ""
                    ComboBox_Sample_Set_View.Items.Clear()
                    firstFlag = 0
                ElseIf CBFilter.SelectedItem = "Обработано" Then
                    ComboBox_Sample_Set_View.Text = ""
                    L_Name_Sample_Set_View.Text = "Фамилия" & vbCrLf & "обработчика"

                    ComboBox_Sample_Set_View.Items.Clear()
                    cmd.CommandText = "select distinct b.R_Processed_By from (" & qs & fields & ") as b ORDER BY b.R_Processed_By"
                    Debug.WriteLine(qs)
                    Debug.WriteLine(fields)
                    Debug.WriteLine(cmd.CommandText)
                    'cmd.CommandText = "SELECT * FROM table_Received_By ORDER BY Received_By"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

                    End While
                    sqlConnection1.Close()

                ElseIf CBFilter.SelectedItem = "Код клиента" Then
                    ComboBox_Sample_Set_View.Text = ""
                    L_Name_Sample_Set_View.Text = "Фамилия " & "Код страны" & vbCrLf & "Код клиента"

                    ComboBox_Sample_Set_View.Items.Clear()
                    cmd.CommandText = "select distinct b.clientInfo from (" & qs & " join (select Country_Code as cc, Client_ID as ci, Last_Name + ';' + Country_Code + ';' + Client_ID as clientInfo from table_Client) as cl on cl.ci = sampSet.Client_ID and cl.cc = sampSet.Country_Code " & fields & ") as b ORDER BY b.clientInfo"
                    Debug.WriteLine(cmd.CommandText)
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

                    End While
                    sqlConnection1.Close()

                ElseIf CBFilter.SelectedItem = "Страна" Then
                    ComboBox_Sample_Set_View.Text = ""
                    L_Name_Sample_Set_View.Text = "Страна"

                    ComboBox_Sample_Set_View.Items.Clear()
                    cmd.CommandText = "select distinct b.Country_Code from (" & qs & fields & ") as b ORDER BY b.Country_Code"

                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

                    End While
                    sqlConnection1.Close()

                ElseIf CBFilter.SelectedItem = "Год" Then
                    ComboBox_Sample_Set_View.Text = ""
                    L_Name_Sample_Set_View.Text = "Год"

                    ComboBox_Sample_Set_View.Items.Clear()
                    cmd.CommandText = "select distinct b.Year from (" & qs & fields & ") as b ORDER BY b.Year"
                    '"select distinct Year from SampleSetForNaaDB ORDER BY Year"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

                    End While

                ElseIf CBFilter.SelectedItem = "Тип работ" Then
                    ComboBox_Sample_Set_View.Text = ""
                    L_Name_Sample_Set_View.Text = "Тип работ"

                    ComboBox_Sample_Set_View.Items.Clear()
                    cmd.CommandText = "select distinct b.Notes_3 from (" & qs & fields & ") as b ORDER BY b.Notes_3"
                    '"select distinct Year from SampleSetForNaaDB ORDER BY Year"
                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader(0)) Then ComboBox_Sample_Set_View.Items.Add(reader(0))

                    End While
                    sqlConnection1.Close()

                End If
                DataGridView_Sample_Set.Focus()
            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try

    End Sub


    Private Sub ComboBox_Sample_Set_View_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_Sample_Set_View.SelectedIndexChanged

        Try
            If L_Name_Sample_Set_View.Text = "Фамилия" & vbCrLf & "обработчика" Then
                Try
                    If hist = "" Then
                        hist = hist & " where sampSet.R_Processed_By like  '%" + ComboBox_Sample_Set_View.SelectedItem + "%'"
                    Else
                        hist = hist & " and sampSet.R_Processed_By like '%" + ComboBox_Sample_Set_View.SelectedItem + "%'"
                    End If
                    If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)

                Catch ex As Exception
                    MsgBox("Партий с таким обработчиком не найдено.")
                    DataSampleSetLoad("")
                End Try
            ElseIf L_Name_Sample_Set_View.Text = "Фамилия " & "Код страны" & vbCrLf & "Код клиента" Then
                If hist = "" Then
                    hist = hist & " where sampSet.Client_ID = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(2) & "' and sampSet.Country_Code = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(1) & "'"
                Else
                    hist = hist & " and sampSet.Client_ID = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(2) & "' and sampSet.Country_Code = '" & Split(ComboBox_Sample_Set_View.SelectedItem, ";")(1) & "'"
                End If

                If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)
            ElseIf L_Name_Sample_Set_View.Text = "Страна" Then
                If hist = "" Then
                    hist = hist & " where sampSet.Country_Code = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
                Else
                    hist = hist & " and sampSet.Country_Code = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
                End If

                If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)
            ElseIf L_Name_Sample_Set_View.Text = "Год" Then
                If hist = "" Then
                    hist = hist & " where sampSet.Year = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
                Else
                    hist = hist & " and sampSet.Year = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
                End If
                If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)

            ElseIf L_Name_Sample_Set_View.Text = "Тип работ" Then
                If hist = "" Then
                    hist = hist & " where sampSet.Notes_3 = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
                Else
                    hist = hist & " and sampSet.Notes_3 = '" + ComboBox_Sample_Set_View.SelectedItem + "'"
                End If
                If SampleSetFormLoadFlag Then DataSampleSetLoad(hist)
            End If
            DataGridView_Sample_Set.Focus()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try
    End Sub


    Private Sub ShowIrrRegisters_Click(sender As System.Object, e As System.EventArgs) Handles ShowIrrRegisters.Click
        Regata.Core.DataBase.RegataContext.ConString = MyConnectionString
        Dim f As New Extensions.NewForms.ChooseIrrRegForm()
        f.Show()
    End Sub


    Private Sub BackgroundWorkerColorizer_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerColorizer.DoWork
        ColorizeAll()
    End Sub

End Class