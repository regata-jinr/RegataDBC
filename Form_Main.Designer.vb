<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.B_NewSampleSetIDAccept = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_Sample_Set = New System.Windows.Forms.DataGridView()
        Me.B_Select_Sample_Set = New System.Windows.Forms.Button()
        Me.B_Physical_Environment = New System.Windows.Forms.Button()
        Me.L_Name_SLI_Irradiation_Log = New System.Windows.Forms.Label()
        Me.L_Name_LLI_Irradiation_Log = New System.Windows.Forms.Label()
        Me.B_Select_SLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.B_New_SLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.MaskedTextBox_SLI_Irradiation_Log = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_Sample_Set = New System.Windows.Forms.Label()
        Me.B_Select_SRM_Set = New System.Windows.Forms.Button()
        Me.B_New_SRM_Set_Accept = New System.Windows.Forms.Button()
        Me.Table_SRM_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.L_Name_SRM_Set = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set = New System.Windows.Forms.Label()
        Me.Table_Monitor_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.B_Select_Monitor_Set = New System.Windows.Forms.Button()
        Me.B_New_Monitor_Set_Accept = New System.Windows.Forms.Button()
        Me.MaskedTextBox_LLI_Irradiation_Log = New System.Windows.Forms.MaskedTextBox()
        Me.B_Select_LLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.B_New_LLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.L_Count = New System.Windows.Forms.Label()
        Me.L_Monitor = New System.Windows.Forms.Label()
        Me.ListBox_SLI_Irradiation_Log_Date = New System.Windows.Forms.ListBox()
        Me.ListBox_LLI_Irradiation_Log_Date = New System.Windows.Forms.ListBox()
        Me.ListBox_Monitor_SRM = New System.Windows.Forms.ListBox()
        Me.ListBox_Monitor_Monitor = New System.Windows.Forms.ListBox()
        Me.DataGridView_Description = New System.Windows.Forms.DataGridView()
        Me.Cell_Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L_Name_Sample_Set_View = New System.Windows.Forms.Label()
        Me.ComboBox_Sample_Set_View = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Journal_Of_Irradiation_View = New System.Windows.Forms.ComboBox()
        Me.OpenSet = New System.Windows.Forms.Button()
        Me.ChangeLang = New System.Windows.Forms.Button()
        Me.GBFilters = New System.Windows.Forms.GroupBox()
        Me.LFilterField = New System.Windows.Forms.Label()
        Me.CBFilter = New System.Windows.Forms.ComboBox()
        Me.SampleSetInfo = New System.Windows.Forms.GroupBox()
        Me.ButtonshowAll = New System.Windows.Forms.Button()
        Me.B_Refresh = New System.Windows.Forms.Button()
        Me.ButtonShowAllSrms = New System.Windows.Forms.Button()
        Me.BackgroundWorkerColorizer = New System.ComponentModel.BackgroundWorker()
        Me.Table_SRM_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_SRM_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter()
        Me.Table_Monitor_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter()
        CType(Me.DataGridView_Sample_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFilters.SuspendLayout()
        Me.SampleSetInfo.SuspendLayout()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_NewSampleSetIDAccept
        '
        Me.B_NewSampleSetIDAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_NewSampleSetIDAccept.Location = New System.Drawing.Point(4, 254)
        Me.B_NewSampleSetIDAccept.Name = "B_NewSampleSetIDAccept"
        Me.B_NewSampleSetIDAccept.Size = New System.Drawing.Size(84, 23)
        Me.B_NewSampleSetIDAccept.TabIndex = 0
        Me.B_NewSampleSetIDAccept.Text = "New sample set acceptance"
        Me.B_NewSampleSetIDAccept.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Country_Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Country_Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Client_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Client_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Year"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sample_Set_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sample_Set_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'DataGridView_Sample_Set
        '
        Me.DataGridView_Sample_Set.AllowUserToAddRows = False
        Me.DataGridView_Sample_Set.AllowUserToDeleteRows = False
        Me.DataGridView_Sample_Set.AllowUserToResizeColumns = False
        Me.DataGridView_Sample_Set.AllowUserToResizeRows = False
        Me.DataGridView_Sample_Set.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Sample_Set.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Sample_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView_Sample_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Sample_Set.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView_Sample_Set.Location = New System.Drawing.Point(6, 39)
        Me.DataGridView_Sample_Set.MultiSelect = False
        Me.DataGridView_Sample_Set.Name = "DataGridView_Sample_Set"
        Me.DataGridView_Sample_Set.ReadOnly = True
        Me.DataGridView_Sample_Set.RowHeadersVisible = False
        Me.DataGridView_Sample_Set.RowHeadersWidth = 10
        Me.DataGridView_Sample_Set.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView_Sample_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Sample_Set.Size = New System.Drawing.Size(358, 209)
        Me.DataGridView_Sample_Set.TabIndex = 2
        '
        'B_Select_Sample_Set
        '
        Me.B_Select_Sample_Set.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_Select_Sample_Set.Location = New System.Drawing.Point(272, 254)
        Me.B_Select_Sample_Set.Name = "B_Select_Sample_Set"
        Me.B_Select_Sample_Set.Size = New System.Drawing.Size(90, 23)
        Me.B_Select_Sample_Set.TabIndex = 3
        Me.B_Select_Sample_Set.Text = "Select sample set"
        Me.B_Select_Sample_Set.UseVisualStyleBackColor = True
        '
        'B_Physical_Environment
        '
        Me.B_Physical_Environment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_Physical_Environment.Location = New System.Drawing.Point(4, 690)
        Me.B_Physical_Environment.Name = "B_Physical_Environment"
        Me.B_Physical_Environment.Size = New System.Drawing.Size(226, 23)
        Me.B_Physical_Environment.TabIndex = 144
        Me.B_Physical_Environment.Text = "Physical environment"
        Me.B_Physical_Environment.UseVisualStyleBackColor = True
        '
        'L_Name_SLI_Irradiation_Log
        '
        Me.L_Name_SLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_SLI_Irradiation_Log.AutoSize = True
        Me.L_Name_SLI_Irradiation_Log.Location = New System.Drawing.Point(678, 3)
        Me.L_Name_SLI_Irradiation_Log.Name = "L_Name_SLI_Irradiation_Log"
        Me.L_Name_SLI_Irradiation_Log.Size = New System.Drawing.Size(88, 13)
        Me.L_Name_SLI_Irradiation_Log.TabIndex = 148
        Me.L_Name_SLI_Irradiation_Log.Text = "SLI irradiation log"
        '
        'L_Name_LLI_Irradiation_Log
        '
        Me.L_Name_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_LLI_Irradiation_Log.AutoSize = True
        Me.L_Name_LLI_Irradiation_Log.Location = New System.Drawing.Point(817, 3)
        Me.L_Name_LLI_Irradiation_Log.Name = "L_Name_LLI_Irradiation_Log"
        Me.L_Name_LLI_Irradiation_Log.Size = New System.Drawing.Size(87, 13)
        Me.L_Name_LLI_Irradiation_Log.TabIndex = 150
        Me.L_Name_LLI_Irradiation_Log.Text = "LLI irradiation log"
        '
        'B_Select_SLI_Irradiation_Log
        '
        Me.B_Select_SLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Select_SLI_Irradiation_Log.Location = New System.Drawing.Point(681, 366)
        Me.B_Select_SLI_Irradiation_Log.Name = "B_Select_SLI_Irradiation_Log"
        Me.B_Select_SLI_Irradiation_Log.Size = New System.Drawing.Size(131, 23)
        Me.B_Select_SLI_Irradiation_Log.TabIndex = 154
        Me.B_Select_SLI_Irradiation_Log.Text = "Select SLI irradiation log"
        Me.B_Select_SLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'B_New_SLI_Irradiation_Log
        '
        Me.B_New_SLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_New_SLI_Irradiation_Log.Location = New System.Drawing.Point(681, 421)
        Me.B_New_SLI_Irradiation_Log.Name = "B_New_SLI_Irradiation_Log"
        Me.B_New_SLI_Irradiation_Log.Size = New System.Drawing.Size(131, 23)
        Me.B_New_SLI_Irradiation_Log.TabIndex = 153
        Me.B_New_SLI_Irradiation_Log.Text = "New SLI irradiation log"
        Me.B_New_SLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_SLI_Irradiation_Log
        '
        Me.MaskedTextBox_SLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox_SLI_Irradiation_Log.Location = New System.Drawing.Point(711, 395)
        Me.MaskedTextBox_SLI_Irradiation_Log.Mask = "00/00/0000"
        Me.MaskedTextBox_SLI_Irradiation_Log.Name = "MaskedTextBox_SLI_Irradiation_Log"
        Me.MaskedTextBox_SLI_Irradiation_Log.Size = New System.Drawing.Size(74, 20)
        Me.MaskedTextBox_SLI_Irradiation_Log.TabIndex = 155
        Me.MaskedTextBox_SLI_Irradiation_Log.ValidatingType = GetType(Date)
        '
        'L_Name_Sample_Set
        '
        Me.L_Name_Sample_Set.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_Sample_Set.AutoSize = True
        Me.L_Name_Sample_Set.Location = New System.Drawing.Point(128, 9)
        Me.L_Name_Sample_Set.Name = "L_Name_Sample_Set"
        Me.L_Name_Sample_Set.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Sample_Set.TabIndex = 156
        Me.L_Name_Sample_Set.Text = "Sample sets"
        '
        'B_Select_SRM_Set
        '
        Me.B_Select_SRM_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_Select_SRM_Set.Location = New System.Drawing.Point(176, 657)
        Me.B_Select_SRM_Set.Name = "B_Select_SRM_Set"
        Me.B_Select_SRM_Set.Size = New System.Drawing.Size(321, 23)
        Me.B_Select_SRM_Set.TabIndex = 159
        Me.B_Select_SRM_Set.Text = "Select SRM set"
        Me.B_Select_SRM_Set.UseVisualStyleBackColor = True
        '
        'B_New_SRM_Set_Accept
        '
        Me.B_New_SRM_Set_Accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_New_SRM_Set_Accept.Location = New System.Drawing.Point(176, 628)
        Me.B_New_SRM_Set_Accept.Name = "B_New_SRM_Set_Accept"
        Me.B_New_SRM_Set_Accept.Size = New System.Drawing.Size(321, 23)
        Me.B_New_SRM_Set_Accept.TabIndex = 158
        Me.B_New_SRM_Set_Accept.Text = "New SRM set acceptance"
        Me.B_New_SRM_Set_Accept.UseVisualStyleBackColor = True
        '
        'Table_SRM_SetDataGridView
        '
        Me.Table_SRM_SetDataGridView.AllowUserToAddRows = False
        Me.Table_SRM_SetDataGridView.AllowUserToDeleteRows = False
        Me.Table_SRM_SetDataGridView.AllowUserToResizeColumns = False
        Me.Table_SRM_SetDataGridView.AllowUserToResizeRows = False
        Me.Table_SRM_SetDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Table_SRM_SetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_SRM_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.Table_SRM_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_SRM_SetDataGridView.Location = New System.Drawing.Point(6, 478)
        Me.Table_SRM_SetDataGridView.Name = "Table_SRM_SetDataGridView"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_SRM_SetDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.Table_SRM_SetDataGridView.RowHeadersVisible = False
        Me.Table_SRM_SetDataGridView.RowHeadersWidth = 21
        Me.Table_SRM_SetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_SRM_SetDataGridView.Size = New System.Drawing.Size(491, 144)
        Me.Table_SRM_SetDataGridView.TabIndex = 157
        '
        'L_Name_SRM_Set
        '
        Me.L_Name_SRM_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.L_Name_SRM_Set.AutoSize = True
        Me.L_Name_SRM_Set.Location = New System.Drawing.Point(156, 462)
        Me.L_Name_SRM_Set.Name = "L_Name_SRM_Set"
        Me.L_Name_SRM_Set.Size = New System.Drawing.Size(53, 13)
        Me.L_Name_SRM_Set.TabIndex = 160
        Me.L_Name_SRM_Set.Text = "SRM sets"
        '
        'L_Name_Monitor_Set
        '
        Me.L_Name_Monitor_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_Monitor_Set.AutoSize = True
        Me.L_Name_Monitor_Set.Location = New System.Drawing.Point(746, 462)
        Me.L_Name_Monitor_Set.Name = "L_Name_Monitor_Set"
        Me.L_Name_Monitor_Set.Size = New System.Drawing.Size(64, 13)
        Me.L_Name_Monitor_Set.TabIndex = 162
        Me.L_Name_Monitor_Set.Text = "Monitor sets"
        '
        'Table_Monitor_SetDataGridView
        '
        Me.Table_Monitor_SetDataGridView.AllowUserToAddRows = False
        Me.Table_Monitor_SetDataGridView.AllowUserToDeleteRows = False
        Me.Table_Monitor_SetDataGridView.AllowUserToResizeColumns = False
        Me.Table_Monitor_SetDataGridView.AllowUserToResizeRows = False
        Me.Table_Monitor_SetDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table_Monitor_SetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Monitor_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.Table_Monitor_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Monitor_SetDataGridView.Location = New System.Drawing.Point(520, 478)
        Me.Table_Monitor_SetDataGridView.Name = "Table_Monitor_SetDataGridView"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Monitor_SetDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.Table_Monitor_SetDataGridView.RowHeadersVisible = False
        Me.Table_Monitor_SetDataGridView.RowHeadersWidth = 21
        Me.Table_Monitor_SetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_Monitor_SetDataGridView.Size = New System.Drawing.Size(429, 144)
        Me.Table_Monitor_SetDataGridView.TabIndex = 161
        '
        'B_Select_Monitor_Set
        '
        Me.B_Select_Monitor_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Select_Monitor_Set.Location = New System.Drawing.Point(671, 661)
        Me.B_Select_Monitor_Set.Name = "B_Select_Monitor_Set"
        Me.B_Select_Monitor_Set.Size = New System.Drawing.Size(278, 23)
        Me.B_Select_Monitor_Set.TabIndex = 164
        Me.B_Select_Monitor_Set.Text = "Select monitor set"
        Me.B_Select_Monitor_Set.UseVisualStyleBackColor = True
        '
        'B_New_Monitor_Set_Accept
        '
        Me.B_New_Monitor_Set_Accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_New_Monitor_Set_Accept.Location = New System.Drawing.Point(671, 628)
        Me.B_New_Monitor_Set_Accept.Name = "B_New_Monitor_Set_Accept"
        Me.B_New_Monitor_Set_Accept.Size = New System.Drawing.Size(278, 23)
        Me.B_New_Monitor_Set_Accept.TabIndex = 163
        Me.B_New_Monitor_Set_Accept.Text = "New monitor set acceptance"
        Me.B_New_Monitor_Set_Accept.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_LLI_Irradiation_Log
        '
        Me.MaskedTextBox_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox_LLI_Irradiation_Log.Location = New System.Drawing.Point(850, 395)
        Me.MaskedTextBox_LLI_Irradiation_Log.Mask = "00/00/0000"
        Me.MaskedTextBox_LLI_Irradiation_Log.Name = "MaskedTextBox_LLI_Irradiation_Log"
        Me.MaskedTextBox_LLI_Irradiation_Log.Size = New System.Drawing.Size(74, 20)
        Me.MaskedTextBox_LLI_Irradiation_Log.TabIndex = 167
        Me.MaskedTextBox_LLI_Irradiation_Log.ValidatingType = GetType(Date)
        '
        'B_Select_LLI_Irradiation_Log
        '
        Me.B_Select_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Select_LLI_Irradiation_Log.Location = New System.Drawing.Point(818, 366)
        Me.B_Select_LLI_Irradiation_Log.Name = "B_Select_LLI_Irradiation_Log"
        Me.B_Select_LLI_Irradiation_Log.Size = New System.Drawing.Size(131, 23)
        Me.B_Select_LLI_Irradiation_Log.TabIndex = 166
        Me.B_Select_LLI_Irradiation_Log.Text = "Select LLI irradiation log"
        Me.B_Select_LLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'B_New_LLI_Irradiation_Log
        '
        Me.B_New_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_New_LLI_Irradiation_Log.Location = New System.Drawing.Point(818, 421)
        Me.B_New_LLI_Irradiation_Log.Name = "B_New_LLI_Irradiation_Log"
        Me.B_New_LLI_Irradiation_Log.Size = New System.Drawing.Size(131, 23)
        Me.B_New_LLI_Irradiation_Log.TabIndex = 165
        Me.B_New_LLI_Irradiation_Log.Text = "New LLI irradiation log"
        Me.B_New_LLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'L_Count
        '
        Me.L_Count.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Count.AutoSize = True
        Me.L_Count.Location = New System.Drawing.Point(12, 9)
        Me.L_Count.Name = "L_Count"
        Me.L_Count.Size = New System.Drawing.Size(104, 13)
        Me.L_Count.TabIndex = 168
        Me.L_Count.Text = "Samples in NAA DB:"
        '
        'L_Monitor
        '
        Me.L_Monitor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Monitor.Location = New System.Drawing.Point(6, 20)
        Me.L_Monitor.Name = "L_Monitor"
        Me.L_Monitor.Size = New System.Drawing.Size(290, 321)
        Me.L_Monitor.TabIndex = 169
        Me.L_Monitor.Text = "Monitor"
        '
        'ListBox_SLI_Irradiation_Log_Date
        '
        Me.ListBox_SLI_Irradiation_Log_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_SLI_Irradiation_Log_Date.FormattingEnabled = True
        Me.ListBox_SLI_Irradiation_Log_Date.Location = New System.Drawing.Point(681, 16)
        Me.ListBox_SLI_Irradiation_Log_Date.Name = "ListBox_SLI_Irradiation_Log_Date"
        Me.ListBox_SLI_Irradiation_Log_Date.Size = New System.Drawing.Size(129, 316)
        Me.ListBox_SLI_Irradiation_Log_Date.TabIndex = 170
        '
        'ListBox_LLI_Irradiation_Log_Date
        '
        Me.ListBox_LLI_Irradiation_Log_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_LLI_Irradiation_Log_Date.FormattingEnabled = True
        Me.ListBox_LLI_Irradiation_Log_Date.Location = New System.Drawing.Point(820, 16)
        Me.ListBox_LLI_Irradiation_Log_Date.Name = "ListBox_LLI_Irradiation_Log_Date"
        Me.ListBox_LLI_Irradiation_Log_Date.Size = New System.Drawing.Size(129, 316)
        Me.ListBox_LLI_Irradiation_Log_Date.TabIndex = 171
        '
        'ListBox_Monitor_SRM
        '
        Me.ListBox_Monitor_SRM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Monitor_SRM.FormattingEnabled = True
        Me.ListBox_Monitor_SRM.Location = New System.Drawing.Point(6, 628)
        Me.ListBox_Monitor_SRM.Name = "ListBox_Monitor_SRM"
        Me.ListBox_Monitor_SRM.Size = New System.Drawing.Size(164, 56)
        Me.ListBox_Monitor_SRM.TabIndex = 174
        '
        'ListBox_Monitor_Monitor
        '
        Me.ListBox_Monitor_Monitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Monitor_Monitor.FormattingEnabled = True
        Me.ListBox_Monitor_Monitor.Location = New System.Drawing.Point(520, 628)
        Me.ListBox_Monitor_Monitor.Name = "ListBox_Monitor_Monitor"
        Me.ListBox_Monitor_Monitor.Size = New System.Drawing.Size(145, 56)
        Me.ListBox_Monitor_Monitor.TabIndex = 175
        '
        'DataGridView_Description
        '
        Me.DataGridView_Description.AllowUserToAddRows = False
        Me.DataGridView_Description.AllowUserToDeleteRows = False
        Me.DataGridView_Description.AllowUserToResizeColumns = False
        Me.DataGridView_Description.AllowUserToResizeRows = False
        Me.DataGridView_Description.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Description.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Description.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridView_Description.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Description.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cell_Color, Me.Description})
        Me.DataGridView_Description.Location = New System.Drawing.Point(6, 283)
        Me.DataGridView_Description.MultiSelect = False
        Me.DataGridView_Description.Name = "DataGridView_Description"
        Me.DataGridView_Description.ReadOnly = True
        Me.DataGridView_Description.RowHeadersVisible = False
        Me.DataGridView_Description.RowHeadersWidth = 21
        Me.DataGridView_Description.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView_Description.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Description.Size = New System.Drawing.Size(358, 176)
        Me.DataGridView_Description.TabIndex = 176
        '
        'Cell_Color
        '
        Me.Cell_Color.HeaderText = "Color"
        Me.Cell_Color.Name = "Cell_Color"
        Me.Cell_Color.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'L_Name_Sample_Set_View
        '
        Me.L_Name_Sample_Set_View.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_Sample_Set_View.AutoSize = True
        Me.L_Name_Sample_Set_View.Location = New System.Drawing.Point(147, 20)
        Me.L_Name_Sample_Set_View.Name = "L_Name_Sample_Set_View"
        Me.L_Name_Sample_Set_View.Size = New System.Drawing.Size(104, 36)
        Me.L_Name_Sample_Set_View.TabIndex = 177
        Me.L_Name_Sample_Set_View.Text = "Выбирите тип" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "фильтра"
        '
        'ComboBox_Sample_Set_View
        '
        Me.ComboBox_Sample_Set_View.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Sample_Set_View.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_Sample_Set_View.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Sample_Set_View.FormattingEnabled = True
        Me.ComboBox_Sample_Set_View.Location = New System.Drawing.Point(150, 59)
        Me.ComboBox_Sample_Set_View.Name = "ComboBox_Sample_Set_View"
        Me.ComboBox_Sample_Set_View.Size = New System.Drawing.Size(146, 26)
        Me.ComboBox_Sample_Set_View.TabIndex = 178
        '
        'ComboBox_Journal_Of_Irradiation_View
        '
        Me.ComboBox_Journal_Of_Irradiation_View.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Journal_Of_Irradiation_View.FormattingEnabled = True
        Me.ComboBox_Journal_Of_Irradiation_View.Items.AddRange(New Object() {"Current year", "All years"})
        Me.ComboBox_Journal_Of_Irradiation_View.Location = New System.Drawing.Point(681, 339)
        Me.ComboBox_Journal_Of_Irradiation_View.Name = "ComboBox_Journal_Of_Irradiation_View"
        Me.ComboBox_Journal_Of_Irradiation_View.Size = New System.Drawing.Size(268, 21)
        Me.ComboBox_Journal_Of_Irradiation_View.TabIndex = 180
        '
        'OpenSet
        '
        Me.OpenSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OpenSet.Location = New System.Drawing.Point(94, 254)
        Me.OpenSet.Name = "OpenSet"
        Me.OpenSet.Size = New System.Drawing.Size(76, 23)
        Me.OpenSet.TabIndex = 181
        Me.OpenSet.Text = "Просмотр"
        Me.OpenSet.UseVisualStyleBackColor = True
        '
        'ChangeLang
        '
        Me.ChangeLang.Location = New System.Drawing.Point(244, 9)
        Me.ChangeLang.Name = "ChangeLang"
        Me.ChangeLang.Size = New System.Drawing.Size(120, 24)
        Me.ChangeLang.TabIndex = 182
        Me.ChangeLang.Text = Global.NaaDB.My.Settings.language
        Me.ChangeLang.UseVisualStyleBackColor = True
        '
        'GBFilters
        '
        Me.GBFilters.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBFilters.Controls.Add(Me.LFilterField)
        Me.GBFilters.Controls.Add(Me.CBFilter)
        Me.GBFilters.Controls.Add(Me.L_Name_Sample_Set_View)
        Me.GBFilters.Controls.Add(Me.ComboBox_Sample_Set_View)
        Me.GBFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GBFilters.Location = New System.Drawing.Point(370, 3)
        Me.GBFilters.Name = "GBFilters"
        Me.GBFilters.Size = New System.Drawing.Size(305, 101)
        Me.GBFilters.TabIndex = 189
        Me.GBFilters.TabStop = False
        Me.GBFilters.Text = "Фильтрация списка партий"
        '
        'LFilterField
        '
        Me.LFilterField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFilterField.AutoSize = True
        Me.LFilterField.Location = New System.Drawing.Point(7, 20)
        Me.LFilterField.Name = "LFilterField"
        Me.LFilterField.Size = New System.Drawing.Size(115, 36)
        Me.LFilterField.TabIndex = 180
        Me.LFilterField.Text = "Выберите поле" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "для фильтра"
        '
        'CBFilter
        '
        Me.CBFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBFilter.FormattingEnabled = True
        Me.CBFilter.Items.AddRange(New Object() {"Обработано", "Страна", "Год", "Код клиента", "Показать все"})
        Me.CBFilter.Location = New System.Drawing.Point(6, 59)
        Me.CBFilter.Name = "CBFilter"
        Me.CBFilter.Size = New System.Drawing.Size(121, 26)
        Me.CBFilter.TabIndex = 179
        Me.CBFilter.Tag = ""
        '
        'SampleSetInfo
        '
        Me.SampleSetInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleSetInfo.Controls.Add(Me.L_Monitor)
        Me.SampleSetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SampleSetInfo.Location = New System.Drawing.Point(370, 110)
        Me.SampleSetInfo.Name = "SampleSetInfo"
        Me.SampleSetInfo.Size = New System.Drawing.Size(302, 357)
        Me.SampleSetInfo.TabIndex = 190
        Me.SampleSetInfo.TabStop = False
        Me.SampleSetInfo.Text = "Информация о выбранной партии"
        '
        'ButtonshowAll
        '
        Me.ButtonshowAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonshowAll.Location = New System.Drawing.Point(176, 254)
        Me.ButtonshowAll.Name = "ButtonshowAll"
        Me.ButtonshowAll.Size = New System.Drawing.Size(90, 23)
        Me.ButtonshowAll.TabIndex = 192
        Me.ButtonshowAll.Text = "Показать все"
        Me.ButtonshowAll.UseVisualStyleBackColor = True
        '
        'B_Refresh
        '
        Me.B_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_Refresh.Location = New System.Drawing.Point(520, 690)
        Me.B_Refresh.Name = "B_Refresh"
        Me.B_Refresh.Size = New System.Drawing.Size(429, 23)
        Me.B_Refresh.TabIndex = 179
        Me.B_Refresh.Text = "Refresh"
        Me.B_Refresh.UseVisualStyleBackColor = True
        '
        'ButtonShowAllSrms
        '
        Me.ButtonShowAllSrms.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonShowAllSrms.Location = New System.Drawing.Point(244, 690)
        Me.ButtonShowAllSrms.Name = "ButtonShowAllSrms"
        Me.ButtonShowAllSrms.Size = New System.Drawing.Size(253, 23)
        Me.ButtonShowAllSrms.TabIndex = 195
        Me.ButtonShowAllSrms.Text = "ShowAllSRMs"
        Me.ButtonShowAllSrms.UseVisualStyleBackColor = True
        '
        'BackgroundWorkerColorizer
        '
        '
        'Table_SRM_Set_BindingSource
        '
        Me.Table_SRM_Set_BindingSource.DataMember = "table_SRM_Set"
        '
        'Table_SRM_TableAdapter
        '
        Me.Table_SRM_TableAdapter.ClearBeforeFill = True
        '
        'Table_Monitor_Set_TableAdapter
        '
        Me.Table_Monitor_Set_TableAdapter.ClearBeforeFill = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 718)
        Me.Controls.Add(Me.ButtonShowAllSrms)
        Me.Controls.Add(Me.ButtonshowAll)
        Me.Controls.Add(Me.SampleSetInfo)
        Me.Controls.Add(Me.GBFilters)
        Me.Controls.Add(Me.ChangeLang)
        Me.Controls.Add(Me.OpenSet)
        Me.Controls.Add(Me.ComboBox_Journal_Of_Irradiation_View)
        Me.Controls.Add(Me.B_Refresh)
        Me.Controls.Add(Me.DataGridView_Description)
        Me.Controls.Add(Me.ListBox_Monitor_Monitor)
        Me.Controls.Add(Me.ListBox_Monitor_SRM)
        Me.Controls.Add(Me.ListBox_LLI_Irradiation_Log_Date)
        Me.Controls.Add(Me.ListBox_SLI_Irradiation_Log_Date)
        Me.Controls.Add(Me.L_Count)
        Me.Controls.Add(Me.MaskedTextBox_LLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Select_LLI_Irradiation_Log)
        Me.Controls.Add(Me.B_New_LLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Select_Monitor_Set)
        Me.Controls.Add(Me.B_New_Monitor_Set_Accept)
        Me.Controls.Add(Me.L_Name_Monitor_Set)
        Me.Controls.Add(Me.Table_Monitor_SetDataGridView)
        Me.Controls.Add(Me.L_Name_SRM_Set)
        Me.Controls.Add(Me.B_Select_SRM_Set)
        Me.Controls.Add(Me.B_New_SRM_Set_Accept)
        Me.Controls.Add(Me.Table_SRM_SetDataGridView)
        Me.Controls.Add(Me.L_Name_Sample_Set)
        Me.Controls.Add(Me.MaskedTextBox_SLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Select_SLI_Irradiation_Log)
        Me.Controls.Add(Me.B_New_SLI_Irradiation_Log)
        Me.Controls.Add(Me.L_Name_LLI_Irradiation_Log)
        Me.Controls.Add(Me.L_Name_SLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Physical_Environment)
        Me.Controls.Add(Me.B_Select_Sample_Set)
        Me.Controls.Add(Me.DataGridView_Sample_Set)
        Me.Controls.Add(Me.B_NewSampleSetIDAccept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView_Sample_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Description, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFilters.ResumeLayout(False)
        Me.GBFilters.PerformLayout()
        Me.SampleSetInfo.ResumeLayout(False)
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_NewSampleSetIDAccept As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView_Sample_Set As System.Windows.Forms.DataGridView
    Friend WithEvents B_Select_Sample_Set As System.Windows.Forms.Button
    Friend WithEvents B_Physical_Environment As System.Windows.Forms.Button
    Friend WithEvents ISLILogNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ILLI1LogNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ILLI2LogNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L_Name_SLI_Irradiation_Log As System.Windows.Forms.Label
    Friend WithEvents L_Name_LLI_Irradiation_Log As System.Windows.Forms.Label
    Friend WithEvents B_Select_SLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents B_New_SLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_SLI_Irradiation_Log As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_Sample_Set As System.Windows.Forms.Label
    Friend WithEvents Table_SRM_Set_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_SRM_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter
    Friend WithEvents B_Select_SRM_Set As System.Windows.Forms.Button
    Friend WithEvents B_New_SRM_Set_Accept As System.Windows.Forms.Button
    Friend WithEvents Table_SRM_SetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents L_Name_SRM_Set As System.Windows.Forms.Label
    Friend WithEvents L_Name_Monitor_Set As System.Windows.Forms.Label
    Friend WithEvents Table_Monitor_SetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Table_Monitor_Set_TableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter
    Friend WithEvents B_Select_Monitor_Set As System.Windows.Forms.Button
    Friend WithEvents B_New_Monitor_Set_Accept As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_LLI_Irradiation_Log As System.Windows.Forms.MaskedTextBox
    Friend WithEvents B_Select_LLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents B_New_LLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents L_Count As System.Windows.Forms.Label
    Friend WithEvents L_Monitor As System.Windows.Forms.Label
    Friend WithEvents ListBox_SLI_Irradiation_Log_Date As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_LLI_Irradiation_Log_Date As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_Monitor_SRM As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_Monitor_Monitor As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView_Description As System.Windows.Forms.DataGridView
    Friend WithEvents Cell_Color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L_Name_Sample_Set_View As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sample_Set_View As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Journal_Of_Irradiation_View As System.Windows.Forms.ComboBox
    Friend WithEvents OpenSet As System.Windows.Forms.Button
    Friend WithEvents ChangeLang As System.Windows.Forms.Button
    Friend WithEvents SRMSetNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetWeightDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetPurchasingDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GBFilters As System.Windows.Forms.GroupBox
    Friend WithEvents SampleSetInfo As System.Windows.Forms.GroupBox
    Friend WithEvents LFilterField As System.Windows.Forms.Label
    Friend WithEvents CBFilter As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonshowAll As Button
    Friend WithEvents B_Refresh As Button
    Friend WithEvents ButtonShowAllSrms As Button
    Friend WithEvents BackgroundWorkerColorizer As System.ComponentModel.BackgroundWorker
End Class
