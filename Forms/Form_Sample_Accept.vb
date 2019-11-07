Imports System
Imports System.Globalization
'Imports nsExcel = Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Interop

Imports System.Data.SqlClient

Public Class Form_Sample_Accept
    Dim Separate_Elements(64) As String

    Public Sub ComboBox_Determined_Elements_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Determined_Elements.SelectionChangeCommitted
        Try
            If ComboBox_Determined_Elements.SelectedItem = "group of elements" Then 'отдельные элементы 
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

            If ComboBox_Determined_Elements.SelectedItem = "separate elements" Then 'отдельные элементы 
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

            If ComboBox_Determined_Elements.SelectedItem = "all elements" Then 'все элементы 
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
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_Determined_Elements_SelectionChangeCommitted)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in ComboBox_Determined_Elements_SelectionChangeCommitted)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_NewSampleAccept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Separate_Elements(0) = "A_F_Plan"
            Separate_Elements(1) = "A_Na_Plan"
            Separate_Elements(2) = "A_Mg_Plan"
            Separate_Elements(3) = "A_Al_Plan"
            Separate_Elements(4) = "A_Si_Plan"
            Separate_Elements(5) = "A_S_Plan"
            Separate_Elements(6) = "A_Cl_Plan"
            Separate_Elements(7) = "A_K_Plan"
            Separate_Elements(8) = "A_Ca_Plan"
            Separate_Elements(9) = "A_Sc_Plan"
            Separate_Elements(10) = "A_Ti_Plan"
            Separate_Elements(11) = "A_V_Plan"
            Separate_Elements(12) = "A_Cr_Plan"
            Separate_Elements(13) = "A_Mn_Plan"
            Separate_Elements(14) = "A_Fe_Plan"
            Separate_Elements(15) = "A_Co_Plan"
            Separate_Elements(16) = "A_Ni_Plan"
            Separate_Elements(17) = "A_Cu_Plan"
            Separate_Elements(18) = "A_Zn_Plan"
            Separate_Elements(19) = "A_Ga_Plan"
            Separate_Elements(20) = "A_Ge_Plan"
            Separate_Elements(21) = "A_As_Plan"
            Separate_Elements(22) = "A_Se_Plan"
            Separate_Elements(23) = "A_Br_Plan"
            Separate_Elements(24) = "A_Rb_Plan"
            Separate_Elements(25) = "A_Sr_Plan"
            Separate_Elements(26) = "A_Y_Plan"
            Separate_Elements(27) = "A_Zr_Plan"
            Separate_Elements(28) = "A_Nb_Plan"
            Separate_Elements(29) = "A_Mo_Plan"
            Separate_Elements(30) = "A_Ru_Plan"
            Separate_Elements(31) = "A_Pd_Plan"
            Separate_Elements(32) = "A_Ag_Plan"
            Separate_Elements(33) = "A_Cd_Plan"
            Separate_Elements(34) = "A_In_Plan"
            Separate_Elements(35) = "A_Sn_Plan"
            Separate_Elements(36) = "A_Sb_Plan"
            Separate_Elements(37) = "A_I_Plan"
            Separate_Elements(38) = "A_Cs_Plan"
            Separate_Elements(39) = "A_Ba_Plan"
            Separate_Elements(40) = "A_La_Plan"
            Separate_Elements(41) = "A_Ce_Plan"
            Separate_Elements(42) = "A_Pr_Plan"
            Separate_Elements(43) = "A_Nd_Plan"
            Separate_Elements(44) = "A_Sm_Plan"
            Separate_Elements(45) = "A_Eu_Plan"
            Separate_Elements(46) = "A_Gd_Plan"
            Separate_Elements(47) = "A_Tb_Plan"
            Separate_Elements(48) = "A_Dy_Plan"
            Separate_Elements(49) = "A_Ho_Plan"
            Separate_Elements(50) = "A_Er_Plan"
            Separate_Elements(51) = "A_Tm_Plan"
            Separate_Elements(52) = "A_Yb_Plan"
            Separate_Elements(53) = "A_Lu_Plan"
            Separate_Elements(54) = "A_Hf_Plan"
            Separate_Elements(55) = "A_Ta_Plan"
            Separate_Elements(56) = "A_W_Plan"
            Separate_Elements(57) = "A_Re_Plan"
            Separate_Elements(58) = "A_Os_Plan"
            Separate_Elements(59) = "A_Ir_Plan"
            Separate_Elements(60) = "A_Pt_Plan"
            Separate_Elements(61) = "A_Au_Plan"
            Separate_Elements(62) = "A_Hg_Plan"
            Separate_Elements(63) = "A_Th_Plan"
            Separate_Elements(64) = "A_U_Plan"

            TextBox_Client_Sample_ID.Text = ""
            ComboBox_Sample_Type.Text = ""
            ComboBox_Sample_Subtype.Text = ""
            ComboBox_Sample_Subtype.Visible = False
            L_Name_Sample_Subtype.Visible = False
            TextBox_Collection_Place.Text = ""
            MaskedTextBox_Latitude.Text = ""
            MaskedTextBox_Longitude.Text = ""
            For i = 0 To CheckedListBox_Sample_Preparation.Items.Count - 1
                CheckedListBox_Sample_Preparation.SetItemChecked(i, False)
            Next
            ComboBox_Determined_Elements.Text = ""
            For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
            Next
            For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                CheckedListBox_Separate_Elements.SetItemChecked(i, False)
            Next
            ComboBox_Cupboard_Number.Text = ""
            ComboBox_Box_Number.Text = ""
            ComboBox_Table_ReceivedBy.Text = ""
            TextBox_New_Sample_Accept_Notes.Text = ""

            ' данная строка кода позволяет загрузить данные в таблицу "NAA_DB_EXPDataSet.table_ReceivedBy". При необходимости она может быть перемещена или удалена.
            Table_Received_ByTableAdapter.Connection.ConnectionString = Form_Main.MyConnectionString
            Me.Table_Received_ByTableAdapter.Fill(Me.NAA_DB_EXPDataSet.table_Received_By)
            ComboBox_Table_ReceivedBy.Text = ""

            CheckedListBox_Group_Of_Elements.Enabled = False
            CheckedListBox_Separate_Elements.Enabled = False
            B_Select_All.Enabled = False

            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            If Form_Samples_List.sample_action = "existing sample" Or (Form_Samples_List.sample_action = "new sample" And L_Sample_ID.Text > 1) Then
                If Form_Samples_List.sample_action = "existing sample" Then
                    cmd.CommandText = "SELECT A_Client_Sample_ID, A_Sample_Type, A_Sample_Subtype, A_Collection_Place, A_Latitude, A_Longitude, A_Cleaning_Plan, A_Drying_Plan, A_Evaporation_Plan, A_Freeze_Drying_Plan, A_Homogenizing_Plan, A_Pelletization_Plan, A_Fragmentation_Plan, A_Determined_Elements, A_Halogens_Plan, A_Heavy_Metals_Plan, A_Short_Lived_Plan, A_Long_Lived_Plan, A_F_Plan, A_Na_Plan, A_Mg_Plan, A_Al_Plan, A_Si_Plan, A_S_Plan, A_Cl_Plan, A_K_Plan, A_Ca_Plan, A_Sc_Plan, A_Ti_Plan, A_V_Plan, A_Cr_Plan, A_Mn_Plan, A_Fe_Plan, A_Co_Plan, A_Ni_Plan, A_Cu_Plan, A_Zn_Plan, A_Ga_Plan, A_Ge_Plan, A_As_Plan, A_Se_Plan, A_Br_Plan, A_Rb_Plan, A_Sr_Plan, A_Y_Plan, A_Zr_Plan, A_Nb_Plan, A_Mo_Plan, A_Ru_Plan, A_Pd_Plan, A_Ag_Plan, A_Cd_Plan, A_In_Plan, A_Sn_Plan, A_Sb_Plan, A_I_Plan, A_Cs_Plan, A_Ba_Plan, A_La_Plan, A_Ce_Plan, A_Pr_Plan, A_Nd_Plan, A_Sm_Plan, A_Eu_Plan, A_Gd_Plan, A_Tb_Plan, A_Dy_Plan, A_Ho_Plan, A_Er_Plan, A_Tm_Plan, A_Yb_Plan, A_Lu_Plan, A_Hf_Plan, A_Ta_Plan, A_W_Plan, A_Re_Plan, A_Os_Plan, A_Ir_Plan, A_Pt_Plan, A_Au_Plan, A_Hg_Plan, A_Th_Plan, A_U_Plan, A_Cupboard_Number, A_Box_Number, A_Received_By, A_Notes FROM dbo.table_Sample WHERE F_Country_Code='" +
                                        L_SS_Country_Code.Text + "' and F_Client_ID='" + L_SS_Client_ID.Text +
                                        "' and F_Year='" + L_SS_Year.Text + "' and F_Sample_Set_ID='" + L_SS_Sample_Set_ID.Text + "' and A_Sample_ID='" + L_Sample_ID.Text + "'"
                ElseIf (Form_Samples_List.sample_action = "new sample" And L_Sample_ID.Text > 1) Then
                    If L_Sample_ID.Text <= 10 Then ' это чтобы кисть не болела у заносящих новые образцы
                        cmd.CommandText = "SELECT A_Client_Sample_ID, A_Sample_Type, A_Sample_Subtype, A_Collection_Place, A_Latitude, A_Longitude, A_Cleaning_Plan, A_Drying_Plan, A_Evaporation_Plan, A_Freeze_Drying_Plan, A_Homogenizing_Plan, A_Pelletization_Plan, A_Fragmentation_Plan, A_Determined_Elements, A_Halogens_Plan, A_Heavy_Metals_Plan, A_Short_Lived_Plan, A_Long_Lived_Plan, A_F_Plan, A_Na_Plan, A_Mg_Plan, A_Al_Plan, A_Si_Plan, A_S_Plan, A_Cl_Plan, A_K_Plan, A_Ca_Plan, A_Sc_Plan, A_Ti_Plan, A_V_Plan, A_Cr_Plan, A_Mn_Plan, A_Fe_Plan, A_Co_Plan, A_Ni_Plan, A_Cu_Plan, A_Zn_Plan, A_Ga_Plan, A_Ge_Plan, A_As_Plan, A_Se_Plan, A_Br_Plan, A_Rb_Plan, A_Sr_Plan, A_Y_Plan, A_Zr_Plan, A_Nb_Plan, A_Mo_Plan, A_Ru_Plan, A_Pd_Plan, A_Ag_Plan, A_Cd_Plan, A_In_Plan, A_Sn_Plan, A_Sb_Plan, A_I_Plan, A_Cs_Plan, A_Ba_Plan, A_La_Plan, A_Ce_Plan, A_Pr_Plan, A_Nd_Plan, A_Sm_Plan, A_Eu_Plan, A_Gd_Plan, A_Tb_Plan, A_Dy_Plan, A_Ho_Plan, A_Er_Plan, A_Tm_Plan, A_Yb_Plan, A_Lu_Plan, A_Hf_Plan, A_Ta_Plan, A_W_Plan, A_Re_Plan, A_Os_Plan, A_Ir_Plan, A_Pt_Plan, A_Au_Plan, A_Hg_Plan, A_Th_Plan, A_U_Plan, A_Cupboard_Number, A_Box_Number, A_Received_By, A_Notes FROM dbo.table_Sample WHERE F_Country_Code='" +
                                          L_SS_Country_Code.Text + "' and F_Client_ID='" + L_SS_Client_ID.Text +
                                          "' and F_Year='" + L_SS_Year.Text + "' and F_Sample_Set_ID='" + L_SS_Sample_Set_ID.Text + "' and A_Sample_ID='0" + (L_Sample_ID.Text - 1).ToString + "'"
                    ElseIf L_Sample_ID.Text > 10 Then
                        cmd.CommandText = "SELECT A_Client_Sample_ID, A_Sample_Type, A_Sample_Subtype, A_Collection_Place, A_Latitude, A_Longitude, A_Cleaning_Plan, A_Drying_Plan, A_Evaporation_Plan, A_Freeze_Drying_Plan, A_Homogenizing_Plan, A_Pelletization_Plan, A_Fragmentation_Plan, A_Determined_Elements, A_Halogens_Plan, A_Heavy_Metals_Plan, A_Short_Lived_Plan, A_Long_Lived_Plan, A_F_Plan, A_Na_Plan, A_Mg_Plan, A_Al_Plan, A_Si_Plan, A_S_Plan, A_Cl_Plan, A_K_Plan, A_Ca_Plan, A_Sc_Plan, A_Ti_Plan, A_V_Plan, A_Cr_Plan, A_Mn_Plan, A_Fe_Plan, A_Co_Plan, A_Ni_Plan, A_Cu_Plan, A_Zn_Plan, A_Ga_Plan, A_Ge_Plan, A_As_Plan, A_Se_Plan, A_Br_Plan, A_Rb_Plan, A_Sr_Plan, A_Y_Plan, A_Zr_Plan, A_Nb_Plan, A_Mo_Plan, A_Ru_Plan, A_Pd_Plan, A_Ag_Plan, A_Cd_Plan, A_In_Plan, A_Sn_Plan, A_Sb_Plan, A_I_Plan, A_Cs_Plan, A_Ba_Plan, A_La_Plan, A_Ce_Plan, A_Pr_Plan, A_Nd_Plan, A_Sm_Plan, A_Eu_Plan, A_Gd_Plan, A_Tb_Plan, A_Dy_Plan, A_Ho_Plan, A_Er_Plan, A_Tm_Plan, A_Yb_Plan, A_Lu_Plan, A_Hf_Plan, A_Ta_Plan, A_W_Plan, A_Re_Plan, A_Os_Plan, A_Ir_Plan, A_Pt_Plan, A_Au_Plan, A_Hg_Plan, A_Th_Plan, A_U_Plan, A_Cupboard_Number, A_Box_Number, A_Received_By, A_Notes FROM dbo.table_Sample WHERE F_Country_Code='" +
                                          L_SS_Country_Code.Text + "' and F_Client_ID='" + L_SS_Client_ID.Text +
                                          "' and F_Year='" + L_SS_Year.Text + "' and F_Sample_Set_ID='" + L_SS_Sample_Set_ID.Text + "' and A_Sample_ID='" + (L_Sample_ID.Text - 1).ToString + "'"
                    End If
                End If

                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    TextBox_Client_Sample_ID.Text = reader(0).ToString
                    ComboBox_Sample_Type.Text = reader(1).ToString
                    ComboBox_Sample_Type_SelectionChangeCommitted(sender, e)
                    ComboBox_Sample_Subtype.Text = reader(2).ToString
                    TextBox_Collection_Place.Text = reader(3).ToString
                    MaskedTextBox_Latitude.Text = reader(4).ToString
                    MaskedTextBox_Longitude.Text = reader(5).ToString
                    For i = 0 To CheckedListBox_Sample_Preparation.Items.Count - 1
                        If Not IsDBNull(reader(6 + i)) Then
                            If reader(6 + i) = True Then
                                CheckedListBox_Sample_Preparation.SetItemChecked(i, True)
                            Else
                                CheckedListBox_Sample_Preparation.SetItemChecked(i, False)
                            End If
                        Else
                            CheckedListBox_Sample_Preparation.SetItemChecked(i, False)
                        End If
                    Next
                    ComboBox_Determined_Elements.Text = reader(13).ToString()
                    For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                        If IsDBNull(reader(14 + i)) Then
                            CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
                        Else
                            If reader(14 + i) = True Then
                                CheckedListBox_Group_Of_Elements.SetItemChecked(i, True)
                            Else
                                CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
                            End If
                        End If
                    Next
                    For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                        If IsDBNull(reader(18 + i)) Then
                            CheckedListBox_Separate_Elements.SetItemChecked(i, False)
                        Else
                            If reader(18 + i) = True Then
                                CheckedListBox_Separate_Elements.SetItemChecked(i, True)
                            Else
                                CheckedListBox_Separate_Elements.SetItemChecked(i, False)
                            End If
                        End If
                    Next
                    ComboBox_Cupboard_Number.Text = reader(83).ToString()
                    ComboBox_Box_Number.Text = reader(84).ToString()
                    ComboBox_Table_ReceivedBy.Text = reader(85).ToString()
                    TextBox_New_Sample_Accept_Notes.Text = reader(86).ToString()
                End While
                sqlConnection1.Close()

                If ComboBox_Determined_Elements.SelectedItem = "group of elements" Then 'группа элементов 
                    CheckedListBox_Group_Of_Elements.Enabled = True
                    'For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                    '    CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
                    'Next
                    CheckedListBox_Separate_Elements.Enabled = False
                    'For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                    '    CheckedListBox_Separate_Elements.SetItemChecked(i, False)
                    'Next
                    B_Select_All.Enabled = False
                End If

                If ComboBox_Determined_Elements.SelectedItem = "separate elements" Then 'отдельные элементы 
                    CheckedListBox_Group_Of_Elements.Enabled = False
                    'For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                    '    CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
                    'Next
                    CheckedListBox_Separate_Elements.Enabled = True
                    'For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                    '    CheckedListBox_Separate_Elements.SetItemChecked(i, False)
                    'Next
                    B_Select_All.Enabled = True
                End If

                If ComboBox_Determined_Elements.SelectedItem = "all elements" Then 'все элементы 
                    CheckedListBox_Group_Of_Elements.Enabled = False
                    'For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                    '    CheckedListBox_Group_Of_Elements.SetItemChecked(i, False)
                    'Next
                    CheckedListBox_Separate_Elements.Enabled = False
                    'For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                    '    CheckedListBox_Separate_Elements.SetItemChecked(i, True)
                    'Next
                    B_Select_All.Enabled = False
                End If
            End If

            If Form_Main.language = "Русский" Then
                If Form_Samples_List.sample_action = "new sample" Then
                    Me.Text = "Приём нового образца"
                ElseIf Form_Samples_List.sample_action = "existing sample" Then
                    Me.Text = "Редактирование существующего образца"
                End If

                Label_Name_Code.Text = "Страна-Клиент-Год-№ парт.-И. п."
                L_Name_Sample_ID.Text = "№ образца"

                L_Name_Client_Sample_ID.Text = "Клиентский № обр."
                L_Name_Sample_Type.Text = "Тип образца"
                L_Name_Latitude.Text = "Широта"
                L_Name_Longitude.Text = "Долгота"
                L_Name_Sample_Subtype.Text = "Подтип образца"
                L_Name_CollectionPlace.Text = "Место сбора"
                L_Name_Cupboard_Number.Text = "Шкаф"
                L_Name_Box_Number.Text = "Коробка"
                L_Name_ReceivedBy.Text = "Принят"
                L_Name_New_Sample_Accept_Notes.Text = "Примечания"

                L_Name_SamplePreparation.Text = "Пробоподготовка"
                CheckedListBox_Sample_Preparation.Items.Item(0) = "очистка"
                CheckedListBox_Sample_Preparation.Items.Item(1) = "сушка"
                CheckedListBox_Sample_Preparation.Items.Item(2) = "выпаривание"
                CheckedListBox_Sample_Preparation.Items.Item(3) = "вымораживание"
                CheckedListBox_Sample_Preparation.Items.Item(4) = "гомогенизация"
                CheckedListBox_Sample_Preparation.Items.Item(5) = "пеллетизация"
                CheckedListBox_Sample_Preparation.Items.Item(6) = "измельчение"
                L_Name_DeterminedElements.Text = "Определяемые элементы"
                B_Select_All.Text = "Выбрать все"
                L_Name_Group_Of_Elements.Text = "Группа элементов"
                CheckedListBox_Group_Of_Elements.Items.Item(0) = "галогены"
                CheckedListBox_Group_Of_Elements.Items.Item(1) = "тяжёлые металлы"
                CheckedListBox_Group_Of_Elements.Items.Item(2) = "короткоживущие"
                CheckedListBox_Group_Of_Elements.Items.Item(3) = "долгоживущие"

                L_Name_Separate_Elements.Text = "Отдельные элементы"

                Button_Save_Sample.Text = "Сохранить образец"
                B_Close.Text = "Закрыть"
                B_Fill_In_From_File.Text = "Заполнить из файла"

                OpenFileDialog_Fill_In_From_File.Filter = "Файлы с информацией об образцах (*.nas)|*.nas|Все файлы (*.*)|*.*"
            ElseIf Form_Main.language = "English" Then
                If Form_Samples_List.sample_action = "new sample" Then
                    Me.Text = "New sample acceptance"
                ElseIf Form_Samples_List.sample_action = "existing sample" Then
                    Me.Text = "Edit existing sample"
                End If
               
                Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
                L_Name_Sample_ID.Text = "Sample ID"

                L_Name_Client_Sample_ID.Text = "Client sample ID"
                L_Name_Sample_Type.Text = "Sample type"
                L_Name_Latitude.Text = "Latitude"
                L_Name_Longitude.Text = "Longitude"
                L_Name_Sample_Subtype.Text = "Sample subtype"
                L_Name_CollectionPlace.Text = "Collection place"
                L_Name_Cupboard_Number.Text = "Cupboard"
                L_Name_Box_Number.Text = "Box"
                L_Name_ReceivedBy.Text = "Received by"
                L_Name_New_Sample_Accept_Notes.Text = "Notes"

                L_Name_SamplePreparation.Text = "Sample preparation"
                CheckedListBox_Sample_Preparation.Items.Item(0) = "cleaning"
                CheckedListBox_Sample_Preparation.Items.Item(1) = "drying"
                CheckedListBox_Sample_Preparation.Items.Item(2) = "evaporation"
                CheckedListBox_Sample_Preparation.Items.Item(3) = "freeze(drying)"
                CheckedListBox_Sample_Preparation.Items.Item(4) = "homogenizing"
                CheckedListBox_Sample_Preparation.Items.Item(5) = "pelletization"
                CheckedListBox_Sample_Preparation.Items.Item(6) = "fragmentation"
                L_Name_DeterminedElements.Text = "Determined elements"
                B_Select_All.Text = "Select all"
                L_Name_Group_Of_Elements.Text = "Group of elements"
                CheckedListBox_Group_Of_Elements.Items.Item(0) = "halogens"
                CheckedListBox_Group_Of_Elements.Items.Item(1) = "heavy metals"
                CheckedListBox_Group_Of_Elements.Items.Item(2) = "short-lived"
                CheckedListBox_Group_Of_Elements.Items.Item(3) = "long-lived"

                L_Name_Separate_Elements.Text = "Separate elements"

                Button_Save_Sample.Text = "Save sample"
                B_Close.Text = "Close"
                B_Fill_In_From_File.Text = "Fill in from file"

                OpenFileDialog_Fill_In_From_File.Filter = "NAA samples info foles (*.nas)|*.nas|All files (*.*)|*.*"
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox($"Операция была отменена (ошибка в Form_NewSampleAccept_Load)!{vbCrLf}{ex.ToString}", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in Form_NewSampleAccept_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Form_Samples_List.Enabled = True
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub CheckedListBox_Group_Of_Elements_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox_Group_Of_Elements.SelectedValueChanged
        Try
            For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                CheckedListBox_Separate_Elements.SetItemChecked(i, False)
            Next
            If CheckedListBox_Group_Of_Elements.GetItemChecked(0) = True Then 'halogens
                CheckedListBox_Separate_Elements.SetItemChecked(6, True) 'Cl
                CheckedListBox_Separate_Elements.SetItemChecked(23, True) 'Br
                CheckedListBox_Separate_Elements.SetItemChecked(37, True) 'I
            End If

            If CheckedListBox_Group_Of_Elements.GetItemChecked(1) = True Then 'heavy metals
                CheckedListBox_Separate_Elements.SetItemChecked(11, True) 'V
                CheckedListBox_Separate_Elements.SetItemChecked(12, True) 'Cr
                CheckedListBox_Separate_Elements.SetItemChecked(13, True) 'Mn
                CheckedListBox_Separate_Elements.SetItemChecked(14, True) 'Fe
                CheckedListBox_Separate_Elements.SetItemChecked(15, True) 'Co
                CheckedListBox_Separate_Elements.SetItemChecked(16, True) 'Ni
                CheckedListBox_Separate_Elements.SetItemChecked(17, True) 'Cu
                CheckedListBox_Separate_Elements.SetItemChecked(18, True) 'Zn
                CheckedListBox_Separate_Elements.SetItemChecked(19, True) 'Ga
                CheckedListBox_Separate_Elements.SetItemChecked(20, True) 'Ge
                CheckedListBox_Separate_Elements.SetItemChecked(21, True) 'As
                CheckedListBox_Separate_Elements.SetItemChecked(22, True) 'Se
                CheckedListBox_Separate_Elements.SetItemChecked(24, True) 'Rb
                CheckedListBox_Separate_Elements.SetItemChecked(25, True) 'Sr
                CheckedListBox_Separate_Elements.SetItemChecked(26, True) 'Y
                CheckedListBox_Separate_Elements.SetItemChecked(27, True) 'Zr
                CheckedListBox_Separate_Elements.SetItemChecked(28, True) 'Nd
                CheckedListBox_Separate_Elements.SetItemChecked(29, True) 'Mo
                CheckedListBox_Separate_Elements.SetItemChecked(30, True) 'Ru
                CheckedListBox_Separate_Elements.SetItemChecked(31, True) 'Pd
                CheckedListBox_Separate_Elements.SetItemChecked(32, True) 'Ag
                CheckedListBox_Separate_Elements.SetItemChecked(33, True) 'Cd
                CheckedListBox_Separate_Elements.SetItemChecked(34, True) 'In
                CheckedListBox_Separate_Elements.SetItemChecked(35, True) 'Sn
                CheckedListBox_Separate_Elements.SetItemChecked(36, True) 'Sb
                CheckedListBox_Separate_Elements.SetItemChecked(38, True) 'Cs
                CheckedListBox_Separate_Elements.SetItemChecked(39, True) 'Ba
                CheckedListBox_Separate_Elements.SetItemChecked(40, True) 'La
                CheckedListBox_Separate_Elements.SetItemChecked(41, True) 'Ce
                CheckedListBox_Separate_Elements.SetItemChecked(42, True) 'Pr
                CheckedListBox_Separate_Elements.SetItemChecked(43, True) 'Nd
                CheckedListBox_Separate_Elements.SetItemChecked(44, True) 'Sm
                CheckedListBox_Separate_Elements.SetItemChecked(45, True) 'Eu
                CheckedListBox_Separate_Elements.SetItemChecked(46, True) 'Gd
                CheckedListBox_Separate_Elements.SetItemChecked(47, True) 'Tb
                CheckedListBox_Separate_Elements.SetItemChecked(48, True) 'Dy
                CheckedListBox_Separate_Elements.SetItemChecked(49, True) 'Ho
                CheckedListBox_Separate_Elements.SetItemChecked(50, True) 'Er
                CheckedListBox_Separate_Elements.SetItemChecked(51, True) 'Tm
                CheckedListBox_Separate_Elements.SetItemChecked(52, True) 'Yb
                CheckedListBox_Separate_Elements.SetItemChecked(53, True) 'Lu
                CheckedListBox_Separate_Elements.SetItemChecked(54, True) 'Hf
                CheckedListBox_Separate_Elements.SetItemChecked(55, True) 'Ta
                CheckedListBox_Separate_Elements.SetItemChecked(56, True) 'W
                CheckedListBox_Separate_Elements.SetItemChecked(58, True) 'Os
                CheckedListBox_Separate_Elements.SetItemChecked(59, True) 'Ir
                CheckedListBox_Separate_Elements.SetItemChecked(60, True) 'Pt
                CheckedListBox_Separate_Elements.SetItemChecked(61, True) 'Au
                CheckedListBox_Separate_Elements.SetItemChecked(62, True) 'Hg
                CheckedListBox_Separate_Elements.SetItemChecked(64, True) 'U
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
                CheckedListBox_Separate_Elements.SetItemChecked(17, True) 'Cu
                CheckedListBox_Separate_Elements.SetItemChecked(23, True) 'Br
                CheckedListBox_Separate_Elements.SetItemChecked(26, True) 'Y
                CheckedListBox_Separate_Elements.SetItemChecked(34, True) 'In
                CheckedListBox_Separate_Elements.SetItemChecked(35, True) 'Sn
                CheckedListBox_Separate_Elements.SetItemChecked(37, True) 'I
                CheckedListBox_Separate_Elements.SetItemChecked(39, True) 'Ba
                CheckedListBox_Separate_Elements.SetItemChecked(48, True) 'Dy
                CheckedListBox_Separate_Elements.SetItemChecked(50, True) 'Er
                CheckedListBox_Separate_Elements.SetItemChecked(64, True) 'U
            End If

            If CheckedListBox_Group_Of_Elements.GetItemChecked(3) = True Then 'long-lived
                CheckedListBox_Separate_Elements.SetItemChecked(1, True) 'Na
                CheckedListBox_Separate_Elements.SetItemChecked(7, True) 'K
                CheckedListBox_Separate_Elements.SetItemChecked(9, True) 'Sc
                CheckedListBox_Separate_Elements.SetItemChecked(12, True) 'Cr
                CheckedListBox_Separate_Elements.SetItemChecked(14, True) 'Fe
                CheckedListBox_Separate_Elements.SetItemChecked(15, True) 'Co
                CheckedListBox_Separate_Elements.SetItemChecked(16, True) 'Ni
                CheckedListBox_Separate_Elements.SetItemChecked(18, True) 'Zn
                CheckedListBox_Separate_Elements.SetItemChecked(19, True) 'Ga
                CheckedListBox_Separate_Elements.SetItemChecked(20, True) 'Ge
                CheckedListBox_Separate_Elements.SetItemChecked(21, True) 'As
                CheckedListBox_Separate_Elements.SetItemChecked(22, True) 'Se
                CheckedListBox_Separate_Elements.SetItemChecked(23, True) 'Br
                CheckedListBox_Separate_Elements.SetItemChecked(24, True) 'Rb
                CheckedListBox_Separate_Elements.SetItemChecked(25, True) 'Sr
                CheckedListBox_Separate_Elements.SetItemChecked(26, True) 'Y
                CheckedListBox_Separate_Elements.SetItemChecked(27, True) 'Zr
                CheckedListBox_Separate_Elements.SetItemChecked(28, True) 'Nb
                CheckedListBox_Separate_Elements.SetItemChecked(29, True) 'Mo
                CheckedListBox_Separate_Elements.SetItemChecked(30, True) 'Ru
                CheckedListBox_Separate_Elements.SetItemChecked(31, True) 'Pd
                CheckedListBox_Separate_Elements.SetItemChecked(32, True) 'Ag
                CheckedListBox_Separate_Elements.SetItemChecked(33, True) 'Cd
                CheckedListBox_Separate_Elements.SetItemChecked(35, True) 'Sn
                CheckedListBox_Separate_Elements.SetItemChecked(36, True) 'Sb
                CheckedListBox_Separate_Elements.SetItemChecked(38, True) 'Cs
                CheckedListBox_Separate_Elements.SetItemChecked(39, True) 'Ba
                CheckedListBox_Separate_Elements.SetItemChecked(40, True) 'La
                CheckedListBox_Separate_Elements.SetItemChecked(41, True) 'Ce
                CheckedListBox_Separate_Elements.SetItemChecked(42, True) 'Pr
                CheckedListBox_Separate_Elements.SetItemChecked(43, True) 'Nd
                CheckedListBox_Separate_Elements.SetItemChecked(44, True) 'Sm
                CheckedListBox_Separate_Elements.SetItemChecked(45, True) 'Eu
                CheckedListBox_Separate_Elements.SetItemChecked(46, True) 'Gd
                CheckedListBox_Separate_Elements.SetItemChecked(47, True) 'Tb
                CheckedListBox_Separate_Elements.SetItemChecked(49, True) 'Ho
                CheckedListBox_Separate_Elements.SetItemChecked(51, True) 'Tm
                CheckedListBox_Separate_Elements.SetItemChecked(52, True) 'Yb
                CheckedListBox_Separate_Elements.SetItemChecked(53, True) 'Lu
                CheckedListBox_Separate_Elements.SetItemChecked(54, True) 'Hf
                CheckedListBox_Separate_Elements.SetItemChecked(55, True) 'Ta
                CheckedListBox_Separate_Elements.SetItemChecked(56, True) 'W
                CheckedListBox_Separate_Elements.SetItemChecked(57, True) 'Re
                CheckedListBox_Separate_Elements.SetItemChecked(58, True) 'Os
                CheckedListBox_Separate_Elements.SetItemChecked(59, True) 'Ir
                CheckedListBox_Separate_Elements.SetItemChecked(60, True) 'Pt
                CheckedListBox_Separate_Elements.SetItemChecked(61, True) 'Au
                CheckedListBox_Separate_Elements.SetItemChecked(62, True) 'Hg
                CheckedListBox_Separate_Elements.SetItemChecked(63, True) 'Th
                CheckedListBox_Separate_Elements.SetItemChecked(64, True) 'U
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в CheckedListBox_Group_Of_Elements_SelectedValueChanged)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in CheckedListBox_Group_Of_Elements_SelectedValueChanged)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public Sub Button_Save_Sample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save_Sample.Click

        Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
        Dim reader As SqlDataReader
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text

        Dim Sample_Preparation_Plan_SQL_Part_Of_String As String
        Sample_Preparation_Plan_SQL_Part_Of_String = ""
        Dim Group_Of_Elements_Plan_SQL_Part_Of_String As String
        Group_Of_Elements_Plan_SQL_Part_Of_String = ""
        Dim Elements_Plan_SQL_Part_Of_String As String
        Elements_Plan_SQL_Part_Of_String = ""

        If Form_Samples_List.sample_action = "new sample" Then
            Try
                cmd.CommandText = "SELECT COUNT (*) FROM dbo.table_Sample WHERE F_Country_Code='" + L_SS_Country_Code.Text + "' and F_Client_ID='" + L_SS_Client_ID.Text +
                     "' and F_Year='" + L_SS_Year.Text + "' and F_Sample_Set_ID='" + L_SS_Sample_Set_ID.Text +
                     "' and F_Sample_Set_Index='" + L_SS_Sample_Set_Index.Text +
                     "' and A_Sample_ID='" + L_Sample_ID.Text + "'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    If reader(0) > 0 Then
                        If Form_Main.language = "Русский" Then
                            MsgBox("Образец с таким номером уже существует", MsgBoxStyle.Exclamation, Me.Text)
                        ElseIf Form_Main.language = "English" Then
                            MsgBox("This sample ID already exist!", MsgBoxStyle.Exclamation, Me.Text)
                        End If
                        sqlConnection1.Close()
                        Exit Sub
                    End If
                End While
                sqlConnection1.Close()

                'Dim Sample_Preparation_Plan_Array As New BitArray(6, 0)
                For i = 0 To CheckedListBox_Sample_Preparation.Items.Count - 1
                    If CheckedListBox_Sample_Preparation.GetItemChecked(i) = True Then
                        Sample_Preparation_Plan_SQL_Part_Of_String = Sample_Preparation_Plan_SQL_Part_Of_String + "'1', "
                    Else
                        Sample_Preparation_Plan_SQL_Part_Of_String = Sample_Preparation_Plan_SQL_Part_Of_String + "'0', "
                    End If
                Next

                For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                    If CheckedListBox_Group_Of_Elements.GetItemChecked(i) = True Then
                        Group_Of_Elements_Plan_SQL_Part_Of_String = Group_Of_Elements_Plan_SQL_Part_Of_String + "'1', "
                    Else
                        Group_Of_Elements_Plan_SQL_Part_Of_String = Group_Of_Elements_Plan_SQL_Part_Of_String + "'0', "
                    End If
                Next

                'Dim Element_Plan_Array As New BitArray(56, 0)
                For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                    If CheckedListBox_Separate_Elements.GetItemChecked(i) = True Then
                        Elements_Plan_SQL_Part_Of_String = Elements_Plan_SQL_Part_Of_String + "'1', "
                    Else
                        Elements_Plan_SQL_Part_Of_String = Elements_Plan_SQL_Part_Of_String + "'0', "
                    End If
                Next

                cmd.CommandText = "INSERT dbo.table_Sample (F_Country_Code, F_Client_ID, F_Year, F_Sample_Set_ID, F_Sample_Set_Index, A_Sample_ID, A_Client_Sample_ID, A_Sample_Type, A_Sample_Subtype, A_Collection_Place, A_Latitude, A_Longitude, A_Cleaning_Plan, A_Drying_Plan, A_Evaporation_Plan, A_Freeze_Drying_Plan, A_Homogenizing_Plan, A_Pelletization_Plan, A_Fragmentation_Plan, A_Determined_Elements, A_Halogens_Plan, A_Heavy_Metals_Plan, A_Short_Lived_Plan, A_Long_Lived_Plan, A_F_Plan, A_Na_Plan, A_Mg_Plan, A_Al_Plan, A_Si_Plan, A_S_Plan, A_Cl_Plan, A_K_Plan, A_Ca_Plan, A_Sc_Plan, A_Ti_Plan, A_V_Plan, A_Cr_Plan, A_Mn_Plan, A_Fe_Plan, A_Co_Plan, A_Ni_Plan, A_Cu_Plan, A_Zn_Plan, A_Ga_Plan, A_Ge_Plan, A_As_Plan, A_Se_Plan, A_Br_Plan, A_Rb_Plan, A_Sr_Plan, A_Y_Plan, A_Zr_Plan, A_Nb_Plan, A_Mo_Plan, A_Ru_Plan, A_Pd_Plan, A_Ag_Plan, A_Cd_Plan, A_In_Plan, A_Sn_Plan, A_Sb_Plan, A_I_Plan, A_Cs_Plan, A_Ba_Plan, A_La_Plan, A_Ce_Plan, A_Pr_Plan, A_Nd_Plan, A_Sm_Plan, A_Eu_Plan, A_Gd_Plan, A_Tb_Plan, A_Dy_Plan, A_Ho_Plan, A_Er_Plan, A_Tm_Plan, A_Yb_Plan, A_Lu_Plan, A_Hf_Plan, A_Ta_Plan, A_W_Plan, A_Re_Plan, A_Os_Plan, A_Ir_Plan, A_Pt_Plan, A_Au_Plan, A_Hg_Plan, A_Th_Plan, A_U_Plan, A_Cupboard_Number, A_Box_Number, A_Received_By, A_Notes) " +
                     "VALUES ('" + L_SS_Country_Code.Text + "', '" + L_SS_Client_ID.Text + "', '" + L_SS_Year.Text + "', '" +
                     L_SS_Sample_Set_ID.Text + "', '" + L_SS_Sample_Set_Index.Text + "', '" +
                     L_Sample_ID.Text + "', '" + TextBox_Client_Sample_ID.Text + "', '" +
                     ComboBox_Sample_Type.Text + "', '" + ComboBox_Sample_Subtype.Text + "', '" +
                     TextBox_Collection_Place.Text + "', '" + MaskedTextBox_Latitude.Text + "', '" +
                     MaskedTextBox_Longitude.Text + "', " + Sample_Preparation_Plan_SQL_Part_Of_String + "'" + ComboBox_Determined_Elements.Text + "', " +
                     Group_Of_Elements_Plan_SQL_Part_Of_String + Elements_Plan_SQL_Part_Of_String + "'" +
                     ComboBox_Cupboard_Number.Text + "', '" + ComboBox_Box_Number.Text + "', '" + ComboBox_Table_ReceivedBy.Text + "', '" +
                     TextBox_New_Sample_Accept_Notes.Text + "')"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.ExecuteNonQuery()
                sqlConnection1.Close()


                cmd.CommandText = $"update dbo.table_Sample_Set set PrepCompl=0, SLICompl=0, LLICompl=0, ResCompl=0 WHERE Country_Code='{L_SS_Country_Code.Text}' and Client_ID='{L_SS_Client_ID.Text}' and Year='{L_SS_Year.Text}' and Sample_Set_ID='{L_SS_Sample_Set_ID.Text}' and Sample_Set_Index='{L_SS_Sample_Set_Index.Text}'"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.ExecuteNonQuery()
                sqlConnection1.Close()


                Form_Main.B_Select_Sample_Set_Click(sender, e)

                Form_Samples_List.ListBox_Sample_ID.SelectedIndex = Form_Samples_List.ListBox_Sample_ID.Items.Count - 1
                Me.Close()

            Catch ex As Exception
                If Form_Main.language = "Русский" Then
                    MsgBox("Операция была отменена (ошибка в Button_Save_Sample_Click, new sample)!", MsgBoxStyle.Critical, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("The operation was cancelled (error in Button_Save_Sample_Click, new sample)!", MsgBoxStyle.Critical, Me.Text)
                End If
                Me.Close()
                Exit Sub
            End Try
        End If
        If Form_Samples_List.sample_action = "existing sample" Then
            Try
                'For i = 0 To CheckedListBox_Sample_Preparation.Items.Count - 1
                '    If CheckedListBox_Sample_Preparation.GetItemChecked(i) = True Then
                '        Sample_Preparation_Plan_SQL_Part_Of_String = Sample_Preparation_Plan_SQL_Part_Of_String + CheckedListBox_Sample_Preparation.Items.Item(i) + "='1', "
                '    Else
                '        Sample_Preparation_Plan_SQL_Part_Of_String = Sample_Preparation_Plan_SQL_Part_Of_String + CheckedListBox_Sample_Preparation.Items.Item(i) + "='0', "
                '    End If
                'Next

                For i = 0 To Separate_Elements.Count - 1
                    Elements_Plan_SQL_Part_Of_String = Elements_Plan_SQL_Part_Of_String + Separate_Elements(i) + "='" + BooleanToStringBit(CheckedListBox_Separate_Elements.GetItemChecked(i)).ToString + "', "
                Next
                cmd.CommandText = "UPDATE dbo.table_Sample SET A_Client_Sample_ID='" + TextBox_Client_Sample_ID.Text +
                "', A_Sample_Type='" + ComboBox_Sample_Type.Text + "', A_Sample_Subtype='" + ComboBox_Sample_Subtype.Text +
                "', A_Collection_Place='" + TextBox_Collection_Place.Text +
                "', A_Latitude='" + MaskedTextBox_Latitude.Text + "', A_Longitude='" + MaskedTextBox_Longitude.Text +
                "', A_Cleaning_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(0)) +
                "', A_Drying_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(1)) +
                "', A_Evaporation_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(2)) +
                "', A_Freeze_Drying_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(3)) +
                "', A_Homogenizing_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(4)) +
                "', A_Pelletization_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(5)) +
                "', A_Fragmentation_Plan='" + BooleanToStringBit(CheckedListBox_Sample_Preparation.GetItemChecked(6)) +
                "', A_Determined_Elements='" + ComboBox_Determined_Elements.Text +
                "', A_Halogens_Plan='" + BooleanToStringBit(CheckedListBox_Group_Of_Elements.GetItemChecked(0)) +
                "', A_Heavy_Metals_Plan='" + BooleanToStringBit(CheckedListBox_Group_Of_Elements.GetItemChecked(1)) +
                "', A_Short_Lived_Plan='" + BooleanToStringBit(CheckedListBox_Group_Of_Elements.GetItemChecked(2)) +
                "', A_Long_Lived_Plan='" + BooleanToStringBit(CheckedListBox_Group_Of_Elements.GetItemChecked(3)) +
                "', " + Elements_Plan_SQL_Part_Of_String +
                "A_Cupboard_Number='" + ComboBox_Cupboard_Number.Text +
                "', A_Box_Number='" + ComboBox_Box_Number.Text +
                "', A_Received_By='" + ComboBox_Table_ReceivedBy.Text +
                "', A_Notes='" + TextBox_New_Sample_Accept_Notes.Text + "' WHERE F_Country_Code='" +
                    Form_Main.DataGridView_Sample_Set.SelectedCells.Item(0).Value +
                    "' and F_Client_ID='" + Form_Main.DataGridView_Sample_Set.SelectedCells.Item(1).Value +
                    "' and F_Year='" + Form_Main.DataGridView_Sample_Set.SelectedCells.Item(2).Value +
                    "' and F_Sample_Set_ID='" + Form_Main.DataGridView_Sample_Set.SelectedCells.Item(3).Value +
                    "' and A_Sample_ID='" + Form_Samples_List.ListBox_Sample_ID.Text + "'"

                '", Na_Plan, Mg_Plan, Al_Plan, Si_Plan, S_Plan, Cl_Plan, K_Plan, Ca_Plan, Sc_Plan, Ti_Plan, V_Plan, Cr_Plan, Mn_Plan, Fe_Plan, Co_Plan, Cu_Plan, Zn_Plan, Ga_Plan, As_Plan, Se_Plan, Br_Plan, Rb_Plan, Sr_Plan, Y_Plan, Zr_Plan, Nb_Plan, Mo_Plan, Ru_Plan, Ag_Plan, Cd_Plan, In_Plan, Sn_Plan, Sb_Plan, I_Plan, Cs_Plan, Ba_Plan, La_Plan, Ce_Plan, Nd_Plan, Sm_Plan, Eu_Plan, Gd_Plan, Tb_Plan, Dy_Plan, Er_Plan, Tm_Plan, Yb_Plan, Lu_Plan, Hf_Plan, Ta_Plan, W_Plan, Re_Plan, Ir_Plan, Pt_Plan, Au_Plan, Hg_Plan, Th_Plan, U_Plan, Cupboard_Number, Box_Number, Received_By, New_Sample_Accept_Notes WHERE Country_Code='"
                'Form_Main.Table_Sample_SetDataGridView.SelectedCells.Item(0).Value +
                '"' and Client_ID='" + Form_Main.Table_Sample_SetDataGridView.SelectedCells.Item(1).Value +
                '"' and Year='" + Form_Main.Table_Sample_SetDataGridView.SelectedCells.Item(2).Value +
                '"' and Sample_Set_ID='" + Form_Main.Table_Sample_SetDataGridView.SelectedCells.Item(3).Value +
                '"' and Sample_ID='" + Form_Sample.MaskedTextBox_New_Sample_ID.Text + "'"
                '            +
                'ComboBox_Sample_Type.Text + "', '" + TextBox_Collection_Place.Text + "', '" + TextBox_Latitude.Text + "', '" +
                'TextBox_Longitude.Text + "', " + Sample_Preparation_Plan_SQL_Part_Of_String + "'" + ComboBox_Determined_Elements.Text + "', " +
                'Group_Of_Elements_Plan_SQL_Part_Of_String + Element_Plan_SQL_Part_Of_String + "'" +
                'ComboBox_Cupboard_Number.Text + "', '" + ComboBox_Box_Number.Text + "', '" + ComboBox_Table_ReceivedBy.Text + "', '" +
                'TextBox_New_Sample_Accept_Notes.Text + "')")
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.ExecuteNonQuery()
                sqlConnection1.Close()
                Me.Close()
            Catch ex As Exception
                If Form_Main.language = "Русский" Then
                    MsgBox("Операция была отменена (ошибка в Button_Save_Sample_Click, existing sample)!", MsgBoxStyle.Critical, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("The operation was cancelled (error in Button_Save_Sample_Click, existing sample)!", MsgBoxStyle.Critical, Me.Text)
                End If
                Exit Sub
            End Try
        End If
    End Sub

    Function BooleanToStringBit(ByVal BooleanVar As Boolean) As String
        BooleanToStringBit = "0"
        Try
            If BooleanVar = True Then BooleanToStringBit = "1"
            If BooleanVar = False Then BooleanToStringBit = "0"
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в BooleanToStringBit)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in BooleanToStringBit)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Function
        End Try
    End Function

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub Form_New_Sample_Accept_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Samples_List.Enabled = True
    End Sub

    Private Sub B_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_All.Click
        Try
            For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                CheckedListBox_Separate_Elements.SetItemChecked(i, True)
            Next
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Select_All_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Select_All_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public Sub B_Fill_In_From_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Fill_In_From_File.Click
        Try
            If TextBox_Client_Sample_ID.Text = "" Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Введите клиентский номер образца!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Type client sample ID!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            Dim array_length_NAS As Integer
            Dim Samples_Info(,) As String
            'Dim Samples_Weights(,) As Single
            Dim row_count As Integer

            'If Form_Samples_List.sample_action = "all samples" Then
            '    GoTo d
            'End If
            ''OpenDialog_Aktivn_Stand_Obr.FileName:="" не разкомментировать, иначе будут ошибки!
            If OpenFileDialog_Fill_In_From_File.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Form_Main.language = "Русский" Then
                    MsgBox("Выберите файл!", MsgBoxStyle.Exclamation, Me.Text)
                ElseIf Form_Main.language = "English" Then
                    MsgBox("Select file!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                'd:
                array_length_NAS = 0
                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Fill_In_From_File.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(vbTab)
                    Dim currentRow As String
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If (currentRow = "0") Or (currentRow = "1") Then
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ")
                            End While
                            If currentRow = "№	Sample ID	Sample type	Sample subtype	Latitude	Longitude	Collection place	Determined elements	Halogens	Heavy metals	Short-lived	Long-lived	F	Na	Mg	Al	Si	S	Cl	K	Ca	Sc	Ti	V	Cr	Mn	Fe	Co	Ni	Cu	Zn	Ga	Ge	As	Se	Br	Rb	Sr	Y	Zr	Nb	Mo	Ru	Pd	Ag	Cd	In	Sn	Sb	I	Cs	Ba	La	Ce	Pr	Nd	Sm	Eu	Gd	Tb	Dy	Ho	Er	Tm	Yb	Lu	Hf	Ta	W	Re	Os	Ir	Pt	Au	Hg	Th	U	Notes" Or currentRow = "№	Номер образца	Тип образца	Подтип образца	Широта	Долгота	Место сбора	Определяемые элементы	Галогены	Тяжёлые металлы	Короткоживущие	Долгоживущие	F	Na	Mg	Al	Si	S	Cl	K	Ca	Sc	Ti	V	Cr	Mn	Fe	Co	Ni	Cu	Zn	Ga	Ge	As	Se	Br	Rb	Sr	Y	Zr	Nb	Mo	Ru	Pd	Ag	Cd	In	Sn	Sb	I	Cs	Ba	La	Ce	Pr	Nd	Sm	Eu	Gd	Tb	Dy	Ho	Er	Tm	Yb	Lu	Hf	Ta	W	Re	Os	Ir	Pt	Au	Hg	Th	U	Примечания" Then
                                'currentRow = MyReader.ReadLine
                                'currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                'While InStr(currentRow, "--") > 0
                                '    currentRow = Replace(currentRow, "--", "-")
                                'End While
                                'If currentRow = "-" Then
                                'MessageBox.Show("Похоже, правильный формат файла активностей исследуемого образца!")
                                currentRow = MyReader.ReadLine
a:                              array_length_NAS = array_length_NAS + 1
                                currentRow = MyReader.ReadLine
                                If currentRow <> "" Then GoTo a
                                'End If
                            End If
                        End If
                    End While
                End Using

                If array_length_NAS = 0 Then
                    If Form_Main.language = "Русский" Then
                        MsgBox("Неправильный формат файла!", MsgBoxStyle.Exclamation, Me.Text)
                    ElseIf Form_Main.language = "English" Then
                        MsgBox("Incorrect file format!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If

                ReDim Samples_Info(array_length_NAS, 77)
                'ReDim Samples_Weights(array_length_VES, 2)

                Using MyReader As New FileIO.TextFieldParser(OpenFileDialog_Fill_In_From_File.FileName, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(vbTab)
                    Dim currentRow As String
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If (currentRow = "0") Or (currentRow = "1") Then
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ")
                            End While
                            If currentRow = "№	Sample ID	Sample type	Sample subtype	Latitude	Longitude	Collection place	Determined elements	Halogens	Heavy metals	Short-lived	Long-lived	F	Na	Mg	Al	Si	S	Cl	K	Ca	Sc	Ti	V	Cr	Mn	Fe	Co	Ni	Cu	Zn	Ga	Ge	As	Se	Br	Rb	Sr	Y	Zr	Nb	Mo	Ru	Pd	Ag	Cd	In	Sn	Sb	I	Cs	Ba	La	Ce	Pr	Nd	Sm	Eu	Gd	Tb	Dy	Ho	Er	Tm	Yb	Lu	Hf	Ta	W	Re	Os	Ir	Pt	Au	Hg	Th	U	Notes" Or currentRow = "№	Номер образца	Тип образца	Подтип образца	Широта	Долгота	Место сбора	Определяемые элементы	Галогены	Тяжёлые металлы	Короткоживущие	Долгоживущие	F	Na	Mg	Al	Si	S	Cl	K	Ca	Sc	Ti	V	Cr	Mn	Fe	Co	Ni	Cu	Zn	Ga	Ge	As	Se	Br	Rb	Sr	Y	Zr	Nb	Mo	Ru	Pd	Ag	Cd	In	Sn	Sb	I	Cs	Ba	La	Ce	Pr	Nd	Sm	Eu	Gd	Tb	Dy	Ho	Er	Tm	Yb	Lu	Hf	Ta	W	Re	Os	Ir	Pt	Au	Hg	Th	U	Примечания" Then

                                '                                currentRow = MyReader.ReadLine
                                '                                currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                '                                While InStr(currentRow, "--") > 0
                                '                                    currentRow = Replace(currentRow, "--", "-")
                                '                                End While
                                '                                If currentRow = "-" Then
                                '                                    'MessageBox.Show("Похоже, правильный формат файла активностей исследуемого образца!")

                                row_count = 0
                                currentRow = MyReader.ReadLine
b:                              currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                'While InStr(currentRow, vbTab + vbTab) > 0
                                '    currentRow = Replace(currentRow, vbTab + vbTab, vbTab) ' заменяем все двойные пробелы одинарными
                                'End While
                                If currentRow(currentRow.Count - 1) <> vbTab Then currentRow = currentRow + vbTab 'добавляем пробел в конец строки
                                Dim i As Integer
                                i = 0
c:                              Samples_Info(row_count, i) = Mid(currentRow, 1, InStr(1, currentRow, vbTab) - 1) ' первое слово до пробела
                                currentRow = Replace(currentRow, Samples_Info(row_count, i) + vbTab, "", , 1, )
                                i = i + 1
                                If currentRow <> "" Then GoTo c
                                'Samples_Info(row_count, 1) = Mid(currentRow, 1, InStr(1, currentRow, vbTab) - 1) 'имя образца - первое слово до пробела
                                'currentRow = Replace(currentRow, Samples_Info(row_count, 1) + vbTab, "", , 1, )
                                '                                    Samples_Weights(row_count, 0) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))
                                '                                    currentRow = Replace(currentRow, Mid(currentRow, 1, InStr(1, currentRow, " ") - 1) + " ", "")
                                '                                    Samples_Weights(row_count, 1) = CDbl(Replace(Mid(currentRow, 1, InStr(1, currentRow, " ") - 1), ".", ","))

                                row_count = row_count + 1
                                currentRow = MyReader.ReadLine
                                If currentRow <> "" Then GoTo b

                                'End If
                                'MsgBox(Samples_Info(row_count - 1, 71))
                            End If
                        End If
                    End While
                End Using

                'ComboBox_Sample_Type.Text = ""
                'ComboBox_Sample_Subtype.Text = ""
                'ComboBox_Sample_Subtype.Visible = False
                'L_Name_Sample_Subtype.Visible = False
                'MaskedTextBox_Latitude.Text = ""
                'MaskedTextBox_Longitude.Text = ""
                'TextBox_Collection_Place.Text = ""
                'ComboBox_Determined_Elements.Text = ""
                'For i = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                '    CheckedListBox_Group_Of_Elements.SetItemCheckState(i, False)
                'Next
                'For i = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                '    CheckedListBox_Separate_Elements.SetItemCheckState(i, False)
                'Next
                'TextBox_New_Sample_Accept_Notes.Text = ""
                'B_Select_All.Enabled = False
                'CheckedListBox_Group_Of_Elements.Enabled = False

                ComboBox_Sample_Subtype.Visible = False
                L_Name_Sample_Subtype.Visible = False

                For i = 0 To array_length_NAS - 1
                    If Samples_Info(i, 2) = "почвы" Then Samples_Info(i, 2) = "soils"
                    If Samples_Info(i, 2) = "донные отложения" Then Samples_Info(i, 2) = "sediments"
                    If Samples_Info(i, 2) = "горные породы" Then Samples_Info(i, 2) = "rocks"
                    If Samples_Info(i, 2) = "продукты" Then Samples_Info(i, 2) = "foodstuffs"
                    If Samples_Info(i, 2) = "растительность" Then Samples_Info(i, 2) = "vegetation"
                    If Samples_Info(i, 2) = "биосубстраты" Then Samples_Info(i, 2) = "biomedical materials"
                    If Samples_Info(i, 2) = "технологический" Then Samples_Info(i, 2) = "technological"
                    If Samples_Info(i, 2) = "фильтры" Then Samples_Info(i, 2) = "filters"
                    If Samples_Info(i, 2) = "жидкий" Then Samples_Info(i, 2) = "luquids"
                    If Samples_Info(i, 2) = "другие" Then Samples_Info(i, 2) = "others"

                    If Samples_Info(i, 3) = "мох" Then Samples_Info(i, 3) = "moss"
                    If Samples_Info(i, 3) = "листья" Then Samples_Info(i, 3) = "leaves"
                    If Samples_Info(i, 3) = "кора" Then Samples_Info(i, 3) = "tree-bark"
                    If Samples_Info(i, 3) = "лишайники" Then Samples_Info(i, 3) = "lichens"
                    If Samples_Info(i, 3) = "другая растительность" Then Samples_Info(i, 3) = "others vegetation"

                    If Samples_Info(i, 3) = "волосы" Then Samples_Info(i, 3) = "hairs"
                    If Samples_Info(i, 3) = "ногти" Then Samples_Info(i, 3) = "nails"
                    If Samples_Info(i, 3) = "кровь" Then Samples_Info(i, 3) = "blood"
                    If Samples_Info(i, 3) = "моча" Then Samples_Info(i, 3) = "urine"
                    If Samples_Info(i, 3) = "ткани" Then Samples_Info(i, 3) = "tissues"
                    If Samples_Info(i, 3) = "зубы" Then Samples_Info(i, 3) = "teeth"
                    If Samples_Info(i, 3) = "другие биосубстраты" Then Samples_Info(i, 3) = "others biomedical materials"

                    If Samples_Info(i, 7) = "группа элементов" Then Samples_Info(i, 7) = "group of elements"
                    If Samples_Info(i, 7) = "отдельные элементы" Then Samples_Info(i, 7) = "separate elements"
                    If Samples_Info(i, 7) = "все элементы" Then Samples_Info(i, 7) = "all elements"
                Next

                For i = 0 To array_length_NAS - 1
                    If TextBox_Client_Sample_ID.Text = Samples_Info(i, 1) Then
                        For i1 = 0 To ComboBox_Sample_Type.Items.Count - 1
                            If ComboBox_Sample_Type.Items(i1) = Samples_Info(i, 2) Then
                                ComboBox_Sample_Type.SelectedItem = ComboBox_Sample_Type.Items(i1)
                                ComboBox_Sample_Type_SelectionChangeCommitted(sender, e)
                            End If
                        Next
                        If ComboBox_Sample_Subtype.Visible = True Then
                            For i1 = 0 To ComboBox_Sample_Subtype.Items.Count - 1
                                If ComboBox_Sample_Subtype.Items(i1) = Samples_Info(i, 3) Then
                                    ComboBox_Sample_Subtype.SelectedItem = ComboBox_Sample_Subtype.Items(i1)
                                End If
                            Next
                        End If
                        MaskedTextBox_Latitude.Text = Samples_Info(i, 4)
                        MaskedTextBox_Longitude.Text = Samples_Info(i, 5)
                        TextBox_Collection_Place.Text = Samples_Info(i, 6)
                        For i1 = 0 To ComboBox_Determined_Elements.Items.Count - 1
                            If ComboBox_Determined_Elements.Items(i1) = Samples_Info(i, 7) Then
                                ComboBox_Determined_Elements.SelectedItem = ComboBox_Determined_Elements.Items(i1)
                                ComboBox_Determined_Elements_SelectionChangeCommitted(sender, e)
                            End If
                        Next
                        For j = 0 To CheckedListBox_Group_Of_Elements.Items.Count - 1
                            If Samples_Info(i, j + 8) = "1" Then CheckedListBox_Group_Of_Elements.SetItemChecked(j, True)
                            If Samples_Info(i, j + 8) = "0" Then CheckedListBox_Group_Of_Elements.SetItemChecked(j, False)
                        Next
                        For j = 0 To CheckedListBox_Separate_Elements.Items.Count - 1
                            If Samples_Info(i, j + 12) = "1" Then CheckedListBox_Separate_Elements.SetItemChecked(j, True)
                            If Samples_Info(i, j + 12) = "0" Then CheckedListBox_Separate_Elements.SetItemChecked(j, False)
                        Next
                        TextBox_New_Sample_Accept_Notes.Text = Samples_Info(i, 77)
                    End If
                Next
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Fill_In_From_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Fill_In_From_File_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public Sub ComboBox_Sample_Type_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Sample_Type.SelectionChangeCommitted
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
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в ComboBox_Sample_Type_SelectionChangeCommitted)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in ComboBox_Sample_Type_SelectionChangeCommitted)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class