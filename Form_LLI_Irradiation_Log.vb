Imports System.Data.SqlClient

Public Class Form_LLI_Irradiation_Log

    Public ContNum As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9}
    Public colorNames As New Dictionary(Of Integer, ClosedXML.Excel.XLColor)

    Private Sub Form_LLI_Irradiation_Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "russian" Then
                ' Form_LLI_Irradiation_Log
                Me.Text = "Журнал облучения ДЖИ"
                L_Name_LLI_Irradiation_Log.Text = "Журнал облучения ДЖИ"
                L_Name_Download.Text = "Загрузка"
                L_Name_Sample_Geometry.Text = "Высота, см"
                Button_Samples_By_Detectors.Text = "Образцы на детекторах"
                Button_Save_LLI_Log_To_File.Text = "Сохранить журнал ДЖИ в файл"

                L_Name_Sample_Set.Text = "Партии образцов"
                L_Name_Sample_Set_View.Text = "Вид партий образцов"
                L_Name_Sample.Text = "Образцы"
                B_Add_Sample.Text = "Добавить образ."
                L_Name_Sample_All_LLI_Weight.Text = "Вес образцов ДЖИ"
                B_Delete_Sample_From_Log.Text = "Удалить образец из журнала"
                L_Name_Date.Text = "Дата"
                L_Name_Date_Field_Name.Text = "Имя поля дата"
                B_Fill_In_Date.Text = "Заполнить дату"
                L_Name_Person.Text = "ФИО"
                B_Fill_In_Person.Text = "Заполнить ФИО"
                L_Name_Channel.Text = "Канал"
                B_Fill_In_Channel.Text = "Заполнить канал"
                L_Name_Container_Number.Text = "Номер контейнера"
                B_Fill_In_Container_Number.Text = "Заполнить контейнер"
                L_Name_Time.Text = "Время"
                L_Name_Time_Field_Name.Text = "Имя поля время"
                B_Fill_In_Time.Text = "Заполнить время"
                L_Name_Person_Field_Name.Text = "Имя поля ФИО"
                L_Name_LLI1_Spectrum_File.Text = "Файл ДЖИ1"
                Button_LLI1_Spectrum_File.Text = "Зап. файл ДЖИ1"
                L_Name_LLI2_Spectrum_File.Text = "Файл ДЖИ2"
                Button_LLI2_Spectrum_File.Text = "Зап. файл ДЖИ2"

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

                B_Save_And_Update_LLI.Text = "Сохранить и обновить журнал ДЖИ"
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

                SaveFileDialog_LLI.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
                ' SaveFileDialog_Sample_By_Detector.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "english" Then
                ' Form_LLI_Irradiation_Log
                Me.Text = "LLI irradiation log"
                L_Name_LLI_Irradiation_Log.Text = "LLI irradiation log"
                L_Name_Download.Text = "Download"
                L_Name_Sample_Geometry.Text = "Height, cm"
                Button_Samples_By_Detectors.Text = "Samples by detectors"
                Button_Save_LLI_Log_To_File.Text = "Save LLI log to file"

                L_Name_Sample_Set.Text = "Sample sets"
                L_Name_Sample_Set_View.Text = "Sample sets view"
                L_Name_Sample.Text = "Samples"
                B_Add_Sample.Text = "Add sample"
                L_Name_Sample_All_LLI_Weight.Text = "Samples's LLI weight"
                B_Delete_Sample_From_Log.Text = "Delete sample from log"
                L_Name_Date.Text = "Date"
                L_Name_Date_Field_Name.Text = "Date field name"
                B_Fill_In_Date.Text = "Fill in date"
                L_Name_Person.Text = "Person"
                B_Fill_In_Person.Text = "Fill in person"
                L_Name_Channel.Text = "Channel"
                B_Fill_In_Channel.Text = "Fill in channel"
                L_Name_Container_Number.Text = "Container number"
                B_Fill_In_Container_Number.Text = "Fill in container"
                L_Name_Time.Text = "Time"
                L_Name_Time_Field_Name.Text = "Time field name"
                B_Fill_In_Time.Text = "Fill in time"
                L_Name_Person_Field_Name.Text = "Person field name"
                L_Name_LLI1_Spectrum_File.Text = "LLI1 file"
                Button_LLI1_Spectrum_File.Text = "Fill in LLI1 file"
                L_Name_LLI2_Spectrum_File.Text = "LLI2 file"
                Button_LLI2_Spectrum_File.Text = "Fill in LLI2 file"

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

                B_Save_And_Update_LLI.Text = "Save and update log LLI"
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

                SaveFileDialog_LLI.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                ' SaveFileDialog_Sample_By_Detector.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            End If

            MaskedTextBox_Date.Text = Format(Now(), "dd.MM.yyyy")
            ComboBox_Date_Field_Name.Text = ""
            ComboBox_Time_Field_Name.Text = ""
            ComboBox_Person_Field_Name.Text = ""

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Received_By". При необходимости она может быть перемещена или удалена.
            Table_Received_By_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Received_By_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Received_By)

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Sample_LLI_Irradiation_Log". При необходимости она может быть перемещена или удалена.
            Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text, Convert.ToInt32(TextBox_Download.Text))
            ListBox_Sample_ID.Items.Clear()
            ListBox_Sample_ID_All_LLI_Weight.Items.Clear()

            Dim g As Graphics = DataGridView_LLI_Irradiation_Log.CreateGraphics()
            Dim offset As Integer = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("  ", DataGridView_LLI_Irradiation_Log.ColumnHeadersDefaultCellStyle.Font).Width))

            With DataGridView_LLI_Irradiation_Log
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "russian" Then
                    .Columns.Add("Country_Code", "Код страны")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Country_Code", "Country code")
                End If
                .Columns(0).DataPropertyName = "Country_Code" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                .Columns(0).Frozen = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Country", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Client_ID", "Клиентский №")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Client_ID", "Client ID")
                End If
                .Columns(1).DataPropertyName = "Client_ID"
                .Columns(1).ReadOnly = True
                .Columns(1).Frozen = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Клиентский", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Year", "Год")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Year", "Year")
                End If
                .Columns(2).DataPropertyName = "Year"
                .Columns(2).ReadOnly = True
                .Columns(2).Frozen = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Year", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Sample_Set_ID", "№ партии образцов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Sample_Set_ID", "Sample set ID")
                End If
                .Columns(3).DataPropertyName = "Sample_Set_ID"
                .Columns(3).ReadOnly = True
                .Columns(3).Frozen = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Sample_Set_Index", "Индекс партии образцов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Sample_Set_Index", "Sample set index")
                End If
                .Columns(4).DataPropertyName = "Sample_Set_Index"
                .Columns(4).ReadOnly = True
                .Columns(4).Frozen = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Sample_ID", "Номер образца")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Sample_ID", "Sample ID")
                End If
                .Columns(5).DataPropertyName = "Sample_ID"
                .Columns(5).ReadOnly = True
                .Columns(5).Frozen = True
                .Columns(5).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образца", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Date_Start", "Дата начала облучения")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Date_Start", "Date_Start")
                End If
                .Columns(6).DataPropertyName = "Date_Start"
                .Columns(6).ReadOnly = True
                .Columns(6).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Time_Start", "Время начала облучения")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Time_Start", "Start time")
                End If
                .Columns(7).DataPropertyName = "Time_Start"
                .Columns(7).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("облучения", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset 'этот столб считаем, как и предыдущий, по Irradiation

                If Form_Main.language = "russian" Then
                    .Columns.Add("Channel", "Канал")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Channel", "Channel")
                End If
                .Columns(8).DataPropertyName = "Channel"
                .Columns(8).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Channel", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Date_Finish", "Дата окончания облучения")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Date_Finish", "Finish date")
                End If
                .Columns(9).DataPropertyName = "Date_Finish"
                .Columns(9).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Time_Finish", "Время окончания облучения")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Time_Finish", "Finish time")
                End If
                .Columns(10).DataPropertyName = "Time_Finish"
                .Columns(10).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(11).HeaderText = "Relief 1 start date"
                '.Columns(11).Visible = False

                '.Columns(12).HeaderText = "Relief 1 start time"
                '.Columns(12).Visible = False

                '.Columns(13).HeaderText = "Relief 1 finish date"
                '.Columns(13).Visible = False

                '.Columns(14).HeaderText = "Relief 1 finish time"
                '.Columns(14).Visible = False

                '.Columns(15).HeaderText = "Relief 2 start date"
                '.Columns(15).Visible = False

                '.Columns(16).HeaderText = "Relief 2 start time"
                '.Columns(16).Visible = False

                '.Columns(17).HeaderText = "Relief 2 finish date"
                '.Columns(17).Visible = False

                '.Columns(18).HeaderText = "Relief 2 finish time"
                '.Columns(18).Visible = False

                If Form_Main.language = "russian" Then
                    .Columns.Add("Container_Number", "Номер контейнера")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Container_Number", "Container number")
                End If
                .Columns(11).DataPropertyName = "Container_Number" ' это бывший столб № 19
                .Columns(11).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("контейнера", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Position_Number", "Номер позиции")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Position_Number", "Position number")
                End If
                .Columns(12).DataPropertyName = "Position_Number" ' это бывший столб № 20
                .Columns(12).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Position", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Irradiated_By", "Облучён")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Irradiated_By", "Irradiated by")
                End If
                .Columns(13).DataPropertyName = "Irradiated_By" ' это бывший столб № 21
                .Columns(13).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Alekseenok Yu.V.", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(22).HeaderText = "Rehandle date"
                '.Columns(22).Visible = False

                If Form_Main.language = "russian" Then
                    .Columns.Add("Rehandled_By", "Перепаковано")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Rehandled_By", "Rehandled by")
                End If
                .Columns(14).DataPropertyName = "Rehandled_By" ' это бывший столб № 23
                .Columns(14).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Alekseenok Yu.V.", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Date_Measurement_LLI_1", "Дата измерения ДЖИ1")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Date_Measurement_LLI_1", "Date measurement LLI1")
                End If
                .Columns(15).DataPropertyName = "Date_Measurement_LLI_1" ' это бывший столб № 24
                .Columns(15).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("measurement", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(25).HeaderText = "Detector № LLI1"
                '.Columns(25).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Detector", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                '.Columns(25).Visible = False

                '.Columns(26).HeaderText = "Detector 5 LLI1"
                '.Columns(26).Visible = False

                '.Columns(27).HeaderText = "Detector 6 LLI1"
                '.Columns(27).Visible = False

                '.Columns(28).HeaderText = "Detector 7 LLI1"
                '.Columns(28).Visible = False

                '.Columns(29).HeaderText = "Paper log LLI1 number"
                '.Columns(29).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("number", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                '.Columns(29).Visible = False

                If Form_Main.language = "russian" Then
                    .Columns.Add("Measured_LLI_1_By", "Файл спектра ДЖИ1")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Measured_LLI_1_By", "LLI1 spectrum file")
                End If
                .Columns(16).DataPropertyName = "Measured_LLI_1_By" 'ОТКРЫТ, это бывший столб "Measured LLI1 by" и бывший столб № 30
                .Columns(16).Visible = True

                If Form_Main.language = "russian" Then
                    .Columns.Add("Date_Measurement_LLI_2", "Дата измерения ДЖИ2")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Date_Measurement_LLI_2", "Date measurement LLI2")
                End If
                .Columns(17).DataPropertyName = "Date_Measurement_LLI_2" ' это бывший столб № 31
                .Columns(17).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("measurement", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(32).HeaderText = "Detector № LLI2"
                '.Columns(32).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Detector", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                '.Columns(32).Visible = False

                '.Columns(33).HeaderText = "Detector 5 LLI2"
                '.Columns(33).Visible = False

                '.Columns(34).HeaderText = "Detector 6 LLI2"
                '.Columns(34).Visible = False

                '.Columns(35).HeaderText = "Detector 7 LLI2"
                '.Columns(35).Visible = False

                '.Columns(36).HeaderText = "Paper log LLI2 number"
                '.Columns(36).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("number", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
                '.Columns(36).Visible = False

                If Form_Main.language = "russian" Then
                    .Columns.Add("Measured_LLI_2_By", "Файл спектра ДЖИ2")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Measured_LLI_2_By", "LLI2 spectrum file")
                End If
                .Columns(18).DataPropertyName = "Measured_LLI_2_By" 'ОТКРЫТ, это бывший столб "Measured LLI2 by" и бывший столб № 37
                .Columns(18).Visible = True
            End With

            'DataGridView_LLI_Irradiation_Log.AutoResizeColumns() 'комментарий не убирать, иначе ширина столбцов будет неправильная

            If DataGridView_LLI_Irradiation_Log.RowCount > 0 Then
                DataGridView_LLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                    DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = False
                    If Not IsDBNull(DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value) Then
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 1 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightBlue
                            Next
                        End If
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 2 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightSalmon
                            Next
                        End If
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 3 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightGreen
                            Next
                        End If
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 4 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightPink
                            Next
                        End If
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 5 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightGray
                            Next
                        End If
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 6 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightYellow
                            Next
                        End If
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = 7 Then
                            For j = 0 To DataGridView_LLI_Irradiation_Log.Columns.Count - 1
                                DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightCyan
                            Next
                        End If
                    End If
                Next
                'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Sample_Set.RowCount - 1).Selected = True
            End If

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_ExpDataSet.table_Sample". При необходимости она может быть перемещена или удалена.
            Table_Sample_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Sample_Set_TableAdapter.Fill_Sample_Set(Me.NAA_DB_EXPDataSet.table_Sample_Set)

            With DataGridView_LLI_Sample_Set
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "russian" Then
                    .Columns.Add("Country_Code", "Код страны")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Country_Code", "Country code")
                End If
                .Columns(0).DataPropertyName = "Country_Code" ' задаём соответсвие между столбцом таблицы datagridview и столбцом базы данных
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Country", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Client_ID", "Клиентский №")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Client_ID", "Client ID")
                End If
                .Columns(1).DataPropertyName = "Client_ID"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Клиентский", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Year", "Год")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Year", "Year")
                End If
                .Columns(2).DataPropertyName = "Year"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Year", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Sample_Set_ID", "№ партии образцов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Sample_Set_ID", "Sample set ID")
                End If
                .Columns(3).DataPropertyName = "Sample_Set_ID"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("образцов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Sample_Set_Index", "Индекс партии образцов")
                ElseIf Form_Main.language = "english" Then
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

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM_Set". При необходимости она может быть перемещена или удалена.
            Table_SRM_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_SRM_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_SRM_Set)

            With DataGridView_Table_SRM_Set
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Name", "Имя партии стандартов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Set_Name", "SRM set name")
                End If
                .Columns(0).DataPropertyName = "SRM_Set_Name"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандартов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Number", "№ партии стандартов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Set_Number", "SRM set number")
                End If
                .Columns(1).DataPropertyName = "SRM_Set_Number"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандартов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Type", "Тип партии стандартов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Set_Type", "SRM set type")
                End If
                .Columns(2).DataPropertyName = "SRM_Set_Type"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандартов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Weight", "Вес партии, гр")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Set_Weight", "Set weight, g")
                End If
                .Columns(3).DataPropertyName = "SRM_Set_Weight"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Weight,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Set_Purchasing_Date", "Дата покупки")
                ElseIf Form_Main.language = "english" Then
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

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_Number", "№ стандарта")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_Number", "SRM number")
                End If
                .Columns(0).DataPropertyName = "SRM_Number"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("стандарта", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Weight", "Вес, гр")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Weight", "Weight, g")
                End If
                .Columns(1).DataPropertyName = "SRM_LLI_Weight"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Weight,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_1", "Дата облучения 1")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_1", "Irradiation date 1")
                End If
                .Columns(2).DataPropertyName = "SRM_LLI_Irradiation_Date_1"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_2", "Дата облучения 2")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_2", "Irradiation date 2")
                End If
                .Columns(3).DataPropertyName = "SRM_LLI_Irradiation_Date_2"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_3", "Дата облучения 3")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_3", "Irradiation date 3")
                End If
                .Columns(4).DataPropertyName = "SRM_LLI_Irradiation_Date_3"
                .Columns(4).ReadOnly = True
                .Columns(4).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_4", "Дата облучения 4")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_4", "Irradiation date 4")
                End If
                .Columns(5).DataPropertyName = "SRM_LLI_Irradiation_Date_4"
                .Columns(5).ReadOnly = True
                .Columns(5).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_5", "Дата облучения 5")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_5", "Irradiation date 5")
                End If
                .Columns(6).DataPropertyName = "SRM_LLI_Irradiation_Date_5"
                .Columns(6).ReadOnly = True
                .Columns(6).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_6", "Дата облучения 6")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_6", "Irradiation date 6")
                End If
                .Columns(7).DataPropertyName = "SRM_LLI_Irradiation_Date_6"
                .Columns(7).ReadOnly = True
                .Columns(7).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_7", "Дата облучения 7")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_7", "Irradiation date 7")
                End If
                .Columns(8).DataPropertyName = "SRM_LLI_Irradiation_Date_7"
                .Columns(8).ReadOnly = True
                .Columns(8).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_8", "Дата облучения 8")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_8", "Irradiation date 8")
                End If
                .Columns(9).DataPropertyName = "SRM_LLI_Irradiation_Date_8"
                .Columns(9).ReadOnly = True
                .Columns(9).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_9", "Дата облучения 9")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_9", "Irradiation date 9")
                End If
                .Columns(10).DataPropertyName = "SRM_LLI_Irradiation_Date_9"
                .Columns(10).ReadOnly = True
                .Columns(10).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_10", "Дата облучения 10")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Irradiation_Date_10", "Irradiation date 10")
                End If
                .Columns(11).DataPropertyName = "SRM_LLI_Irradiation_Date_10"
                .Columns(11).ReadOnly = True
                .Columns(11).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("SRM_LLI_Not_In_Use", "Не используется")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("SRM_LLI_Not_In_Use", "Not in use")
                End If
                .Columns(12).DataPropertyName = "SRM_LLI_Not_In_Use"
                .Columns(12).ReadOnly = True
                .Columns(12).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("используется", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM) ' запрос, который никогда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

                'If Table_SRM_DataGridView.RowCount > 1 Then
                '    Table_SRM_DataGridView.Rows.Clear()
                '    Table_SRM_DataGridView.FirstDisplayedScrollingRowIndex = Table_SRM_DataGridView.RowCount - 1
                '    For i = 0 To Table_SRM_DataGridView.RowCount - 1
                '        Table_SRM_DataGridView.Rows.Item(i).Selected = False
                '    Next
                'End If
            End With

            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_Monitor_Set". При необходимости она может быть перемещена или удалена.
            Table_Monitor_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Monitor_Set_TableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Monitor_Set)

            With DataGridView_Table_Monitor_Set
                .Columns.Clear()
                .RowHeadersWidth = 21

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_Set_Name", "Имя партии мониторов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_Set_Name", "Monitor set name")
                End If
                .Columns(0).DataPropertyName = "Monitor_Set_Name"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("мониторов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_Set_Number", "№ партии мониторов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_Set_Number", "Monitor set number")
                End If
                .Columns(1).DataPropertyName = "Monitor_Set_Number"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("мониторов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_Set_Type", "Тип партии мониторов")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_Set_Type", "Monitor set type")
                End If
                .Columns(2).DataPropertyName = "Monitor_Set_Type"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("мониторов", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_Set_Weight", "Вес партии, гр")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_Set_Weight", "Set weight, g")
                End If
                .Columns(3).DataPropertyName = "Monitor_Set_Weight"
                .Columns(3).ReadOnly = True
                .Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("партии", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_Set_Purchasing_Date", "Дата покупки")
                ElseIf Form_Main.language = "english" Then
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
                '.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
                .RowHeadersWidth = 21

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_Number", "№ монитора")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_Number", "Monitor number")
                End If
                .Columns(0).DataPropertyName = "Monitor_Number"
                .Columns(0).ReadOnly = True
                .Columns(0).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("монитора", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_LLI_Weight", "Вес, гр")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_LLI_Weight", "Weight, g")
                End If
                .Columns(1).DataPropertyName = "Monitor_LLI_Weight"
                .Columns(1).ReadOnly = True
                .Columns(1).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Weight,", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                If Form_Main.language = "russian" Then
                    .Columns.Add("Monitor_LLI_Date_Start", "Дата облучения")
                ElseIf Form_Main.language = "english" Then
                    .Columns.Add("Monitor_LLI_Date_Start", "Irradiation date")
                End If
                .Columns(2).DataPropertyName = "Monitor_LLI_Date_Start"
                .Columns(2).ReadOnly = True
                .Columns(2).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Irradiation", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset

                '.Columns(3).HeaderText = "Not in use"
                '.Columns(3).ReadOnly = False
                '.Columns(3).Width = Convert.ToInt32(System.Math.Ceiling(g.MeasureString("Not", .ColumnHeadersDefaultCellStyle.Font).Width)) + offset + offset
            End With

            Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor) ' запрос, который никгда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

            ComboBox_Sample_Set_View_SelectionChangeCommitted(sender, e)

            L_Monitor.Text = "M"

            ' это чтобы по умолчанию была высота 2,5
            ComboBox_Sample_Geometry.SelectedIndex = 0
        Catch ex As Exception
            Form_Main.LangException(Form_Main.language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub ComboBox_Sample_Set_View_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Sample_Set_View.SelectionChangeCommitted
        Try
            ListBox_Sample_ID.Items.Clear()
            ListBox_Sample_ID_All_LLI_Weight.Items.Clear()

            If ComboBox_Sample_Set_View.SelectedItem = "All sample sets" Or ComboBox_Sample_Set_View.SelectedItem = "Все партии образцов" Then
                Table_Sample_Set_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                Me.Table_Sample_Set_TableAdapter.Fill_Sample_Set(Me.NAA_DB_EXPDataSet.table_Sample_Set)
                If DataGridView_LLI_Sample_Set.RowCount > 0 Then
                    For i = 0 To DataGridView_LLI_Sample_Set.RowCount - 1
                        DataGridView_LLI_Sample_Set.Rows.Item(i).Visible = True
                    Next

                    DataGridView_LLI_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_LLI_Sample_Set.RowCount - 1
                    For i = 0 To DataGridView_LLI_Sample_Set.RowCount - 1
                        DataGridView_LLI_Sample_Set.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Sample_Set.RowCount - 1).Selected = True
                End If
            End If

            If ComboBox_Sample_Set_View.SelectedItem = "Sample sets from log" Or ComboBox_Sample_Set_View.SelectedItem = "Партии образцов из журнала" Then

                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT DISTINCT Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index FROM dbo.table_LLI_Irradiation_Log" +
                         " WHERE Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text +
                         "'  and Country_Code<>'m' and Country_Code<>'s' and loadNumber = '" + TextBox_Download.Text + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()

                Table_Sample_Set_BindingSource.CurrencyManager.SuspendBinding() 'SuspendBinding приостанавливает привязку данных DataGridView к базе данных. Если этого не сделать, то при попытке сделать невидимой текущюю строку grid'а будет ошибка

                For i = 0 To DataGridView_LLI_Sample_Set.RowCount - 1
                    'Table_Sample_Set_BindingSource.DataGridView_LLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_LLI_Irradiation_Log.RowCount - 1
                    DataGridView_LLI_Sample_Set.Rows.Item(i).Visible = False

                Next

                While reader.Read()
                    'Dim myBindingManager As BindingManagerBase = BindingContext(NAA_DB_EXPDataSet, "table_Sample_Set")
                    'myBindingManager.SuspendBinding()

                    'Dim tbl As DataTable = CType(DataGridView_LLI_Sample_Set.DataSource, DataTable)
                    'Dim CurManager As CurrencyManager = CType(DataGridView_LLI_Sample_Set.BindingContext(tbl), CurrencyManager)
                    'CurManager.SuspendBinding()

                    'Table_Sample_Set_BindingSource.Filter = ""

                    If Not IsDBNull(reader(0)) Then
                        For i = 0 To DataGridView_LLI_Sample_Set.RowCount - 1
                            'Table_Sample_Set_BindingSource.DataGridView_LLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_LLI_Irradiation_Log.RowCount - 1
                            If (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(0).Value = reader(0)) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(1).Value = reader(1)) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(2).Value = reader(2)) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(3).Value = reader(3)) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(4).Value = reader(4)) Then
                                DataGridView_LLI_Sample_Set.Rows.Item(i).Visible = True
                            End If
                        Next
                    End If

                    'myBindingManager.ResumeBinding()
                    If DataGridView_LLI_Sample_Set.RowCount > 0 Then
                        'DataGridView_LLI_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_LLI_Sample_Set.RowCount - 1 ' если разкоментить, будет ошибка при установке firstdisplayed для скрытой строки
                        For i = 0 To DataGridView_LLI_Sample_Set.RowCount - 1
                            DataGridView_LLI_Sample_Set.Rows.Item(i).Selected = False
                        Next
                        'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Sample_Set.RowCount - 1).Selected = True
                    End If
                End While
                sqlConnection1.Close()

                Table_Sample_Set_BindingSource.CurrencyManager.ResumeBinding()

                If DataGridView_LLI_Irradiation_Log.RowCount > 0 Then
                    DataGridView_LLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                        DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Sample_Set.RowCount - 1).Selected = True
                End If
            End If

            If TextBox_Download.Text = "" Then

                Dim sqlConnection2 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader1 As SqlDataReader
                Dim cmd1 As New System.Data.SqlClient.SqlCommand
                cmd1.CommandType = System.Data.CommandType.Text
                cmd1.CommandText = "SELECT distinct loadNumber from table_LLI_Irradiation_Log where Date_Start = '" & MaskedTextBox_LLI_Irradiation_Log.Text & "' order by loadNumber desc"

                cmd1.Connection = sqlConnection2
                sqlConnection2.Open()
                reader1 = cmd1.ExecuteReader()

                While reader1.Read()
                    If Not IsDBNull(reader1(0)) Then
                        TextBox_Download.Text = reader1(0)
                    Else
                        TextBox_Download.Text = ""
                    End If
                End While
                sqlConnection2.Close()
            End If

        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_Sample_Set_View_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in ComboBox_Sample_Set_View_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public loadNumFlag As Boolean

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Try
            Dim response As MsgBoxResult
            If Form_Main.language = "russian" Then
                response = MsgBox("Вы уверены? Все необходимые данные сохранены?", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, Me.Text)
                If response = MsgBoxResult.Ok Then
                    Me.Close()
                    Exit Sub
                ElseIf response = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            ElseIf Form_Main.language = "english" Then
                response = MsgBox("Are you sure? Is all necessary data stored?", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, Me.Text)
                If response = MsgBoxResult.Ok Then
                    Me.Close()
                    Exit Sub
                ElseIf response = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_LLI_Irradiation_Log_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Main.ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)
            'Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            'Dim cmd As New System.Data.SqlClient.SqlCommand
            'cmd.CommandType = System.Data.CommandType.Text
            'Form_Main.ListBox_LLI_Irradiation_Log_Date.Items.Clear()
            'cmd.CommandText = "SELECT DISTINCT Date_Start FROM table_LLI_Irradiation_Log ORDER BY Date_Start"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'reader = cmd.ExecuteReader()
            'While reader.Read()
            '    If Not IsDBNull(reader(0)) Then Form_Main.ListBox_LLI_Irradiation_Log_Date.Items.Add(Format(reader(0), "dd.MM.yyyy"))
            'End While
            'sqlConnection1.Close()
            'If Form_Main.ListBox_LLI_Irradiation_Log_Date.Items.Count > 0 Then
            '    For i = 0 To Form_Main.ListBox_LLI_Irradiation_Log_Date.Items.Count - 1
            '        Form_Main.ListBox_LLI_Irradiation_Log_Date.SetSelected(i, False)
            '    Next
            '    Form_Main.ListBox_LLI_Irradiation_Log_Date.SetSelected(Form_Main.ListBox_LLI_Irradiation_Log_Date.Items.Count - 1, True)
            'End If


            'we don't need to refresh For_Main
            '   Form_Main.Form_Main_Load(sender, e)
            '  Form_Main.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_LLI_Irradiation_Log_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_LLI_Irradiation_Log_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Add_Sample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Add_Sample.Click
        Try
            If DataGridView_LLI_Sample_Set.SelectedCells.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите партию образцов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select sample set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ListBox_Sample_ID.SelectedItems.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
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

            'cmd.CommandText = "SELECT MAX(I_LLI_Position_Number) FROM dbo.table_Sample WHERE I_LLI_Date='" +
            '    MaskedTextBox_LLI_Irradiation_Log.Text + "'"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'reader = cmd.ExecuteReader()

            'While reader.Read()
            '    If Not IsDBNull(reader(0)) Then Max_Position_Number = reader(0)
            'End While
            'sqlConnection1.Close()

            cmd.CommandText = "INSERT dbo.table_LLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
                " VALUES ('" + DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value + "', '" +
               DataGridView_LLI_Sample_Set.SelectedCells.Item(1).Value + "', '" +
                DataGridView_LLI_Sample_Set.SelectedCells.Item(2).Value + "', '" +
                DataGridView_LLI_Sample_Set.SelectedCells.Item(3).Value + "', '" +
                DataGridView_LLI_Sample_Set.SelectedCells.Item(4).Value + "', '" +
                ListBox_Sample_ID.Text + "', '" + MaskedTextBox_LLI_Irradiation_Log.Text + "')"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "UPDATE dbo.table_Sample SET I_LLI_Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text +
                "' WHERE F_Country_Code='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value +
                "' and F_Client_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(1).Value +
                "' and F_Year='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(2).Value +
                "' and F_Sample_Set_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(3).Value +
                "' and F_Sample_Set_Index='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(4).Value +
                "' and A_Sample_ID='" + ListBox_Sample_ID.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            Save_And_Update_LLI_Click(sender, e)

            'Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Add_Sample_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Add_Sample_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_LLI_Sample_Set_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_LLI_Sample_Set.CellMouseUp
        Try
            If (DataGridView_LLI_Sample_Set.CurrentCellAddress.X = -1) And (DataGridView_LLI_Sample_Set.CurrentCellAddress.Y = -1) Then
                ListBox_Sample_ID.Items.Clear()
                ListBox_Sample_ID_All_LLI_Weight.Items.Clear()
                For i = 0 To DataGridView_LLI_Sample_Set.Rows.Count - 1
                    DataGridView_LLI_Sample_Set.Rows.Item(i).Selected = False
                Next
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If DataGridView_LLI_Sample_Set.SelectedCells.Count = 0 Then Exit Sub 'иначе ошибка
            cmd.CommandText = "SELECT A_Sample_ID FROM dbo.table_Sample WHERE F_Country_Code='" +
                DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value +
                "' and F_Client_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(1).Value +
                "' and F_Year='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(2).Value +
                "' and F_Sample_Set_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(3).Value +
                "' and F_Sample_Set_Index='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(4).Value +
                "' and I_LLI_Date_Start IS NULL"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ListBox_Sample_ID.Items.Clear()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then ListBox_Sample_ID.Items.Add(reader(0))
            End While
            sqlConnection1.Close()

            cmd.CommandText = "SELECT A_Sample_ID, P_Weighting_LLI FROM dbo.table_Sample WHERE F_Country_Code='" +
            DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value +
            "' and F_Client_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(1).Value +
            "' and F_Year='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(2).Value +
            "' and F_Sample_Set_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(3).Value +
            "' and F_Sample_Set_Index='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(4).Value + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ListBox_Sample_ID_All_LLI_Weight.Items.Clear()
            While reader.Read()
                If (Not IsDBNull(reader(0))) And (Not IsDBNull(reader(1))) Then ListBox_Sample_ID_All_LLI_Weight.Items.Add(reader(0) + ", " + reader(1).ToString)
            End While
            sqlConnection1.Close()

            Fill_In_Monitor()
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в DataGridView_LLI_Sample_Set_CellMouseUp!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in DataGridView_LLI_Sample_Set_CellMouseUp!", MsgBoxStyle.Critical, Me.Text)
            End If
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

            cmd.CommandText = "SELECT Country FROM dbo.table_Country WHERE Country_Code='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then L_Monitor.Text = "Country: " + reader(0).ToString + "; "
            End While
            sqlConnection1.Close()

            cmd.CommandText = "SELECT Organization, Last_Name FROM dbo.table_Client WHERE Country_Code='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value + "' and Client_Id='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(1).Value + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If Not IsDBNull(reader(0)) Then L_Monitor.Text = L_Monitor.Text + "Organization: " + reader(0).ToString + "; " + "Last name: " + reader(1).ToString + "."
            End While
            sqlConnection1.Close()
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Fill_In_Monitor!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Fill_In_Monitor!", MsgBoxStyle.Critical, Me.Text)
            End If
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_Table_SRM_Set_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Table_SRM_Set.CellMouseUp
        Try  'это для отображения списка стандартов
            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM". При необходимости она может быть перемещена или удалена.
            Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_SRM_TableAdapter.Fill_In_Use_LLI(Me.NAA_DB_EXPDataSet.table_SRM, DataGridView_Table_SRM_Set.SelectedCells.Item(0).Value, DataGridView_Table_SRM_Set.SelectedCells.Item(1).Value)

            If DataGridView_Table_SRM.RowCount > 0 Then
                DataGridView_Table_SRM.FirstDisplayedScrollingRowIndex = DataGridView_Table_SRM.RowCount - 1
                For i = 0 To DataGridView_Table_SRM.RowCount - 1
                    DataGridView_Table_SRM.Rows.Item(i).Selected = False
                Next
                'Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.RowCount - 1).Selected = True
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в DataGridView_Table_SRM_Set_CellMouseUp!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in DataGridView_Table_SRM_Set_CellMouseUp!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_Table_Monitor_Set_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Table_Monitor_Set.CellMouseUp
        Try 'это для отображения списка мониторов
            'TODO: данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_SRM". При необходимости она может быть перемещена или удалена.
            'Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Me.Table_Monitor_TableAdapter.Fill_In_Use_Date_LLI(Me.NAA_DB_EXPDataSet.table_Monitor, DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value, DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value, MaskedTextBox_LLI_Irradiation_Log.Text)


            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "select Monitor_Number, Monitor_LLI_Weight, Monitor_LLI_Date_Start from table_Monitor where Monitor_Set_Name = '" & DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value & "' and Monitor_Set_Number = '" & DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value & "' and Monitor_Set_Weight = '" & DataGridView_Table_Monitor_Set.SelectedCells.Item(3).Value.ToString.Replace(",", ".") & "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()

            Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
            Dim ds As New DataSet()

            dataadapter.Fill(ds, "SampleInf")
            sqlConnection1.Close()
            DataGridView_Table_Monitor.DataSource = ds
            DataGridView_Table_Monitor.DataMember = "SampleInf"

            DataGridView_Table_Monitor.ClearSelection()
            If DataGridView_Table_Monitor.RowCount > 0 Then
                DataGridView_Table_Monitor.FirstDisplayedScrollingRowIndex = DataGridView_Table_Monitor.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в DataGridView_Table_Monitor_Set_CellMouseUp!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in DataGridView_Table_Monitor_Set_CellMouseUp!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Time_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Time.Text = "  :  :" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите время!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type time!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1

                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(7).Value = MaskedTextBox_Time.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Time_Start_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Time_Start_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Irradiated_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(21).Value = ComboBox_Person.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Irradiated_By_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Irradiated_By_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Measured_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(30).Value = ComboBox_Person.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Measured_By_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Measured_By_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Delete_Sample_From_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Delete_Sample_From_Log.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_LLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value = "m" Or DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value = "s" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            For Each row As DataGridViewRow In DataGridView_LLI_Irradiation_Log.SelectedRows
                DataGridView_LLI_Irradiation_Log.Rows.RemoveAt(row.Index)
            Next


            'Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            ''Dim reader As SqlDataReader
            'Dim cmd As New System.Data.SqlClient.SqlCommand
            'cmd.CommandType = System.Data.CommandType.Text

            'cmd.CommandText = "DELETE FROM dbo.table_LLI_Irradiation_Log" +
            '   " WHERE Country_Code='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value +
            '   "' and Client_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(1).Value +
            '   "' and Year='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(2).Value +
            '   "' and Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
            '   "' and Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value +
            '   "' and Sample_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value +
            '   "' and Date_Start='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(6).Value + "'"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'cmd.ExecuteNonQuery()
            'sqlConnection1.Close()

            'cmd.CommandText = "UPDATE dbo.table_Sample SET I_LLI_Date_Start=NULL" +
            '   " WHERE F_Country_Code='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value +
            '   "' and F_Client_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(1).Value +
            '   "' and F_Year='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(2).Value +
            '   "' and F_Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
            '   "' and F_Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value +
            '   "' and A_Sample_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value +
            '   "' and I_LLI_Date_Start='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(6).Value + "'"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'cmd.ExecuteNonQuery()
            'sqlConnection1.Close()

            Save_And_Update_LLI_Click(sender, e)

            'Me.Validate()
            'Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            'Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            'Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Delete_Sample_From_Log_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Delete_Sample_From_Log_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Rehandled_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(23).Value = ComboBox_Person.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Rehandled_By_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Rehandled_By_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Measured_LLI2_By_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(37).Value = ComboBox_Person.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Measured_LLI2_By_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Measured_LLI2_By_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Time_Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Time.Text = "  :  :" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите время!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type time!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(10).Value = MaskedTextBox_Time.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Time_Finish_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Time_Finish_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Date_Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Date.Text = "  .  ." Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите дату!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type date!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(9).Value = MaskedTextBox_Date.Text
            Next

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
            Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Date_Finish_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Date_Finish_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Date.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Date.Text = "  .  ." Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите дату!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type date!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Date_Field_Name.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите имя поля с датой", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select date field name!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                If ComboBox_Date_Field_Name.Text = "irradiation finish date" Then
                    'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(9).Value = MaskedTextBox_Date.Text
                End If
                'If ComboBox_Date_Field_Name.Text = "power relief start date 1" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = MaskedTextBox_Date.Text
                'End If
                'If ComboBox_Date_Field_Name.Text = "power relief finish date 1" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(13).Value = MaskedTextBox_Date.Text
                'End If
                'If ComboBox_Date_Field_Name.Text = "power relief start date 2" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(15).Value = MaskedTextBox_Date.Text
                'End If
                'If ComboBox_Date_Field_Name.Text = "power relief finish date 2" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(17).Value = MaskedTextBox_Date.Text
                'End If
                'If ComboBox_Date_Field_Name.Text = "rehandle date" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(22).Value = MaskedTextBox_Date.Text
                'End If
                If ComboBox_Date_Field_Name.Text = "measurement LLI1 date" Then
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(15).Value = MaskedTextBox_Date.Text
                End If
                If ComboBox_Date_Field_Name.Text = "measurement LLI2 date" Then
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(17).Value = MaskedTextBox_Date.Text
                End If
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Date_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Date_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Time.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If MaskedTextBox_Time.Text = "  :  :" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите время!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type time!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Time_Field_Name.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите имя поля со временем!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select time field name!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                If ComboBox_Time_Field_Name.Text = "irradiation start time" Then
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(7).Value = MaskedTextBox_Time.Text
                End If
                If ComboBox_Time_Field_Name.Text = "irradiation finish time" Then
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(10).Value = MaskedTextBox_Time.Text
                End If
                'If ComboBox_Time_Field_Name.Text = "power relief start time 1" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(12).Value = MaskedTextBox_Time.Text
                'End If
                'If ComboBox_Time_Field_Name.Text = "power relief finish time 1" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(14).Value = MaskedTextBox_Time.Text
                'End If
                'If ComboBox_Time_Field_Name.Text = "power relief start time 2" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(16).Value = MaskedTextBox_Time.Text
                'End If
                'If ComboBox_Time_Field_Name.Text = "power relief finish time 2" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(18).Value = MaskedTextBox_Time.Text
                'End If
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Time_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Time_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Person_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Person.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select person!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Person_Field_Name.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите имя поля с ФИО!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select person field name!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                If ComboBox_Person_Field_Name.Text = "irradiated by" Then
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(13).Value = ComboBox_Person.Text
                End If
                If ComboBox_Person_Field_Name.Text = "rehandled by" Then
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(14).Value = ComboBox_Person.Text
                End If
                'If ComboBox_Person_Field_Name.Text = "measured LLI1 by" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(30).Value = ComboBox_Person.Text
                'End If
                'If ComboBox_Person_Field_Name.Text = "measured LLI2 by" Then
                '    If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(37).Value = ComboBox_Person.Text
                'End If
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Person_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Person_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_LLI_Irradiation_Log_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Try
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 25 Then 'Детектор 1 LLI1
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then 'событие CellContentClick происходит перед непосредственным изменением значения ячейки: было DBNull станет True
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(26).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(27).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(28).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then 'было False станет True
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(26).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(27).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(28).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 26 Then 'Детектор 2 LLI1
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(25).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(27).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(28).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(25).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(27).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(28).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 27 Then 'Детектор 3 LLI1
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(25).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(26).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(28).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(25).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(26).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(28).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 28 Then 'Детектор 4 LLI1
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(25).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(26).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(27).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(25).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(26).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(27).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If

        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 32 Then 'Детектор 1 LLI2
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then 'событие CellContentClick происходит перед непосредственным изменением значения ячейки: было DBNull станет True
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(33).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(34).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(35).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then 'было False станет True
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(33).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(34).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(35).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 33 Then 'Детектор 2 LLI2
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(32).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(34).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(35).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(32).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(34).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(35).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 34 Then 'Детектор 3 LLI2
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(32).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(33).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(35).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(32).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(33).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(35).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        '    If DataGridView_LLI_Irradiation_Log.CurrentCell.ColumnIndex = 35 Then 'Детектор 4 LLI2
        '        If IsDBNull(DataGridView_LLI_Irradiation_Log.CurrentCell.Value) = True Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(32).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(33).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(34).Value = False

        '            Me.Validate()
        '            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '        If DataGridView_LLI_Irradiation_Log.CurrentCell.Value = False Then
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(32).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(33).Value = False
        '            DataGridView_LLI_Irradiation_Log.Rows.Item(DataGridView_LLI_Irradiation_Log.CurrentCell.RowIndex).Cells.Item(34).Value = False

        '            'Me.Validate()
        '            'Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '            'Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '            'Form_LLI_Irradiation_Log_Load(sender, e)

        '            Exit Sub
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("The operation was cancelled!")
        'End Try
    End Sub

    Private Sub DataGridView_LLI_Irradiation_Log_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_LLI_Irradiation_Log.CellEndEdit, DataGridView_LLI_Irradiation_Log.CellContentClick
        'Try
        '    Me.Validate()
        '    Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
        '    Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)
        '    Form_LLI_Irradiation_Log_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox("The operation was cancelled!")
        'End Try
    End Sub

    Private Sub B_Add_SRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Add_SRM.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If DataGridView_Table_SRM_Set.SelectedCells.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите партию стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select SRM set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_Table_SRM.SelectedCells.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            For i = 1 To 10
                If IsDBNull(DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i + 1).Value) = True Then
                    If i > 1 Then
                        If MaskedTextBox_LLI_Irradiation_Log.Text <= DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i).Value Then
                            i = 11
                            If Form_Main.language = "russian" Then
                                MsgBox("Неправильная дата!", MsgBoxStyle.Exclamation, Me.Text)
                            ElseIf Form_Main.language = "english" Then
                                MsgBox("Incorrect date!", MsgBoxStyle.Exclamation, Me.Text)
                            End If
                            Exit Sub
                        End If
                    End If

                    cmd.CommandText = "INSERT dbo.table_LLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
                         " VALUES ('s', 's', 's', '" +
                          DataGridView_Table_SRM_Set.SelectedCells.Item(0).Value + "', '" +
                          DataGridView_Table_SRM_Set.SelectedCells.Item(1).Value.ToString + "', '" +
                          DataGridView_Table_SRM.SelectedCells.Item(0).Value.ToString + "', '" +
                          MaskedTextBox_LLI_Irradiation_Log.Text + "')"

                    cmd.Connection = sqlConnection1
                    sqlConnection1.Open()
                    cmd.ExecuteNonQuery()
                    sqlConnection1.Close()

                    DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(i + 1).Value = MaskedTextBox_LLI_Irradiation_Log.Text
                    If i = 10 Then
                        DataGridView_Table_SRM.Rows.Item(DataGridView_Table_SRM.CurrentCell.RowIndex).Cells.Item(12).Value = True
                    End If

                    Me.Validate() 'специально переставил после добавки в журнал, чтобы найти бяку
                    Me.Table_SRM_BindingSource.EndEdit()
                    Me.Table_SRM_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_SRM)

                    'Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                    'Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
                    'Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
                    'Me.Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM) ' запрос, который никгда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

                    Save_And_Update_LLI_Click(sender, e)
                    Exit Sub
                End If
                'If Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.CurrentCell.RowIndex).Cells.Item(i + 1).Value <> "" Then
                '    Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.CurrentCell.RowIndex).Cells.Item(i + 1).Value = MaskedTextBox_LLI_Irradiation_Log.Text
                '    If i = 10 Then
                '        Table_SRM_DataGridView.Rows.Item(Table_SRM_DataGridView.CurrentCell.RowIndex).Cells.Item(12).Value = False
                '    End If
                '    Exit Sub
                'End If
            Next

            '  cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_LLI_Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text +
            '"' WHERE Monitor_Set_Name='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value +
            '"' and Monitor_Set_Number='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString +
            '"' and Monitor_Number='" + DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "'"

            '  cmd.Connection = sqlConnection1
            '  sqlConnection1.Open()
            '  cmd.ExecuteNonQuery()
            '  sqlConnection1.Close()

            '  cmd.CommandText = "INSERT dbo.table_LLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
            '      " VALUES ('m', 'm', 'm', '" +
            '       DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value + "', '" +
            '       DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString + "', '" +
            '       DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "', '" +
            '       MaskedTextBox_LLI_Irradiation_Log.Text + "')"

            '  cmd.Connection = sqlConnection1
            '  sqlConnection1.Open()
            '  cmd.ExecuteNonQuery()
            '  sqlConnection1.Close()

            '  Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            '  Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
            '  Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            '  Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)
            '  Form_LLI_Irradiation_Log_Load(sender, e)

            ''Dim Max_Position_Number As Integer
            ''Max_Position_Number = 0
            'Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            ''Dim reader As SqlDataReader
            'Dim cmd As New System.Data.SqlClient.SqlCommand
            'cmd.CommandType = System.Data.CommandType.Text

            ''cmd.CommandText = "SELECT MAX(I_LLI_Position_Number) FROM dbo.table_Sample WHERE I_LLI_Date='" +
            ''    MaskedTextBox_LLI_Irradiation_Log.Text + "'"
            ''cmd.Connection = sqlConnection1
            ''sqlConnection1.Open()
            ''reader = cmd.ExecuteReader()

            ''While reader.Read()
            ''    If Not IsDBNull(reader(0)) Then Max_Position_Number = reader(0)
            ''End While
            ''sqlConnection1.Close()

            'cmd.CommandText = "UPDATE dbo.table_Sample SET I_LLI_Date='" + MaskedTextBox_LLI_Irradiation_Log.Text +
            '     "' WHERE F_Country_Code='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(0).Value +
            '     "' and F_Client_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(1).Value +
            '     "' and F_Year='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(2).Value +
            '     "' and F_Sample_Set_ID='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(3).Value +
            '     "' and F_Sample_Set_Index='" + DataGridView_LLI_Sample_Set.SelectedCells.Item(4).Value +
            '     "' and A_Sample_ID='" + ListBox_Sample_ID.Text + "'"
            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'cmd.ExecuteNonQuery()
            'sqlConnection1.Close()

            'table_Sample_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'table_Sample_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_Sample_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
            'Form_LLI_Irradiation_Log_Load(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Add_SRM_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Add_SRM_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Delete_Last_Irradiation_Date_From_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Delete_Last_Irradiation_Date_From_Log.Click
        Try
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_LLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value <> "s" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
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

                cmd.CommandText = "SELECT SRM_LLI_Irradiation_Date_" + i.ToString + " FROM dbo.table_SRM" +
                     " WHERE SRM_Set_Name='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
                     "' and SRM_Set_Number='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                     "' and SRM_Number='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        sqlConnection1.Close()
                        cmd.CommandText = "UPDATE dbo.table_SRM SET SRM_LLI_Irradiation_Date_" + i.ToString + "=NULL" +
                                          " WHERE SRM_Set_Name='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
                                          "' and SRM_Set_Number='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                                          "' and SRM_Number='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString + "'"
                        cmd.Connection = sqlConnection1
                        sqlConnection1.Open()
                        cmd.ExecuteNonQuery()
                        sqlConnection1.Close()
                        GoTo a
                    End If

                End While
                sqlConnection1.Close()
            Next

