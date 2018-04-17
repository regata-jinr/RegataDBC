Public Class Form_Fill_Notes

    Private Sub ComboBox_DeterminedElements_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_DeterminedElements.SelectionChangeCommitted
        If ComboBox_DeterminedElements.SelectedItem = "group of elements" Then 'отдельные элементы 
            CheckedListBox_Group_Of_Elements.Enabled = True
            B_Select_All.Enabled = False
            For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
            Next
            CheckedListBox_Separate_Elements.Enabled = False
            For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                CheckedListBox_Separate_Elements.SetItemChecked(i, False)
            Next
        End If

        If ComboBox_DeterminedElements.SelectedItem = "separate elements" Then 'отдельные элементы 
            CheckedListBox_Group_Of_Elements.Enabled = False
            B_Select_All.Enabled = True
            For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
            Next
            CheckedListBox_Separate_Elements.Enabled = True
            For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                CheckedListBox_Separate_Elements.SetItemChecked(i, False)
            Next
        End If

        If ComboBox_DeterminedElements.SelectedItem = "all elements" Then 'все элементы 
            CheckedListBox_Group_Of_Elements.Enabled = False
            B_Select_All.Enabled = False
            For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
            Next
            CheckedListBox_Separate_Elements.Enabled = False
            For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                CheckedListBox_Separate_Elements.SetItemChecked(i, True)
            Next
        End If
    End Sub

    Private Sub CheckedListBox_Group_Of_Elements_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox_Group_Of_Elements.SelectedValueChanged
        For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
            CheckedListBox_Separate_Elements.SetItemChecked(i, False)
        Next
        If CheckedListBox_Group_Of_Elements.GetItemChecked(0) = True Then 'halogens
            CheckedListBox_Separate_Elements.SetItemChecked(6, True) 'Cl
            CheckedListBox_Separate_Elements.SetItemChecked(21, True) 'Br
            CheckedListBox_Separate_Elements.SetItemChecked(34, True) 'I
        End If

        If CheckedListBox_Group_Of_Elements.GetItemChecked(1) = True Then 'heavy metals
            CheckedListBox_Separate_Elements.SetItemChecked(11, True) 'V
            CheckedListBox_Separate_Elements.SetItemChecked(12, True) 'Cr
            CheckedListBox_Separate_Elements.SetItemChecked(13, True) 'Mn
            CheckedListBox_Separate_Elements.SetItemChecked(14, True) 'Fe
            CheckedListBox_Separate_Elements.SetItemChecked(15, True) 'Co
            CheckedListBox_Separate_Elements.SetItemChecked(16, True) 'Cu
            CheckedListBox_Separate_Elements.SetItemChecked(17, True) 'Zn
            CheckedListBox_Separate_Elements.SetItemChecked(18, True) 'Ga
            CheckedListBox_Separate_Elements.SetItemChecked(19, True) 'As
            CheckedListBox_Separate_Elements.SetItemChecked(20, True) 'Se
            CheckedListBox_Separate_Elements.SetItemChecked(22, True) 'Rb
            CheckedListBox_Separate_Elements.SetItemChecked(23, True) 'Sr
            CheckedListBox_Separate_Elements.SetItemChecked(24, True) 'Y
            CheckedListBox_Separate_Elements.SetItemChecked(25, True) 'Zr
            CheckedListBox_Separate_Elements.SetItemChecked(26, True) 'Nd
            CheckedListBox_Separate_Elements.SetItemChecked(27, True) 'Mo
            CheckedListBox_Separate_Elements.SetItemChecked(28, True) 'Ru
            CheckedListBox_Separate_Elements.SetItemChecked(29, True) 'Ag
            CheckedListBox_Separate_Elements.SetItemChecked(30, True) 'Cd
            CheckedListBox_Separate_Elements.SetItemChecked(31, True) 'In
            CheckedListBox_Separate_Elements.SetItemChecked(32, True) 'Sn
            CheckedListBox_Separate_Elements.SetItemChecked(33, True) 'Sb
            CheckedListBox_Separate_Elements.SetItemChecked(35, True) 'Cs
            CheckedListBox_Separate_Elements.SetItemChecked(36, True) 'Ba
            CheckedListBox_Separate_Elements.SetItemChecked(37, True) 'La
            CheckedListBox_Separate_Elements.SetItemChecked(38, True) 'Ce
            CheckedListBox_Separate_Elements.SetItemChecked(39, True) 'Nd
            CheckedListBox_Separate_Elements.SetItemChecked(40, True) 'Sm
            CheckedListBox_Separate_Elements.SetItemChecked(41, True) 'Eu
            CheckedListBox_Separate_Elements.SetItemChecked(42, True) 'Gd
            CheckedListBox_Separate_Elements.SetItemChecked(43, True) 'Tb
            CheckedListBox_Separate_Elements.SetItemChecked(44, True) 'Dy
            CheckedListBox_Separate_Elements.SetItemChecked(45, True) 'Er
            CheckedListBox_Separate_Elements.SetItemChecked(46, True) 'Tm
            CheckedListBox_Separate_Elements.SetItemChecked(47, True) 'Yb
            CheckedListBox_Separate_Elements.SetItemChecked(48, True) 'Lu
            CheckedListBox_Separate_Elements.SetItemChecked(49, True) 'Hf
            CheckedListBox_Separate_Elements.SetItemChecked(50, True) 'Ta
            CheckedListBox_Separate_Elements.SetItemChecked(51, True) 'W
            CheckedListBox_Separate_Elements.SetItemChecked(53, True) 'Ir
            CheckedListBox_Separate_Elements.SetItemChecked(54, True) 'Pt
            CheckedListBox_Separate_Elements.SetItemChecked(55, True) 'Au
            CheckedListBox_Separate_Elements.SetItemChecked(56, True) 'Hg
            CheckedListBox_Separate_Elements.SetItemChecked(58, True) 'U
        End If

        If CheckedListBox_Group_Of_Elements.GetItemChecked(2) = True Then 'short-lived
            CheckedListBox_Separate_Elements.SetItemChecked(1, True) 'Na
            CheckedListBox_Separate_Elements.SetItemChecked(2, True) 'Mg
            CheckedListBox_Separate_Elements.SetItemChecked(3, True) 'Al
            CheckedListBox_Separate_Elements.SetItemChecked(4, True) 'Si
            CheckedListBox_Separate_Elements.SetItemChecked(5, True) 'S
            CheckedListBox_Separate_Elements.SetItemChecked(6, True) 'Cl
            CheckedListBox_Separate_Elements.SetItemChecked(7, True) 'K
            CheckedListBox_Separate_Elements.SetItemChecked(8, True) 'Ca
            CheckedListBox_Separate_Elements.SetItemChecked(10, True) 'Ti
            CheckedListBox_Separate_Elements.SetItemChecked(11, True) 'V
            CheckedListBox_Separate_Elements.SetItemChecked(13, True) 'Mn
            CheckedListBox_Separate_Elements.SetItemChecked(16, True) 'Cu
            CheckedListBox_Separate_Elements.SetItemChecked(21, True) 'Br
            CheckedListBox_Separate_Elements.SetItemChecked(24, True) 'Y
            CheckedListBox_Separate_Elements.SetItemChecked(31, True) 'In
            CheckedListBox_Separate_Elements.SetItemChecked(32, True) 'Sn
            CheckedListBox_Separate_Elements.SetItemChecked(34, True) 'I
            CheckedListBox_Separate_Elements.SetItemChecked(36, True) 'Ba
            CheckedListBox_Separate_Elements.SetItemChecked(44, True) 'Dy
            CheckedListBox_Separate_Elements.SetItemChecked(45, True) 'Er
            CheckedListBox_Separate_Elements.SetItemChecked(58, True) 'U
        End If

        If CheckedListBox_Group_Of_Elements.GetItemChecked(3) = True Then 'long-lived
            CheckedListBox_Separate_Elements.SetItemChecked(1, True) 'Na
            CheckedListBox_Separate_Elements.SetItemChecked(7, True) 'K
            CheckedListBox_Separate_Elements.SetItemChecked(9, True) 'Sc
            CheckedListBox_Separate_Elements.SetItemChecked(12, True) 'Cr
            CheckedListBox_Separate_Elements.SetItemChecked(14, True) 'Fe
            CheckedListBox_Separate_Elements.SetItemChecked(15, True) 'Co
            CheckedListBox_Separate_Elements.SetItemChecked(17, True) 'Zn
            CheckedListBox_Separate_Elements.SetItemChecked(18, True) 'Ga
            CheckedListBox_Separate_Elements.SetItemChecked(19, True) 'As
            CheckedListBox_Separate_Elements.SetItemChecked(20, True) 'Se
            CheckedListBox_Separate_Elements.SetItemChecked(21, True) 'Br
            CheckedListBox_Separate_Elements.SetItemChecked(22, True) 'Rb
            CheckedListBox_Separate_Elements.SetItemChecked(23, True) 'Sr
            CheckedListBox_Separate_Elements.SetItemChecked(24, True) 'Y
            CheckedListBox_Separate_Elements.SetItemChecked(25, True) 'Zr
            CheckedListBox_Separate_Elements.SetItemChecked(26, True) 'Nb
            CheckedListBox_Separate_Elements.SetItemChecked(27, True) 'Mo
            CheckedListBox_Separate_Elements.SetItemChecked(28, True) 'Ru
            CheckedListBox_Separate_Elements.SetItemChecked(29, True) 'Ag
            CheckedListBox_Separate_Elements.SetItemChecked(30, True) 'Cd
            CheckedListBox_Separate_Elements.SetItemChecked(32, True) 'Sn
            CheckedListBox_Separate_Elements.SetItemChecked(33, True) 'Sb
            CheckedListBox_Separate_Elements.SetItemChecked(35, True) 'Cs
            CheckedListBox_Separate_Elements.SetItemChecked(36, True) 'Ba
            CheckedListBox_Separate_Elements.SetItemChecked(37, True) 'La
            CheckedListBox_Separate_Elements.SetItemChecked(38, True) 'Ce
            CheckedListBox_Separate_Elements.SetItemChecked(39, True) 'Nd
            CheckedListBox_Separate_Elements.SetItemChecked(40, True) 'Sm
            CheckedListBox_Separate_Elements.SetItemChecked(41, True) 'Eu
            CheckedListBox_Separate_Elements.SetItemChecked(42, True) 'Gd
            CheckedListBox_Separate_Elements.SetItemChecked(43, True) 'Tb
            CheckedListBox_Separate_Elements.SetItemChecked(46, True) 'Tm
            CheckedListBox_Separate_Elements.SetItemChecked(47, True) 'Yb
            CheckedListBox_Separate_Elements.SetItemChecked(48, True) 'Lu
            CheckedListBox_Separate_Elements.SetItemChecked(49, True) 'Hf
            CheckedListBox_Separate_Elements.SetItemChecked(50, True) 'Ta
            CheckedListBox_Separate_Elements.SetItemChecked(51, True) 'W
            CheckedListBox_Separate_Elements.SetItemChecked(52, True) 'Re
            CheckedListBox_Separate_Elements.SetItemChecked(53, True) 'Ir
            CheckedListBox_Separate_Elements.SetItemChecked(54, True) 'Pt
            CheckedListBox_Separate_Elements.SetItemChecked(55, True) 'Au
            CheckedListBox_Separate_Elements.SetItemChecked(56, True) 'Hg
            CheckedListBox_Separate_Elements.SetItemChecked(57, True) 'Th
            CheckedListBox_Separate_Elements.SetItemChecked(58, True) 'U
        End If
    End Sub

    Private Sub Form_Fill_Notes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckedListBox_Group_Of_Elements.Enabled = False
        CheckedListBox_Separate_Elements.Enabled = False
        B_Select_All.Enabled = False
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub B_Fill_Notes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_Notes.Click
        Dim Notes_Text, Elements_List, Group_Of_Elements_List As String
        Notes_Text = ""
        Elements_List = ""
        Group_Of_Elements_List = ""
        If ComboBox_Sample_Type.Text = "" Then
            MsgBox("Select sample type!")
            Exit Sub
        End If
        If ComboBox_Sample_Subtype.Visible = True And ComboBox_Sample_Subtype.Text = "" Then
            MsgBox("Select sample subtype!")
            Exit Sub
        End If
        If MaskedTextBox_Quantity.Text = "" Then
            MsgBox("Type quantity of samples!")
            Exit Sub
        End If
        If ComboBox_DeterminedElements.Text = "" Then
            MsgBox("Select determined elements!")
            Exit Sub
        End If

        If ComboBox_Sample_Subtype.Visible = False Then
            Notes_Text = "Sample type: " + ComboBox_Sample_Type.Text + "; quantity: " + MaskedTextBox_Quantity.Text.Trim +
                     "; determined elements: " + ComboBox_DeterminedElements.Text
        End If
        
        If ComboBox_Sample_Subtype.Visible = True Then
            Notes_Text = "Sample type: " + ComboBox_Sample_Type.Text + "; sample subtype: " + ComboBox_Sample_Subtype.Text + "; quantity: " + MaskedTextBox_Quantity.Text.Trim +
                     "; determined elements: " + ComboBox_DeterminedElements.Text
        End If

        For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
            If CheckedListBox_Group_Of_Elements.GetItemChecked(i) = True Then Group_Of_Elements_List = Group_Of_Elements_List + CheckedListBox_Group_Of_Elements.Items.Item(i) + ", "
        Next
        Group_Of_Elements_List = Group_Of_Elements_List.Trim(" ", ",")

        If Group_Of_Elements_List <> "" Then
            Notes_Text = Notes_Text + "; " + Group_Of_Elements_List
        End If

        For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
            If CheckedListBox_Separate_Elements.GetItemChecked(i) = True Then Elements_List = Elements_List + CheckedListBox_Separate_Elements.Items.Item(i) + ", "
        Next
        Elements_List = Elements_List.Trim(" ", ",")
        If Elements_List <> "" Then
            Notes_Text = Notes_Text + "; " + Elements_List
        End If

        Notes_Text = Notes_Text.Trim
        Notes_Text = Notes_Text + "."


        If Form_Sample_Set_Accept.Notes_Number = 1 Then
            Form_Sample_Set_Accept.TextBox_Notes_1.Text = Notes_Text
            Me.Close()
            Exit Sub
        End If
        If Form_Sample_Set_Accept.Notes_Number = 2 Then
            Form_Sample_Set_Accept.TextBox_Notes_2.Text = Notes_Text
            Me.Close()
            Exit Sub
        End If
        If Form_Sample_Set_Accept.Notes_Number = 3 Then
            Form_Sample_Set_Accept.TextBox_Notes_3.Text = Notes_Text
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub B_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_All.Click
        For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
            CheckedListBox_Separate_Elements.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub ComboBox_Sample_Type_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Sample_Type.SelectionChangeCommitted
        Try
            If (ComboBox_Sample_Type.Text <> "vegetation") Or (ComboBox_Sample_Type.Text <> "biomedical materials") Then
                ComboBox_Sample_Subtype.Text = ""
                ComboBox_Sample_Subtype.Visible = False
                L_Name_Sample_Subtype.Visible = False
            End If
            If ComboBox_Sample_Type.Text = "vegetation" Then
                ComboBox_Sample_Subtype.Items.Clear()
                L_Name_Sample_Subtype.Text = "Vegetation"
                ComboBox_Sample_Subtype.Items.Add("")
                ComboBox_Sample_Subtype.Items.Add("moss")
                ComboBox_Sample_Subtype.Items.Add("leaves")
                ComboBox_Sample_Subtype.Items.Add("tree-bark")
                ComboBox_Sample_Subtype.Items.Add("lichens")
                ComboBox_Sample_Subtype.Items.Add("other vegetation")
                L_Name_Sample_Subtype.Visible = True
                ComboBox_Sample_Subtype.Visible = True
            End If
            If ComboBox_Sample_Type.Text = "biomedical materials" Then
                ComboBox_Sample_Subtype.Items.Clear()
                L_Name_Sample_Subtype.Text = "Biomedical materials"
                ComboBox_Sample_Subtype.Items.Add("")
                ComboBox_Sample_Subtype.Items.Add("hairs")
                ComboBox_Sample_Subtype.Items.Add("nails")
                ComboBox_Sample_Subtype.Items.Add("blood")
                ComboBox_Sample_Subtype.Items.Add("urine")
                ComboBox_Sample_Subtype.Items.Add("tissues")
                ComboBox_Sample_Subtype.Items.Add("teeth")
                ComboBox_Sample_Subtype.Items.Add("other biomedical materials")
                L_Name_Sample_Subtype.Visible = True
                ComboBox_Sample_Subtype.Visible = True
            End If
        Catch ex As Exception
            MsgBox("The operation was cancelled!")
        End Try
    End Sub
End Class