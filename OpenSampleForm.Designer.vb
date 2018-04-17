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
        Me.OpenSetSLIDataGridView = New System.Windows.Forms.DataGridView()
        Me.OpenSetLLIDataGridView = New System.Windows.Forms.DataGridView()
        Me.OpenSetBaseDataGridView = New System.Windows.Forms.DataGridView()
        Me.BaseLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.NAADBEXPDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.OpenSetSLIDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenSetLLIDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenSetBaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAADBEXPDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenSetSLIDataGridView
        '
        Me.OpenSetSLIDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenSetSLIDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OpenSetSLIDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.OpenSetSLIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OpenSetSLIDataGridView.Location = New System.Drawing.Point(12, 101)
        Me.OpenSetSLIDataGridView.Name = "OpenSetSLIDataGridView"
        Me.OpenSetSLIDataGridView.ReadOnly = True
        Me.OpenSetSLIDataGridView.RowHeadersVisible = False
        Me.OpenSetSLIDataGridView.Size = New System.Drawing.Size(913, 280)
        Me.OpenSetSLIDataGridView.TabIndex = 0
        '
        'OpenSetLLIDataGridView
        '
        Me.OpenSetLLIDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenSetLLIDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OpenSetLLIDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.OpenSetLLIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OpenSetLLIDataGridView.Location = New System.Drawing.Point(12, 407)
        Me.OpenSetLLIDataGridView.Name = "OpenSetLLIDataGridView"
        Me.OpenSetLLIDataGridView.ReadOnly = True
        Me.OpenSetLLIDataGridView.RowHeadersVisible = False
        Me.OpenSetLLIDataGridView.Size = New System.Drawing.Size(913, 274)
        Me.OpenSetLLIDataGridView.TabIndex = 1
        '
        'OpenSetBaseDataGridView
        '
        Me.OpenSetBaseDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenSetBaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OpenSetBaseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.OpenSetBaseDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.OpenSetBaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OpenSetBaseDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.OpenSetBaseDataGridView.MultiSelect = False
        Me.OpenSetBaseDataGridView.Name = "OpenSetBaseDataGridView"
        Me.OpenSetBaseDataGridView.ReadOnly = True
        Me.OpenSetBaseDataGridView.RowHeadersVisible = False
        Me.OpenSetBaseDataGridView.Size = New System.Drawing.Size(913, 47)
        Me.OpenSetBaseDataGridView.TabIndex = 2
        '
        'BaseLabel
        '
        Me.BaseLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaseLabel.AutoSize = True
        Me.BaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BaseLabel.Location = New System.Drawing.Point(356, 6)
        Me.BaseLabel.Name = "BaseLabel"
        Me.BaseLabel.Size = New System.Drawing.Size(234, 20)
        Me.BaseLabel.TabIndex = 3
        Me.BaseLabel.Text = "Общая информация о партии"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Информации о КЖИ"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Информация о ДЖИ"
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
        Me.ClientSize = New System.Drawing.Size(937, 684)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BaseLabel)
        Me.Controls.Add(Me.OpenSetBaseDataGridView)
        Me.Controls.Add(Me.OpenSetLLIDataGridView)
        Me.Controls.Add(Me.OpenSetSLIDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OpenSampleForm"
        Me.Text = "Подробная информация о партии"
        CType(Me.OpenSetSLIDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenSetLLIDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenSetBaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAADBEXPDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenSetSLIDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NAADBEXPDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents OpenSetLLIDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OpenSetBaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BaseLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
