<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Sample_Accept
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
        Me.CheckedListBox_Sample_Preparation = New System.Windows.Forms.CheckedListBox()
        Me.L_Name_SamplePreparation = New System.Windows.Forms.Label()
        Me.L_Name_DeterminedElements = New System.Windows.Forms.Label()
        Me.TextBox_Collection_Place = New System.Windows.Forms.TextBox()
        Me.L_Name_CollectionPlace = New System.Windows.Forms.Label()
        Me.CheckedListBox_Group_Of_Elements = New System.Windows.Forms.CheckedListBox()
        Me.L_Name_Sample_ID = New System.Windows.Forms.Label()
        Me.TextBox_Client_Sample_ID = New System.Windows.Forms.TextBox()
        Me.L_Name_Client_Sample_ID = New System.Windows.Forms.Label()
        Me.L_Name_Sample_Type = New System.Windows.Forms.Label()
        Me.L_Name_Latitude = New System.Windows.Forms.Label()
        Me.L_Name_Longitude = New System.Windows.Forms.Label()
        Me.CheckedListBox_Separate_Elements = New System.Windows.Forms.CheckedListBox()
        Me.L_Name_Separate_Elements = New System.Windows.Forms.Label()
        Me.ComboBox_Determined_Elements = New System.Windows.Forms.ComboBox()
        Me.L_Name_Group_Of_Elements = New System.Windows.Forms.Label()
        Me.ComboBox_Table_ReceivedBy = New System.Windows.Forms.ComboBox()
        Me.Table_Received_By_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.L_Name_ReceivedBy = New System.Windows.Forms.Label()
        Me.Table_Received_ByTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter()
        Me.ComboBox_Cupboard_Number = New System.Windows.Forms.ComboBox()
        Me.L_Name_Cupboard_Number = New System.Windows.Forms.Label()
        Me.ComboBox_Box_Number = New System.Windows.Forms.ComboBox()
        Me.L_Name_Box_Number = New System.Windows.Forms.Label()
        Me.ComboBox_Sample_Type = New System.Windows.Forms.ComboBox()
        Me.L_Name_New_Sample_Accept_Notes = New System.Windows.Forms.Label()
        Me.TextBox_New_Sample_Accept_Notes = New System.Windows.Forms.TextBox()
        Me.Button_Save_Sample = New System.Windows.Forms.Button()
        Me.Label_Name_Code = New System.Windows.Forms.Label()
        Me.L_SS_Sample_Set_ID = New System.Windows.Forms.Label()
        Me.L_SS_Client_ID = New System.Windows.Forms.Label()
        Me.L_SS_Year = New System.Windows.Forms.Label()
        Me.L_SS_Country_Code = New System.Windows.Forms.Label()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.L_Sample_ID = New System.Windows.Forms.Label()
        Me.L_SS_Sample_Set_Index = New System.Windows.Forms.Label()
        Me.B_Select_All = New System.Windows.Forms.Button()
        Me.B_Fill_In_From_File = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Fill_In_From_File = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox_Sample_Subtype = New System.Windows.Forms.ComboBox()
        Me.L_Name_Sample_Subtype = New System.Windows.Forms.Label()
        Me.MaskedTextBox_Latitude = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_Longitude = New System.Windows.Forms.MaskedTextBox()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBox_Sample_Preparation
        '
        Me.CheckedListBox_Sample_Preparation.FormattingEnabled = True
        Me.CheckedListBox_Sample_Preparation.Items.AddRange(New Object() {"cleaning", "drying", "evaporation", "freeze drying", "homogenizing", "pelletization", "fragmentation"})
        Me.CheckedListBox_Sample_Preparation.Location = New System.Drawing.Point(278, 62)
        Me.CheckedListBox_Sample_Preparation.Name = "CheckedListBox_Sample_Preparation"
        Me.CheckedListBox_Sample_Preparation.Size = New System.Drawing.Size(115, 109)
        Me.CheckedListBox_Sample_Preparation.TabIndex = 85
        '
        'L_Name_SamplePreparation
        '
        Me.L_Name_SamplePreparation.AutoSize = True
        Me.L_Name_SamplePreparation.Location = New System.Drawing.Point(276, 46)
        Me.L_Name_SamplePreparation.Name = "L_Name_SamplePreparation"
        Me.L_Name_SamplePreparation.Size = New System.Drawing.Size(98, 13)
        Me.L_Name_SamplePreparation.TabIndex = 84
        Me.L_Name_SamplePreparation.Text = "Sample preparation"
        '
        'L_Name_DeterminedElements
        '
        Me.L_Name_DeterminedElements.AutoSize = True
        Me.L_Name_DeterminedElements.Location = New System.Drawing.Point(396, 45)
        Me.L_Name_DeterminedElements.Name = "L_Name_DeterminedElements"
        Me.L_Name_DeterminedElements.Size = New System.Drawing.Size(106, 13)
        Me.L_Name_DeterminedElements.TabIndex = 86
        Me.L_Name_DeterminedElements.Text = "Determined elements"
        '
        'TextBox_Collection_Place
        '
        Me.TextBox_Collection_Place.Location = New System.Drawing.Point(6, 144)
        Me.TextBox_Collection_Place.Name = "TextBox_Collection_Place"
        Me.TextBox_Collection_Place.Size = New System.Drawing.Size(266, 20)
        Me.TextBox_Collection_Place.TabIndex = 88
        '
        'L_Name_CollectionPlace
        '
        Me.L_Name_CollectionPlace.AutoSize = True
        Me.L_Name_CollectionPlace.Location = New System.Drawing.Point(100, 128)
        Me.L_Name_CollectionPlace.Name = "L_Name_CollectionPlace"
        Me.L_Name_CollectionPlace.Size = New System.Drawing.Size(82, 13)
        Me.L_Name_CollectionPlace.TabIndex = 89
        Me.L_Name_CollectionPlace.Text = "Collection place"
        '
        'CheckedListBox_Group_Of_Elements
        '
        Me.CheckedListBox_Group_Of_Elements.FormattingEnabled = True
        Me.CheckedListBox_Group_Of_Elements.Items.AddRange(New Object() {"halogens", "heavy metals", "short-lived", "long-lived"})
        Me.CheckedListBox_Group_Of_Elements.Location = New System.Drawing.Point(400, 131)
        Me.CheckedListBox_Group_Of_Elements.Name = "CheckedListBox_Group_Of_Elements"
        Me.CheckedListBox_Group_Of_Elements.Size = New System.Drawing.Size(119, 64)
        Me.CheckedListBox_Group_Of_Elements.TabIndex = 90
        '
        'L_Name_Sample_ID
        '
        Me.L_Name_Sample_ID.AutoSize = True
        Me.L_Name_Sample_ID.Location = New System.Drawing.Point(463, 9)
        Me.L_Name_Sample_ID.Name = "L_Name_Sample_ID"
        Me.L_Name_Sample_ID.Size = New System.Drawing.Size(56, 13)
        Me.L_Name_Sample_ID.TabIndex = 92
        Me.L_Name_Sample_ID.Text = "Sample ID"
        '
        'TextBox_Client_Sample_ID
        '
        Me.TextBox_Client_Sample_ID.Location = New System.Drawing.Point(6, 60)
        Me.TextBox_Client_Sample_ID.Name = "TextBox_Client_Sample_ID"
        Me.TextBox_Client_Sample_ID.Size = New System.Drawing.Size(126, 20)
        Me.TextBox_Client_Sample_ID.TabIndex = 93
        '
        'L_Name_Client_Sample_ID
        '
        Me.L_Name_Client_Sample_ID.AutoSize = True
        Me.L_Name_Client_Sample_ID.Location = New System.Drawing.Point(20, 44)
        Me.L_Name_Client_Sample_ID.Name = "L_Name_Client_Sample_ID"
        Me.L_Name_Client_Sample_ID.Size = New System.Drawing.Size(83, 13)
        Me.L_Name_Client_Sample_ID.TabIndex = 94
        Me.L_Name_Client_Sample_ID.Text = "Client sample ID"
        '
        'L_Name_Sample_Type
        '
        Me.L_Name_Sample_Type.AutoSize = True
        Me.L_Name_Sample_Type.Location = New System.Drawing.Point(171, 44)
        Me.L_Name_Sample_Type.Name = "L_Name_Sample_Type"
        Me.L_Name_Sample_Type.Size = New System.Drawing.Size(65, 13)
        Me.L_Name_Sample_Type.TabIndex = 97
        Me.L_Name_Sample_Type.Text = "Sample type"
        '
        'L_Name_Latitude
        '
        Me.L_Name_Latitude.AutoSize = True
        Me.L_Name_Latitude.Location = New System.Drawing.Point(8, 84)
        Me.L_Name_Latitude.Name = "L_Name_Latitude"
        Me.L_Name_Latitude.Size = New System.Drawing.Size(45, 13)
        Me.L_Name_Latitude.TabIndex = 100
        Me.L_Name_Latitude.Text = "Latitude"
        '
        'L_Name_Longitude
        '
        Me.L_Name_Longitude.AutoSize = True
        Me.L_Name_Longitude.Location = New System.Drawing.Point(77, 84)
        Me.L_Name_Longitude.Name = "L_Name_Longitude"
        Me.L_Name_Longitude.Size = New System.Drawing.Size(54, 13)
        Me.L_Name_Longitude.TabIndex = 102
        Me.L_Name_Longitude.Text = "Longitude"
        '
        'CheckedListBox_Separate_Elements
        '
        Me.CheckedListBox_Separate_Elements.ColumnWidth = 70
        Me.CheckedListBox_Separate_Elements.Enabled = False
        Me.CheckedListBox_Separate_Elements.FormattingEnabled = True
        Me.CheckedListBox_Separate_Elements.Items.AddRange(New Object() {"F", "Na", "Mg", "Al", "Si", "S", "Cl", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Ru", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "I", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Th", "U"})
        Me.CheckedListBox_Separate_Elements.Location = New System.Drawing.Point(526, 62)
        Me.CheckedListBox_Separate_Elements.MultiColumn = True
        Me.CheckedListBox_Separate_Elements.Name = "CheckedListBox_Separate_Elements"
        Me.CheckedListBox_Separate_Elements.Size = New System.Drawing.Size(284, 259)
        Me.CheckedListBox_Separate_Elements.TabIndex = 104
        '
        'L_Name_Separate_Elements
        '
        Me.L_Name_Separate_Elements.AutoSize = True
        Me.L_Name_Separate_Elements.Location = New System.Drawing.Point(622, 46)
        Me.L_Name_Separate_Elements.Name = "L_Name_Separate_Elements"
        Me.L_Name_Separate_Elements.Size = New System.Drawing.Size(95, 13)
        Me.L_Name_Separate_Elements.TabIndex = 103
        Me.L_Name_Separate_Elements.Text = "Separate elements"
        '
        'ComboBox_Determined_Elements
        '
        Me.ComboBox_Determined_Elements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Determined_Elements.FormattingEnabled = True
        Me.ComboBox_Determined_Elements.Items.AddRange(New Object() {"", "group of elements", "separate elements", "all elements"})
        Me.ComboBox_Determined_Elements.Location = New System.Drawing.Point(399, 62)
        Me.ComboBox_Determined_Elements.Name = "ComboBox_Determined_Elements"
        Me.ComboBox_Determined_Elements.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Determined_Elements.TabIndex = 106
        '
        'L_Name_Group_Of_Elements
        '
        Me.L_Name_Group_Of_Elements.AutoSize = True
        Me.L_Name_Group_Of_Elements.Location = New System.Drawing.Point(404, 115)
        Me.L_Name_Group_Of_Elements.Name = "L_Name_Group_Of_Elements"
        Me.L_Name_Group_Of_Elements.Size = New System.Drawing.Size(93, 13)
        Me.L_Name_Group_Of_Elements.TabIndex = 107
        Me.L_Name_Group_Of_Elements.Text = "Group of elements"
        '
        'ComboBox_Table_ReceivedBy
        '
        Me.ComboBox_Table_ReceivedBy.DataSource = Me.Table_Received_By_BindingSource
        Me.ComboBox_Table_ReceivedBy.DisplayMember = "Received_By"
        Me.ComboBox_Table_ReceivedBy.FormattingEnabled = True
        Me.ComboBox_Table_ReceivedBy.Location = New System.Drawing.Point(128, 188)
        Me.ComboBox_Table_ReceivedBy.Name = "ComboBox_Table_ReceivedBy"
        Me.ComboBox_Table_ReceivedBy.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox_Table_ReceivedBy.TabIndex = 111
        Me.ComboBox_Table_ReceivedBy.ValueMember = "Received_By"
        '
        'Table_Received_By_BindingSource
        '
        Me.Table_Received_By_BindingSource.DataMember = "table_Received_By"
        Me.Table_Received_By_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L_Name_ReceivedBy
        '
        Me.L_Name_ReceivedBy.AutoSize = True
        Me.L_Name_ReceivedBy.Location = New System.Drawing.Point(158, 172)
        Me.L_Name_ReceivedBy.Name = "L_Name_ReceivedBy"
        Me.L_Name_ReceivedBy.Size = New System.Drawing.Size(67, 13)
        Me.L_Name_ReceivedBy.TabIndex = 110
        Me.L_Name_ReceivedBy.Text = "Received by"
        '
        'Table_Received_ByTableAdapter
        '
        Me.Table_Received_ByTableAdapter.ClearBeforeFill = True
        '
        'ComboBox_Cupboard_Number
        '
        Me.ComboBox_Cupboard_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Cupboard_Number.FormattingEnabled = True
        Me.ComboBox_Cupboard_Number.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox_Cupboard_Number.Location = New System.Drawing.Point(6, 188)
        Me.ComboBox_Cupboard_Number.Name = "ComboBox_Cupboard_Number"
        Me.ComboBox_Cupboard_Number.Size = New System.Drawing.Size(55, 21)
        Me.ComboBox_Cupboard_Number.TabIndex = 113
        '
        'L_Name_Cupboard_Number
        '
        Me.L_Name_Cupboard_Number.AutoSize = True
        Me.L_Name_Cupboard_Number.Location = New System.Drawing.Point(8, 172)
        Me.L_Name_Cupboard_Number.Name = "L_Name_Cupboard_Number"
        Me.L_Name_Cupboard_Number.Size = New System.Drawing.Size(53, 13)
        Me.L_Name_Cupboard_Number.TabIndex = 112
        Me.L_Name_Cupboard_Number.Text = "Cupboard"
        '
        'ComboBox_Box_Number
        '
        Me.ComboBox_Box_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Box_Number.FormattingEnabled = True
        Me.ComboBox_Box_Number.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99"})
        Me.ComboBox_Box_Number.Location = New System.Drawing.Point(70, 188)
        Me.ComboBox_Box_Number.Name = "ComboBox_Box_Number"
        Me.ComboBox_Box_Number.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox_Box_Number.TabIndex = 115
        '
        'L_Name_Box_Number
        '
        Me.L_Name_Box_Number.AutoSize = True
        Me.L_Name_Box_Number.Location = New System.Drawing.Point(70, 172)
        Me.L_Name_Box_Number.Name = "L_Name_Box_Number"
        Me.L_Name_Box_Number.Size = New System.Drawing.Size(25, 13)
        Me.L_Name_Box_Number.TabIndex = 114
        Me.L_Name_Box_Number.Text = "Box"
        '
        'ComboBox_Sample_Type
        '
        Me.ComboBox_Sample_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sample_Type.FormattingEnabled = True
        Me.ComboBox_Sample_Type.Items.AddRange(New Object() {"", "soils", "sediments", "rocks", "foodstuffs", "vegetation", "biomedical materials", "technological", "filters", "luquids", "others"})
        Me.ComboBox_Sample_Type.Location = New System.Drawing.Point(141, 60)
        Me.ComboBox_Sample_Type.Name = "ComboBox_Sample_Type"
        Me.ComboBox_Sample_Type.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox_Sample_Type.TabIndex = 116
        '
        'L_Name_New_Sample_Accept_Notes
        '
        Me.L_Name_New_Sample_Accept_Notes.AutoSize = True
        Me.L_Name_New_Sample_Accept_Notes.Location = New System.Drawing.Point(109, 215)
        Me.L_Name_New_Sample_Accept_Notes.Name = "L_Name_New_Sample_Accept_Notes"
        Me.L_Name_New_Sample_Accept_Notes.Size = New System.Drawing.Size(35, 13)
        Me.L_Name_New_Sample_Accept_Notes.TabIndex = 117
        Me.L_Name_New_Sample_Accept_Notes.Text = "Notes"
        '
        'TextBox_New_Sample_Accept_Notes
        '
        Me.TextBox_New_Sample_Accept_Notes.Location = New System.Drawing.Point(6, 231)
        Me.TextBox_New_Sample_Accept_Notes.Name = "TextBox_New_Sample_Accept_Notes"
        Me.TextBox_New_Sample_Accept_Notes.Size = New System.Drawing.Size(266, 20)
        Me.TextBox_New_Sample_Accept_Notes.TabIndex = 118
        '
        'Button_Save_Sample
        '
        Me.Button_Save_Sample.Location = New System.Drawing.Point(212, 327)
        Me.Button_Save_Sample.Name = "Button_Save_Sample"
        Me.Button_Save_Sample.Size = New System.Drawing.Size(124, 23)
        Me.Button_Save_Sample.TabIndex = 119
        Me.Button_Save_Sample.Text = "Save sample"
        Me.Button_Save_Sample.UseVisualStyleBackColor = True
        '
        'Label_Name_Code
        '
        Me.Label_Name_Code.AutoSize = True
        Me.Label_Name_Code.Location = New System.Drawing.Point(289, 9)
        Me.Label_Name_Code.Name = "Label_Name_Code"
        Me.Label_Name_Code.Size = New System.Drawing.Size(177, 13)
        Me.Label_Name_Code.TabIndex = 127
        Me.Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
        '
        'L_SS_Sample_Set_ID
        '
        Me.L_SS_Sample_Set_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_ID.Location = New System.Drawing.Point(405, 22)
        Me.L_SS_Sample_Set_ID.Name = "L_SS_Sample_Set_ID"
        Me.L_SS_Sample_Set_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Sample_Set_ID.TabIndex = 125
        '
        'L_SS_Client_ID
        '
        Me.L_SS_Client_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Client_ID.Location = New System.Drawing.Point(344, 22)
        Me.L_SS_Client_ID.Name = "L_SS_Client_ID"
        Me.L_SS_Client_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Client_ID.TabIndex = 123
        '
        'L_SS_Year
        '
        Me.L_SS_Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Year.Location = New System.Drawing.Point(375, 22)
        Me.L_SS_Year.Name = "L_SS_Year"
        Me.L_SS_Year.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Year.TabIndex = 122
        '
        'L_SS_Country_Code
        '
        Me.L_SS_Country_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Country_Code.Location = New System.Drawing.Point(312, 22)
        Me.L_SS_Country_Code.Name = "L_SS_Country_Code"
        Me.L_SS_Country_Code.Size = New System.Drawing.Size(26, 14)
        Me.L_SS_Country_Code.TabIndex = 120
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(342, 327)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(124, 23)
        Me.B_Close.TabIndex = 128
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'L_Sample_ID
        '
        Me.L_Sample_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Sample_ID.Location = New System.Drawing.Point(465, 22)
        Me.L_Sample_ID.Name = "L_Sample_ID"
        Me.L_Sample_ID.Size = New System.Drawing.Size(28, 14)
        Me.L_Sample_ID.TabIndex = 129
        '
        'L_SS_Sample_Set_Index
        '
        Me.L_SS_Sample_Set_Index.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_Index.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_SS_Sample_Set_Index.Location = New System.Drawing.Point(435, 22)
        Me.L_SS_Sample_Set_Index.Name = "L_SS_Sample_Set_Index"
        Me.L_SS_Sample_Set_Index.Size = New System.Drawing.Size(24, 23)
        Me.L_SS_Sample_Set_Index.TabIndex = 171
        '
        'B_Select_All
        '
        Me.B_Select_All.Location = New System.Drawing.Point(399, 89)
        Me.B_Select_All.Name = "B_Select_All"
        Me.B_Select_All.Size = New System.Drawing.Size(121, 23)
        Me.B_Select_All.TabIndex = 172
        Me.B_Select_All.Text = "Select all"
        Me.B_Select_All.UseVisualStyleBackColor = True
        '
        'B_Fill_In_From_File
        '
        Me.B_Fill_In_From_File.Location = New System.Drawing.Point(472, 327)
        Me.B_Fill_In_From_File.Name = "B_Fill_In_From_File"
        Me.B_Fill_In_From_File.Size = New System.Drawing.Size(124, 23)
        Me.B_Fill_In_From_File.TabIndex = 173
        Me.B_Fill_In_From_File.Text = "Fill in from file"
        Me.B_Fill_In_From_File.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_Fill_In_From_File
        '
        Me.OpenFileDialog_Fill_In_From_File.Filter = "Samples info files (*.nas)|*.nas|All files (*.*)|*.*"
        Me.OpenFileDialog_Fill_In_From_File.RestoreDirectory = True
        '
        'ComboBox_Sample_Subtype
        '
        Me.ComboBox_Sample_Subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sample_Subtype.FormattingEnabled = True
        Me.ComboBox_Sample_Subtype.Items.AddRange(New Object() {"", "soils", "sediments", "rocks", "foodstuffs", "vegetation", "biomedical materials", "technological", "filters", "luquids", "others"})
        Me.ComboBox_Sample_Subtype.Location = New System.Drawing.Point(141, 99)
        Me.ComboBox_Sample_Subtype.Name = "ComboBox_Sample_Subtype"
        Me.ComboBox_Sample_Subtype.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox_Sample_Subtype.TabIndex = 174
        Me.ComboBox_Sample_Subtype.Visible = False
        '
        'L_Name_Sample_Subtype
        '
        Me.L_Name_Sample_Subtype.AutoSize = True
        Me.L_Name_Sample_Subtype.Location = New System.Drawing.Point(169, 84)
        Me.L_Name_Sample_Subtype.Name = "L_Name_Sample_Subtype"
        Me.L_Name_Sample_Subtype.Size = New System.Drawing.Size(82, 13)
        Me.L_Name_Sample_Subtype.TabIndex = 175
        Me.L_Name_Sample_Subtype.Text = "Sample subtype"
        Me.L_Name_Sample_Subtype.Visible = False
        '
        'MaskedTextBox_Latitude
        '
        Me.MaskedTextBox_Latitude.Location = New System.Drawing.Point(6, 99)
        Me.MaskedTextBox_Latitude.Mask = "00\.00999"
        Me.MaskedTextBox_Latitude.Name = "MaskedTextBox_Latitude"
        Me.MaskedTextBox_Latitude.Size = New System.Drawing.Size(59, 20)
        Me.MaskedTextBox_Latitude.TabIndex = 176
        '
        'MaskedTextBox_Longitude
        '
        Me.MaskedTextBox_Longitude.Location = New System.Drawing.Point(73, 99)
        Me.MaskedTextBox_Longitude.Mask = "900\.00999"
        Me.MaskedTextBox_Longitude.Name = "MaskedTextBox_Longitude"
        Me.MaskedTextBox_Longitude.Size = New System.Drawing.Size(59, 20)
        Me.MaskedTextBox_Longitude.TabIndex = 177
        '
        'Form_Sample_Accept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 354)
        Me.Controls.Add(Me.MaskedTextBox_Longitude)
        Me.Controls.Add(Me.MaskedTextBox_Latitude)
        Me.Controls.Add(Me.L_Name_Sample_Subtype)
        Me.Controls.Add(Me.ComboBox_Sample_Subtype)
        Me.Controls.Add(Me.B_Fill_In_From_File)
        Me.Controls.Add(Me.B_Select_All)
        Me.Controls.Add(Me.L_SS_Sample_Set_Index)
        Me.Controls.Add(Me.L_Sample_ID)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.Label_Name_Code)
        Me.Controls.Add(Me.L_SS_Sample_Set_ID)
        Me.Controls.Add(Me.L_SS_Client_ID)
        Me.Controls.Add(Me.L_SS_Year)
        Me.Controls.Add(Me.L_SS_Country_Code)
        Me.Controls.Add(Me.Button_Save_Sample)
        Me.Controls.Add(Me.TextBox_New_Sample_Accept_Notes)
        Me.Controls.Add(Me.L_Name_New_Sample_Accept_Notes)
        Me.Controls.Add(Me.ComboBox_Sample_Type)
        Me.Controls.Add(Me.ComboBox_Box_Number)
        Me.Controls.Add(Me.L_Name_Box_Number)
        Me.Controls.Add(Me.ComboBox_Cupboard_Number)
        Me.Controls.Add(Me.L_Name_Cupboard_Number)
        Me.Controls.Add(Me.ComboBox_Table_ReceivedBy)
        Me.Controls.Add(Me.L_Name_ReceivedBy)
        Me.Controls.Add(Me.L_Name_Group_Of_Elements)
        Me.Controls.Add(Me.ComboBox_Determined_Elements)
        Me.Controls.Add(Me.CheckedListBox_Separate_Elements)
        Me.Controls.Add(Me.L_Name_Separate_Elements)
        Me.Controls.Add(Me.L_Name_Longitude)
        Me.Controls.Add(Me.L_Name_Latitude)
        Me.Controls.Add(Me.L_Name_Sample_Type)
        Me.Controls.Add(Me.TextBox_Client_Sample_ID)
        Me.Controls.Add(Me.L_Name_Client_Sample_ID)
        Me.Controls.Add(Me.L_Name_Sample_ID)
        Me.Controls.Add(Me.CheckedListBox_Group_Of_Elements)
        Me.Controls.Add(Me.TextBox_Collection_Place)
        Me.Controls.Add(Me.L_Name_CollectionPlace)
        Me.Controls.Add(Me.L_Name_DeterminedElements)
        Me.Controls.Add(Me.CheckedListBox_Sample_Preparation)
        Me.Controls.Add(Me.L_Name_SamplePreparation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Sample_Accept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New sample acceptance"
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox_Sample_Preparation As System.Windows.Forms.CheckedListBox
    Friend WithEvents L_Name_SamplePreparation As System.Windows.Forms.Label
    Friend WithEvents L_Name_DeterminedElements As System.Windows.Forms.Label
    Friend WithEvents TextBox_Collection_Place As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_CollectionPlace As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox_Group_Of_Elements As System.Windows.Forms.CheckedListBox
    Friend WithEvents L_Name_Sample_ID As System.Windows.Forms.Label
    Friend WithEvents TextBox_Client_Sample_ID As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Client_Sample_ID As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample_Type As System.Windows.Forms.Label
    Friend WithEvents L_Name_Latitude As System.Windows.Forms.Label
    Friend WithEvents L_Name_Longitude As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox_Separate_Elements As System.Windows.Forms.CheckedListBox
    Friend WithEvents L_Name_Separate_Elements As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Determined_Elements As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Group_Of_Elements As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Table_ReceivedBy As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_ReceivedBy As System.Windows.Forms.Label
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_Received_ByTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter
    Friend WithEvents ComboBox_Cupboard_Number As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Cupboard_Number As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Box_Number As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Box_Number As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sample_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Table_Received_By_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents L_Name_New_Sample_Accept_Notes As System.Windows.Forms.Label
    Friend WithEvents TextBox_New_Sample_Accept_Notes As System.Windows.Forms.TextBox
    Friend WithEvents Button_Save_Sample As System.Windows.Forms.Button
    Friend WithEvents Label_Name_Code As System.Windows.Forms.Label
    Friend WithEvents L_SS_Sample_Set_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Client_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Year As System.Windows.Forms.Label
    Friend WithEvents L_SS_Country_Code As System.Windows.Forms.Label
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents L_Sample_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Sample_Set_Index As System.Windows.Forms.Label
    Friend WithEvents B_Select_All As System.Windows.Forms.Button
    Friend WithEvents B_Fill_In_From_File As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Fill_In_From_File As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ComboBox_Sample_Subtype As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Sample_Subtype As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_Latitude As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_Longitude As System.Windows.Forms.MaskedTextBox
End Class
