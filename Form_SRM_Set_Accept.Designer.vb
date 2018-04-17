<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SRM_Set_Accept
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
        Me.ComboBox_SRM_Set_Type = New System.Windows.Forms.ComboBox()
        Me.L_Name_SRM_Set_Type = New System.Windows.Forms.Label()
        Me.L_Name_New_SRM_Set_Name = New System.Windows.Forms.Label()
        Me.TextBox_New_Monitor_Set_Name = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox_New_SRM_Set_Weight = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_New_SRM_Set_Weight = New System.Windows.Forms.Label()
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_SRM_New_Set_Purchasing_Date = New System.Windows.Forms.Label()
        Me.B_Save_New_SRM_Set = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.Table_SRM_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_SRM_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.Table_SRM_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L_Name_New_SRM_Set_Number = New System.Windows.Forms.Label()
        Me.MaskedTextBox_New_SRM_Set_Number = New System.Windows.Forms.MaskedTextBox()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_SRM_Set_Type
        '
        Me.ComboBox_SRM_Set_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SRM_Set_Type.FormattingEnabled = True
        Me.ComboBox_SRM_Set_Type.Items.AddRange(New Object() {"soil", "plant", "fauna", "liquid standart", "salt", "metal"})
        Me.ComboBox_SRM_Set_Type.Location = New System.Drawing.Point(85, 169)
        Me.ComboBox_SRM_Set_Type.Name = "ComboBox_SRM_Set_Type"
        Me.ComboBox_SRM_Set_Type.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox_SRM_Set_Type.TabIndex = 0
        '
        'L_Name_SRM_Set_Type
        '
        Me.L_Name_SRM_Set_Type.AutoSize = True
        Me.L_Name_SRM_Set_Type.Location = New System.Drawing.Point(84, 153)
        Me.L_Name_SRM_Set_Type.Name = "L_Name_SRM_Set_Type"
        Me.L_Name_SRM_Set_Type.Size = New System.Drawing.Size(87, 13)
        Me.L_Name_SRM_Set_Type.TabIndex = 1
        Me.L_Name_SRM_Set_Type.Text = "Type of SRM set"
        '
        'L_Name_New_SRM_Set_Name
        '
        Me.L_Name_New_SRM_Set_Name.AutoSize = True
        Me.L_Name_New_SRM_Set_Name.Location = New System.Drawing.Point(28, 104)
        Me.L_Name_New_SRM_Set_Name.Name = "L_Name_New_SRM_Set_Name"
        Me.L_Name_New_SRM_Set_Name.Size = New System.Drawing.Size(102, 13)
        Me.L_Name_New_SRM_Set_Name.TabIndex = 2
        Me.L_Name_New_SRM_Set_Name.Text = "New SRM set name"
        '
        'TextBox_New_Monitor_Set_Name
        '
        Me.TextBox_New_Monitor_Set_Name.Location = New System.Drawing.Point(28, 121)
        Me.TextBox_New_Monitor_Set_Name.Name = "TextBox_New_Monitor_Set_Name"
        Me.TextBox_New_Monitor_Set_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_New_Monitor_Set_Name.TabIndex = 3
        '
        'MaskedTextBox_New_SRM_Set_Weight
        '
        Me.MaskedTextBox_New_SRM_Set_Weight.Location = New System.Drawing.Point(41, 211)
        Me.MaskedTextBox_New_SRM_Set_Weight.Mask = "000.00"
        Me.MaskedTextBox_New_SRM_Set_Weight.Name = "MaskedTextBox_New_SRM_Set_Weight"
        Me.MaskedTextBox_New_SRM_Set_Weight.Size = New System.Drawing.Size(50, 20)
        Me.MaskedTextBox_New_SRM_Set_Weight.TabIndex = 4
        '
        'L_Name_New_SRM_Set_Weight
        '
        Me.L_Name_New_SRM_Set_Weight.AutoSize = True
        Me.L_Name_New_SRM_Set_Weight.Location = New System.Drawing.Point(25, 195)
        Me.L_Name_New_SRM_Set_Weight.Name = "L_Name_New_SRM_Set_Weight"
        Me.L_Name_New_SRM_Set_Weight.Size = New System.Drawing.Size(82, 13)
        Me.L_Name_New_SRM_Set_Weight.TabIndex = 5
        Me.L_Name_New_SRM_Set_Weight.Text = "Weight of set, g"
        '
        'MaskedTextBox_New_SRM_Set_Purchasing_Date
        '
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date.Location = New System.Drawing.Point(174, 211)
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date.Mask = "00/00/0000"
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date.Name = "MaskedTextBox_New_SRM_Set_Purchasing_Date"
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date.Size = New System.Drawing.Size(60, 20)
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date.TabIndex = 113
        Me.MaskedTextBox_New_SRM_Set_Purchasing_Date.ValidatingType = GetType(Date)
        '
        'L_Name_SRM_New_Set_Purchasing_Date
        '
        Me.L_Name_SRM_New_Set_Purchasing_Date.AutoSize = True
        Me.L_Name_SRM_New_Set_Purchasing_Date.Location = New System.Drawing.Point(160, 195)
        Me.L_Name_SRM_New_Set_Purchasing_Date.Name = "L_Name_SRM_New_Set_Purchasing_Date"
        Me.L_Name_SRM_New_Set_Purchasing_Date.Size = New System.Drawing.Size(84, 13)
        Me.L_Name_SRM_New_Set_Purchasing_Date.TabIndex = 112
        Me.L_Name_SRM_New_Set_Purchasing_Date.Text = "Purchasing date"
        '
        'B_Save_New_SRM_Set
        '
        Me.B_Save_New_SRM_Set.Location = New System.Drawing.Point(18, 237)
        Me.B_Save_New_SRM_Set.Name = "B_Save_New_SRM_Set"
        Me.B_Save_New_SRM_Set.Size = New System.Drawing.Size(237, 23)
        Me.B_Save_New_SRM_Set.TabIndex = 115
        Me.B_Save_New_SRM_Set.Text = "Save new SRM set"
        Me.B_Save_New_SRM_Set.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(18, 266)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(237, 23)
        Me.B_Close.TabIndex = 116
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_SRM_Set_BindingSource
        '
        Me.Table_SRM_Set_BindingSource.DataMember = "table_SRM_Set"
        Me.Table_SRM_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_SRM_Set_TableAdapter
        '
        Me.Table_SRM_Set_TableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.table_SRM_SetTableAdapter = Me.Table_SRM_Set_TableAdapter
        Me.TableAdapterManager.table_SRMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table_SRM_SetDataGridView
        '
        Me.Table_SRM_SetDataGridView.AllowUserToAddRows = False
        Me.Table_SRM_SetDataGridView.AllowUserToDeleteRows = False
        Me.Table_SRM_SetDataGridView.AllowUserToResizeColumns = False
        Me.Table_SRM_SetDataGridView.AllowUserToResizeRows = False
        Me.Table_SRM_SetDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_SRM_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table_SRM_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_SRM_SetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.Table_SRM_SetDataGridView.DataSource = Me.Table_SRM_Set_BindingSource
        Me.Table_SRM_SetDataGridView.Location = New System.Drawing.Point(18, 12)
        Me.Table_SRM_SetDataGridView.Name = "Table_SRM_SetDataGridView"
        Me.Table_SRM_SetDataGridView.RowHeadersWidth = 21
        Me.Table_SRM_SetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_SRM_SetDataGridView.Size = New System.Drawing.Size(237, 83)
        Me.Table_SRM_SetDataGridView.TabIndex = 117
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SRM_Set_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SRM_Set_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'L_Name_New_SRM_Set_Number
        '
        Me.L_Name_New_SRM_Set_Number.AutoSize = True
        Me.L_Name_New_SRM_Set_Number.Location = New System.Drawing.Point(134, 104)
        Me.L_Name_New_SRM_Set_Number.Name = "L_Name_New_SRM_Set_Number"
        Me.L_Name_New_SRM_Set_Number.Size = New System.Drawing.Size(67, 13)
        Me.L_Name_New_SRM_Set_Number.TabIndex = 118
        Me.L_Name_New_SRM_Set_Number.Text = "New number"
        '
        'MaskedTextBox_New_SRM_Set_Number
        '
        Me.MaskedTextBox_New_SRM_Set_Number.Location = New System.Drawing.Point(154, 120)
        Me.MaskedTextBox_New_SRM_Set_Number.Mask = "00"
        Me.MaskedTextBox_New_SRM_Set_Number.Name = "MaskedTextBox_New_SRM_Set_Number"
        Me.MaskedTextBox_New_SRM_Set_Number.Size = New System.Drawing.Size(33, 20)
        Me.MaskedTextBox_New_SRM_Set_Number.TabIndex = 119
        '
        'Form_SRM_Set_Accept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 293)
        Me.Controls.Add(Me.MaskedTextBox_New_SRM_Set_Number)
        Me.Controls.Add(Me.L_Name_New_SRM_Set_Number)
        Me.Controls.Add(Me.Table_SRM_SetDataGridView)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Save_New_SRM_Set)
        Me.Controls.Add(Me.MaskedTextBox_New_SRM_Set_Purchasing_Date)
        Me.Controls.Add(Me.L_Name_SRM_New_Set_Purchasing_Date)
        Me.Controls.Add(Me.L_Name_New_SRM_Set_Weight)
        Me.Controls.Add(Me.MaskedTextBox_New_SRM_Set_Weight)
        Me.Controls.Add(Me.TextBox_New_Monitor_Set_Name)
        Me.Controls.Add(Me.L_Name_New_SRM_Set_Name)
        Me.Controls.Add(Me.L_Name_SRM_Set_Type)
        Me.Controls.Add(Me.ComboBox_SRM_Set_Type)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_SRM_Set_Accept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New SRM set"
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_SRM_Set_Type As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_SRM_Set_Type As System.Windows.Forms.Label
    Friend WithEvents L_Name_New_SRM_Set_Name As System.Windows.Forms.Label
    Friend WithEvents TextBox_New_Monitor_Set_Name As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox_New_SRM_Set_Weight As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_New_SRM_Set_Weight As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_New_SRM_Set_Purchasing_Date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_SRM_New_Set_Purchasing_Date As System.Windows.Forms.Label
    Friend WithEvents B_Save_New_SRM_Set As System.Windows.Forms.Button
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_SRM_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRM_SetTableAdapter
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table_SRM_SetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents L_Name_New_SRM_Set_Number As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_New_SRM_Set_Number As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
