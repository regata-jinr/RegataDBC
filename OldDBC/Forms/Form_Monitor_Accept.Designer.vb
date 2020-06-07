<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Monitor_Accept
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
        Me.Table_Monitor_DataGridView = New System.Windows.Forms.DataGridView()
        Me.MonitorNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorSLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonitorLLIWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableMonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.L_Monitor_Set_Weight = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set_Weight = New System.Windows.Forms.Label()
        Me.L_Monitor_Set_Number = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set_Number = New System.Windows.Forms.Label()
        Me.L_Monitor_Set_Name = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set_Name = New System.Windows.Forms.Label()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.L_Weight_Balance = New System.Windows.Forms.Label()
        Me.L_Name_Weight_Balance = New System.Windows.Forms.Label()
        Me.Table_MonitorTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_MonitorTableAdapter()
        Me.OpenFileDialog_Weighting_SLI_LLI = New System.Windows.Forms.OpenFileDialog()
        Me.B_Fill_Monitor_From_File = New System.Windows.Forms.Button()
        CType(Me.Table_Monitor_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableMonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table_Monitor_DataGridView
        '
        Me.Table_Monitor_DataGridView.AllowUserToAddRows = False
        Me.Table_Monitor_DataGridView.AllowUserToDeleteRows = False
        Me.Table_Monitor_DataGridView.AllowUserToResizeColumns = False
        Me.Table_Monitor_DataGridView.AllowUserToResizeRows = False
        Me.Table_Monitor_DataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Monitor_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table_Monitor_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Monitor_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonitorNumberDataGridViewTextBoxColumn, Me.MonitorSLIWeightDataGridViewTextBoxColumn, Me.MonitorLLIWeightDataGridViewTextBoxColumn})
        Me.Table_Monitor_DataGridView.DataSource = Me.TableMonitorBindingSource
        Me.Table_Monitor_DataGridView.Location = New System.Drawing.Point(12, 80)
        Me.Table_Monitor_DataGridView.Name = "Table_Monitor_DataGridView"
        Me.Table_Monitor_DataGridView.RowHeadersWidth = 21
        Me.Table_Monitor_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_Monitor_DataGridView.Size = New System.Drawing.Size(302, 151)
        Me.Table_Monitor_DataGridView.TabIndex = 22
        '
        'MonitorNumberDataGridViewTextBoxColumn
        '
        Me.MonitorNumberDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Number"
        Me.MonitorNumberDataGridViewTextBoxColumn.HeaderText = "Monitor number"
        Me.MonitorNumberDataGridViewTextBoxColumn.Name = "MonitorNumberDataGridViewTextBoxColumn"
        Me.MonitorNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonitorNumberDataGridViewTextBoxColumn.Width = 65
        '
        'MonitorSLIWeightDataGridViewTextBoxColumn
        '
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.DataPropertyName = "Monitor_SLI_Weight"
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.HeaderText = "Monitor SLI weight, g"
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.Name = "MonitorSLIWeightDataGridViewTextBoxColumn"
        Me.MonitorSLIWeightDataGridViewTextBoxColumn.Width = 65
        '
        'MonitorLLIWeightDataGridViewTextBoxColumn
        '
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.DataPropertyName = "Monitor_LLI_Weight"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.HeaderText = "Monitor LLI weight, g"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.Name = "MonitorLLIWeightDataGridViewTextBoxColumn"
        Me.MonitorLLIWeightDataGridViewTextBoxColumn.Width = 65
        '
        'TableMonitorBindingSource
        '
        Me.TableMonitorBindingSource.DataMember = "table_Monitor"
        Me.TableMonitorBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L_Monitor_Set_Weight
        '
        Me.L_Monitor_Set_Weight.AutoSize = True
        Me.L_Monitor_Set_Weight.Location = New System.Drawing.Point(128, 64)
        Me.L_Monitor_Set_Weight.Name = "L_Monitor_Set_Weight"
        Me.L_Monitor_Set_Weight.Size = New System.Drawing.Size(33, 13)
        Me.L_Monitor_Set_Weight.TabIndex = 23
        Me.L_Monitor_Set_Weight.Text = "Label"
        '
        'L_Name_Monitor_Set_Weight
        '
        Me.L_Name_Monitor_Set_Weight.AutoSize = True
        Me.L_Name_Monitor_Set_Weight.Location = New System.Drawing.Point(91, 51)
        Me.L_Name_Monitor_Set_Weight.Name = "L_Name_Monitor_Set_Weight"
        Me.L_Name_Monitor_Set_Weight.Size = New System.Drawing.Size(105, 13)
        Me.L_Name_Monitor_Set_Weight.TabIndex = 21
        Me.L_Name_Monitor_Set_Weight.Text = "Monitor set weight, g"
        '
        'L_Monitor_Set_Number
        '
        Me.L_Monitor_Set_Number.AutoSize = True
        Me.L_Monitor_Set_Number.Location = New System.Drawing.Point(197, 22)
        Me.L_Monitor_Set_Number.Name = "L_Monitor_Set_Number"
        Me.L_Monitor_Set_Number.Size = New System.Drawing.Size(33, 13)
        Me.L_Monitor_Set_Number.TabIndex = 20
        Me.L_Monitor_Set_Number.Text = "Label"
        '
        'L_Name_Monitor_Set_Number
        '
        Me.L_Name_Monitor_Set_Number.AutoSize = True
        Me.L_Name_Monitor_Set_Number.Location = New System.Drawing.Point(168, 9)
        Me.L_Name_Monitor_Set_Number.Name = "L_Name_Monitor_Set_Number"
        Me.L_Name_Monitor_Set_Number.Size = New System.Drawing.Size(97, 13)
        Me.L_Name_Monitor_Set_Number.TabIndex = 19
        Me.L_Name_Monitor_Set_Number.Text = "Monitor set number"
        '
        'L_Monitor_Set_Name
        '
        Me.L_Monitor_Set_Name.AutoSize = True
        Me.L_Monitor_Set_Name.Location = New System.Drawing.Point(41, 22)
        Me.L_Monitor_Set_Name.Name = "L_Monitor_Set_Name"
        Me.L_Monitor_Set_Name.Size = New System.Drawing.Size(33, 13)
        Me.L_Monitor_Set_Name.TabIndex = 18
        Me.L_Monitor_Set_Name.Text = "Label"
        '
        'L_Name_Monitor_Set_Name
        '
        Me.L_Name_Monitor_Set_Name.AutoSize = True
        Me.L_Name_Monitor_Set_Name.Location = New System.Drawing.Point(12, 9)
        Me.L_Name_Monitor_Set_Name.Name = "L_Name_Monitor_Set_Name"
        Me.L_Name_Monitor_Set_Name.Size = New System.Drawing.Size(88, 13)
        Me.L_Name_Monitor_Set_Name.TabIndex = 17
        Me.L_Name_Monitor_Set_Name.Text = "Monitor set name"
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(44, 299)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(253, 23)
        Me.B_Close.TabIndex = 14
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'L_Weight_Balance
        '
        Me.L_Weight_Balance.AutoSize = True
        Me.L_Weight_Balance.Location = New System.Drawing.Point(202, 243)
        Me.L_Weight_Balance.Name = "L_Weight_Balance"
        Me.L_Weight_Balance.Size = New System.Drawing.Size(33, 13)
        Me.L_Weight_Balance.TabIndex = 13
        Me.L_Weight_Balance.Text = "Label"
        '
        'L_Name_Weight_Balance
        '
        Me.L_Name_Weight_Balance.AutoSize = True
        Me.L_Name_Weight_Balance.Location = New System.Drawing.Point(102, 243)
        Me.L_Name_Weight_Balance.Name = "L_Name_Weight_Balance"
        Me.L_Name_Weight_Balance.Size = New System.Drawing.Size(94, 13)
        Me.L_Name_Weight_Balance.TabIndex = 12
        Me.L_Name_Weight_Balance.Text = "Weight balance, g"
        '
        'Table_MonitorTableAdapter
        '
        Me.Table_MonitorTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog_Weighting_SLI_LLI
        '
        Me.OpenFileDialog_Weighting_SLI_LLI.Filter = "Weighting files (*.ves)|*.ves|All files (*.*)|*.*"
        '
        'B_Fill_Monitor_From_File
        '
        Me.B_Fill_Monitor_From_File.Location = New System.Drawing.Point(44, 270)
        Me.B_Fill_Monitor_From_File.Name = "B_Fill_Monitor_From_File"
        Me.B_Fill_Monitor_From_File.Size = New System.Drawing.Size(253, 23)
        Me.B_Fill_Monitor_From_File.TabIndex = 24
        Me.B_Fill_Monitor_From_File.Text = "Fill in monitor weight from file"
        Me.B_Fill_Monitor_From_File.UseVisualStyleBackColor = True
        '
        'Form_Monitor_Accept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 326)
        Me.Controls.Add(Me.B_Fill_Monitor_From_File)
        Me.Controls.Add(Me.Table_Monitor_DataGridView)
        Me.Controls.Add(Me.L_Monitor_Set_Weight)
        Me.Controls.Add(Me.L_Name_Monitor_Set_Weight)
        Me.Controls.Add(Me.L_Monitor_Set_Number)
        Me.Controls.Add(Me.L_Name_Monitor_Set_Number)
        Me.Controls.Add(Me.L_Monitor_Set_Name)
        Me.Controls.Add(Me.L_Name_Monitor_Set_Name)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.L_Weight_Balance)
        Me.Controls.Add(Me.L_Name_Weight_Balance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Monitor_Accept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor"
        CType(Me.Table_Monitor_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableMonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Table_Monitor_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents L_Monitor_Set_Weight As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set_Weight As System.Windows.Forms.Label
    Friend WithEvents L_Monitor_Set_Number As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set_Number As System.Windows.Forms.Label
    Friend WithEvents L_Monitor_Set_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set_Name As System.Windows.Forms.Label
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents L_Weight_Balance As System.Windows.Forms.Label
    Friend WithEvents L_Name_Weight_Balance As System.Windows.Forms.Label
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents TableMonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_MonitorTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_MonitorTableAdapter
    Friend WithEvents MonitorNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorSLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorLLIWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog_Weighting_SLI_LLI As System.Windows.Forms.OpenFileDialog
    Friend WithEvents B_Fill_Monitor_From_File As System.Windows.Forms.Button
End Class