a:          cmd.CommandText = "DELETE FROM dbo.table_LLI_Irradiation_Log " +
                 " WHERE Country_Code='s' and Client_ID='s' and Year='s" +
                 "' and Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
                 "' and Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                 "' and Sample_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString +
                 "' and Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
            'Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Me.Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM) ' запрос, который никгда не возвращает ни одной строки. Нужен для того, чтобы очистить datagridview для  SRM 

            Save_And_Update_LLI_Click(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Delete_Last_Irradiation_Date_From_Log_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Delete_Last_Irradiation_Date_From_Log_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Set_SRM_As_Not_In_Use_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Set_SRM_As_Not_In_Use.Click
        Try
            If DataGridView_Table_SRM_Set.SelectedRows.Count = 0 Or DataGridView_Table_SRM_Set.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите одну партию стандартов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one SRM set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_Table_SRM.SelectedRows.Count = 0 Or DataGridView_Table_SRM.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один стандарт!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one SRM!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE dbo.table_SRM SET SRM_LLI_Not_In_Use='True'" +
                 " WHERE SRM_Set_Name='" + DataGridView_Table_SRM_Set.SelectedCells.Item(0).Value +
                 "' and SRM_Set_Number='" + DataGridView_Table_SRM_Set.SelectedCells.Item(1).Value.ToString +
                 "' and SRM_Number='" + DataGridView_Table_SRM.SelectedCells.Item(0).Value.ToString + "'"
            ''"' and SRM_LLI_Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text + "'" 'если добавить это условие, будут помечаться только с проставленной датой облучения, без него - любые
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text, TextBox_Download.Text)
            Table_SRM_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_SRM_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_SRM)

            Save_And_Update_LLI_Click(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Set_SRM_As_Not_In_Use_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Set_SRM_As_Not_In_Use_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Add_Monitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Add_Monitor.Click
        Try
            If DataGridView_Table_Monitor_Set.SelectedCells.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите партию мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select monitor set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If DataGridView_Table_Monitor.SelectedCells.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_LLI_Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text +
                 "' WHERE Monitor_Set_Name='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value +
                 "' and Monitor_Set_Number='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString +
                 "' and Monitor_Number='" + DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "INSERT dbo.table_LLI_Irradiation_Log (Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index, Sample_ID, Date_Start) " +
                " VALUES ('m', 'm', 'm', '" +
                 DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value + "', '" +
                 DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString + "', '" +
                 DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "', '" +
                 MaskedTextBox_LLI_Irradiation_Log.Text + "')"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
            'Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)

            Save_And_Update_LLI_Click(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Add_Monitor_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Add_Monitor_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Delete_Monitor_From_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Delete_Monitor_From_Log.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_LLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value <> "m" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "DELETE FROM dbo.table_LLI_Irradiation_Log " +
                 " WHERE Country_Code='m' and Client_ID='m' and Year='m" +
                 "' and Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
                 "' and Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                 "' and Sample_ID='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString +
                 "' and Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_LLI_Date_Start=NULL" +
                 " WHERE Monitor_Set_Name='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(3).Value +
                 "' and Monitor_Set_Number='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(4).Value.ToString +
                 "' and Monitor_Number='" + DataGridView_LLI_Irradiation_Log.SelectedCells.Item(5).Value.ToString + "'"
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            'Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text)
            'Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            'Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)

            Save_And_Update_LLI_Click(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Delete_Monitor_From_Log_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Delete_Monitor_From_Log_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Set_Monitor_As_Not_In_Use_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Set_Monitor_As_Not_In_Use.Click
        Try
            If DataGridView_Table_Monitor_Set.SelectedRows.Count = 0 Or DataGridView_Table_Monitor_Set.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите одну партию мониторов!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one monitor set!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_Table_Monitor.SelectedRows.Count = 0 Or DataGridView_Table_Monitor.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один монитор!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one monitor!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            'Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE dbo.table_Monitor SET Monitor_LLI_Not_In_Use='True'" +
                 " WHERE Monitor_Set_Name='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(0).Value +
                 "' and Monitor_Set_Number='" + DataGridView_Table_Monitor_Set.SelectedCells.Item(1).Value.ToString +
                 "' and Monitor_Number='" + DataGridView_Table_Monitor.SelectedCells.Item(0).Value.ToString + "'"
            ''"' and Monitor_LLI_Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text + "'" 'если добавить это условие, будут помечаться только с проставленной датой облучения, без него - любые
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            Table_LLI_Irradiation_Log_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_LLI_Irradiation_Log_TableAdapter.Fill_LLI_Irradiation_Log(NAA_DB_EXPDataSet.table_LLI_Irradiation_Log, MaskedTextBox_LLI_Irradiation_Log.Text, TextBox_Download.Text)
            Table_Monitor_TableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Table_Monitor_TableAdapter.Fill_Empty(Me.NAA_DB_EXPDataSet.table_Monitor)

            Save_And_Update_LLI_Click(sender, e)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Set_Monitor_As_Not_In_Use_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Set_Monitor_As_Not_In_Use_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Save_And_Update_LLI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save_And_Update_LLI.Click
        Try
            '   If Not loadNumFlag Then

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text


            cmd.CommandText = $"update  table_LLI_Irradiation_Log set loadNumber = '{TextBox_Download.Text}' where Date_Start = '{MaskedTextBox_LLI_Irradiation_Log.Text}' and loadNumber is null"

            cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                sqlConnection1.Close()

            '  End If


            Dim s_var_1, s_var_2, s_var_3, s_var_4 As String

            Me.Validate()
            Me.Table_LLI_Irradiation_Log_BindingSource.EndEdit()
            Me.Table_LLI_Irradiation_Log_TableAdapter.Update(Me.NAA_DB_EXPDataSet.table_LLI_Irradiation_Log)

            s_var_1 = ComboBox_Sample_Set_View.Text
            s_var_2 = ComboBox_Person.Text ' не менять на .SelectedItem - будут ошибки!
            s_var_3 = ComboBox_SRM_Set_View.Text
            s_var_4 = ComboBox_Monitor_Set_View.Text

            Form_LLI_Irradiation_Log_Load(sender, e)

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

    Private Sub B_Find_Sample_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Find_Sample_Set.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Or DataGridView_LLI_Irradiation_Log.SelectedRows.Count > 1 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value = "m" Or DataGridView_LLI_Irradiation_Log.SelectedCells.Item(0).Value = "s" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите один образец!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select one sample!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If DataGridView_LLI_Irradiation_Log.RowCount > 0 Then
                'DataGridView_LLI_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_LLI_Sample_Set.RowCount - 1
                For i = 0 To DataGridView_LLI_Sample_Set.RowCount - 1
                    If (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(0).Value = DataGridView_LLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(0).Value) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(1).Value = DataGridView_LLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(1).Value) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(2).Value = DataGridView_LLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(2).Value) And (DataGridView_LLI_Sample_Set.Rows.Item(i).Cells.Item(3).Value = DataGridView_LLI_Irradiation_Log.SelectedRows.Item(0).Cells.Item(3).Value) Then
                        DataGridView_LLI_Sample_Set.Rows.Item(i).Selected = True
                        DataGridView_LLI_Sample_Set.FirstDisplayedScrollingRowIndex = i
                        Exit Sub
                    End If

                Next
                'DataGridView_LLI_Sample_Set.Rows.Item(DataGridView_LLI_Sample_Set.RowCount - 1).Selected = True
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Find_Sample_Set_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Find_Sample_Set_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Channel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Channel.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If ComboBox_Channel.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите канал!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select channel!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(8).Value = ComboBox_Channel.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Channel_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Channel_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Fill_In_Container_Number_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_Container_Number.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_Container_Number.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер контейнера!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type container's number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(11).Value = TextBox_Container_Number.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_Container_Number_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in B_Fill_In_Container_Number_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Paper_Log_LLI1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Paper_Log_LLI1.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_Paper_Log_LLI1.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер бумажного журнала ДЖИ1!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type paper log LLI1's number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(29).Value = TextBox_Paper_Log_LLI1.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Button_Paper_Log_LLI1_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Button_Paper_Log_LLI1_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Paper_Log_LLI2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Paper_Log_LLI2.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_Paper_Log_LLI2.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер бумажного журнала ДЖИ2!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type paper log LLI2's number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(36).Value = TextBox_Paper_Log_LLI2.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Button_Paper_Log_LLI2_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Button_Paper_Log_LLI2_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
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
                    'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_SRM_Set.RowCount - 1).Selected = True
                End If
            End If

            If ComboBox_SRM_Set_View.SelectedItem = "SRM sets from log" Or ComboBox_SRM_Set_View.SelectedItem = "Партии стандартов из журнала" Then
                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT DISTINCT Sample_Set_ID, Sample_Set_Index FROM dbo.table_LLI_Irradiation_Log" +
                         " WHERE Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text +
                         "' and Country_Code='s'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()

                Table_SRM_Set_BindingSource.CurrencyManager.SuspendBinding() 'SuspendBinding приостанавливает привязку данных DataGridView к базе данных. Если этого не сделать, то при попытке сделать невидимой текущюю строку grid'а будет ошибка

                For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                    'Table_SRM_Set_BindingSource.DataGridView_LLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_LLI_Irradiation_Log.RowCount - 1
                    DataGridView_Table_SRM_Set.Rows.Item(i).Visible = False
                Next

                While reader.Read()
                    'Dim myBindingManager As BindingManagerBase = BindingContext(NAA_DB_EXPDataSet, "table_SRM_Set")
                    'myBindingManager.SuspendBinding()

                    'Dim tbl As DataTable = CType(DataGridView_LLI_SRM_Set.DataSource, DataTable)
                    'Dim CurManager As CurrencyManager = CType(DataGridView_LLI_SRM_Set.BindingContext(tbl), CurrencyManager)
                    'CurManager.SuspendBinding()

                    'Table_SRM_Set_BindingSource.Filter = ""

                    If Not IsDBNull(reader(0)) Then
                        For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                            'Table_SRM_Set_BindingSource.DataGridView_LLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_LLI_Irradiation_Log.RowCount - 1
                            If (DataGridView_Table_SRM_Set.Rows.Item(i).Cells.Item(0).Value = reader(0)) And (DataGridView_Table_SRM_Set.Rows.Item(i).Cells.Item(1).Value = reader(1)) Then
                                DataGridView_Table_SRM_Set.Rows.Item(i).Visible = True
                            End If
                        Next
                    End If

                    'myBindingManager.ResumeBinding()
                    If DataGridView_Table_SRM_Set.RowCount > 0 Then
                        'DataGridView_LLI_SRM_Set.FirstDisplayedScrollingRowIndex = DataGridView_LLI_SRM_Set.RowCount - 1 ' если разкоментить, будет ошибка при установке firstdisplayed для скрытой строки
                        For i = 0 To DataGridView_Table_SRM_Set.RowCount - 1
                            DataGridView_Table_SRM_Set.Rows.Item(i).Selected = False
                        Next
                        'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_SRM_Set.RowCount - 1).Selected = True
                    End If
                End While
                sqlConnection1.Close()

                Table_SRM_Set_BindingSource.CurrencyManager.ResumeBinding()

                If DataGridView_LLI_Irradiation_Log.RowCount > 0 Then
                    DataGridView_LLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                        DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_SRM_Set.RowCount - 1).Selected = True
                End If
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_SRM_Set_View_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in ComboBox_SRM_Set_View_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            End If
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
                    'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Monitor_Set.RowCount - 1).Selected = True
                End If
            End If

            If ComboBox_Monitor_Set_View.SelectedItem = "Monitor sets from log" Or ComboBox_Monitor_Set_View.SelectedItem = "Партии мониторов из журнала" Then

                Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
                Dim reader As SqlDataReader
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "SELECT DISTINCT Sample_Set_ID, Sample_Set_Index FROM dbo.table_LLI_Irradiation_Log" +
                         " WHERE Date_Start='" + MaskedTextBox_LLI_Irradiation_Log.Text +
                         "' and Country_Code='m'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()

                Table_Monitor_Set_BindingSource.CurrencyManager.SuspendBinding() 'SuspendBinding приостанавливает привязку данных DataGridView к базе данных. Если этого не сделать, то при попытке сделать невидимой текущюю строку grid'а будет ошибка

                For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                    'Table_Monitor_Set_BindingSource.DataGridView_LLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_LLI_Irradiation_Log.RowCount - 1
                    DataGridView_Table_Monitor_Set.Rows.Item(i).Visible = False
                Next

                While reader.Read()
                    'Dim myBindingManager As BindingManagerBase = BindingContext(NAA_DB_EXPDataSet, "table_Monitor_Set")
                    'myBindingManager.SuspendBinding()

                    'Dim tbl As DataTable = CType(DataGridView_LLI_Monitor_Set.DataSource, DataTable)
                    'Dim CurManager As CurrencyManager = CType(DataGridView_LLI_Monitor_Set.BindingContext(tbl), CurrencyManager)
                    'CurManager.SuspendBinding()

                    'Table_Monitor_Set_BindingSource.Filter = ""

                    If Not IsDBNull(reader(0)) Then
                        For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                            'Table_Monitor_Set_BindingSource.DataGridView_LLI_Irradiation_Log.DataSource.CurrencyManager.Position = DataGridView_LLI_Irradiation_Log.RowCount - 1
                            If (DataGridView_Table_Monitor_Set.Rows.Item(i).Cells.Item(0).Value = reader(0)) And (DataGridView_Table_Monitor_Set.Rows.Item(i).Cells.Item(1).Value = reader(1)) Then
                                DataGridView_Table_Monitor_Set.Rows.Item(i).Visible = True
                            End If
                        Next
                    End If

                    'myBindingManager.ResumeBinding()
                    If DataGridView_Table_Monitor_Set.RowCount > 0 Then
                        'DataGridView_LLI_Monitor_Set.FirstDisplayedScrollingRowIndex = DataGridView_LLI_Monitor_Set.RowCount - 1 ' если разкоментить, будет ошибка при установке firstdisplayed для скрытой строки
                        For i = 0 To DataGridView_Table_Monitor_Set.RowCount - 1
                            DataGridView_Table_Monitor_Set.Rows.Item(i).Selected = False
                        Next
                        'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Monitor_Set.RowCount - 1).Selected = True
                    End If
                End While
                sqlConnection1.Close()

                Table_Monitor_Set_BindingSource.CurrencyManager.ResumeBinding()

                If DataGridView_LLI_Irradiation_Log.RowCount > 0 Then
                    DataGridView_LLI_Irradiation_Log.FirstDisplayedScrollingRowIndex = 0
                    For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                        DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = False
                    Next
                    'DataGridView_LLI_Table.Rows.Item(DataGridView_LLI_Monitor_Set.RowCount - 1).Selected = True
                End If
            End If
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_Monitor_Set_View_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in ComboBox_Monitor_Set_View_SelectionChangeCommitted!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Save_LLI_Log_To_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save_LLI_Log_To_File.Click
        Try
            Dim dictionary As New Dictionary(Of Integer, String)

            Dim DI As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\JOURNALS")
            If DI.Exists Then
            Else
                MkDir("C:\GENIE2K\JOURNALS")
            End If
            SaveFileDialog_LLI.InitialDirectory = "C:\GENIE2K\JOURNALS"
            SaveFileDialog_LLI.FileName = $"LLI_journals_{MaskedTextBox_LLI_Irradiation_Log.Text}_{TextBox_Download.Text}.xlsx"
            If SaveFileDialog_LLI.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 

                '' ***быстрее, но не сохраняет форматирование ячеек
                Dim dataList As New ArrayList
                dataList.Add(6)
                dataList.Add(9)
                dataList.Add(15)
                dataList.Add(17)
                Dim dt As New DataTable()
                Dim cntNum As Integer
                Dim colorDict As New Dictionary(Of Integer, String)
                For Each elem In ContNum
                    colorDict.Add(elem, "init")
                Next

                Dim finish, len As Integer
                len = 0
                finish = 0
                For Each column As DataGridViewColumn In DataGridView_LLI_Irradiation_Log.Columns
                    dt.Columns.Add(column.HeaderText, column.ValueType) 'column.ValueType
                Next

                ' 
                For Each cntNum In ContNum
                    For i As Integer = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                        If DataGridView_LLI_Irradiation_Log(11, i).Value = cntNum Then
                            len += 1
                            colorDict.Remove(cntNum)
                            colorDict.Add(cntNum, (i - len + 3).ToString & "_" & (i + 2).ToString)

                        End If
                    Next
                    len = 0
                Next

                For Each row As DataGridViewRow In DataGridView_LLI_Irradiation_Log.Rows
                    dt.Rows.Add()
                    For Each cell As DataGridViewCell In row.Cells
                        dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value

                       
                    Next
                Next


                colorNames.Add(1, ClosedXML.Excel.XLColor.SkyBlue)
                colorNames.Add(2, ClosedXML.Excel.XLColor.Tan)
                colorNames.Add(3, ClosedXML.Excel.XLColor.TeaRoseRose)
                colorNames.Add(4, ClosedXML.Excel.XLColor.TeaGreen)
                colorNames.Add(5, ClosedXML.Excel.XLColor.LightGray)
                colorNames.Add(6, ClosedXML.Excel.XLColor.LightYellow)
                colorNames.Add(7, ClosedXML.Excel.XLColor.Brass)
                colorNames.Add(8, ClosedXML.Excel.XLColor.CaribbeanGreen)
                colorNames.Add(9, ClosedXML.Excel.XLColor.CosmicLatte)

                Using wb As New ClosedXML.Excel.XLWorkbook()
                    Dim ws = wb.Worksheets.Add(dt, $"{MaskedTextBox_LLI_Irradiation_Log.Text}_{TextBox_Download.Text}")

                    For Each key In colorDict
                        If key.Value <> "init" Then
                            Dim rngclr = ws.Range("A" & Split(key.Value, "_")(0) & ":S" & Split(key.Value, "_")(1))
                            rngclr.Style.Fill.BackgroundColor = colorNames(key.Key)
                        End If
                    Next
                    Dim rngbord = ws.Range("A1:S" & (dt.Rows.Count + 1).ToString)
                    rngbord.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thick
                    rngbord.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    ' ws.Columns("A:S").Style.Alignment.WrapText = True
                    ws.Columns("A:S").Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                    ws.Columns("A:S").AdjustToContents()
                    wb.SaveAs(SaveFileDialog_LLI.FileName)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Button_Save_LLI_Log_To_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Button_Save_LLI_Log_To_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
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
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в column_letters!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in column_letters!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Function
        End Try
    End Function

    Private Sub Button_LLI1_Spectrum_File_Click(sender As System.Object, e As System.EventArgs) Handles Button_LLI1_Spectrum_File.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_LLI1_Spectrum_File.Text = "" Then
                MsgBox("Type number of LLI1 spectrum file!")
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер бумажного журнала ДЖИ1!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type paper log LLI1's number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(16).Value = TextBox_LLI1_Spectrum_File.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Button_LLI1_Spectrum_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Button_LLI1_Spectrum_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Button_LLI2_Spectrum_File_Click(sender As System.Object, e As System.EventArgs) Handles Button_LLI2_Spectrum_File.Click
        Try
            If DataGridView_LLI_Irradiation_Log.SelectedRows.Count = 0 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите строку(и)!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select row(s)!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            If TextBox_LLI2_Spectrum_File.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер бумажного журнала ДЖИ2!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Type paper log LLI2's number!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            For i = 0 To DataGridView_LLI_Irradiation_Log.RowCount - 1
                'Table_SampleDataGridView.Rows.Item(i).Cells.Item(2).Value = 0 '2 - cleaning
                If DataGridView_LLI_Irradiation_Log.Rows.Item(i).Selected = True Then DataGridView_LLI_Irradiation_Log.Rows.Item(i).Cells.Item(18).Value = TextBox_LLI2_Spectrum_File.Text
            Next
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Button_LLI2_Spectrum_File_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Button_LLI2_Spectrum_File_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub ListBox_Sample_ID_All_LLI_Weight_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles ListBox_Sample_ID_All_LLI_Weight.SelectedValueChanged
        Try
            Dim s As String
            s = ListBox_Sample_ID_All_LLI_Weight.SelectedItem
            s = Replace(s, Mid(s, 1, InStr(1, s, " ")), "", 1, 1)
            Clipboard.SetText(s)
        Catch ex As Exception
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в ListBox_Sample_ID_All_LLI_Weight_SelectedValueChanged!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in ListBox_Sample_ID_All_LLI_Weight_SelectedValueChanged!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Samples_By_Detectors_Click(sender As System.Object, e As System.EventArgs) Handles Button_Samples_By_Detectors.Click
        Try
            Dim Max_Conteiner_Capacity(8, 0), Container_Count As Integer
            Dim local_maximum As Integer
            Dim Current_Set, Current_Value_Of_Excel_Cell As String

            If TextBox_Download.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Введите номер загрузки!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Fill in the number of download!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            If ComboBox_Sample_Geometry.Text = "" Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выберите высоту!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select height!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Current_Set = ""
            Current_Value_Of_Excel_Cell = ""

            For i = 0 To 8
                Max_Conteiner_Capacity(i, 0) = 0
            Next

            Container_Count = 0
            For i = 1 To 8
                Max_Conteiner_Capacity(i, 0) = 0
                For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = i Then
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(12).Value > Max_Conteiner_Capacity(i, 0) Then
                            Max_Conteiner_Capacity(i, 0) = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(12).Value
                        End If
                    End If
                Next
                If Max_Conteiner_Capacity(i, 0) <> 0 Then
                    Container_Count = i
                End If
            Next

            If Container_Count = 0 Then
                Exit Sub
            ElseIf Container_Count > 6 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Число контейнеров превышает допустимое (6)!", MsgBoxStyle.Critical, Me.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("The quantity of containers is more then the valid number (6)!", MsgBoxStyle.Critical, Me.Text)
                End If
                'Exit Sub
            End If

            ' SaveFileDialog_Sample_By_Detector.InitialDirectory = "C:\"
            SaveFileDialog_Sample_By_Detector.FileName = "Download " + TextBox_Download.Text + ".xlsx"
            If SaveFileDialog_Sample_By_Detector.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                'Dim s As String
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                'Открыть новую книгу Excel
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)

                oSheet.Columns("A").ColumnWidth = 5
                oSheet.Columns("A").HorizontalAlignment = -4108
                oSheet.Columns("A").VerticalAlignment = -4108
                oSheet.Columns("A").WrapText = True ' Переносить по словам
                oSheet.Columns("B").ColumnWidth = 20
                oSheet.Columns("B").HorizontalAlignment = -4108
                oSheet.Columns("B").VerticalAlignment = -4108
                oSheet.Columns("B").WrapText = True ' Переносить по словам
                oSheet.Columns("C").ColumnWidth = 20
                oSheet.Columns("C").HorizontalAlignment = -4108
                oSheet.Columns("C").VerticalAlignment = -4108
                oSheet.Columns("C").WrapText = True ' Переносить по словам
                oSheet.Columns("D").ColumnWidth = 20
                oSheet.Columns("D").HorizontalAlignment = -4108
                oSheet.Columns("D").VerticalAlignment = -4108
                oSheet.Columns("D").WrapText = True ' Переносить по словам

                oSheet.Range("B1").Value = "Загрузка " + TextBox_Download.Text
                oSheet.Range("B2").Value = ""
                oSheet.Range("B3").Value = "Журнал облучения"
                oSheet.Range("C3").Value = MaskedTextBox_LLI_Irradiation_Log.Text
                oSheet.Range("B5").Value = "Начало облучения:"
                oSheet.Range("C5").Value = Format(DataGridView_LLI_Irradiation_Log.Rows.Item(0).Cells.Item(6).Value, "dd.MM.yyyy").ToString
                oSheet.Range("D5").Value = DataGridView_LLI_Irradiation_Log.Rows.Item(0).Cells.Item(7).Value.ToString

                oSheet.Range("B7").Value = "Окончание облучения:"
                If Not IsDBNull(DataGridView_LLI_Irradiation_Log.Rows.Item(0).Cells.Item(9).Value) Then
                    oSheet.Range("C7").Value = Format(DataGridView_LLI_Irradiation_Log.Rows.Item(0).Cells.Item(9).Value, "dd.MM.yyyy").ToString
                End If
                oSheet.Range("D7").Value = DataGridView_LLI_Irradiation_Log.Rows.Item(0).Cells.Item(10).Value.ToString

                oSheet.Range("B9").Value = "Детектор 1"
                oSheet.Range("C9").Value = "Детектор 5"
                oSheet.Range("D9").Value = "Детектор 7"

                Dim current_i, maximum_i As Integer
                current_i = 12
                maximum_i = 12
                local_maximum = 12
                Dim monitor_list As String
                monitor_list = ""

                ' 1 КОНТЕЙНЕР или 4 КОНТЕЙНЕРА
                If Container_Count < 4 Then
                    oSheet.Range("B" + (current_i - 2).ToString).Value = "Контейнер 1"
                ElseIf Container_Count >= 4 Then
                    oSheet.Range("B" + (current_i - 2).ToString).Value = "Контейнер 1 Контейнер 4"
                End If

                For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 1 Or DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 4 Then
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "s" And DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" Then
                            ' номера ячеек с образцами
                            oSheet.Range("A" + current_i.ToString).Value = current_i - 11

                            oSheet.Range("B" + current_i.ToString).Value = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString

                            Current_Set = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(1).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(2).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString

                            oSheet.Range("B" + (local_maximum - 1).ToString).Value = oSheet.Range("B" + (local_maximum - 1).ToString).Value + " " + Current_Set
                            Current_Value_Of_Excel_Cell = oSheet.Range("B" + (local_maximum - 1).ToString).Value

                            Dim First_In As Integer
                            First_In = 0
                            First_In = InStr(Current_Value_Of_Excel_Cell, Current_Set)
                            If First_In > 0 Then
                                If InStr(First_In + Len(Current_Set), Current_Value_Of_Excel_Cell, Current_Set) > 0 Then
                                    Current_Value_Of_Excel_Cell = Replace(Current_Value_Of_Excel_Cell, Current_Set, "", , 1)
                                End If
                            End If

                            ' убираем все пробелы в начале и в конце
                            Current_Value_Of_Excel_Cell = Trim(Current_Value_Of_Excel_Cell)
                            ' убираем двойные пробелы внутри строки
                            While InStr(Current_Value_Of_Excel_Cell, "  ") > 0
                                Current_Value_Of_Excel_Cell = Replace(Current_Value_Of_Excel_Cell, "  ", " ")
                            End While
                            oSheet.Range("B" + (local_maximum - 1).ToString).Value = Current_Value_Of_Excel_Cell

                            current_i = current_i + 1
                            If maximum_i < current_i Then maximum_i = current_i
                        ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "s" Then
                            ' номера ячеек с образцами
                            oSheet.Range("A" + current_i.ToString).Value = current_i - 11

                            oSheet.Range("B" + current_i.ToString).NumberFormat = "@" ' этот крякозябр обозначает текстовый формат
                            oSheet.Range("B" + current_i.ToString).Value = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString

                            current_i = current_i + 1
                            If maximum_i < current_i Then maximum_i = current_i
                        ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                            monitor_list = monitor_list + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString + "; "
                        End If
                    End If
                Next
                If Container_Count = 1 Then GoTo Label_Exit

                ' 2 КОНТЕЙНЕРА или 5 КОНТЕЙНЕРОВ
                current_i = 12

                If Container_Count < 5 Then
                    oSheet.Range("C" + (current_i - 2).ToString).Value = "Контейнер 2"
                ElseIf Container_Count >= 5 Then
                    oSheet.Range("C" + (current_i - 2).ToString).Value = "Контейнер 2 Контейнер 5"
                End If

                For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 2 Or DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 5 Then
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "s" And DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" Then
                            ' номера ячеек с образцами
                            oSheet.Range("A" + current_i.ToString).Value = current_i - 11

                            oSheet.Range("C" + current_i.ToString).Value = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString

                            Current_Set = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(1).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(2).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString

                            oSheet.Range("C" + (local_maximum - 1).ToString).Value = oSheet.Range("C" + (local_maximum - 1).ToString).Value + " " + Current_Set
                            Current_Value_Of_Excel_Cell = oSheet.Range("C" + (local_maximum - 1).ToString).Value

                            Dim First_In As Integer
                            First_In = 0
                            First_In = InStr(Current_Value_Of_Excel_Cell, Current_Set)
                            If First_In > 0 Then
                                If InStr(First_In + Len(Current_Set), Current_Value_Of_Excel_Cell, Current_Set) > 0 Then
                                    Current_Value_Of_Excel_Cell = Replace(Current_Value_Of_Excel_Cell, Current_Set, "", , 1)
                                End If
                            End If

                            ' убираем все пробелы в начале и в конце
                            Current_Value_Of_Excel_Cell = Trim(Current_Value_Of_Excel_Cell)
                            ' убираем двойные пробелы внутри строки
                            While InStr(Current_Value_Of_Excel_Cell, "  ") > 0
                                Current_Value_Of_Excel_Cell = Replace(Current_Value_Of_Excel_Cell, "  ", " ")
                            End While
                            oSheet.Range("C" + (local_maximum - 1).ToString).Value = Current_Value_Of_Excel_Cell

                            current_i = current_i + 1
                            If maximum_i < current_i Then maximum_i = current_i
                        ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "s" Then
                            ' номера ячеек с образцами
                            oSheet.Range("A" + current_i.ToString).Value = current_i - 11

                            oSheet.Range("C" + current_i.ToString).NumberFormat = "@" ' этот крякозябр обозначает текстовый формат
                            oSheet.Range("C" + current_i.ToString).Value = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString

                            current_i = current_i + 1
                            If maximum_i < current_i Then maximum_i = current_i
                        ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                            monitor_list = monitor_list + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString + "; "
                        End If
                    End If
                Next
                If Container_Count = 2 Then GoTo Label_Exit

                ' 3 КОНТЕЙНЕРА или 6 КОНТЕЙНЕРОВ
                current_i = 12

                If Container_Count < 6 Then
                    oSheet.Range("D" + (current_i - 2).ToString).Value = "Контейнер 3"
                ElseIf Container_Count >= 6 Then
                    oSheet.Range("D" + (current_i - 2).ToString).Value = "Контейнер 3 Контейнер 6"
                End If

                For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                    If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 3 Or DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 6 Then
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "s" And DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" Then
                            ' номера ячеек с образцами
                            oSheet.Range("A" + current_i.ToString).Value = current_i - 11

                            oSheet.Range("D" + current_i.ToString).Value = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString

                            Current_Set = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(1).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(2).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + Chr(151) + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString

                            oSheet.Range("D" + (local_maximum - 1).ToString).Value = oSheet.Range("D" + (local_maximum - 1).ToString).Value + " " + Current_Set
                            Current_Value_Of_Excel_Cell = oSheet.Range("D" + (local_maximum - 1).ToString).Value

                            Dim First_In As Integer
                            First_In = 0
                            First_In = InStr(Current_Value_Of_Excel_Cell, Current_Set)
                            If First_In > 0 Then
                                If InStr(First_In + Len(Current_Set), Current_Value_Of_Excel_Cell, Current_Set) > 0 Then
                                    Current_Value_Of_Excel_Cell = Replace(Current_Value_Of_Excel_Cell, Current_Set, "", , 1)
                                End If
                            End If

                            ' убираем все пробелы в начале и в конце
                            Current_Value_Of_Excel_Cell = Trim(Current_Value_Of_Excel_Cell)
                            ' убираем двойные пробелы внутри строки
                            While InStr(Current_Value_Of_Excel_Cell, "  ") > 0
                                Current_Value_Of_Excel_Cell = Replace(Current_Value_Of_Excel_Cell, "  ", " ")
                            End While
                            oSheet.Range("D" + (local_maximum - 1).ToString).Value = Current_Value_Of_Excel_Cell

                            current_i = current_i + 1
                            If maximum_i < current_i Then maximum_i = current_i
                        ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "s" Then
                            ' номера ячеек с образцами
                            oSheet.Range("A" + current_i.ToString).Value = current_i - 11

                            oSheet.Range("D" + current_i.ToString).NumberFormat = "@" ' этот крякозябр обозначает текстовый формат
                            oSheet.Range("D" + current_i.ToString).Value = DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString

                            current_i = current_i + 1
                            If maximum_i < current_i Then maximum_i = current_i
                        ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                            monitor_list = monitor_list + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(3).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(4).Value.ToString + "-" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(5).Value.ToString + "; "
                        End If
                    End If
                Next
                If Container_Count = 3 Then GoTo Label_Exit

