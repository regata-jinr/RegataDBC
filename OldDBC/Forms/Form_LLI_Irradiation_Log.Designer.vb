<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_LLI_Irradiation_Log
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_LLI_Irradiation_Log))
        Me.ComboBox_Sample_Set_View = New System.Windows.Forms.ComboBox()
        Me.B_Find_Sample_Set = New System.Windows.Forms.Button()
        Me.B_Set_SRM_As_Not_In_Use = New System.Windows.Forms.Button()
        Me.B_Set_Monitor_As_Not_In_Use = New System.Windows.Forms.Button()
        Me.B_Delete_Monitor_From_Log = New System.Windows.Forms.Button()
        Me.B_Add_Monitor = New System.Windows.Forms.Button()
        Me.L_Name_Monitor = New System.Windows.Forms.Label()
        Me.DataGridView_Table_Monitor = New System.Windows.Forms.DataGridView()
        Me.MonitorNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorLLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monitor_LLI_Date_Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Monitor_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.DataGridView_Table_Monitor_Set = New System.Windows.Forms.DataGridView()
        Me.MonitorSetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Monitor_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Name_Monitor_Set = New System.Windows.Forms.Label()
        Me.B_Delete_Last_Irradiation_Date_From_Log = New System.Windows.Forms.Button()
        Me.B_Add_SRM = New System.Windows.Forms.Button()
        Me.L_Name_SRM = New System.Windows.Forms.Label()
        Me.DataGridView_Table_SRM = New System.Windows.Forms.DataGridView()
        Me.SRM_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridView_Table_SRM_Set = New System.Windows.Forms.DataGridView()
        Me.SRMSetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_SRM_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Name_SRM_Set = New System.Windows.Forms.Label()
        Me.L_Name_Sample = New System.Windows.Forms.Label()
        Me.L_Name_Sample_Set = New System.Windows.Forms.Label()
        Me.ComboBox_Person = New System.Windows.Forms.ComboBox()
        Me.Table_Received_By_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_Delete_Sample_From_Log = New System.Windows.Forms.Button()
        Me.L_Name_Time = New System.Windows.Forms.Label()
        Me.MaskedTextBox_Time = New System.Windows.Forms.MaskedTextBox()
        Me.B_Add_Sample = New System.Windows.Forms.Button()
        Me.ListBox_Sample_ID = New System.Windows.Forms.ListBox()
        Me.DataGridView_LLI_Sample_Set = New System.Windows.Forms.DataGridView()
        Me.CountryCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIndexDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Sample_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox_LLI_Irradiation_Log = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_LLI_Irradiation_Log = New System.Windows.Forms.Label()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.DataGridView_LLI_Irradiation_Log = New System.Windows.Forms.DataGridView()
        Me.CountryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleSetIndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChannelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFinishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeFinishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefDateStart1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefTimeStart1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefDateFinish1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefTimeFinish1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefDateStart2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefTimeStart2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefDateFinish2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowerReliefTimeFinish2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContainerNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IrradiatedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRehadleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RehandledByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMeasurementLLI1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detector2MeasurementLLI1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Detector3MeasurementLLI1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Detector4MeasurementLLI1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PaperLogLLI1NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeasuredLLI1ByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMeasurementLLI2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detector2MeasurementLLI2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Detector3MeasurementLLI2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Detector4MeasurementLLI2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PaperLogLLI2NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeasuredLLI2ByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_LLI_Irradiation_Log_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_LLI_Irradiation_Log_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_LLI_Irradiation_LogTableAdapter()
        Me.Table_Received_By_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter()
        Me.Table_Sample_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter()
        Me.Table_SRM_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter()
        Me.Table_Monitor_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter()
        Me.Table_SRM_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter()
        Me.Table_Monitor_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_MonitorTableAdapter()
        Me.MaskedTextBox_Date = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_Date = New System.Windows.Forms.Label()
        Me.ComboBox_Date_Field_Name = New System.Windows.Forms.ComboBox()
        Me.B_Fill_In_Date = New System.Windows.Forms.Button()
        Me.B_Fill_In_Time = New System.Windows.Forms.Button()
        Me.ComboBox_Time_Field_Name = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Person_Field_Name = New System.Windows.Forms.ComboBox()
        Me.B_Fill_In_Person = New System.Windows.Forms.Button()
        Me.B_Save_And_Update_LLI = New System.Windows.Forms.Button()
        Me.TextBox_Container_Number = New System.Windows.Forms.TextBox()
        Me.B_Fill_In_Container_Number = New System.Windows.Forms.Button()
        Me.L_Name_Container_Number = New System.Windows.Forms.Label()
        Me.ComboBox_Channel = New System.Windows.Forms.ComboBox()
        Me.B_Fill_In_Channel = New System.Windows.Forms.Button()
        Me.L_Name_Channel = New System.Windows.Forms.Label()
        Me.TextBox_Paper_Log_LLI2 = New System.Windows.Forms.TextBox()
        Me.Button_Paper_Log_LLI2 = New System.Windows.Forms.Button()
        Me.L_Name_Paper_Log_LLI2 = New System.Windows.Forms.Label()
        Me.Button_Paper_Log_LLI1 = New System.Windows.Forms.Button()
        Me.L_Name_Paper_Log_LLI1 = New System.Windows.Forms.Label()
        Me.TextBox_Paper_Log_LLI1 = New System.Windows.Forms.TextBox()
        Me.L_Monitor = New System.Windows.Forms.Label()
        Me.ComboBox_SRM_Set_View = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Monitor_Set_View = New System.Windows.Forms.ComboBox()
        Me.Button_Save_LLI_Log_To_File = New System.Windows.Forms.Button()
        Me.SaveFileDialog_LLI = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox_LLI1_Spectrum_File = New System.Windows.Forms.TextBox()
        Me.TextBox_LLI2_Spectrum_File = New System.Windows.Forms.TextBox()
        Me.Button_LLI2_Spectrum_File = New System.Windows.Forms.Button()
        Me.L_Name_LLI2_Spectrum_File = New System.Windows.Forms.Label()
        Me.Button_LLI1_Spectrum_File = New System.Windows.Forms.Button()
        Me.L_Name_LLI1_Spectrum_File = New System.Windows.Forms.Label()
        Me.L_Name_Sample_All_LLI_Weight = New System.Windows.Forms.Label()
        Me.ListBox_Sample_ID_All_LLI_Weight = New System.Windows.Forms.ListBox()
        Me.Button_Samples_By_Detectors = New System.Windows.Forms.Button()
        Me.SaveFileDialog_Sample_By_Detector = New System.Windows.Forms.SaveFileDialog()
        Me.L_Name_Sample_Set_View = New System.Windows.Forms.Label()
        Me.L_Name_Person = New System.Windows.Forms.Label()
        Me.L_Name_Person_Field_Name = New System.Windows.Forms.Label()
        Me.L_Name_Date_Field_Name = New System.Windows.Forms.Label()
        Me.L_Name_Time_Field_Name = New System.Windows.Forms.Label()
        Me.L_Name_SRM_Set_View = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set_View = New System.Windows.Forms.Label()
        Me.ComboBox_Sample_Geometry = New System.Windows.Forms.ComboBox()
        Me.L_Name_Sample_Geometry = New System.Windows.Forms.Label()
        Me.TextBox_Download = New System.Windows.Forms.TextBox()
        Me.L_Name_Download = New System.Windows.Forms.Label()
        Me.ButtonSaveSpectra = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogSaveSpectra = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.DataGridView_Table_Monitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_Monitor_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_SRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_SRM_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_LLI_Sample_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_LLI_Irradiation_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_LLI_Irradiation_Log_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_Sample_Set_View
        '
        Me.ComboBox_Sample_Set_View.FormattingEnabled = True
        Me.ComboBox_Sample_Set_View.Items.AddRange(New Object() {"All sample sets", "Sample sets from log"})
        Me.ComboBox_Sample_Set_View.Location = New System.Drawing.Point(369, 430)
        Me.ComboBox_Sample_Set_View.Name = "ComboBox_Sample_Set_View"
        Me.ComboBox_Sample_Set_View.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox_Sample_Set_View.TabIndex = 223
        '
        'B_Find_Sample_Set
        '
        Me.B_Find_Sample_Set.Location = New System.Drawing.Point(241, 448)
        Me.B_Find_Sample_Set.Name = "B_Find_Sample_Set"
        Me.B_Find_Sample_Set.Size = New System.Drawing.Size(104, 23)
        Me.B_Find_Sample_Set.TabIndex = 221
        Me.B_Find_Sample_Set.Text = "Find sample set"
        Me.B_Find_Sample_Set.UseVisualStyleBackColor = True
        Me.B_Find_Sample_Set.Visible = False
        '
        'B_Set_SRM_As_Not_In_Use
        '
        Me.B_Set_SRM_As_Not_In_Use.Location = New System.Drawing.Point(438, 674)
        Me.B_Set_SRM_As_Not_In_Use.Name = "B_Set_SRM_As_Not_In_Use"
        Me.B_Set_SRM_As_Not_In_Use.Size = New System.Drawing.Size(157, 23)
        Me.B_Set_SRM_As_Not_In_Use.TabIndex = 220
        Me.B_Set_SRM_As_Not_In_Use.Text = "Set SRM as not in use"
        Me.B_Set_SRM_As_Not_In_Use.UseVisualStyleBackColor = True
        '
        'B_Set_Monitor_As_Not_In_Use
        '
        Me.B_Set_Monitor_As_Not_In_Use.Location = New System.Drawing.Point(438, 849)
        Me.B_Set_Monitor_As_Not_In_Use.Name = "B_Set_Monitor_As_Not_In_Use"
        Me.B_Set_Monitor_As_Not_In_Use.Size = New System.Drawing.Size(157, 39)
        Me.B_Set_Monitor_As_Not_In_Use.TabIndex = 219
        Me.B_Set_Monitor_As_Not_In_Use.Text = "Set monitor as not in use"
        Me.B_Set_Monitor_As_Not_In_Use.UseVisualStyleBackColor = True
        '
        'B_Delete_Monitor_From_Log
        '
        Me.B_Delete_Monitor_From_Log.Location = New System.Drawing.Point(438, 800)
        Me.B_Delete_Monitor_From_Log.Name = "B_Delete_Monitor_From_Log"
        Me.B_Delete_Monitor_From_Log.Size = New System.Drawing.Size(157, 43)
        Me.B_Delete_Monitor_From_Log.TabIndex = 218
        Me.B_Delete_Monitor_From_Log.Text = "Delete monitor from log"
        Me.B_Delete_Monitor_From_Log.UseVisualStyleBackColor = True
        '
        'B_Add_Monitor
        '
        Me.B_Add_Monitor.Location = New System.Drawing.Point(438, 772)
        Me.B_Add_Monitor.Name = "B_Add_Monitor"
        Me.B_Add_Monitor.Size = New System.Drawing.Size(157, 22)
        Me.B_Add_Monitor.TabIndex = 217
        Me.B_Add_Monitor.Text = "Add monitor"
        Me.B_Add_Monitor.UseVisualStyleBackColor = True
        '
        'L_Name_Monitor
        '
        Me.L_Name_Monitor.AutoSize = True
        Me.L_Name_Monitor.Location = New System.Drawing.Point(687, 708)
        Me.L_Name_Monitor.Name = "L_Name_Monitor"
        Me.L_Name_Monitor.Size = New System.Drawing.Size(42, 13)
        Me.L_Name_Monitor.TabIndex = 216
        Me.L_Name_Monitor.Text = "Monitor"
        '
        'DataGridView_Table_Monitor
        '
        Me.DataGridView_Table_Monitor.AllowUserToAddRows = False
        Me.DataGridView_Table_Monitor.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Monitor.AllowUserToResizeColumns = False
        Me.DataGridView_Table_Monitor.AllowUserToResizeRows = False
        Me.DataGridView_Table_Monitor.AutoGenerateColumns = False
        Me.DataGridView_Table_Monitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Monitor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Table_Monitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Monitor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonitorNumberDataGridViewTextBoxColumn, Me.MonitorLLIWeightDataGridViewTextBoxColumn, Me.Monitor_LLI_Date_Start})
        Me.DataGridView_Table_Monitor.DataSource = Me.Table_Monitor_BindingSource
        Me.DataGridView_Table_Monitor.Location = New System.Drawing.Point(601, 724)
        Me.DataGridView_Table_Monitor.MultiSelect = False
        Me.DataGridView_Table_Monitor.Name = "DataGridView_Table_Monitor"
        Me.DataGridView_Table_Monitor.RowHeadersVisible = False
        Me.DataGridView_Table_Monitor.RowHeadersWidth = 21
        Me.DataGridView_Table_Monitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Monitor.Size = New System.Drawing.Size(377, 164)
        Me.DataGridView_Table_Monitor.TabIndex = 215
        '
        'MonitorNumberDataGridViewTextBoxColumn
        '
        Me.MonitorNumberDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Number"
        Me.MonitorNumberDataGridViewTextBoxColumn.HeaderText = "Monitor_Number"
        Me.MonitorNumberDataGridViewTextBoxColumn.Name = "MonitorNumberDataGridViewTextBoxColumn"
        '
        'MonitorLLIWeightDataGridViewTextBoxColumn
        '
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.DataPropertyName = "Monitor_LLI_Weight"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.HeaderText = "Monitor_LLI_Weight"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.Name = "MonitorLLIWeightDataGridViewTextBoxColumn"
        '
        'Monitor_LLI_Date_Start
        '
        Me.Monitor_LLI_Date_Start.DataPropertyName = "Monitor_LLI_Date_Start"
        Me.Monitor_LLI_Date_Start.HeaderText = "Monitor_LLI_Date_Start"
        Me.Monitor_LLI_Date_Start.Name = "Monitor_LLI_Date_Start"
        '
        'Table_Monitor_BindingSource
        '
        Me.Table_Monitor_BindingSource.DataMember = "table_Monitor"
        Me.Table_Monitor_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView_Table_Monitor_Set
        '
        Me.DataGridView_Table_Monitor_Set.AllowUserToAddRows = False
        Me.DataGridView_Table_Monitor_Set.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Monitor_Set.AllowUserToResizeColumns = False
        Me.DataGridView_Table_Monitor_Set.AllowUserToResizeRows = False
        Me.DataGridView_Table_Monitor_Set.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Monitor_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Table_Monitor_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Monitor_Set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonitorSetNameDataGridViewTextBoxColumn, Me.MonitorSetNumberDataGridViewTextBoxColumn, Me.MonitorSetTypeDataGridViewTextBoxColumn, Me.MonitorSetWeightDataGridViewTextBoxColumn, Me.MonitorSetPurchasingDateDataGridViewTextBoxColumn})
        Me.DataGridView_Table_Monitor_Set.DataSource = Me.Table_Monitor_Set_BindingSource
        Me.DataGridView_Table_Monitor_Set.Location = New System.Drawing.Point(11, 724)
        Me.DataGridView_Table_Monitor_Set.MultiSelect = False
        Me.DataGridView_Table_Monitor_Set.Name = "DataGridView_Table_Monitor_Set"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Monitor_Set.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Table_Monitor_Set.RowHeadersVisible = False
        Me.DataGridView_Table_Monitor_Set.RowHeadersWidth = 21
        Me.DataGridView_Table_Monitor_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Monitor_Set.Size = New System.Drawing.Size(421, 164)
        Me.DataGridView_Table_Monitor_Set.TabIndex = 214
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
        Me.L_Name_Monitor_Set.Location = New System.Drawing.Point(181, 708)
        Me.L_Name_Monitor_Set.Name = "L_Name_Monitor_Set"
        Me.L_Name_Monitor_Set.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Monitor_Set.TabIndex = 213
        Me.L_Name_Monitor_Set.Text = "Monitor sets"
        '
        'B_Delete_Last_Irradiation_Date_From_Log
        '
        Me.B_Delete_Last_Irradiation_Date_From_Log.Location = New System.Drawing.Point(438, 625)
        Me.B_Delete_Last_Irradiation_Date_From_Log.Name = "B_Delete_Last_Irradiation_Date_From_Log"
        Me.B_Delete_Last_Irradiation_Date_From_Log.Size = New System.Drawing.Size(157, 43)
        Me.B_Delete_Last_Irradiation_Date_From_Log.TabIndex = 212
        Me.B_Delete_Last_Irradiation_Date_From_Log.Text = "Delete last irradiation date from log"
        Me.B_Delete_Last_Irradiation_Date_From_Log.UseVisualStyleBackColor = True
        '
        'B_Add_SRM
        '
        Me.B_Add_SRM.Location = New System.Drawing.Point(438, 596)
        Me.B_Add_SRM.Name = "B_Add_SRM"
        Me.B_Add_SRM.Size = New System.Drawing.Size(157, 23)
        Me.B_Add_SRM.TabIndex = 211
        Me.B_Add_SRM.Text = "Add SRM"
        Me.B_Add_SRM.UseVisualStyleBackColor = True
        '
        'L_Name_SRM
        '
        Me.L_Name_SRM.AutoSize = True
        Me.L_Name_SRM.Location = New System.Drawing.Point(748, 529)
        Me.L_Name_SRM.Name = "L_Name_SRM"
        Me.L_Name_SRM.Size = New System.Drawing.Size(31, 13)
        Me.L_Name_SRM.TabIndex = 210
        Me.L_Name_SRM.Text = "SRM"
        '
        'DataGridView_Table_SRM
        '
        Me.DataGridView_Table_SRM.AllowUserToAddRows = False
        Me.DataGridView_Table_SRM.AllowUserToDeleteRows = False
        Me.DataGridView_Table_SRM.AllowUserToResizeColumns = False
        Me.DataGridView_Table_SRM.AllowUserToResizeRows = False
        Me.DataGridView_Table_SRM.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_SRM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_Table_SRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_SRM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SRM_Number, Me.SRMLLIWeightDataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn, Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn, Me.SRMLLINotInUseDataGridViewCheckBoxColumn})
        Me.DataGridView_Table_SRM.DataSource = Me.Table_SRM_BindingSource
        Me.DataGridView_Table_SRM.Location = New System.Drawing.Point(601, 545)
        Me.DataGridView_Table_SRM.MultiSelect = False
        Me.DataGridView_Table_SRM.Name = "DataGridView_Table_SRM"
        Me.DataGridView_Table_SRM.RowHeadersVisible = False
        Me.DataGridView_Table_SRM.RowHeadersWidth = 21
        Me.DataGridView_Table_SRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_SRM.Size = New System.Drawing.Size(377, 152)
        Me.DataGridView_Table_SRM.TabIndex = 209
        '
        'SRM_Number
        '
        Me.SRM_Number.DataPropertyName = "SRM_Number"
        Me.SRM_Number.HeaderText = "SRM_Number"
        Me.SRM_Number.Name = "SRM_Number"
        '
        'SRMLLIWeightDataGridViewTextBoxColumn
        '
        Me.SRMLLIWeightDataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Weight"
        Me.SRMLLIWeightDataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Weight"
        Me.SRMLLIWeightDataGridViewTextBoxColumn.Name = "SRMLLIWeightDataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate1DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_1"
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_1"
        Me.SRMLLIIrradiationDate1DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate1DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate2DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_2"
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_2"
        Me.SRMLLIIrradiationDate2DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate2DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate3DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_3"
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_3"
        Me.SRMLLIIrradiationDate3DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate3DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate4DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_4"
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_4"
        Me.SRMLLIIrradiationDate4DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate4DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate5DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_5"
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_5"
        Me.SRMLLIIrradiationDate5DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate5DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate6DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_6"
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_6"
        Me.SRMLLIIrradiationDate6DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate6DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate7DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_7"
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_7"
        Me.SRMLLIIrradiationDate7DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate7DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate8DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_8"
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_8"
        Me.SRMLLIIrradiationDate8DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate8DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate9DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_9"
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_9"
        Me.SRMLLIIrradiationDate9DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate9DataGridViewTextBoxColumn"
        '
        'SRMLLIIrradiationDate10DataGridViewTextBoxColumn
        '
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.DataPropertyName = "SRM_LLI_Irradiation_Date_10"
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.HeaderText = "SRM_LLI_Irradiation_Date_10"
        Me.SRMLLIIrradiationDate10DataGridViewTextBoxColumn.Name = "SRMLLIIrradiationDate10DataGridViewTextBoxColumn"
        '
        'SRMLLINotInUseDataGridViewCheckBoxColumn
        '
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.DataPropertyName = "SRM_LLI_Not_In_Use"
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.HeaderText = "SRM_LLI_Not_In_Use"
        Me.SRMLLINotInUseDataGridViewCheckBoxColumn.Name = "SRMLLINotInUseDataGridViewCheckBoxColumn"
        '
        'Table_SRM_BindingSource
        '
        Me.Table_SRM_BindingSource.DataMember = "table_SRM"
        Me.Table_SRM_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'DataGridView_Table_SRM_Set
        '
        Me.DataGridView_Table_SRM_Set.AllowUserToAddRows = False
        Me.DataGridView_Table_SRM_Set.AllowUserToDeleteRows = False
        Me.DataGridView_Table_SRM_Set.AllowUserToResizeColumns = False
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
        Me.DataGridView_Table_SRM_Set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SRMSetNameDataGridViewTextBoxColumn, Me.SRMSetNumberDataGridViewTextBoxColumn, Me.SRMSetTypeDataGridViewTextBoxColumn, Me.SRMSetWeightDataGridViewTextBoxColumn, Me.SRMSetPurchasingDateDataGridViewTextBoxColumn})
        Me.DataGridView_Table_SRM_Set.DataSource = Me.Table_SRM_Set_BindingSource
        Me.DataGridView_Table_SRM_Set.Location = New System.Drawing.Point(11, 545)
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
        Me.DataGridView_Table_SRM_Set.Size = New System.Drawing.Size(421, 152)
        Me.DataGridView_Table_SRM_Set.TabIndex = 208
        '
        'SRMSetNameDataGridViewTextBoxColumn
        '
        Me.SRMSetNameDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Name"
        Me.SRMSetNameDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Name"
        Me.SRMSetNameDataGridViewTextBoxColumn.Name = "SRMSetNameDataGridViewTextBoxColumn"
        '
        'SRMSetNumberDataGridViewTextBoxColumn
        '
        Me.SRMSetNumberDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Number"
        Me.SRMSetNumberDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Number"
        Me.SRMSetNumberDataGridViewTextBoxColumn.Name = "SRMSetNumberDataGridViewTextBoxColumn"
        '
        'SRMSetTypeDataGridViewTextBoxColumn
        '
        Me.SRMSetTypeDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Type"
        Me.SRMSetTypeDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Type"
        Me.SRMSetTypeDataGridViewTextBoxColumn.Name = "SRMSetTypeDataGridViewTextBoxColumn"
        '
        'SRMSetWeightDataGridViewTextBoxColumn
        '
        Me.SRMSetWeightDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Weight"
        Me.SRMSetWeightDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Weight"
        Me.SRMSetWeightDataGridViewTextBoxColumn.Name = "SRMSetWeightDataGridViewTextBoxColumn"
        '
        'SRMSetPurchasingDateDataGridViewTextBoxColumn
        '
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.DataPropertyName = "SRM_Set_Purchasing_Date"
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.HeaderText = "SRM_Set_Purchasing_Date"
        Me.SRMSetPurchasingDateDataGridViewTextBoxColumn.Name = "SRMSetPurchasingDateDataGridViewTextBoxColumn"
        '
        'Table_SRM_Set_BindingSource
        '
        Me.Table_SRM_Set_BindingSource.DataMember = "table_SRM_Set"
        Me.Table_SRM_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'L_Name_SRM_Set
        '
        Me.L_Name_SRM_Set.AutoSize = True
        Me.L_Name_SRM_Set.Location = New System.Drawing.Point(171, 529)
        Me.L_Name_SRM_Set.Name = "L_Name_SRM_Set"
        Me.L_Name_SRM_Set.Size = New System.Drawing.Size(53, 13)
        Me.L_Name_SRM_Set.TabIndex = 207
        Me.L_Name_SRM_Set.Text = "SRM sets"
        '
        'L_Name_Sample
        '
        Me.L_Name_Sample.AutoSize = True
        Me.L_Name_Sample.Location = New System.Drawing.Point(553, 271)
        Me.L_Name_Sample.Name = "L_Name_Sample"
        Me.L_Name_Sample.Size = New System.Drawing.Size(42, 13)
        Me.L_Name_Sample.TabIndex = 206
        Me.L_Name_Sample.Text = "Sample"
        '
        'L_Name_Sample_Set
        '
        Me.L_Name_Sample_Set.AutoSize = True
        Me.L_Name_Sample_Set.Location = New System.Drawing.Point(139, 275)
        Me.L_Name_Sample_Set.Name = "L_Name_Sample_Set"
        Me.L_Name_Sample_Set.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Sample_Set.TabIndex = 205
        Me.L_Name_Sample_Set.Text = "Sample sets"
        '
        'ComboBox_Person
        '
        Me.ComboBox_Person.DataSource = Me.Table_Received_By_BindingSource
        Me.ComboBox_Person.DisplayMember = "Received_By"
        Me.ComboBox_Person.FormattingEnabled = True
        Me.ComboBox_Person.Location = New System.Drawing.Point(648, 393)
        Me.ComboBox_Person.Name = "ComboBox_Person"
        Me.ComboBox_Person.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Person.TabIndex = 202
        Me.ComboBox_Person.ValueMember = "Received_By"
        '
        'Table_Received_By_BindingSource
        '
        Me.Table_Received_By_BindingSource.DataMember = "table_Received_By"
        Me.Table_Received_By_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'B_Delete_Sample_From_Log
        '
        Me.B_Delete_Sample_From_Log.Location = New System.Drawing.Point(522, 490)
        Me.B_Delete_Sample_From_Log.Name = "B_Delete_Sample_From_Log"
        Me.B_Delete_Sample_From_Log.Size = New System.Drawing.Size(120, 36)
        Me.B_Delete_Sample_From_Log.TabIndex = 201
        Me.B_Delete_Sample_From_Log.Text = "Delete sample from log"
        Me.B_Delete_Sample_From_Log.UseVisualStyleBackColor = True
        '
        'L_Name_Time
        '
        Me.L_Name_Time.AutoSize = True
        Me.L_Name_Time.Location = New System.Drawing.Point(878, 271)
        Me.L_Name_Time.Name = "L_Name_Time"
        Me.L_Name_Time.Size = New System.Drawing.Size(30, 13)
        Me.L_Name_Time.TabIndex = 198
        Me.L_Name_Time.Text = "Time"
        '
        'MaskedTextBox_Time
        '
        Me.MaskedTextBox_Time.Location = New System.Drawing.Point(872, 287)
        Me.MaskedTextBox_Time.Mask = "00:00:00"
        Me.MaskedTextBox_Time.Name = "MaskedTextBox_Time"
        Me.MaskedTextBox_Time.Size = New System.Drawing.Size(48, 20)
        Me.MaskedTextBox_Time.TabIndex = 197
        '
        'B_Add_Sample
        '
        Me.B_Add_Sample.Location = New System.Drawing.Point(522, 461)
        Me.B_Add_Sample.Name = "B_Add_Sample"
        Me.B_Add_Sample.Size = New System.Drawing.Size(120, 23)
        Me.B_Add_Sample.TabIndex = 196
        Me.B_Add_Sample.Text = "Add sample"
        Me.B_Add_Sample.UseVisualStyleBackColor = True
        '
        'ListBox_Sample_ID
        '
        Me.ListBox_Sample_ID.FormattingEnabled = True
        Me.ListBox_Sample_ID.Location = New System.Drawing.Point(522, 287)
        Me.ListBox_Sample_ID.Name = "ListBox_Sample_ID"
        Me.ListBox_Sample_ID.Size = New System.Drawing.Size(120, 160)
        Me.ListBox_Sample_ID.TabIndex = 195
        '
        'DataGridView_LLI_Sample_Set
        '
        Me.DataGridView_LLI_Sample_Set.AllowUserToAddRows = False
        Me.DataGridView_LLI_Sample_Set.AllowUserToDeleteRows = False
        Me.DataGridView_LLI_Sample_Set.AllowUserToResizeColumns = False
        Me.DataGridView_LLI_Sample_Set.AllowUserToResizeRows = False
        Me.DataGridView_LLI_Sample_Set.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_LLI_Sample_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView_LLI_Sample_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LLI_Sample_Set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryCodeDataGridViewTextBoxColumn1, Me.ClientIDDataGridViewTextBoxColumn1, Me.YearDataGridViewTextBoxColumn1, Me.SampleSetIDDataGridViewTextBoxColumn1, Me.SampleSetIndexDataGridViewTextBoxColumn1})
        Me.DataGridView_LLI_Sample_Set.DataSource = Me.Table_Sample_Set_BindingSource
        Me.DataGridView_LLI_Sample_Set.Location = New System.Drawing.Point(12, 291)
        Me.DataGridView_LLI_Sample_Set.MultiSelect = False
        Me.DataGridView_LLI_Sample_Set.Name = "DataGridView_LLI_Sample_Set"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_LLI_Sample_Set.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_LLI_Sample_Set.RowHeadersVisible = False
        Me.DataGridView_LLI_Sample_Set.RowHeadersWidth = 21
        Me.DataGridView_LLI_Sample_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_LLI_Sample_Set.Size = New System.Drawing.Size(352, 235)
        Me.DataGridView_LLI_Sample_Set.TabIndex = 193
        '
        'CountryCodeDataGridViewTextBoxColumn1
        '
        Me.CountryCodeDataGridViewTextBoxColumn1.DataPropertyName = "Country_Code"
        Me.CountryCodeDataGridViewTextBoxColumn1.HeaderText = "Country_Code"
        Me.CountryCodeDataGridViewTextBoxColumn1.Name = "CountryCodeDataGridViewTextBoxColumn1"
        '
        'ClientIDDataGridViewTextBoxColumn1
        '
        Me.ClientIDDataGridViewTextBoxColumn1.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn1.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn1.Name = "ClientIDDataGridViewTextBoxColumn1"
        '
        'YearDataGridViewTextBoxColumn1
        '
        Me.YearDataGridViewTextBoxColumn1.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn1.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn1.Name = "YearDataGridViewTextBoxColumn1"
        '
        'SampleSetIDDataGridViewTextBoxColumn1
        '
        Me.SampleSetIDDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Set_ID"
        Me.SampleSetIDDataGridViewTextBoxColumn1.HeaderText = "Sample_Set_ID"
        Me.SampleSetIDDataGridViewTextBoxColumn1.Name = "SampleSetIDDataGridViewTextBoxColumn1"
        '
        'SampleSetIndexDataGridViewTextBoxColumn1
        '
        Me.SampleSetIndexDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Set_Index"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SampleSetIndexDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.SampleSetIndexDataGridViewTextBoxColumn1.HeaderText = "Sample_Set_Index"
        Me.SampleSetIndexDataGridViewTextBoxColumn1.Name = "SampleSetIndexDataGridViewTextBoxColumn1"
        '
        'Table_Sample_Set_BindingSource
        '
        Me.Table_Sample_Set_BindingSource.DataMember = "table_Sample_Set"
        Me.Table_Sample_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'MaskedTextBox_LLI_Irradiation_Log
        '
        Me.MaskedTextBox_LLI_Irradiation_Log.Culture = New System.Globalization.CultureInfo("")
        Me.MaskedTextBox_LLI_Irradiation_Log.Enabled = False
        Me.MaskedTextBox_LLI_Irradiation_Log.Location = New System.Drawing.Point(152, 12)
        Me.MaskedTextBox_LLI_Irradiation_Log.Mask = "00.00.0000"
        Me.MaskedTextBox_LLI_Irradiation_Log.Name = "MaskedTextBox_LLI_Irradiation_Log"
        Me.MaskedTextBox_LLI_Irradiation_Log.Size = New System.Drawing.Size(66, 20)
        Me.MaskedTextBox_LLI_Irradiation_Log.TabIndex = 194
        '
        'L_Name_LLI_Irradiation_Log
        '
        Me.L_Name_LLI_Irradiation_Log.AutoSize = True
        Me.L_Name_LLI_Irradiation_Log.Location = New System.Drawing.Point(12, 14)
        Me.L_Name_LLI_Irradiation_Log.Name = "L_Name_LLI_Irradiation_Log"
        Me.L_Name_LLI_Irradiation_Log.Size = New System.Drawing.Size(87, 13)
        Me.L_Name_LLI_Irradiation_Log.TabIndex = 192
        Me.L_Name_LLI_Irradiation_Log.Text = "LLI irradiation log"
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(496, 894)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(213, 23)
        Me.B_Close.TabIndex = 191
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'DataGridView_LLI_Irradiation_Log
        '
        Me.DataGridView_LLI_Irradiation_Log.AllowUserToAddRows = False
        Me.DataGridView_LLI_Irradiation_Log.AllowUserToDeleteRows = False
        Me.DataGridView_LLI_Irradiation_Log.AllowUserToResizeColumns = False
        Me.DataGridView_LLI_Irradiation_Log.AllowUserToResizeRows = False
        Me.DataGridView_LLI_Irradiation_Log.AutoGenerateColumns = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_LLI_Irradiation_Log.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView_LLI_Irradiation_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LLI_Irradiation_Log.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryCodeDataGridViewTextBoxColumn, Me.ClientIDDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.SampleSetIDDataGridViewTextBoxColumn, Me.SampleSetIndexDataGridViewTextBoxColumn, Me.SampleIDDataGridViewTextBoxColumn, Me.DateStartDataGridViewTextBoxColumn, Me.TimeStartDataGridViewTextBoxColumn, Me.ChannelDataGridViewTextBoxColumn, Me.DateFinishDataGridViewTextBoxColumn, Me.TimeFinishDataGridViewTextBoxColumn, Me.PowerReliefDateStart1DataGridViewTextBoxColumn, Me.PowerReliefTimeStart1DataGridViewTextBoxColumn, Me.PowerReliefDateFinish1DataGridViewTextBoxColumn, Me.PowerReliefTimeFinish1DataGridViewTextBoxColumn, Me.PowerReliefDateStart2DataGridViewTextBoxColumn, Me.PowerReliefTimeStart2DataGridViewTextBoxColumn, Me.PowerReliefDateFinish2DataGridViewTextBoxColumn, Me.PowerReliefTimeFinish2DataGridViewTextBoxColumn, Me.ContainerNumberDataGridViewTextBoxColumn, Me.PositionNumberDataGridViewTextBoxColumn, Me.IrradiatedByDataGridViewTextBoxColumn, Me.DateRehadleDataGridViewTextBoxColumn, Me.RehandledByDataGridViewTextBoxColumn, Me.DateMeasurementLLI1DataGridViewTextBoxColumn, Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn, Me.Detector2MeasurementLLI1DataGridViewCheckBoxColumn, Me.Detector3MeasurementLLI1DataGridViewCheckBoxColumn, Me.Detector4MeasurementLLI1DataGridViewCheckBoxColumn, Me.PaperLogLLI1NumberDataGridViewTextBoxColumn, Me.MeasuredLLI1ByDataGridViewTextBoxColumn, Me.DateMeasurementLLI2DataGridViewTextBoxColumn, Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn, Me.Detector2MeasurementLLI2DataGridViewCheckBoxColumn, Me.Detector3MeasurementLLI2DataGridViewCheckBoxColumn, Me.Detector4MeasurementLLI2DataGridViewCheckBoxColumn, Me.PaperLogLLI2NumberDataGridViewTextBoxColumn, Me.MeasuredLLI2ByDataGridViewTextBoxColumn})
        Me.DataGridView_LLI_Irradiation_Log.DataSource = Me.Table_LLI_Irradiation_Log_BindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_LLI_Irradiation_Log.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView_LLI_Irradiation_Log.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView_LLI_Irradiation_Log.Name = "DataGridView_LLI_Irradiation_Log"
        Me.DataGridView_LLI_Irradiation_Log.RowHeadersVisible = False
        Me.DataGridView_LLI_Irradiation_Log.RowHeadersWidth = 21
        Me.DataGridView_LLI_Irradiation_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_LLI_Irradiation_Log.Size = New System.Drawing.Size(965, 229)
        Me.DataGridView_LLI_Irradiation_Log.TabIndex = 190
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
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SampleSetIndexDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.SampleSetIndexDataGridViewTextBoxColumn.HeaderText = "Sample_Set_Index"
        Me.SampleSetIndexDataGridViewTextBoxColumn.Name = "SampleSetIndexDataGridViewTextBoxColumn"
        '
        'SampleIDDataGridViewTextBoxColumn
        '
        Me.SampleIDDataGridViewTextBoxColumn.DataPropertyName = "Sample_ID"
        Me.SampleIDDataGridViewTextBoxColumn.HeaderText = "Sample_ID"
        Me.SampleIDDataGridViewTextBoxColumn.Name = "SampleIDDataGridViewTextBoxColumn"
        '
        'DateStartDataGridViewTextBoxColumn
        '
        Me.DateStartDataGridViewTextBoxColumn.DataPropertyName = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.HeaderText = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.Name = "DateStartDataGridViewTextBoxColumn"
        '
        'TimeStartDataGridViewTextBoxColumn
        '
        Me.TimeStartDataGridViewTextBoxColumn.DataPropertyName = "Time_Start"
        Me.TimeStartDataGridViewTextBoxColumn.HeaderText = "Time_Start"
        Me.TimeStartDataGridViewTextBoxColumn.Name = "TimeStartDataGridViewTextBoxColumn"
        '
        'ChannelDataGridViewTextBoxColumn
        '
        Me.ChannelDataGridViewTextBoxColumn.DataPropertyName = "Channel"
        Me.ChannelDataGridViewTextBoxColumn.HeaderText = "Channel"
        Me.ChannelDataGridViewTextBoxColumn.Name = "ChannelDataGridViewTextBoxColumn"
        '
        'DateFinishDataGridViewTextBoxColumn
        '
        Me.DateFinishDataGridViewTextBoxColumn.DataPropertyName = "Date_Finish"
        Me.DateFinishDataGridViewTextBoxColumn.HeaderText = "Date_Finish"
        Me.DateFinishDataGridViewTextBoxColumn.Name = "DateFinishDataGridViewTextBoxColumn"
        '
        'TimeFinishDataGridViewTextBoxColumn
        '
        Me.TimeFinishDataGridViewTextBoxColumn.DataPropertyName = "Time_Finish"
        Me.TimeFinishDataGridViewTextBoxColumn.HeaderText = "Time_Finish"
        Me.TimeFinishDataGridViewTextBoxColumn.Name = "TimeFinishDataGridViewTextBoxColumn"
        '
        'PowerReliefDateStart1DataGridViewTextBoxColumn
        '
        Me.PowerReliefDateStart1DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Date_Start_1"
        Me.PowerReliefDateStart1DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Date_Start_1"
        Me.PowerReliefDateStart1DataGridViewTextBoxColumn.Name = "PowerReliefDateStart1DataGridViewTextBoxColumn"
        '
        'PowerReliefTimeStart1DataGridViewTextBoxColumn
        '
        Me.PowerReliefTimeStart1DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Time_Start_1"
        Me.PowerReliefTimeStart1DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Time_Start_1"
        Me.PowerReliefTimeStart1DataGridViewTextBoxColumn.Name = "PowerReliefTimeStart1DataGridViewTextBoxColumn"
        '
        'PowerReliefDateFinish1DataGridViewTextBoxColumn
        '
        Me.PowerReliefDateFinish1DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Date_Finish_1"
        Me.PowerReliefDateFinish1DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Date_Finish_1"
        Me.PowerReliefDateFinish1DataGridViewTextBoxColumn.Name = "PowerReliefDateFinish1DataGridViewTextBoxColumn"
        '
        'PowerReliefTimeFinish1DataGridViewTextBoxColumn
        '
        Me.PowerReliefTimeFinish1DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Time_Finish_1"
        Me.PowerReliefTimeFinish1DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Time_Finish_1"
        Me.PowerReliefTimeFinish1DataGridViewTextBoxColumn.Name = "PowerReliefTimeFinish1DataGridViewTextBoxColumn"
        '
        'PowerReliefDateStart2DataGridViewTextBoxColumn
        '
        Me.PowerReliefDateStart2DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Date_Start_2"
        Me.PowerReliefDateStart2DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Date_Start_2"
        Me.PowerReliefDateStart2DataGridViewTextBoxColumn.Name = "PowerReliefDateStart2DataGridViewTextBoxColumn"
        '
        'PowerReliefTimeStart2DataGridViewTextBoxColumn
        '
        Me.PowerReliefTimeStart2DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Time_Start_2"
        Me.PowerReliefTimeStart2DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Time_Start_2"
        Me.PowerReliefTimeStart2DataGridViewTextBoxColumn.Name = "PowerReliefTimeStart2DataGridViewTextBoxColumn"
        '
        'PowerReliefDateFinish2DataGridViewTextBoxColumn
        '
        Me.PowerReliefDateFinish2DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Date_Finish_2"
        Me.PowerReliefDateFinish2DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Date_Finish_2"
        Me.PowerReliefDateFinish2DataGridViewTextBoxColumn.Name = "PowerReliefDateFinish2DataGridViewTextBoxColumn"
        '
        'PowerReliefTimeFinish2DataGridViewTextBoxColumn
        '
        Me.PowerReliefTimeFinish2DataGridViewTextBoxColumn.DataPropertyName = "Power_Relief_Time_Finish_2"
        Me.PowerReliefTimeFinish2DataGridViewTextBoxColumn.HeaderText = "Power_Relief_Time_Finish_2"
        Me.PowerReliefTimeFinish2DataGridViewTextBoxColumn.Name = "PowerReliefTimeFinish2DataGridViewTextBoxColumn"
        '
        'ContainerNumberDataGridViewTextBoxColumn
        '
        Me.ContainerNumberDataGridViewTextBoxColumn.DataPropertyName = "Container_Number"
        Me.ContainerNumberDataGridViewTextBoxColumn.HeaderText = "Container_Number"
        Me.ContainerNumberDataGridViewTextBoxColumn.Name = "ContainerNumberDataGridViewTextBoxColumn"
        '
        'PositionNumberDataGridViewTextBoxColumn
        '
        Me.PositionNumberDataGridViewTextBoxColumn.DataPropertyName = "Position_Number"
        Me.PositionNumberDataGridViewTextBoxColumn.HeaderText = "Position_Number"
        Me.PositionNumberDataGridViewTextBoxColumn.Name = "PositionNumberDataGridViewTextBoxColumn"
        '
        'IrradiatedByDataGridViewTextBoxColumn
        '
        Me.IrradiatedByDataGridViewTextBoxColumn.DataPropertyName = "Irradiated_By"
        Me.IrradiatedByDataGridViewTextBoxColumn.HeaderText = "Irradiated_By"
        Me.IrradiatedByDataGridViewTextBoxColumn.Name = "IrradiatedByDataGridViewTextBoxColumn"
        '
        'DateRehadleDataGridViewTextBoxColumn
        '
        Me.DateRehadleDataGridViewTextBoxColumn.DataPropertyName = "Date_Rehadle"
        Me.DateRehadleDataGridViewTextBoxColumn.HeaderText = "Date_Rehadle"
        Me.DateRehadleDataGridViewTextBoxColumn.Name = "DateRehadleDataGridViewTextBoxColumn"
        '
        'RehandledByDataGridViewTextBoxColumn
        '
        Me.RehandledByDataGridViewTextBoxColumn.DataPropertyName = "Rehandled_By"
        Me.RehandledByDataGridViewTextBoxColumn.HeaderText = "Rehandled_By"
        Me.RehandledByDataGridViewTextBoxColumn.Name = "RehandledByDataGridViewTextBoxColumn"
        '
        'DateMeasurementLLI1DataGridViewTextBoxColumn
        '
        Me.DateMeasurementLLI1DataGridViewTextBoxColumn.DataPropertyName = "Date_Measurement_LLI_1"
        Me.DateMeasurementLLI1DataGridViewTextBoxColumn.HeaderText = "Date_Measurement_LLI_1"
        Me.DateMeasurementLLI1DataGridViewTextBoxColumn.Name = "DateMeasurementLLI1DataGridViewTextBoxColumn"
        '
        'Detector1MeasurementLLI1DataGridViewCheckBoxColumn
        '
        Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn.DataPropertyName = "Detector_1_Measurement_LLI_1"
        Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn.HeaderText = "Detector_1_Measurement_LLI_1"
        Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn.Name = "Detector1MeasurementLLI1DataGridViewCheckBoxColumn"
        Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detector1MeasurementLLI1DataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Detector2MeasurementLLI1DataGridViewCheckBoxColumn
        '
        Me.Detector2MeasurementLLI1DataGridViewCheckBoxColumn.DataPropertyName = "Detector_2_Measurement_LLI_1"
        Me.Detector2MeasurementLLI1DataGridViewCheckBoxColumn.HeaderText = "Detector_2_Measurement_LLI_1"
        Me.Detector2MeasurementLLI1DataGridViewCheckBoxColumn.Name = "Detector2MeasurementLLI1DataGridViewCheckBoxColumn"
        '
        'Detector3MeasurementLLI1DataGridViewCheckBoxColumn
        '
        Me.Detector3MeasurementLLI1DataGridViewCheckBoxColumn.DataPropertyName = "Detector_3_Measurement_LLI_1"
        Me.Detector3MeasurementLLI1DataGridViewCheckBoxColumn.HeaderText = "Detector_3_Measurement_LLI_1"
        Me.Detector3MeasurementLLI1DataGridViewCheckBoxColumn.Name = "Detector3MeasurementLLI1DataGridViewCheckBoxColumn"
        '
        'Detector4MeasurementLLI1DataGridViewCheckBoxColumn
        '
        Me.Detector4MeasurementLLI1DataGridViewCheckBoxColumn.DataPropertyName = "Detector_4_Measurement_LLI_1"
        Me.Detector4MeasurementLLI1DataGridViewCheckBoxColumn.HeaderText = "Detector_4_Measurement_LLI_1"
        Me.Detector4MeasurementLLI1DataGridViewCheckBoxColumn.Name = "Detector4MeasurementLLI1DataGridViewCheckBoxColumn"
        '
        'PaperLogLLI1NumberDataGridViewTextBoxColumn
        '
        Me.PaperLogLLI1NumberDataGridViewTextBoxColumn.DataPropertyName = "Paper_Log_LLI_1_Number"
        Me.PaperLogLLI1NumberDataGridViewTextBoxColumn.HeaderText = "Paper_Log_LLI_1_Number"
        Me.PaperLogLLI1NumberDataGridViewTextBoxColumn.Name = "PaperLogLLI1NumberDataGridViewTextBoxColumn"
        '
        'MeasuredLLI1ByDataGridViewTextBoxColumn
        '
        Me.MeasuredLLI1ByDataGridViewTextBoxColumn.DataPropertyName = "Measured_LLI_1_By"
        Me.MeasuredLLI1ByDataGridViewTextBoxColumn.HeaderText = "Measured_LLI_1_By"
        Me.MeasuredLLI1ByDataGridViewTextBoxColumn.Name = "MeasuredLLI1ByDataGridViewTextBoxColumn"
        '
        'DateMeasurementLLI2DataGridViewTextBoxColumn
        '
        Me.DateMeasurementLLI2DataGridViewTextBoxColumn.DataPropertyName = "Date_Measurement_LLI_2"
        Me.DateMeasurementLLI2DataGridViewTextBoxColumn.HeaderText = "Date_Measurement_LLI_2"
        Me.DateMeasurementLLI2DataGridViewTextBoxColumn.Name = "DateMeasurementLLI2DataGridViewTextBoxColumn"
        '
        'Detector1MeasurementLLI2DataGridViewCheckBoxColumn
        '
        Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn.DataPropertyName = "Detector_1_Measurement_LLI_2"
        Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn.HeaderText = "Detector_1_Measurement_LLI_2"
        Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn.Name = "Detector1MeasurementLLI2DataGridViewCheckBoxColumn"
        Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detector1MeasurementLLI2DataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Detector2MeasurementLLI2DataGridViewCheckBoxColumn
        '
        Me.Detector2MeasurementLLI2DataGridViewCheckBoxColumn.DataPropertyName = "Detector_2_Measurement_LLI_2"
        Me.Detector2MeasurementLLI2DataGridViewCheckBoxColumn.HeaderText = "Detector_2_Measurement_LLI_2"
        Me.Detector2MeasurementLLI2DataGridViewCheckBoxColumn.Name = "Detector2MeasurementLLI2DataGridViewCheckBoxColumn"
        '
        'Detector3MeasurementLLI2DataGridViewCheckBoxColumn
        '
        Me.Detector3MeasurementLLI2DataGridViewCheckBoxColumn.DataPropertyName = "Detector_3_Measurement_LLI_2"
        Me.Detector3MeasurementLLI2DataGridViewCheckBoxColumn.HeaderText = "Detector_3_Measurement_LLI_2"
        Me.Detector3MeasurementLLI2DataGridViewCheckBoxColumn.Name = "Detector3MeasurementLLI2DataGridViewCheckBoxColumn"
        '
        'Detector4MeasurementLLI2DataGridViewCheckBoxColumn
        '
        Me.Detector4MeasurementLLI2DataGridViewCheckBoxColumn.DataPropertyName = "Detector_4_Measurement_LLI_2"
        Me.Detector4MeasurementLLI2DataGridViewCheckBoxColumn.HeaderText = "Detector_4_Measurement_LLI_2"
        Me.Detector4MeasurementLLI2DataGridViewCheckBoxColumn.Name = "Detector4MeasurementLLI2DataGridViewCheckBoxColumn"
        '
        'PaperLogLLI2NumberDataGridViewTextBoxColumn
        '
        Me.PaperLogLLI2NumberDataGridViewTextBoxColumn.DataPropertyName = "Paper_Log_LLI_2_Number"
        Me.PaperLogLLI2NumberDataGridViewTextBoxColumn.HeaderText = "Paper_Log_LLI_2_Number"
        Me.PaperLogLLI2NumberDataGridViewTextBoxColumn.Name = "PaperLogLLI2NumberDataGridViewTextBoxColumn"
        '
        'MeasuredLLI2ByDataGridViewTextBoxColumn
        '
        Me.MeasuredLLI2ByDataGridViewTextBoxColumn.DataPropertyName = "Measured_LLI_2_By"
        Me.MeasuredLLI2ByDataGridViewTextBoxColumn.HeaderText = "Measured_LLI_2_By"
        Me.MeasuredLLI2ByDataGridViewTextBoxColumn.Name = "MeasuredLLI2ByDataGridViewTextBoxColumn"
        '
        'Table_LLI_Irradiation_Log_BindingSource
        '
        Me.Table_LLI_Irradiation_Log_BindingSource.DataMember = "table_LLI_Irradiation_Log"
        Me.Table_LLI_Irradiation_Log_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_LLI_Irradiation_Log_TableAdapter
        '
        Me.Table_LLI_Irradiation_Log_TableAdapter.ClearBeforeFill = True
        '
        'Table_Received_By_TableAdapter
        '
        Me.Table_Received_By_TableAdapter.ClearBeforeFill = True
        '
        'Table_Sample_Set_TableAdapter
        '
        Me.Table_Sample_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_SRM_Set_TableAdapter
        '
        Me.Table_SRM_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_Monitor_Set_TableAdapter
        '
        Me.Table_Monitor_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_SRM_TableAdapter
        '
        Me.Table_SRM_TableAdapter.ClearBeforeFill = True
        '
        'Table_Monitor_TableAdapter
        '
        Me.Table_Monitor_TableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox_Date
        '
        Me.MaskedTextBox_Date.Location = New System.Drawing.Point(690, 287)
        Me.MaskedTextBox_Date.Mask = "00/00/0000"
        Me.MaskedTextBox_Date.Name = "MaskedTextBox_Date"
        Me.MaskedTextBox_Date.Size = New System.Drawing.Size(66, 20)
        Me.MaskedTextBox_Date.TabIndex = 227
        Me.MaskedTextBox_Date.ValidatingType = GetType(Date)
        '
        'L_Name_Date
        '
        Me.L_Name_Date.AutoSize = True
        Me.L_Name_Date.Location = New System.Drawing.Point(705, 271)
        Me.L_Name_Date.Name = "L_Name_Date"
        Me.L_Name_Date.Size = New System.Drawing.Size(30, 13)
        Me.L_Name_Date.TabIndex = 229
        Me.L_Name_Date.Text = "Date"
        '
        'ComboBox_Date_Field_Name
        '
        Me.ComboBox_Date_Field_Name.FormattingEnabled = True
        Me.ComboBox_Date_Field_Name.Items.AddRange(New Object() {"", "irradiation finish date", "measurement LLI1 date", "measurement LLI2 date"})
        Me.ComboBox_Date_Field_Name.Location = New System.Drawing.Point(648, 328)
        Me.ComboBox_Date_Field_Name.Name = "ComboBox_Date_Field_Name"
        Me.ComboBox_Date_Field_Name.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Date_Field_Name.TabIndex = 241
        '
        'B_Fill_In_Date
        '
        Me.B_Fill_In_Date.Location = New System.Drawing.Point(648, 351)
        Me.B_Fill_In_Date.Name = "B_Fill_In_Date"
        Me.B_Fill_In_Date.Size = New System.Drawing.Size(156, 23)
        Me.B_Fill_In_Date.TabIndex = 242
        Me.B_Fill_In_Date.Text = "Fill in date"
        Me.B_Fill_In_Date.UseVisualStyleBackColor = True
        '
        'B_Fill_In_Time
        '
        Me.B_Fill_In_Time.Location = New System.Drawing.Point(820, 351)
        Me.B_Fill_In_Time.Name = "B_Fill_In_Time"
        Me.B_Fill_In_Time.Size = New System.Drawing.Size(156, 23)
        Me.B_Fill_In_Time.TabIndex = 245
        Me.B_Fill_In_Time.Text = "Fill in time"
        Me.B_Fill_In_Time.UseVisualStyleBackColor = True
        '
        'ComboBox_Time_Field_Name
        '
        Me.ComboBox_Time_Field_Name.FormattingEnabled = True
        Me.ComboBox_Time_Field_Name.Items.AddRange(New Object() {"", "irradiation start time", "irradiation finish time"})
        Me.ComboBox_Time_Field_Name.Location = New System.Drawing.Point(820, 328)
        Me.ComboBox_Time_Field_Name.Name = "ComboBox_Time_Field_Name"
        Me.ComboBox_Time_Field_Name.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Time_Field_Name.TabIndex = 244
        '
        'ComboBox_Person_Field_Name
        '
        Me.ComboBox_Person_Field_Name.FormattingEnabled = True
        Me.ComboBox_Person_Field_Name.Items.AddRange(New Object() {"", "irradiated by", "rehandled by"})
        Me.ComboBox_Person_Field_Name.Location = New System.Drawing.Point(820, 393)
        Me.ComboBox_Person_Field_Name.Name = "ComboBox_Person_Field_Name"
        Me.ComboBox_Person_Field_Name.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Person_Field_Name.TabIndex = 247
        '
        'B_Fill_In_Person
        '
        Me.B_Fill_In_Person.Location = New System.Drawing.Point(645, 420)
        Me.B_Fill_In_Person.Name = "B_Fill_In_Person"
        Me.B_Fill_In_Person.Size = New System.Drawing.Size(328, 23)
        Me.B_Fill_In_Person.TabIndex = 248
        Me.B_Fill_In_Person.Text = "Fill in person"
        Me.B_Fill_In_Person.UseVisualStyleBackColor = True
        '
        'B_Save_And_Update_LLI
        '
        Me.B_Save_And_Update_LLI.Location = New System.Drawing.Point(277, 894)
        Me.B_Save_And_Update_LLI.Name = "B_Save_And_Update_LLI"
        Me.B_Save_And_Update_LLI.Size = New System.Drawing.Size(213, 23)
        Me.B_Save_And_Update_LLI.TabIndex = 249
        Me.B_Save_And_Update_LLI.Text = "Save and update LLI"
        Me.B_Save_And_Update_LLI.UseVisualStyleBackColor = True
        '
        'TextBox_Container_Number
        '
        Me.TextBox_Container_Number.Location = New System.Drawing.Point(745, 464)
        Me.TextBox_Container_Number.Name = "TextBox_Container_Number"
        Me.TextBox_Container_Number.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Container_Number.TabIndex = 255
        '
        'B_Fill_In_Container_Number
        '
        Me.B_Fill_In_Container_Number.Location = New System.Drawing.Point(729, 490)
        Me.B_Fill_In_Container_Number.Name = "B_Fill_In_Container_Number"
        Me.B_Fill_In_Container_Number.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Container_Number.TabIndex = 254
        Me.B_Fill_In_Container_Number.Text = "Fill in container number"
        Me.B_Fill_In_Container_Number.UseVisualStyleBackColor = True
        '
        'L_Name_Container_Number
        '
        Me.L_Name_Container_Number.AutoSize = True
        Me.L_Name_Container_Number.Location = New System.Drawing.Point(714, 448)
        Me.L_Name_Container_Number.Name = "L_Name_Container_Number"
        Me.L_Name_Container_Number.Size = New System.Drawing.Size(90, 13)
        Me.L_Name_Container_Number.TabIndex = 253
        Me.L_Name_Container_Number.Text = "Container number"
        '
        'ComboBox_Channel
        '
        Me.ComboBox_Channel.FormattingEnabled = True
        Me.ComboBox_Channel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox_Channel.Location = New System.Drawing.Point(664, 464)
        Me.ComboBox_Channel.Name = "ComboBox_Channel"
        Me.ComboBox_Channel.Size = New System.Drawing.Size(43, 21)
        Me.ComboBox_Channel.TabIndex = 252
        Me.ComboBox_Channel.Text = "2"
        '
        'B_Fill_In_Channel
        '
        Me.B_Fill_In_Channel.Location = New System.Drawing.Point(648, 490)
        Me.B_Fill_In_Channel.Name = "B_Fill_In_Channel"
        Me.B_Fill_In_Channel.Size = New System.Drawing.Size(75, 36)
        Me.B_Fill_In_Channel.TabIndex = 251
        Me.B_Fill_In_Channel.Text = "Fill in channel"
        Me.B_Fill_In_Channel.UseVisualStyleBackColor = True
        '
        'L_Name_Channel
        '
        Me.L_Name_Channel.AutoSize = True
        Me.L_Name_Channel.Location = New System.Drawing.Point(661, 448)
        Me.L_Name_Channel.Name = "L_Name_Channel"
        Me.L_Name_Channel.Size = New System.Drawing.Size(46, 13)
        Me.L_Name_Channel.TabIndex = 250
        Me.L_Name_Channel.Text = "Channel"
        '
        'TextBox_Paper_Log_LLI2
        '
        Me.TextBox_Paper_Log_LLI2.Location = New System.Drawing.Point(161, 352)
        Me.TextBox_Paper_Log_LLI2.Name = "TextBox_Paper_Log_LLI2"
        Me.TextBox_Paper_Log_LLI2.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Paper_Log_LLI2.TabIndex = 261
        Me.TextBox_Paper_Log_LLI2.Visible = False
        '
        'Button_Paper_Log_LLI2
        '
        Me.Button_Paper_Log_LLI2.Location = New System.Drawing.Point(135, 378)
        Me.Button_Paper_Log_LLI2.Name = "Button_Paper_Log_LLI2"
        Me.Button_Paper_Log_LLI2.Size = New System.Drawing.Size(75, 36)
        Me.Button_Paper_Log_LLI2.TabIndex = 260
        Me.Button_Paper_Log_LLI2.Text = "Fill in paper log LLI2"
        Me.Button_Paper_Log_LLI2.UseVisualStyleBackColor = True
        Me.Button_Paper_Log_LLI2.Visible = False
        '
        'L_Name_Paper_Log_LLI2
        '
        Me.L_Name_Paper_Log_LLI2.AutoSize = True
        Me.L_Name_Paper_Log_LLI2.Location = New System.Drawing.Point(135, 336)
        Me.L_Name_Paper_Log_LLI2.Name = "L_Name_Paper_Log_LLI2"
        Me.L_Name_Paper_Log_LLI2.Size = New System.Drawing.Size(76, 13)
        Me.L_Name_Paper_Log_LLI2.TabIndex = 259
        Me.L_Name_Paper_Log_LLI2.Text = "Paper log LLI2"
        Me.L_Name_Paper_Log_LLI2.Visible = False
        '
        'Button_Paper_Log_LLI1
        '
        Me.Button_Paper_Log_LLI1.Location = New System.Drawing.Point(54, 378)
        Me.Button_Paper_Log_LLI1.Name = "Button_Paper_Log_LLI1"
        Me.Button_Paper_Log_LLI1.Size = New System.Drawing.Size(75, 36)
        Me.Button_Paper_Log_LLI1.TabIndex = 257
        Me.Button_Paper_Log_LLI1.Text = "Fill in paper log LLI1"
        Me.Button_Paper_Log_LLI1.UseVisualStyleBackColor = True
        Me.Button_Paper_Log_LLI1.Visible = False
        '
        'L_Name_Paper_Log_LLI1
        '
        Me.L_Name_Paper_Log_LLI1.AutoSize = True
        Me.L_Name_Paper_Log_LLI1.Location = New System.Drawing.Point(53, 336)
        Me.L_Name_Paper_Log_LLI1.Name = "L_Name_Paper_Log_LLI1"
        Me.L_Name_Paper_Log_LLI1.Size = New System.Drawing.Size(76, 13)
        Me.L_Name_Paper_Log_LLI1.TabIndex = 256
        Me.L_Name_Paper_Log_LLI1.Text = "Paper log LLI1"
        Me.L_Name_Paper_Log_LLI1.Visible = False
        '
        'TextBox_Paper_Log_LLI1
        '
        Me.TextBox_Paper_Log_LLI1.Location = New System.Drawing.Point(70, 352)
        Me.TextBox_Paper_Log_LLI1.Name = "TextBox_Paper_Log_LLI1"
        Me.TextBox_Paper_Log_LLI1.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Paper_Log_LLI1.TabIndex = 262
        Me.TextBox_Paper_Log_LLI1.Visible = False
        '
        'L_Monitor
        '
        Me.L_Monitor.Location = New System.Drawing.Point(373, 275)
        Me.L_Monitor.Name = "L_Monitor"
        Me.L_Monitor.Size = New System.Drawing.Size(143, 133)
        Me.L_Monitor.TabIndex = 263
        Me.L_Monitor.Text = "M"
        '
        'ComboBox_SRM_Set_View
        '
        Me.ComboBox_SRM_Set_View.FormattingEnabled = True
        Me.ComboBox_SRM_Set_View.Items.AddRange(New Object() {"All SRM sets", "SRM sets from log"})
        Me.ComboBox_SRM_Set_View.Location = New System.Drawing.Point(438, 561)
        Me.ComboBox_SRM_Set_View.Name = "ComboBox_SRM_Set_View"
        Me.ComboBox_SRM_Set_View.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox_SRM_Set_View.TabIndex = 265
        '
        'ComboBox_Monitor_Set_View
        '
        Me.ComboBox_Monitor_Set_View.FormattingEnabled = True
        Me.ComboBox_Monitor_Set_View.Items.AddRange(New Object() {"All Monitor sets", "Monitor sets from log"})
        Me.ComboBox_Monitor_Set_View.Location = New System.Drawing.Point(439, 740)
        Me.ComboBox_Monitor_Set_View.Name = "ComboBox_Monitor_Set_View"
        Me.ComboBox_Monitor_Set_View.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Monitor_Set_View.TabIndex = 267
        '
        'Button_Save_LLI_Log_To_File
        '
        Me.Button_Save_LLI_Log_To_File.Location = New System.Drawing.Point(838, 9)
        Me.Button_Save_LLI_Log_To_File.Name = "Button_Save_LLI_Log_To_File"
        Me.Button_Save_LLI_Log_To_File.Size = New System.Drawing.Size(138, 23)
        Me.Button_Save_LLI_Log_To_File.TabIndex = 268
        Me.Button_Save_LLI_Log_To_File.Text = "Save LLI log to file"
        Me.Button_Save_LLI_Log_To_File.UseVisualStyleBackColor = True
        '
        'SaveFileDialog_LLI
        '
        Me.SaveFileDialog_LLI.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        '
        'TextBox_LLI1_Spectrum_File
        '
        Me.TextBox_LLI1_Spectrum_File.Location = New System.Drawing.Point(817, 464)
        Me.TextBox_LLI1_Spectrum_File.Name = "TextBox_LLI1_Spectrum_File"
        Me.TextBox_LLI1_Spectrum_File.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_LLI1_Spectrum_File.TabIndex = 274
        '
        'TextBox_LLI2_Spectrum_File
        '
        Me.TextBox_LLI2_Spectrum_File.Location = New System.Drawing.Point(898, 464)
        Me.TextBox_LLI2_Spectrum_File.Name = "TextBox_LLI2_Spectrum_File"
        Me.TextBox_LLI2_Spectrum_File.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_LLI2_Spectrum_File.TabIndex = 273
        '
        'Button_LLI2_Spectrum_File
        '
        Me.Button_LLI2_Spectrum_File.Location = New System.Drawing.Point(898, 490)
        Me.Button_LLI2_Spectrum_File.Name = "Button_LLI2_Spectrum_File"
        Me.Button_LLI2_Spectrum_File.Size = New System.Drawing.Size(75, 36)
        Me.Button_LLI2_Spectrum_File.TabIndex = 272
        Me.Button_LLI2_Spectrum_File.Text = "Fill in LLI2 file"
        Me.Button_LLI2_Spectrum_File.UseVisualStyleBackColor = True
        '
        'L_Name_LLI2_Spectrum_File
        '
        Me.L_Name_LLI2_Spectrum_File.AutoSize = True
        Me.L_Name_LLI2_Spectrum_File.Location = New System.Drawing.Point(903, 448)
        Me.L_Name_LLI2_Spectrum_File.Name = "L_Name_LLI2_Spectrum_File"
        Me.L_Name_LLI2_Spectrum_File.Size = New System.Drawing.Size(44, 13)
        Me.L_Name_LLI2_Spectrum_File.TabIndex = 271
        Me.L_Name_LLI2_Spectrum_File.Text = "LLI2 file"
        '
        'Button_LLI1_Spectrum_File
        '
        Me.Button_LLI1_Spectrum_File.Location = New System.Drawing.Point(817, 490)
        Me.Button_LLI1_Spectrum_File.Name = "Button_LLI1_Spectrum_File"
        Me.Button_LLI1_Spectrum_File.Size = New System.Drawing.Size(75, 36)
        Me.Button_LLI1_Spectrum_File.TabIndex = 270
        Me.Button_LLI1_Spectrum_File.Text = "Fill in LLI1 file"
        Me.Button_LLI1_Spectrum_File.UseVisualStyleBackColor = True
        '
        'L_Name_LLI1_Spectrum_File
        '
        Me.L_Name_LLI1_Spectrum_File.AutoSize = True
        Me.L_Name_LLI1_Spectrum_File.Location = New System.Drawing.Point(823, 448)
        Me.L_Name_LLI1_Spectrum_File.Name = "L_Name_LLI1_Spectrum_File"
        Me.L_Name_LLI1_Spectrum_File.Size = New System.Drawing.Size(44, 13)
        Me.L_Name_LLI1_Spectrum_File.TabIndex = 269
        Me.L_Name_LLI1_Spectrum_File.Text = "LLI1 file"
        '
        'L_Name_Sample_All_LLI_Weight
        '
        Me.L_Name_Sample_All_LLI_Weight.AutoSize = True
        Me.L_Name_Sample_All_LLI_Weight.Location = New System.Drawing.Point(389, 454)
        Me.L_Name_Sample_All_LLI_Weight.Name = "L_Name_Sample_All_LLI_Weight"
        Me.L_Name_Sample_All_LLI_Weight.Size = New System.Drawing.Size(101, 13)
        Me.L_Name_Sample_All_LLI_Weight.TabIndex = 276
        Me.L_Name_Sample_All_LLI_Weight.Text = "Sample's LLI weight"
        '
        'ListBox_Sample_ID_All_LLI_Weight
        '
        Me.ListBox_Sample_ID_All_LLI_Weight.FormattingEnabled = True
        Me.ListBox_Sample_ID_All_LLI_Weight.Location = New System.Drawing.Point(370, 470)
        Me.ListBox_Sample_ID_All_LLI_Weight.Name = "ListBox_Sample_ID_All_LLI_Weight"
        Me.ListBox_Sample_ID_All_LLI_Weight.Size = New System.Drawing.Size(146, 56)
        Me.ListBox_Sample_ID_All_LLI_Weight.TabIndex = 275
        '
        'Button_Samples_By_Detectors
        '
        Me.Button_Samples_By_Detectors.Location = New System.Drawing.Point(690, 9)
        Me.Button_Samples_By_Detectors.Name = "Button_Samples_By_Detectors"
        Me.Button_Samples_By_Detectors.Size = New System.Drawing.Size(142, 23)
        Me.Button_Samples_By_Detectors.TabIndex = 277
        Me.Button_Samples_By_Detectors.Text = "Samples by detectors"
        Me.Button_Samples_By_Detectors.UseVisualStyleBackColor = True
        '
        'L_Name_Sample_Set_View
        '
        Me.L_Name_Sample_Set_View.AutoSize = True
        Me.L_Name_Sample_Set_View.Location = New System.Drawing.Point(389, 414)
        Me.L_Name_Sample_Set_View.Name = "L_Name_Sample_Set_View"
        Me.L_Name_Sample_Set_View.Size = New System.Drawing.Size(89, 13)
        Me.L_Name_Sample_Set_View.TabIndex = 278
        Me.L_Name_Sample_Set_View.Text = "Sample sets view"
        '
        'L_Name_Person
        '
        Me.L_Name_Person.AutoSize = True
        Me.L_Name_Person.Location = New System.Drawing.Point(705, 377)
        Me.L_Name_Person.Name = "L_Name_Person"
        Me.L_Name_Person.Size = New System.Drawing.Size(40, 13)
        Me.L_Name_Person.TabIndex = 279
        Me.L_Name_Person.Text = "Person"
        '
        'L_Name_Person_Field_Name
        '
        Me.L_Name_Person_Field_Name.AutoSize = True
        Me.L_Name_Person_Field_Name.Location = New System.Drawing.Point(856, 377)
        Me.L_Name_Person_Field_Name.Name = "L_Name_Person_Field_Name"
        Me.L_Name_Person_Field_Name.Size = New System.Drawing.Size(91, 13)
        Me.L_Name_Person_Field_Name.TabIndex = 280
        Me.L_Name_Person_Field_Name.Text = "Person field name"
        '
        'L_Name_Date_Field_Name
        '
        Me.L_Name_Date_Field_Name.AutoSize = True
        Me.L_Name_Date_Field_Name.Location = New System.Drawing.Point(687, 312)
        Me.L_Name_Date_Field_Name.Name = "L_Name_Date_Field_Name"
        Me.L_Name_Date_Field_Name.Size = New System.Drawing.Size(81, 13)
        Me.L_Name_Date_Field_Name.TabIndex = 281
        Me.L_Name_Date_Field_Name.Text = "Date field name"
        '
        'L_Name_Time_Field_Name
        '
        Me.L_Name_Time_Field_Name.AutoSize = True
        Me.L_Name_Time_Field_Name.Location = New System.Drawing.Point(856, 312)
        Me.L_Name_Time_Field_Name.Name = "L_Name_Time_Field_Name"
        Me.L_Name_Time_Field_Name.Size = New System.Drawing.Size(81, 13)
        Me.L_Name_Time_Field_Name.TabIndex = 282
        Me.L_Name_Time_Field_Name.Text = "Time field name"
        '
        'L_Name_SRM_Set_View
        '
        Me.L_Name_SRM_Set_View.AutoSize = True
        Me.L_Name_SRM_Set_View.Location = New System.Drawing.Point(449, 545)
        Me.L_Name_SRM_Set_View.Name = "L_Name_SRM_Set_View"
        Me.L_Name_SRM_Set_View.Size = New System.Drawing.Size(78, 13)
        Me.L_Name_SRM_Set_View.TabIndex = 283
        Me.L_Name_SRM_Set_View.Text = "SRM sets view"
        '
        'L_Name_Monitor_Set_View
        '
        Me.L_Name_Monitor_Set_View.AutoSize = True
        Me.L_Name_Monitor_Set_View.Location = New System.Drawing.Point(449, 724)
        Me.L_Name_Monitor_Set_View.Name = "L_Name_Monitor_Set_View"
        Me.L_Name_Monitor_Set_View.Size = New System.Drawing.Size(89, 13)
        Me.L_Name_Monitor_Set_View.TabIndex = 284
        Me.L_Name_Monitor_Set_View.Text = "Monitor sets view"
        '
        'ComboBox_Sample_Geometry
        '
        Me.ComboBox_Sample_Geometry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sample_Geometry.Enabled = False
        Me.ComboBox_Sample_Geometry.FormattingEnabled = True
        Me.ComboBox_Sample_Geometry.Items.AddRange(New Object() {"2,5", "5", "10", "20"})
        Me.ComboBox_Sample_Geometry.Location = New System.Drawing.Point(414, 7)
        Me.ComboBox_Sample_Geometry.Name = "ComboBox_Sample_Geometry"
        Me.ComboBox_Sample_Geometry.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox_Sample_Geometry.TabIndex = 286
        '
        'L_Name_Sample_Geometry
        '
        Me.L_Name_Sample_Geometry.Location = New System.Drawing.Point(342, 9)
        Me.L_Name_Sample_Geometry.Name = "L_Name_Sample_Geometry"
        Me.L_Name_Sample_Geometry.Size = New System.Drawing.Size(66, 16)
        Me.L_Name_Sample_Geometry.TabIndex = 285
        Me.L_Name_Sample_Geometry.Text = "Высота, см"
        Me.L_Name_Sample_Geometry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Download
        '
        Me.TextBox_Download.Location = New System.Drawing.Point(291, 9)
        Me.TextBox_Download.Name = "TextBox_Download"
        Me.TextBox_Download.ReadOnly = True
        Me.TextBox_Download.Size = New System.Drawing.Size(34, 20)
        Me.TextBox_Download.TabIndex = 288
        '
        'L_Name_Download
        '
        Me.L_Name_Download.AutoSize = True
        Me.L_Name_Download.Location = New System.Drawing.Point(231, 13)
        Me.L_Name_Download.Name = "L_Name_Download"
        Me.L_Name_Download.Size = New System.Drawing.Size(54, 13)
        Me.L_Name_Download.TabIndex = 287
        Me.L_Name_Download.Text = "Загрузка"
        '
        'ButtonSaveSpectra
        '
        Me.ButtonSaveSpectra.Location = New System.Drawing.Point(542, 8)
        Me.ButtonSaveSpectra.Name = "ButtonSaveSpectra"
        Me.ButtonSaveSpectra.Size = New System.Drawing.Size(142, 23)
        Me.ButtonSaveSpectra.TabIndex = 289
        Me.ButtonSaveSpectra.Text = "Save Spectra"
        Me.ButtonSaveSpectra.UseVisualStyleBackColor = True
        '
        'Form_LLI_Irradiation_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 919)
        Me.Controls.Add(Me.ButtonSaveSpectra)
        Me.Controls.Add(Me.TextBox_Download)
        Me.Controls.Add(Me.L_Name_Download)
        Me.Controls.Add(Me.ComboBox_Sample_Geometry)
        Me.Controls.Add(Me.L_Name_Sample_Geometry)
        Me.Controls.Add(Me.L_Name_Monitor_Set_View)
        Me.Controls.Add(Me.L_Name_SRM_Set_View)
        Me.Controls.Add(Me.L_Name_Time_Field_Name)
        Me.Controls.Add(Me.L_Name_Date_Field_Name)
        Me.Controls.Add(Me.L_Name_Person_Field_Name)
        Me.Controls.Add(Me.L_Name_Person)
        Me.Controls.Add(Me.L_Name_Sample_Set_View)
        Me.Controls.Add(Me.TextBox_Paper_Log_LLI1)
        Me.Controls.Add(Me.TextBox_Paper_Log_LLI2)
        Me.Controls.Add(Me.Button_Paper_Log_LLI2)
        Me.Controls.Add(Me.L_Name_Paper_Log_LLI2)
        Me.Controls.Add(Me.Button_Paper_Log_LLI1)
        Me.Controls.Add(Me.L_Name_Paper_Log_LLI1)
        Me.Controls.Add(Me.Button_Samples_By_Detectors)
        Me.Controls.Add(Me.L_Name_Sample_All_LLI_Weight)
        Me.Controls.Add(Me.ListBox_Sample_ID_All_LLI_Weight)
        Me.Controls.Add(Me.TextBox_LLI1_Spectrum_File)
        Me.Controls.Add(Me.TextBox_LLI2_Spectrum_File)
        Me.Controls.Add(Me.Button_LLI2_Spectrum_File)
        Me.Controls.Add(Me.L_Name_LLI2_Spectrum_File)
        Me.Controls.Add(Me.Button_LLI1_Spectrum_File)
        Me.Controls.Add(Me.L_Name_LLI1_Spectrum_File)
        Me.Controls.Add(Me.Button_Save_LLI_Log_To_File)
        Me.Controls.Add(Me.ComboBox_Monitor_Set_View)
        Me.Controls.Add(Me.ComboBox_SRM_Set_View)
        Me.Controls.Add(Me.L_Monitor)
        Me.Controls.Add(Me.TextBox_Container_Number)
        Me.Controls.Add(Me.B_Fill_In_Container_Number)
        Me.Controls.Add(Me.L_Name_Container_Number)
        Me.Controls.Add(Me.ComboBox_Channel)
        Me.Controls.Add(Me.B_Fill_In_Channel)
        Me.Controls.Add(Me.L_Name_Channel)
        Me.Controls.Add(Me.B_Save_And_Update_LLI)
        Me.Controls.Add(Me.B_Fill_In_Person)
        Me.Controls.Add(Me.ComboBox_Person_Field_Name)
        Me.Controls.Add(Me.B_Fill_In_Time)
        Me.Controls.Add(Me.ComboBox_Time_Field_Name)
        Me.Controls.Add(Me.B_Fill_In_Date)
        Me.Controls.Add(Me.ComboBox_Date_Field_Name)
        Me.Controls.Add(Me.L_Name_Date)
        Me.Controls.Add(Me.MaskedTextBox_Date)
        Me.Controls.Add(Me.ComboBox_Sample_Set_View)
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
        Me.Controls.Add(Me.ComboBox_Person)
        Me.Controls.Add(Me.B_Delete_Sample_From_Log)
        Me.Controls.Add(Me.L_Name_Time)
        Me.Controls.Add(Me.MaskedTextBox_Time)
        Me.Controls.Add(Me.B_Add_Sample)
        Me.Controls.Add(Me.ListBox_Sample_ID)
        Me.Controls.Add(Me.DataGridView_LLI_Sample_Set)
        Me.Controls.Add(Me.MaskedTextBox_LLI_Irradiation_Log)
        Me.Controls.Add(Me.L_Name_LLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.DataGridView_LLI_Irradiation_Log)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_LLI_Irradiation_Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LLI irradiation log"
        CType(Me.DataGridView_Table_Monitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_Monitor_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_SRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_SRM_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_LLI_Sample_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_LLI_Irradiation_Log, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_LLI_Irradiation_Log_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_Sample_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents B_Find_Sample_Set As System.Windows.Forms.Button
    Friend WithEvents B_Set_SRM_As_Not_In_Use As System.Windows.Forms.Button
    Friend WithEvents B_Set_Monitor_As_Not_In_Use As System.Windows.Forms.Button
    Friend WithEvents B_Delete_Monitor_From_Log As System.Windows.Forms.Button
    Friend WithEvents B_Add_Monitor As System.Windows.Forms.Button
    Friend WithEvents L_Name_Monitor As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Table_Monitor As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView_Table_Monitor_Set As System.Windows.Forms.DataGridView
    Friend WithEvents L_Name_Monitor_Set As System.Windows.Forms.Label
    Friend WithEvents B_Delete_Last_Irradiation_Date_From_Log As System.Windows.Forms.Button
    Friend WithEvents B_Add_SRM As System.Windows.Forms.Button
    Friend WithEvents L_Name_SRM As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Table_SRM As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView_Table_SRM_Set As System.Windows.Forms.DataGridView
    Friend WithEvents L_Name_SRM_Set As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample_Set As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Person As System.Windows.Forms.ComboBox
    Friend WithEvents B_Delete_Sample_From_Log As System.Windows.Forms.Button
    Friend WithEvents L_Name_Time As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_Time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents B_Add_Sample As System.Windows.Forms.Button
    Friend WithEvents ListBox_Sample_ID As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView_LLI_Sample_Set As System.Windows.Forms.DataGridView
    Friend WithEvents MaskedTextBox_LLI_Irradiation_Log As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_LLI_Irradiation_Log As System.Windows.Forms.Label
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents DataGridView_LLI_Irradiation_Log As System.Windows.Forms.DataGridView
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_LLI_Irradiation_Log_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_LLI_Irradiation_Log_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_LLI_Irradiation_LogTableAdapter
    Friend WithEvents Table_Received_By_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Received_By_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter
    Friend WithEvents Table_Sample_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Sample_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter
    Friend WithEvents Table_SRM_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter
    Friend WithEvents SRMSetNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetPurchasingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table_Monitor_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Monitor_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter
    Friend WithEvents MonitorSetNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetPurchasingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSLINotInUseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Table_Monitor_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter
    Friend WithEvents Table_Monitor_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_MonitorTableAdapter
    Friend WithEvents SRM_Number As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents MonitorNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorLLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monitor_LLI_Date_Start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox_Date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_Date As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Date_Field_Name As System.Windows.Forms.ComboBox
    Friend WithEvents B_Fill_In_Date As System.Windows.Forms.Button
    Friend WithEvents B_Fill_In_Time As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Time_Field_Name As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Person_Field_Name As System.Windows.Forms.ComboBox
    Friend WithEvents B_Fill_In_Person As System.Windows.Forms.Button
    Friend WithEvents B_Save_And_Update_LLI As System.Windows.Forms.Button
    Friend WithEvents TextBox_Container_Number As System.Windows.Forms.TextBox
    Friend WithEvents B_Fill_In_Container_Number As System.Windows.Forms.Button
    Friend WithEvents L_Name_Container_Number As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Channel As System.Windows.Forms.ComboBox
    Friend WithEvents B_Fill_In_Channel As System.Windows.Forms.Button
    Friend WithEvents L_Name_Channel As System.Windows.Forms.Label
    Friend WithEvents TextBox_Paper_Log_LLI2 As System.Windows.Forms.TextBox
    Friend WithEvents Button_Paper_Log_LLI2 As System.Windows.Forms.Button
    Friend WithEvents L_Name_Paper_Log_LLI2 As System.Windows.Forms.Label
    Friend WithEvents Button_Paper_Log_LLI1 As System.Windows.Forms.Button
    Friend WithEvents L_Name_Paper_Log_LLI1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Paper_Log_LLI1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Monitor As System.Windows.Forms.Label
    Friend WithEvents ComboBox_SRM_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Monitor_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Save_LLI_Log_To_File As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_LLI As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox_LLI1_Spectrum_File As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_LLI2_Spectrum_File As System.Windows.Forms.TextBox
    Friend WithEvents Button_LLI2_Spectrum_File As System.Windows.Forms.Button
    Friend WithEvents L_Name_LLI2_Spectrum_File As System.Windows.Forms.Label
    Friend WithEvents Button_LLI1_Spectrum_File As System.Windows.Forms.Button
    Friend WithEvents L_Name_LLI1_Spectrum_File As System.Windows.Forms.Label
    Friend WithEvents CountryCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIndexDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetIndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChannelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFinishDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFinishDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefDateStart1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefTimeStart1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefDateFinish1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefTimeFinish1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefDateStart2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefTimeStart2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefDateFinish2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerReliefTimeFinish2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContainerNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IrradiatedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRehadleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RehandledByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateMeasurementLLI1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detector1MeasurementLLI1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detector2MeasurementLLI1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Detector3MeasurementLLI1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Detector4MeasurementLLI1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PaperLogLLI1NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeasuredLLI1ByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateMeasurementLLI2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detector1MeasurementLLI2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detector2MeasurementLLI2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Detector3MeasurementLLI2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Detector4MeasurementLLI2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PaperLogLLI2NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeasuredLLI2ByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L_Name_Sample_All_LLI_Weight As System.Windows.Forms.Label
    Friend WithEvents ListBox_Sample_ID_All_LLI_Weight As System.Windows.Forms.ListBox
    Friend WithEvents Button_Samples_By_Detectors As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_Sample_By_Detector As System.Windows.Forms.SaveFileDialog
    Friend WithEvents L_Name_Sample_Set_View As System.Windows.Forms.Label
    Friend WithEvents L_Name_Person As System.Windows.Forms.Label
    Friend WithEvents L_Name_Person_Field_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_Date_Field_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_Time_Field_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_SRM_Set_View As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set_View As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sample_Geometry As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Sample_Geometry As System.Windows.Forms.Label
    Friend WithEvents TextBox_Download As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Download As System.Windows.Forms.Label
    Friend WithEvents ButtonSaveSpectra As Button
    Friend WithEvents FolderBrowserDialogSaveSpectra As FolderBrowserDialog
End Class
