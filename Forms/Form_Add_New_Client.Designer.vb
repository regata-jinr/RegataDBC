<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Add_New_Client
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
        Me.TextBox_Republic = New System.Windows.Forms.TextBox()
        Me.L_Name_Republic = New System.Windows.Forms.Label()
        Me.L_Name_Region = New System.Windows.Forms.Label()
        Me.TextBox_Region = New System.Windows.Forms.TextBox()
        Me.L_Name_City = New System.Windows.Forms.Label()
        Me.TextBox_City = New System.Windows.Forms.TextBox()
        Me.L_Name_Street = New System.Windows.Forms.Label()
        Me.TextBox_Street = New System.Windows.Forms.TextBox()
        Me.L_Name_Organization = New System.Windows.Forms.Label()
        Me.TextBox_Organization = New System.Windows.Forms.TextBox()
        Me.L_Name_Last_Name = New System.Windows.Forms.Label()
        Me.TextBox_Last_Name = New System.Windows.Forms.TextBox()
        Me.L_Name_First_Name = New System.Windows.Forms.Label()
        Me.TextBox_First_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Middle_Name = New System.Windows.Forms.TextBox()
        Me.L_Name_Phone_1 = New System.Windows.Forms.Label()
        Me.TextBox_Phone_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Phone_2 = New System.Windows.Forms.Label()
        Me.TextBox_Phone_2 = New System.Windows.Forms.TextBox()
        Me.L_Name_Fax_1 = New System.Windows.Forms.Label()
        Me.TextBox_Fax_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_E_mail_2 = New System.Windows.Forms.Label()
        Me.TextBox_E_mail_2 = New System.Windows.Forms.TextBox()
        Me.L_Name_E_mail_1 = New System.Windows.Forms.Label()
        Me.TextBox_E_mail_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Notes = New System.Windows.Forms.Label()
        Me.TextBox_Notes = New System.Windows.Forms.TextBox()
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.Table_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_CountryTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_CountryTableAdapter()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.Table_CountryComboBox_ANC = New System.Windows.Forms.ComboBox()
        Me.L_Name_Client_ID = New System.Windows.Forms.Label()
        Me.Table_ClientIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox_ClientID = New System.Windows.Forms.ListBox()
        Me.L_Name_New_Client_ID = New System.Windows.Forms.Label()
        Me.MaskedTextBox_NewClientID = New System.Windows.Forms.MaskedTextBox()
        Me.B_Save_New_Client_ID = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.L_Name_House = New System.Windows.Forms.Label()
        Me.TextBox_House = New System.Windows.Forms.TextBox()
        Me.L_Name_Building = New System.Windows.Forms.Label()
        Me.TextBox_Building = New System.Windows.Forms.TextBox()
        Me.L_Name_Postal_Code = New System.Windows.Forms.Label()
        Me.TextBox_Postal_Code = New System.Windows.Forms.TextBox()
        Me.L_Name_Phone_Country_Code_Phone_1 = New System.Windows.Forms.Label()
        Me.TextBox_Phone_Country_Code_Phone_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Code_Phone_1 = New System.Windows.Forms.Label()
        Me.TextBox_Code_Phone_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Code_Phone_2 = New System.Windows.Forms.Label()
        Me.TextBox_Code_Phone_2 = New System.Windows.Forms.TextBox()
        Me.L_Name_Phone_Country_Code_Phone_2 = New System.Windows.Forms.Label()
        Me.TextBox_Phone_Country_Code_Phone_2 = New System.Windows.Forms.TextBox()
        Me.L_Name_Code_Fax_1 = New System.Windows.Forms.Label()
        Me.TextBox_Code_Fax_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Phone_Country_Code_Fax_1 = New System.Windows.Forms.Label()
        Me.TextBox_Phone_Country_Code_Fax_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Code_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.TextBox_Code_Mobile_Phone_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.TextBox_Phone_Country_Code_Mobile_Phone_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.TextBox_Mobile_Phone_1 = New System.Windows.Forms.TextBox()
        Me.ComboBox_Title = New System.Windows.Forms.ComboBox()
        Me.B_Fill_In_From_File = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Add_New_Client_From_File = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox_Gender = New System.Windows.Forms.ComboBox()
        Me.L_Name_District = New System.Windows.Forms.Label()
        Me.TextBox_District = New System.Windows.Forms.TextBox()
        Me.L_Name_Country = New System.Windows.Forms.Label()
        Me.L_Name_Title = New System.Windows.Forms.Label()
        Me.L_Name_Gender = New System.Windows.Forms.Label()
        Me.L_Name_Middle_Name = New System.Windows.Forms.Label()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_ClientIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Republic
        '
        Me.TextBox_Republic.Location = New System.Drawing.Point(118, 93)
        Me.TextBox_Republic.Name = "TextBox_Republic"
        Me.TextBox_Republic.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Republic.TabIndex = 0
        '
        'L_Name_Republic
        '
        Me.L_Name_Republic.AutoSize = True
        Me.L_Name_Republic.Location = New System.Drawing.Point(144, 77)
        Me.L_Name_Republic.Name = "L_Name_Republic"
        Me.L_Name_Republic.Size = New System.Drawing.Size(49, 13)
        Me.L_Name_Republic.TabIndex = 1
        Me.L_Name_Republic.Text = "Republic"
        '
        'L_Name_Region
        '
        Me.L_Name_Region.AutoSize = True
        Me.L_Name_Region.Location = New System.Drawing.Point(256, 77)
        Me.L_Name_Region.Name = "L_Name_Region"
        Me.L_Name_Region.Size = New System.Drawing.Size(41, 13)
        Me.L_Name_Region.TabIndex = 3
        Me.L_Name_Region.Text = "Region"
        '
        'TextBox_Region
        '
        Me.TextBox_Region.Location = New System.Drawing.Point(224, 93)
        Me.TextBox_Region.Name = "TextBox_Region"
        Me.TextBox_Region.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Region.TabIndex = 2
        '
        'L_Name_City
        '
        Me.L_Name_City.AutoSize = True
        Me.L_Name_City.Location = New System.Drawing.Point(49, 125)
        Me.L_Name_City.Name = "L_Name_City"
        Me.L_Name_City.Size = New System.Drawing.Size(24, 13)
        Me.L_Name_City.TabIndex = 5
        Me.L_Name_City.Text = "City"
        '
        'TextBox_City
        '
        Me.TextBox_City.Location = New System.Drawing.Point(12, 141)
        Me.TextBox_City.Name = "TextBox_City"
        Me.TextBox_City.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_City.TabIndex = 4
        '
        'L_Name_Street
        '
        Me.L_Name_Street.AutoSize = True
        Me.L_Name_Street.Location = New System.Drawing.Point(156, 125)
        Me.L_Name_Street.Name = "L_Name_Street"
        Me.L_Name_Street.Size = New System.Drawing.Size(35, 13)
        Me.L_Name_Street.TabIndex = 7
        Me.L_Name_Street.Text = "Street"
        '
        'TextBox_Street
        '
        Me.TextBox_Street.Location = New System.Drawing.Point(120, 141)
        Me.TextBox_Street.Name = "TextBox_Street"
        Me.TextBox_Street.Size = New System.Drawing.Size(98, 20)
        Me.TextBox_Street.TabIndex = 6
        '
        'L_Name_Organization
        '
        Me.L_Name_Organization.AutoSize = True
        Me.L_Name_Organization.Location = New System.Drawing.Point(188, 174)
        Me.L_Name_Organization.Name = "L_Name_Organization"
        Me.L_Name_Organization.Size = New System.Drawing.Size(66, 13)
        Me.L_Name_Organization.TabIndex = 9
        Me.L_Name_Organization.Text = "Organization"
        '
        'TextBox_Organization
        '
        Me.TextBox_Organization.Location = New System.Drawing.Point(12, 190)
        Me.TextBox_Organization.Name = "TextBox_Organization"
        Me.TextBox_Organization.Size = New System.Drawing.Size(418, 20)
        Me.TextBox_Organization.TabIndex = 8
        '
        'L_Name_Last_Name
        '
        Me.L_Name_Last_Name.AutoSize = True
        Me.L_Name_Last_Name.Location = New System.Drawing.Point(135, 224)
        Me.L_Name_Last_Name.Name = "L_Name_Last_Name"
        Me.L_Name_Last_Name.Size = New System.Drawing.Size(58, 13)
        Me.L_Name_Last_Name.TabIndex = 11
        Me.L_Name_Last_Name.Text = "Last Name"
        '
        'TextBox_Last_Name
        '
        Me.TextBox_Last_Name.Location = New System.Drawing.Point(118, 240)
        Me.TextBox_Last_Name.Name = "TextBox_Last_Name"
        Me.TextBox_Last_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Last_Name.TabIndex = 10
        '
        'L_Name_First_Name
        '
        Me.L_Name_First_Name.AutoSize = True
        Me.L_Name_First_Name.Location = New System.Drawing.Point(245, 224)
        Me.L_Name_First_Name.Name = "L_Name_First_Name"
        Me.L_Name_First_Name.Size = New System.Drawing.Size(57, 13)
        Me.L_Name_First_Name.TabIndex = 13
        Me.L_Name_First_Name.Text = "First Name"
        '
        'TextBox_First_Name
        '
        Me.TextBox_First_Name.Location = New System.Drawing.Point(225, 240)
        Me.TextBox_First_Name.Name = "TextBox_First_Name"
        Me.TextBox_First_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_First_Name.TabIndex = 12
        '
        'TextBox_Middle_Name
        '
        Me.TextBox_Middle_Name.Location = New System.Drawing.Point(331, 240)
        Me.TextBox_Middle_Name.Name = "TextBox_Middle_Name"
        Me.TextBox_Middle_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Middle_Name.TabIndex = 14
        '
        'L_Name_Phone_1
        '
        Me.L_Name_Phone_1.AutoSize = True
        Me.L_Name_Phone_1.Location = New System.Drawing.Point(144, 271)
        Me.L_Name_Phone_1.Name = "L_Name_Phone_1"
        Me.L_Name_Phone_1.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Phone_1.TabIndex = 17
        Me.L_Name_Phone_1.Text = "Phone 1"
        '
        'TextBox_Phone_1
        '
        Me.TextBox_Phone_1.Location = New System.Drawing.Point(118, 287)
        Me.TextBox_Phone_1.Name = "TextBox_Phone_1"
        Me.TextBox_Phone_1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Phone_1.TabIndex = 16
        '
        'L_Name_Phone_2
        '
        Me.L_Name_Phone_2.AutoSize = True
        Me.L_Name_Phone_2.Location = New System.Drawing.Point(354, 271)
        Me.L_Name_Phone_2.Name = "L_Name_Phone_2"
        Me.L_Name_Phone_2.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Phone_2.TabIndex = 19
        Me.L_Name_Phone_2.Text = "Phone 2"
        '
        'TextBox_Phone_2
        '
        Me.TextBox_Phone_2.Location = New System.Drawing.Point(330, 287)
        Me.TextBox_Phone_2.Name = "TextBox_Phone_2"
        Me.TextBox_Phone_2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Phone_2.TabIndex = 18
        '
        'L_Name_Fax_1
        '
        Me.L_Name_Fax_1.AutoSize = True
        Me.L_Name_Fax_1.Location = New System.Drawing.Point(155, 317)
        Me.L_Name_Fax_1.Name = "L_Name_Fax_1"
        Me.L_Name_Fax_1.Size = New System.Drawing.Size(24, 13)
        Me.L_Name_Fax_1.TabIndex = 21
        Me.L_Name_Fax_1.Text = "Fax"
        '
        'TextBox_Fax_1
        '
        Me.TextBox_Fax_1.Location = New System.Drawing.Point(118, 333)
        Me.TextBox_Fax_1.Name = "TextBox_Fax_1"
        Me.TextBox_Fax_1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Fax_1.TabIndex = 20
        '
        'L_Name_E_mail_2
        '
        Me.L_Name_E_mail_2.AutoSize = True
        Me.L_Name_E_mail_2.Location = New System.Drawing.Point(146, 362)
        Me.L_Name_E_mail_2.Name = "L_Name_E_mail_2"
        Me.L_Name_E_mail_2.Size = New System.Drawing.Size(43, 13)
        Me.L_Name_E_mail_2.TabIndex = 27
        Me.L_Name_E_mail_2.Text = "e-mail 2"
        '
        'TextBox_E_mail_2
        '
        Me.TextBox_E_mail_2.Location = New System.Drawing.Point(120, 378)
        Me.TextBox_E_mail_2.Name = "TextBox_E_mail_2"
        Me.TextBox_E_mail_2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_E_mail_2.TabIndex = 26
        '
        'L_Name_E_mail_1
        '
        Me.L_Name_E_mail_1.AutoSize = True
        Me.L_Name_E_mail_1.Location = New System.Drawing.Point(43, 362)
        Me.L_Name_E_mail_1.Name = "L_Name_E_mail_1"
        Me.L_Name_E_mail_1.Size = New System.Drawing.Size(43, 13)
        Me.L_Name_E_mail_1.TabIndex = 25
        Me.L_Name_E_mail_1.Text = "e-mail 1"
        '
        'TextBox_E_mail_1
        '
        Me.TextBox_E_mail_1.Location = New System.Drawing.Point(12, 378)
        Me.TextBox_E_mail_1.Name = "TextBox_E_mail_1"
        Me.TextBox_E_mail_1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_E_mail_1.TabIndex = 24
        '
        'L_Name_Notes
        '
        Me.L_Name_Notes.AutoSize = True
        Me.L_Name_Notes.Location = New System.Drawing.Point(200, 405)
        Me.L_Name_Notes.Name = "L_Name_Notes"
        Me.L_Name_Notes.Size = New System.Drawing.Size(35, 13)
        Me.L_Name_Notes.TabIndex = 29
        Me.L_Name_Notes.Text = "Notes"
        '
        'TextBox_Notes
        '
        Me.TextBox_Notes.Location = New System.Drawing.Point(12, 421)
        Me.TextBox_Notes.Name = "TextBox_Notes"
        Me.TextBox_Notes.Size = New System.Drawing.Size(419, 20)
        Me.TextBox_Notes.TabIndex = 28
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_CountryBindingSource
        '
        Me.Table_CountryBindingSource.DataMember = "table_Country"
        Me.Table_CountryBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_CountryTableAdapter
        '
        Me.Table_CountryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.table_ClientTableAdapter = Nothing
        Me.TableAdapterManager.table_CountryTableAdapter = Me.Table_CountryTableAdapter
        Me.TableAdapterManager.table_Determined_ElementsTableAdapter = Nothing
        Me.TableAdapterManager.table_LLI_Irradiation_LogTableAdapter = Nothing
        Me.TableAdapterManager.table_Monitor_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_MonitorTableAdapter = Nothing
        Me.TableAdapterManager.table_Physical_EnvironmentTableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_NAA_Results_TableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_PreparationTableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_Sample_Preparation_TableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_TableAdapter = Nothing
        Me.TableAdapterManager.table_Sample_TypeTableAdapter = Nothing
        Me.TableAdapterManager.table_SLI_Irradiation_LogTableAdapter = Nothing
        Me.TableAdapterManager.table_SRM_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_SRMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table_CountryComboBox_ANC
        '
        Me.Table_CountryComboBox_ANC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Table_CountryComboBox_ANC.FormattingEnabled = True
        Me.Table_CountryComboBox_ANC.Location = New System.Drawing.Point(12, 26)
        Me.Table_CountryComboBox_ANC.Name = "Table_CountryComboBox_ANC"
        Me.Table_CountryComboBox_ANC.Size = New System.Drawing.Size(133, 21)
        Me.Table_CountryComboBox_ANC.TabIndex = 32
        '
        'L_Name_Client_ID
        '
        Me.L_Name_Client_ID.AutoSize = True
        Me.L_Name_Client_ID.Location = New System.Drawing.Point(162, 10)
        Me.L_Name_Client_ID.Name = "L_Name_Client_ID"
        Me.L_Name_Client_ID.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Client_ID.TabIndex = 72
        Me.L_Name_Client_ID.Text = "Client ID"
        '
        'ListBox_ClientID
        '
        Me.ListBox_ClientID.FormattingEnabled = True
        Me.ListBox_ClientID.Location = New System.Drawing.Point(165, 26)
        Me.ListBox_ClientID.Name = "ListBox_ClientID"
        Me.ListBox_ClientID.Size = New System.Drawing.Size(55, 43)
        Me.ListBox_ClientID.Sorted = True
        Me.ListBox_ClientID.TabIndex = 74
        '
        'L_Name_New_Client_ID
        '
        Me.L_Name_New_Client_ID.AutoSize = True
        Me.L_Name_New_Client_ID.Location = New System.Drawing.Point(251, 11)
        Me.L_Name_New_Client_ID.Name = "L_Name_New_Client_ID"
        Me.L_Name_New_Client_ID.Size = New System.Drawing.Size(71, 13)
        Me.L_Name_New_Client_ID.TabIndex = 76
        Me.L_Name_New_Client_ID.Text = "New сlient ID"
        '
        'MaskedTextBox_NewClientID
        '
        Me.MaskedTextBox_NewClientID.Location = New System.Drawing.Point(281, 27)
        Me.MaskedTextBox_NewClientID.Mask = "00"
        Me.MaskedTextBox_NewClientID.Name = "MaskedTextBox_NewClientID"
        Me.MaskedTextBox_NewClientID.Size = New System.Drawing.Size(21, 20)
        Me.MaskedTextBox_NewClientID.TabIndex = 77
        '
        'B_Save_New_Client_ID
        '
        Me.B_Save_New_Client_ID.Location = New System.Drawing.Point(12, 452)
        Me.B_Save_New_Client_ID.Name = "B_Save_New_Client_ID"
        Me.B_Save_New_Client_ID.Size = New System.Drawing.Size(151, 23)
        Me.B_Save_New_Client_ID.TabIndex = 78
        Me.B_Save_New_Client_ID.Text = "Save new client ID"
        Me.B_Save_New_Client_ID.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(317, 452)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(113, 23)
        Me.B_Close.TabIndex = 79
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'L_Name_House
        '
        Me.L_Name_House.AutoSize = True
        Me.L_Name_House.Location = New System.Drawing.Point(256, 125)
        Me.L_Name_House.Name = "L_Name_House"
        Me.L_Name_House.Size = New System.Drawing.Size(38, 13)
        Me.L_Name_House.TabIndex = 81
        Me.L_Name_House.Text = "House"
        '
        'TextBox_House
        '
        Me.TextBox_House.Location = New System.Drawing.Point(224, 141)
        Me.TextBox_House.Name = "TextBox_House"
        Me.TextBox_House.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_House.TabIndex = 80
        '
        'L_Name_Building
        '
        Me.L_Name_Building.AutoSize = True
        Me.L_Name_Building.Location = New System.Drawing.Point(359, 125)
        Me.L_Name_Building.Name = "L_Name_Building"
        Me.L_Name_Building.Size = New System.Drawing.Size(44, 13)
        Me.L_Name_Building.TabIndex = 83
        Me.L_Name_Building.Text = "Building"
        '
        'TextBox_Building
        '
        Me.TextBox_Building.Location = New System.Drawing.Point(330, 141)
        Me.TextBox_Building.Name = "TextBox_Building"
        Me.TextBox_Building.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Building.TabIndex = 82
        '
        'L_Name_Postal_Code
        '
        Me.L_Name_Postal_Code.AutoSize = True
        Me.L_Name_Postal_Code.Location = New System.Drawing.Point(31, 77)
        Me.L_Name_Postal_Code.Name = "L_Name_Postal_Code"
        Me.L_Name_Postal_Code.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Postal_Code.TabIndex = 85
        Me.L_Name_Postal_Code.Text = "Postal Code"
        '
        'TextBox_Postal_Code
        '
        Me.TextBox_Postal_Code.Location = New System.Drawing.Point(12, 93)
        Me.TextBox_Postal_Code.Name = "TextBox_Postal_Code"
        Me.TextBox_Postal_Code.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Postal_Code.TabIndex = 84
        '
        'L_Name_Phone_Country_Code_Phone_1
        '
        Me.L_Name_Phone_Country_Code_Phone_1.AutoSize = True
        Me.L_Name_Phone_Country_Code_Phone_1.Location = New System.Drawing.Point(25, 270)
        Me.L_Name_Phone_Country_Code_Phone_1.Name = "L_Name_Phone_Country_Code_Phone_1"
        Me.L_Name_Phone_Country_Code_Phone_1.Size = New System.Drawing.Size(55, 13)
        Me.L_Name_Phone_Country_Code_Phone_1.TabIndex = 87
        Me.L_Name_Phone_Country_Code_Phone_1.Text = "Phone CC"
        '
        'TextBox_Phone_Country_Code_Phone_1
        '
        Me.TextBox_Phone_Country_Code_Phone_1.Location = New System.Drawing.Point(46, 287)
        Me.TextBox_Phone_Country_Code_Phone_1.Name = "TextBox_Phone_Country_Code_Phone_1"
        Me.TextBox_Phone_Country_Code_Phone_1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Phone_Country_Code_Phone_1.TabIndex = 86
        '
        'L_Name_Code_Phone_1
        '
        Me.L_Name_Code_Phone_1.AutoSize = True
        Me.L_Name_Code_Phone_1.Location = New System.Drawing.Point(79, 270)
        Me.L_Name_Code_Phone_1.Name = "L_Name_Code_Phone_1"
        Me.L_Name_Code_Phone_1.Size = New System.Drawing.Size(32, 13)
        Me.L_Name_Code_Phone_1.TabIndex = 89
        Me.L_Name_Code_Phone_1.Text = "Code"
        '
        'TextBox_Code_Phone_1
        '
        Me.TextBox_Code_Phone_1.Location = New System.Drawing.Point(82, 287)
        Me.TextBox_Code_Phone_1.Name = "TextBox_Code_Phone_1"
        Me.TextBox_Code_Phone_1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Code_Phone_1.TabIndex = 88
        '
        'L_Name_Code_Phone_2
        '
        Me.L_Name_Code_Phone_2.AutoSize = True
        Me.L_Name_Code_Phone_2.Location = New System.Drawing.Point(291, 271)
        Me.L_Name_Code_Phone_2.Name = "L_Name_Code_Phone_2"
        Me.L_Name_Code_Phone_2.Size = New System.Drawing.Size(32, 13)
        Me.L_Name_Code_Phone_2.TabIndex = 93
        Me.L_Name_Code_Phone_2.Text = "Code"
        '
        'TextBox_Code_Phone_2
        '
        Me.TextBox_Code_Phone_2.Location = New System.Drawing.Point(294, 287)
        Me.TextBox_Code_Phone_2.Name = "TextBox_Code_Phone_2"
        Me.TextBox_Code_Phone_2.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Code_Phone_2.TabIndex = 92
        '
        'L_Name_Phone_Country_Code_Phone_2
        '
        Me.L_Name_Phone_Country_Code_Phone_2.AutoSize = True
        Me.L_Name_Phone_Country_Code_Phone_2.Location = New System.Drawing.Point(235, 271)
        Me.L_Name_Phone_Country_Code_Phone_2.Name = "L_Name_Phone_Country_Code_Phone_2"
        Me.L_Name_Phone_Country_Code_Phone_2.Size = New System.Drawing.Size(55, 13)
        Me.L_Name_Phone_Country_Code_Phone_2.TabIndex = 91
        Me.L_Name_Phone_Country_Code_Phone_2.Text = "Phone CC"
        '
        'TextBox_Phone_Country_Code_Phone_2
        '
        Me.TextBox_Phone_Country_Code_Phone_2.Location = New System.Drawing.Point(258, 287)
        Me.TextBox_Phone_Country_Code_Phone_2.Name = "TextBox_Phone_Country_Code_Phone_2"
        Me.TextBox_Phone_Country_Code_Phone_2.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Phone_Country_Code_Phone_2.TabIndex = 90
        '
        'L_Name_Code_Fax_1
        '
        Me.L_Name_Code_Fax_1.AutoSize = True
        Me.L_Name_Code_Fax_1.Location = New System.Drawing.Point(79, 317)
        Me.L_Name_Code_Fax_1.Name = "L_Name_Code_Fax_1"
        Me.L_Name_Code_Fax_1.Size = New System.Drawing.Size(32, 13)
        Me.L_Name_Code_Fax_1.TabIndex = 97
        Me.L_Name_Code_Fax_1.Text = "Code"
        '
        'TextBox_Code_Fax_1
        '
        Me.TextBox_Code_Fax_1.Location = New System.Drawing.Point(82, 333)
        Me.TextBox_Code_Fax_1.Name = "TextBox_Code_Fax_1"
        Me.TextBox_Code_Fax_1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Code_Fax_1.TabIndex = 96
        '
        'L_Name_Phone_Country_Code_Fax_1
        '
        Me.L_Name_Phone_Country_Code_Fax_1.AutoSize = True
        Me.L_Name_Phone_Country_Code_Fax_1.Location = New System.Drawing.Point(25, 317)
        Me.L_Name_Phone_Country_Code_Fax_1.Name = "L_Name_Phone_Country_Code_Fax_1"
        Me.L_Name_Phone_Country_Code_Fax_1.Size = New System.Drawing.Size(55, 13)
        Me.L_Name_Phone_Country_Code_Fax_1.TabIndex = 95
        Me.L_Name_Phone_Country_Code_Fax_1.Text = "Phone CC"
        '
        'TextBox_Phone_Country_Code_Fax_1
        '
        Me.TextBox_Phone_Country_Code_Fax_1.Location = New System.Drawing.Point(46, 333)
        Me.TextBox_Phone_Country_Code_Fax_1.Name = "TextBox_Phone_Country_Code_Fax_1"
        Me.TextBox_Phone_Country_Code_Fax_1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Phone_Country_Code_Fax_1.TabIndex = 94
        '
        'L_Name_Code_Mobile_Phone_1
        '
        Me.L_Name_Code_Mobile_Phone_1.AutoSize = True
        Me.L_Name_Code_Mobile_Phone_1.Location = New System.Drawing.Point(291, 317)
        Me.L_Name_Code_Mobile_Phone_1.Name = "L_Name_Code_Mobile_Phone_1"
        Me.L_Name_Code_Mobile_Phone_1.Size = New System.Drawing.Size(32, 13)
        Me.L_Name_Code_Mobile_Phone_1.TabIndex = 103
        Me.L_Name_Code_Mobile_Phone_1.Text = "Code"
        '
        'TextBox_Code_Mobile_Phone_1
        '
        Me.TextBox_Code_Mobile_Phone_1.Location = New System.Drawing.Point(294, 333)
        Me.TextBox_Code_Mobile_Phone_1.Name = "TextBox_Code_Mobile_Phone_1"
        Me.TextBox_Code_Mobile_Phone_1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Code_Mobile_Phone_1.TabIndex = 102
        '
        'L_Name_Phone_Country_Code_Mobile_Phone_1
        '
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1.AutoSize = True
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1.Location = New System.Drawing.Point(237, 317)
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1.Name = "L_Name_Phone_Country_Code_Mobile_Phone_1"
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1.Size = New System.Drawing.Size(55, 13)
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1.TabIndex = 101
        Me.L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Phone CC"
        '
        'TextBox_Phone_Country_Code_Mobile_Phone_1
        '
        Me.TextBox_Phone_Country_Code_Mobile_Phone_1.Location = New System.Drawing.Point(258, 333)
        Me.TextBox_Phone_Country_Code_Mobile_Phone_1.Name = "TextBox_Phone_Country_Code_Mobile_Phone_1"
        Me.TextBox_Phone_Country_Code_Mobile_Phone_1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox_Phone_Country_Code_Mobile_Phone_1.TabIndex = 100
        '
        'L_Name_Mobile_Phone_1
        '
        Me.L_Name_Mobile_Phone_1.AutoSize = True
        Me.L_Name_Mobile_Phone_1.Location = New System.Drawing.Point(344, 317)
        Me.L_Name_Mobile_Phone_1.Name = "L_Name_Mobile_Phone_1"
        Me.L_Name_Mobile_Phone_1.Size = New System.Drawing.Size(72, 13)
        Me.L_Name_Mobile_Phone_1.TabIndex = 99
        Me.L_Name_Mobile_Phone_1.Text = "Mobile Phone"
        '
        'TextBox_Mobile_Phone_1
        '
        Me.TextBox_Mobile_Phone_1.Location = New System.Drawing.Point(330, 333)
        Me.TextBox_Mobile_Phone_1.Name = "TextBox_Mobile_Phone_1"
        Me.TextBox_Mobile_Phone_1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Mobile_Phone_1.TabIndex = 98
        '
        'ComboBox_Title
        '
        Me.ComboBox_Title.AutoCompleteCustomSource.AddRange(New String() {"", "Dr.", "Ms.", "Mr.", "Mrs.", "Prof."})
        Me.ComboBox_Title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Title.FormattingEnabled = True
        Me.ComboBox_Title.Items.AddRange(New Object() {"Dr.", "Ms.", "Mr.", "Mrs.", "Prof."})
        Me.ComboBox_Title.Location = New System.Drawing.Point(12, 239)
        Me.ComboBox_Title.Name = "ComboBox_Title"
        Me.ComboBox_Title.Size = New System.Drawing.Size(53, 21)
        Me.ComboBox_Title.TabIndex = 105
        '
        'B_Fill_In_From_File
        '
        Me.B_Fill_In_From_File.Location = New System.Drawing.Point(169, 452)
        Me.B_Fill_In_From_File.Name = "B_Fill_In_From_File"
        Me.B_Fill_In_From_File.Size = New System.Drawing.Size(142, 23)
        Me.B_Fill_In_From_File.TabIndex = 106
        Me.B_Fill_In_From_File.Text = "Fill in from file"
        Me.B_Fill_In_From_File.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_Add_New_Client_From_File
        '
        Me.OpenFileDialog_Add_New_Client_From_File.Filter = "Client info files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'ComboBox_Gender
        '
        Me.ComboBox_Gender.AutoCompleteCustomSource.AddRange(New String() {"", "f", "m"})
        Me.ComboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Gender.FormattingEnabled = True
        Me.ComboBox_Gender.Items.AddRange(New Object() {"", "f", "m"})
        Me.ComboBox_Gender.Location = New System.Drawing.Point(71, 239)
        Me.ComboBox_Gender.Name = "ComboBox_Gender"
        Me.ComboBox_Gender.Size = New System.Drawing.Size(41, 21)
        Me.ComboBox_Gender.TabIndex = 108
        '
        'L_Name_District
        '
        Me.L_Name_District.AutoSize = True
        Me.L_Name_District.Location = New System.Drawing.Point(362, 77)
        Me.L_Name_District.Name = "L_Name_District"
        Me.L_Name_District.Size = New System.Drawing.Size(39, 13)
        Me.L_Name_District.TabIndex = 110
        Me.L_Name_District.Text = "District"
        '
        'TextBox_District
        '
        Me.TextBox_District.Location = New System.Drawing.Point(331, 93)
        Me.TextBox_District.Name = "TextBox_District"
        Me.TextBox_District.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_District.TabIndex = 109
        '
        'L_Name_Country
        '
        Me.L_Name_Country.AutoSize = True
        Me.L_Name_Country.Location = New System.Drawing.Point(51, 11)
        Me.L_Name_Country.Name = "L_Name_Country"
        Me.L_Name_Country.Size = New System.Drawing.Size(43, 13)
        Me.L_Name_Country.TabIndex = 111
        Me.L_Name_Country.Text = "Country"
        '
        'L_Name_Title
        '
        Me.L_Name_Title.AutoSize = True
        Me.L_Name_Title.Location = New System.Drawing.Point(25, 223)
        Me.L_Name_Title.Name = "L_Name_Title"
        Me.L_Name_Title.Size = New System.Drawing.Size(27, 13)
        Me.L_Name_Title.TabIndex = 112
        Me.L_Name_Title.Text = "Title"
        '
        'L_Name_Gender
        '
        Me.L_Name_Gender.AutoSize = True
        Me.L_Name_Gender.Location = New System.Drawing.Point(73, 223)
        Me.L_Name_Gender.Name = "L_Name_Gender"
        Me.L_Name_Gender.Size = New System.Drawing.Size(42, 13)
        Me.L_Name_Gender.TabIndex = 113
        Me.L_Name_Gender.Text = "Gender"
        '
        'L_Name_Middle_Name
        '
        Me.L_Name_Middle_Name.AutoSize = True
        Me.L_Name_Middle_Name.Location = New System.Drawing.Point(349, 224)
        Me.L_Name_Middle_Name.Name = "L_Name_Middle_Name"
        Me.L_Name_Middle_Name.Size = New System.Drawing.Size(67, 13)
        Me.L_Name_Middle_Name.TabIndex = 114
        Me.L_Name_Middle_Name.Text = "Middle name"
        '
        'Form_Add_New_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 481)
        Me.Controls.Add(Me.L_Name_Middle_Name)
        Me.Controls.Add(Me.L_Name_Gender)
        Me.Controls.Add(Me.L_Name_Title)
        Me.Controls.Add(Me.L_Name_Country)
        Me.Controls.Add(Me.L_Name_District)
        Me.Controls.Add(Me.TextBox_District)
        Me.Controls.Add(Me.ComboBox_Gender)
        Me.Controls.Add(Me.B_Fill_In_From_File)
        Me.Controls.Add(Me.ComboBox_Title)
        Me.Controls.Add(Me.L_Name_Code_Mobile_Phone_1)
        Me.Controls.Add(Me.TextBox_Code_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Name_Phone_Country_Code_Mobile_Phone_1)
        Me.Controls.Add(Me.TextBox_Phone_Country_Code_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Name_Mobile_Phone_1)
        Me.Controls.Add(Me.TextBox_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Name_Code_Fax_1)
        Me.Controls.Add(Me.TextBox_Code_Fax_1)
        Me.Controls.Add(Me.L_Name_Phone_Country_Code_Fax_1)
        Me.Controls.Add(Me.TextBox_Phone_Country_Code_Fax_1)
        Me.Controls.Add(Me.L_Name_Code_Phone_2)
        Me.Controls.Add(Me.TextBox_Code_Phone_2)
        Me.Controls.Add(Me.L_Name_Phone_Country_Code_Phone_2)
        Me.Controls.Add(Me.TextBox_Phone_Country_Code_Phone_2)
        Me.Controls.Add(Me.L_Name_Code_Phone_1)
        Me.Controls.Add(Me.TextBox_Code_Phone_1)
        Me.Controls.Add(Me.L_Name_Phone_Country_Code_Phone_1)
        Me.Controls.Add(Me.TextBox_Phone_Country_Code_Phone_1)
        Me.Controls.Add(Me.L_Name_Postal_Code)
        Me.Controls.Add(Me.TextBox_Postal_Code)
        Me.Controls.Add(Me.L_Name_Building)
        Me.Controls.Add(Me.TextBox_Building)
        Me.Controls.Add(Me.L_Name_House)
        Me.Controls.Add(Me.TextBox_House)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Save_New_Client_ID)
        Me.Controls.Add(Me.MaskedTextBox_NewClientID)
        Me.Controls.Add(Me.L_Name_New_Client_ID)
        Me.Controls.Add(Me.ListBox_ClientID)
        Me.Controls.Add(Me.L_Name_Client_ID)
        Me.Controls.Add(Me.Table_CountryComboBox_ANC)
        Me.Controls.Add(Me.L_Name_Notes)
        Me.Controls.Add(Me.TextBox_Notes)
        Me.Controls.Add(Me.L_Name_E_mail_2)
        Me.Controls.Add(Me.TextBox_E_mail_2)
        Me.Controls.Add(Me.L_Name_E_mail_1)
        Me.Controls.Add(Me.TextBox_E_mail_1)
        Me.Controls.Add(Me.L_Name_Fax_1)
        Me.Controls.Add(Me.TextBox_Fax_1)
        Me.Controls.Add(Me.L_Name_Phone_2)
        Me.Controls.Add(Me.TextBox_Phone_2)
        Me.Controls.Add(Me.L_Name_Phone_1)
        Me.Controls.Add(Me.TextBox_Phone_1)
        Me.Controls.Add(Me.TextBox_Middle_Name)
        Me.Controls.Add(Me.L_Name_First_Name)
        Me.Controls.Add(Me.TextBox_First_Name)
        Me.Controls.Add(Me.L_Name_Last_Name)
        Me.Controls.Add(Me.TextBox_Last_Name)
        Me.Controls.Add(Me.L_Name_Organization)
        Me.Controls.Add(Me.TextBox_Organization)
        Me.Controls.Add(Me.L_Name_Street)
        Me.Controls.Add(Me.TextBox_Street)
        Me.Controls.Add(Me.L_Name_City)
        Me.Controls.Add(Me.TextBox_City)
        Me.Controls.Add(Me.L_Name_Region)
        Me.Controls.Add(Me.TextBox_Region)
        Me.Controls.Add(Me.L_Name_Republic)
        Me.Controls.Add(Me.TextBox_Republic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Add_New_Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Client"
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_ClientIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Republic As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Republic As System.Windows.Forms.Label
    Friend WithEvents L_Name_Region As System.Windows.Forms.Label
    Friend WithEvents TextBox_Region As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_City As System.Windows.Forms.Label
    Friend WithEvents TextBox_City As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Street As System.Windows.Forms.Label
    Friend WithEvents TextBox_Street As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Organization As System.Windows.Forms.Label
    Friend WithEvents TextBox_Organization As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Last_Name As System.Windows.Forms.Label
    Friend WithEvents TextBox_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_First_Name As System.Windows.Forms.Label
    Friend WithEvents TextBox_First_Name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Middle_Name As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Phone_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Phone_2 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Fax_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_E_mail_2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_E_mail_2 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_E_mail_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_E_mail_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Notes As System.Windows.Forms.Label
    Friend WithEvents TextBox_Notes As System.Windows.Forms.TextBox
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_CountryTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_CountryTableAdapter
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table_CountryComboBox_ANC As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Client_ID As System.Windows.Forms.Label
    Friend WithEvents Table_ClientIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox_ClientID As System.Windows.Forms.ListBox
    Friend WithEvents L_Name_New_Client_ID As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_NewClientID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents B_Save_New_Client_ID As System.Windows.Forms.Button
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents L_Name_House As System.Windows.Forms.Label
    Friend WithEvents TextBox_House As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Building As System.Windows.Forms.Label
    Friend WithEvents TextBox_Building As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Postal_Code As System.Windows.Forms.Label
    Friend WithEvents TextBox_Postal_Code As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Phone_Country_Code_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Phone_Country_Code_Phone_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Code_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Code_Phone_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Code_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Code_Phone_2 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Phone_Country_Code_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Phone_Country_Code_Phone_2 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Code_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Code_Fax_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Phone_Country_Code_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Phone_Country_Code_Fax_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Code_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Code_Mobile_Phone_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Phone_Country_Code_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Phone_Country_Code_Mobile_Phone_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Mobile_Phone_1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Title As System.Windows.Forms.ComboBox
    Friend WithEvents B_Fill_In_From_File As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Add_New_Client_From_File As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ComboBox_Gender As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_District As System.Windows.Forms.Label
    Friend WithEvents TextBox_District As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Country As System.Windows.Forms.Label
    Friend WithEvents L_Name_Title As System.Windows.Forms.Label
    Friend WithEvents L_Name_Gender As System.Windows.Forms.Label
    Friend WithEvents L_Name_Middle_Name As System.Windows.Forms.Label
End Class
