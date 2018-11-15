<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SRM_Accept
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
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.Table_SRM_SetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_SRM_SetTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.Table_SRMTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter()
        Me.TableSRMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Name_Weight_Balance = New System.Windows.Forms.Label()
        Me.L_Weight_Balance = New System.Windows.Forms.Label()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Weighting_SLI_LLI = New System.Windows.Forms.OpenFileDialog()
        Me.L_SRM_Set_Name = New System.Windows.Forms.Label()
        Me.L_Name_SRM_Set_Name = New System.Windows.Forms.Label()
        Me.L_SRM_Set_Number = New System.Windows.Forms.Label()
        Me.L_Name_SRM_Set_Number = New System.Windows.Forms.Label()
        Me.L_SRM_Set_Weight = New System.Windows.Forms.Label()
        Me.L_Name_SRM_Set_Weight = New System.Windows.Forms.Label()
        Me.Table_SRMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_Fill_SRM_From_File = New System.Windows.Forms.Button()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_SetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableSRMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_SRM_SetBindingSource
        '
        Me.Table_SRM_SetBindingSource.DataMember = "table_SRM_Set"
        Me.Table_SRM_SetBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_SRM_SetTableAdapter
        '
        Me.Table_SRM_SetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.table_SRM_SetTableAdapter = Me.Table_SRM_SetTableAdapter
        Me.TableAdapterManager.table_SRMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table_SRMTableAdapter
        '
        Me.Table_SRMTableAdapter.ClearBeforeFill = True
        '
        'TableSRMBindingSource
        '
        Me.TableSRMBindingSource.DataMember = "table_SRM"
        Me.TableSRMBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'L_Name_Weight_Balance
        '
        Me.L_Name_Weight_Balance.AutoSize = True
        Me.L_Name_Weight_Balance.Location = New System.Drawing.Point(75, 240)
        Me.L_Name_Weight_Balance.Name = "L_Name_Weight_Balance"
        Me.L_Name_Weight_Balance.Size = New System.Drawing.Size(94, 13)
        Me.L_Name_Weight_Balance.TabIndex = 1
        Me.L_Name_Weight_Balance.Text = "Weight balance, g"
        '
        'L_Weight_Balance
        '
        Me.L_Weight_Balance.AutoSize = True
        Me.L_Weight_Balance.Location = New System.Drawing.Point(175, 240)
        Me.L_Weight_Balance.Name = "L_Weight_Balance"
        Me.L_Weight_Balance.Size = New System.Drawing.Size(33, 13)
        Me.L_Weight_Balance.TabIndex = 2
        Me.L_Weight_Balance.Text = "Label"
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(26, 296)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(231, 23)
        Me.B_Close.TabIndex = 3
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_Weighting_SLI_LLI
        '
        Me.OpenFileDialog_Weighting_SLI_LLI.Filter = "Weighting files (*.ves)|*.ves|All files (*.*)|*.*"
        Me.OpenFileDialog_Weighting_SLI_LLI.RestoreDirectory = True
        '
        'L_SRM_Set_Name
        '
        Me.L_SRM_Set_Name.AutoSize = True
        Me.L_SRM_Set_Name.Location = New System.Drawing.Point(53, 22)
        Me.L_SRM_Set_Name.Name = "L_SRM_Set_Name"
        Me.L_SRM_Set_Name.Size = New System.Drawing.Size(33, 13)
        Me.L_SRM_Set_Name.TabIndex = 7
        Me.L_SRM_Set_Name.Text = "Label"
        '
        'L_Name_SRM_Set_Name
        '
        Me.L_Name_SRM_Set_Name.AutoSize = True
        Me.L_Name_SRM_Set_Name.Location = New System.Drawing.Point(9, 9)
        Me.L_Name_SRM_Set_Name.Name = "L_Name_SRM_Set_Name"
        Me.L_Name_SRM_Set_Name.Size = New System.Drawing.Size(77, 13)
        Me.L_Name_SRM_Set_Name.TabIndex = 6
        Me.L_Name_SRM_Set_Name.Text = "SRM set name"
        '
        'L_SRM_Set_Number
        '
        Me.L_SRM_Set_Number.AutoSize = True
        Me.L_SRM_Set_Number.Location = New System.Drawing.Point(179, 22)
        Me.L_SRM_Set_Number.Name = "L_SRM_Set_Number"
        Me.L_SRM_Set_Number.Size = New System.Drawing.Size(33, 13)
        Me.L_SRM_Set_Number.TabIndex = 9
        Me.L_SRM_Set_Number.Text = "Label"
        '
        'L_Name_SRM_Set_Number
        '
        Me.L_Name_SRM_Set_Number.AutoSize = True
        Me.L_Name_SRM_Set_Number.Location = New System.Drawing.Point(143, 9)
        Me.L_Name_SRM_Set_Number.Name = "L_Name_SRM_Set_Number"
        Me.L_Name_SRM_Set_Number.Size = New System.Drawing.Size(86, 13)
        Me.L_Name_SRM_Set_Number.TabIndex = 8
        Me.L_Name_SRM_Set_Number.Text = "SRM set number"
        '
        'L_SRM_Set_Weight
        '
        Me.L_SRM_Set_Weight.AutoSize = True
        Me.L_SRM_Set_Weight.Location = New System.Drawing.Point(111, 60)
        Me.L_SRM_Set_Weight.Name = "L_SRM_Set_Weight"
        Me.L_SRM_Set_Weight.Size = New System.Drawing.Size(33, 13)
        Me.L_SRM_Set_Weight.TabIndex = 11
        Me.L_SRM_Set_Weight.Text = "Label"
        '
        'L_Name_SRM_Set_Weight
        '
        Me.L_Name_SRM_Set_Weight.AutoSize = True
        Me.L_Name_SRM_Set_Weight.Location = New System.Drawing.Point(60, 47)
        Me.L_Name_SRM_Set_Weight.Name = "L_Name_SRM_Set_Weight"
        Me.L_Name_SRM_Set_Weight.Size = New System.Drawing.Size(109, 13)
        Me.L_Name_SRM_Set_Weight.TabIndex = 10
        Me.L_Name_SRM_Set_Weight.Text = "Weight of SRM set, g"
        '
        'Table_SRMDataGridView
        '
        Me.Table_SRMDataGridView.AllowUserToAddRows = False
        Me.Table_SRMDataGridView.AllowUserToDeleteRows = False
        Me.Table_SRMDataGridView.AllowUserToResizeColumns = False
        Me.Table_SRMDataGridView.AllowUserToResizeRows = False
        Me.Table_SRMDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_SRMDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table_SRMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_SRMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Table_SRMDataGridView.DataSource = Me.TableSRMBindingSource
        Me.Table_SRMDataGridView.Location = New System.Drawing.Point(12, 76)
        Me.Table_SRMDataGridView.Name = "Table_SRMDataGridView"
        Me.Table_SRMDataGridView.RowHeadersWidth = 21
        Me.Table_SRMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_SRMDataGridView.Size = New System.Drawing.Size(263, 151)
        Me.Table_SRMDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SRM_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SRM number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SRM_SLI_Weight"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SRM SLI weight, g"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SRM_LLI_Weight"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SRM LLI weight, g"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'B_Fill_SRM_From_File
        '
        Me.B_Fill_SRM_From_File.Location = New System.Drawing.Point(26, 267)
        Me.B_Fill_SRM_From_File.Name = "B_Fill_SRM_From_File"
        Me.B_Fill_SRM_From_File.Size = New System.Drawing.Size(231, 23)
        Me.B_Fill_SRM_From_File.TabIndex = 12
        Me.B_Fill_SRM_From_File.Text = "Fill in SRM weight from file"
        Me.B_Fill_SRM_From_File.UseVisualStyleBackColor = True
        '
        'Form_SRM_Accept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 324)
        Me.Controls.Add(Me.B_Fill_SRM_From_File)
        Me.Controls.Add(Me.Table_SRMDataGridView)
        Me.Controls.Add(Me.L_SRM_Set_Weight)
        Me.Controls.Add(Me.L_Name_SRM_Set_Weight)
        Me.Controls.Add(Me.L_SRM_Set_Number)
        Me.Controls.Add(Me.L_Name_SRM_Set_Number)
        Me.Controls.Add(Me.L_SRM_Set_Name)
        Me.Controls.Add(Me.L_Name_SRM_Set_Name)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.L_Weight_Balance)
        Me.Controls.Add(Me.L_Name_Weight_Balance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_SRM_Accept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SRM"
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_SetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableSRMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_SRM_SetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_SetTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table_SRMTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter
    Friend WithEvents L_Name_Weight_Balance As System.Windows.Forms.Label
    Friend WithEvents L_Weight_Balance As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Weighting_SLI_LLI As System.Windows.Forms.OpenFileDialog
    Friend WithEvents L_SRM_Set_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_SRM_Set_Name As System.Windows.Forms.Label
    Friend WithEvents L_SRM_Set_Number As System.Windows.Forms.Label
    Friend WithEvents L_Name_SRM_Set_Number As System.Windows.Forms.Label
    Friend WithEvents TableSRMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents L_SRM_Set_Weight As System.Windows.Forms.Label
    Friend WithEvents L_Name_SRM_Set_Weight As System.Windows.Forms.Label
    Friend WithEvents Table_SRMDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents B_Fill_SRM_From_File As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