Label_Exit:     oSheet.Range("B" + (maximum_i + 1).ToString + ":D" + (maximum_i + 1).ToString).MergeCells = True
                oSheet.Range("B" + (maximum_i + 1).ToString).Value = monitor_list
                oBook.SaveAs(SaveFileDialog_Sample_By_Detector.FileName)
                oExcel.Quit()
            End If

            Dim lines_counter As Integer
            Dim current_weight As String

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If Container_Count >= 1 Or Container_Count >= 4 Then
                ' список образцов для УСО Д1
                SaveFileDialog_Sample_By_Detector.FileName = "D1 SCh list - download " + TextBox_Download.Text + ".uso"
                If SaveFileDialog_Sample_By_Detector.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                    Exit Sub
                ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "D1 samples changer list - download " + TextBox_Download.Text + " - " + Format(Now(), "dd.MM.yyyy") + vbCrLf, False) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "LLI" + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                                "№" + vbTab +
                                                                "Sample set" + vbTab +
                                                                "Samp." + vbTab +
                                                                "w., gr" + vbTab +
                                                                "h., sm" + vbTab +
                                                                "Irr. beg. date" + vbTab +
                                                                "Irr. beg. time" + vbTab +
                                                                "Irr. fin. date" + vbTab +
                                                                "Irr. fin. time", True)
                    lines_counter = 1

                    For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 1 Or DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 4 Then
                            current_weight = ""

                            If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" And DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "s" Then
                                cmd.CommandText = "SELECT P_Weighting_LLI FROM dbo.table_Sample WHERE F_Country_Code='" +
                                                  DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(0).Value +
                                                  "' and F_Client_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(1).Value +
                                                  "' and F_Year='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(2).Value +
                                                  "' and F_Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                                  "' and F_Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                                  "' and A_Sample_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"

                            ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "s" Then
                                cmd.CommandText = "SELECT SRM_LLI_Weight FROM table_SRM WHERE SRM_Set_Name='" +
                                                      DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                                      "' and SRM_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                                      "' and SRM_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"

                                'ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                                '    cmd.CommandText = "SELECT Monitor_SLI_Weight FROM table_Monitor WHERE Monitor_Set_Name='" +
                                '                         DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                '                         "' and Monitor_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                '                         "' and Monitor_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"
                            End If

                            If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" Then
                                cmd.Connection = sqlConnection1
                                sqlConnection1.Open()
                                reader = cmd.ExecuteReader()
                                While reader.Read()
                                    If (Not IsDBNull(reader(0))) Then current_weight = reader(0)
                                End While
                                sqlConnection1.Close()
                                With DataGridView_LLI_Irradiation_Log.Rows
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                                vbCrLf +
                                                                lines_counter.ToString + vbTab + .Item(ii).Cells(0).Value.ToString + "-" + .Item(ii).Cells(1).Value.ToString + "-" + .Item(ii).Cells(2).Value.ToString + "-" + .Item(ii).Cells(3).Value.ToString + "-" + .Item(ii).Cells(4).Value.ToString + vbTab +
                                                                .Item(ii).Cells(5).Value.ToString + vbTab +
                                                                current_weight + vbTab +
                                                                ComboBox_Sample_Geometry.Text + vbTab +
                                                                Format(.Item(ii).Cells(6).Value, "dd.MM.yyyy") + vbTab +
                                                                .Item(ii).Cells(7).Value.ToString + vbTab +
                                                                Format(.Item(ii).Cells(9).Value, "dd.MM.yyyy") + vbTab +
                                                                .Item(ii).Cells(10).Value.ToString + vbTab, True)
                                    lines_counter = lines_counter + 1
                                End With
                            End If
                        End If
                    Next
                End If
            End If

            If Container_Count >= 2 Or Container_Count >= 5 Then
                ' список образцов для УСО Д5
                SaveFileDialog_Sample_By_Detector.FileName = "D5 SCh list - download " + TextBox_Download.Text + ".uso"
                If SaveFileDialog_Sample_By_Detector.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                    Exit Sub
                ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "D5 samples changer list - download " + TextBox_Download.Text + " - " + Format(Now(), "dd.MM.yyyy") + vbCrLf, False) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "LLI" + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                                "№" + vbTab +
                                                                "Sample set" + vbTab +
                                                                "Samp." + vbTab +
                                                                "w., gr" + vbTab +
                                                                "h., sm" + vbTab +
                                                                "Irr. beg. date" + vbTab +
                                                                "Irr. beg. time" + vbTab +
                                                                "Irr. fin. date" + vbTab +
                                                                "Irr. fin. time", True)
                    lines_counter = 1

                    For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 2 Or DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 5 Then
                            current_weight = ""

                            If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" And DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "s" Then
                                cmd.CommandText = "SELECT P_Weighting_LLI FROM dbo.table_Sample WHERE F_Country_Code='" +
                                                  DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(0).Value +
                                                  "' and F_Client_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(1).Value +
                                                  "' and F_Year='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(2).Value +
                                                  "' and F_Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                                  "' and F_Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                                  "' and A_Sample_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"

                            ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "s" Then
                                cmd.CommandText = "SELECT SRM_LLI_Weight FROM table_SRM WHERE SRM_Set_Name='" +
                                                      DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                                      "' and SRM_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                                      "' and SRM_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"

                                'ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                                '    cmd.CommandText = "SELECT Monitor_SLI_Weight FROM table_Monitor WHERE Monitor_Set_Name='" +
                                '                         DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                '                         "' and Monitor_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                '                         "' and Monitor_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"
                            End If

                            If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" Then
                                cmd.Connection = sqlConnection1
                                sqlConnection1.Open()
                                reader = cmd.ExecuteReader()
                                While reader.Read()
                                    If (Not IsDBNull(reader(0))) Then current_weight = reader(0)
                                End While
                                sqlConnection1.Close()
                                With DataGridView_LLI_Irradiation_Log.Rows
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                                vbCrLf +
                                                                lines_counter.ToString + vbTab + .Item(ii).Cells(0).Value.ToString + "-" + .Item(ii).Cells(1).Value.ToString + "-" + .Item(ii).Cells(2).Value.ToString + "-" + .Item(ii).Cells(3).Value.ToString + "-" + .Item(ii).Cells(4).Value.ToString + vbTab +
                                                                .Item(ii).Cells(5).Value.ToString + vbTab +
                                                                current_weight + vbTab +
                                                                ComboBox_Sample_Geometry.Text + vbTab +
                                                                Format(.Item(ii).Cells(6).Value, "dd.MM.yyyy") + vbTab +
                                                                .Item(ii).Cells(7).Value.ToString + vbTab +
                                                                Format(.Item(ii).Cells(9).Value, "dd.MM.yyyy") + vbTab +
                                                                .Item(ii).Cells(10).Value.ToString + vbTab, True)
                                    lines_counter = lines_counter + 1
                                End With
                            End If
                        End If
                    Next
                End If
            End If

            If Container_Count >= 3 Or Container_Count >= 6 Then
                ' список образцов для УСО Д7
                SaveFileDialog_Sample_By_Detector.FileName = "D7 SCh list - download " + TextBox_Download.Text + ".uso"
                If SaveFileDialog_Sample_By_Detector.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                    Exit Sub
                ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "D7 samples changer list - download " + TextBox_Download.Text + " - " + Format(Now(), "dd.MM.yyyy") + vbCrLf, False) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "LLI" + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                                "№" + vbTab +
                                                                "Sample set" + vbTab +
                                                                "Samp." + vbTab +
                                                                "w., gr" + vbTab +
                                                                "h., sm" + vbTab +
                                                                "Irr. beg. date" + vbTab +
                                                                "Irr. beg. time" + vbTab +
                                                                "Irr. fin. date" + vbTab +
                                                                "Irr. fin. time", True)
                    lines_counter = 1

                    For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                        If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 3 Or DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(11).Value = 6 Then
                            current_weight = ""

                            If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" And DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "s" Then
                                cmd.CommandText = "SELECT P_Weighting_LLI FROM dbo.table_Sample WHERE F_Country_Code='" +
                                                  DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(0).Value +
                                                  "' and F_Client_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(1).Value +
                                                  "' and F_Year='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(2).Value +
                                                  "' and F_Sample_Set_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                                  "' and F_Sample_Set_Index='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                                  "' and A_Sample_ID='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"

                            ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "s" Then
                                cmd.CommandText = "SELECT SRM_LLI_Weight FROM table_SRM WHERE SRM_Set_Name='" +
                                                      DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                                      "' and SRM_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                                      "' and SRM_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"

                                'ElseIf DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                                '    cmd.CommandText = "SELECT Monitor_SLI_Weight FROM table_Monitor WHERE Monitor_Set_Name='" +
                                '                         DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                '                         "' and Monitor_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                '                         "' and Monitor_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"
                            End If

                            If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString <> "m" Then
                                cmd.Connection = sqlConnection1
                                sqlConnection1.Open()
                                reader = cmd.ExecuteReader()
                                While reader.Read()
                                    If (Not IsDBNull(reader(0))) Then current_weight = reader(0)
                                End While
                                sqlConnection1.Close()
                                With DataGridView_LLI_Irradiation_Log.Rows
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                                vbCrLf +
                                                                lines_counter.ToString + vbTab + .Item(ii).Cells(0).Value.ToString + "-" + .Item(ii).Cells(1).Value.ToString + "-" + .Item(ii).Cells(2).Value.ToString + "-" + .Item(ii).Cells(3).Value.ToString + "-" + .Item(ii).Cells(4).Value.ToString + vbTab +
                                                                .Item(ii).Cells(5).Value.ToString + vbTab +
                                                                current_weight + vbTab +
                                                                ComboBox_Sample_Geometry.Text + vbTab +
                                                                Format(.Item(ii).Cells(6).Value, "dd.MM.yyyy") + vbTab +
                                                                .Item(ii).Cells(7).Value.ToString + vbTab +
                                                                Format(.Item(ii).Cells(9).Value, "dd.MM.yyyy") + vbTab +
                                                                .Item(ii).Cells(10).Value.ToString + vbTab, True)
                                    lines_counter = lines_counter + 1
                                End With
                            End If
                        End If
                    Next
                End If
            End If

            ' список мониторов
            SaveFileDialog_Sample_By_Detector.FileName = "SCh monitor list - download " + TextBox_Download.Text + ".uso"
            If SaveFileDialog_Sample_By_Detector.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "Samples changer monitor list - download " + TextBox_Download.Text + " - " + Format(Now(), "dd.MM.yyyy") + vbCrLf, False) 'vbCrLf - символ перевода строки
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName, "LLI" + vbCrLf, True) 'vbCrLf - символ перевода строки
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                            "№" + vbTab +
                                                            "Sample set" + vbTab +
                                                            "Samp." + vbTab +
                                                            "w., gr" + vbTab +
                                                            "h., sm" + vbTab +
                                                            "Irr. beg. date" + vbTab +
                                                            "Irr. beg. time" + vbTab +
                                                            "Irr. fin. date" + vbTab +
                                                            "Irr. fin. time", True)
                lines_counter = 1

                For ii = 0 To DataGridView_LLI_Irradiation_Log.Rows.Count - 1
                    current_weight = ""

                    If DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells.Item(0).Value.ToString = "m" Then
                        cmd.CommandText = "SELECT Monitor_LLI_Weight FROM table_Monitor WHERE Monitor_Set_Name='" +
                                             DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(3).Value +
                                             "' and Monitor_Set_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(4).Value +
                                             "' and Monitor_Number='" + DataGridView_LLI_Irradiation_Log.Rows.Item(ii).Cells(5).Value + "'"
                        cmd.Connection = sqlConnection1
                        sqlConnection1.Open()
                        reader = cmd.ExecuteReader()
                        While reader.Read()
                            If (Not IsDBNull(reader(0))) Then current_weight = reader(0)
                        End While
                        sqlConnection1.Close()
                        With DataGridView_LLI_Irradiation_Log.Rows
                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_Sample_By_Detector.FileName,
                                                        vbCrLf +
                                                        lines_counter.ToString + vbTab + .Item(ii).Cells(0).Value.ToString + "-" + .Item(ii).Cells(1).Value.ToString + "-" + .Item(ii).Cells(2).Value.ToString + "-" + .Item(ii).Cells(3).Value.ToString + "-" + .Item(ii).Cells(4).Value.ToString + vbTab +
                                                        .Item(ii).Cells(5).Value.ToString + vbTab +
                                                        current_weight + vbTab +
                                                        "5" + vbTab +
                                                        Format(.Item(ii).Cells(6).Value, "dd.MM.yyyy") + vbTab +
                                                        .Item(ii).Cells(7).Value.ToString + vbTab +
                                                        Format(.Item(ii).Cells(9).Value, "dd.MM.yyyy") + vbTab +
                                                        .Item(ii).Cells(10).Value.ToString + vbTab, True)
                            lines_counter = lines_counter + 1
                        End With
                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub


End Class