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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.B_NewSampleSetIDAccept = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_Sample_Set = New Zuby.ADGV.AdvancedDataGridView()
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.B_Select_Sample_Set = New System.Windows.Forms.Button()
        Me.B_Physical_Environment = New System.Windows.Forms.Button()
        Me.L_Name_SLI_Irradiation_Log = New System.Windows.Forms.Label()
        Me.L_Name_LLI_Irradiation_Log = New System.Windows.Forms.Label()
        Me.B_Select_SLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.B_New_SLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.B_Select_SRM_Set = New System.Windows.Forms.Button()
        Me.B_New_SRM_Set_Accept = New System.Windows.Forms.Button()
        Me.Table_SRM_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.L_Name_SRM_Set = New System.Windows.Forms.Label()
        Me.L_Name_Monitor_Set = New System.Windows.Forms.Label()
        Me.Table_Monitor_SetDataGridView = New System.Windows.Forms.DataGridView()
        Me.B_Select_Monitor_Set = New System.Windows.Forms.Button()
        Me.B_New_Monitor_Set_Accept = New System.Windows.Forms.Button()
        Me.B_Select_LLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.B_New_LLI_Irradiation_Log = New System.Windows.Forms.Button()
        Me.L_Monitor = New System.Windows.Forms.Label()
        Me.ListBox_SLI_Irradiation_Log_Date = New System.Windows.Forms.ListBox()
        Me.ListBox_LLI_Irradiation_Log_Date = New System.Windows.Forms.ListBox()
        Me.ListBox_Monitor_SRM = New System.Windows.Forms.ListBox()
        Me.ListBox_Monitor_Monitor = New System.Windows.Forms.ListBox()
        Me.DataGridView_Description = New System.Windows.Forms.DataGridView()
        Me.ComboBox_Journal_Of_Irradiation_View = New System.Windows.Forms.ComboBox()
        Me.OpenSet = New System.Windows.Forms.Button()
        Me.SampleSetInfo = New System.Windows.Forms.GroupBox()
        Me.ButtonshowAll = New System.Windows.Forms.Button()
        Me.ButtonShowAllSrms = New System.Windows.Forms.Button()
        Me.BackgroundWorkerColorizer = New System.ComponentModel.BackgroundWorker()
        Me.Table_SRM_Set_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_SRM_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_SRMTableAdapter()
        Me.Table_Monitor_Set_TableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Monitor_SetTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.МенюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLang = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetLoginButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИнформацияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбщееToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaskedTextBoxDateOfNewJournal = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDateOfNewJournalTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBoxIrradiations = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxNotes = New System.Windows.Forms.RichTextBox()
        CType(Me.DataGridView_Sample_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SRM_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Monitor_SetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SampleSetInfo.SuspendLayout()
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_NewSampleSetIDAccept
        '
        Me.B_NewSampleSetIDAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_NewSampleSetIDAccept.Location = New System.Drawing.Point(6, 313)
        Me.B_NewSampleSetIDAccept.Name = "B_NewSampleSetIDAccept"
        Me.B_NewSampleSetIDAccept.Size = New System.Drawing.Size(203, 23)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Sample_Set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Sample_Set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Sample_Set.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView_Sample_Set.Location = New System.Drawing.Point(6, 27)
        Me.DataGridView_Sample_Set.MultiSelect = False
        Me.DataGridView_Sample_Set.Name = "DataGridView_Sample_Set"
        Me.DataGridView_Sample_Set.ReadOnly = True
        Me.DataGridView_Sample_Set.RowHeadersVisible = False
        Me.DataGridView_Sample_Set.RowHeadersWidth = 10
        Me.DataGridView_Sample_Set.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView_Sample_Set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Sample_Set.Size = New System.Drawing.Size(524, 280)
        Me.DataGridView_Sample_Set.TabIndex = 2
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'B_Select_Sample_Set
        '
        Me.B_Select_Sample_Set.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_Select_Sample_Set.Location = New System.Drawing.Point(582, 313)
        Me.B_Select_Sample_Set.Name = "B_Select_Sample_Set"
        Me.B_Select_Sample_Set.Size = New System.Drawing.Size(90, 23)
        Me.B_Select_Sample_Set.TabIndex = 3
        Me.B_Select_Sample_Set.Text = "Select sample set"
        Me.B_Select_Sample_Set.UseVisualStyleBackColor = True
        '
        'B_Physical_Environment
        '
        Me.B_Physical_Environment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.B_Physical_Environment.Location = New System.Drawing.Point(4, 764)
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
        Me.L_Name_SLI_Irradiation_Log.Location = New System.Drawing.Point(681, 11)
        Me.L_Name_SLI_Irradiation_Log.Name = "L_Name_SLI_Irradiation_Log"
        Me.L_Name_SLI_Irradiation_Log.Size = New System.Drawing.Size(88, 13)
        Me.L_Name_SLI_Irradiation_Log.TabIndex = 148
        Me.L_Name_SLI_Irradiation_Log.Text = "SLI irradiation log"
        '
        'L_Name_LLI_Irradiation_Log
        '
        Me.L_Name_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_LLI_Irradiation_Log.AutoSize = True
        Me.L_Name_LLI_Irradiation_Log.Location = New System.Drawing.Point(816, 11)
        Me.L_Name_LLI_Irradiation_Log.Name = "L_Name_LLI_Irradiation_Log"
        Me.L_Name_LLI_Irradiation_Log.Size = New System.Drawing.Size(87, 13)
        Me.L_Name_LLI_Irradiation_Log.TabIndex = 150
        Me.L_Name_LLI_Irradiation_Log.Text = "LLI irradiation log"
        '
        'B_Select_SLI_Irradiation_Log
        '
        Me.B_Select_SLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Select_SLI_Irradiation_Log.Location = New System.Drawing.Point(678, 419)
        Me.B_Select_SLI_Irradiation_Log.Name = "B_Select_SLI_Irradiation_Log"
        Me.B_Select_SLI_Irradiation_Log.Size = New System.Drawing.Size(129, 23)
        Me.B_Select_SLI_Irradiation_Log.TabIndex = 154
        Me.B_Select_SLI_Irradiation_Log.Text = "Select SLI irradiation log"
        Me.B_Select_SLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'B_New_SLI_Irradiation_Log
        '
        Me.B_New_SLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_New_SLI_Irradiation_Log.Location = New System.Drawing.Point(678, 478)
        Me.B_New_SLI_Irradiation_Log.Name = "B_New_SLI_Irradiation_Log"
        Me.B_New_SLI_Irradiation_Log.Size = New System.Drawing.Size(129, 23)
        Me.B_New_SLI_Irradiation_Log.TabIndex = 153
        Me.B_New_SLI_Irradiation_Log.Text = "New SLI irradiation log"
        Me.B_New_SLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'B_Select_SRM_Set
        '
        Me.B_Select_SRM_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_Select_SRM_Set.Location = New System.Drawing.Point(176, 731)
        Me.B_Select_SRM_Set.Name = "B_Select_SRM_Set"
        Me.B_Select_SRM_Set.Size = New System.Drawing.Size(321, 23)
        Me.B_Select_SRM_Set.TabIndex = 159
        Me.B_Select_SRM_Set.Text = "Select SRM set"
        Me.B_Select_SRM_Set.UseVisualStyleBackColor = True
        '
        'B_New_SRM_Set_Accept
        '
        Me.B_New_SRM_Set_Accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_New_SRM_Set_Accept.Location = New System.Drawing.Point(176, 702)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_SRM_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Table_SRM_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_SRM_SetDataGridView.Location = New System.Drawing.Point(6, 552)
        Me.Table_SRM_SetDataGridView.Name = "Table_SRM_SetDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_SRM_SetDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
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
        Me.L_Name_SRM_Set.Location = New System.Drawing.Point(156, 536)
        Me.L_Name_SRM_Set.Name = "L_Name_SRM_Set"
        Me.L_Name_SRM_Set.Size = New System.Drawing.Size(53, 13)
        Me.L_Name_SRM_Set.TabIndex = 160
        Me.L_Name_SRM_Set.Text = "SRM sets"
        '
        'L_Name_Monitor_Set
        '
        Me.L_Name_Monitor_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name_Monitor_Set.AutoSize = True
        Me.L_Name_Monitor_Set.Location = New System.Drawing.Point(746, 536)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Monitor_SetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Table_Monitor_SetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Monitor_SetDataGridView.Location = New System.Drawing.Point(520, 552)
        Me.Table_Monitor_SetDataGridView.Name = "Table_Monitor_SetDataGridView"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table_Monitor_SetDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Table_Monitor_SetDataGridView.RowHeadersVisible = False
        Me.Table_Monitor_SetDataGridView.RowHeadersWidth = 21
        Me.Table_Monitor_SetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table_Monitor_SetDataGridView.Size = New System.Drawing.Size(429, 144)
        Me.Table_Monitor_SetDataGridView.TabIndex = 161
        '
        'B_Select_Monitor_Set
        '
        Me.B_Select_Monitor_Set.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Select_Monitor_Set.Location = New System.Drawing.Point(671, 764)
        Me.B_Select_Monitor_Set.Name = "B_Select_Monitor_Set"
        Me.B_Select_Monitor_Set.Size = New System.Drawing.Size(278, 23)
        Me.B_Select_Monitor_Set.TabIndex = 164
        Me.B_Select_Monitor_Set.Text = "Select monitor set"
        Me.B_Select_Monitor_Set.UseVisualStyleBackColor = True
        '
        'B_New_Monitor_Set_Accept
        '
        Me.B_New_Monitor_Set_Accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_New_Monitor_Set_Accept.Location = New System.Drawing.Point(671, 702)
        Me.B_New_Monitor_Set_Accept.Name = "B_New_Monitor_Set_Accept"
        Me.B_New_Monitor_Set_Accept.Size = New System.Drawing.Size(278, 23)
        Me.B_New_Monitor_Set_Accept.TabIndex = 163
        Me.B_New_Monitor_Set_Accept.Text = "New monitor set acceptance"
        Me.B_New_Monitor_Set_Accept.UseVisualStyleBackColor = True
        '
        'B_Select_LLI_Irradiation_Log
        '
        Me.B_Select_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Select_LLI_Irradiation_Log.Location = New System.Drawing.Point(817, 419)
        Me.B_Select_LLI_Irradiation_Log.Name = "B_Select_LLI_Irradiation_Log"
        Me.B_Select_LLI_Irradiation_Log.Size = New System.Drawing.Size(131, 23)
        Me.B_Select_LLI_Irradiation_Log.TabIndex = 166
        Me.B_Select_LLI_Irradiation_Log.Text = "Select LLI irradiation log"
        Me.B_Select_LLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'B_New_LLI_Irradiation_Log
        '
        Me.B_New_LLI_Irradiation_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_New_LLI_Irradiation_Log.Location = New System.Drawing.Point(817, 478)
        Me.B_New_LLI_Irradiation_Log.Name = "B_New_LLI_Irradiation_Log"
        Me.B_New_LLI_Irradiation_Log.Size = New System.Drawing.Size(129, 23)
        Me.B_New_LLI_Irradiation_Log.TabIndex = 165
        Me.B_New_LLI_Irradiation_Log.Text = "New LLI irradiation log"
        Me.B_New_LLI_Irradiation_Log.UseVisualStyleBackColor = True
        '
        'L_Monitor
        '
        Me.L_Monitor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Monitor.Location = New System.Drawing.Point(6, 20)
        Me.L_Monitor.Name = "L_Monitor"
        Me.L_Monitor.Size = New System.Drawing.Size(197, 137)
        Me.L_Monitor.TabIndex = 169
        Me.L_Monitor.Text = "Gen"
        '
        'ListBox_SLI_Irradiation_Log_Date
        '
        Me.ListBox_SLI_Irradiation_Log_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_SLI_Irradiation_Log_Date.FormattingEnabled = True
        Me.ListBox_SLI_Irradiation_Log_Date.Location = New System.Drawing.Point(681, 29)
        Me.ListBox_SLI_Irradiation_Log_Date.Name = "ListBox_SLI_Irradiation_Log_Date"
        Me.ListBox_SLI_Irradiation_Log_Date.Size = New System.Drawing.Size(129, 355)
        Me.ListBox_SLI_Irradiation_Log_Date.TabIndex = 170
        '
        'ListBox_LLI_Irradiation_Log_Date
        '
        Me.ListBox_LLI_Irradiation_Log_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_LLI_Irradiation_Log_Date.FormattingEnabled = True
        Me.ListBox_LLI_Irradiation_Log_Date.Location = New System.Drawing.Point(820, 29)
        Me.ListBox_LLI_Irradiation_Log_Date.Name = "ListBox_LLI_Irradiation_Log_Date"
        Me.ListBox_LLI_Irradiation_Log_Date.Size = New System.Drawing.Size(129, 355)
        Me.ListBox_LLI_Irradiation_Log_Date.TabIndex = 171
        '
        'ListBox_Monitor_SRM
        '
        Me.ListBox_Monitor_SRM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Monitor_SRM.FormattingEnabled = True
        Me.ListBox_Monitor_SRM.Location = New System.Drawing.Point(6, 702)
        Me.ListBox_Monitor_SRM.Name = "ListBox_Monitor_SRM"
        Me.ListBox_Monitor_SRM.Size = New System.Drawing.Size(164, 56)
        Me.ListBox_Monitor_SRM.TabIndex = 174
        '
        'ListBox_Monitor_Monitor
        '
        Me.ListBox_Monitor_Monitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Monitor_Monitor.FormattingEnabled = True
        Me.ListBox_Monitor_Monitor.Location = New System.Drawing.Point(520, 702)
        Me.ListBox_Monitor_Monitor.Name = "ListBox_Monitor_Monitor"
        Me.ListBox_Monitor_Monitor.Size = New System.Drawing.Size(145, 82)
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Description.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_Description.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Description.Location = New System.Drawing.Point(536, 27)
        Me.DataGridView_Description.MultiSelect = False
        Me.DataGridView_Description.Name = "DataGridView_Description"
        Me.DataGridView_Description.ReadOnly = True
        Me.DataGridView_Description.RowHeadersVisible = False
        Me.DataGridView_Description.RowHeadersWidth = 21
        Me.DataGridView_Description.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView_Description.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Description.Size = New System.Drawing.Size(136, 280)
        Me.DataGridView_Description.TabIndex = 176
        '
        'ComboBox_Journal_Of_Irradiation_View
        '
        Me.ComboBox_Journal_Of_Irradiation_View.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Journal_Of_Irradiation_View.FormattingEnabled = True
        Me.ComboBox_Journal_Of_Irradiation_View.Items.AddRange(New Object() {"Current year", "All time"})
        Me.ComboBox_Journal_Of_Irradiation_View.Location = New System.Drawing.Point(678, 392)
        Me.ComboBox_Journal_Of_Irradiation_View.Name = "ComboBox_Journal_Of_Irradiation_View"
        Me.ComboBox_Journal_Of_Irradiation_View.Size = New System.Drawing.Size(268, 21)
        Me.ComboBox_Journal_Of_Irradiation_View.TabIndex = 180
        '
        'OpenSet
        '
        Me.OpenSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OpenSet.Location = New System.Drawing.Point(256, 313)
        Me.OpenSet.Name = "OpenSet"
        Me.OpenSet.Size = New System.Drawing.Size(170, 23)
        Me.OpenSet.TabIndex = 181
        Me.OpenSet.Text = "Просмотр"
        Me.OpenSet.UseVisualStyleBackColor = True
        '
        'SampleSetInfo
        '
        Me.SampleSetInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleSetInfo.Controls.Add(Me.RichTextBoxNotes)
        Me.SampleSetInfo.Controls.Add(Me.RichTextBoxIrradiations)
        Me.SampleSetInfo.Controls.Add(Me.L_Monitor)
        Me.SampleSetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SampleSetInfo.Location = New System.Drawing.Point(6, 342)
        Me.SampleSetInfo.Name = "SampleSetInfo"
        Me.SampleSetInfo.Size = New System.Drawing.Size(666, 160)
        Me.SampleSetInfo.TabIndex = 190
        Me.SampleSetInfo.TabStop = False
        Me.SampleSetInfo.Text = "Информация о выбранной партии"
        '
        'ButtonshowAll
        '
        Me.ButtonshowAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonshowAll.Location = New System.Drawing.Point(432, 313)
        Me.ButtonshowAll.Name = "ButtonshowAll"
        Me.ButtonshowAll.Size = New System.Drawing.Size(133, 23)
        Me.ButtonshowAll.TabIndex = 192
        Me.ButtonshowAll.Text = "Сброс фильтров"
        Me.ButtonshowAll.UseVisualStyleBackColor = True
        '
        'ButtonShowAllSrms
        '
        Me.ButtonShowAllSrms.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonShowAllSrms.Location = New System.Drawing.Point(244, 764)
        Me.ButtonShowAllSrms.Name = "ButtonShowAllSrms"
        Me.ButtonShowAllSrms.Size = New System.Drawing.Size(253, 23)
        Me.ButtonShowAllSrms.TabIndex = 195
        Me.ButtonShowAllSrms.Text = "ShowAllSRMs"
        Me.ButtonShowAllSrms.UseVisualStyleBackColor = True
        '
        'Table_SRM_Set_BindingSource
        '
        Me.Table_SRM_Set_BindingSource.DataMember = "table_SRM_Set"
        Me.Table_SRM_Set_BindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_SRM_TableAdapter
        '
        Me.Table_SRM_TableAdapter.ClearBeforeFill = True
        '
        'Table_Monitor_Set_TableAdapter
        '
        Me.Table_Monitor_Set_TableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МенюToolStripMenuItem, Me.ИнформацияToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 24)
        Me.MenuStrip1.TabIndex = 196
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'МенюToolStripMenuItem
        '
        Me.МенюToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeLang, Me.B_Refresh, Me.ResetLoginButton})
        Me.МенюToolStripMenuItem.Name = "МенюToolStripMenuItem"
        Me.МенюToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.МенюToolStripMenuItem.Text = "Меню"
        '
        'ChangeLang
        '
        Me.ChangeLang.Name = "ChangeLang"
        Me.ChangeLang.Size = New System.Drawing.Size(132, 22)
        Me.ChangeLang.Text = "Lang"
        '
        'B_Refresh
        '
        Me.B_Refresh.Name = "B_Refresh"
        Me.B_Refresh.Size = New System.Drawing.Size(132, 22)
        Me.B_Refresh.Text = "Обновить"
        '
        'ResetLoginButton
        '
        Me.ResetLoginButton.Name = "ResetLoginButton"
        Me.ResetLoginButton.Size = New System.Drawing.Size(132, 22)
        Me.ResetLoginButton.Text = "Reset login"
        '
        'ИнформацияToolStripMenuItem
        '
        Me.ИнформацияToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОбщееToolStripMenuItem})
        Me.ИнформацияToolStripMenuItem.Name = "ИнформацияToolStripMenuItem"
        Me.ИнформацияToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ИнформацияToolStripMenuItem.Text = "Информация"
        '
        'ОбщееToolStripMenuItem
        '
        Me.ОбщееToolStripMenuItem.Name = "ОбщееToolStripMenuItem"
        Me.ОбщееToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ОбщееToolStripMenuItem.Text = "Общее"
        '
        'MaskedTextBoxDateOfNewJournal
        '
        Me.MaskedTextBoxDateOfNewJournal.BackColor = System.Drawing.Color.White
        Me.MaskedTextBoxDateOfNewJournal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxDateOfNewJournal.Location = New System.Drawing.Point(876, 450)
        Me.MaskedTextBoxDateOfNewJournal.Mask = "00/00/0000"
        Me.MaskedTextBoxDateOfNewJournal.Name = "MaskedTextBoxDateOfNewJournal"
        Me.MaskedTextBoxDateOfNewJournal.Size = New System.Drawing.Size(70, 22)
        Me.MaskedTextBoxDateOfNewJournal.TabIndex = 197
        Me.MaskedTextBoxDateOfNewJournal.ValidatingType = GetType(Date)
        '
        'LabelDateOfNewJournalTitle
        '
        Me.LabelDateOfNewJournalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateOfNewJournalTitle.Location = New System.Drawing.Point(678, 445)
        Me.LabelDateOfNewJournalTitle.Name = "LabelDateOfNewJournalTitle"
        Me.LabelDateOfNewJournalTitle.Size = New System.Drawing.Size(192, 30)
        Me.LabelDateOfNewJournalTitle.TabIndex = 198
        Me.LabelDateOfNewJournalTitle.Text = "Установите дату нового" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "журнала"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(468, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 41)
        Me.Button1.TabIndex = 199
        Me.Button1.Text = "⮟ ⮝"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBoxIrradiations
        '
        Me.RichTextBoxIrradiations.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBoxIrradiations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxIrradiations.Location = New System.Drawing.Point(209, 20)
        Me.RichTextBoxIrradiations.Name = "RichTextBoxIrradiations"
        Me.RichTextBoxIrradiations.Size = New System.Drawing.Size(229, 134)
        Me.RichTextBoxIrradiations.TabIndex = 172
        Me.RichTextBoxIrradiations.Text = ""
        '
        'RichTextBoxNotes
        '
        Me.RichTextBoxNotes.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxNotes.Location = New System.Drawing.Point(440, 20)
        Me.RichTextBoxNotes.Name = "RichTextBoxNotes"
        Me.RichTextBoxNotes.Size = New System.Drawing.Size(220, 134)
        Me.RichTextBoxNotes.TabIndex = 173
        Me.RichTextBoxNotes.Text = ""
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 792)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelDateOfNewJournalTitle)
        Me.Controls.Add(Me.MaskedTextBoxDateOfNewJournal)
        Me.Controls.Add(Me.ButtonShowAllSrms)
        Me.Controls.Add(Me.ButtonshowAll)
        Me.Controls.Add(Me.SampleSetInfo)
        Me.Controls.Add(Me.OpenSet)
        Me.Controls.Add(Me.ComboBox_Journal_Of_Irradiation_View)
        Me.Controls.Add(Me.DataGridView_Description)
        Me.Controls.Add(Me.ListBox_Monitor_Monitor)
        Me.Controls.Add(Me.ListBox_Monitor_SRM)
        Me.Controls.Add(Me.ListBox_LLI_Irradiation_Log_Date)
        Me.Controls.Add(Me.ListBox_SLI_Irradiation_Log_Date)
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
        Me.Controls.Add(Me.B_Select_SLI_Irradiation_Log)
        Me.Controls.Add(Me.B_New_SLI_Irradiation_Log)
        Me.Controls.Add(Me.L_Name_LLI_Irradiation_Log)
        Me.Controls.Add(Me.L_Name_SLI_Irradiation_Log)
        Me.Controls.Add(Me.B_Physical_Environment)
        Me.Controls.Add(Me.B_Select_Sample_Set)
        Me.Controls.Add(Me.DataGridView_Sample_Set)
        Me.Controls.Add(Me.B_NewSampleSetIDAccept)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView_Sample_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SRM_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Monitor_SetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Description, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SampleSetInfo.ResumeLayout(False)
        CType(Me.Table_SRM_Set_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_NewSampleSetIDAccept As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView_Sample_Set As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents NAA_DB_EXPDataSet As NAA_DB_EXPDataSet
    Friend WithEvents B_Select_Sample_Set As System.Windows.Forms.Button
    Friend WithEvents B_Physical_Environment As System.Windows.Forms.Button
    Friend WithEvents ISLILogNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ILLI1LogNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ILLI2LogNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L_Name_SLI_Irradiation_Log As System.Windows.Forms.Label
    Friend WithEvents L_Name_LLI_Irradiation_Log As System.Windows.Forms.Label
    Friend WithEvents B_Select_SLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents B_New_SLI_Irradiation_Log As System.Windows.Forms.Button
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
    Friend WithEvents B_Select_LLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents B_New_LLI_Irradiation_Log As System.Windows.Forms.Button
    Friend WithEvents L_Monitor As System.Windows.Forms.Label
    Friend WithEvents ListBox_SLI_Irradiation_Log_Date As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_LLI_Irradiation_Log_Date As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_Monitor_SRM As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_Monitor_Monitor As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView_Description As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox_Journal_Of_Irradiation_View As System.Windows.Forms.ComboBox
    Friend WithEvents OpenSet As System.Windows.Forms.Button
    Friend WithEvents SRMSetNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetWeightDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRMSetPurchasingDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleSetInfo As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonshowAll As Button
    Friend WithEvents ButtonShowAllSrms As Button
    Friend WithEvents BackgroundWorkerColorizer As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents МенюToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeLang As ToolStripMenuItem
    Friend WithEvents B_Refresh As ToolStripMenuItem
    Friend WithEvents ResetLoginButton As ToolStripMenuItem
    Friend WithEvents MaskedTextBoxDateOfNewJournal As MaskedTextBox
    Friend WithEvents LabelDateOfNewJournalTitle As Label
    Friend WithEvents ИнформацияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбщееToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBoxNotes As RichTextBox
    Friend WithEvents RichTextBoxIrradiations As RichTextBox
End Class
