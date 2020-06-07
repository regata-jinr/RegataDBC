<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenSampleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenSampleForm))
        Me.BaseLabel = New System.Windows.Forms.Label()
        Me.DataGridViewForPrint = New System.Windows.Forms.DataGridView()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.SaveFileDialogExportToExcel = New System.Windows.Forms.SaveFileDialog()
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.NAADBEXPDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridViewForPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAADBEXPDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseLabel
        '
        Me.BaseLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaseLabel.AutoSize = True
        Me.BaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BaseLabel.Location = New System.Drawing.Point(297, 19)
        Me.BaseLabel.Name = "BaseLabel"
        Me.BaseLabel.Size = New System.Drawing.Size(351, 20)
        Me.BaseLabel.TabIndex = 3
        Me.BaseLabel.Text = "Подготовка списка партий к экспорту в excel"
        '
        'DataGridViewForPrint
        '
        Me.DataGridViewForPrint.AllowUserToAddRows = False
        Me.DataGridViewForPrint.AllowUserToOrderColumns = True
        Me.DataGridViewForPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewForPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewForPrint.Location = New System.Drawing.Point(12, 42)
        Me.DataGridViewForPrint.Name = "DataGridViewForPrint"
        Me.DataGridViewForPrint.ReadOnly = True
        Me.DataGridViewForPrint.RowHeadersVisible = False
        Me.DataGridViewForPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForPrint.Size = New System.Drawing.Size(913, 579)
        Me.DataGridViewForPrint.TabIndex = 4
        '
        'ButtonExport
        '
        Me.ButtonExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonExport.Location = New System.Drawing.Point(12, 627)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(124, 31)
        Me.ButtonExport.TabIndex = 5
        Me.ButtonExport.Text = "Экпорт в Excel"
        Me.ButtonExport.UseVisualStyleBackColor = True
        '
        'SaveFileDialogExportToExcel
        '
        Me.SaveFileDialogExportToExcel.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        Me.SaveFileDialogExportToExcel.RestoreDirectory = True
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NAADBEXPDataSetBindingSource
        '
        Me.NAADBEXPDataSetBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        Me.NAADBEXPDataSetBindingSource.Position = 0
        '
        'OpenSampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(937, 665)
        Me.Controls.Add(Me.ButtonExport)
        Me.Controls.Add(Me.DataGridViewForPrint)
        Me.Controls.Add(Me.BaseLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OpenSampleForm"
        Me.Text = "Подробная информация о партиях"
        CType(Me.DataGridViewForPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAADBEXPDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NAADBEXPDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents BaseLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridViewForPrint As DataGridView
    Friend WithEvents ButtonExport As Button
    Friend WithEvents SaveFileDialogExportToExcel As SaveFileDialog
End Class
