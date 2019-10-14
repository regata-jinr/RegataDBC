<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Samples_Search
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
        Me.B_Close = New System.Windows.Forms.Button()
        Me.B_Run = New System.Windows.Forms.Button()
        Me.DataGridView_Table_Sample = New System.Windows.Forms.DataGridView()
        Me.TableReceivedByBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.Table_ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableSampleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_SampleTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_TableAdapter()
        Me.Table_CountryTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_CountryTableAdapter()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.Table_ClientTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_ClientTableAdapter()
        Me.Table_Received_ByTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter()
        Me.L_Name_NAA_Results = New System.Windows.Forms.Label()
        Me.Panel_Search_NAA_Results = New System.Windows.Forms.Panel()
        Me.L_Name_NAA_Results_Separate_Elements = New System.Windows.Forms.Label()
        Me.L_Name_NAA_Results_Scheme_Type = New System.Windows.Forms.Label()
        Me.ComboBox_NAA_Results_Scheme_Type = New System.Windows.Forms.ComboBox()
        Me.B_Save = New System.Windows.Forms.Button()
        Me.SaveFileDialog_Search_Results = New System.Windows.Forms.SaveFileDialog()
        Me.L_Name_Sample_Set = New System.Windows.Forms.Label()
        Me.ComboBox_Country = New System.Windows.Forms.ComboBox()
        Me.L_Name_Last_Name = New System.Windows.Forms.Label()
        Me.L_Last_Name = New System.Windows.Forms.Label()
        Me.L_Name_Organization = New System.Windows.Forms.Label()
        Me.L_Organization = New System.Windows.Forms.Label()
        Me.Panel_Search_Sample_Set = New System.Windows.Forms.Panel()
        Me.L_Name_Country = New System.Windows.Forms.Label()
        Me.L_Name_Sample_Set_Scheme_Type = New System.Windows.Forms.Label()
        Me.ComboBox_Sample_Set_Scheme_Type = New System.Windows.Forms.ComboBox()
        Me.L_Name_Client_S_ID = New System.Windows.Forms.Label()
        Me.CheckedListBox_Sample_Set_Client = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox_NAA_Results_Separate_Elements = New System.Windows.Forms.CheckedListBox()
        CType(Me.DataGridView_Table_Sample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableReceivedByBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableSampleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Search_NAA_Results.SuspendLayout()
        Me.Panel_Search_Sample_Set.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(485, 683)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(83, 23)
        Me.B_Close.TabIndex = 169
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'B_Run
        '
        Me.B_Run.AutoSize = True
        Me.B_Run.Location = New System.Drawing.Point(256, 683)
        Me.B_Run.Name = "B_Run"
        Me.B_Run.Size = New System.Drawing.Size(88, 23)
        Me.B_Run.TabIndex = 173
        Me.B_Run.Text = "Run"
        Me.B_Run.UseVisualStyleBackColor = True
        '
        'DataGridView_Table_Sample
        '
        Me.DataGridView_Table_Sample.AllowUserToAddRows = False
        Me.DataGridView_Table_Sample.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Sample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Sample.Location = New System.Drawing.Point(3, 456)
        Me.DataGridView_Table_Sample.Name = "DataGridView_Table_Sample"
        Me.DataGridView_Table_Sample.RowHeadersWidth = 21
        Me.DataGridView_Table_Sample.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Sample.Size = New System.Drawing.Size(819, 221)
        Me.DataGridView_Table_Sample.TabIndex = 173
        '
        'TableReceivedByBindingSource
        '
        Me.TableReceivedByBindingSource.DataMember = "table_Received_By"
        Me.TableReceivedByBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_ClientBindingSource
        '
        Me.Table_ClientBindingSource.DataMember = "table_Client"
        Me.Table_ClientBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_CountryBindingSource
        '
        Me.Table_CountryBindingSource.DataMember = "table_Country"
        Me.Table_CountryBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'TableSampleBindingSource
        '
        Me.TableSampleBindingSource.DataMember = "table_Sample"
        Me.TableSampleBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_SampleTableAdapter
        '
        Me.Table_SampleTableAdapter.ClearBeforeFill = True
        '
        'Table_CountryTableAdapter
        '
        Me.Table_CountryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.table_ClientTableAdapter = Me.Table_ClientTableAdapter
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
        'Table_ClientTableAdapter
        '
        Me.Table_ClientTableAdapter.ClearBeforeFill = True
        '
        'Table_Received_ByTableAdapter
        '
        Me.Table_Received_ByTableAdapter.ClearBeforeFill = True
        '
        'L_Name_NAA_Results
        '
        Me.L_Name_NAA_Results.AutoSize = True
        Me.L_Name_NAA_Results.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.L_Name_NAA_Results.Location = New System.Drawing.Point(1, 1)
        Me.L_Name_NAA_Results.Name = "L_Name_NAA_Results"
        Me.L_Name_NAA_Results.Size = New System.Drawing.Size(62, 13)
        Me.L_Name_NAA_Results.TabIndex = 5
        Me.L_Name_NAA_Results.Text = "NAA results"
        '
        'Panel_Search_NAA_Results
        '
        Me.Panel_Search_NAA_Results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Search_NAA_Results.Controls.Add(Me.CheckedListBox_NAA_Results_Separate_Elements)
        Me.Panel_Search_NAA_Results.Controls.Add(Me.L_Name_NAA_Results_Separate_Elements)
        Me.Panel_Search_NAA_Results.Controls.Add(Me.L_Name_NAA_Results_Scheme_Type)
        Me.Panel_Search_NAA_Results.Controls.Add(Me.ComboBox_NAA_Results_Scheme_Type)
        Me.Panel_Search_NAA_Results.Controls.Add(Me.L_Name_NAA_Results)
        Me.Panel_Search_NAA_Results.Location = New System.Drawing.Point(3, 167)
        Me.Panel_Search_NAA_Results.Name = "Panel_Search_NAA_Results"
        Me.Panel_Search_NAA_Results.Size = New System.Drawing.Size(819, 272)
        Me.Panel_Search_NAA_Results.TabIndex = 196
        '
        'L_Name_NAA_Results_Separate_Elements
        '
        Me.L_Name_NAA_Results_Separate_Elements.AutoSize = True
        Me.L_Name_NAA_Results_Separate_Elements.Location = New System.Drawing.Point(174, 14)
        Me.L_Name_NAA_Results_Separate_Elements.Name = "L_Name_NAA_Results_Separate_Elements"
        Me.L_Name_NAA_Results_Separate_Elements.Size = New System.Drawing.Size(95, 13)
        Me.L_Name_NAA_Results_Separate_Elements.TabIndex = 201
        Me.L_Name_NAA_Results_Separate_Elements.Text = "Separate elements"
        '
        'L_Name_NAA_Results_Scheme_Type
        '
        Me.L_Name_NAA_Results_Scheme_Type.AutoSize = True
        Me.L_Name_NAA_Results_Scheme_Type.Location = New System.Drawing.Point(3, 14)
        Me.L_Name_NAA_Results_Scheme_Type.Name = "L_Name_NAA_Results_Scheme_Type"
        Me.L_Name_NAA_Results_Scheme_Type.Size = New System.Drawing.Size(69, 13)
        Me.L_Name_NAA_Results_Scheme_Type.TabIndex = 200
        Me.L_Name_NAA_Results_Scheme_Type.Text = "Scheme type"
        '
        'ComboBox_NAA_Results_Scheme_Type
        '
        Me.ComboBox_NAA_Results_Scheme_Type.FormattingEnabled = True
        Me.ComboBox_NAA_Results_Scheme_Type.Items.AddRange(New Object() {"AND", "OR"})
        Me.ComboBox_NAA_Results_Scheme_Type.Location = New System.Drawing.Point(6, 30)
        Me.ComboBox_NAA_Results_Scheme_Type.Name = "ComboBox_NAA_Results_Scheme_Type"
        Me.ComboBox_NAA_Results_Scheme_Type.Size = New System.Drawing.Size(63, 21)
        Me.ComboBox_NAA_Results_Scheme_Type.TabIndex = 199
        Me.ComboBox_NAA_Results_Scheme_Type.Text = "AND"
        '
        'B_Save
        '
        Me.B_Save.Location = New System.Drawing.Point(350, 683)
        Me.B_Save.Name = "B_Save"
        Me.B_Save.Size = New System.Drawing.Size(129, 23)
        Me.B_Save.TabIndex = 197
        Me.B_Save.Text = "Save results"
        Me.B_Save.UseVisualStyleBackColor = True
        '
        'L_Name_Sample_Set
        '
        Me.L_Name_Sample_Set.AutoSize = True
        Me.L_Name_Sample_Set.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.L_Name_Sample_Set.Location = New System.Drawing.Point(1, 1)
        Me.L_Name_Sample_Set.Name = "L_Name_Sample_Set"
        Me.L_Name_Sample_Set.Size = New System.Drawing.Size(59, 13)
        Me.L_Name_Sample_Set.TabIndex = 5
        Me.L_Name_Sample_Set.Text = "Sample set"
        '
        'ComboBox_Country
        '
        Me.ComboBox_Country.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table_CountryBindingSource, "Country", True))
        Me.ComboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Country.FormattingEnabled = True
        Me.ComboBox_Country.Location = New System.Drawing.Point(10, 30)
        Me.ComboBox_Country.Name = "ComboBox_Country"
        Me.ComboBox_Country.Size = New System.Drawing.Size(129, 21)
        Me.ComboBox_Country.Sorted = True
        Me.ComboBox_Country.TabIndex = 184
        '
        'L_Name_Last_Name
        '
        Me.L_Name_Last_Name.AutoSize = True
        Me.L_Name_Last_Name.Location = New System.Drawing.Point(154, 14)
        Me.L_Name_Last_Name.Name = "L_Name_Last_Name"
        Me.L_Name_Last_Name.Size = New System.Drawing.Size(88, 13)
        Me.L_Name_Last_Name.TabIndex = 199
        Me.L_Name_Last_Name.Text = "Client's last name"
        '
        'L_Last_Name
        '
        Me.L_Last_Name.AutoSize = True
        Me.L_Last_Name.Location = New System.Drawing.Point(275, 14)
        Me.L_Last_Name.Name = "L_Last_Name"
        Me.L_Last_Name.Size = New System.Drawing.Size(10, 13)
        Me.L_Last_Name.TabIndex = 200
        Me.L_Last_Name.Text = "-"
        '
        'L_Name_Organization
        '
        Me.L_Name_Organization.AutoSize = True
        Me.L_Name_Organization.Location = New System.Drawing.Point(154, 33)
        Me.L_Name_Organization.Name = "L_Name_Organization"
        Me.L_Name_Organization.Size = New System.Drawing.Size(100, 13)
        Me.L_Name_Organization.TabIndex = 201
        Me.L_Name_Organization.Text = "Client's organization"
        '
        'L_Organization
        '
        Me.L_Organization.AutoSize = True
        Me.L_Organization.Location = New System.Drawing.Point(275, 33)
        Me.L_Organization.Name = "L_Organization"
        Me.L_Organization.Size = New System.Drawing.Size(10, 13)
        Me.L_Organization.TabIndex = 202
        Me.L_Organization.Text = "-"
        '
        'Panel_Search_Sample_Set
        '
        Me.Panel_Search_Sample_Set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Name_Country)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Name_Sample_Set_Scheme_Type)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.ComboBox_Sample_Set_Scheme_Type)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Name_Client_S_ID)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.CheckedListBox_Sample_Set_Client)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Organization)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Name_Organization)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Last_Name)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Name_Last_Name)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.ComboBox_Country)
        Me.Panel_Search_Sample_Set.Controls.Add(Me.L_Name_Sample_Set)
        Me.Panel_Search_Sample_Set.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Search_Sample_Set.Name = "Panel_Search_Sample_Set"
        Me.Panel_Search_Sample_Set.Size = New System.Drawing.Size(819, 158)
        Me.Panel_Search_Sample_Set.TabIndex = 194
        '
        'L_Name_Country
        '
        Me.L_Name_Country.AutoSize = True
        Me.L_Name_Country.Location = New System.Drawing.Point(52, 14)
        Me.L_Name_Country.Name = "L_Name_Country"
        Me.L_Name_Country.Size = New System.Drawing.Size(43, 13)
        Me.L_Name_Country.TabIndex = 208
        Me.L_Name_Country.Text = "Country"
        '
        'L_Name_Sample_Set_Scheme_Type
        '
        Me.L_Name_Sample_Set_Scheme_Type.AutoSize = True
        Me.L_Name_Sample_Set_Scheme_Type.Location = New System.Drawing.Point(3, 56)
        Me.L_Name_Sample_Set_Scheme_Type.Name = "L_Name_Sample_Set_Scheme_Type"
        Me.L_Name_Sample_Set_Scheme_Type.Size = New System.Drawing.Size(69, 13)
        Me.L_Name_Sample_Set_Scheme_Type.TabIndex = 207
        Me.L_Name_Sample_Set_Scheme_Type.Text = "Scheme type"
        '
        'ComboBox_Sample_Set_Scheme_Type
        '
        Me.ComboBox_Sample_Set_Scheme_Type.FormattingEnabled = True
        Me.ComboBox_Sample_Set_Scheme_Type.Items.AddRange(New Object() {"AND", "OR"})
        Me.ComboBox_Sample_Set_Scheme_Type.Location = New System.Drawing.Point(6, 72)
        Me.ComboBox_Sample_Set_Scheme_Type.Name = "ComboBox_Sample_Set_Scheme_Type"
        Me.ComboBox_Sample_Set_Scheme_Type.Size = New System.Drawing.Size(63, 21)
        Me.ComboBox_Sample_Set_Scheme_Type.TabIndex = 206
        Me.ComboBox_Sample_Set_Scheme_Type.Text = "AND"
        '
        'L_Name_Client_S_ID
        '
        Me.L_Name_Client_S_ID.AutoSize = True
        Me.L_Name_Client_S_ID.Location = New System.Drawing.Point(85, 56)
        Me.L_Name_Client_S_ID.Name = "L_Name_Client_S_ID"
        Me.L_Name_Client_S_ID.Size = New System.Drawing.Size(54, 13)
        Me.L_Name_Client_S_ID.TabIndex = 205
        Me.L_Name_Client_S_ID.Text = "Client's ID"
        '
        'CheckedListBox_Sample_Set_Client
        '
        Me.CheckedListBox_Sample_Set_Client.ColumnWidth = 70
        Me.CheckedListBox_Sample_Set_Client.FormattingEnabled = True
        Me.CheckedListBox_Sample_Set_Client.Location = New System.Drawing.Point(78, 72)
        Me.CheckedListBox_Sample_Set_Client.MultiColumn = True
        Me.CheckedListBox_Sample_Set_Client.Name = "CheckedListBox_Sample_Set_Client"
        Me.CheckedListBox_Sample_Set_Client.Size = New System.Drawing.Size(396, 79)
        Me.CheckedListBox_Sample_Set_Client.TabIndex = 203
        '
        'CheckedListBox_NAA_Results_Separate_Elements
        '
        Me.CheckedListBox_NAA_Results_Separate_Elements.ColumnWidth = 70
        Me.CheckedListBox_NAA_Results_Separate_Elements.FormattingEnabled = True
        Me.CheckedListBox_NAA_Results_Separate_Elements.Items.AddRange(New Object() {"F", "Na", "Mg", "Al", "Si", "S", "Cl", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Ru", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "I", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Th", "U"})
        Me.CheckedListBox_NAA_Results_Separate_Elements.Location = New System.Drawing.Point(390, 6)
        Me.CheckedListBox_NAA_Results_Separate_Elements.MultiColumn = True
        Me.CheckedListBox_NAA_Results_Separate_Elements.Name = "CheckedListBox_NAA_Results_Separate_Elements"
        Me.CheckedListBox_NAA_Results_Separate_Elements.Size = New System.Drawing.Size(284, 259)
        Me.CheckedListBox_NAA_Results_Separate_Elements.TabIndex = 202
        '
        'Form_Samples_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(827, 714)
        Me.Controls.Add(Me.B_Save)
        Me.Controls.Add(Me.Panel_Search_NAA_Results)
        Me.Controls.Add(Me.Panel_Search_Sample_Set)
        Me.Controls.Add(Me.DataGridView_Table_Sample)
        Me.Controls.Add(Me.B_Run)
        Me.Controls.Add(Me.B_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Samples_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Samples search"
        CType(Me.DataGridView_Table_Sample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableReceivedByBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableSampleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Search_NAA_Results.ResumeLayout(False)
        Me.Panel_Search_NAA_Results.PerformLayout()
        Me.Panel_Search_Sample_Set.ResumeLayout(False)
        Me.Panel_Search_Sample_Set.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents TableSampleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_SampleTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_TableAdapter
    Friend WithEvents Table_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_CountryTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_CountryTableAdapter
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table_ClientTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_ClientTableAdapter
    Friend WithEvents Table_ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents B_Run As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Table_Sample As System.Windows.Forms.DataGridView
    Friend WithEvents TableReceivedByBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_Received_ByTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Received_ByTableAdapter
    Friend WithEvents L_Name_NAA_Results As System.Windows.Forms.Label
    Friend WithEvents Panel_Search_NAA_Results As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_NAA_Results_Scheme_Type As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_NAA_Results_Scheme_Type As System.Windows.Forms.Label
    Friend WithEvents L_Name_NAA_Results_Separate_Elements As System.Windows.Forms.Label
    Friend WithEvents B_Save As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_Search_Results As System.Windows.Forms.SaveFileDialog
    Friend WithEvents L_Name_Sample_Set As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Country As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Last_Name As System.Windows.Forms.Label
    Friend WithEvents L_Last_Name As System.Windows.Forms.Label
    Friend WithEvents L_Name_Organization As System.Windows.Forms.Label
    Friend WithEvents L_Organization As System.Windows.Forms.Label
    Friend WithEvents Panel_Search_Sample_Set As System.Windows.Forms.Panel
    Friend WithEvents CheckedListBox_Sample_Set_Client As System.Windows.Forms.CheckedListBox
    Friend WithEvents L_Name_Client_S_ID As System.Windows.Forms.Label
    Friend WithEvents L_Name_Sample_Set_Scheme_Type As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sample_Set_Scheme_Type As System.Windows.Forms.ComboBox
    Friend WithEvents L_Name_Country As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox_NAA_Results_Separate_Elements As System.Windows.Forms.CheckedListBox
End Class
