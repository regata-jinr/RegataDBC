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
        Me.SuspendLayout()
        '
        'RichTextBoxFormNotice
        '
        Me.RichTextBoxFormNotice.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBoxFormNotice.Name = "RichTextBoxFormNotice"
        Me.RichTextBoxFormNotice.Size = New System.Drawing.Size(480, 272)
        Me.RichTextBoxFormNotice.TabIndex = 0
        Me.RichTextBoxFormNotice.Text = ""
        '
        'ButtonFormNoticeSave
        '
        Me.ButtonFormNoticeSave.Location = New System.Drawing.Point(105, 299)
        Me.ButtonFormNoticeSave.Name = "ButtonFormNoticeSave"
        Me.ButtonFormNoticeSave.Size = New System.Drawing.Size(129, 32)
        Me.ButtonFormNoticeSave.TabIndex = 1
        Me.ButtonFormNoticeSave.Text = "Save"
        Me.ButtonFormNoticeSave.UseVisualStyleBackColor = True
        '
        'ButtonFormNoticeCancel
        '
        Me.ButtonFormNoticeCancel.Location = New System.Drawing.Point(269, 299)
        Me.ButtonFormNoticeCancel.Name = "ButtonFormNoticeCancel"
        Me.ButtonFormNoticeCancel.Size = New System.Drawing.Size(129, 32)
        Me.ButtonFormNoticeCancel.TabIndex = 2
        Me.ButtonFormNoticeCancel.Text = "Cancel"
        Me.ButtonFormNoticeCancel.UseVisualStyleBackColor = True
        '
        'Form_Notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 343)
        Me.Controls.Add(Me.ButtonFormNoticeCancel)
        Me.Controls.Add(Me.ButtonFormNoticeSave)
        Me.Controls.Add(Me.RichTextBoxFormNotice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Notice"
        Me.Text = "Form_Notice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxFormNotice As RichTextBox
    Friend WithEvents ButtonFormNoticeSave As Button
    Friend WithEvents ButtonFormNoticeCancel As Button
End Class
