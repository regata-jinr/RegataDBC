<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ElsSum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label_Name_Code = New System.Windows.Forms.Label()
        Me.LablelElSumCountryCode = New System.Windows.Forms.Label()
        Me.LabelElSumClientId = New System.Windows.Forms.Label()
        Me.LabelElSumYear = New System.Windows.Forms.Label()
        Me.LabelElSumSetId = New System.Windows.Forms.Label()
        Me.LabelElSumSetIndex = New System.Windows.Forms.Label()
        Me.DataGridViewElsSum = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSpectraDWLD = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogSpectra = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBarDwld = New System.Windows.Forms.ProgressBar()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.RadioButtonDFSLI = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDFLLI1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDFLLI2 = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridViewElsSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Name_Code
        '
        Me.Label_Name_Code.AutoSize = True
        Me.Label_Name_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_Name_Code.Location = New System.Drawing.Point(2, -2)
        Me.Label_Name_Code.Name = "Label_Name_Code"
        Me.Label_Name_Code.Size = New System.Drawing.Size(278, 36)
        Me.Label_Name_Code.TabIndex = 177
        Me.Label_Name_Code.Text = "Страна  Клиент  Год   Номер   Индекс " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                       пар" &
    "тии   партии"
        '
        'LablelElSumCountryCode
        '
        Me.LablelElSumCountryCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LablelElSumCountryCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LablelElSumCountryCode.Location = New System.Drawing.Point(12, 43)
        Me.LablelElSumCountryCode.Name = "LablelElSumCountryCode"
        Me.LablelElSumCountryCode.Size = New System.Drawing.Size(33, 23)
        Me.LablelElSumCountryCode.TabIndex = 173
        '
        'LabelElSumClientId
        '
        Me.LabelElSumClientId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelElSumClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelElSumClientId.Location = New System.Drawing.Point(61, 43)
        Me.LabelElSumClientId.Name = "LabelElSumClientId"
        Me.LabelElSumClientId.Size = New System.Drawing.Size(33, 23)
        Me.LabelElSumClientId.TabIndex = 178
        '
        'LabelElSumYear
        '
        Me.LabelElSumYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelElSumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelElSumYear.Location = New System.Drawing.Point(115, 43)
        Me.LabelElSumYear.Name = "LabelElSumYear"
        Me.LabelElSumYear.Size = New System.Drawing.Size(33, 23)
        Me.LabelElSumYear.TabIndex = 179
        '
        'LabelElSumSetId
        '
        Me.LabelElSumSetId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelElSumSetId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelElSumSetId.Location = New System.Drawing.Point(163, 43)
        Me.LabelElSumSetId.Name = "LabelElSumSetId"
        Me.LabelElSumSetId.Size = New System.Drawing.Size(33, 23)
        Me.LabelElSumSetId.TabIndex = 180
        '
        'LabelElSumSetIndex
        '
        Me.LabelElSumSetIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelElSumSetIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelElSumSetIndex.Location = New System.Drawing.Point(221, 43)
        Me.LabelElSumSetIndex.Name = "LabelElSumSetIndex"
        Me.LabelElSumSetIndex.Size = New System.Drawing.Size(33, 23)
        Me.LabelElSumSetIndex.TabIndex = 181
        '
        'DataGridViewElsSum
        '
        Me.DataGridViewElsSum.AllowUserToAddRows = False
        Me.DataGridViewElsSum.AllowUserToDeleteRows = False
        Me.DataGridViewElsSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewElsSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewElsSum.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewElsSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewElsSum.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewElsSum.Location = New System.Drawing.Point(5, 71)
        Me.DataGridViewElsSum.Name = "DataGridViewElsSum"
        Me.DataGridViewElsSum.ReadOnly = True
        Me.DataGridViewElsSum.RowHeadersVisible = False
        Me.DataGridViewElsSum.Size = New System.Drawing.Size(954, 415)
        Me.DataGridViewElsSum.TabIndex = 182
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDFLLI2)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDFLLI1)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDFSLI)
        Me.GroupBox1.Controls.Add(Me.ProgressBarDwld)
        Me.GroupBox1.Controls.Add(Me.ButtonSpectraDWLD)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(671, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 68)
        Me.GroupBox1.TabIndex = 183
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Загрузить файлы спектров"
        '
        'ButtonSpectraDWLD
        '
        Me.ButtonSpectraDWLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSpectraDWLD.Location = New System.Drawing.Point(215, 37)
        Me.ButtonSpectraDWLD.Name = "ButtonSpectraDWLD"
        Me.ButtonSpectraDWLD.Size = New System.Drawing.Size(62, 25)
        Me.ButtonSpectraDWLD.TabIndex = 3
        Me.ButtonSpectraDWLD.Text = "OK"
        Me.ButtonSpectraDWLD.UseVisualStyleBackColor = True
        '
        'ProgressBarDwld
        '
        Me.ProgressBarDwld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarDwld.Location = New System.Drawing.Point(6, 39)
        Me.ProgressBarDwld.Name = "ProgressBarDwld"
        Me.ProgressBarDwld.Size = New System.Drawing.Size(198, 23)
        Me.ProgressBarDwld.TabIndex = 184
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.Location = New System.Drawing.Point(518, 9)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(147, 57)
        Me.LabelStatus.TabIndex = 184
        '
        'RadioButtonDFSLI
        '
        Me.RadioButtonDFSLI.AutoSize = True
        Me.RadioButtonDFSLI.Location = New System.Drawing.Point(7, 17)
        Me.RadioButtonDFSLI.Name = "RadioButtonDFSLI"
        Me.RadioButtonDFSLI.Size = New System.Drawing.Size(53, 19)
        Me.RadioButtonDFSLI.TabIndex = 185
        Me.RadioButtonDFSLI.TabStop = True
        Me.RadioButtonDFSLI.Text = "КЖИ"
        Me.RadioButtonDFSLI.UseVisualStyleBackColor = True
        '
        'RadioButtonDFLLI1
        '
        Me.RadioButtonDFLLI1.AutoSize = True
        Me.RadioButtonDFLLI1.Location = New System.Drawing.Point(66, 17)
        Me.RadioButtonDFLLI1.Name = "RadioButtonDFLLI1"
        Me.RadioButtonDFLLI1.Size = New System.Drawing.Size(65, 19)
        Me.RadioButtonDFLLI1.TabIndex = 186
        Me.RadioButtonDFLLI1.TabStop = True
        Me.RadioButtonDFLLI1.Text = "ДЖИ-1"
        Me.RadioButtonDFLLI1.UseVisualStyleBackColor = True
        '
        'RadioButtonDFLLI2
        '
        Me.RadioButtonDFLLI2.AutoSize = True
        Me.RadioButtonDFLLI2.Location = New System.Drawing.Point(137, 17)
        Me.RadioButtonDFLLI2.Name = "RadioButtonDFLLI2"
        Me.RadioButtonDFLLI2.Size = New System.Drawing.Size(65, 19)
        Me.RadioButtonDFLLI2.TabIndex = 187
        Me.RadioButtonDFLLI2.TabStop = True
        Me.RadioButtonDFLLI2.Text = "ДЖИ-2"
        Me.RadioButtonDFLLI2.UseVisualStyleBackColor = True
        '
        'Form_ElsSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 496)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewElsSum)
        Me.Controls.Add(Me.LabelElSumSetIndex)
        Me.Controls.Add(Me.LabelElSumSetId)
        Me.Controls.Add(Me.LabelElSumYear)
        Me.Controls.Add(Me.LabelElSumClientId)
        Me.Controls.Add(Me.Label_Name_Code)
        Me.Controls.Add(Me.LablelElSumCountryCode)
        Me.Name = "Form_ElsSum"
        Me.Text = "Информация об образцах"
        CType(Me.DataGridViewElsSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Name_Code As Label
    Friend WithEvents LablelElSumCountryCode As Label
    Friend WithEvents LabelElSumClientId As Label
    Friend WithEvents LabelElSumYear As Label
    Friend WithEvents LabelElSumSetId As Label
    Friend WithEvents LabelElSumSetIndex As Label
    Friend WithEvents DataGridViewElsSum As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSpectraDWLD As Button
    Friend WithEvents FolderBrowserDialogSpectra As FolderBrowserDialog
    Friend WithEvents ProgressBarDwld As ProgressBar
    Friend WithEvents LabelStatus As Label
    Friend WithEvents RadioButtonDFLLI2 As RadioButton
    Friend WithEvents RadioButtonDFLLI1 As RadioButton
    Friend WithEvents RadioButtonDFSLI As RadioButton
End Class
