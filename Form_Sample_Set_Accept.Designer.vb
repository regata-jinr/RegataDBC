<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Sample_Set_Accept
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.B_SaveNewSampleAcceptance = New System.Windows.Forms.Button()
        Me.TextBox_Notes_1 = New System.Windows.Forms.TextBox()
        Me.L_Name_Notes_1 = New System.Windows.Forms.Label()
        Me.L_Name_ReceivedBy = New System.Windows.Forms.Label()
        Me.L_Name_New_Sample_Set_ID = New System.Windows.Forms.Label()
        Me.L_Name_Client_ID = New System.Windows.Forms.Label()
        Me.B_NewClient = New System.Windows.Forms.Button()
        Me.L_Name_Country = New System.Windows.Forms.Label()
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.Table_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_CountryTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_CountryTableAdapter()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox_Country = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Client_ID = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Table_ReceivedBy = New System.Windows.Forms.ComboBox()
        Me.Table_Received_By_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_NSSID_Country_Code = New System.Windows.Forms.Label()
        Me.L_NSSID_Year = New System.Windows.Forms.Label()
        Me.L_NSSID_Client_ID = New System.Windows.Forms.Label()
        Me.L_Country_Code = New System.Windows.Forms.Label()
        Me.L_Organization = New System.Windows.Forms.Label()
        Me.L_First_Name = New System.Windows.Forms.Label()
        Me.L_Last_Name = New System.Windows.Forms.Label()
        Me.L_NSSID_New_Sample_Set_ID = New System.Windows.Forms.Label()
        Me.L_Name_Sample_Set_List = New System.Windows.Forms.Label()
        Me.MaskedTextBox_New_Sample_Set_ID = New System.Windows.Forms.MaskedTextBox()
        Me.Label_Name_Code = New System.Windows.Forms.Label()
        Me.Table_Received_ByTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter()
        Me.MaskedTextBox_Sample_Set_Receipt_Date = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_SampleSetReceiptDate = New System.Windows.Forms.Label()
        Me.MaskedTextBox_Sample_Set_Report_Date = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_SampleSetReportDate = New System.Windows.Forms.Label()
        Me.Table_Sample_SetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_Sample_SetTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter()
        Me.Table_Sample_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sample_Set_Index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_Print_Preview_Form = New System.Windows.Forms.Button()
        Me.L_Republic = New System.Windows.Forms.Label()
        Me.L_City = New System.Windows.Forms.Label()
        Me.L_Street = New System.Windows.Forms.Label()
        Me.L_House = New System.Windows.Forms.Label()
        Me.L_Building = New System.Windows.Forms.Label()
        Me.L_Title = New System.Windows.Forms.Label()
        Me.L_Phone_Country_Code_Phone_1 = New System.Windows.Forms.Label()
        Me.L_E_mail_1 = New System.Windows.Forms.Label()
        Me.L_E_mail_2 = New System.Windows.Forms.Label()
        Me.L_Notes = New System.Windows.Forms.Label()
        Me.L_Postal_Code = New System.Windows.Forms.Label()
        Me.L_Region = New System.Windows.Forms.Label()
        Me.L_Code_Phone_1 = New System.Windows.Forms.Label()
        Me.L_Phone_1 = New System.Windows.Forms.Label()
        Me.L_Phone_2 = New System.Windows.Forms.Label()
        Me.L_Code_Phone_2 = New System.Windows.Forms.Label()
        Me.L_Phone_Country_Code_Phone_2 = New System.Windows.Forms.Label()
        Me.L_Fax_1 = New System.Windows.Forms.Label()
        Me.L_Code_Fax_1 = New System.Windows.Forms.Label()
        Me.L_Phone_Country_Code_Fax_1 = New System.Windows.Forms.Label()
        Me.L_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.L_Code_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.L_Phone_Country_Code_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.B_Fill_Notes_1 = New System.Windows.Forms.Button()
        Me.B_Correct_Client_Info = New System.Windows.Forms.Button()
        Me.MaskedTextBox_New_Sample_Set_Index = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_New_Sample_Set_Index = New System.Windows.Forms.Label()
        Me.L_NSSID_New_Sample_Set_Index = New System.Windows.Forms.Label()
        Me.L_District = New System.Windows.Forms.Label()
        Me.L_Gender = New System.Windows.Forms.Label()
        Me.L_Name_Postal_Code = New System.Windows.Forms.Label()
        Me.L_Name_Republic = New System.Windows.Forms.Label()
        Me.L_Name_Region = New System.Windows.Forms.Label()
        Me.L_Name_District = New System.Windows.Forms.Label()
        Me.L_Name_City = New System.Windows.Forms.Label()
        Me.L_Name_Street = New System.Windows.Forms.Label()
        Me.L_Name_House = New System.Windows.Forms.Label()
        Me.L_Name_Building = New System.Windows.Forms.Label()
        Me.L_Name_Organization = New System.Windows.Forms.Label()
        Me.L_Name_Gender = New System.Windows.Forms.Label()
        Me.L_Name_Last_Name = New System.Windows.Forms.Label()
        Me.L_Name_First_Name = New System.Windows.Forms.Label()
        Me.L_Name_Phone_1 = New System.Windows.Forms.Label()
        Me.L_Name_Phone_2 = New System.Windows.Forms.Label()
        Me.L_Name_Fax_1 = New System.Windows.Forms.Label()
        Me.L_Name_Mobile_Phone_1 = New System.Windows.Forms.Label()
        Me.L_Name_E_mail_1 = New System.Windows.Forms.Label()
        Me.L_Name_E_mail_2 = New System.Windows.Forms.Label()
        Me.L_Name_Notes = New System.Windows.Forms.Label()
        Me.L_Name_Country_Code = New System.Windows.Forms.Label()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_SetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Sample_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(455, 616)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(176, 23)
        Me.B_Close.TabIndex = 70
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'B_SaveNewSampleAcceptance
        '
        Me.B_SaveNewSampleAcceptance.Location = New System.Drawing.Point(93, 616)
        Me.B_SaveNewSampleAcceptance.Name = "B_SaveNewSampleAcceptance"
        Me.B_SaveNewSampleAcceptance.Size = New System.Drawing.Size(174, 23)
        Me.B_SaveNewSampleAcceptance.TabIndex = 69
        Me.B_SaveNewSampleAcceptance.Text = "Save new sample set"
        Me.B_SaveNewSampleAcceptance.UseVisualStyleBackColor = True
        '
        'TextBox_Notes_1
        '
        Me.TextBox_Notes_1.Location = New System.Drawing.Point(12, 449)
        Me.TextBox_Notes_1.MaxLength = 400
        Me.TextBox_Notes_1.Multiline = True
        Me.TextBox_Notes_1.Name = "TextBox_Notes_1"
        Me.TextBox_Notes_1.Size = New System.Drawing.Size(561, 60)
        Me.TextBox_Notes_1.TabIndex = 68
        '
        'L_Name_Notes_1
        '
        Me.L_Name_Notes_1.AutoSize = True
        Me.L_Name_Notes_1.Location = New System.Drawing.Point(279, 433)
        Me.L_Name_Notes_1.Name = "L_Name_Notes_1"
        Me.L_Name_Notes_1.Size = New System.Drawing.Size(35, 13)
        Me.L_Name_Notes_1.TabIndex = 67
        Me.L_Name_Notes_1.Text = "Notes"
        '
        'L_Name_ReceivedBy
        '
        Me.L_Name_ReceivedBy.AutoSize = True
        Me.L_Name_ReceivedBy.Location = New System.Drawing.Point(301, 512)
        Me.L_Name_ReceivedBy.Name = "L_Name_ReceivedBy"
        Me.L_Name_ReceivedBy.Size = New System.Drawing.Size(67, 13)
        Me.L_Name_ReceivedBy.TabIndex = 66
        Me.L_Name_ReceivedBy.Text = "Received by"
        '
        'L_Name_New_Sample_Set_ID
        '
        Me.L_Name_New_Sample_Set_ID.AutoSize = True
        Me.L_Name_New_Sample_Set_ID.Location = New System.Drawing.Point(308, 322)
        Me.L_Name_New_Sample_Set_ID.Name = "L_Name_New_Sample_Set_ID"
        Me.L_Name_New_Sample_Set_ID.Size = New System.Drawing.Size(96, 13)
        Me.L_Name_New_Sample_Set_ID.TabIndex = 52
        Me.L_Name_New_Sample_Set_ID.Text = "New sample set ID"
        '
        'L_Name_Client_ID
        '
        Me.L_Name_Client_ID.AutoSize = True
        Me.L_Name_Client_ID.Location = New System.Drawing.Point(383, 8)
        Me.L_Name_Client_ID.Name = "L_Name_Client_ID"
        Me.L_Name_Client_ID.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Client_ID.TabIndex = 47
        Me.L_Name_Client_ID.Text = "Client ID"
        '
        'B_NewClient
        '
        Me.B_NewClient.Location = New System.Drawing.Point(123, 282)
        Me.B_NewClient.Name = "B_NewClient"
        Me.B_NewClient.Size = New System.Drawing.Size(200, 23)
        Me.B_NewClient.TabIndex = 45
        Me.B_NewClient.Text = "Add new client"
        Me.B_NewClient.UseVisualStyleBackColor = True
        '
        'L_Name_Country
        '
        Me.L_Name_Country.AutoSize = True
        Me.L_Name_Country.Location = New System.Drawing.Point(221, 8)
        Me.L_Name_Country.Name = "L_Name_Country"
        Me.L_Name_Country.Size = New System.Drawing.Size(43, 13)
        Me.L_Name_Country.TabIndex = 43
        Me.L_Name_Country.Text = "Country"
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.table_ClientTableAdapter = Nothing
        Me.TableAdapterManager.table_CountryTableAdapter = Nothing
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
        'ComboBox_Country
        '
        Me.ComboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Country.FormattingEnabled = True
        Me.ComboBox_Country.Location = New System.Drawing.Point(159, 24)
        Me.ComboBox_Country.Name = "ComboBox_Country"
        Me.ComboBox_Country.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox_Country.TabIndex = 71
        '
        'ComboBox_Client_ID
        '
        Me.ComboBox_Client_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Client_ID.Location = New System.Drawing.Point(381, 24)
        Me.ComboBox_Client_ID.Name = "ComboBox_Client_ID"
        Me.ComboBox_Client_ID.Size = New System.Drawing.Size(86, 21)
        Me.ComboBox_Client_ID.Sorted = True
        Me.ComboBox_Client_ID.TabIndex = 112
        '
        'ComboBox_Table_ReceivedBy
        '
        Me.ComboBox_Table_ReceivedBy.DataSource = Me.Table_Received_By_BindingSource
        Me.ComboBox_Table_ReceivedBy.DisplayMember = "Received_By"
        Me.ComboBox_Table_ReceivedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Table_ReceivedBy.FormattingEnabled = True
        Me.ComboBox_Table_ReceivedBy.Location = New System.Drawing.Point(256, 527)
        Me.ComboBox_Table_ReceivedBy.Name = "ComboBox_Table_ReceivedBy"
        Me.ComboBox_Table_ReceivedBy.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox_Table_ReceivedBy.TabIndex = 71
        Me.ComboBox_Table_ReceivedBy.ValueMember = "ReceivedBy"
        '
        'Table_Received_By_BindingSource
        '
        Me.Table_Received_By_BindingSource.DataMember = "table_Received_By"
        Me.Table_Received_By_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'L_NSSID_Country_Code
        '
        Me.L_NSSID_Country_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_NSSID_Country_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table_CountryBindingSource, "Country_Code", True))
        Me.L_NSSID_Country_Code.Location = New System.Drawing.Point(273, 573)
        Me.L_NSSID_Country_Code.Name = "L_NSSID_Country_Code"
        Me.L_NSSID_Country_Code.Size = New System.Drawing.Size(26, 14)
        Me.L_NSSID_Country_Code.TabIndex = 72
        '
        'L_NSSID_Year
        '
        Me.L_NSSID_Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_NSSID_Year.Location = New System.Drawing.Point(335, 573)
        Me.L_NSSID_Year.Name = "L_NSSID_Year"
        Me.L_NSSID_Year.Size = New System.Drawing.Size(24, 14)
        Me.L_NSSID_Year.TabIndex = 74
        '
        'L_NSSID_Client_ID
        '
        Me.L_NSSID_Client_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_NSSID_Client_ID.Location = New System.Drawing.Point(305, 573)
        Me.L_NSSID_Client_ID.Name = "L_NSSID_Client_ID"
        Me.L_NSSID_Client_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_NSSID_Client_ID.TabIndex = 75
        '
        'L_Country_Code
        '
        Me.L_Country_Code.Location = New System.Drawing.Point(135, 58)
        Me.L_Country_Code.Name = "L_Country_Code"
        Me.L_Country_Code.Size = New System.Drawing.Size(137, 13)
        Me.L_Country_Code.TabIndex = 77
        Me.L_Country_Code.Text = "Label"
        '
        'L_Organization
        '
        Me.L_Organization.Location = New System.Drawing.Point(135, 265)
        Me.L_Organization.Name = "L_Organization"
        Me.L_Organization.Size = New System.Drawing.Size(252, 13)
        Me.L_Organization.TabIndex = 80
        Me.L_Organization.Text = "Label"
        '
        'L_First_Name
        '
        Me.L_First_Name.Location = New System.Drawing.Point(508, 103)
        Me.L_First_Name.Name = "L_First_Name"
        Me.L_First_Name.Size = New System.Drawing.Size(137, 13)
        Me.L_First_Name.TabIndex = 81
        Me.L_First_Name.Text = "Label"
        '
        'L_Last_Name
        '
        Me.L_Last_Name.Location = New System.Drawing.Point(508, 80)
        Me.L_Last_Name.Name = "L_Last_Name"
        Me.L_Last_Name.Size = New System.Drawing.Size(137, 13)
        Me.L_Last_Name.TabIndex = 82
        Me.L_Last_Name.Text = "Label"
        '
        'L_NSSID_New_Sample_Set_ID
        '
        Me.L_NSSID_New_Sample_Set_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_NSSID_New_Sample_Set_ID.Location = New System.Drawing.Point(365, 573)
        Me.L_NSSID_New_Sample_Set_ID.Name = "L_NSSID_New_Sample_Set_ID"
        Me.L_NSSID_New_Sample_Set_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_NSSID_New_Sample_Set_ID.TabIndex = 87
        '
        'L_Name_Sample_Set_List
        '
        Me.L_Name_Sample_Set_List.AutoSize = True
        Me.L_Name_Sample_Set_List.Location = New System.Drawing.Point(83, 306)
        Me.L_Name_Sample_Set_List.Name = "L_Name_Sample_Set_List"
        Me.L_Name_Sample_Set_List.Size = New System.Drawing.Size(74, 13)
        Me.L_Name_Sample_Set_List.TabIndex = 89
        Me.L_Name_Sample_Set_List.Text = "Sample set list"
        '
        'MaskedTextBox_New_Sample_Set_ID
        '
        Me.MaskedTextBox_New_Sample_Set_ID.Location = New System.Drawing.Point(338, 338)
        Me.MaskedTextBox_New_Sample_Set_ID.Mask = "00"
        Me.MaskedTextBox_New_Sample_Set_ID.Name = "MaskedTextBox_New_Sample_Set_ID"
        Me.MaskedTextBox_New_Sample_Set_ID.Size = New System.Drawing.Size(25, 20)
        Me.MaskedTextBox_New_Sample_Set_ID.TabIndex = 90
        '
        'Label_Name_Code
        '
        Me.Label_Name_Code.AutoSize = True
        Me.Label_Name_Code.Location = New System.Drawing.Point(253, 560)
        Me.Label_Name_Code.Name = "Label_Name_Code"
        Me.Label_Name_Code.Size = New System.Drawing.Size(177, 13)
        Me.Label_Name_Code.TabIndex = 91
        Me.Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
        '
        'Table_Received_ByTableAdapter
        '
        Me.Table_Received_ByTableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox_Sample_Set_Receipt_Date
        '
        Me.MaskedTextBox_Sample_Set_Receipt_Date.Location = New System.Drawing.Point(491, 338)
        Me.MaskedTextBox_Sample_Set_Receipt_Date.Mask = "00/00/0000"
        Me.MaskedTextBox_Sample_Set_Receipt_Date.Name = "MaskedTextBox_Sample_Set_Receipt_Date"
        Me.MaskedTextBox_Sample_Set_Receipt_Date.Size = New System.Drawing.Size(62, 20)
        Me.MaskedTextBox_Sample_Set_Receipt_Date.TabIndex = 98
        Me.MaskedTextBox_Sample_Set_Receipt_Date.ValidatingType = GetType(Date)
        '
        'L_Name_SampleSetReceiptDate
        '
        Me.L_Name_SampleSetReceiptDate.AutoSize = True
        Me.L_Name_SampleSetReceiptDate.Location = New System.Drawing.Point(462, 322)
        Me.L_Name_SampleSetReceiptDate.Name = "L_Name_SampleSetReceiptDate"
        Me.L_Name_SampleSetReceiptDate.Size = New System.Drawing.Size(143, 13)
        Me.L_Name_SampleSetReceiptDate.TabIndex = 97
        Me.L_Name_SampleSetReceiptDate.Text = "Sample set acceptance date"
        '
        'MaskedTextBox_Sample_Set_Report_Date
        '
        Me.MaskedTextBox_Sample_Set_Report_Date.Location = New System.Drawing.Point(491, 389)
        Me.MaskedTextBox_Sample_Set_Report_Date.Mask = "00/00/0000"
        Me.MaskedTextBox_Sample_Set_Report_Date.Name = "MaskedTextBox_Sample_Set_Report_Date"
        Me.MaskedTextBox_Sample_Set_Report_Date.Size = New System.Drawing.Size(60, 20)
        Me.MaskedTextBox_Sample_Set_Report_Date.TabIndex = 111
        Me.MaskedTextBox_Sample_Set_Report_Date.ValidatingType = GetType(Date)
        '
        'L_Name_SampleSetReportDate
        '
        Me.L_Name_SampleSetReportDate.AutoSize = True
        Me.L_Name_SampleSetReportDate.Location = New System.Drawing.Point(468, 373)
        Me.L_Name_SampleSetReportDate.Name = "L_Name_SampleSetReportDate"
        Me.L_Name_SampleSetReportDate.Size = New System.Drawing.Size(113, 13)
        Me.L_Name_SampleSetReportDate.TabIndex = 110
        Me.L_Name_SampleSetReportDate.Text = "Sample set report date"
        '
        'Table_Sample_SetBindingSource
        '
        Me.Table_Sample_SetBindingSource.DataMember = "table_Sample_Set"
        Me.Table_Sample_SetBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_Sample_SetTableAdapter
        '
        Me.Table_Sample_SetTableAdapter.ClearBeforeFill = True
        '
        'Table_Sample_SetDataGridView
        '
        Me.Table_Sample_SetDataGridView.AllowUserToAddRows = False
        Me.Table_Sample_SetDataGridView.AllowUserToDeleteRows = False
        Me.Table_Sample_SetDataGridView.AllowUserToResizeColumns = False
        Me.Table_Sample_SetDataGridView.AllowUserToResizeRows = False
        Me.Table_Sample_SetDataGridView.AutoGenerateColumns = False
        Me.Table_Sample_SetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Sample_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table_Sample_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Sample_SetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Sample_Set_Index})
        Me.Table_Sample_SetDataGridView.DataSource = Me.Table_Sample_SetBindingSource
        Me.Table_Sample_SetDataGridView.Location = New System.Drawing.Point(12, 322)
        Me.Table_Sample_SetDataGridView.MultiSelect = False
        Me.Table_Sample_SetDataGridView.Name = "Table_Sample_SetDataGridView"
        Me.Table_Sample_SetDataGridView.ReadOnly = True
        Me.Table_Sample_SetDataGridView.RowHeadersVisible = False
        Me.Table_Sample_SetDataGridView.RowHeadersWidth = 21
        Me.Table_Sample_SetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_Sample_SetDataGridView.Size = New System.Drawing.Size(252, 102)
        Me.Table_Sample_SetDataGridView.TabIndex = 112
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Year"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sample_Set_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sample set ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Sample_Set_Index
        '
        Me.Sample_Set_Index.DataPropertyName = "Sample_Set_Index"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sample_Set_Index.DefaultCellStyle = DataGridViewCellStyle2
        Me.Sample_Set_Index.HeaderText = "Sample set index"
        Me.Sample_Set_Index.Name = "Sample_Set_Index"
        Me.Sample_Set_Index.ReadOnly = True
        '
        'B_Print_Preview_Form
        '
        Me.B_Print_Preview_Form.Location = New System.Drawing.Point(273, 616)
        Me.B_Print_Preview_Form.Name = "B_Print_Preview_Form"
        Me.B_Print_Preview_Form.Size = New System.Drawing.Size(176, 23)
        Me.B_Print_Preview_Form.TabIndex = 113
        Me.B_Print_Preview_Form.Text = "Form for printing"
        Me.B_Print_Preview_Form.UseVisualStyleBackColor = True
        '
        'L_Republic
        '
        Me.L_Republic.Location = New System.Drawing.Point(135, 104)
        Me.L_Republic.Name = "L_Republic"
        Me.L_Republic.Size = New System.Drawing.Size(137, 13)
        Me.L_Republic.TabIndex = 116
        Me.L_Republic.Text = "Label"
        '
        'L_City
        '
        Me.L_City.Location = New System.Drawing.Point(135, 172)
        Me.L_City.Name = "L_City"
        Me.L_City.Size = New System.Drawing.Size(137, 13)
        Me.L_City.TabIndex = 118
        Me.L_City.Text = "Label"
        '
        'L_Street
        '
        Me.L_Street.Location = New System.Drawing.Point(135, 194)
        Me.L_Street.Name = "L_Street"
        Me.L_Street.Size = New System.Drawing.Size(137, 13)
        Me.L_Street.TabIndex = 120
        Me.L_Street.Text = "Label"
        '
        'L_House
        '
        Me.L_House.Location = New System.Drawing.Point(135, 218)
        Me.L_House.Name = "L_House"
        Me.L_House.Size = New System.Drawing.Size(137, 13)
        Me.L_House.TabIndex = 122
        Me.L_House.Text = "Label"
        '
        'L_Building
        '
        Me.L_Building.Location = New System.Drawing.Point(135, 241)
        Me.L_Building.Name = "L_Building"
        Me.L_Building.Size = New System.Drawing.Size(137, 13)
        Me.L_Building.TabIndex = 124
        Me.L_Building.Text = "Label"
        '
        'L_Title
        '
        Me.L_Title.Location = New System.Drawing.Point(468, 80)
        Me.L_Title.Name = "L_Title"
        Me.L_Title.Size = New System.Drawing.Size(30, 13)
        Me.L_Title.TabIndex = 125
        Me.L_Title.Text = "Label"
        '
        'L_Phone_Country_Code_Phone_1
        '
        Me.L_Phone_Country_Code_Phone_1.Location = New System.Drawing.Point(468, 126)
        Me.L_Phone_Country_Code_Phone_1.Name = "L_Phone_Country_Code_Phone_1"
        Me.L_Phone_Country_Code_Phone_1.Size = New System.Drawing.Size(30, 13)
        Me.L_Phone_Country_Code_Phone_1.TabIndex = 127
        Me.L_Phone_Country_Code_Phone_1.Text = "Label"
        '
        'L_E_mail_1
        '
        Me.L_E_mail_1.Location = New System.Drawing.Point(468, 218)
        Me.L_E_mail_1.Name = "L_E_mail_1"
        Me.L_E_mail_1.Size = New System.Drawing.Size(137, 13)
        Me.L_E_mail_1.TabIndex = 141
        Me.L_E_mail_1.Text = "Label"
        '
        'L_E_mail_2
        '
        Me.L_E_mail_2.Location = New System.Drawing.Point(468, 241)
        Me.L_E_mail_2.Name = "L_E_mail_2"
        Me.L_E_mail_2.Size = New System.Drawing.Size(137, 13)
        Me.L_E_mail_2.TabIndex = 143
        Me.L_E_mail_2.Text = "Label"
        '
        'L_Notes
        '
        Me.L_Notes.Location = New System.Drawing.Point(468, 265)
        Me.L_Notes.Name = "L_Notes"
        Me.L_Notes.Size = New System.Drawing.Size(137, 13)
        Me.L_Notes.TabIndex = 129
        Me.L_Notes.Text = "Label"
        '
        'L_Postal_Code
        '
        Me.L_Postal_Code.Location = New System.Drawing.Point(135, 81)
        Me.L_Postal_Code.Name = "L_Postal_Code"
        Me.L_Postal_Code.Size = New System.Drawing.Size(137, 13)
        Me.L_Postal_Code.TabIndex = 145
        Me.L_Postal_Code.Text = "Label"
        '
        'L_Region
        '
        Me.L_Region.Location = New System.Drawing.Point(135, 126)
        Me.L_Region.Name = "L_Region"
        Me.L_Region.Size = New System.Drawing.Size(137, 13)
        Me.L_Region.TabIndex = 147
        Me.L_Region.Text = "Label"
        '
        'L_Code_Phone_1
        '
        Me.L_Code_Phone_1.Location = New System.Drawing.Point(504, 126)
        Me.L_Code_Phone_1.Name = "L_Code_Phone_1"
        Me.L_Code_Phone_1.Size = New System.Drawing.Size(30, 13)
        Me.L_Code_Phone_1.TabIndex = 148
        Me.L_Code_Phone_1.Text = "Label"
        '
        'L_Phone_1
        '
        Me.L_Phone_1.Location = New System.Drawing.Point(540, 126)
        Me.L_Phone_1.Name = "L_Phone_1"
        Me.L_Phone_1.Size = New System.Drawing.Size(65, 13)
        Me.L_Phone_1.TabIndex = 149
        Me.L_Phone_1.Text = "Label"
        '
        'L_Phone_2
        '
        Me.L_Phone_2.Location = New System.Drawing.Point(540, 149)
        Me.L_Phone_2.Name = "L_Phone_2"
        Me.L_Phone_2.Size = New System.Drawing.Size(65, 13)
        Me.L_Phone_2.TabIndex = 152
        Me.L_Phone_2.Text = "Label"
        '
        'L_Code_Phone_2
        '
        Me.L_Code_Phone_2.Location = New System.Drawing.Point(504, 149)
        Me.L_Code_Phone_2.Name = "L_Code_Phone_2"
        Me.L_Code_Phone_2.Size = New System.Drawing.Size(30, 13)
        Me.L_Code_Phone_2.TabIndex = 151
        Me.L_Code_Phone_2.Text = "Label"
        '
        'L_Phone_Country_Code_Phone_2
        '
        Me.L_Phone_Country_Code_Phone_2.Location = New System.Drawing.Point(468, 149)
        Me.L_Phone_Country_Code_Phone_2.Name = "L_Phone_Country_Code_Phone_2"
        Me.L_Phone_Country_Code_Phone_2.Size = New System.Drawing.Size(30, 13)
        Me.L_Phone_Country_Code_Phone_2.TabIndex = 150
        Me.L_Phone_Country_Code_Phone_2.Text = "Label"
        '
        'L_Fax_1
        '
        Me.L_Fax_1.Location = New System.Drawing.Point(540, 172)
        Me.L_Fax_1.Name = "L_Fax_1"
        Me.L_Fax_1.Size = New System.Drawing.Size(65, 13)
        Me.L_Fax_1.TabIndex = 155
        Me.L_Fax_1.Text = "Label"
        '
        'L_Code_Fax_1
        '
        Me.L_Code_Fax_1.Location = New System.Drawing.Point(504, 172)
        Me.L_Code_Fax_1.Name = "L_Code_Fax_1"
        Me.L_Code_Fax_1.Size = New System.Drawing.Size(30, 13)
        Me.L_Code_Fax_1.TabIndex = 154
        Me.L_Code_Fax_1.Text = "Label"
        '
        'L_Phone_Country_Code_Fax_1
        '
        Me.L_Phone_Country_Code_Fax_1.Location = New System.Drawing.Point(468, 172)
        Me.L_Phone_Country_Code_Fax_1.Name = "L_Phone_Country_Code_Fax_1"
        Me.L_Phone_Country_Code_Fax_1.Size = New System.Drawing.Size(30, 13)
        Me.L_Phone_Country_Code_Fax_1.TabIndex = 153
        Me.L_Phone_Country_Code_Fax_1.Text = "Label"
        '
        'L_Mobile_Phone_1
        '
        Me.L_Mobile_Phone_1.Location = New System.Drawing.Point(540, 194)
        Me.L_Mobile_Phone_1.Name = "L_Mobile_Phone_1"
        Me.L_Mobile_Phone_1.Size = New System.Drawing.Size(65, 13)
        Me.L_Mobile_Phone_1.TabIndex = 158
        Me.L_Mobile_Phone_1.Text = "Label"
        '
        'L_Code_Mobile_Phone_1
        '
        Me.L_Code_Mobile_Phone_1.Location = New System.Drawing.Point(504, 194)
        Me.L_Code_Mobile_Phone_1.Name = "L_Code_Mobile_Phone_1"
        Me.L_Code_Mobile_Phone_1.Size = New System.Drawing.Size(30, 13)
        Me.L_Code_Mobile_Phone_1.TabIndex = 157
        Me.L_Code_Mobile_Phone_1.Text = "Label"
        '
        'L_Phone_Country_Code_Mobile_Phone_1
        '
        Me.L_Phone_Country_Code_Mobile_Phone_1.Location = New System.Drawing.Point(468, 194)
        Me.L_Phone_Country_Code_Mobile_Phone_1.Name = "L_Phone_Country_Code_Mobile_Phone_1"
        Me.L_Phone_Country_Code_Mobile_Phone_1.Size = New System.Drawing.Size(30, 13)
        Me.L_Phone_Country_Code_Mobile_Phone_1.TabIndex = 156
        Me.L_Phone_Country_Code_Mobile_Phone_1.Text = "Label"
        '
        'B_Fill_Notes_1
        '
        Me.B_Fill_Notes_1.Location = New System.Drawing.Point(579, 449)
        Me.B_Fill_Notes_1.Name = "B_Fill_Notes_1"
        Me.B_Fill_Notes_1.Size = New System.Drawing.Size(97, 60)
        Me.B_Fill_Notes_1.TabIndex = 159
        Me.B_Fill_Notes_1.Text = "Quick fill in notes"
        Me.B_Fill_Notes_1.UseVisualStyleBackColor = True
        '
        'B_Correct_Client_Info
        '
        Me.B_Correct_Client_Info.Location = New System.Drawing.Point(350, 282)
        Me.B_Correct_Client_Info.Name = "B_Correct_Client_Info"
        Me.B_Correct_Client_Info.Size = New System.Drawing.Size(201, 23)
        Me.B_Correct_Client_Info.TabIndex = 166
        Me.B_Correct_Client_Info.Text = "Change client info"
        Me.B_Correct_Client_Info.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_New_Sample_Set_Index
        '
        Me.MaskedTextBox_New_Sample_Set_Index.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox_New_Sample_Set_Index.Location = New System.Drawing.Point(338, 389)
        Me.MaskedTextBox_New_Sample_Set_Index.Mask = "L"
        Me.MaskedTextBox_New_Sample_Set_Index.Name = "MaskedTextBox_New_Sample_Set_Index"
        Me.MaskedTextBox_New_Sample_Set_Index.Size = New System.Drawing.Size(18, 20)
        Me.MaskedTextBox_New_Sample_Set_Index.TabIndex = 168
        '
        'L_Name_New_Sample_Set_Index
        '
        Me.L_Name_New_Sample_Set_Index.AutoSize = True
        Me.L_Name_New_Sample_Set_Index.Location = New System.Drawing.Point(301, 373)
        Me.L_Name_New_Sample_Set_Index.Name = "L_Name_New_Sample_Set_Index"
        Me.L_Name_New_Sample_Set_Index.Size = New System.Drawing.Size(110, 13)
        Me.L_Name_New_Sample_Set_Index.TabIndex = 167
        Me.L_Name_New_Sample_Set_Index.Text = "New sample set index"
        '
        'L_NSSID_New_Sample_Set_Index
        '
        Me.L_NSSID_New_Sample_Set_Index.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_NSSID_New_Sample_Set_Index.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_NSSID_New_Sample_Set_Index.Location = New System.Drawing.Point(395, 573)
        Me.L_NSSID_New_Sample_Set_Index.Name = "L_NSSID_New_Sample_Set_Index"
        Me.L_NSSID_New_Sample_Set_Index.Size = New System.Drawing.Size(24, 22)
        Me.L_NSSID_New_Sample_Set_Index.TabIndex = 170
        '
        'L_District
        '
        Me.L_District.Location = New System.Drawing.Point(135, 150)
        Me.L_District.Name = "L_District"
        Me.L_District.Size = New System.Drawing.Size(137, 13)
        Me.L_District.TabIndex = 172
        Me.L_District.Text = "Label"
        '
        'L_Gender
        '
        Me.L_Gender.Location = New System.Drawing.Point(468, 58)
        Me.L_Gender.Name = "L_Gender"
        Me.L_Gender.Size = New System.Drawing.Size(30, 13)
        Me.L_Gender.TabIndex = 174
        Me.L_Gender.Text = "Label"
        '
        'L_Name_Postal_Code
        '
        Me.L_Name_Postal_Code.AutoSize = True
        Me.L_Name_Postal_Code.Location = New System.Drawing.Point(19, 81)
        Me.L_Name_Postal_Code.Name = "L_Name_Postal_Code"
        Me.L_Name_Postal_Code.Size = New System.Drawing.Size(66, 13)
        Me.L_Name_Postal_Code.TabIndex = 175
        Me.L_Name_Postal_Code.Text = "Postal code:"
        '
        'L_Name_Republic
        '
        Me.L_Name_Republic.AutoSize = True
        Me.L_Name_Republic.Location = New System.Drawing.Point(19, 104)
        Me.L_Name_Republic.Name = "L_Name_Republic"
        Me.L_Name_Republic.Size = New System.Drawing.Size(52, 13)
        Me.L_Name_Republic.TabIndex = 176
        Me.L_Name_Republic.Text = "Republic:"
        '
        'L_Name_Region
        '
        Me.L_Name_Region.AutoSize = True
        Me.L_Name_Region.Location = New System.Drawing.Point(19, 126)
        Me.L_Name_Region.Name = "L_Name_Region"
        Me.L_Name_Region.Size = New System.Drawing.Size(44, 13)
        Me.L_Name_Region.TabIndex = 177
        Me.L_Name_Region.Text = "Region:"
        '
        'L_Name_District
        '
        Me.L_Name_District.AutoSize = True
        Me.L_Name_District.Location = New System.Drawing.Point(19, 150)
        Me.L_Name_District.Name = "L_Name_District"
        Me.L_Name_District.Size = New System.Drawing.Size(42, 13)
        Me.L_Name_District.TabIndex = 178
        Me.L_Name_District.Text = "District:"
        '
        'L_Name_City
        '
        Me.L_Name_City.AutoSize = True
        Me.L_Name_City.Location = New System.Drawing.Point(19, 172)
        Me.L_Name_City.Name = "L_Name_City"
        Me.L_Name_City.Size = New System.Drawing.Size(27, 13)
        Me.L_Name_City.TabIndex = 179
        Me.L_Name_City.Text = "City:"
        '
        'L_Name_Street
        '
        Me.L_Name_Street.AutoSize = True
        Me.L_Name_Street.Location = New System.Drawing.Point(19, 194)
        Me.L_Name_Street.Name = "L_Name_Street"
        Me.L_Name_Street.Size = New System.Drawing.Size(38, 13)
        Me.L_Name_Street.TabIndex = 180
        Me.L_Name_Street.Text = "Street:"
        '
        'L_Name_House
        '
        Me.L_Name_House.AutoSize = True
        Me.L_Name_House.Location = New System.Drawing.Point(19, 218)
        Me.L_Name_House.Name = "L_Name_House"
        Me.L_Name_House.Size = New System.Drawing.Size(41, 13)
        Me.L_Name_House.TabIndex = 181
        Me.L_Name_House.Text = "House:"
        '
        'L_Name_Building
        '
        Me.L_Name_Building.AutoSize = True
        Me.L_Name_Building.Location = New System.Drawing.Point(19, 241)
        Me.L_Name_Building.Name = "L_Name_Building"
        Me.L_Name_Building.Size = New System.Drawing.Size(47, 13)
        Me.L_Name_Building.TabIndex = 182
        Me.L_Name_Building.Text = "Building:"
        '
        'L_Name_Organization
        '
        Me.L_Name_Organization.AutoSize = True
        Me.L_Name_Organization.Location = New System.Drawing.Point(19, 265)
        Me.L_Name_Organization.Name = "L_Name_Organization"
        Me.L_Name_Organization.Size = New System.Drawing.Size(69, 13)
        Me.L_Name_Organization.TabIndex = 183
        Me.L_Name_Organization.Text = "Organization:"
        '
        'L_Name_Gender
        '
        Me.L_Name_Gender.AutoSize = True
        Me.L_Name_Gender.Location = New System.Drawing.Point(392, 58)
        Me.L_Name_Gender.Name = "L_Name_Gender"
        Me.L_Name_Gender.Size = New System.Drawing.Size(45, 13)
        Me.L_Name_Gender.TabIndex = 184
        Me.L_Name_Gender.Text = "Gender:"
        '
        'L_Name_Last_Name
        '
        Me.L_Name_Last_Name.AutoSize = True
        Me.L_Name_Last_Name.Location = New System.Drawing.Point(392, 80)
        Me.L_Name_Last_Name.Name = "L_Name_Last_Name"
        Me.L_Name_Last_Name.Size = New System.Drawing.Size(59, 13)
        Me.L_Name_Last_Name.TabIndex = 185
        Me.L_Name_Last_Name.Text = "Last name:"
        '
        'L_Name_First_Name
        '
        Me.L_Name_First_Name.AutoSize = True
        Me.L_Name_First_Name.Location = New System.Drawing.Point(392, 103)
        Me.L_Name_First_Name.Name = "L_Name_First_Name"
        Me.L_Name_First_Name.Size = New System.Drawing.Size(58, 13)
        Me.L_Name_First_Name.TabIndex = 186
        Me.L_Name_First_Name.Text = "First name:"
        '
        'L_Name_Phone_1
        '
        Me.L_Name_Phone_1.AutoSize = True
        Me.L_Name_Phone_1.Location = New System.Drawing.Point(392, 126)
        Me.L_Name_Phone_1.Name = "L_Name_Phone_1"
        Me.L_Name_Phone_1.Size = New System.Drawing.Size(50, 13)
        Me.L_Name_Phone_1.TabIndex = 187
        Me.L_Name_Phone_1.Text = "Phone 1:"
        '
        'L_Name_Phone_2
        '
        Me.L_Name_Phone_2.AutoSize = True
        Me.L_Name_Phone_2.Location = New System.Drawing.Point(392, 149)
        Me.L_Name_Phone_2.Name = "L_Name_Phone_2"
        Me.L_Name_Phone_2.Size = New System.Drawing.Size(50, 13)
        Me.L_Name_Phone_2.TabIndex = 188
        Me.L_Name_Phone_2.Text = "Phone 2:"
        '
        'L_Name_Fax_1
        '
        Me.L_Name_Fax_1.AutoSize = True
        Me.L_Name_Fax_1.Location = New System.Drawing.Point(392, 172)
        Me.L_Name_Fax_1.Name = "L_Name_Fax_1"
        Me.L_Name_Fax_1.Size = New System.Drawing.Size(36, 13)
        Me.L_Name_Fax_1.TabIndex = 189
        Me.L_Name_Fax_1.Text = "Fax 1:"
        '
        'L_Name_Mobile_Phone_1
        '
        Me.L_Name_Mobile_Phone_1.AutoSize = True
        Me.L_Name_Mobile_Phone_1.Location = New System.Drawing.Point(392, 194)
        Me.L_Name_Mobile_Phone_1.Name = "L_Name_Mobile_Phone_1"
        Me.L_Name_Mobile_Phone_1.Size = New System.Drawing.Size(76, 13)
        Me.L_Name_Mobile_Phone_1.TabIndex = 190
        Me.L_Name_Mobile_Phone_1.Text = "Mob. phone 1:"
        '
        'L_Name_E_mail_1
        '
        Me.L_Name_E_mail_1.AutoSize = True
        Me.L_Name_E_mail_1.Location = New System.Drawing.Point(392, 218)
        Me.L_Name_E_mail_1.Name = "L_Name_E_mail_1"
        Me.L_Name_E_mail_1.Size = New System.Drawing.Size(46, 13)
        Me.L_Name_E_mail_1.TabIndex = 191
        Me.L_Name_E_mail_1.Text = "e-mail 1:"
        '
        'L_Name_E_mail_2
        '
        Me.L_Name_E_mail_2.AutoSize = True
        Me.L_Name_E_mail_2.Location = New System.Drawing.Point(392, 241)
        Me.L_Name_E_mail_2.Name = "L_Name_E_mail_2"
        Me.L_Name_E_mail_2.Size = New System.Drawing.Size(46, 13)
        Me.L_Name_E_mail_2.TabIndex = 192
        Me.L_Name_E_mail_2.Text = "e-mail 2:"
        '
        'L_Name_Notes
        '
        Me.L_Name_Notes.AutoSize = True
        Me.L_Name_Notes.Location = New System.Drawing.Point(392, 265)
        Me.L_Name_Notes.Name = "L_Name_Notes"
        Me.L_Name_Notes.Size = New System.Drawing.Size(38, 13)
        Me.L_Name_Notes.TabIndex = 193
        Me.L_Name_Notes.Text = "Notes:"
        '
        'L_Name_Country_Code
        '
        Me.L_Name_Country_Code.AutoSize = True
        Me.L_Name_Country_Code.Location = New System.Drawing.Point(19, 58)
        Me.L_Name_Country_Code.Name = "L_Name_Country_Code"
        Me.L_Name_Country_Code.Size = New System.Drawing.Size(73, 13)
        Me.L_Name_Country_Code.TabIndex = 194
        Me.L_Name_Country_Code.Text = "Country code:"
        '
        'Form_Sample_Set_Accept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 642)
        Me.Controls.Add(Me.L_Name_Country_Code)
        Me.Controls.Add(Me.L_Name_Notes)
        Me.Controls.Add(Me.L_Name_E_mail_2)
        Me.Controls.Add(Me.L_Name_E_mail_1)
        Me.Controls.Add(Me.L_Name_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Name_Fax_1)
        Me.Controls.Add(Me.L_Name_Phone_2)
        Me.Controls.Add(Me.L_Name_Phone_1)
        Me.Controls.Add(Me.L_Name_First_Name)
        Me.Controls.Add(Me.L_Name_Last_Name)
        Me.Controls.Add(Me.L_Name_Gender)
        Me.Controls.Add(Me.L_Name_Organization)
        Me.Controls.Add(Me.L_Name_Building)
        Me.Controls.Add(Me.L_Name_House)
        Me.Controls.Add(Me.L_Name_Street)
        Me.Controls.Add(Me.L_Name_City)
        Me.Controls.Add(Me.L_Name_District)
        Me.Controls.Add(Me.L_Name_Region)
        Me.Controls.Add(Me.L_Name_Republic)
        Me.Controls.Add(Me.L_Name_Postal_Code)
        Me.Controls.Add(Me.L_Gender)
        Me.Controls.Add(Me.L_District)
        Me.Controls.Add(Me.L_NSSID_New_Sample_Set_Index)
        Me.Controls.Add(Me.MaskedTextBox_New_Sample_Set_Index)
        Me.Controls.Add(Me.L_Name_New_Sample_Set_Index)
        Me.Controls.Add(Me.B_Correct_Client_Info)
        Me.Controls.Add(Me.B_Fill_Notes_1)
        Me.Controls.Add(Me.L_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Code_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Phone_Country_Code_Mobile_Phone_1)
        Me.Controls.Add(Me.L_Fax_1)
        Me.Controls.Add(Me.L_Code_Fax_1)
        Me.Controls.Add(Me.L_Phone_Country_Code_Fax_1)
        Me.Controls.Add(Me.L_Phone_2)
        Me.Controls.Add(Me.L_Code_Phone_2)
        Me.Controls.Add(Me.L_Phone_Country_Code_Phone_2)
        Me.Controls.Add(Me.L_Phone_1)
        Me.Controls.Add(Me.L_Code_Phone_1)
        Me.Controls.Add(Me.L_Region)
        Me.Controls.Add(Me.L_Postal_Code)
        Me.Controls.Add(Me.L_Phone_Country_Code_Phone_1)
        Me.Controls.Add(Me.L_E_mail_1)
        Me.Controls.Add(Me.L_E_mail_2)
        Me.Controls.Add(Me.L_Notes)
        Me.Controls.Add(Me.L_Title)
        Me.Controls.Add(Me.L_City)
        Me.Controls.Add(Me.B_Print_Preview_Form)
        Me.Controls.Add(Me.L_Country_Code)
        Me.Controls.Add(Me.L_Republic)
        Me.Controls.Add(Me.Table_Sample_SetDataGridView)
        Me.Controls.Add(Me.L_Street)
        Me.Controls.Add(Me.MaskedTextBox_Sample_Set_Report_Date)
        Me.Controls.Add(Me.L_House)
        Me.Controls.Add(Me.ComboBox_Country)
        Me.Controls.Add(Me.L_Building)
        Me.Controls.Add(Me.ComboBox_Client_ID)
        Me.Controls.Add(Me.L_Name_SampleSetReportDate)
        Me.Controls.Add(Me.L_Name_Client_ID)
        Me.Controls.Add(Me.MaskedTextBox_Sample_Set_Receipt_Date)
        Me.Controls.Add(Me.L_Organization)
        Me.Controls.Add(Me.L_Name_SampleSetReceiptDate)
        Me.Controls.Add(Me.L_Last_Name)
        Me.Controls.Add(Me.Label_Name_Code)
        Me.Controls.Add(Me.MaskedTextBox_New_Sample_Set_ID)
        Me.Controls.Add(Me.L_First_Name)
        Me.Controls.Add(Me.L_Name_Sample_Set_List)
        Me.Controls.Add(Me.L_NSSID_New_Sample_Set_ID)
        Me.Controls.Add(Me.L_NSSID_Client_ID)
        Me.Controls.Add(Me.L_NSSID_Year)
        Me.Controls.Add(Me.L_NSSID_Country_Code)
        Me.Controls.Add(Me.ComboBox_Table_ReceivedBy)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_SaveNewSampleAcceptance)
        Me.Controls.Add(Me.TextBox_Notes_1)
        Me.Controls.Add(Me.L_Name_Notes_1)
        Me.Controls.Add(Me.L_Name_Country)
        Me.Controls.Add(Me.L_Name_ReceivedBy)
        Me.Controls.Add(Me.L_Name_New_Sample_Set_ID)
        Me.Controls.Add(Me.B_NewClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Sample_Set_Accept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Sample Set Acceptance"
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Received_By_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_SetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Sample_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents B_SaveNewSampleAcceptance As System.Windows.Forms.Button
    Friend WithEvents TextBox_Notes_1 As System.Windows.Forms.TextBox
    Friend WithEvents L_Name_Notes_1 As System.Windows.Forms.Label
    Friend WithEvents L_Name_ReceivedBy As System.Windows.Forms.Label
    Friend WithEvents L_Name_New_Sample_Set_ID As System.Windows.Forms.Label
    Friend WithEvents L_Name_Client_ID As System.Windows.Forms.Label
    Friend WithEvents B_NewClient As System.Windows.Forms.Button
    Friend WithEvents L_Name_Country As System.Windows.Forms.Label
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_CountryTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_CountryTableAdapter
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox_Country As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Client_ID As System.Windows.Forms.ComboBox
    'Friend WithEvents Table_SamplePreparationTableAdapter As WindowsApplication1.NAA_DB_EXPDataSetTableAdapters.table_SamplePreparationTableAdapter
    Friend WithEvents ComboBox_Table_ReceivedBy As System.Windows.Forms.ComboBox
    Friend WithEvents L_NSSID_Country_Code As System.Windows.Forms.Label
    Friend WithEvents L_NSSID_Year As System.Windows.Forms.Label
    Friend WithEvents L_NSSID_Client_ID As System.Windows.Forms.Label
    Friend WithEvents L_Country_Code As System.Windows.Forms.Label
    Friend WithEvents L_Organization As System.Windows.Forms.Label
    Friend WithEvents L_First_Name As System.Windows.Forms.Label
    Friend WithEvents L_Last_Name As System.Windows.Forms.Label
    Friend WithEvents L_NSSID_New_Sample_Set_ID As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample_Set_List As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_New_Sample_Set_ID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_Name_Code As System.Windows.Forms.Label
    Friend WithEvents Table_Received_ByTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter
    Friend WithEvents MaskedTextBox_Sample_Set_Receipt_Date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_SampleSetReceiptDate As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_Sample_Set_Report_Date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_SampleSetReportDate As System.Windows.Forms.Label
    Friend WithEvents Table_Sample_SetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Sample_SetTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_SetTableAdapter
    Friend WithEvents Table_Sample_SetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Table_Received_By_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents B_Print_Preview_Form As System.Windows.Forms.Button

    Friend WithEvents L_Republic As System.Windows.Forms.Label
    Friend WithEvents L_Title As System.Windows.Forms.Label
    Friend WithEvents L_Building As System.Windows.Forms.Label
    Friend WithEvents L_House As System.Windows.Forms.Label
    Friend WithEvents L_Street As System.Windows.Forms.Label
    Friend WithEvents L_City As System.Windows.Forms.Label
    Friend WithEvents L_Phone_Country_Code_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_E_mail_1 As System.Windows.Forms.Label
    Friend WithEvents L_E_mail_2 As System.Windows.Forms.Label
    Friend WithEvents L_Notes As System.Windows.Forms.Label
    Friend WithEvents L_Region As System.Windows.Forms.Label
    Friend WithEvents L_Postal_Code As System.Windows.Forms.Label
    Friend WithEvents L_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents L_Code_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents L_Phone_Country_Code_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents L_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents L_Code_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents L_Phone_Country_Code_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents L_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_Code_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_Code_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_Phone_Country_Code_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents B_Fill_Notes_1 As System.Windows.Forms.Button
    Friend WithEvents B_Correct_Client_Info As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_New_Sample_Set_Index As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_New_Sample_Set_Index As System.Windows.Forms.Label
    Friend WithEvents L_NSSID_New_Sample_Set_Index As System.Windows.Forms.Label
    Friend WithEvents L_District As System.Windows.Forms.Label
    Friend WithEvents L_Gender As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Set_Index As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L_Name_Postal_Code As System.Windows.Forms.Label
    Friend WithEvents L_Name_Republic As System.Windows.Forms.Label
    Friend WithEvents L_Name_Region As System.Windows.Forms.Label
    Friend WithEvents L_Name_District As System.Windows.Forms.Label
    Friend WithEvents L_Name_City As System.Windows.Forms.Label
    Friend WithEvents L_Name_Street As System.Windows.Forms.Label
    Friend WithEvents L_Name_House As System.Windows.Forms.Label
    Friend WithEvents L_Name_Building As System.Windows.Forms.Label
    Friend WithEvents L_Name_Organization As System.Windows.Forms.Label
    Friend WithEvents L_Name_Gender As System.Windows.Forms.Label
    Friend WithEvents L_Name_Last_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_First_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_Name_Phone_2 As System.Windows.Forms.Label
    Friend WithEvents L_Name_Fax_1 As System.Windows.Forms.Label
    Friend WithEvents L_Name_Mobile_Phone_1 As System.Windows.Forms.Label
    Friend WithEvents L_Name_E_mail_1 As System.Windows.Forms.Label
    Friend WithEvents L_Name_E_mail_2 As System.Windows.Forms.Label
    Friend WithEvents L_Name_Notes As System.Windows.Forms.Label
    Friend WithEvents L_Name_Country_Code As System.Windows.Forms.Label
End Class
