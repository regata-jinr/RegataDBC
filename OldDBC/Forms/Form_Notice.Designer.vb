<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Notice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Notice))
        Me.RichTextBoxFormNotice = New System.Windows.Forms.RichTextBox()
        Me.ButtonFormNoticeSave = New System.Windows.Forms.Button()
        Me.ButtonFormNoticeCancel = New System.Windows.Forms.Button()
        Me.Form_Notice_Log = New System.Windows.Forms.RichTextBox()
        Me.GroupBoxComplete = New System.Windows.Forms.GroupBox()
        Me.ResCompl = New System.Windows.Forms.CheckBox()
        Me.LLICompl = New System.Windows.Forms.CheckBox()
        Me.SLICompl = New System.Windows.Forms.CheckBox()
        Me.PrepCompl = New System.Windows.Forms.CheckBox()
        Me.GroupBoxComplete.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxFormNotice
        '
        Me.RichTextBoxFormNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBoxFormNotice.Location = New System.Drawing.Point(12, 152)
        Me.RichTextBoxFormNotice.Name = "RichTextBoxFormNotice"
        Me.RichTextBoxFormNotice.Size = New System.Drawing.Size(480, 101)
        Me.RichTextBoxFormNotice.TabIndex = 0
        Me.RichTextBoxFormNotice.Text = ""
        '
        'ButtonFormNoticeSave
        '
        Me.ButtonFormNoticeSave.Location = New System.Drawing.Point(105, 308)
        Me.ButtonFormNoticeSave.Name = "ButtonFormNoticeSave"
        Me.ButtonFormNoticeSave.Size = New System.Drawing.Size(129, 32)
        Me.ButtonFormNoticeSave.TabIndex = 1
        Me.ButtonFormNoticeSave.Text = "Добавить"
        Me.ButtonFormNoticeSave.UseVisualStyleBackColor = True
        '
        'ButtonFormNoticeCancel
        '
        Me.ButtonFormNoticeCancel.Location = New System.Drawing.Point(269, 308)
        Me.ButtonFormNoticeCancel.Name = "ButtonFormNoticeCancel"
        Me.ButtonFormNoticeCancel.Size = New System.Drawing.Size(129, 32)
        Me.ButtonFormNoticeCancel.TabIndex = 2
        Me.ButtonFormNoticeCancel.Text = "Отменить"
        Me.ButtonFormNoticeCancel.UseVisualStyleBackColor = True
        '
        'Form_Notice_Log
        '
        Me.Form_Notice_Log.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Form_Notice_Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Form_Notice_Log.Location = New System.Drawing.Point(12, 12)
        Me.Form_Notice_Log.Name = "Form_Notice_Log"
        Me.Form_Notice_Log.ReadOnly = True
        Me.Form_Notice_Log.Size = New System.Drawing.Size(480, 134)
        Me.Form_Notice_Log.TabIndex = 3
        Me.Form_Notice_Log.Text = ""
        '
        'GroupBoxComplete
        '
        Me.GroupBoxComplete.Controls.Add(Me.ResCompl)
        Me.GroupBoxComplete.Controls.Add(Me.LLICompl)
        Me.GroupBoxComplete.Controls.Add(Me.SLICompl)
        Me.GroupBoxComplete.Controls.Add(Me.PrepCompl)
        Me.GroupBoxComplete.Location = New System.Drawing.Point(12, 259)
        Me.GroupBoxComplete.Name = "GroupBoxComplete"
        Me.GroupBoxComplete.Size = New System.Drawing.Size(480, 43)
        Me.GroupBoxComplete.TabIndex = 4
        Me.GroupBoxComplete.TabStop = False
        Me.GroupBoxComplete.Text = "Закончить этап"
        '
        'ResCompl
        '
        Me.ResCompl.AutoSize = True
        Me.ResCompl.Location = New System.Drawing.Point(393, 19)
        Me.ResCompl.Name = "ResCompl"
        Me.ResCompl.Size = New System.Drawing.Size(81, 17)
        Me.ResCompl.TabIndex = 4
        Me.ResCompl.Text = "Обработки"
        Me.ResCompl.UseVisualStyleBackColor = True
        '
        'LLICompl
        '
        Me.LLICompl.AutoSize = True
        Me.LLICompl.Location = New System.Drawing.Point(268, 19)
        Me.LLICompl.Name = "LLICompl"
        Me.LLICompl.Size = New System.Drawing.Size(111, 17)
        Me.LLICompl.TabIndex = 2
        Me.LLICompl.Text = "Облучения ДЖИ"
        Me.LLICompl.UseVisualStyleBackColor = True
        '
        'SLICompl
        '
        Me.SLICompl.AutoSize = True
        Me.SLICompl.Location = New System.Drawing.Point(126, 19)
        Me.SLICompl.Name = "SLICompl"
        Me.SLICompl.Size = New System.Drawing.Size(109, 17)
        Me.SLICompl.TabIndex = 1
        Me.SLICompl.Text = "Облучения КЖИ"
        Me.SLICompl.UseVisualStyleBackColor = True
        '
        'PrepCompl
        '
        Me.PrepCompl.AutoSize = True
        Me.PrepCompl.Location = New System.Drawing.Point(4, 19)
        Me.PrepCompl.Name = "PrepCompl"
        Me.PrepCompl.Size = New System.Drawing.Size(116, 17)
        Me.PrepCompl.TabIndex = 0
        Me.PrepCompl.Text = "Пробоподготовки"
        Me.PrepCompl.UseVisualStyleBackColor = True
        '
        'Form_Notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 343)
        Me.Controls.Add(Me.GroupBoxComplete)
        Me.Controls.Add(Me.Form_Notice_Log)
        Me.Controls.Add(Me.ButtonFormNoticeCancel)
        Me.Controls.Add(Me.ButtonFormNoticeSave)
        Me.Controls.Add(Me.RichTextBoxFormNotice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Notice"
        Me.Text = "Form_Notice"
        Me.GroupBoxComplete.ResumeLayout(False)
        Me.GroupBoxComplete.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxFormNotice As RichTextBox
    Friend WithEvents ButtonFormNoticeSave As Button
    Friend WithEvents ButtonFormNoticeCancel As Button
    Friend WithEvents Form_Notice_Log As RichTextBox
    Friend WithEvents GroupBoxComplete As GroupBox
    Friend WithEvents LLICompl As CheckBox
    Friend WithEvents SLICompl As CheckBox
    Friend WithEvents PrepCompl As CheckBox
    Friend WithEvents ResCompl As CheckBox
End Class
