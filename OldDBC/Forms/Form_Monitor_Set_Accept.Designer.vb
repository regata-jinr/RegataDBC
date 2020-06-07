<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Monitor_Set_Accept
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
        Me.MaskedTextBox_New_Monitor_Set_Number = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_New_Monitor_Set_Number = New System.Windows.Forms.Label()
        Me.Table_Monitor_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.MonitorSetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSetNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table_Monitor_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.B_Save_New_Monitor_Set = New System.Windows.Forms.Button()
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_New_Monitor_Set_Purchasing_Date = New System.Windows.Forms.Label()
        Me.L_Name_New_Monitor_Set_Weight = New System.Windows.Forms.Label()
        Me.MaskedTextBox_New_Monitor_Set_Weight = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_New_Monitor_Set_Name = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set_Type = New System.Windows.Forms.Label()
        Me.ComboBox_Monitor_Set_Type = New System.Windows.Forms.ComboBox()
        Me.Table_Monitor_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter()
        Me.ComboBox_New_Monitor_Set_Name = New System.Windows.Forms.ComboBox()
        CType(Me.Table_Monitor_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaskedTextBox_New_Monitor_Set_Number
        '
        Me.MaskedTextBox_New_Monitor_Set_Number.Location = New System.Drawing.Point(208, 120)
        Me.MaskedTextBox_New_Monitor_Set_Number.Mask = "00"
        Me.MaskedTextBox_New_Monitor_Set_Number.Name = "MaskedTextBox_New_Monitor_Set_Number"
        Me.MaskedTextBox_New_Monitor_Set_Number.Size = New System.Drawing.Size(33, 20)
        Me.MaskedTextBox_New_Monitor_Set_Number.TabIndex = 132
        '
        'L_Name_New_Monitor_Set_Number
        '
        Me.L_Name_New_Monitor_Set_Number.AutoSize = True
        Me.L_Name_New_Monitor_Set_Number.Location = New System.Drawing.Point(188, 104)
        Me.L_Name_New_Monitor_Set_Number.Name = "L_Name_New_Monitor_Set_Number"
        Me.L_Name_New_Monitor_Set_Number.Size = New System.Drawing.Size(67, 13)
        Me.L_Name_New_Monitor_Set_Number.TabIndex = 131
        Me.L_Name_New_Monitor_Set_Number.Text = "New number"
        '
        'Table_Monitor_SetDataGridView
        '
        Me.Table_Monitor_SetDataGridView.AllowUserToAddRows = False
        Me.Table_Monitor_SetDataGridView.AllowUserToDeleteRows = False
        Me.Table_Monitor_SetDataGridView.AllowUserToResizeColumns = False
        Me.Table_Monitor_SetDataGridView.AllowUserToResizeRows = False
        Me.Table_Monitor_SetDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Monitor_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table_Monitor_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Monitor_SetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonitorSetNameDataGridViewTextBoxColumn, Me.MonitorSetNumberDataGridViewTextBoxColumn})
        Me.Table_Monitor_SetDataGridView.DataSource = Me.Table_Monitor_Set_BindingSource
        Me.Table_Monitor_SetDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Table_Monitor_SetDataGridView.Name = "Table_Monitor_SetDataGridView"
        Me.Table_Monitor_SetDataGridView.RowHeadersWidth = 21
        Me.Table_Monitor_SetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_Monitor_SetDataGridView.Size = New System.Drawing.Size(243, 83)
        Me.Table_Monitor_SetDataGridView.TabIndex = 130
        '
        'MonitorSetNameDataGridViewTextBoxColumn
        '
        Me.MonitorSetNameDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Name"
        Me.MonitorSetNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.MonitorSetNameDataGridViewTextBoxColumn.Name = "MonitorSetNameDataGridViewTextBoxColumn"
        Me.MonitorSetNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonitorSetNameDataGridViewTextBoxColumn.Width = 60
        '
        'MonitorSetNumberDataGridViewTextBoxColumn
        '
        Me.MonitorSetNumberDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Set_Number"
        Me.MonitorSetNumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.MonitorSetNumberDataGridViewTextBoxColumn.Name = "MonitorSetNumberDataGridViewTextBoxColumn"
        Me.MonitorSetNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonitorSetNumberDataGridViewTextBoxColumn.Width = 60
        '
        'Table_Monitor_Set_BindingSource
        '
        Me.Table_Monitor_Set_BindingSource.DataMember = "table_Monitor_Set"
        Me.Table_Monitor_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(12, 266)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(243, 23)
        Me.B_Close.TabIndex = 129
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'B_Save_New_Monitor_Set
        '
        Me.B_Save_New_Monitor_Set.Location = New System.Drawing.Point(12, 237)
        Me.B_Save_New_Monitor_Set.Name = "B_Save_New_Monitor_Set"
        Me.B_Save_New_Monitor_Set.Size = New System.Drawing.Size(243, 23)
        Me.B_Save_New_Monitor_Set.TabIndex = 128
        Me.B_Save_New_Monitor_Set.Text = "Save new monitor set"
        Me.B_Save_New_Monitor_Set.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_New_Monitor_Set_Purchasing_Date
        '
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date.Location = New System.Drawing.Point(185, 211)
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date.Mask = "00/00/0000"
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date.Name = "MaskedTextBox_New_Monitor_Set_Purchasing_Date"
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date.Size = New System.Drawing.Size(60, 20)
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date.TabIndex = 127
        Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date.ValidatingType = GetType(Date)
        '
        'L_Name_New_Monitor_Set_Purchasing_Date
        '
        Me.L_Name_New_Monitor_Set_Purchasing_Date.AutoSize = True
        Me.L_Name_New_Monitor_Set_Purchasing_Date.Location = New System.Drawing.Point(171, 195)
        Me.L_Name_New_Monitor_Set_Purchasing_Date.Name = "L_Name_New_Monitor_Set_Purchasing_Date"
        Me.L_Name_New_Monitor_Set_Purchasing_Date.Size = New System.Drawing.Size(84, 13)
        Me.L_Name_New_Monitor_Set_Purchasing_Date.TabIndex = 126
        Me.L_Name_New_Monitor_Set_Purchasing_Date.Text = "Purchasing date"
        '
        'L_Name_New_Monitor_Set_Weight
        '
        Me.L_Name_New_Monitor_Set_Weight.AutoSize = True
        Me.L_Name_New_Monitor_Set_Weight.Location = New System.Drawing.Point(13, 195)
        Me.L_Name_New_Monitor_Set_Weight.Name = "L_Name_New_Monitor_Set_Weight"
        Me.L_Name_New_Monitor_Set_Weight.Size = New System.Drawing.Size(82, 13)
        Me.L_Name_New_Monitor_Set_Weight.TabIndex = 125
        Me.L_Name_New_Monitor_Set_Weight.Text = "Weight of set, g"
        '
        'MaskedTextBox_New_Monitor_Set_Weight
        '
        Me.MaskedTextBox_New_Monitor_Set_Weight.Location = New System.Drawing.Point(29, 211)
        Me.MaskedTextBox_New_Monitor_Set_Weight.Mask = "000.00"
        Me.MaskedTextBox_New_Monitor_Set_Weight.Name = "MaskedTextBox_New_Monitor_Set_Weight"
        Me.MaskedTextBox_New_Monitor_Set_Weight.Size = New System.Drawing.Size(50, 20)
        Me.MaskedTextBox_New_Monitor_Set_Weight.TabIndex = 124
        '
        'L_Name_New_Monitor_Set_Name
        '
        Me.L_Name_New_Monitor_Set_Name.AutoSize = True
        Me.L_Name_New_Monitor_Set_Name.Location = New System.Drawing.Point(12, 104)
        Me.L_Name_New_Monitor_Set_Name.Name = "L_Name_New_Monitor_Set_Name"
        Me.L_Name_New_Monitor_Set_Name.Size = New System.Drawing.Size(112, 13)
        Me.L_Name_New_Monitor_Set_Name.TabIndex = 122
        Me.L_Name_New_Monitor_Set_Name.Text = "New monitor set name"
        '
        'L_Name_Monitor_Set_Type
        '
        Me.L_Name_Monitor_Set_Type.AutoSize = True
        Me.L_Name_Monitor_Set_Type.Location = New System.Drawing.Point(72, 152)
        Me.L_Name_Monitor_Set_Type.Name = "L_Name_Monitor_Set_Type"
        Me.L_Name_Monitor_Set_Type.Size = New System.Drawing.Size(97, 13)
        Me.L_Name_Monitor_Set_Type.TabIndex = 121
        Me.L_Name_Monitor_Set_Type.Text = "Type of monitor set"
        '
        'ComboBox_Monitor_Set_Type
        '
        Me.ComboBox_Monitor_Set_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Monitor_Set_Type.FormattingEnabled = True
        Me.ComboBox_Monitor_Set_Type.Items.AddRange(New Object() {"foil", "granules", "liquid", "powder", "wire"})
        Me.ComboBox_Monitor_Set_Type.Location = New System.Drawing.Point(75, 168)
        Me.ComboBox_Monitor_Set_Type.Name = "ComboBox_Monitor_Set_Type"
        Me.ComboBox_Monitor_Set_Type.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Monitor_Set_Type.TabIndex = 120
        '
        'Table_Monitor_Set_TableAdapter
        '
        Me.Table_Monitor_Set_TableAdapter.ClearBeforeFill = True
        '
        'ComboBox_New_Monitor_Set_Name
        '
        Me.ComboBox_New_Monitor_Set_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_New_Monitor_Set_Name.FormattingEnabled = True
        Me.ComboBox_New_Monitor_Set_Name.Items.AddRange(New Object() {"Co", "Ni", "Zr", "Au"})
        Me.ComboBox_New_Monitor_Set_Name.Location = New System.Drawing.Point(16, 119)
        Me.ComboBox_New_Monitor_Set_Name.Name = "ComboBox_New_Monitor_Set_Name"
        Me.ComboBox_New_Monitor_Set_Name.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_New_Monitor_Set_Name.TabIndex = 133
        '
        'Form_Monitor_Set_Accept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 295)
        Me.Controls.Add(Me.ComboBox_New_Monitor_Set_Name)
        Me.Controls.Add(Me.MaskedTextBox_New_Monitor_Set_Number)
        Me.Controls.Add(Me.L_Name_New_Monitor_Set_Number)
        Me.Controls.Add(Me.Table_Monitor_SetDataGridView)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Save_New_Monitor_Set)
        Me.Controls.Add(Me.MaskedTextBox_New_Monitor_Set_Purchasing_Date)
        Me.Controls.Add(Me.L_Name_New_Monitor_Set_Purchasing_Date)
        Me.Controls.Add(Me.L_Name_New_Monitor_Set_Weight)
        Me.Controls.Add(Me.MaskedTextBox_New_Monitor_Set_Weight)
        Me.Controls.Add(Me.L_Name_New_Monitor_Set_Name)
        Me.Controls.Add(Me.L_Name_Monitor_Set_Type)
        Me.Controls.Add(Me.ComboBox_Monitor_Set_Type)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Monitor_Set_Accept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New monitor set"
        CType(Me.Table_Monitor_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaskedTextBox_New_Monitor_Set_Number As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_New_Monitor_Set_Number As System.Windows.Forms.Label
    Friend WithEvents Table_Monitor_SetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents B_Save_New_Monitor_Set As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_New_Monitor_Set_Purchasing_Date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_New_Monitor_Set_Purchasing_Date As System.Windows.Forms.Label
    Friend WithEvents L_Name_New_Monitor_Set_Weight As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_New_Monitor_Set_Weight As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_New_Monitor_Set_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set_Type As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Monitor_Set_Type As System.Windows.Forms.ComboBox
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_Monitor_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Monitor_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter
    Friend WithEvents MonitorSetNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox_New_Monitor_Set_Name As System.Windows.Forms.ComboBox
End Class
