<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SLI_Irradiation_Log
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SLI_Irradiation_Log))
        Me.DataGridView_SLI_Irradiation_Log = New System.Windows.Forms.DataGridView()
        Me.CountryCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIndexDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChannelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detector2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Detector3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Detector4DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FileLastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IrradiatedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeasuredByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaperLogNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detector1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileFirstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_SLI_Irradiation_Log_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.L_Name_SLI_Irradiation_Log = New System.Windows.Forms.Label()
        Me.MaskedTextBox_SLI_Irradiation_Log = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView_SLI_Sample_Set = New System.Windows.Forms.DataGridView()
        Me.CountryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetReceiptDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetReportDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Sample_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox_Sample_ID = New System.Windows.Forms.ListBox()
        Me.B_Add_Sample = New System.Windows.Forms.Button()
        Me.MaskedTextBox_Time = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_Time = New System.Windows.Forms.Label()
        Me.B_Fill_In_Time_Start = New System.Windows.Forms.Button()
        Me.B_Delete_Sample_From_Log = New System.Windows.Forms.Button()
        Me.Table_Received_By_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_Fill_In_Irradiated_By = New System.Windows.Forms.Button()
        Me.B_Fill_In_Measured_By = New System.Windows.Forms.Button()
        Me.L_Name_Sample_Set = New System.Windows.Forms.Label()
        Me.L_Name_Sample = New System.Windows.Forms.Label()
        Me.L_Name_SRM_Set = New System.Windows.Forms.Label()
        Me.DataGridView_Table_SRM_Set = New System.Windows.Forms.DataGridView()
        Me.SRMSetNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetWeightDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_SRM_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView_Table_SRM = New System.Windows.Forms.DataGridView()
        Me.SRMSetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLIIrradiationDate10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSLINotInUseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SRMLLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Table_SRM_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Name_SRM = New System.Windows.Forms.Label()
        Me.B_Add_SRM = New System.Windows.Forms.Button()
        Me.B_Delete_Last_Irradiation_Date_From_Log = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.Table_Sample_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_TableAdapter()
        Me.Table_Sample_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter()
        Me.Table_Received_By_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter()
        Me.Table_SRM_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter()
        Me.Table_SRM_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter()
        Me.B_Delete_Monitor_From_Log = New System.Windows.Forms.Button()
        Me.B_Add_Monitor = New System.Windows.Forms.Button()
        Me.L_Name_Monitor = New System.Windows.Forms.Label()
        Me.DataGridView_Table_Monitor = New System.Windows.Forms.DataGridView()
        Me.MonitorSetNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetWeightDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSLIDateStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSLINotInUseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MonitorLLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorLLIDateStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorLLINotInUseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Table_Monitor_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView_Table_Monitor_Set = New System.Windows.Forms.DataGridView()
        Me.MonitorSetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Monitor_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Name_Monitor_Set = New System.Windows.Forms.Label()
        Me.Table_Monitor_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter()
        Me.Table_Monitor_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_MonitorTableAdapter()
        Me.Table_SLI_Irradiation_Log_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SLI_Irradiation_LogTableAdapter()
        Me.Table_Sample_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_Set_Monitor_As_Not_In_Use = New System.Windows.Forms.Button()
        Me.B_Set_SRM_As_Not_In_Use = New System.Windows.Forms.Button()
        Me.B_Find_Sample_Set = New System.Windows.Forms.Button()
        Me.B_Fill_In_Channel = New System.Windows.Forms.Button()
        Me.L_Name_Channel = New System.Windows.Forms.Label()
        Me.ComboBox_Channel = New System.Windows.Forms.ComboBox()
        Me.B_Fill_In_Duration = New System.Windows.Forms.Button()
        Me.L_Name_Duration = New System.Windows.Forms.Label()
        Me.TextBox_Duration = New System.Windows.Forms.TextBox()
        Me.B_Save_And_Update_SLI = New System.Windows.Forms.Button()
        Me.ComboBox_Person = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Sample_Set_View = New System.Windows.Forms.ComboBox()
        Me.L_Monitor = New System.Windows.Forms.Label()
        Me.ComboBox_SRM_Set_View = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Monitor_Set_View = New System.Windows.Forms.ComboBox()
        Me.Button_Auto_Fill_In_Irradiation_Start_Time = New System.Windows.Forms.Button()
        Me.Button_Save_SLI_Log_To_File = New System.Windows.Forms.Button()
        Me.SaveFileDialog_SLI = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox_Spectrum_File = New System.Windows.Forms.TextBox()
        Me.B_Fill_In_Spectrum_File = New System.Windows.Forms.Button()
        Me.L_Name_Spectrum_File = New System.Windows.Forms.Label()
        Me.L_Name_Sample_All_SLI_Weight = New System.Windows.Forms.Label()
        Me.ListBox_Sample_ID_All_SLI_Weight = New System.Windows.Forms.ListBox()
        Me.TextBox_Paper_Log_Number = New System.Windows.Forms.TextBox()
        Me.Button_Paper_Log_Number = New System.Windows.Forms.Button()
        Me.L_Name_Paper_Log_Number = New System.Windows.Forms.Label()
        Me.L_Name_Person = New System.Windows.Forms.Label()
        Me.L_Name_SRM_Set_View = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set_View = New System.Windows.Forms.Label()
        Me.L_Name_Sample_Set_View = New System.Windows.Forms.Label()
        Me.ButtonSaveSpectra = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogSaveSpectra = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.DataGridView_SLI_Irradiation_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SLI_Irradiation_Log_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_SLI_Sample_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_SRM_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_SRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_Monitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_Monitor_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_SLI_Irradiation_Log
        '
        Me.DataGridView_SLI_Irradiation_Log.AllowUserToAddRows = False
        Me.DataGridView_SLI_Irradiation_Log.AllowUserToDeleteRows = False
        Me.DataGridView_SLI_Irradiation_Log.AllowUserToResizeRows = False
        Me.DataGridView_SLI_Irradiation_Log.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_SLI_Irradiation_Log.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_SLI_Irradiation_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_SLI_Irradiation_Log.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryCodeDataGridViewTextBoxColumn1, Me.ClientIDDataGridViewTextBoxColumn1, Me.YearDataGridViewTextBoxColumn1, Me.SampleSetIDDataGridViewTextBoxColumn1, Me.SampleSetIndexDataGridViewTextBoxColumn1, Me.SampleIDDataGridViewTextBoxColumn, Me.DateStartDataGridViewTextBoxColumn, Me.TimeStartDataGridViewTextBoxColumn, Me.ChannelDataGridViewTextBoxColumn, Me.DurationDataGridViewTextBoxColumn, Me.Detector2DataGridViewCheckBoxColumn, Me.Detector3DataGridViewCheckBoxColumn, Me.Detector4DataGridViewCheckBoxColumn, Me.FileLastDataGridViewTextBoxColumn, Me.IrradiatedByDataGridViewTextBoxColumn, Me.MeasuredByDataGridViewTextBoxColumn, Me.PaperLogNumberDataGridViewTextBoxColumn, Me.PositionNumberDataGridViewTextBoxColumn, Me.Detector1DataGridViewTextBoxColumn, Me.FileFirstDataGridViewTextBoxColumn})
        Me.DataGridView_SLI_Irradiation_Log.DataSource = Me.Table_SLI_Irradiation_Log_BindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_SLI_Irradiation_Log.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_SLI_Irradiation_Log.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView_SLI_Irradiation_Log.Name = "DataGridView_SLI_Irradiation_Log"
        Me.DataGridView_SLI_Irradiation_Log.RowHeadersVisible = False
        Me.DataGridView_SLI_Irradiation_Log.RowHeadersWidth = 21
        Me.DataGridView_SLI_Irradiation_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_SLI_Irradiation_Log.Size = New System.Drawing.Size(965, 228)
        Me.DataGridView_SLI_Irradiation_Log.TabIndex = 0
        '
        'CountryCodeDataGridViewTextBoxColumn1
        '
        Me.CountryCodeDataGridViewTextBoxColumn1.DataPropertyName = "Country_Code"
        Me.CountryCodeDataGridViewTextBoxColumn1.HeaderText = "Country_Code"
        Me.CountryCodeDataGridViewTextBoxColumn1.MinimumWidth = 20
        Me.CountryCodeDataGridViewTextBoxColumn1.Name = "CountryCodeDataGridViewTextBoxColumn1"
        Me.CountryCodeDataGridViewTextBoxColumn1.Width = 48
        '
        'ClientIDDataGridViewTextBoxColumn1
        '
        Me.ClientIDDataGridViewTextBoxColumn1.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn1.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn1.Name = "ClientIDDataGridViewTextBoxColumn1"
        Me.ClientIDDataGridViewTextBoxColumn1.Width = 48
        '
        'YearDataGridViewTextBoxColumn1
        '
        Me.YearDataGridViewTextBoxColumn1.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn1.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn1.Name = "YearDataGridViewTextBoxColumn1"
        Me.YearDataGridViewTextBoxColumn1.Width = 48
        '
        'SampleSetIDDataGridViewTextBoxColumn1
        '
        Me.SampleSetIDDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Set_ID"
        Me.SampleSetIDDataGridViewTextBoxColumn1.HeaderText = "Sample_Set_ID"
        Me.SampleSetIDDataGridViewTextBoxColumn1.Name = "SampleSetIDDataGridViewTextBoxColumn1"
        Me.SampleSetIDDataGridViewTextBoxColumn1.Width = 48
        '
        'SampleSetIndexDataGridViewTextBoxColumn1
        '
        Me.SampleSetIndexDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Set_Index"
        Me.SampleSetIndexDataGridViewTextBoxColumn1.HeaderText = "Sample_Set_Index"
        Me.SampleSetIndexDataGridViewTextBoxColumn1.Name = "SampleSetIndexDataGridViewTextBoxColumn1"
        Me.SampleSetIndexDataGridViewTextBoxColumn1.Width = 48
        '
        'SampleIDDataGridViewTextBoxColumn
        '
        Me.SampleIDDataGridViewTextBoxColumn.DataPropertyName = "Sample_ID"
        Me.SampleIDDataGridViewTextBoxColumn.HeaderText = "Sample_ID"
        Me.SampleIDDataGridViewTextBoxColumn.Name = "SampleIDDataGridViewTextBoxColumn"
        Me.SampleIDDataGridViewTextBoxColumn.Width = 49
        '
        'DateStartDataGridViewTextBoxColumn
        '
        Me.DateStartDataGridViewTextBoxColumn.DataPropertyName = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.HeaderText = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.Name = "DateStartDataGridViewTextBoxColumn"
        Me.DateStartDataGridViewTextBoxColumn.Width = 48
        '
        'TimeStartDataGridViewTextBoxColumn
        '
        Me.TimeStartDataGridViewTextBoxColumn.DataPropertyName = "Time_Start"
        Me.TimeStartDataGridViewTextBoxColumn.HeaderText = "Time_Start"
        Me.TimeStartDataGridViewTextBoxColumn.Name = "TimeStartDataGridViewTextBoxColumn"
        Me.TimeStartDataGridViewTextBoxColumn.Width = 48
        '
        'ChannelDataGridViewTextBoxColumn
        '
        Me.ChannelDataGridViewTextBoxColumn.DataPropertyName = "Channel"
        Me.ChannelDataGridViewTextBoxColumn.HeaderText = "Channel"
        Me.ChannelDataGridViewTextBoxColumn.Name = "ChannelDataGridViewTextBoxColumn"
        Me.ChannelDataGridViewTextBoxColumn.Width = 48
        '
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "Duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "Duration"
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        Me.DurationDataGridViewTextBoxColumn.Width = 48
        '
        'Detector2DataGridViewCheckBoxColumn
        '
        Me.Detector2DataGridViewCheckBoxColumn.DataPropertyName = "Detector_2"
        Me.Detector2DataGridViewCheckBoxColumn.HeaderText = "Detector_2"
        Me.Detector2DataGridViewCheckBoxColumn.Name = "Detector2DataGridViewCheckBoxColumn"
        Me.Detector2DataGridViewCheckBoxColumn.Width = 48
        '
        'Detector3DataGridViewCheckBoxColumn
        '
        Me.Detector3DataGridViewCheckBoxColumn.DataPropertyName = "Detector_3"
        Me.Detector3DataGridViewCheckBoxColumn.HeaderText = "Detector_3"
        Me.Detector3DataGridViewCheckBoxColumn.Name = "Detector3DataGridViewCheckBoxColumn"
        Me.Detector3DataGridViewCheckBoxColumn.Width = 48
        '
        'Detector4DataGridViewCheckBoxColumn
        '
        Me.Detector4DataGridViewCheckBoxColumn.DataPropertyName = "Detector_4"
        Me.Detector4DataGridViewCheckBoxColumn.HeaderText = "Detector_4"
        Me.Detector4DataGridViewCheckBoxColumn.Name = "Detector4DataGridViewCheckBoxColumn"
        Me.Detector4DataGridViewCheckBoxColumn.Width = 48
        '
        'FileLastDataGridViewTextBoxColumn
        '
        Me.FileLastDataGridViewTextBoxColumn.DataPropertyName = "File_Last"
        Me.FileLastDataGridViewTextBoxColumn.HeaderText = "File_Last"
        Me.FileLastDataGridViewTextBoxColumn.Name = "FileLastDataGridViewTextBoxColumn"
        Me.FileLastDataGridViewTextBoxColumn.Width = 48
        '
        'IrradiatedByDataGridViewTextBoxColumn
        '
        Me.IrradiatedByDataGridViewTextBoxColumn.DataPropertyName = "Irradiated_By"
        Me.IrradiatedByDataGridViewTextBoxColumn.HeaderText = "Irradiated_By"
        Me.IrradiatedByDataGridViewTextBoxColumn.Name = "IrradiatedByDataGridViewTextBoxColumn"
        Me.IrradiatedByDataGridViewTextBoxColumn.Width = 48
        '
        'MeasuredByDataGridViewTextBoxColumn
        '
        Me.MeasuredByDataGridViewTextBoxColumn.DataPropertyName = "Measured_By"
        Me.MeasuredByDataGridViewTextBoxColumn.HeaderText = "Measured_By"
        Me.MeasuredByDataGridViewTextBoxColumn.Name = "MeasuredByDataGridViewTextBoxColumn"
        Me.MeasuredByDataGridViewTextBoxColumn.Width = 49
        '
        'PaperLogNumberDataGridViewTextBoxColumn
        '
        Me.PaperLogNumberDataGridViewTextBoxColumn.DataPropertyName = "Paper_Log_Number"
        Me.PaperLogNumberDataGridViewTextBoxColumn.HeaderText = "Paper_Log_Number"
        Me.PaperLogNumberDataGridViewTextBoxColumn.Name = "PaperLogNumberDataGridViewTextBoxColumn"
        Me.PaperLogNumberDataGridViewTextBoxColumn.Width = 48
        '
        'PositionNumberDataGridViewTextBoxColumn
        '
        Me.PositionNumberDataGridViewTextBoxColumn.DataPropertyName = "Position_Number"
        Me.PositionNumberDataGridViewTextBoxColumn.HeaderText = "Position_Number"
        Me.PositionNumberDataGridViewTextBoxColumn.Name = "PositionNumberDataGridViewTextBoxColumn"
        Me.PositionNumberDataGridViewTextBoxColumn.Width = 48
        '
        'Detector1DataGridViewTextBoxColumn
        '
        Me.Detector1DataGridViewTextBoxColumn.DataPropertyName = "Detector_1"
        Me.Detector1DataGridViewTextBoxColumn.HeaderText = "Detector_1"
        Me.Detector1DataGridViewTextBoxColumn.Name = "Detector1DataGridViewTextBoxColumn"
        Me.Detector1DataGridViewTextBoxColumn.Width = 48
        '
        'FileFirstDataGridViewTextBoxColumn
        '
        Me.FileFirstDataGridViewTextBoxColumn.DataPropertyName = "File_First"
        Me.FileFirstDataGridViewTextBoxColumn.HeaderText = "File_First"
        Me.FileFirstDataGridViewTextBoxColumn.Name = "FileFirstDataGridViewTextBoxColumn"
        Me.FileFirstDataGridViewTextBoxColumn.Width = 48
        '
        'Table_SLI_Irradiation_Log_BindingSource
        '
        Me.Table_SLI_Irradiation_Log_BindingSource.DataMember = "table_SLI_Irradiation_Log"
        Me.Table_SLI_Irradiation_Log_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(497, 811)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(213, 23)
        Me.B_Close.TabIndex = 4
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'L_Name_SLI_Irradiation_Log
        '
        Me.L_Name_SLI_Irradiation_Log.AutoSize = True
        Me.L_Name_SLI_Irradiation_Log.Location = New System.Drawing.Point(364, 15)
        Me.L_Name_SLI_Irradiation_Log.Name = "L_Name_SLI_Irradiation_Log"
        Me.L_Name_SLI_Irradiation_Log.Size = New System.Drawing.Size(88, 13)
        Me.L_Name_SLI_Irradiation_Log.TabIndex = 5
        Me.L_Name_SLI_Irradiation_Log.Text = "SLI irradiation log"
        '
        'MaskedTextBox_SLI_Irradiation_Log
        '
        Me.MaskedTextBox_SLI_Irradiation_Log.Enabled = False
        Me.MaskedTextBox_SLI_Irradiation_Log.Location = New System.Drawing.Point(497, 12)
        Me.MaskedTextBox_SLI_Irradiation_Log.Mask = "00/00/0000"
        Me.MaskedTextBox_SLI_Irradiation_Log.Name = "MaskedTextBox_SLI_Irradiation_Log"
        Me.MaskedTextBox_SLI_Irradiation_Log.Size = New System.Drawing.Size(66, 20)
        Me.MaskedTextBox_SLI_Irradiation_Log.TabIndex = 156
        Me.MaskedTextBox_SLI_Irradiation_Log.ValidatingType = GetType(Date)
        '
        'DataGridView_SLI_Sample_Set
        '
        Me.DataGridView_SLI_Sample_Set.AllowUserToAddRows = False
        Me.DataGridView_SLI_Sample_Set.AllowUserToDeleteRows = False
        Me.DataGridView_SLI_Sample_Set.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_SLI_Sample_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_SLI_Sample_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_SLI_Sample_Set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryCodeDataGridViewTextBoxColumn, Me.ClientIDDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.SampleSetIDDataGridViewTextBoxColumn, Me.SampleSetIndexDataGridViewTextBoxColumn, Me.SampleSetReceiptDateDataGridViewTextBoxColumn, Me.SampleSetReportDateDataGridViewTextBoxColumn, Me.ReceivedByDataGridViewTextBoxColumn, Me.Notes1DataGridViewTextBoxColumn, Me.Notes2DataGridViewTextBoxColumn, Me.Notes3DataGridViewTextBoxColumn})
        Me.DataGridView_SLI_Sample_Set.DataSource = Me.Table_Sample_Set_BindingSource
        Me.DataGridView_SLI_Sample_Set.Location = New System.Drawing.Point(13, 297)
        Me.DataGridView_SLI_Sample_Set.MultiSelect = False
        Me.DataGridView_SLI_Sample_Set.Name = "DataGridView_SLI_Sample_Set"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_SLI_Sample_Set.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_SLI_Sample_Set.RowHeadersVisible = False
        Me.DataGridView_SLI_Sample_Set.RowHeadersWidth = 21
        Me.DataGridView_SLI_Sample_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_SLI_Sample_Set.Size = New System.Drawing.Size(355, 133)
        Me.DataGridView_SLI_Sample_Set.TabIndex = 156
        '
        'CountryCodeDataGridViewTextBoxColumn
        '
        Me.CountryCodeDataGridViewTextBoxColumn.DataPropertyName = "Country_Code"
        Me.CountryCodeDataGridViewTextBoxColumn.HeaderText = "Country_Code"
        Me.CountryCodeDataGridViewTextBoxColumn.Name = "CountryCodeDataGridViewTextBoxColumn"
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'SampleSetIDDataGridViewTextBoxColumn
        '
        Me.SampleSetIDDataGridViewTextBoxColumn.DataPropertyName = "Sample_Set_ID"
        Me.SampleSetIDDataGridViewTextBoxColumn.HeaderText = "Sample_Set_ID"
        Me.SampleSetIDDataGridViewTextBoxColumn.Name = "SampleSetIDDataGridViewTextBoxColumn"
        '
        'SampleSetIndexDataGridViewTextBoxColumn
        '
        Me.SampleSetIndexDataGridViewTextBoxColumn.DataPropertyName = "Sample_Set_Index"
        Me.SampleSetIndexDataGridViewTextBoxColumn.HeaderText = "Sample_Set_Index"
        Me.SampleSetIndexDataGridViewTextBoxColumn.Name = "SampleSetIndexDataGridViewTextBoxColumn"
        '
        'SampleSetReceiptDateDataGridViewTextBoxColumn
        '
        Me.SampleSetReceiptDateDataGridViewTextBoxColumn.DataPropertyName = "Sample_Set_Receipt_Date"
        Me.SampleSetReceiptDateDataGridViewTextBoxColumn.HeaderText = "Sample_Set_Receipt_Date"
        Me.SampleSetReceiptDateDataGridViewTextBoxColumn.Name = "SampleSetReceiptDateDataGridViewTextBoxColumn"
        '
        'SampleSetReportDateDataGridViewTextBoxColumn
        '
        Me.SampleSetReportDateDataGridViewTextBoxColumn.DataPropertyName = "Sample_Set_Report_Date"
        Me.SampleSetReportDateDataGridViewTextBoxColumn.HeaderText = "Sample_Set_Report_Date"
        Me.SampleSetReportDateDataGridViewTextBoxColumn.Name = "SampleSetReportDateDataGridViewTextBoxColumn"
        '
        'ReceivedByDataGridViewTextBoxColumn
        '
        Me.ReceivedByDataGridViewTextBoxColumn.DataPropertyName = "Received_By"
        Me.ReceivedByDataGridViewTextBoxColumn.HeaderText = "Received_By"
        Me.ReceivedByDataGridViewTextBoxColumn.Name = "ReceivedByDataGridViewTextBoxColumn"
        '
        'Notes1DataGridViewTextBoxColumn
        '
        Me.Notes1DataGridViewTextBoxColumn.DataPropertyName = "Notes_1"
        Me.Notes1DataGridViewTextBoxColumn.HeaderText = "Notes_1"
        Me.Notes1DataGridViewTextBoxColumn.Name = "Notes1DataGridViewTextBoxColumn"
        '
        'Notes2DataGridViewTextBoxColumn
        '
        Me.Notes2DataGridViewTextBoxColumn.DataPropertyName = "Notes_2"
        Me.Notes2DataGridViewTextBoxColumn.HeaderText = "Notes_2"
        Me.Notes2DataGridViewTextBoxColumn.Name = "Notes2DataGridViewTextBoxColumn"
        '
        'Notes3DataGridViewTextBoxColumn
        '
        Me.Notes3DataGridViewTextBoxColumn.DataPropertyName = "Notes_3"
        Me.Notes3DataGridViewTextBoxColumn.HeaderText = "Notes_3"
        Me.Notes3DataGridViewTextBoxColumn.Name = "Notes3DataGridViewTextBoxColumn"
        '
        'Table_Sample_Set_BindingSource
        '
        Me.Table_Sample_Set_BindingSource.DataMember = "table_Sample_Set"
        Me.Table_Sample_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'ListBox_Sample_ID
        '
        Me.ListBox_Sample_ID.FormattingEnabled = True
        Me.ListBox_Sample_ID.Location = New System.Drawing.Point(504, 288)
        Me.ListBox_Sample_ID.Name = "ListBox_Sample_ID"
        Me.ListBox_Sample_ID.Size = New System.Drawing.Size(104, 108)
        Me.ListBox_Sample_ID.TabIndex = 157
        '
        'B_Add_Sample
        '
        Me.B_Add_Sample.Location = New System.Drawing.Point(501, 407)
        Me.B_Add_Sample.Name = "B_Add_Sample"
        Me.B_Add_Sample.Size = New System.Drawing.Size(107, 23)
        Me.B_Add_Sample.TabIndex = 158
        Me.B_Add_Sample.Text = "Add sample"
        Me.B_Add_Sample.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_Time
        '
        Me.MaskedTextBox_Time.Location = New System.Drawing.Point(751, 287)
        Me.MaskedTextBox_Time.Mask = "00:00:00"
        Me.MaskedTextBox_Time.Name = "MaskedTextBox_Time"
        Me.MaskedTextBox_Time.Size = New System.Drawing.Size(48, 20)
        Me.MaskedTextBox_Time.TabIndex = 161
        '
        'L_Name_Time
        '
        Me.L_Name_Time.AutoSize = True
        Me.L_Name_Time.Location = New System.Drawing.Point(758, 270)
        Me.L_Name_Time.Name = "L_Name_Time"
        Me.L_Name_Time.Size = New System.Drawing.Size(30, 13)
        Me.L_Name_Time.TabIndex = 162
        Me.L_Name_Time.Text = "Time"
        '
        'B_Fill_In_Time_Start
        '
        Me.B_Fill_In_Time_Start.Location = New System.Drawing.Point(740, 313)
        Me.B_Fill_In_Time_Start.Name = "B_Fill_In_Time_Start"
        Me.B_Fill_In_Time_Start.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Time_Start.TabIndex = 164
        Me.B_Fill_In_Time_Start.Text = "Fill in start time"
        Me.B_Fill_In_Time_Start.UseVisualStyleBackColor = True
        '
        'B_Delete_Sample_From_Log
        '
        Me.B_Delete_Sample_From_Log.Location = New System.Drawing.Point(616, 394)
        Me.B_Delete_Sample_From_Log.Name = "B_Delete_Sample_From_Log"
        Me.B_Delete_Sample_From_Log.Size = New System.Drawing.Size(120, 36)
        Me.B_Delete_Sample_From_Log.TabIndex = 165
        Me.B_Delete_Sample_From_Log.Text = "Delete sample from log"
        Me.B_Delete_Sample_From_Log.UseVisualStyleBackColor = True
        '
        'Table_Received_By_BindingSource
        '
        Me.Table_Received_By_BindingSource.DataMember = "table_Received_By"
        Me.Table_Received_By_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'B_Fill_In_Irradiated_By
        '
        Me.B_Fill_In_Irradiated_By.Location = New System.Drawing.Point(821, 313)
        Me.B_Fill_In_Irradiated_By.Name = "B_Fill_In_Irradiated_By"
        Me.B_Fill_In_Irradiated_By.Size = New System.Drawing.Size(156, 36)
        Me.B_Fill_In_Irradiated_By.TabIndex = 168
        Me.B_Fill_In_Irradiated_By.Text = "Fill in irradiated by"
        Me.B_Fill_In_Irradiated_By.UseVisualStyleBackColor = True
        '
        'B_Fill_In_Measured_By
        '
        Me.B_Fill_In_Measured_By.Location = New System.Drawing.Point(249, 335)
        Me.B_Fill_In_Measured_By.Name = "B_Fill_In_Measured_By"
        Me.B_Fill_In_Measured_By.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Measured_By.TabIndex = 169
        Me.B_Fill_In_Measured_By.Text = "Fill in measured by"
        Me.B_Fill_In_Measured_By.UseVisualStyleBackColor = True
        Me.B_Fill_In_Measured_By.Visible = False
        '
        'L_Name_Sample_Set
        '
        Me.L_Name_Sample_Set.AutoSize = True
        Me.L_Name_Sample_Set.Location = New System.Drawing.Point(151, 281)
        Me.L_Name_Sample_Set.Name = "L_Name_Sample_Set"
        Me.L_Name_Sample_Set.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Sample_Set.TabIndex = 170
        Me.L_Name_Sample_Set.Text = "Sample sets"
        '
        'L_Name_Sample
        '
        Me.L_Name_Sample.AutoSize = True
        Me.L_Name_Sample.Location = New System.Drawing.Point(531, 270)
        Me.L_Name_Sample.Name = "L_Name_Sample"
        Me.L_Name_Sample.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Sample.TabIndex = 172
        Me.L_Name_Sample.Text = "Samples"
        '
        'L_Name_SRM_Set
        '
        Me.L_Name_SRM_Set.AutoSize = True
        Me.L_Name_SRM_Set.Location = New System.Drawing.Point(162, 440)
        Me.L_Name_SRM_Set.Name = "L_Name_SRM_Set"
        Me.L_Name_SRM_Set.Size = New System.Drawing.Size(53, 13)
        Me.L_Name_SRM_Set.TabIndex = 173
        Me.L_Name_SRM_Set.Text = "SRM sets"
        '
        'DataGridView_Table_SRM_Set
        '
        Me.DataGridView_Table_SRM_Set.AllowUserToAddRows = False
        Me.DataGridView_Table_SRM_Set.AllowUserToDeleteRows = False
        Me.DataGridView_Table_SRM_Set.AllowUserToResizeRows = False
        Me.DataGridView_Table_SRM_Set.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_SRM_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView_Table_SRM_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_SRM_Set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SRMSetNameDataGridViewTextBoxColumn1, Me.SRMSetNumberDataGridViewTextBoxColumn1, Me.SRMSetTypeDataGridViewTextBoxColumn, Me.SRMSetWeightDataGridViewTextBoxColumn1, Me.SRMSetPurchasingDateDataGridViewTextBoxColumn})
        Me.DataGridView_Table_SRM_Set.DataSource = Me.Table_SRM_Set_BindingSource
        Me.DataGridView_Table_SRM_Set.Location = New System.Drawing.Point(13, 456)
        Me.DataGridView_Table_SRM_Set.MultiSelect = False
        Me.DataGridView_Table_SRM_Set.Name = "DataGridView_Table_SRM_Set"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_SRM_Set.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_Table_SRM_Set.RowHeadersVisible = False
        Me.DataGridView_Table_SRM_Set.RowHeadersWidth = 21
        Me.DataGridView_Table_SRM_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_SRM_Set.Size = New System.Drawing.Size(411, 160)
        Me.DataGridView_Table_SRM_Set.TabIndex = 174
        '
        'SRMSetNameDataGridViewTextBoxColumn1
        '
        Me.SRMSetNameDataGridViewTextBoxColumn1.DataPropertyName = "SRM_Set_Name"
        Me.SRMSetNameDataGridViewTextBoxColumn1.HeaderText = "SRM_Set_Name"
        Me.SRMSetNameDataGridViewTextBoxColumn1.Name = "SRMSetNameDataGridViewTextBoxColumn1"
        Me.SRMSetNameDataGridViewTextBoxColumn1.Width = 82
        '
        'SRMSetNumberDataGridViewTextBoxColumn1
        '
        Me.SRMSetNumberDataGridViewTextBoxColumn1.DataPropertyName = "SRM_Set_Number"
        Me.SRMSetNumberDataGridViewTextBoxColumn1.HeaderText = "SRM_Set_Number"
        Me.SRMSetNumberDataGridViewTextBoxColumn1.Name = "SRMSetNumberDataGridViewTextBoxColumn1"
        Me.SRMSetNumberDataGridViewTextBoxColumn1.Width = 81
        '
        'SRMSetTypeDataGridViewTextBoxColumn
        '
        Me.SRMSetTypeDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Type"
        Me.SRMSetTypeDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Type"
        Me.SRMSetTypeDataGridViewTextBoxColumn.Name = "SRMSetTypeDataGridViewTextBoxColumn"
        Me.SRMSetTypeDataGridViewTextBoxColumn.Width = 82
        '
        'SRMSetWeightDataGridViewTextBoxColumn1
        '
        Me.SRMSetWeightDataGridViewTextBoxColumn1.DataPropertyName = "SRM_Set_Weight"
        Me.SRMSetWeightDataGridViewTextBoxColumn1.HeaderText = "SRM_Set_Weight"
        Me.SRMSetWeightDataGridViewTextBoxColumn1.Name = "SRMSetWeightDataGridViewTextBoxColumn1"
        Me.SRMSetWeightDataGridViewTextBoxColumn1.Width = 81
        '
        'SRMSetPurchasingDateDataGridViewTextBoxColumn
        '
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Purchasing_Date"
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Purchasing_Date"
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.Name = "SRMSetPurchasingDateDataGridViewTextBoxColumn"
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.Width = 82
        '
        'Table_SRM_Set_BindingSource
        '
        Me.Table_SRM_Set_BindingSource.DataMember = "table_SRM_Set"
        Me.Table_SRM_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'DataGridView_Table_SRM
        '
        Me.DataGridView_Table_SRM.AllowUserToAddRows = False
        Me.DataGridView_Table_SRM.AllowUserToDeleteRows = False
        Me.DataGridView_Table_SRM.AllowUserToResizeRows = False
        Me.DataGridView_Table_SRM.AutoGenerateColumns = False
        Me.DataGridView_Table_SRM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_SRM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView_Table_SRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_SRM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SRMSetNameDataGridViewTextBoxColumn, Me.SRMSetNumberDataGridViewTextBoxColumn, Me.SRMSetWeightDataGridViewTextBoxColumn, Me.SRMNumberDataGridViewTextBoxColumn, Me.SRMSLIWeightDataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate1DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate2DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate3DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate4DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate5DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate6DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate7DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate8DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate9DataGridViewTextBoxColumn, Me.SRMSLIIrradiationDate10DataGridViewTextBoxColumn, Me.SRMSLINotInUseDataGridViewCheckBoxColumn, Me.SRMLLIWeightDataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn, Me.SRMLLINotInUseDataGridViewCheckBoxColumn})
        Me.DataGridView_Table_SRM.DataSource = Me.Table_SRM_BindingSource
        Me.DataGridView_Table_SRM.Location = New System.Drawing.Point(594, 456)
        Me.DataGridView_Table_SRM.MultiSelect = False
        Me.DataGridView_Table_SRM.Name = "DataGridView_Table_SRM"
        Me.DataGridView_Table_SRM.RowHeadersVisible = False
        Me.DataGridView_Table_SRM.RowHeadersWidth = 21
        Me.DataGridView_Table_SRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_SRM.Size = New System.Drawing.Size(384, 160)
        Me.DataGridView_Table_SRM.TabIndex = 175
        '
        'SRMSetNameDataGridViewTextBoxColumn
        '
        Me.SRMSetNameDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Name"
        Me.SRMSetNameDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Name"
        Me.SRMSetNameDataGridViewTextBoxColumn.Name = "SRMSetNameDataGridViewTextBoxColumn"
        Me.SRMSetNameDataGridViewTextBoxColumn.Width = 124
        '
        'SRMSetNumberDataGridViewTextBoxColumn
        '
        Me.SRMSetNumberDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Number"
        Me.SRMSetNumberDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Number"
        Me.SRMSetNumberDataGridViewTextBoxColumn.Name = "SRMSetNumberDataGridViewTextBoxColumn"
        Me.SRMSetNumberDataGridViewTextBoxColumn.Width = 135
        '
        'SRMSetWeightDataGridViewTextBoxColumn
        '
        Me.SRMSetWeightDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Weight"
        Me.SRMSetWeightDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Weight"
        Me.SRMSetWeightDataGridViewTextBoxColumn.Name = "SRMSetWeightDataGridViewTextBoxColumn"
        Me.SRMSetWeightDataGridViewTextBoxColumn.Width = 132
        '
        'SRMNumberDataGridViewTextBoxColumn
        '
        Me.SRMNumberDataGridViewTextBoxColumn.DataPropertyName = "SRM_Number"
        Me.SRMNumberDataGridViewTextBoxColumn.HeaderText = "SRM_Number"
        Me.SRMNumberDataGridViewTextBoxColumn.Name = "SRMNumberDataGridViewTextBoxColumn"
        Me.SRMNumberDataGridViewTextBoxColumn.Width = 109
        '
        'SRMSLIWeightDataGridViewTextBoxColumn
        '
        Me.SRMSLIWeightDataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Weight"
        Me.SRMSLIWeightDataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Weight"
        Me.SRMSLIWeightDataGridViewTextBoxColumn.Name = "SRMSLIWeightDataGridViewTextBoxColumn"
        Me.SRMSLIWeightDataGridViewTextBoxColumn.Width = 132
        '
        'SRMSLIIrradiationDate1DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate1DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_1"
        Me.SRMSLIIrradiationDate1DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_1"
        Me.SRMSLIIrradiationDate1DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate1DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate1DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate2DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate2DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_2"
        Me.SRMSLIIrradiationDate2DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_2"
        Me.SRMSLIIrradiationDate2DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate2DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate2DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate3DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate3DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_3"
        Me.SRMSLIIrradiationDate3DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_3"
        Me.SRMSLIIrradiationDate3DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate3DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate3DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate4DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate4DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_4"
        Me.SRMSLIIrradiationDate4DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_4"
        Me.SRMSLIIrradiationDate4DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate4DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate4DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate5DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate5DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_5"
        Me.SRMSLIIrradiationDate5DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_5"
        Me.SRMSLIIrradiationDate5DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate5DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate5DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate6DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate6DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_6"
        Me.SRMSLIIrradiationDate6DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_6"
        Me.SRMSLIIrradiationDate6DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate6DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate6DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate7DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate7DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_7"
        Me.SRMSLIIrradiationDate7DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_7"
        Me.SRMSLIIrradiationDate7DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate7DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate7DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate8DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate8DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_8"
        Me.SRMSLIIrradiationDate8DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_8"
        Me.SRMSLIIrradiationDate8DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate8DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate8DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate9DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate9DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_9"
        Me.SRMSLIIrradiationDate9DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_9"
        Me.SRMSLIIrradiationDate9DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate9DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate9DataGridViewTextBoxColumn.Width = 197
        '
        'SRMSLIIrradiationDate10DataGridViewTextBoxColumn
        '
        Me.SRMSLIIrradiationDate10DataGridViewTextBoxColumn.DataPropertyName = "SRM_SLI_Irradiation_Date_10"
        Me.SRMSLIIrradiationDate10DataGridViewTextBoxColumn.HeaderText = "SRM_SLI_Irradiation_Date_10"
        Me.SRMSLIIrradiationDate10DataGridViewTextBoxColumn.Name = "SRMSLIIrradiationDate10DataGridViewTextBoxColumn"
        Me.SRMSLIIrradiationDate10DataGridViewTextBoxColumn.Width = 204
        '
        'SRMSLINotInUseDataGridViewCheckBoxColumn
        '
        Me.SRMSLINotInUseDataGridViewCheckBoxColumn.DataPropertyName = "SRM_SLI_Not_In_Use"
        Me.SRMSLINotInUseDataGridViewCheckBoxColumn.HeaderText = "SRM_SLI_Not_In_Use"
        Me.SRMSLINotInUseDataGridViewCheckBoxColumn.Name = "SRMSLINotInUseDataGridViewCheckBoxColumn"
        Me.SRMSLINotInUseDataGridViewCheckBoxColumn.Width = 140
        '
        'SRMLLIWeightDataGridViewTextBoxColumn
        '
        Me.SRMLLIWeightDataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Weight"
        Me.SRMLLIWeightDataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Weight"
        Me.SRMLLIWeightDataGridViewTextBoxColumn.Name = "SRMLLIWeightDataGridViewTextBoxColumn"
        Me.SRMLLIWeightDataGridViewTextBoxColumn.Width = 131
        '
        'SRMLLIIrradiationDate1DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_1"
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_1"
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate1DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate2DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_2"
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_2"
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate2DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate3DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_3"
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_3"
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate3DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate4DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_4"
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_4"
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate4DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate5DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_5"
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_5"
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate5DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate6DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_6"
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_6"
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate6DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate7DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_7"
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_7"
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate7DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate8DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_8"
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_8"
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate8DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate9DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_9"
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_9"
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate9DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.Width = 196
        '
        'SRMLLIIrradiationDate10DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_10"
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_10"
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate10DataGridViewTextBoxColumn"
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.Width = 203
        '
        'SRMLLINotInUseDataGridViewCheckBoxColumn
        '
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.DataPropertyName = "SRM_LLI_Not_In_Use"
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.HeaderText = "SRM_LLI_Not_In_Use"
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.Name = "SRMLLINotInUseDataGridViewCheckBoxColumn"
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.Width = 139
        '
        'Table_SRM_BindingSource
        '
        Me.Table_SRM_BindingSource.DataMember = "table_SRM"
        Me.Table_SRM_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'L_Name_SRM
        '
        Me.L_Name_SRM.AutoSize = True
        Me.L_Name_SRM.Location = New System.Drawing.Point(763, 440)
        Me.L_Name_SRM.Name = "L_Name_SRM"
        Me.L_Name_SRM.Size = New System.Drawing.Size(36, 13)
        Me.L_Name_SRM.TabIndex = 176
        Me.L_Name_SRM.Text = "SRMs"
        '
        'B_Add_SRM
        '
        Me.B_Add_SRM.Location = New System.Drawing.Point(430, 499)
        Me.B_Add_SRM.Name = "B_Add_SRM"
        Me.B_Add_SRM.Size = New System.Drawing.Size(158, 23)
        Me.B_Add_SRM.TabIndex = 177
        Me.B_Add_SRM.Text = "Add SRM"
        Me.B_Add_SRM.UseVisualStyleBackColor = True
        '
        'B_Delete_Last_Irradiation_Date_From_Log
        '
        Me.B_Delete_Last_Irradiation_Date_From_Log.Location = New System.Drawing.Point(430, 526)
        Me.B_Delete_Last_Irradiation_Date_From_Log.Name = "B_Delete_Last_Irradiation_Date_From_Log"
        Me.B_Delete_Last_Irradiation_Date_From_Log.Size = New System.Drawing.Size(158, 42)
        Me.B_Delete_Last_Irradiation_Date_From_Log.TabIndex = 178
        Me.B_Delete_Last_Irradiation_Date_From_Log.Text = "Delete last irradiation date from log"
        Me.B_Delete_Last_Irradiation_Date_From_Log.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.table_ClientTableAdapter = Nothing
        Me.TableAdapterManager.table_CountryTableAdapter = Nothing
        Me.TableAdapterManager.table_Determined_ElementsTableAdapter = Nothing
        Me.TableAdapterManager.table_LLI_Irradiation_LogTableAdapter = Nothing
        Me.TableAdapterManager.table_Monitor_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_MonitorTableAdapter = Nothing
        Me.TableAdapterManager.table_Physical_EnvironmentTableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_NAA_Results_TableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_PreparationTableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_Sample_Preparation_TableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_TableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_TypeTableAdapter = Nothing
        Me.TableAdapterManager.table_SLI_Irradiation_LogTableAdapter = Nothing
        Me.TableAdapterManager.table_SRM_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_SRMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table_Sample_TableAdapter
        '
        Me.Table_Sample_TableAdapter.ClearBeforeFill = True
        '
        'Table_Sample_Set_TableAdapter
        '
        Me.Table_Sample_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_Received_By_TableAdapter
        '
        Me.Table_Received_By_TableAdapter.ClearBeforeFill = True
        '
        'Table_SRM_Set_TableAdapter
        '
        Me.Table_SRM_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_SRM_TableAdapter
        '
        Me.Table_SRM_TableAdapter.ClearBeforeFill = True
        '
        'B_Delete_Monitor_From_Log
        '
        Me.B_Delete_Monitor_From_Log.Location = New System.Drawing.Point(430, 706)
        Me.B_Delete_Monitor_From_Log.Name = "B_Delete_Monitor_From_Log"
        Me.B_Delete_Monitor_From_Log.Size = New System.Drawing.Size(158, 42)
        Me.B_Delete_Monitor_From_Log.TabIndex = 184
        Me.B_Delete_Monitor_From_Log.Text = "Delete monitor from log"
        Me.B_Delete_Monitor_From_Log.UseVisualStyleBackColor = True
        '
        'B_Add_Monitor
        '
        Me.B_Add_Monitor.Location = New System.Drawing.Point(430, 677)
        Me.B_Add_Monitor.Name = "B_Add_Monitor"
        Me.B_Add_Monitor.Size = New System.Drawing.Size(158, 23)
        Me.B_Add_Monitor.TabIndex = 183
        Me.B_Add_Monitor.Text = "Add monitor"
        Me.B_Add_Monitor.UseVisualStyleBackColor = True
        '
        'L_Name_Monitor
        '
        Me.L_Name_Monitor.AutoSize = True
        Me.L_Name_Monitor.Location = New System.Drawing.Point(758, 622)
        Me.L_Name_Monitor.Name = "L_Name_Monitor"
        Me.L_Name_Monitor.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Monitor.TabIndex = 182
        Me.L_Name_Monitor.Text = "Monitors"
        '
        'DataGridView_Table_Monitor
        '
        Me.DataGridView_Table_Monitor.AllowUserToAddRows = False
        Me.DataGridView_Table_Monitor.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Monitor.AllowUserToResizeRows = False
        Me.DataGridView_Table_Monitor.AutoGenerateColumns = False
        Me.DataGridView_Table_Monitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Monitor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView_Table_Monitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Monitor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonitorSetNameDataGridViewTextBoxColumn1, Me.MonitorSetNumberDataGridViewTextBoxColumn1, Me.MonitorSetWeightDataGridViewTextBoxColumn1, Me.MonitorNumberDataGridViewTextBoxColumn, Me.MonitorSLIWeightDataGridViewTextBoxColumn, Me.MonitorSLIDateStartDataGridViewTextBoxColumn, Me.MonitorSLINotInUseDataGridViewCheckBoxColumn, Me.MonitorLLIWeightDataGridViewTextBoxColumn, Me.MonitorLLIDateStartDataGridViewTextBoxColumn, Me.MonitorLLINotInUseDataGridViewCheckBoxColumn})
        Me.DataGridView_Table_Monitor.DataSource = Me.Table_Monitor_BindingSource
        Me.DataGridView_Table_Monitor.Location = New System.Drawing.Point(594, 638)
        Me.DataGridView_Table_Monitor.MultiSelect = False
        Me.DataGridView_Table_Monitor.Name = "DataGridView_Table_Monitor"
        Me.DataGridView_Table_Monitor.RowHeadersVisible = False
        Me.DataGridView_Table_Monitor.RowHeadersWidth = 21
        Me.DataGridView_Table_Monitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Monitor.Size = New System.Drawing.Size(383, 158)
        Me.DataGridView_Table_Monitor.TabIndex = 181
        '
        'MonitorSetNameDataGridViewTextBoxColumn1
        '
        Me.MonitorSetNameDataGridViewTextBoxColumn1.DataPropertyName = "Monitor_Set_Name"
        Me.MonitorSetNameDataGridViewTextBoxColumn1.HeaderText = "Monitor_Set_Name"
        Me.MonitorSetNameDataGridViewTextBoxColumn1.Name = "MonitorSetNameDataGridViewTextBoxColumn1"
        Me.MonitorSetNameDataGridViewTextBoxColumn1.Width = 139
        '
        'MonitorSetNumberDataGridViewTextBoxColumn1
        '
        Me.MonitorSetNumberDataGridViewTextBoxColumn1.DataPropertyName = "Monitor_Set_Number"
        Me.MonitorSetNumberDataGridViewTextBoxColumn1.HeaderText = "Monitor_Set_Number"
        Me.MonitorSetNumberDataGridViewTextBoxColumn1.Name = "MonitorSetNumberDataGridViewTextBoxColumn1"
        Me.MonitorSetNumberDataGridViewTextBoxColumn1.Width = 150
        '
        'MonitorSetWeightDataGridViewTextBoxColumn1
        '
        Me.MonitorSetWeightDataGridViewTextBoxColumn1.DataPropertyName = "Monitor_Set_Weight"
        Me.MonitorSetWeightDataGridViewTextBoxColumn1.HeaderText = "Monitor_Set_Weight"
        Me.MonitorSetWeightDataGridViewTextBoxColumn1.Name = "MonitorSetWeightDataGridViewTextBoxColumn1"
        Me.MonitorSetWeightDataGridViewTextBoxColumn1.Width = 147
        '
        'MonitorNumberDataGridViewTextBoxColumn
        '
        Me.MonitorNumberDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Number"
        Me.MonitorNumberDataGridViewTextBoxColumn.HeaderText = "Monitor_Number"
        Me.MonitorNumberDataGridViewTextBoxColumn.Name = "MonitorNumberDataGridViewTextBoxColumn"
        Me.MonitorNumberDataGridViewTextBoxColumn.Width = 124
        '
        'MonitorSLIWeightDataGridViewTextBoxColumn
        '
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.DataPropertyName = "Monitor_SLI_Weight"
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.HeaderText = "Monitor_SLI_Weight"
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.Name = "MonitorSLIWeightDataGridViewTextBoxColumn"
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.Width = 147
        '
        'MonitorSLIDateStartDataGridViewTextBoxColumn
        '
        Me.MonitorSLIDateStartDataGridViewTextBoxColumn.DataPropertyName = "Monitor_SLI_Date_Start"
        Me.MonitorSLIDateStartDataGridViewTextBoxColumn.HeaderText = "Monitor_SLI_Date_Start"
        Me.MonitorSLIDateStartDataGridViewTextBoxColumn.Name = "MonitorSLIDateStartDataGridViewTextBoxColumn"
        Me.MonitorSLIDateStartDataGridViewTextBoxColumn.Width = 168
        '
        'MonitorSLINotInUseDataGridViewCheckBoxColumn
        '
        Me.MonitorSLINotInUseDataGridViewCheckBoxColumn.DataPropertyName = "Monitor_SLI_Not_In_Use"
        Me.MonitorSLINotInUseDataGridViewCheckBoxColumn.HeaderText = "Monitor_SLI_Not_In_Use"
        Me.MonitorSLINotInUseDataGridViewCheckBoxColumn.Name = "MonitorSLINotInUseDataGridViewCheckBoxColumn"
        Me.MonitorSLINotInUseDataGridViewCheckBoxColumn.Width = 155
        '
        'MonitorLLIWeightDataGridViewTextBoxColumn
        '
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.DataPropertyName = "Monitor_LLI_Weight"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.HeaderText = "Monitor_LLI_Weight"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.Name = "MonitorLLIWeightDataGridViewTextBoxColumn"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.Width = 146
        '
        'MonitorLLIDateStartDataGridViewTextBoxColumn
        '
        Me.MonitorLLIDateStartDataGridViewTextBoxColumn.DataPropertyName = "Monitor_LLI_Date_Start"
        Me.MonitorLLIDateStartDataGridViewTextBoxColumn.HeaderText = "Monitor_LLI_Date_Start"
        Me.MonitorLLIDateStartDataGridViewTextBoxColumn.Name = "MonitorLLIDateStartDataGridViewTextBoxColumn"
        Me.MonitorLLIDateStartDataGridViewTextBoxColumn.Width = 167
        '
        'MonitorLLINotInUseDataGridViewCheckBoxColumn
        '
        Me.MonitorLLINotInUseDataGridViewCheckBoxColumn.DataPropertyName = "Monitor_LLI_Not_In_Use"
        Me.MonitorLLINotInUseDataGridViewCheckBoxColumn.HeaderText = "Monitor_LLI_Not_In_Use"
        Me.MonitorLLINotInUseDataGridViewCheckBoxColumn.Name = "MonitorLLINotInUseDataGridViewCheckBoxColumn"
        Me.MonitorLLINotInUseDataGridViewCheckBoxColumn.Width = 154
        '
        'Table_Monitor_BindingSource
        '
        Me.Table_Monitor_BindingSource.DataMember = "table_Monitor"
        Me.Table_Monitor_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'DataGridView_Table_Monitor_Set
        '
        Me.DataGridView_Table_Monitor_Set.AllowUserToAddRows = False
        Me.DataGridView_Table_Monitor_Set.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Monitor_Set.AllowUserToResizeRows = False
        Me.DataGridView_Table_Monitor_Set.AutoGenerateColumns = False
        Me.DataGridView_Table_Monitor_Set.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Monitor_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_Table_Monitor_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Monitor_Set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonitorSetNameDataGridViewTextBoxColumn, Me.MonitorSetNumberDataGridViewTextBoxColumn, Me.MonitorSetTypeDataGridViewTextBoxColumn, Me.MonitorSetWeightDataGridViewTextBoxColumn, Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn})
        Me.DataGridView_Table_Monitor_Set.DataSource = Me.Table_Monitor_Set_BindingSource
        Me.DataGridView_Table_Monitor_Set.Location = New System.Drawing.Point(12, 638)
        Me.DataGridView_Table_Monitor_Set.MultiSelect = False
        Me.DataGridView_Table_Monitor_Set.Name = "DataGridView_Table_Monitor_Set"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Monitor_Set.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView_Table_Monitor_Set.RowHeadersVisible = False
        Me.DataGridView_Table_Monitor_Set.RowHeadersWidth = 21
        Me.DataGridView_Table_Monitor_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Monitor_Set.Size = New System.Drawing.Size(412, 165)
        Me.DataGridView_Table_Monitor_Set.TabIndex = 180
        '
        'MonitorSetNameDataGridViewTextBoxColumn
        '
        Me.MonitorSetNameDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Name"
        Me.MonitorSetNameDataGridViewTextBoxColumn.HeaderText = "Monitor_Set_Name"
        Me.MonitorSetNameDataGridViewTextBoxColumn.Name = "MonitorSetNameDataGridViewTextBoxColumn"
        '
        'MonitorSetNumberDataGridViewTextBoxColumn
        '
        Me.MonitorSetNumberDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Number"
        Me.MonitorSetNumberDataGridViewTextBoxColumn.HeaderText = "Monitor_Set_Number"
        Me.MonitorSetNumberDataGridViewTextBoxColumn.Name = "MonitorSetNumberDataGridViewTextBoxColumn"
        '
        'MonitorSetTypeDataGridViewTextBoxColumn
        '
        Me.MonitorSetTypeDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Type"
        Me.MonitorSetTypeDataGridViewTextBoxColumn.HeaderText = "Monitor_Set_Type"
        Me.MonitorSetTypeDataGridViewTextBoxColumn.Name = "MonitorSetTypeDataGridViewTextBoxColumn"
        '
        'MonitorSetWeightDataGridViewTextBoxColumn
        '
        Me.MonitorSetWeightDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Weight"
        Me.MonitorSetWeightDataGridViewTextBoxColumn.HeaderText = "Monitor_Set_Weight"
        Me.MonitorSetWeightDataGridViewTextBoxColumn.Name = "MonitorSetWeightDataGridViewTextBoxColumn"
        '
        'MonitorSetPurchasingDateDataGridViewTextBoxColumn
        '
        Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Purchasing_Date"
        Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn.HeaderText = "Monitor_Set_Purchasing_Date"
        Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn.Name = "MonitorSetPurchasingDateDataGridViewTextBoxColumn"
        '
        'Table_Monitor_Set_BindingSource
        '
        Me.Table_Monitor_Set_BindingSource.DataMember = "table_Monitor_Set"
        Me.Table_Monitor_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'L_Name_Monitor_Set
        '
        Me.L_Name_Monitor_Set.AutoSize = True
        Me.L_Name_Monitor_Set.Location = New System.Drawing.Point(151, 622)
        Me.L_Name_Monitor_Set.Name = "L_Name_Monitor_Set"
        Me.L_Name_Monitor_Set.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Monitor_Set.TabIndex = 179
        Me.L_Name_Monitor_Set.Text = "Monitor sets"
        '
        'Table_Monitor_Set_TableAdapter
        '
        Me.Table_Monitor_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_Monitor_TableAdapter
        '
        Me.Table_Monitor_TableAdapter.ClearBeforeFill = True
        '
        'Table_SLI_Irradiation_Log_TableAdapter
        '
        Me.Table_SLI_Irradiation_Log_TableAdapter.ClearBeforeFill = True
        '
        'Table_Sample_BindingSource
        '
        Me.Table_Sample_BindingSource.DataMember = "table_Sample"
        Me.Table_Sample_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'B_Set_Monitor_As_Not_In_Use
        '
        Me.B_Set_Monitor_As_Not_In_Use.Location = New System.Drawing.Point(430, 754)
        Me.B_Set_Monitor_As_Not_In_Use.Name = "B_Set_Monitor_As_Not_In_Use"
        Me.B_Set_Monitor_As_Not_In_Use.Size = New System.Drawing.Size(158, 42)
        Me.B_Set_Monitor_As_Not_In_Use.TabIndex = 185
        Me.B_Set_Monitor_As_Not_In_Use.Text = "Set monitor as not in use"
        Me.B_Set_Monitor_As_Not_In_Use.UseVisualStyleBackColor = True
        '
        'B_Set_SRM_As_Not_In_Use
        '
        Me.B_Set_SRM_As_Not_In_Use.Location = New System.Drawing.Point(430, 574)
        Me.B_Set_SRM_As_Not_In_Use.Name = "B_Set_SRM_As_Not_In_Use"
        Me.B_Set_SRM_As_Not_In_Use.Size = New System.Drawing.Size(158, 42)
        Me.B_Set_SRM_As_Not_In_Use.TabIndex = 186
        Me.B_Set_SRM_As_Not_In_Use.Text = "Set SRM as not in use"
        Me.B_Set_SRM_As_Not_In_Use.UseVisualStyleBackColor = True
        '
        'B_Find_Sample_Set
        '
        Me.B_Find_Sample_Set.Location = New System.Drawing.Point(236, 394)
        Me.B_Find_Sample_Set.Name = "B_Find_Sample_Set"
        Me.B_Find_Sample_Set.Size = New System.Drawing.Size(104, 23)
        Me.B_Find_Sample_Set.TabIndex = 187
        Me.B_Find_Sample_Set.Text = "Find sample set"
        Me.B_Find_Sample_Set.UseVisualStyleBackColor = True
        Me.B_Find_Sample_Set.Visible = False
        '
        'B_Fill_In_Channel
        '
        Me.B_Fill_In_Channel.Location = New System.Drawing.Point(821, 394)
        Me.B_Fill_In_Channel.Name = "B_Fill_In_Channel"
        Me.B_Fill_In_Channel.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Channel.TabIndex = 192
        Me.B_Fill_In_Channel.Text = "Fill in channel"
        Me.B_Fill_In_Channel.UseVisualStyleBackColor = True
        '
        'L_Name_Channel
        '
        Me.L_Name_Channel.AutoSize = True
        Me.L_Name_Channel.Location = New System.Drawing.Point(834, 352)
        Me.L_Name_Channel.Name = "L_Name_Channel"
        Me.L_Name_Channel.Size = New System.Drawing.Size(46, 13)
        Me.L_Name_Channel.TabIndex = 191
        Me.L_Name_Channel.Text = "Channel"
        '
        'ComboBox_Channel
        '
        Me.ComboBox_Channel.FormattingEnabled = True
        Me.ComboBox_Channel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox_Channel.Location = New System.Drawing.Point(837, 368)
        Me.ComboBox_Channel.Name = "ComboBox_Channel"
        Me.ComboBox_Channel.Size = New System.Drawing.Size(43, 21)
        Me.ComboBox_Channel.TabIndex = 193
        Me.ComboBox_Channel.Text = "2"
        '
        'B_Fill_In_Duration
        '
        Me.B_Fill_In_Duration.Location = New System.Drawing.Point(902, 394)
        Me.B_Fill_In_Duration.Name = "B_Fill_In_Duration"
        Me.B_Fill_In_Duration.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Duration.TabIndex = 195
        Me.B_Fill_In_Duration.Text = "Fill in duration"
        Me.B_Fill_In_Duration.UseVisualStyleBackColor = True
        '
        'L_Name_Duration
        '
        Me.L_Name_Duration.AutoSize = True
        Me.L_Name_Duration.Location = New System.Drawing.Point(899, 351)
        Me.L_Name_Duration.Name = "L_Name_Duration"
        Me.L_Name_Duration.Size = New System.Drawing.Size(70, 13)
        Me.L_Name_Duration.TabIndex = 194
        Me.L_Name_Duration.Text = "Duration, sec"
        '
        'TextBox_Duration
        '
        Me.TextBox_Duration.Location = New System.Drawing.Point(918, 368)
        Me.TextBox_Duration.Name = "TextBox_Duration"
        Me.TextBox_Duration.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Duration.TabIndex = 196
        '
        'B_Save_And_Update_SLI
        '
        Me.B_Save_And_Update_SLI.Location = New System.Drawing.Point(278, 811)
        Me.B_Save_And_Update_SLI.Name = "B_Save_And_Update_SLI"
        Me.B_Save_And_Update_SLI.Size = New System.Drawing.Size(213, 23)
        Me.B_Save_And_Update_SLI.TabIndex = 197
        Me.B_Save_And_Update_SLI.Text = "Save and update SLI"
        Me.B_Save_And_Update_SLI.UseVisualStyleBackColor = True
        '
        'ComboBox_Person
        '
        Me.ComboBox_Person.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table_Received_By_BindingSource, "Received_By", True))
        Me.ComboBox_Person.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Table_Received_By_BindingSource, "Received_By", True))
        Me.ComboBox_Person.DataSource = Me.Table_Received_By_BindingSource
        Me.ComboBox_Person.DisplayMember = "Received_By"
        Me.ComboBox_Person.FormattingEnabled = True
        Me.ComboBox_Person.Location = New System.Drawing.Point(821, 288)
        Me.ComboBox_Person.Name = "ComboBox_Person"
        Me.ComboBox_Person.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Person.TabIndex = 166
        Me.ComboBox_Person.ValueMember = "Received_By"
        '
        'ComboBox_Sample_Set_View
        '
        Me.ComboBox_Sample_Set_View.FormattingEnabled = True
        Me.ComboBox_Sample_Set_View.Items.AddRange(New Object() {"All sample sets", "Sample sets from log"})
        Me.ComboBox_Sample_Set_View.Location = New System.Drawing.Point(374, 407)
        Me.ComboBox_Sample_Set_View.Name = "ComboBox_Sample_Set_View"
        Me.ComboBox_Sample_Set_View.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Sample_Set_View.TabIndex = 198
        '
        'L_Monitor
        '
        Me.L_Monitor.Location = New System.Drawing.Point(378, 273)
        Me.L_Monitor.Name = "L_Monitor"
        Me.L_Monitor.Size = New System.Drawing.Size(117, 115)
        Me.L_Monitor.TabIndex = 199
        Me.L_Monitor.Text = "M"
        '
        'ComboBox_SRM_Set_View
        '
        Me.ComboBox_SRM_Set_View.FormattingEnabled = True
        Me.ComboBox_SRM_Set_View.Location = New System.Drawing.Point(430, 472)
        Me.ComboBox_SRM_Set_View.Name = "ComboBox_SRM_Set_View"
        Me.ComboBox_SRM_Set_View.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox_SRM_Set_View.TabIndex = 267
        '
        'ComboBox_Monitor_Set_View
        '
        Me.ComboBox_Monitor_Set_View.FormattingEnabled = True
        Me.ComboBox_Monitor_Set_View.Location = New System.Drawing.Point(430, 650)
        Me.ComboBox_Monitor_Set_View.Name = "ComboBox_Monitor_Set_View"
        Me.ComboBox_Monitor_Set_View.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox_Monitor_Set_View.TabIndex = 269
        '
        'Button_Auto_Fill_In_Irradiation_Start_Time
        '
        Me.Button_Auto_Fill_In_Irradiation_Start_Time.Location = New System.Drawing.Point(616, 351)
        Me.Button_Auto_Fill_In_Irradiation_Start_Time.Name = "Button_Auto_Fill_In_Irradiation_Start_Time"
        Me.Button_Auto_Fill_In_Irradiation_Start_Time.Size = New System.Drawing.Size(120, 34)
        Me.Button_Auto_Fill_In_Irradiation_Start_Time.TabIndex = 270
        Me.Button_Auto_Fill_In_Irradiation_Start_Time.Text = "Auto fill in irradiation start time"
        Me.Button_Auto_Fill_In_Irradiation_Start_Time.UseVisualStyleBackColor = True
        '
        'Button_Save_SLI_Log_To_File
        '
        Me.Button_Save_SLI_Log_To_File.Location = New System.Drawing.Point(772, 10)
        Me.Button_Save_SLI_Log_To_File.Name = "Button_Save_SLI_Log_To_File"
        Me.Button_Save_SLI_Log_To_File.Size = New System.Drawing.Size(205, 23)
        Me.Button_Save_SLI_Log_To_File.TabIndex = 271
        Me.Button_Save_SLI_Log_To_File.Text = "Save SLI log to file"
        Me.Button_Save_SLI_Log_To_File.UseVisualStyleBackColor = True
        '
        'SaveFileDialog_SLI
        '
        Me.SaveFileDialog_SLI.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        '
        'TextBox_Spectrum_File
        '
        Me.TextBox_Spectrum_File.Location = New System.Drawing.Point(742, 368)
        Me.TextBox_Spectrum_File.Name = "TextBox_Spectrum_File"
        Me.TextBox_Spectrum_File.Size = New System.Drawing.Size(73, 20)
        Me.TextBox_Spectrum_File.TabIndex = 274
        '
        'B_Fill_In_Spectrum_File
        '
        Me.B_Fill_In_Spectrum_File.Location = New System.Drawing.Point(742, 394)
        Me.B_Fill_In_Spectrum_File.Name = "B_Fill_In_Spectrum_File"
        Me.B_Fill_In_Spectrum_File.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Spectrum_File.TabIndex = 273
        Me.B_Fill_In_Spectrum_File.Text = "Fill in spectrum file"
        Me.B_Fill_In_Spectrum_File.UseVisualStyleBackColor = True
        '
        'L_Name_Spectrum_File
        '
        Me.L_Name_Spectrum_File.AutoSize = True
        Me.L_Name_Spectrum_File.Location = New System.Drawing.Point(739, 352)
        Me.L_Name_Spectrum_File.Name = "L_Name_Spectrum_File"
        Me.L_Name_Spectrum_File.Size = New System.Drawing.Size(68, 13)
        Me.L_Name_Spectrum_File.TabIndex = 272
        Me.L_Name_Spectrum_File.Text = "Spectrum file"
        '
        'L_Name_Sample_All_SLI_Weight
        '
        Me.L_Name_Sample_All_SLI_Weight.AutoSize = True
        Me.L_Name_Sample_All_SLI_Weight.Location = New System.Drawing.Point(621, 273)
        Me.L_Name_Sample_All_SLI_Weight.Name = "L_Name_Sample_All_SLI_Weight"
        Me.L_Name_Sample_All_SLI_Weight.Size = New System.Drawing.Size(107, 13)
        Me.L_Name_Sample_All_SLI_Weight.TabIndex = 278
        Me.L_Name_Sample_All_SLI_Weight.Text = "Samples's SLI weight"
        '
        'ListBox_Sample_ID_All_SLI_Weight
        '
        Me.ListBox_Sample_ID_All_SLI_Weight.FormattingEnabled = True
        Me.ListBox_Sample_ID_All_SLI_Weight.Location = New System.Drawing.Point(624, 289)
        Me.ListBox_Sample_ID_All_SLI_Weight.Name = "ListBox_Sample_ID_All_SLI_Weight"
        Me.ListBox_Sample_ID_All_SLI_Weight.Size = New System.Drawing.Size(105, 56)
        Me.ListBox_Sample_ID_All_SLI_Weight.TabIndex = 277
        '
        'TextBox_Paper_Log_Number
        '
        Me.TextBox_Paper_Log_Number.Location = New System.Drawing.Point(99, 368)
        Me.TextBox_Paper_Log_Number.Name = "TextBox_Paper_Log_Number"
        Me.TextBox_Paper_Log_Number.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Paper_Log_Number.TabIndex = 281
        Me.TextBox_Paper_Log_Number.Visible = False
        '
        'Button_Paper_Log_Number
        '
        Me.Button_Paper_Log_Number.Location = New System.Drawing.Point(83, 394)
        Me.Button_Paper_Log_Number.Name = "Button_Paper_Log_Number"
        Me.Button_Paper_Log_Number.Size = New System.Drawing.Size(75, 36)
        Me.Button_Paper_Log_Number.TabIndex = 280
        Me.Button_Paper_Log_Number.Text = "Fill in paper log number"
        Me.Button_Paper_Log_Number.UseVisualStyleBackColor = True
        Me.Button_Paper_Log_Number.Visible = False
        '
        'L_Name_Paper_Log_Number
        '
        Me.L_Name_Paper_Log_Number.AutoSize = True
        Me.L_Name_Paper_Log_Number.Location = New System.Drawing.Point(91, 352)
        Me.L_Name_Paper_Log_Number.Name = "L_Name_Paper_Log_Number"
        Me.L_Name_Paper_Log_Number.Size = New System.Drawing.Size(66, 13)
        Me.L_Name_Paper_Log_Number.TabIndex = 279
        Me.L_Name_Paper_Log_Number.Text = "Paper log №"
        Me.L_Name_Paper_Log_Number.Visible = False
        '
        'L_Name_Person
        '
        Me.L_Name_Person.AutoSize = True
        Me.L_Name_Person.Location = New System.Drawing.Point(867, 270)
        Me.L_Name_Person.Name = "L_Name_Person"
        Me.L_Name_Person.Size = New System.Drawing.Size(40, 13)
        Me.L_Name_Person.TabIndex = 283
        Me.L_Name_Person.Text = "Person"
        '
        'L_Name_SRM_Set_View
        '
        Me.L_Name_SRM_Set_View.AutoSize = True
        Me.L_Name_SRM_Set_View.Location = New System.Drawing.Point(447, 456)
        Me.L_Name_SRM_Set_View.Name = "L_Name_SRM_Set_View"
        Me.L_Name_SRM_Set_View.Size = New System.Drawing.Size(78, 13)
        Me.L_Name_SRM_Set_View.TabIndex = 284
        Me.L_Name_SRM_Set_View.Text = "SRM sets view"
        '
        'L_Name_Monitor_Set_View
        '
        Me.L_Name_Monitor_Set_View.AutoSize = True
        Me.L_Name_Monitor_Set_View.Location = New System.Drawing.Point(460, 634)
        Me.L_Name_Monitor_Set_View.Name = "L_Name_Monitor_Set_View"
        Me.L_Name_Monitor_Set_View.Size = New System.Drawing.Size(89, 13)
        Me.L_Name_Monitor_Set_View.TabIndex = 285
        Me.L_Name_Monitor_Set_View.Text = "Monitor sets view"
        '
        'L_Name_Sample_Set_View
        '
        Me.L_Name_Sample_Set_View.AutoSize = True
        Me.L_Name_Sample_Set_View.Location = New System.Drawing.Point(378, 388)
        Me.L_Name_Sample_Set_View.Name = "L_Name_Sample_Set_View"
        Me.L_Name_Sample_Set_View.Size = New System.Drawing.Size(89, 13)
        Me.L_Name_Sample_Set_View.TabIndex = 286
        Me.L_Name_Sample_Set_View.Text = "Sample sets view"
        '
        'ButtonSaveSpectra
        '
        Me.ButtonSaveSpectra.Location = New System.Drawing.Point(624, 10)
        Me.ButtonSaveSpectra.Name = "ButtonSaveSpectra"
        Me.ButtonSaveSpectra.Size = New System.Drawing.Size(142, 23)
        Me.ButtonSaveSpectra.TabIndex = 290
        Me.ButtonSaveSpectra.Text = "Save Spectra"
        Me.ButtonSaveSpectra.UseVisualStyleBackColor = True
        '
        'Form_SLI_Irradiation_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 837)
        Me.Controls.Add(Me.ButtonSaveSpectra)
        Me.Controls.Add(Me.L_Name_Sample_Set_View)
        Me.Controls.Add(Me.L_Name_Monitor_Set_View)
        Me.Controls.Add(Me.L_Name_SRM_Set_View)
        Me.Controls.Add(Me.L_Name_Person)
        Me.Controls.Add(Me.B_Fill_In_Measured_By)
        Me.Controls.Add(Me.TextBox_Paper_Log_Number)
        Me.Controls.Add(Me.Button_Paper_Log_Number)
        Me.Controls.Add(Me.L_Name_Paper_Log_Number)
        Me.Controls.Add(Me.L_Name_Sample_All_SLI_Weight)
        Me.Controls.Add(Me.ListBox_Sample_ID_All_SLI_Weight)
        Me.Controls.Add(Me.TextBox_Spectrum_File)
        Me.Controls.Add(Me.B_Fill_In_Spectrum_File)
        Me.Controls.Add(Me.L_Name_Spectrum_File)
        Me.Controls.Add(Me.Button_Save_SLI_Log_To_File)
        Me.Controls.Add(Me.Button_Auto_Fill_In_Irradiation_Start_Time)
        Me.Controls.Add(Me.ComboBox_Monitor_Set_View)
        Me.Controls.Add(Me.ComboBox_SRM_Set_View)
        Me.Controls.Add(Me.L_Monitor)
        Me.Controls.Add(Me.ComboBox_Sample_Set_View)
        Me.Controls.Add(Me.B_Save_And_Update_SLI)
        Me.Controls.Add(Me.TextBox_Duration)
        Me.Controls.Add(Me.B_Fill_In_Duration)
        Me.Controls.Add(Me.L_Name_Duration)
        Me.Controls.Add(Me.ComboBox_Channel)
        Me.Controls.Add(Me.B_Fill_In_Channel)
        Me.Controls.Add(Me.L_Name_Channel)
        Me.Controls.Add(Me.B_Find_Sample_Set)
        Me.Controls.Add(Me.B_Set_SRM_As_Not_In_Use)
        Me.Controls.Add(Me.B_Set_Monitor_As_Not_In_Use)
        Me.Controls.Add(Me.B_Delete_Monitor_From_Log)
        Me.Controls.Add(Me.B_Add_Monitor)
        Me.Controls.Add(Me.L_Name_Monitor)
        Me.Controls.Add(Me.DataGridView_Table_Monitor)
        Me.Controls.Add(Me.DataGridView_Table_Monitor_Set)
        Me.Controls.Add(Me.L_Name_Monitor_Set)
        Me.Controls.Add(Me.B_Delete_Last_Irradiation_Date_From_Log)
        Me.Controls.Add(Me.B_Add_SRM)
        Me.Controls.Add(Me.L_Name_SRM)
        Me.Controls.Add(Me.DataGridView_Table_SRM)
        Me.Controls.Add(Me.DataGridView_Table_SRM_Set)
        Me.Controls.Add(Me.L_Name_SRM_Set)
        Me.Controls.Add(Me.L_Name_Sample)
        Me.Controls.Add(Me.L_Name_Sample_Set)
        Me.Controls.Add(Me.B_Fill_In_Irradiated_By)
        Me.Controls.Add(Me.ComboBox_Person)
        Me.Controls.Add(Me.B_Delete_Sample_From_Log)
        Me.Controls.Add(Me.B_Fill_In_Time_Start)
        Me.Controls.Add(Me.L_Name_Time)
        Me.Controls.Add(Me.MaskedTextBox_Time)
        Me.Controls.Add(Me.B_Add_Sample)
        Me.Controls.Add(Me.ListBox_Sample_ID)
        Me.Controls.Add(Me.DataGridView_SLI_Sample_Set)
        Me.Controls.Add(Me.MaskedTextBox_SLI_Irradiation_Log)
        Me.Controls.Add(Me.L_Name_SLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.DataGridView_SLI_Irradiation_Log)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_SLI_Irradiation_Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLI irradiation log"
        CType(Me.DataGridView_SLI_Irradiation_Log, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SLI_Irradiation_Log_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_SLI_Sample_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_SRM_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_SRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_Monitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_Monitor_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents DataGridView_SLI_Irradiation_Log As System.Windows.Forms.DataGridView
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents L_Name_SLI_Irradiation_Log As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_SLI_Irradiation_Log As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView_SLI_Sample_Set As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox_Sample_ID As System.Windows.Forms.ListBox
    Friend WithEvents B_Add_Sample As System.Windows.Forms.Button
    Friend WithEvents Table_Sample_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Sample_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_TableAdapter
    Friend WithEvents Table_Sample_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Sample_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter
    Friend WithEvents MaskedTextBox_Time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_Time As System.Windows.Forms.Label
    Friend WithEvents B_Fill_In_Time_Start As System.Windows.Forms.Button
    Friend WithEvents ISLIPositionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISLIMeasurementsQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B_Delete_Sample_From_Log As System.Windows.Forms.Button
    Friend WithEvents Table_Received_By_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Received_By_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter
    Friend WithEvents B_Fill_In_Irradiated_By As System.Windows.Forms.Button
    Friend WithEvents B_Fill_In_Measured_By As System.Windows.Forms.Button
    Friend WithEvents L_Name_Sample_Set As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample As System.Windows.Forms.Label
    Friend WithEvents L_Name_SRM_Set As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Table_SRM_Set As System.Windows.Forms.DataGridView
    Friend WithEvents Table_SRM_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter
    Friend WithEvents DataGridView_Table_SRM As System.Windows.Forms.DataGridView
    Friend WithEvents L_Name_SRM As System.Windows.Forms.Label
    Friend WithEvents Table_SRM_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter
    Friend WithEvents B_Add_SRM As System.Windows.Forms.Button
    Friend WithEvents B_Delete_Last_Irradiation_Date_From_Log As System.Windows.Forms.Button
    Friend WithEvents B_Delete_Monitor_From_Log As System.Windows.Forms.Button
    Friend WithEvents B_Add_Monitor As System.Windows.Forms.Button
    Friend WithEvents L_Name_Monitor As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Table_Monitor As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView_Table_Monitor_Set As System.Windows.Forms.DataGridView
    Friend WithEvents L_Name_Monitor_Set As System.Windows.Forms.Label
    Friend WithEvents Table_Monitor_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Monitor_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter
    Friend WithEvents MonitorSetNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetPurchasingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table_Monitor_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Monitor_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_MonitorTableAdapter
    Friend WithEvents Table_SLI_Irradiation_Log_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SLI_Irradiation_Log_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SLI_Irradiation_LogTableAdapter
    Friend WithEvents B_Set_Monitor_As_Not_In_Use As System.Windows.Forms.Button
    Friend WithEvents B_Set_SRM_As_Not_In_Use As System.Windows.Forms.Button
    Friend WithEvents B_Find_Sample_Set As System.Windows.Forms.Button
    Friend WithEvents B_Fill_In_Channel As System.Windows.Forms.Button
    Friend WithEvents L_Name_Channel As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Channel As System.Windows.Forms.ComboBox
    Friend WithEvents B_Fill_In_Duration As System.Windows.Forms.Button
    Friend WithEvents L_Name_Duration As System.Windows.Forms.Label
    Friend WithEvents TextBox_Duration As System.Windows.Forms.TextBox
    Friend WithEvents B_Save_And_Update_SLI As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Person As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Sample_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents L_Monitor As System.Windows.Forms.Label
    Friend WithEvents ComboBox_SRM_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Monitor_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Auto_Fill_In_Irradiation_Start_Time As System.Windows.Forms.Button
    Friend WithEvents Button_Save_SLI_Log_To_File As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_SLI As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox_Spectrum_File As System.Windows.Forms.TextBox
    Friend WithEvents B_Fill_In_Spectrum_File As System.Windows.Forms.Button
    Friend WithEvents L_Name_Spectrum_File As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample_All_SLI_Weight As System.Windows.Forms.Label
    Friend WithEvents ListBox_Sample_ID_All_SLI_Weight As System.Windows.Forms.ListBox
    Friend WithEvents TextBox_Paper_Log_Number As System.Windows.Forms.TextBox
    Friend WithEvents Button_Paper_Log_Number As System.Windows.Forms.Button
    Friend WithEvents L_Name_Paper_Log_Number As System.Windows.Forms.Label
    Friend WithEvents CountryCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetReceiptDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetReportDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceivedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetWeightDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetPurchasingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLIIrradiationDate10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSLINotInUseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SRMLLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLIIrradiationDate10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMLLINotInUseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MonitorSetNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetWeightDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSLIDateStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSLINotInUseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MonitorLLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorLLIDateStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorLLINotInUseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents L_Name_Person As System.Windows.Forms.Label
    Friend WithEvents L_Name_SRM_Set_View As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set_View As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample_Set_View As System.Windows.Forms.Label
    Friend WithEvents CountryCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIndexDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SampleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateStartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeStartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChannelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Detector2DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Detector3DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Detector4DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FileLastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IrradiatedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeasuredByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaperLogNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Detector1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileFirstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSaveSpectra As Button
    Friend WithEvents FolderBrowserDialogSaveSpectra As FolderBrowserDialog
End Class
