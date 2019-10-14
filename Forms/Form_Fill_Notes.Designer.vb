<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Fill_Notes
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
        Me.ComboBox_Sample_Type = New System.Windows.Forms.ComboBox()
        Me.L_Name_Group_Of_Elements = New System.Windows.Forms.Label()
        Me.ComboBox_DeterminedElements = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox_Separate_Elements = New System.Windows.Forms.CheckedListBox()
        Me.L_Name_Sample_Type = New System.Windows.Forms.Label()
        Me.CheckedListBox_Group_Of_Elements = New System.Windows.Forms.CheckedListBox()
        Me.L_Name_DeterminedElements = New System.Windows.Forms.Label()
        Me.MaskedTextBox_Quantity = New System.Windows.Forms.MaskedTextBox()
        Me.L_Quantity = New System.Windows.Forms.Label()
        Me.B_Fill_Notes = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.B_Select_All = New System.Windows.Forms.Button()
        Me.L_Name_Sample_Subtype = New System.Windows.Forms.Label()
        Me.ComboBox_Sample_Subtype = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ComboBox_Sample_Type
        '
        Me.ComboBox_Sample_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sample_Type.FormattingEnabled = True
        Me.ComboBox_Sample_Type.Items.AddRange(New Object() {"", "biomedical materials", "filters", "foodstuffs", "luquids", "others", "rocks", "sediments", "soils", "technological", "vegetation"})
        Me.ComboBox_Sample_Type.Location = New System.Drawing.Point(50, 25)
        Me.ComboBox_Sample_Type.Name = "ComboBox_Sample_Type"
        Me.ComboBox_Sample_Type.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox_Sample_Type.TabIndex = 125
        '
        'L_Name_Group_Of_Elements
        '
        Me.L_Name_Group_Of_Elements.AutoSize = True
        Me.L_Name_Group_Of_Elements.Location = New System.Drawing.Point(24, 139)
        Me.L_Name_Group_Of_Elements.Name = "L_Name_Group_Of_Elements"
        Me.L_Name_Group_Of_Elements.Size = New System.Drawing.Size(93, 13)
        Me.L_Name_Group_Of_Elements.TabIndex = 124
        Me.L_Name_Group_Of_Elements.Text = "Group of elements"
        '
        'ComboBox_DeterminedElements
        '
        Me.ComboBox_DeterminedElements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_DeterminedElements.FormattingEnabled = True
        Me.ComboBox_DeterminedElements.Items.AddRange(New Object() {"group of elements", "separate elements", "all elements"})
        Me.ComboBox_DeterminedElements.Location = New System.Drawing.Point(12, 78)
        Me.ComboBox_DeterminedElements.Name = "ComboBox_DeterminedElements"
        Me.ComboBox_DeterminedElements.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DeterminedElements.TabIndex = 123
        '
        'CheckedListBox_Separate_Elements
        '
        Me.CheckedListBox_Separate_Elements.ColumnWidth = 70
        Me.CheckedListBox_Separate_Elements.Enabled = False
        Me.CheckedListBox_Separate_Elements.FormattingEnabled = True
        Me.CheckedListBox_Separate_Elements.Items.AddRange(New Object() {"F", "Na", "Mg", "Al", "Si", "S", "Cl", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Cu", "Zn", "Ga", "As", "Se", "Br", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Ru", "Ag", "Cd", "In", "Sn", "Sb", "I", "Cs", "Ba", "La", "Ce", "Nd", "Sm", "Eu", "Gd", "Tb", "Dy", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Ir", "Pt", "Au", "Hg", "Th", "U"})
        Me.CheckedListBox_Separate_Elements.Location = New System.Drawing.Point(156, 78)
        Me.CheckedListBox_Separate_Elements.MultiColumn = True
        Me.CheckedListBox_Separate_Elements.Name = "CheckedListBox_Separate_Elements"
        Me.CheckedListBox_Separate_Elements.Size = New System.Drawing.Size(286, 229)
        Me.CheckedListBox_Separate_Elements.TabIndex = 122
        '
        'L_Name_Sample_Type
        '
        Me.L_Name_Sample_Type.AutoSize = True
        Me.L_Name_Sample_Type.Location = New System.Drawing.Point(82, 9)
        Me.L_Name_Sample_Type.Name = "L_Name_Sample_Type"
        Me.L_Name_Sample_Type.Size = New System.Drawing.Size(65, 13)
        Me.L_Name_Sample_Type.TabIndex = 121
        Me.L_Name_Sample_Type.Text = "Sample type"
        '
        'CheckedListBox_Group_Of_Elements
        '
        Me.CheckedListBox_Group_Of_Elements.FormattingEnabled = True
        Me.CheckedListBox_Group_Of_Elements.Items.AddRange(New Object() {"halogens", "heavy metals", "short-lived", "long-lived"})
        Me.CheckedListBox_Group_Of_Elements.Location = New System.Drawing.Point(20, 155)
        Me.CheckedListBox_Group_Of_Elements.Name = "CheckedListBox_Group_Of_Elements"
        Me.CheckedListBox_Group_Of_Elements.Size = New System.Drawing.Size(103, 64)
        Me.CheckedListBox_Group_Of_Elements.TabIndex = 120
        '
        'L_Name_DeterminedElements
        '
        Me.L_Name_DeterminedElements.AutoSize = True
        Me.L_Name_DeterminedElements.Location = New System.Drawing.Point(17, 62)
        Me.L_Name_DeterminedElements.Name = "L_Name_DeterminedElements"
        Me.L_Name_DeterminedElements.Size = New System.Drawing.Size(106, 13)
        Me.L_Name_DeterminedElements.TabIndex = 117
        Me.L_Name_DeterminedElements.Text = "Determined elements"
        '
        'MaskedTextBox_Quantity
        '
        Me.MaskedTextBox_Quantity.Location = New System.Drawing.Point(364, 25)
        Me.MaskedTextBox_Quantity.Mask = "00"
        Me.MaskedTextBox_Quantity.Name = "MaskedTextBox_Quantity"
        Me.MaskedTextBox_Quantity.Size = New System.Drawing.Size(30, 20)
        Me.MaskedTextBox_Quantity.TabIndex = 127
        '
        'L_Quantity
        '
        Me.L_Quantity.AutoSize = True
        Me.L_Quantity.Location = New System.Drawing.Point(361, 7)
        Me.L_Quantity.Name = "L_Quantity"
        Me.L_Quantity.Size = New System.Drawing.Size(46, 13)
        Me.L_Quantity.TabIndex = 126
        Me.L_Quantity.Text = "Quantity"
        '
        'B_Fill_Notes
        '
        Me.B_Fill_Notes.Location = New System.Drawing.Point(139, 315)
        Me.B_Fill_Notes.Name = "B_Fill_Notes"
        Me.B_Fill_Notes.Size = New System.Drawing.Size(75, 23)
        Me.B_Fill_Notes.TabIndex = 128
        Me.B_Fill_Notes.Text = "Fill notes"
        Me.B_Fill_Notes.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(236, 315)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(75, 23)
        Me.B_Close.TabIndex = 129
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'B_Select_All
        '
        Me.B_Select_All.Location = New System.Drawing.Point(35, 105)
        Me.B_Select_All.Name = "B_Select_All"
        Me.B_Select_All.Size = New System.Drawing.Size(75, 23)
        Me.B_Select_All.TabIndex = 130
        Me.B_Select_All.Text = "Select all"
        Me.B_Select_All.UseVisualStyleBackColor = True
        '
        'L_Name_Sample_Subtype
        '
        Me.L_Name_Sample_Subtype.AutoSize = True
        Me.L_Name_Sample_Subtype.Location = New System.Drawing.Point(224, 10)
        Me.L_Name_Sample_Subtype.Name = "L_Name_Sample_Subtype"
        Me.L_Name_Sample_Subtype.Size = New System.Drawing.Size(82, 13)
        Me.L_Name_Sample_Subtype.TabIndex = 177
        Me.L_Name_Sample_Subtype.Text = "Sample subtype"
        Me.L_Name_Sample_Subtype.Visible = False
        '
        'ComboBox_Sample_Subtype
        '
        Me.ComboBox_Sample_Subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sample_Subtype.FormattingEnabled = True
        Me.ComboBox_Sample_Subtype.Items.AddRange(New Object() {"", "soils", "sediments", "rocks", "foodstuffs", "vegetation", "biomedical materials", "technological", "filters", "luquids", "others"})
        Me.ComboBox_Sample_Subtype.Location = New System.Drawing.Point(201, 25)
        Me.ComboBox_Sample_Subtype.Name = "ComboBox_Sample_Subtype"
        Me.ComboBox_Sample_Subtype.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox_Sample_Subtype.TabIndex = 176
        Me.ComboBox_Sample_Subtype.Visible = False
        '
        'Form_Fill_Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 350)
        Me.Controls.Add(Me.L_Name_Sample_Subtype)
        Me.Controls.Add(Me.ComboBox_Sample_Subtype)
        Me.Controls.Add(Me.B_Select_All)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Fill_Notes)
        Me.Controls.Add(Me.MaskedTextBox_Quantity)
        Me.Controls.Add(Me.L_Quantity)
        Me.Controls.Add(Me.ComboBox_Sample_Type)
        Me.Controls.Add(Me.L_Name_Group_Of_Elements)
        Me.Controls.Add(Me.ComboBox_DeterminedElements)
        Me.Controls.Add(Me.CheckedListBox_Separate_Elements)
        Me.Controls.Add(Me.L_Name_Sample_Type)
        Me.Controls.Add(Me.CheckedListBox_Group_Of_Elements)
        Me.Controls.Add(Me.L_Name_DeterminedElements)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Fill_Notes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fill in notes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_Sample_Type As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Group_Of_Elements As System.Windows.Forms.Label
    Friend WithEvents ComboBox_DeterminedElements As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListBox_Separate_Elements As System.Windows.Forms.CheckedListBox
    Friend WithEvents L_Name_Sample_Type As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox_Group_Of_Elements As System.Windows.Forms.CheckedListBox
    Friend WithEvents L_Name_DeterminedElements As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_Quantity As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Quantity As System.Windows.Forms.Label
    Friend WithEvents B_Fill_Notes As System.Windows.Forms.Button
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents B_Select_All As System.Windows.Forms.Button
    Friend WithEvents L_Name_Sample_Subtype As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sample_Subtype As System.Windows.Forms.ComboBox
End Class
