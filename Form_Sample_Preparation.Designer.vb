<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Sample_Preparation
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
        Me.B_Save = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.Label_Name_Code = New System.Windows.Forms.Label()
        Me.L_SS_Sample_Set_ID = New System.Windows.Forms.Label()
        Me.L_SS_Client_ID = New System.Windows.Forms.Label()
        Me.L_SS_Year = New System.Windows.Forms.Label()
        Me.L_SS_Country_Code = New System.Windows.Forms.Label()
        Me.Received_ByComboBox = New System.Windows.Forms.ComboBox()
        Me.Table_Received_By_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.B_Select_All = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Cleaning = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Drying = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Evaporation = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Freeze_Drying = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Homogenizing = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Pelletization = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Fragmentation = New System.Windows.Forms.Button()
        Me.B_Check_Selected_Maked_By = New System.Windows.Forms.Button()
        Me.B_Fill_Weighting_From_File = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Weighting = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView_Table_Sample = New System.Windows.Forms.DataGridView()
        Me.ASampleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_Client_Sample_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCleaningFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PDryingFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PEvaporationFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PFreezeDryingFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PHomogenizingFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PPelletizationFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PFragmentationFactDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PWeightingSLIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PWeightingLLIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDateSamplePreparationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMakedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Sample_Sample_Preparation_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_SS_Sample_Set_Index = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.Table_Received_By_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter()
        Me.Table_Sample_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_Sample_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter()
        Me.Table_Sample_Sample_Preparation_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_Sample_Preparation_TableAdapter()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Table_Sample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_Sample_Preparation_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_Save
        '
        Me.B_Save.Location = New System.Drawing.Point(473, 369)
        Me.B_Save.Name = "B_Save"
        Me.B_Save.Size = New System.Drawing.Size(114, 23)
        Me.B_Save.TabIndex = 2
        Me.B_Save.Text = "Save"
        Me.B_Save.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(593, 369)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(114, 23)
        Me.B_Close.TabIndex = 3
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'Label_Name_Code
        '
        Me.Label_Name_Code.AutoSize = True
        Me.Label_Name_Code.Location = New System.Drawing.Point(410, 9)
        Me.Label_Name_Code.Name = "Label_Name_Code"
        Me.Label_Name_Code.Size = New System.Drawing.Size(177, 13)
        Me.Label_Name_Code.TabIndex = 143
        Me.Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
        '
        'L_SS_Sample_Set_ID
        '
        Me.L_SS_Sample_Set_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_ID.Location = New System.Drawing.Point(518, 22)
        Me.L_SS_Sample_Set_ID.Name = "L_SS_Sample_Set_ID"
        Me.L_SS_Sample_Set_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Sample_Set_ID.TabIndex = 141
        '
        'L_SS_Client_ID
        '
        Me.L_SS_Client_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Client_ID.Location = New System.Drawing.Point(458, 22)
        Me.L_SS_Client_ID.Name = "L_SS_Client_ID"
        Me.L_SS_Client_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Client_ID.TabIndex = 139
        '
        'L_SS_Year
        '
        Me.L_SS_Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Year.Location = New System.Drawing.Point(488, 22)
        Me.L_SS_Year.Name = "L_SS_Year"
        Me.L_SS_Year.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Year.TabIndex = 138
        '
        'L_SS_Country_Code
        '
        Me.L_SS_Country_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Country_Code.Location = New System.Drawing.Point(424, 22)
        Me.L_SS_Country_Code.Name = "L_SS_Country_Code"
        Me.L_SS_Country_Code.Size = New System.Drawing.Size(26, 14)
        Me.L_SS_Country_Code.TabIndex = 136
        '
        'Received_ByComboBox
        '
        Me.Received_ByComboBox.DataSource = Me.Table_Received_By_BindingSource
        Me.Received_ByComboBox.DisplayMember = "Received_By"
        Me.Received_ByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Received_ByComboBox.FormattingEnabled = True
        Me.Received_ByComboBox.Location = New System.Drawing.Point(929, 300)
        Me.Received_ByComboBox.Name = "Received_ByComboBox"
        Me.Received_ByComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Received_ByComboBox.TabIndex = 144
        Me.Received_ByComboBox.ValueMember = "Received_By"
        '
        'Table_Received_By_BindingSource
        '
        Me.Table_Received_By_BindingSource.DataMember = "table_Received_By"
        Me.Table_Received_By_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'B_Select_All
        '
        Me.B_Select_All.Location = New System.Drawing.Point(353, 369)
        Me.B_Select_All.Name = "B_Select_All"
        Me.B_Select_All.Size = New System.Drawing.Size(114, 23)
        Me.B_Select_All.TabIndex = 145
        Me.B_Select_All.Text = "Select all rows"
        Me.B_Select_All.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Cleaning
        '
        Me.B_Check_Selected_Cleaning.Location = New System.Drawing.Point(12, 300)
        Me.B_Check_Selected_Cleaning.Name = "B_Check_Selected_Cleaning"
        Me.B_Check_Selected_Cleaning.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Cleaning.TabIndex = 146
        Me.B_Check_Selected_Cleaning.Text = "Check selected 'Cleaning'"
        Me.B_Check_Selected_Cleaning.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Drying
        '
        Me.B_Check_Selected_Drying.Location = New System.Drawing.Point(126, 300)
        Me.B_Check_Selected_Drying.Name = "B_Check_Selected_Drying"
        Me.B_Check_Selected_Drying.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Drying.TabIndex = 147
        Me.B_Check_Selected_Drying.Text = "Check selected 'Drying'"
        Me.B_Check_Selected_Drying.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Evaporation
        '
        Me.B_Check_Selected_Evaporation.Location = New System.Drawing.Point(240, 300)
        Me.B_Check_Selected_Evaporation.Name = "B_Check_Selected_Evaporation"
        Me.B_Check_Selected_Evaporation.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Evaporation.TabIndex = 148
        Me.B_Check_Selected_Evaporation.Text = "Check selected 'Evaporation'"
        Me.B_Check_Selected_Evaporation.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Freeze_Drying
        '
        Me.B_Check_Selected_Freeze_Drying.Location = New System.Drawing.Point(353, 300)
        Me.B_Check_Selected_Freeze_Drying.Name = "B_Check_Selected_Freeze_Drying"
        Me.B_Check_Selected_Freeze_Drying.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Freeze_Drying.TabIndex = 149
        Me.B_Check_Selected_Freeze_Drying.Text = "Check selected 'Freeze Drying'"
        Me.B_Check_Selected_Freeze_Drying.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Homogenizing
        '
        Me.B_Check_Selected_Homogenizing.Location = New System.Drawing.Point(467, 300)
        Me.B_Check_Selected_Homogenizing.Name = "B_Check_Selected_Homogenizing"
        Me.B_Check_Selected_Homogenizing.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Homogenizing.TabIndex = 150
        Me.B_Check_Selected_Homogenizing.Text = "Check selected 'Homogenizing'"
        Me.B_Check_Selected_Homogenizing.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Pelletization
        '
        Me.B_Check_Selected_Pelletization.Location = New System.Drawing.Point(581, 300)
        Me.B_Check_Selected_Pelletization.Name = "B_Check_Selected_Pelletization"
        Me.B_Check_Selected_Pelletization.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Pelletization.TabIndex = 151
        Me.B_Check_Selected_Pelletization.Text = "Check selected 'Pelletization'"
        Me.B_Check_Selected_Pelletization.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Fragmentation
        '
        Me.B_Check_Selected_Fragmentation.Location = New System.Drawing.Point(695, 300)
        Me.B_Check_Selected_Fragmentation.Name = "B_Check_Selected_Fragmentation"
        Me.B_Check_Selected_Fragmentation.Size = New System.Drawing.Size(108, 63)
        Me.B_Check_Selected_Fragmentation.TabIndex = 152
        Me.B_Check_Selected_Fragmentation.Text = "Check selected 'Fragmentation'"
        Me.B_Check_Selected_Fragmentation.UseVisualStyleBackColor = True
        '
        'B_Check_Selected_Maked_By
        '
        Me.B_Check_Selected_Maked_By.Location = New System.Drawing.Point(929, 328)
        Me.B_Check_Selected_Maked_By.Name = "B_Check_Selected_Maked_By"
        Me.B_Check_Selected_Maked_By.Size = New System.Drawing.Size(121, 35)
        Me.B_Check_Selected_Maked_By.TabIndex = 153
        Me.B_Check_Selected_Maked_By.Text = "Check selected 'Maked by'"
        Me.B_Check_Selected_Maked_By.UseVisualStyleBackColor = True
        '
        'B_Fill_Weighting_From_File
        '
        Me.B_Fill_Weighting_From_File.Location = New System.Drawing.Point(809, 300)
        Me.B_Fill_Weighting_From_File.Name = "B_Fill_Weighting_From_File"
        Me.B_Fill_Weighting_From_File.Size = New System.Drawing.Size(114, 63)
        Me.B_Fill_Weighting_From_File.TabIndex = 154
        Me.B_Fill_Weighting_From_File.Text = "Fill in weights from file"
        Me.B_Fill_Weighting_From_File.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_Weighting
        '
        Me.OpenFileDialog_Weighting.Filter = "Weighting files (*.ves)|*.ves|All files (*.*)|*.*"
        Me.OpenFileDialog_Weighting.InitialDirectory = "C:/"
        '
        'DataGridView_Table_Sample
        '
        Me.DataGridView_Table_Sample.AllowUserToAddRows = False
        Me.DataGridView_Table_Sample.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Sample.AllowUserToResizeRows = False
        Me.DataGridView_Table_Sample.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Sample.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Table_Sample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Sample.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ASampleIDDataGridViewTextBoxColumn, Me.A_Client_Sample_ID, Me.PCleaningFactDataGridViewCheckBoxColumn, Me.PDryingFactDataGridViewCheckBoxColumn, Me.PEvaporationFactDataGridViewCheckBoxColumn, Me.PFreezeDryingFactDataGridViewCheckBoxColumn, Me.PHomogenizingFactDataGridViewCheckBoxColumn, Me.PPelletizationFactDataGridViewCheckBoxColumn, Me.PFragmentationFactDataGridViewCheckBoxColumn, Me.PWeightingSLIDataGridViewTextBoxColumn, Me.PWeightingLLIDataGridViewTextBoxColumn, Me.PDateSamplePreparationDataGridViewTextBoxColumn, Me.PMakedByDataGridViewTextBoxColumn})
        Me.DataGridView_Table_Sample.DataSource = Me.Table_Sample_Sample_Preparation_BindingSource
        Me.DataGridView_Table_Sample.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView_Table_Sample.Name = "DataGridView_Table_Sample"
        Me.DataGridView_Table_Sample.RowHeadersWidth = 21
        Me.DataGridView_Table_Sample.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Sample.Size = New System.Drawing.Size(1038, 245)
        Me.DataGridView_Table_Sample.TabIndex = 154
        '
        'ASampleIDDataGridViewTextBoxColumn
        '
        Me.ASampleIDDataGridViewTextBoxColumn.DataPropertyName = "A_Sample_ID"
        Me.ASampleIDDataGridViewTextBoxColumn.HeaderText = "A_Sample_ID"
        Me.ASampleIDDataGridViewTextBoxColumn.Name = "ASampleIDDataGridViewTextBoxColumn"
        '
        'A_Client_Sample_ID
        '
        Me.A_Client_Sample_ID.DataPropertyName = "A_Client_Sample_ID"
        Me.A_Client_Sample_ID.HeaderText = "A_Client_Sample_ID"
        Me.A_Client_Sample_ID.Name = "A_Client_Sample_ID"
        '
        'PCleaningFactDataGridViewCheckBoxColumn
        '
        Me.PCleaningFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Cleaning_Fact"
        Me.PCleaningFactDataGridViewCheckBoxColumn.HeaderText = "P_Cleaning_Fact"
        Me.PCleaningFactDataGridViewCheckBoxColumn.Name = "PCleaningFactDataGridViewCheckBoxColumn"
        '
        'PDryingFactDataGridViewCheckBoxColumn
        '
        Me.PDryingFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Drying_Fact"
        Me.PDryingFactDataGridViewCheckBoxColumn.HeaderText = "P_Drying_Fact"
        Me.PDryingFactDataGridViewCheckBoxColumn.Name = "PDryingFactDataGridViewCheckBoxColumn"
        '
        'PEvaporationFactDataGridViewCheckBoxColumn
        '
        Me.PEvaporationFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Evaporation_Fact"
        Me.PEvaporationFactDataGridViewCheckBoxColumn.HeaderText = "P_Evaporation_Fact"
        Me.PEvaporationFactDataGridViewCheckBoxColumn.Name = "PEvaporationFactDataGridViewCheckBoxColumn"
        '
        'PFreezeDryingFactDataGridViewCheckBoxColumn
        '
        Me.PFreezeDryingFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Freeze_Drying_Fact"
        Me.PFreezeDryingFactDataGridViewCheckBoxColumn.HeaderText = "P_Freeze_Drying_Fact"
        Me.PFreezeDryingFactDataGridViewCheckBoxColumn.Name = "PFreezeDryingFactDataGridViewCheckBoxColumn"
        '
        'PHomogenizingFactDataGridViewCheckBoxColumn
        '
        Me.PHomogenizingFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Homogenizing_Fact"
        Me.PHomogenizingFactDataGridViewCheckBoxColumn.HeaderText = "P_Homogenizing_Fact"
        Me.PHomogenizingFactDataGridViewCheckBoxColumn.Name = "PHomogenizingFactDataGridViewCheckBoxColumn"
        '
        'PPelletizationFactDataGridViewCheckBoxColumn
        '
        Me.PPelletizationFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Pelletization_Fact"
        Me.PPelletizationFactDataGridViewCheckBoxColumn.HeaderText = "P_Pelletization_Fact"
        Me.PPelletizationFactDataGridViewCheckBoxColumn.Name = "PPelletizationFactDataGridViewCheckBoxColumn"
        '
        'PFragmentationFactDataGridViewCheckBoxColumn
        '
        Me.PFragmentationFactDataGridViewCheckBoxColumn.DataPropertyName = "P_Fragmentation_Fact"
        Me.PFragmentationFactDataGridViewCheckBoxColumn.HeaderText = "P_Fragmentation_Fact"
        Me.PFragmentationFactDataGridViewCheckBoxColumn.Name = "PFragmentationFactDataGridViewCheckBoxColumn"
        '
        'PWeightingSLIDataGridViewTextBoxColumn
        '
        Me.PWeightingSLIDataGridViewTextBoxColumn.DataPropertyName = "P_Weighting_SLI"
        Me.PWeightingSLIDataGridViewTextBoxColumn.HeaderText = "P_Weighting_SLI"
        Me.PWeightingSLIDataGridViewTextBoxColumn.Name = "PWeightingSLIDataGridViewTextBoxColumn"
        '
        'PWeightingLLIDataGridViewTextBoxColumn
        '
        Me.PWeightingLLIDataGridViewTextBoxColumn.DataPropertyName = "P_Weighting_LLI"
        Me.PWeightingLLIDataGridViewTextBoxColumn.HeaderText = "P_Weighting_LLI"
        Me.PWeightingLLIDataGridViewTextBoxColumn.Name = "PWeightingLLIDataGridViewTextBoxColumn"
        '
        'PDateSamplePreparationDataGridViewTextBoxColumn
        '
        Me.PDateSamplePreparationDataGridViewTextBoxColumn.DataPropertyName = "P_Date_Sample_Preparation"
        Me.PDateSamplePreparationDataGridViewTextBoxColumn.HeaderText = "P_Date_Sample_Preparation"
        Me.PDateSamplePreparationDataGridViewTextBoxColumn.Name = "PDateSamplePreparationDataGridViewTextBoxColumn"
        '
        'PMakedByDataGridViewTextBoxColumn
        '
        Me.PMakedByDataGridViewTextBoxColumn.DataPropertyName = "P_Maked_By"
        Me.PMakedByDataGridViewTextBoxColumn.HeaderText = "P_Maked_By"
        Me.PMakedByDataGridViewTextBoxColumn.Name = "PMakedByDataGridViewTextBoxColumn"
        '
        'Table_Sample_Sample_Preparation_BindingSource
        '
        Me.Table_Sample_Sample_Preparation_BindingSource.DataMember = "table_Sample_Sample_Preparation"
        Me.Table_Sample_Sample_Preparation_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'L_SS_Sample_Set_Index
        '
        Me.L_SS_Sample_Set_Index.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_Index.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_SS_Sample_Set_Index.Location = New System.Drawing.Point(548, 22)
        Me.L_SS_Sample_Set_Index.Name = "L_SS_Sample_Set_Index"
        Me.L_SS_Sample_Set_Index.Size = New System.Drawing.Size(24, 24)
        Me.L_SS_Sample_Set_Index.TabIndex = 155
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
        'Table_Received_By_TableAdapter
        '
        Me.Table_Received_By_TableAdapter.ClearBeforeFill = True
        '
        'Table_Sample_Set_BindingSource
        '
        Me.Table_Sample_Set_BindingSource.DataMember = "table_Sample_Set"
        Me.Table_Sample_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_Sample_Set_TableAdapter
        '
        Me.Table_Sample_Set_TableAdapter.ClearBeforeFill = True
        '
        'Table_Sample_Sample_Preparation_TableAdapter
        '
        Me.Table_Sample_Sample_Preparation_TableAdapter.ClearBeforeFill = True
        '
        'Form_Sample_Preparation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 396)
        Me.Controls.Add(Me.L_SS_Sample_Set_Index)
        Me.Controls.Add(Me.DataGridView_Table_Sample)
        Me.Controls.Add(Me.B_Fill_Weighting_From_File)
        Me.Controls.Add(Me.B_Check_Selected_Maked_By)
        Me.Controls.Add(Me.B_Check_Selected_Fragmentation)
        Me.Controls.Add(Me.B_Check_Selected_Pelletization)
        Me.Controls.Add(Me.B_Check_Selected_Homogenizing)
        Me.Controls.Add(Me.B_Check_Selected_Freeze_Drying)
        Me.Controls.Add(Me.B_Check_Selected_Evaporation)
        Me.Controls.Add(Me.B_Check_Selected_Drying)
        Me.Controls.Add(Me.B_Check_Selected_Cleaning)
        Me.Controls.Add(Me.B_Select_All)
        Me.Controls.Add(Me.Received_ByComboBox)
        Me.Controls.Add(Me.Label_Name_Code)
        Me.Controls.Add(Me.L_SS_Sample_Set_ID)
        Me.Controls.Add(Me.L_SS_Client_ID)
        Me.Controls.Add(Me.L_SS_Year)
        Me.Controls.Add(Me.L_SS_Country_Code)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Sample_Preparation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sample preparation"
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Table_Sample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_Sample_Preparation_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B_Save As System.Windows.Forms.Button
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents Label_Name_Code As System.Windows.Forms.Label
    Friend WithEvents L_SS_Sample_Set_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Client_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Year As System.Windows.Forms.Label
    Friend WithEvents L_SS_Country_Code As System.Windows.Forms.Label
    Friend WithEvents Table_Received_By_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter
    Friend WithEvents Received_ByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents B_Select_All As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Cleaning As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Drying As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Evaporation As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Freeze_Drying As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Homogenizing As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Pelletization As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Fragmentation As System.Windows.Forms.Button
    Friend WithEvents B_Check_Selected_Maked_By As System.Windows.Forms.Button
    Friend WithEvents Table_Received_By_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents B_Fill_Weighting_From_File As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Weighting As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table_Sample_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Sample_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter
    Friend WithEvents DataGridView_Table_Sample As System.Windows.Forms.DataGridView
    Friend WithEvents L_SS_Sample_Set_Index As System.Windows.Forms.Label
    Friend WithEvents Table_Sample_Sample_Preparation_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_Sample_Preparation_TableAdapter
    Friend WithEvents FCountryCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FClientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSampleSetIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSampleSetIndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table_Sample_Sample_Preparation_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASampleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_Client_Sample_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCleaningFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PDryingFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PEvaporationFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PFreezeDryingFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PHomogenizingFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PPelletizationFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PFragmentationFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PWeightingSLIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PWeightingLLIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDateSamplePreparationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMakedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
