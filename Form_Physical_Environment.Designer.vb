<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Physical_Environment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Table_Physical_EnvironmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.B_Insert_From_File = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Insert_From_file = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Table_Physical_EnvironmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table_Physical_EnvironmentDataGridView
        '
        Me.Table_Physical_EnvironmentDataGridView.AllowUserToAddRows = False
        Me.Table_Physical_EnvironmentDataGridView.AllowUserToDeleteRows = False
        Me.Table_Physical_EnvironmentDataGridView.AllowUserToResizeColumns = False
        Me.Table_Physical_EnvironmentDataGridView.AllowUserToResizeRows = False
        Me.Table_Physical_EnvironmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Physical_EnvironmentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table_Physical_EnvironmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Physical_EnvironmentDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Table_Physical_EnvironmentDataGridView.Name = "Table_Physical_EnvironmentDataGridView"
        Me.Table_Physical_EnvironmentDataGridView.ReadOnly = True
        Me.Table_Physical_EnvironmentDataGridView.RowHeadersWidth = 21
        Me.Table_Physical_EnvironmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_Physical_EnvironmentDataGridView.Size = New System.Drawing.Size(395, 333)
        Me.Table_Physical_EnvironmentDataGridView.TabIndex = 1
        '
        'B_Insert_From_File
        '
        Me.B_Insert_From_File.Location = New System.Drawing.Point(89, 351)
        Me.B_Insert_From_File.Name = "B_Insert_From_File"
        Me.B_Insert_From_File.Size = New System.Drawing.Size(126, 23)
        Me.B_Insert_From_File.TabIndex = 2
        Me.B_Insert_From_File.Text = "Insert from file"
        Me.B_Insert_From_File.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(221, 351)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(90, 23)
        Me.B_Close.TabIndex = 3
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'Form_Physical_Environment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 379)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Insert_From_File)
        Me.Controls.Add(Me.Table_Physical_EnvironmentDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Physical_Environment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physical environment"
        CType(Me.Table_Physical_EnvironmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Table_Physical_EnvironmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents B_Insert_From_File As System.Windows.Forms.Button
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Insert_From_file As System.Windows.Forms.OpenFileDialog
End Class
