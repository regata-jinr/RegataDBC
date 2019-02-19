Imports System.Data.SqlClient
Imports System.Math


Public Class Form_SLI_Irradiation_Log
    Private Sub Form_SLI_Table_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)
            '  Form_Main.Form_Main_Load(sender, e)
            '  Form_Main.Enabled = True
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Try
            Dim response As MsgBoxResult
            If Form_Main.language = "Русский" Then
                response = MsgBox("Вы уверены? Все необходимые данные сохранены?", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, Me.Text)
                If response = MsgBoxResult.Ok Then
                    Me.Close()
                    Exit Sub
                ElseIf response = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            ElseIf Form_Main.language = "English" Then
                MsgBox("Are you sure? Is all necessary data stored?", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, Me.Text)
                If response = MsgBoxResult.Ok Then
                    Me.Close()
                    Exit Sub
                ElseIf response = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_SLI_Table_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        If Form_Main.language = "Русский" Then
            MsgBox("Операция была отменена (ошибка в DataGridView_SLI_Table_DataError)!", MsgBoxStyle.Critical, Me.Text)
        ElseIf Form_Main.language = "English" Then
            MsgBox("Operation was cancelled (error in DataGridView_SLI_Table_DataError)!", MsgBoxStyle.Critical, Me.Text)
        End If
        Exit Sub
    End Sub

    Private Sub Form_SLI_Irradiation_Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If Form_Main.language = "Русский" Then
                ' Form_SLI_Irradiation_Log
                Me.Text = "Журнал облучения КЖИ"
                L_Name_SLI_Irradiation_Log.Text = "Журнал облучения КЖИ"
                Button_Save_SLI_Log_To_File.Text = "Сохранить журнал КЖИ в файл"

                L_Name_Sample_Set.Text = "Партии образцов"
                L_Name_Sample_Set_View.Text = "Вид партий образцов"
                L_Name_Sample.Text = "Образцы"
                B_Add_Sample.Text = "Добавить образ."
                L_Name_Sample_All_SLI_Weight.Text = "Вес образцов КЖИ"
                Button_Auto_Fill_In_Irradiation_Start_Time.Text = "Авто заполнение врем. начала обл."
                B_Delete_Sample_From_Log.Text = "Удалить образец из журнала"
                L_Name_Time.Text = "Время"
                B_Fill_In_Time_Start.Text = "Зап. время нач. обл."
                L_Name_Spectrum_File.Text = "Файл спектра"
                B_Fill_In_Spectrum_File.Text = "Зап. файл спектра"
                L_Name_Person.Text = "ФИО"
                B_Fill_In_Irradiated_By.Text = "Заполнить 'Облучён'"
                L_Name_Channel.Text = "Канал"
                B_Fill_In_Channel.Text = "Заполнить канал"
                L_Name_Duration.Text = "Длительн., сек"
                B_Fill_In_Duration.Text = "Заполнить длительн."

                L_Name_SRM_Set.Text = "Партии стандартов"
                L_Name_SRM.Text = "Стандарты"
                L_Name_SRM_Set_View.Text = "Вид партий стандартов"
                B_Add_SRM.Text = "Добавить стандарт"
                B_Delete_Last_Irradiation_Date_From_Log.Text = "Удалить посл. дату облучения из журнала"
                B_Set_SRM_As_Not_In_Use.Text = "Исключить стандарт"

                L_Name_Monitor_Set.Text = "Партии мониторов"
                L_Name_Monitor.Text = "Мониторы"
                L_Name_Monitor_Set_View.Text = "Вид партий мониторов"
                B_Add_Monitor.Text = "Добавить монитор"
                B_Delete_Monitor_From_Log.Text = "Удалить монитор из журнала"
                B_Set_Monitor_As_Not_In_Use.Text = "Исключить монитор"

                B_Save_And_Update_SLI.Text = "Сохранить и обновить журнал КЖИ"
                B_Close.Text = "Закрыть"

                ComboBox_Sample_Set_View.Items.Clear()
                ComboBox_Sample_Set_View.Items.Add("Все партии образцов")
                ComboBox_Sample_Set_View.Items.Add("Партии образцов из журнала")

                ComboBox_SRM_Set_View.Items.Clear()
                ComboBox_SRM_Set_View.Items.Add("Все партии стандартов")
                ComboBox_SRM_Set_View.Items.Add("Партии стандартов из журнала")

                ComboBox_Monitor_Set_View.Items.Clear()
                ComboBox_Monitor_Set_View.Items.Add("Все партии мониторов")
                ComboBox_Monitor_Set_View.Items.Add("Партии мониторов из журнала")

                SaveFileDialog_SLI.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "English" Then
                ' Form_SLI_Irradiation_Log
                Me.Text = "SLI irradiation log"
                L_Name_SLI_Irradiation_Log.Text = "SLI irradiation log"
                Button_Save_SLI_Log_To_File.Text = "Save SLI log to file"

                L_Name_Sample_Set.Text = "Sample sets"
                L_Name_Sample_Set_View.Text = "Sample sets view"
                L_Name_Sample.Text = "Samples"
                B_Add_Sample.Text = "Add sample"
                L_Name_Sample_All_SLI_Weight.Text = "Samples's SLI weight"
                Button_Auto_Fill_In_Irradiation_Start_Time.Text = "Auto fill in irradiation start time"
                B_Delete_Sample_From_Log.Text = "Delete sample from log"
                L_Name_Time.Text = "Time"
                B_Fill_In_Time_Start.Text = "Fill in start time"
                L_Name_Spectrum_File.Text = "Spectrum file"
                B_Fill_In_Spectrum_File.Text = "Fill in spectrum file"
                L_Name_Person.Text = "Person"
                B_Fill_In_Irradiated_By.Text = "Fill in irradiated by"
                L_Name_Channel.Text = "Channel"
                B_Fill_In_Channel.Text = "Fill in channel"
                L_Name_Duration.Text = "Duration, sec"
                B_Fill_In_Duration.Text = "Fill in duration"

                L_Name_SRM_Set.Text = "SRM sets"
                L_Name_SRM.Text = "SRMs"
                L_Name_SRM_Set_View.Text = "SRM sets view"
                B_Add_SRM.Text = "Add SRM"
                B_Delete_Last_Irradiation_Date_From_Log.Text = "Delete last irradiation date from log"
                B_Set_SRM_As_Not_In_Use.Text = "Set SRM as not in use"

                L_Name_Monitor_Set.Text = "Monitor sets"
                L_Name_Monitor.Text = "Monitors"
                L_Name_Monitor_Set_View.Text = "Monitor sets view"
                B_Add_Monitor.Text = "Add monitor"
                B_Delete_Monitor_From_Log.Text = "Delete monitor from log"
                B_Set_Monitor_As_Not_In_Use.Text = "Set monitor as not in use"

                B_Save_And_Update_SLI.Text = "Save and update log SLI"
                B_Close.Text = "Close"

                ComboBox_Sample_Set_View.Items.Clear()
                ComboBox_Sample_Set_View.Items.Add("All sample sets")
                ComboBox_Sample_Set_View.Items.Add("Sample sets from log")

                ComboBox_SRM_Set_View.Items.Clear()
                ComboBox_SRM_Set_View.Items.Add("All SRM sets")
                ComboBox_SRM_Set_View.Items.Add("SRM sets from log")

                ComboBox_Monitor_Set_View.Items.Clear()
                ComboBox_Monitor_Set_View.Items.Add("All monitor sets")
                ComboBox_Monitor_Set_View.Items.Add("Monitor sets from log")

                SaveFileDialog_SLI.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            End If

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Received_By". При необходимости она может быть перемещена или удалена.
            Table_Received_By_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Received_By_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Received_By)

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Sample_SLI_Irradiation_Log". При необходимости она может быть перемещена или удалена.
            Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString

            Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            ListBox_Sample_ID.Items.Clear()
            ListBox_Sample_ID_All_SLI_Weight.Items.Clear()

            'DataGridView_SLI_Irradiation_Log.AutoResizeColumnHeadersHeight(DataGridViewColumnHeadersHeightSizeMode.AutoSize)

            'DataGridView_SLI_Irradiation_Log.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders ) 'это касается строк
            Dim g As Graphics = DataGridView_SLI_Irradiation_Log.CreateGraphics()
            Dim offset As Integer = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("  ", DataGridView_SLI_Irradiation_Log.ColumnHeadersDefaultCellStyle.Font).Width))

            With DataGridView_SLI_Irradiation_Log
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Country_Code", "Код страны")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Country_Code", "Country code")
                End If
                .Columns(0).DataPropertyName = "Country_Code" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                .Columns(0).Frozen = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Country", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Client_ID", "Клиентский №")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Client_ID", "Client ID")
                End If
                .Columns(1).DataPropertyName = "Client_ID"
                .Columns(1).ReadOnly = True
                .Columns(1).Frozen = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Клиентский", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Year", "Год")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Year", "Year")
                End If
                .Columns(2).DataPropertyName = "Year"
                .Columns(2).ReadOnly = True
                .Columns(2).Frozen = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Year", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Sample_Set_ID", "№ партии образцов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Sample_Set_ID", "Sample set ID")
                End If
                .Columns(3).DataPropertyName = "Sample_Set_ID"
                .Columns(3).ReadOnly = True
                .Columns(3).Frozen = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Sample_Set_Index", "Индекс партии образцов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Sample_Set_Index", "Sample set index")
                End If
                .Columns(4).DataPropertyName = "Sample_Set_Index"
                .Columns(4).ReadOnly = True
                .Columns(4).Frozen = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Sample_ID", "Номер образца")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Sample_ID", "Sample ID")
                End If
                .Columns(5).DataPropertyName = "Sample_ID"
                .Columns(5).ReadOnly = True
                .Columns(5).Frozen = True
                .Columns(5).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образца", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Date_Start", "Дата облучения")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Date_Start", "Irradiation date")
                End If
                .Columns(6).DataPropertyName = "Date_Start"
                .Columns(6).ReadOnly = True
                .Columns(6).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Time_Start", "Время начала облучения")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Time_Start", "Start time")
                End If
                .Columns(7).DataPropertyName = "Time_Start"
                .Columns(7).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("облучения", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset 'этот столб считаем, как и предыдущий, по Irradiation

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Channel", "Канал")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Channel", "Channel")
                End If
                .Columns(8).DataPropertyName = "Channel"
                .Columns(8).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Channel", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Duration", "Длительность, сек")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Duration", "Duration, sec")
                End If
                .Columns(9).DataPropertyName = "Duration"
                .Columns(9).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Длительность,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(10).HeaderText = "Detector №" 'СКРЫТ
                '.Columns(10).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Detector", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                '.Columns(10).Visible = False

                '.Columns(11).HeaderText = "Detector 5" 'СКРЫТ
                '.Columns(11).Visible = False

                '.Columns(12).HeaderText = "Detector 6" 'СКРЫТ
                '.Columns(12).Visible = False

                '.Columns(13).HeaderText = "Detector 7" 'СКРЫТ
                '.Columns(13).Visible = False

                If Form_Main.language = "Русский" Then
                    .Columns.Add("File_First", "Файл спектра")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("File_First", "Spectrum file")
                End If
                .Columns(10).DataPropertyName = "File_First" 'ПОКАЗАН, это бывший столб "First file" и бывший столб № 14

                '.Columns(15).HeaderText = "Last file" 'СКРЫТ
                '.Columns(15).Visible = False

                '.Columns(16).HeaderText = "Paper log number" 'СКРЫТ
                '.Columns(16).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("number", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                '.Columns(16).Visible = False

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Irradiated_By", "Облучён")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Irradiated_By", "Irradiated by")
                End If
                .Columns(11).DataPropertyName = "Irradiated_By"
                .Columns(11).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Alekseenok Yu.V.", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset 'этот столб считаем по самой длинной фамилии, это бывший столб № 17

                '.Columns(18).HeaderText = "Measured by" 'СКРЫТ
                '.Columns(18).Visible = False

                '.Columns(19).HeaderText = "Position number" 'СКРЫТ
                '.Columns(19).Visible = False

                If .RowCount > 0 Then
                    .FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To .RowCount - 1
                        .Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Sample_Set.RowCount - 1).Selected = True
                End If
            End With

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_ExpDataSet.table_Sample_Set". При необходимости она может быть перемещена или удалена.
            Table_Sample_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Sample_Set_TableAdapter.Fill_Sample_Set(Me.NAA_DB_EXPDataSet.table_Sample_Set)

            With DataGridView_SLI_Sample_Set
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Country_Code", "Код страны")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Country_Code", "Country code")
                End If
                .Columns(0).DataPropertyName = "Country_Code" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Country", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Client_ID", "Клиентский №")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Client_ID", "Client ID")
                End If
                .Columns(1).DataPropertyName = "Client_ID"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Клиентский", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Year", "Год")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Year", "Year")
                End If
                .Columns(2).DataPropertyName = "Year"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Year", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Sample_Set_ID", "№ партии образцов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Sample_Set_ID", "Sample set ID")
                End If
                .Columns(3).DataPropertyName = "Sample_Set_ID"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Sample_Set_Index", "Индекс партии образцов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Sample_Set_Index", "Sample set index")
                End If
                .Columns(4).DataPropertyName = "Sample_Set_Index"
                .Columns(4).ReadOnly = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If .RowCount > 0 Then
                    .FirstDisplayedScrollingRowIndex = .RowCount - 1
                    For i = 0 To .RowCount - 1
                        .Rows.Item(i).Selected = False
                    Next
                    '.Rows.Item(.RowCount - 1).Selected = True
                End If
            End With

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM_Set". При необходимости она может быть перемещена или удалена.
            Table_SRM_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_SRM_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_SRM_Set)

            With DataGridView_Table_SRM_Set
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_Set_Name", "Имя партии стандартов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_Set_Name", "SRM set name")
                End If
                .Columns(0).DataPropertyName = "SRM_Set_Name"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандартов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_Set_Number", "№ партии стандартов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_Set_Number", "SRM set number")
                End If
                .Columns(1).DataPropertyName = "SRM_Set_Number"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандартов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_Set_Type", "Тип партии стандартов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_Set_Type", "SRM set type")
                End If
                .Columns(2).DataPropertyName = "SRM_Set_Type"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандартов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_Set_Weight", "Вес партии, гр")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_Set_Weight", "Set weight, g")
                End If
                .Columns(3).DataPropertyName = "SRM_Set_Weight"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Weight,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_Set_Purchasing_Date", "Дата покупки")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_Set_Purchasing_Date", "Purchasing date")
                End If
                .Columns(4).DataPropertyName = "SRM_Set_Purchasing_Date"
                .Columns(4).ReadOnly = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Purchasing", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If .RowCount > 0 Then
                    .FirstDisplayedScrollingRowIndex = .RowCount - 1
                    For i = 0 To .RowCount - 1
                        .Rows.Item(i).Selected = False
                    Next
                    '.Rows.Item(.RowCount - 1).Selected = True
                End If
            End With

            With DataGridView_Table_SRM
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_Number", "№ стандарта")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_Number", "SRM number")
                End If
                .Columns(0).DataPropertyName = "SRM_Number"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандарта", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Weight", "Вес, гр")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Weight", "Weight, g")
                End If
                .Columns(1).DataPropertyName = "SRM_SLI_Weight"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Weight,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_1", "Дата облучения 1")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_1", "Irradiation date 1")
                End If
                .Columns(2).DataPropertyName = "SRM_SLI_Irradiation_Date_1"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_2", "Дата облучения 2")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_2", "Irradiation date 2")
                End If
                .Columns(3).DataPropertyName = "SRM_SLI_Irradiation_Date_2"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_3", "Дата облучения 3")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_3", "Irradiation date 3")
                End If
                .Columns(4).DataPropertyName = "SRM_SLI_Irradiation_Date_3"
                .Columns(4).ReadOnly = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_4", "Дата облучения 4")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_4", "Irradiation date 4")
                End If
                .Columns(5).DataPropertyName = "SRM_SLI_Irradiation_Date_4"
                .Columns(5).ReadOnly = True
                .Columns(5).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_5", "Дата облучения 5")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_5", "Irradiation date 5")
                End If
                .Columns(6).DataPropertyName = "SRM_SLI_Irradiation_Date_5"
                .Columns(6).ReadOnly = True
                .Columns(6).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_6", "Дата облучения 6")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_6", "Irradiation date 6")
                End If
                .Columns(7).DataPropertyName = "SRM_SLI_Irradiation_Date_6"
                .Columns(7).ReadOnly = True
                .Columns(7).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_7", "Дата облучения 7")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_7", "Irradiation date 7")
                End If
                .Columns(8).DataPropertyName = "SRM_SLI_Irradiation_Date_7"
                .Columns(8).ReadOnly = True
                .Columns(8).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_8", "Дата облучения 8")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_8", "Irradiation date 8")
                End If
                .Columns(9).DataPropertyName = "SRM_SLI_Irradiation_Date_8"
                .Columns(9).ReadOnly = True
                .Columns(9).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_9", "Дата облучения 9")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_9", "Irradiation date 9")
                End If
                .Columns(10).DataPropertyName = "SRM_SLI_Irradiation_Date_9"
                .Columns(10).ReadOnly = True
                .Columns(10).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_10", "Дата облучения 10")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Irradiation_Date_10", "Irradiation date 10")
                End If
                .Columns(11).DataPropertyName = "SRM_SLI_Irradiation_Date_10"
                .Columns(11).ReadOnly = True
                .Columns(11).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("SRM_SLI_Not_In_Use", "Не используется")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("SRM_SLI_Not_In_Use", "Not in use")
                End If
                .Columns(12).DataPropertyName = "SRM_SLI_Not_In_Use"
                .Columns(12).ReadOnly = True
                .Columns(12).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("используется", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM) ' запрос, который никгда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

                'If Table_SRM_DataGridView.RowCount > 1 Then
                '    Table_SRM_DataGridView.Rows.Clear()
                '    Table_SRM_DataGridView.FirstDisplayedScrollingRowIndex = Table_SRM_DataGridView.RowCount - 1
                '    For i = 0 To Table_SRM_DataGridView.RowCount - 1
                '        Table_SRM_DataGridView.Rows.Item(i).Selected = False
                '    Next
                'End If
            End With

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor_Set". При необходимости она может быть перемещена или удалена.
            Table_Monitor_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Monitor_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor_Set)

            With DataGridView_Table_Monitor_Set
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Name", "Имя партии мониторов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Name", "Monitor set name")
                End If
                .Columns(0).DataPropertyName = "Monitor_Set_Name"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("мониторов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Number", "№ партии мониторов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Number", "Monitor set number")
                End If
                .Columns(1).DataPropertyName = "Monitor_Set_Number"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("мониторов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Type", "Тип партии мониторов")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Type", "Monitor set type")
                End If
                .Columns(2).DataPropertyName = "Monitor_Set_Type"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("мониторов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Weight", "Вес партии, гр")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Weight", "Set weight, g")
                End If
                .Columns(3).DataPropertyName = "Monitor_Set_Weight"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("партии", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Set_Purchasing_Date", "Дата покупки")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Set_Purchasing_Date", "Purchasing date")
                End If
                .Columns(4).DataPropertyName = "Monitor_Set_Purchasing_Date"
                .Columns(4).ReadOnly = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Purchasing", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If .RowCount > 0 Then
                    .FirstDisplayedScrollingRowIndex = .RowCount - 1
                    For i = 0 To .RowCount - 1
                        .Rows.Item(i).Selected = False
                    Next
                    '.Rows.Item(.RowCount - 1).Selected = True
                End If
            End With

            With DataGridView_Table_Monitor
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_Number", "№ монитора")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_Number", "Monitor number")
                End If
                .Columns(0).DataPropertyName = "Monitor_Number"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("монитора", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_SLI_Weight", "Вес, гр")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_SLI_Weight", "Weight, g")
                End If
                .Columns(1).DataPropertyName = "Monitor_SLI_Weight"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Weight,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "Русский" Then
                    .Columns.Add("Monitor_SLI_Date_Start", "Дата облучения")
                ElseIf Form_Main.language = "English" Then
                    .Columns.Add("Monitor_SLI_Date_Start", "Irradiation date")
                End If
                .Columns(2).DataPropertyName = "Monitor_SLI_Date_Start"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(3).HeaderText = "Not in use"
                '.Columns(3).ReadOnly = False
                '.Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Not", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
            End With

            Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor) ' запрос, который никогда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

            'ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            L_Monitor.Text = "M"
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_SLI_Sample_Set_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_SLI_Sample_Set.CellMouseUp
        Try
            If DataGridView_SLI_Sample_Set.SelectedRows.Count = 0 Then Exit Sub
            'If (DataGridView_SLI_Sample_Set.CurrentCellAddress.X = -1) And (DataGridView_SLI_Sample_Set.CurrentCellAddress.Y = -1) Then
            '    ListBox_Sample_ID.Items.Clear()
            '    For i = 0 To DataGridView_SLI_Sample_Set.Rows.Count - 1
            '        DataGridView_SLI_Sample_Set.Rows.Item(i).Selected = False
            '    Next
            '    Exit Sub
            'End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If DataGridView_SLI_Sample_Set.SelectedCells.Count = 0 Then Exit Sub 'иначе ошибка
            cmd.CommandText = "SELECT A_Sample_ID FROM dbo.table_Sample WHERE F_Country_Code='" +
                DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value +
                "' and F_Client_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(1).Value +
                "' and F_Year='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(2).Value +
                "' and F_Sample_Set_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(3).Value +
                "' and F_Sample_Set_Index='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(4).Value +
                "' and I_SLI_Date_Start IS NULL"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ListBox_Sample_ID.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then ListBox_Sample_ID.Items.Add(reader(0))
            End While
            sqlConnection1.Close()

            cmd.CommandText = "SELECT A_Sample_ID, P_Weighting_SLI FROM dbo.table_Sample WHERE F_Country_Code='" +
            DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value +
            "' and F_Client_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(1).Value +
            "' and F_Year='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(2).Value +
            "' and F_Sample_Set_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(3).Value +
            "' and F_Sample_Set_Index='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(4).Value + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ListBox_Sample_ID_All_SLI_Weight.Items.Clear()
            While reader.Read()
                If (Not IsDBNull(reader(0))) And (Not IsDBNull(reader(1))) Then ListBox_Sample_ID_All_SLI_Weight.Items.Add(reader(0) + ", " + reader(1).ToString)
            End While
            sqlConnection1.Close()

            Fill_In_Monitor()
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Fill_In_Monitor()
        Try
            L_Monitor.Text = ""
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "SELECT Country FROM dbo.table_Country WHERE Country_Code='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If Form_Main.language = "Русский" Then
                    If Not IsDBNull(reader(0)) Then L_Monitor.Text = "Страна: " + reader(0).ToString + "; "
                ElseIf Form_Main.language = "English" Then
                    If Not IsDBNull(reader(0)) Then L_Monitor.Text = "Country: " + reader(0).ToString + "; "
                End If
            End While
            sqlConnection1.Close()

            cmd.CommandText = "SELECT Organization, Last_Name FROM dbo.table_Client WHERE Country_Code='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value + "' and Client_Id='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(1).Value + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If Form_Main.language = "Русский" Then
                    If Not IsDBNull(reader(0)) Then L_Monitor.Text = L_Monitor.Text + "Организация: " + reader(0).ToString + "; " + "Фамилия: " + reader(1).ToString + "."
                ElseIf Form_Main.language = "English" Then
                    If Not IsDBNull(reader(0)) Then L_Monitor.Text = L_Monitor.Text + "Organization: " + reader(0).ToString + "; " + "Last name: " + reader(1).ToString + "."
                End If
            End While
            sqlConnection1.Close()
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub B_Add_Sample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Add_Sample.Click
        Try
            If DataGridView_SLI_Sample_Set.SelectedCells.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите партию образцов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select sample set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ListBox_Sample_ID.SelectedItems.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            'Dim Max_Position_Number As Integer
            'Max_Position_Number = 0
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            'cmd.CommandText = "SELECT MAX(I_SLI_Position_Number) FROM dbo.table_Sample WHERE I_SLI_Date='" +
            '    MaskedTextBox_SLI_Irradiation_Log.Text + "'"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'reader = cmd.ExecuteReader()

            'While reader.Read()
            '    If Not IsDBNull(reader(0)) Then Max_Position_Number = reader(0)
            'End While
            'sqlConnection1.Close()

            cmd.CommandText = "INSERT dbo.table_SLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
                " VALUES ('" + DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value + "', '" +
               DataGridView_SLI_Sample_Set.SelectedCells.Item(1).Value + "', '" +
                DataGridView_SLI_Sample_Set.SelectedCells.Item(2).Value + "', '" +
                DataGridView_SLI_Sample_Set.SelectedCells.Item(3).Value + "', '" +
                DataGridView_SLI_Sample_Set.SelectedCells.Item(4).Value + "', '" +
                ListBox_Sample_ID.Text + "', '" + MaskedTextBox_SLI_Irradiation_Log.Text + "')"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "UPDATE dbo.table_Sample SET I_SLI_Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text +
                "' WHERE F_Country_Code='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value +
                "' and F_Client_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(1).Value +
                "' and F_Year='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(2).Value +
                "' and F_Sample_Set_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(3).Value +
                "' and F_Sample_Set_Index='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(4).Value +
                "' and A_Sample_ID='" + ListBox_Sample_ID.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    'Private Sub DataGridView_SLI_Irradiation_Log_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_SLI_Irradiation_Log.KeyDown
    '    Try
    '        'If (e.KeyCode = Keys.Down) And (e.Control = True) Then 'ВЫДЕЛЕННЫЕ СТРОКИ ВВЕРХ
    '        If (e.KeyCode = Keys.Down) Then 'ВЫДЕЛЕННЫЕ СТРОКИ ВВЕРХ
    '            Dim Index As Integer
    '            Dim Position_Number As String
    '            Index = 0
    '            Position_Number = ""
    '            'index = DataGridView_SLI_Irradiation_Log.SelectedRows.Item(0).Index
    '            Index = DataGridView_SLI_Irradiation_Log.CurrentCellAddress.Y
    '            If Index <> DataGridView_SLI_Irradiation_Log.Rows.Count - 1 Then
    '                Position_Number = DataGridView_SLI_Irradiation_Log.Rows.Item(Index).Cells.Item(7).Value
    '                DataGridView_SLI_Irradiation_Log.Rows.Item(Index).Cells.Item(7).Value = Position_Number + 1
    '                DataGridView_SLI_Irradiation_Log.Rows.Item(Index + 1).Cells.Item(7).Value = Position_Number
    '                '    {
    '                '        ListViewItem tempItem = CurrentListView.Items[index - 1];
    '                '        CurrentListView.Items.Remove(tempItem);
    '                '        CurrentListView.Items.Insert(index + (CurrentListView.SelectedItems.Count - 1), tempItem);
    '                '    }
    '                '}

    '                Me.Validate()
    '                Me.TableSampleBindingSource.EndEdit()
    '                Me.Table_SampleTableAdapter.Update(Me.NAA_DB_ExpDataSet.table_Sample)

    '                Table_SampleTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
    '                Table_SampleTableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_ExpDataSet.table_Sample, MaskedTextBox_SLI_Irradiation_Log.Text)
    '                Form_SLI_Irradiation_Log_Load(sender, e)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("The operation was cancelled!")
    '    End Try
    'End Sub

    'Private Sub DataGridView_SLI_Irradiation_Log_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_SLI_Irradiation_Log.KeyUp
    '    Try
    '        'If (e.KeyCode = Keys.Up) And (e.Control = True) Then 'ВЫДЕЛЕННЫЕ СТРОКИ ВВЕРХ
    '        If (e.KeyCode = Keys.Up) Then 'ВЫДЕЛЕННЫЕ СТРОКИ ВВЕРХ
    '            Dim Index As Integer
    '            Dim Position_Number As String
    '            Index = 0
    '            Position_Number = ""
    '            'index = DataGridView_SLI_Irradiation_Log.SelectedRows.Item(0).Index
    '            Index = DataGridView_SLI_Irradiation_Log.CurrentCellAddress.Y
    '            If Index <> 0 Then
    '                Position_Number = DataGridView_SLI_Irradiation_Log.Rows.Item(Index).Cells.Item(7).Value

    '                '    {
    '                '        ListViewItem tempItem = CurrentListView.Items[index - 1];
    '                '        CurrentListView.Items.Remove(tempItem);
    '                '        CurrentListView.Items.Insert(index + (CurrentListView.SelectedItems.Count - 1), tempItem);
    '                '    }
    '                '}
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("The operation was cancelled!")
    '    End Try
    'End Sub

    Private Sub B_Fill_In_Time_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Time_Start.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Time.Text = "  :  :" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите время!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type time!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(7).Value = MaskedTextBox_Time.Text
            Next
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Save_SLI_Irradiation_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.TableSampleBindingSource.EndEdit()
        'Me.TableAdapterManager.table_SampleTableAdapter.Update(Me.NAA_DB_ExpDataSet)

        'Table_SampleTableAdapter.Update = ""

        'Me.Validate()
        'Me.TableSampleBindingSource.EndEdit()
        ''Me.CustomersBindingSource.EndEdit()

        'Dim deletedSamples As NAA_DB_ExpDataSet.table_SampleDataTable = CType(
        '    NAA_DB_ExpDataSet.table_Sample.GetChanges(Data.DataRowState.Deleted), NAA_DB_ExpDataSet.table_SampleDataTable)

        'Dim newSamples As NAA_DB_ExpDataSet.table_SampleDataTable = CType(
        '    NAA_DB_ExpDataSet.table_Sample.GetChanges(Data.DataRowState.Added), NAA_DB_ExpDataSet.table_SampleDataTable)

        'Dim modifiedSamples As NAA_DB_ExpDataSet.table_SampleDataTable = CType(
        '    NAA_DB_ExpDataSet.table_Sample.GetChanges(Data.DataRowState.Modified), NAA_DB_ExpDataSet.table_SampleDataTable)

        'Try
        '    ' Remove all deleted samples from the Sample table.
        '    If Not deletedSamples Is Nothing Then
        '        Table_SampleTableAdapter.Update(deletedSamples)
        '    End If

        '    '' Update the Customers table.
        '    '  Table_SampleTableAdapter.Update(NAA_DB_ExpDataSet.table_Sample)

        '    ' Add new orders to the Orders table.
        '    If Not newSamples Is Nothing Then
        '        Table_SampleTableAdapter.Update(newSamples)
        '    End If

        '    ' Update all modified Orders.
        '    If Not modifiedSamples Is Nothing Then
        '        Table_SampleTableAdapter.Update(modifiedSamples)
        '    End If

        '    NAA_DB_ExpDataSet.AcceptChanges()

        'Catch ex As Exception
        '    MsgBox("Update failed")

        'Finally
        '    If Not deletedSamples Is Nothing Then
        '        deletedSamples.Dispose()
        '    End If

        '    If Not newSamples Is Nothing Then
        '        newSamples.Dispose()
        '    End If

        '    If Not modifiedSamples Is Nothing Then
        '        modifiedSamples.Dispose()
        '    End If
        'End Try
    End Sub

    Private Sub DataGridView_SLI_Irradiation_Log_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_SLI_Irradiation_Log.CellContentClick
        'Try
        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 10 Then 'Детектор 1
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then 'событие CellContentClick происходит перед непосредственным изменением значения ячейки: было DBNull станет True
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(11).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(12).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(13).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value = False Then 'было False станет True
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(11).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(12).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(13).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If

        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 11 Then 'Детектор 2
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(10).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(12).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(13).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(10).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(12).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(13).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If

        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 12 Then 'Детектор 3
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(10).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(11).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(13).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(10).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(11).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(13).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 13 Then 'Детектор 4
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(10).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(11).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(12).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(10).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(11).Value = False
        '            DataGridView_SLI_Irradiation_Log.Rows.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(12).Value = False

        '            'Me.Validate()
        '            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '            'Form_SLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If

        '    'Me.Validate()
        '    'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '    'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '    'Form_SLI_Irradiation_Log_Load(sender, e)

        'Catch ex As Exception
        '    MsgBox("The operation was cancelled!")
        'End Try
    End Sub

    Private Sub DataGridView_SLI_Irradiation_Log_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView_SLI_Irradiation_Log.DataError
        If Form_Main.language = "Русский" Then
            MsgBox("Операция была отменена (ошибка в DataGridView_SLI_Irradiation_Log_DataError)!", MsgBoxStyle.Critical, Me.Text)
        ElseIf Form_Main.language = "English" Then
            MsgBox("Operation was cancelled (error in DataGridView_SLI_Irradiation_Log_DataError)!", MsgBoxStyle.Critical, Me.Text)
        End If
        Exit Sub
    End Sub

    Private Sub B_Delete_Sample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Delete_Sample_From_Log.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_SLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value = "m" Or DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value = "s" Then
                MsgBox("Select one sample!")
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "DELETE FROM dbo.table_SLI_Irradiation_Log" +
               " WHERE Country_Code='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value +
               "' and Client_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(1).Value +
               "' and Year='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(2).Value +
               "' and Sample_Set_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
               "' and Sample_Set_Index='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value +
               "' and Sample_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value +
               "' and Date_Start='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(6).Value + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "UPDATE dbo.table_Sample SET I_SLI_Date_Start=NULL" +
               " WHERE F_Country_Code='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value +
               "' and F_Client_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(1).Value +
               "' and F_Year='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(2).Value +
               "' and F_Sample_Set_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
               "' and F_Sample_Set_Index='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value +
               "' and A_Sample_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value +
               "' and I_SLI_Date_Start='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(6).Value + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Me.Validate()
            'Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
            'Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Irradiated_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Irradiated_By.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = ComboBox_Person.Text
            Next
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Measured_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Measured_By.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(18).Value = ComboBox_Person.Text
            Next
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_Table_SRM_Set_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Table_SRM_Set.CellMouseUp
        Try
            If DataGridView_Table_SRM_Set.SelectedRows.Count = 0 Then Exit Sub
            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM". При необходимости она может быть перемещена или удалена.
            Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_SRM_TableAdapter.Fill_In_Use_SLI(Me.NAA_DB_EXPDataSet.table_SRM, DataGridView_Table_SRM_Set.SelectedCells.Item(0).Value, DataGridView_Table_SRM_Set.SelectedCells.Item(1).Value)

            If DataGridView_Table_SRM.RowCount > 0 Then
                DataGridView_Table_SRM.FirstDisplayedScrollingRowIndex = 0
                For i = 0 To DataGridView_Table_SRM.RowCount - 1
                    DataGridView_Table_SRM.Rows.Item(i).Selected = False
                Next
                'Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.RowCount - 1).Selected = True
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Add_SRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Add_SRM.Click
        '        Update(table_SRM)
        'SET              SRM_Set_Weight = @SRM_Set_Weight, SRM_SLI_Weight = @SRM_SLI_Weight, SRM_LLI_Weight = @SRM_LLI_Weight, 
        '                      SRM_SLI_Irradiation_Date_1 = @SRM_SLI_Irradiation_Date_1, SRM_SLI_Irradiation_Date_2 = @SRM_SLI_Irradiation_Date_2, 
        '                      SRM_SLI_Irradiation_Date_3 = @SRM_SLI_Irradiation_Date_3, SRM_SLI_Irradiation_Date_4 = @SRM_SLI_Irradiation_Date_4, 
        '                      SRM_SLI_Irradiation_Date_5 = @SRM_SLI_Irradiation_Date_5, SRM_SLI_Irradiation_Date_6 = @SRM_SLI_Irradiation_Date_6, 
        '                      SRM_SLI_Irradiation_Date_7 = @SRM_SLI_Irradiation_Date_7, SRM_SLI_Irradiation_Date_8 = @SRM_SLI_Irradiation_Date_8, 
        '                      SRM_SLI_Irradiation_Date_9 = @SRM_SLI_Irradiation_Date_9, SRM_SLI_Irradiation_Date_10 = @SRM_SLI_Irradiation_Date_10, 
        '                      SRM_SLI_Not_In_Use = @SRM_SLI_Not_In_Use, SRM_LLI_Irradiation_Date_1 = @SRM_LLI_Irradiation_Date_1, 
        '                      SRM_LLI_Irradiation_Date_2 = @SRM_LLI_Irradiation_Date_2, SRM_LLI_Irradiation_Date_3 = @SRM_LLI_Irradiation_Date_3, 
        '                      SRM_LLI_Irradiation_Date_4 = @SRM_LLI_Irradiation_Date_4, SRM_LLI_Irradiation_Date_5 = @SRM_LLI_Irradiation_Date_5, 
        '                      SRM_LLI_Irradiation_Date_6 = @SRM_LLI_Irradiation_Date_6, SRM_LLI_Irradiation_Date_7 = @SRM_LLI_Irradiation_Date_7, 
        '                      SRM_LLI_Irradiation_Date_8 = @SRM_LLI_Irradiation_Date_8, SRM_LLI_Irradiation_Date_9 = @SRM_LLI_Irradiation_Date_9, 
        '                      SRM_LLI_Irradiation_Date_10 = @SRM_LLI_Irradiation_Date_10, SRM_LLI_Not_In_Use = @SRM_LLI_Not_In_Use
        'WHERE     (SRM_Set_Name = @SRM_Set_Name) AND (SRM_Set_Number = @SRM_Set_Number) AND (SRM_Number = @SRM_Number)

        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If DataGridView_Table_SRM_Set.SelectedCells.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите партию стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select SRM set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_Table_SRM.SelectedCells.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            For i = 1 To 10
                If IsDBNull(DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i + 1).Value) = True Then
                    If i > 1 Then
                        If MaskedTextBox_SLI_Irradiation_Log.Text <= DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i).Value Then
                            If Form_Main.language = "Русский" Then
                                MsgBox("Некорректная дата!", MsgBoxStyle.Exclamation, Me.Text)
                            ElseIf Form_Main.language = "English" Then
                                MsgBox("Incorrect date!", MsgBoxStyle.Exclamation, Me.Text)
                            End If
                            Exit Sub
                        End If
                    End If

                    cmd.CommandText = "INSERT dbo.table_SLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
                                            " VALUES ('s', 's', 's', '" +
                                             DataGridView_Table_SRM_Set.SelectedCells.Item(0).Value + "', '" +
                                             DataGridView_Table_SRM_Set.SelectedCells.Item(1).Value.ToString + "', '" +
                                             DataGridView_Table_SRM.SelectedCells.Item(0).Value.ToString + "', '" +
                                             MaskedTextBox_SLI_Irradiation_Log.Text + "')"

                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    cmd.ExecuteNonQuery()
                    sqlConnection1.Close()

                    DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i + 1).Value = MaskedTextBox_SLI_Irradiation_Log.Text
                    If i = 10 Then
                        DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(12).Value = True
                    End If

                    Me.Validate()
                    Me.Table_SRM_BindingSource.EndEdit()
                    Me.Table_SRM_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SRM)

                    'Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                    'Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
                    'Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                    'Me.Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM) ' запрос, который никгда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

                    B_Save_And_Update_SLI_Click(sender, e)
                    Exit Sub
                End If
                'If Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.CurrentCell.RowIndex).Cells.Item(i + 1).Value <> "" Then
                '    Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.CurrentCell.RowIndex).Cells.Item(i + 1).Value = MaskedTextBox_SLI_Irradiation_Log.Text
                '    If i = 10 Then
                '        Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.CurrentCell.RowIndex).Cells.Item(12).Value = False
                '    End If
                '    Exit Sub
                'End If
            Next

            '  cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_SLI_Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text +
            '"' WHERE Monitor_Set_Name='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value +
            '"' and Monitor_Set_Number='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString +
            '"' and Monitor_Number='" + DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "'"

            '  cmd.Connection = sqlConnection1
            '  sqlConnection1.Open()
            '  cmd.ExecuteNonQuery()
            '  sqlConnection1.Close()

            '  cmd.CommandText = "INSERT dbo.table_SLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
            '      " VALUES ('m', 'm', 'm', '" +
            '       DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value + "', '" +
            '       DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString + "', '" +
            '       DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "', '" +
            '       MaskedTextBox_SLI_Irradiation_Log.Text + "')"

            '  cmd.Connection = sqlConnection1
            '  sqlConnection1.Open()
            '  cmd.ExecuteNonQuery()
            '  sqlConnection1.Close()

            '  Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            '  Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            '  Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            '  Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)
            '  Form_SLI_Irradiation_Log_Load(sender, e)

            ''Dim Max_Position_Number As Integer
            ''Max_Position_Number = 0
            'Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            ''Dim reader As SqlDataReader
            'Dim cmd As New System.Data.SqlClient.SqlCommand
            'cmd.CommandType = System.Data.CommandType.Text

            ''cmd.CommandText = "SELECT MAX(I_SLI_Position_Number) FROM dbo.table_Sample WHERE I_SLI_Date='" +
            ''    MaskedTextBox_SLI_Irradiation_Log.Text + "'"
            ''cmd.Connection = sqlConnection1
            ''sqlConnection1.Open()
            ''reader = cmd.ExecuteReader()

            ''While reader.Read()
            ''    If Not IsDBNull(reader(0)) Then Max_Position_Number = reader(0)
            ''End While
            ''sqlConnection1.Close()

            'cmd.CommandText = "UPDATE dbo.table_Sample SET I_SLI_Date='" + MaskedTextBox_SLI_Irradiation_Log.Text +
            '     "' WHERE F_Country_Code='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(0).Value +
            '     "' and F_Client_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(1).Value +
            '     "' and F_Year='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(2).Value +
            '     "' and F_Sample_Set_ID='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(3).Value +
            '     "' and F_Sample_Set_Index='" + DataGridView_SLI_Sample_Set.SelectedCells.Item(4).Value +
            '     "' and A_Sample_ID='" + ListBox_Sample_ID.Text + "'"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'cmd.ExecuteNonQuery()
            'sqlConnection1.Close()

            'table_Sample_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'table_Sample_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_Sample_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            'Form_SLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Delete_Last_Irradiation_Date_From_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Delete_Last_Irradiation_Date_From_Log.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_SLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value <> "s" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            For i = 10 To 1 Step -1
                'If IsDBNull(DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i).Value) = False Then
                '    'DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(12).Value = False
                '    DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i).Value = DBNull.Value

                '    Me.Validate()
                '    Me.Table_SRM_BindingSource.EndEdit()
                '    Me.Table_SRM_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SRM)

                cmd.CommandText = "SELECT SRM_SLI_Irradiation_Date_" + i.ToString + " FROM dbo.table_SRM" +
                     " WHERE SRM_Set_Name='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
                     "' and SRM_Set_Number='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                     "' and SRM_Number='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        sqlConnection1.Close()
                        cmd.CommandText = "UPDATE dbo.table_SRM SET SRM_SLI_Irradiation_Date_" + i.ToString + "=NULL" +
                                          " WHERE SRM_Set_Name='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
                                          "' and SRM_Set_Number='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                                          "' and SRM_Number='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString + "'"
                        cmd.Connection = sqlConnection1
                        sqlConnection1.Open()
                        cmd.ExecuteNonQuery()
                        sqlConnection1.Close()
                        GoTo a
                    End If

                End While
                sqlConnection1.Close()
            Next

