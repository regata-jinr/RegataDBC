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
        Me.CheckBoxCompleteLLI = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCompleteSLI = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCompletePrep = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCompleteProcess = New System.Windows.Forms.CheckBox()
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
        Me.ButtonFormNoticeSave.Text = "Add"
        Me.ButtonFormNoticeSave.UseVisualStyleBackColor = True
        '
        'ButtonFormNoticeCancel
        '
        Me.ButtonFormNoticeCancel.Location = New System.Drawing.Point(269, 308)
        Me.ButtonFormNoticeCancel.Name = "ButtonFormNoticeCancel"
        Me.ButtonFormNoticeCancel.Size = New System.Drawing.Size(129, 32)
        Me.ButtonFormNoticeCancel.TabIndex = 2
        Me.ButtonFormNoticeCancel.Text = "Cancel"
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
        Me.GroupBoxComplete.Controls.Add(Me.CheckBoxCompleteProcess)
        Me.GroupBoxComplete.Controls.Add(Me.CheckBoxCompleteLLI)
        Me.GroupBoxComplete.Controls.Add(Me.CheckBoxCompleteSLI)
        Me.GroupBoxComplete.Controls.Add(Me.CheckBoxCompletePrep)
        Me.GroupBoxComplete.Location = New System.Drawing.Point(12, 259)
        Me.GroupBoxComplete.Name = "GroupBoxComplete"
        Me.GroupBoxComplete.Size = New System.Drawing.Size(480, 43)
        Me.GroupBoxComplete.TabIndex = 4
        Me.GroupBoxComplete.TabStop = False
        Me.GroupBoxComplete.Text = "Закончить этап"
        '
        'CheckBoxCompleteLLI
        '
        Me.CheckBoxCompleteLLI.AutoSize = True
        Me.CheckBoxCompleteLLI.Location = New System.Drawing.Point(268, 19)
        Me.CheckBoxCompleteLLI.Name = "CheckBoxCompleteLLI"
        Me.CheckBoxCompleteLLI.Size = New System.Drawing.Size(111, 17)
        Me.CheckBoxCompleteLLI.TabIndex = 2
        Me.CheckBoxCompleteLLI.Text = "Облучения ДЖИ"
        Me.CheckBoxCompleteLLI.UseVisualStyleBackColor = True
        '
        'CheckBoxCompleteSLI
        '
        Me.CheckBoxCompleteSLI.AutoSize = True
        Me.CheckBoxCompleteSLI.Location = New System.Drawing.Point(126, 19)
        Me.CheckBoxCompleteSLI.Name = "CheckBoxCompleteSLI"
        Me.CheckBoxCompleteSLI.Size = New System.Drawing.Size(109, 17)
        Me.CheckBoxCompleteSLI.TabIndex = 1
        Me.CheckBoxCompleteSLI.Text = "Облучения КЖИ"
        Me.CheckBoxCompleteSLI.UseVisualStyleBackColor = True
        '
        'CheckBoxCompletePrep
        '
        Me.CheckBoxCompletePrep.AutoSize = True
        Me.CheckBoxCompletePrep.Location = New System.Drawing.Point(4, 19)
        Me.CheckBoxCompletePrep.Name = "CheckBoxCompletePrep"
        Me.CheckBoxCompletePrep.Size = New System.Drawing.Size(116, 17)
        Me.CheckBoxCompletePrep.TabIndex = 0
        Me.CheckBoxCompletePrep.Text = "Пробоподготовки"
        Me.CheckBoxCompletePrep.UseVisualStyleBackColor = True
        '
        'CheckBoxCompleteProcess
        '
        Me.CheckBoxCompleteProcess.AutoSize = True
        Me.CheckBoxCompleteProcess.Location = New System.Drawing.Point(393, 19)
        Me.CheckBoxCompleteProcess.Name = "CheckBoxCompleteProcess"
        Me.CheckBoxCompleteProcess.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxCompleteProcess.TabIndex = 4
        Me.CheckBoxCompleteProcess.Text = "Обработки"
        Me.CheckBoxCompleteProcess.UseVisualStyleBackColor = True
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
    Friend WithEvents CheckBoxCompleteLLI As CheckBox
    Friend WithEvents CheckBoxCompleteSLI As CheckBox
    Friend WithEvents CheckBoxCompletePrep As CheckBox
    Friend WithEvents CheckBoxCompleteProcess As CheckBox
End Class