a:          cmd.CommandText = "DELETE FROM dbo.table_SLI_Irradiation_Log " +
                 " WHERE Country_Code='s' and Client_ID='s' and Year='s" +
                 "' and Sample_Set_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
                 "' and Sample_Set_Index='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                 "' and Sample_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString +
                 "' and Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            'Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Me.Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM) ' запрос, который никгда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_Table_Monitor_Set_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Table_Monitor_Set.CellMouseUp
        Try
            If DataGridView_Table_Monitor_Set.SelectedRows.Count = 0 Then Exit Sub
            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM". При необходимости она может быть перемещена или удалена.
            Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Monitor_TableAdapter.Fill_In_Use_Date_SLI(Me.NAA_DB_EXPDataSet.table_Monitor, DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value, DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value, MaskedTextBox_SLI_Irradiation_Log.Text)

            If DataGridView_Table_Monitor.RowCount > 0 Then
                DataGridView_Table_Monitor.FirstDisplayedScrollingRowIndex = DataGridView_Table_Monitor.RowCount - 1
                For i = 0 To DataGridView_Table_Monitor.RowCount - 1
                    DataGridView_Table_Monitor.Rows.Item(i).Selected = False
                Next
                'Table_Monitor_DataGridView.Rows.Item(Table_Monitor_DataGridView.RowCount - 1).Selected = True
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Add_Monitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Add_Monitor.Click
        '        Update(table_Monitor)
        'SET              Monitor_Set_Weight = @Monitor_Set_Weight, Monitor_SLI_Weight = @Monitor_SLI_Weight, Monitor_LLI_Weight = @Monitor_LLI_Weight, 
        '                      Monitor_SLI_Date_Start = @Monitor_SLI_Date_Start, Monitor_LLI_Date_Start = @Monitor_LLI_Date_Start, 
        '                      Monitor_LLI_Not_In_Use = @Monitor_LLI_Not_In_Use, Monitor_SLI_Not_In_Use = @Monitor_SLI_Not_In_Use
        'WHERE     (Monitor_Set_Name = @Monitor_Set_Name) AND (Monitor_Set_Number = @Monitor_Set_Number) AND (Monitor_Number = @Monitor_Number)
        Try
            If DataGridView_Table_Monitor_Set.SelectedCells.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите партию мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select monitor set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If DataGridView_Table_Monitor.SelectedCells.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_SLI_Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text +
                 "' WHERE Monitor_Set_Name='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value +
                 "' and Monitor_Set_Number='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString +
                 "' and Monitor_Number='" + DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "INSERT dbo.table_SLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
                " VALUES ('m', 'm', 'm', '" +
                 DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value + "', '" +
                 DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString + "', '" +
                 DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "', '" +
                 MaskedTextBox_SLI_Irradiation_Log.Text + "')"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            'Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)

            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Delete_Monitor_From_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Delete_Monitor_From_Log.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_SLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value <> "m" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "DELETE FROM dbo.table_SLI_Irradiation_Log " +
                 " WHERE Country_Code='m' and Client_ID='m' and Year='m" +
                 "' and Sample_Set_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
                 "' and Sample_Set_Index='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                 "' and Sample_ID='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString +
                 "' and Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_SLI_Date_Start=NULL" +
                 " WHERE Monitor_Set_Name='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(3).Value +
                 "' and Monitor_Set_Number='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                 "' and Monitor_Number='" + DataGridView_SLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            'Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)

            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Set_Monitor_As_Not_In_Use_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Set_Monitor_As_Not_In_Use.Click
        Try
            If DataGridView_Table_Monitor_Set.SelectedRows.Count = 0 Or DataGridView_Table_Monitor_Set.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите одну партию мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one monitor set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_Table_Monitor.SelectedRows.Count = 0 Or DataGridView_Table_Monitor.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_SLI_Not_In_Use='True'" +
                 " WHERE Monitor_Set_Name='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value +
                 "' and Monitor_Set_Number='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString +
                 "' and Monitor_Number='" + DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "'"
            ''"' and Monitor_SLI_Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text + "'" 'если добавить это условие, будут помечаться только с проставленной датой облучения, без него - любые
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)

            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Set_SRM_As_Not_In_Use_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Set_SRM_As_Not_In_Use.Click
        Try
            If DataGridView_Table_SRM_Set.SelectedRows.Count = 0 Or DataGridView_Table_SRM_Set.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите одну партию стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one SRM set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_Table_SRM.SelectedRows.Count = 0 Or DataGridView_Table_SRM.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE dbo.table_SRM SET SRM_SLI_Not_In_Use='True'" +
                 " WHERE SRM_Set_Name='" + DataGridView_Table_SRM_Set.SelectedCells.Item(0).Value +
                 "' and SRM_Set_Number='" + DataGridView_Table_SRM_Set.SelectedCells.Item(1).Value.ToString +
                 "' and SRM_Number='" + DataGridView_Table_SRM.SelectedCells.Item(0).Value.ToString + "'"
            ''"' and SRM_SLI_Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text + "'" 'если добавить это условие, будут помечаться только с проставленной датой облучения, без него - любые
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            Table_SLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_SLI_Irradiation_Log_TableAdapter.Fill_SLI_Irradiation_Log(NAA_DB_EXPDataSet.table_SLI_Irradiation_Log, MaskedTextBox_SLI_Irradiation_Log.Text)
            Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM)

            B_Save_And_Update_SLI_Click(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Find_Sample_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Find_Sample_Set.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_SLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value = "m" Or DataGridView_SLI_Irradiation_Log.SelectedCells.Item(0).Value = "s" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If DataGridView_SLI_Irradiation_Log.RowCount > 0 Then
                'DataGridView_SLI_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_SLI_Sample_Set.RowCount - 1
                For i = 0 To DataGridView_SLI_Sample_Set.RowCount - 1
                    If (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(0).Value = DataGridView_SLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(0).Value) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(1).Value = DataGridView_SLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(1).Value) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(2).Value = DataGridView_SLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(2).Value) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(3).Value = DataGridView_SLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(3).Value) Then
                        DataGridView_SLI_Sample_Set.Rows.Item(i).Selected = True
                        DataGridView_SLI_Sample_Set.FirstDisplayedScrollingRowIndex = i
                        Exit Sub
                    End If

                Next
                'DataGridView_SLI_Sample_Set.Rows.Item(DataGridView_SLI_Sample_Set.RowCount - 1).Selected = True
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_SLI_Irradiation_Log_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_SLI_Irradiation_Log.CellEndEdit
        'Try
        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 0 Then Exit Sub
        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 14 Then 'Первый файл
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value <> "" Then
        '            For i = 0 To DataGridView_SLI_Irradiation_Log.Rows.Count - 1
        '                DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex).Value = DataGridView_SLI_Irradiation_Log.CurrentCell.Value
        '            Next
        '        End If
        '    End If

        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 15 Then 'Последний файл
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value <> "" Then
        '            For i = 0 To DataGridView_SLI_Irradiation_Log.Rows.Count - 1
        '                DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex).Value = DataGridView_SLI_Irradiation_Log.CurrentCell.Value
        '            Next
        '        End If
        '    End If

        '    If DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex = 16 Then 'Номер бумажного журнала
        '        If IsDBNull(DataGridView_SLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            Exit Sub
        '        End If
        '        If DataGridView_SLI_Irradiation_Log.CurrentCell.Value <> "" Then
        '            For i = 0 To DataGridView_SLI_Irradiation_Log.Rows.Count - 1
        '                DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(DataGridView_SLI_Irradiation_Log.CurrentCell.ColumnIndex).Value = DataGridView_SLI_Irradiation_Log.CurrentCell.Value
        '            Next
        '        End If
        '    End If

        '    Me.Validate()
        '    Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
        '    Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        '    Form_SLI_Irradiation_Log_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox("The operation was cancelled!")
        'End Try
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim s_var As String
    '        If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
    '            MsgBox("Select row(s)!")
    '            Exit Sub
    '        End If
    '        If TextBox_Duration.Text = "" Then
    '            MsgBox("Type duration!")
    '            Exit Sub
    '        End If
    '        For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
    '            'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
    '            If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(9).Value = TextBox_Duration.Text
    '        Next

    '        Me.Validate()
    '        Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
    '        Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)

    '        s_var = ComboBox_Sample_Set_View.Text
    '        Form_SLI_Irradiation_Log_Load(sender, e)
    '        ComboBox_Sample_Set_View.Text = s_var
    '        ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)
    '    Catch ex As Exception
    '        If Form_Main.language = "Русский" Then
    '            MsgBox("Операция была отменена (ошибка в B_Find_Sample_Set_Click)!", MsgBoxStyle.Critical, Me.Text)
    '        ElseIf Form_Main.language = "English" Then
    '            MsgBox("Operation was cancelled (error in B_Find_Sample_Set_Click)!", MsgBoxStyle.Critical, Me.Text)
    '        End If
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub B_Fill_In_Channel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Channel.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Channel.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите канал облучения!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select irradiation channel!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(8).Value = ComboBox_Channel.Text
            Next
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Duration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Duration.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_Duration.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите длительность облучения", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type duration of irradiation!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(9).Value = TextBox_Duration.Text
            Next

            Me.Validate()
            Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Save_And_Update_SLI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save_And_Update_SLI.Click
        Try
            Dim s_var_1, s_var_2, s_var_3, s_var_4 As String

            Me.Validate()
            Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)

            s_var_1 = ComboBox_Sample_Set_View.Text
            s_var_2 = ComboBox_Person.Text ' не менять на .SelectedItem - будут ошибки!
            s_var_3 = ComboBox_SRM_Set_View.Text
            s_var_4 = ComboBox_Monitor_Set_View.Text

            Form_SLI_Irradiation_Log_Load(sender, e)

            ComboBox_Sample_Set_View.Text = s_var_1
            ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            ComboBox_Person.Text = s_var_2

            ComboBox_SRM_Set_View.Text = s_var_3
            ComboBox_SRM_Set_View_SelectionChangeCommitted(sender, e)

            ComboBox_Monitor_Set_View.Text = s_var_4
            ComboBox_Monitor_Set_View_SelectionChangeCommitted(sender, e)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub ComboBox_Sample_Set_View_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Sample_Set_View.SelectionChangeCommitted
        Try
            ListBox_Sample_ID.Items.Clear()
            ListBox_Sample_ID_All_SLI_Weight.Items.Clear()

            If ComboBox_Sample_Set_View.SelectedItem = "All sample sets" Or ComboBox_Sample_Set_View.SelectedItem = "Все партии образцов" Then
                Table_Sample_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_Sample_Set_TableAdapter.Fill_Sample_Set(Me.NAA_DB_EXPDataSet.table_Sample_Set)
                If DataGridView_SLI_Sample_Set.RowCount > 0 Then
                    For i = 0 To DataGridView_SLI_Sample_Set.RowCount - 1
                        DataGridView_SLI_Sample_Set.Rows.Item(i).Visible = True
                    Next

                    DataGridView_SLI_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_SLI_Sample_Set.RowCount - 1
                    For i = 0 To DataGridView_SLI_Sample_Set.RowCount - 1
                        DataGridView_SLI_Sample_Set.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Sample_Set.RowCount - 1).Selected = True
                End If
            End If

            If ComboBox_Sample_Set_View.SelectedItem = "Sample sets from log" Or ComboBox_Sample_Set_View.SelectedItem = "Партии образцов из журнала" Then
                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT DISTINCT Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index FROM dbo.table_SLI_Irradiation_Log" +
                         " WHERE Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text +
                         "' and Country_Code<>'m' and Country_Code<>'s'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()

                Table_Sample_Set_BindingSource.CurrencyManager.SuspendBinding() 'SuspendBinding приостанавливает привязку данных DataGridView к базе данных. Если этого не сделать, то при попытке сделать невидимой текущюю строку grid'а будет ошибка

                For i = 0 To DataGridView_SLI_Sample_Set.RowCount - 1
                    'Table_Sample_Set_BindingSource.DataGridView_SLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_SLI_Irradiation_Log.RowCount - 1
                    DataGridView_SLI_Sample_Set.Rows.Item(i).Visible = False
                Next

                While reader.Read()
                    'Dim myBindingManager As BindingManagerBase = BindingContext(NAA_DB_EXPDataSet, "table_Sample_Set")
                    'myBindingManager.SuspendBinding()

                    'Dim tbl As DataTable = CType(DataGridView_SLI_Sample_Set.DataSource, DataTable)
                    'Dim CurManager As CurrencyManager = CType(DataGridView_SLI_Sample_Set.BindingContext(tbl), CurrencyManager)
                    'CurManager.SuspendBinding()

                    'Table_Sample_Set_BindingSource.Filter = ""

                    If Not IsDBNull(reader(0)) Then
                        For i = 0 To DataGridView_SLI_Sample_Set.RowCount - 1
                            'Table_Sample_Set_BindingSource.DataGridView_SLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_SLI_Irradiation_Log.RowCount - 1
                            If (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(0).Value = reader(0)) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(1).Value = reader(1)) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(2).Value = reader(2)) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(3).Value = reader(3)) And (DataGridView_SLI_Sample_Set.Rows.Item(i).Cells.Item(4).Value = reader(4)) Then
                                DataGridView_SLI_Sample_Set.Rows.Item(i).Visible = True
                            End If
                        Next
                    End If

                    'myBindingManager.ResumeBinding()
                    If DataGridView_SLI_Sample_Set.RowCount > 0 Then
                        'DataGridView_SLI_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_SLI_Sample_Set.RowCount - 1 ' если разкоментить, будет ошибка при установке firstdisplayed для скрытой строки
                        For i = 0 To DataGridView_SLI_Sample_Set.RowCount - 1
                            DataGridView_SLI_Sample_Set.Rows.Item(i).Selected = False
                        Next
                        'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Sample_Set.RowCount - 1).Selected = True
                    End If
                End While
                sqlConnection1.Close()

                Table_Sample_Set_BindingSource.CurrencyManager.ResumeBinding()

                If DataGridView_SLI_Irradiation_Log.RowCount > 0 Then
                    DataGridView_SLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                        DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Sample_Set.RowCount - 1).Selected = True
                End If
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub ComboBox_SRM_Set_View_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_SRM_Set_View.SelectionChangeCommitted
        Try
            'ListBox_SRM_ID.Items.Clear()

            If ComboBox_SRM_Set_View.SelectedItem = "All SRM sets" Or ComboBox_SRM_Set_View.SelectedItem = "Все партии стандартов" Then
                Table_SRM_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_SRM_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_SRM_Set)
                If DataGridView_Table_SRM_Set.RowCount > 0 Then
                    For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                        DataGridView_Table_SRM_Set.Rows.Item(i).Visible = True
                    Next

                    DataGridView_Table_SRM_Set.FirstDisplayedScrollingRowIndex = DataGridView_Table_SRM_Set.RowCount - 1
                    For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                        DataGridView_Table_SRM_Set.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_SRM_Set.RowCount - 1).Selected = True
                End If
            End If

            If ComboBox_SRM_Set_View.SelectedItem = "SRM sets from log" Or ComboBox_SRM_Set_View.SelectedItem = "Партии стандартов из журнала" Then
                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT DISTINCT Sample_Set_ID, Sample_Set_Index FROM dbo.table_SLI_Irradiation_Log" +
                         " WHERE Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text +
                         "' and Country_Code='s'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()

                Table_SRM_Set_BindingSource.CurrencyManager.SuspendBinding() 'SuspendBinding приостанавливает привязку данных DataGridView к базе данных. Если этого не сделать, то при попытке сделать невидимой текущюю строку grid'а будет ошибка

                For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                    'Table_SRM_Set_BindingSource.DataGridView_SLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_SLI_Irradiation_Log.RowCount - 1
                    DataGridView_Table_SRM_Set.Rows.Item(i).Visible = False
                Next

                While reader.Read()
                    'Dim myBindingManager As BindingManagerBase = BindingContext(NAA_DB_EXPDataSet, "table_SRM_Set")
                    'myBindingManager.SuspendBinding()

                    'Dim tbl As DataTable = CType(DataGridView_SLI_SRM_Set.DataSource, DataTable)
                    'Dim CurManager As CurrencyManager = CType(DataGridView_SLI_SRM_Set.BindingContext(tbl), CurrencyManager)
                    'CurManager.SuspendBinding()

                    'Table_SRM_Set_BindingSource.Filter = ""

                    If Not IsDBNull(reader(0)) Then
                        For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                            'Table_SRM_Set_BindingSource.DataGridView_SLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_SLI_Irradiation_Log.RowCount - 1
                            If (DataGridView_Table_SRM_Set.Rows.Item(i).Cells.Item(0).Value = reader(0)) And (DataGridView_Table_SRM_Set.Rows.Item(i).Cells.Item(1).Value = reader(1)) Then
                                DataGridView_Table_SRM_Set.Rows.Item(i).Visible = True
                            End If
                        Next
                    End If

                    'myBindingManager.ResumeBinding()
                    If DataGridView_Table_SRM_Set.RowCount > 0 Then
                        'DataGridView_SLI_SRM_Set.FirstDisplayedScroSLIngRowIndex = DataGridView_SLI_SRM_Set.RowCount - 1 ' если разкоментить, будет ошибка при установке firstdisplayed для скрытой строки
                        For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                            DataGridView_Table_SRM_Set.Rows.Item(i).Selected = False
                        Next
                        'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_SRM_Set.RowCount - 1).Selected = True
                    End If
                End While
                sqlConnection1.Close()

                Table_SRM_Set_BindingSource.CurrencyManager.ResumeBinding()

                If DataGridView_SLI_Irradiation_Log.RowCount > 0 Then
                    DataGridView_SLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                        DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_SRM_Set.RowCount - 1).Selected = True
                End If
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub ComboBox_Monitor_Set_View_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Monitor_Set_View.SelectionChangeCommitted
        Try
            'ListBox_Monitor_ID.Items.Clear()

            If ComboBox_Monitor_Set_View.SelectedItem = "All Monitor sets" Or ComboBox_Monitor_Set_View.SelectedItem = "Все партии мониторов" Then
                Table_Monitor_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_Monitor_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor_Set)
                If DataGridView_Table_Monitor_Set.RowCount > 0 Then
                    For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                        DataGridView_Table_Monitor_Set.Rows.Item(i).Visible = True
                    Next

                    DataGridView_Table_Monitor_Set.FirstDisplayedScrollingRowIndex = DataGridView_Table_Monitor_Set.RowCount - 1
                    For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                        DataGridView_Table_Monitor_Set.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Monitor_Set.RowCount - 1).Selected = True
                End If
            End If

            If ComboBox_Monitor_Set_View.SelectedItem = "Monitor sets from log" Or ComboBox_Monitor_Set_View.SelectedItem = "Партии мониторов из журнала" Then
                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT DISTINCT Sample_Set_ID, Sample_Set_Index FROM dbo.table_SLI_Irradiation_Log" +
                         " WHERE Date_Start='" + MaskedTextBox_SLI_Irradiation_Log.Text +
                         "' and Country_Code='m'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()

                Table_Monitor_Set_BindingSource.CurrencyManager.SuspendBinding() 'SuspendBinding приостанавливает привязку данных DataGridView к базе данных. Если этого не сделать, то при попытке сделать невидимой текущюю строку grid'а будет ошибка

                For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                    'Table_Monitor_Set_BindingSource.DataGridView_SLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_SLI_Irradiation_Log.RowCount - 1
                    DataGridView_Table_Monitor_Set.Rows.Item(i).Visible = False
                Next

                While reader.Read()
                    'Dim myBindingManager As BindingManagerBase = BindingContext(NAA_DB_EXPDataSet, "table_Monitor_Set")
                    'myBindingManager.SuspendBinding()

                    'Dim tbl As DataTable = CType(DataGridView_SLI_Monitor_Set.DataSource, DataTable)
                    'Dim CurManager As CurrencyManager = CType(DataGridView_SLI_Monitor_Set.BindingContext(tbl), CurrencyManager)
                    'CurManager.SuspendBinding()

                    'Table_Monitor_Set_BindingSource.Filter = ""

                    If Not IsDBNull(reader(0)) Then
                        For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                            'Table_Monitor_Set_BindingSource.DataGridView_SLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_SLI_Irradiation_Log.RowCount - 1
                            If (DataGridView_Table_Monitor_Set.Rows.Item(i).Cells.Item(0).Value = reader(0)) And (DataGridView_Table_Monitor_Set.Rows.Item(i).Cells.Item(1).Value = reader(1)) Then
                                DataGridView_Table_Monitor_Set.Rows.Item(i).Visible = True
                            End If
                        Next
                    End If

                    'myBindingManager.ResumeBinding()
                    If DataGridView_Table_Monitor_Set.RowCount > 0 Then
                        'DataGridView_SLI_Monitor_Set.FirstDisplayedScroSLIngRowIndex = DataGridView_SLI_Monitor_Set.RowCount - 1 ' если разкоментить, будет ошибка при установке firstdisplayed для скрытой строки
                        For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                            DataGridView_Table_Monitor_Set.Rows.Item(i).Selected = False
                        Next
                        'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Monitor_Set.RowCount - 1).Selected = True
                    End If
                End While
                sqlConnection1.Close()

                Table_Monitor_Set_BindingSource.CurrencyManager.ResumeBinding()

                If DataGridView_SLI_Irradiation_Log.RowCount > 0 Then
                    DataGridView_SLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                        DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_SLI_Table.Rows.Item(DataGridView_SLI_Monitor_Set.RowCount - 1).Selected = True
                End If
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Auto_Fill_In_Irradiation_Time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Auto_Fill_In_Irradiation_Start_Time.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(7).Value = Format(Now(), "HH:mm:ss")
            Next
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Save_SLI_Log_To_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save_SLI_Log_To_File.Click
        Try
            Dim DI As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\JOURNALS")
            If DI.Exists Then
            Else
                MkDir("C:\GENIE2K\JOURNALS")
            End If
            SaveFileDialog_SLI.InitialDirectory = "C:\GENIE2K\JOURNALS"
            SaveFileDialog_SLI.FileName = "SLI_journals_" + MaskedTextBox_SLI_Irradiation_Log.Text + ".xlsx"
            If SaveFileDialog_SLI.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                '***быстрее, но не сохраняет форматирование ячеек

                Dim dt As New DataTable()

                For Each column As DataGridViewColumn In DataGridView_SLI_Irradiation_Log.Columns
                    dt.Columns.Add(column.HeaderText, column.ValueType)
                Next

                For Each row As DataGridViewRow In DataGridView_SLI_Irradiation_Log.Rows
                    dt.Rows.Add()
                    For Each cell As DataGridViewCell In row.Cells

                        dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value

                    Next
                Next

                Using wb As New ClosedXML.Excel.XLWorkbook()
                    Dim ws = wb.Worksheets.Add(dt, MaskedTextBox_SLI_Irradiation_Log.Text)


                    ws.Columns("A:S").Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                    ws.Columns("A:S").AdjustToContents()
                    wb.SaveAs(SaveFileDialog_SLI.FileName)
                End Using

                '***быстрее, но не сохраняет форматирование ячеек

            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Function column_letters(ByVal column_number_p As Integer) As String
        column_letters = ""
        Try
            ' Col_Letters = номер колонки
            If column_number_p > 26 Then
                column_letters = Chr(64 + Int((column_number_p - 1) / 26)) & Chr(65 + ((column_number_p - 1) Mod 26))
            Else
                column_letters = Chr(64 + column_number_p)
            End If
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Function
        End Try
    End Function

    Private Sub B_Fill_In_Spectrum_File_Click(sender As System.Object, e As System.EventArgs) Handles B_Fill_In_Spectrum_File.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_Spectrum_File.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите имя файла спектра!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type spectrum file!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(10).Value = TextBox_Spectrum_File.Text
            Next

            Me.Validate()
            Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Spectrum_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Spectrum_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub ListBox_Sample_ID_All_SLI_Weight_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles ListBox_Sample_ID_All_SLI_Weight.SelectedValueChanged
        Try
            Dim s As String
            s = ListBox_Sample_ID_All_SLI_Weight.SelectedItem
            s = Replace(s, Mid(s, 1, InStr(1, s, " ")), "", 1, 1)
            Clipboard.SetText(s)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Paper_Log_Number_Click(sender As System.Object, e As System.EventArgs) Handles Button_Paper_Log_Number.Click
        Try
            If DataGridView_SLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_Paper_Log_Number.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите номер бумажного журнала", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type paper log number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_SLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_SLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_SLI_Irradiation_Log.Rows.Item(i).Cells.Item(16).Value = TextBox_Paper_Log_Number.Text
            Next

            Me.Validate()
            Me.Table_SLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_SLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SLI_Irradiation_Log)
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub
End Class