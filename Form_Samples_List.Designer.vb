<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Samples_List
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
        Me.NAA_DB_EXPDataSet = New NaaDB.NAA_DB_EXPDataSet()
        Me.Table_SampleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_SampleTableAdapter = New NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_TableAdapter()
        Me.TableAdapterManager = New NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager()
        Me.B_Insert_New_Sample_Into_Sample_Set = New System.Windows.Forms.Button()
        Me.Label_Name_Code = New System.Windows.Forms.Label()
        Me.L_SS_Sample_Set_ID = New System.Windows.Forms.Label()
        Me.L_SS_Client_ID = New System.Windows.Forms.Label()
        Me.L_SS_Year = New System.Windows.Forms.Label()
        Me.L_SS_Country_Code = New System.Windows.Forms.Label()
        Me.ListBox_Sample_ID = New System.Windows.Forms.ListBox()
        Me.L_Name_Sample_ID = New System.Windows.Forms.Label()
        Me.MaskedTextBox_New_Sample_ID = New System.Windows.Forms.MaskedTextBox()
        Me.L_Name_New_Sample_ID = New System.Windows.Forms.Label()
        Me.B_Correct_Information_About_Sample = New System.Windows.Forms.Button()
        Me.B_Samples_Preparation = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.L_SS_Sample_Set_Index = New System.Windows.Forms.Label()
        Me.B_NAA_Results = New System.Windows.Forms.Button()
        Me.B_Insert_All_Samples_Into_Sample_Set = New System.Windows.Forms.Button()
        Me.Button_ShowNotice = New System.Windows.Forms.Button()
        Me.BShowSumAbEls = New System.Windows.Forms.Button()
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_SampleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NAA_DB_EXPDataSet
        '
        Me.NAA_DB_EXPDataSet.DataSetName = "NAA_DB_EXPDataSet"
        Me.NAA_DB_EXPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_SampleBindingSource
        '
        Me.Table_SampleBindingSource.DataMember = "table_Sample"
        Me.Table_SampleBindingSource.DataSource = Me.NAA_DB_EXPDataSet
        '
        'Table_SampleTableAdapter
        '
        Me.Table_SampleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.table_Sample_TableAdapter = Me.Table_SampleTableAdapter
        Me.TableAdapterManager.table_Sample_TypeTableAdapter = Nothing
        Me.TableAdapterManager.table_SLI_Irradiation_LogTableAdapter = Nothing
        Me.TableAdapterManager.table_SRM_SetTableAdapter = Nothing
        Me.TableAdapterManager.table_SRMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'B_Insert_New_Sample_Into_Sample_Set
        '
        Me.B_Insert_New_Sample_Into_Sample_Set.Location = New System.Drawing.Point(12, 73)
        Me.B_Insert_New_Sample_Into_Sample_Set.Name = "B_Insert_New_Sample_Into_Sample_Set"
        Me.B_Insert_New_Sample_Into_Sample_Set.Size = New System.Drawing.Size(269, 23)
        Me.B_Insert_New_Sample_Into_Sample_Set.TabIndex = 2
        Me.B_Insert_New_Sample_Into_Sample_Set.Text = "Insert new sample into sample set"
        Me.B_Insert_New_Sample_Into_Sample_Set.UseVisualStyleBackColor = True
        '
        'Label_Name_Code
        '
        Me.Label_Name_Code.AutoSize = True
        Me.Label_Name_Code.Location = New System.Drawing.Point(-2, 8)
        Me.Label_Name_Code.Name = "Label_Name_Code"
        Me.Label_Name_Code.Size = New System.Drawing.Size(177, 13)
        Me.Label_Name_Code.TabIndex = 135
        Me.Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
        '
        'L_SS_Sample_Set_ID
        '
        Me.L_SS_Sample_Set_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_ID.Location = New System.Drawing.Point(110, 21)
        Me.L_SS_Sample_Set_ID.Name = "L_SS_Sample_Set_ID"
        Me.L_SS_Sample_Set_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Sample_Set_ID.TabIndex = 133
        '
        'L_SS_Client_ID
        '
        Me.L_SS_Client_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Client_ID.Location = New System.Drawing.Point(50, 21)
        Me.L_SS_Client_ID.Name = "L_SS_Client_ID"
        Me.L_SS_Client_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Client_ID.TabIndex = 131
        '
        'L_SS_Year
        '
        Me.L_SS_Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Year.Location = New System.Drawing.Point(80, 21)
        Me.L_SS_Year.Name = "L_SS_Year"
        Me.L_SS_Year.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Year.TabIndex = 130
        '
        'L_SS_Country_Code
        '
        Me.L_SS_Country_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Country_Code.Location = New System.Drawing.Point(15, 21)
        Me.L_SS_Country_Code.Name = "L_SS_Country_Code"
        Me.L_SS_Country_Code.Size = New System.Drawing.Size(26, 14)
        Me.L_SS_Country_Code.TabIndex = 128
        '
        'ListBox_Sample_ID
        '
        Me.ListBox_Sample_ID.FormattingEnabled = True
        Me.ListBox_Sample_ID.Location = New System.Drawing.Point(287, 24)
        Me.ListBox_Sample_ID.Name = "ListBox_Sample_ID"
        Me.ListBox_Sample_ID.Size = New System.Drawing.Size(55, 251)
        Me.ListBox_Sample_ID.TabIndex = 137
        '
        'L_Name_Sample_ID
        '
        Me.L_Name_Sample_ID.AutoSize = True
        Me.L_Name_Sample_ID.Location = New System.Drawing.Point(291, 8)
        Me.L_Name_Sample_ID.Name = "L_Name_Sample_ID"
        Me.L_Name_Sample_ID.Size = New System.Drawing.Size(56, 13)
        Me.L_Name_Sample_ID.TabIndex = 136
        Me.L_Name_Sample_ID.Text = "Sample ID"
        '
        'MaskedTextBox_New_Sample_ID
        '
        Me.MaskedTextBox_New_Sample_ID.Location = New System.Drawing.Point(195, 21)
        Me.MaskedTextBox_New_Sample_ID.Mask = "90"
        Me.MaskedTextBox_New_Sample_ID.Name = "MaskedTextBox_New_Sample_ID"
        Me.MaskedTextBox_New_Sample_ID.Size = New System.Drawing.Size(31, 20)
        Me.MaskedTextBox_New_Sample_ID.TabIndex = 139
        '
        'L_Name_New_Sample_ID
        '
        Me.L_Name_New_Sample_ID.AutoSize = True
        Me.L_Name_New_Sample_ID.Location = New System.Drawing.Point(176, 8)
        Me.L_Name_New_Sample_ID.Name = "L_Name_New_Sample_ID"
        Me.L_Name_New_Sample_ID.Size = New System.Drawing.Size(79, 13)
        Me.L_Name_New_Sample_ID.TabIndex = 138
        Me.L_Name_New_Sample_ID.Text = "New sample ID"
        '
        'B_Correct_Information_About_Sample
        '
        Me.B_Correct_Information_About_Sample.Location = New System.Drawing.Point(12, 102)
        Me.B_Correct_Information_About_Sample.Name = "B_Correct_Information_About_Sample"
        Me.B_Correct_Information_About_Sample.Size = New System.Drawing.Size(269, 23)
        Me.B_Correct_Information_About_Sample.TabIndex = 140
        Me.B_Correct_Information_About_Sample.Text = "Change information about sample"
        Me.B_Correct_Information_About_Sample.UseVisualStyleBackColor = True
        '
        'B_Samples_Preparation
        '
        Me.B_Samples_Preparation.Location = New System.Drawing.Point(12, 131)
        Me.B_Samples_Preparation.Name = "B_Samples_Preparation"
        Me.B_Samples_Preparation.Size = New System.Drawing.Size(269, 23)
        Me.B_Samples_Preparation.TabIndex = 141
        Me.B_Samples_Preparation.Text = "Samples preparation"
        Me.B_Samples_Preparation.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(12, 252)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(269, 23)
        Me.B_Close.TabIndex = 145
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'L_SS_Sample_Set_Index
        '
        Me.L_SS_Sample_Set_Index.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_Index.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_SS_Sample_Set_Index.Location = New System.Drawing.Point(140, 21)
        Me.L_SS_Sample_Set_Index.Name = "L_SS_Sample_Set_Index"
        Me.L_SS_Sample_Set_Index.Size = New System.Drawing.Size(24, 20)
        Me.L_SS_Sample_Set_Index.TabIndex = 172
        '
        'B_NAA_Results
        '
        Me.B_NAA_Results.Location = New System.Drawing.Point(12, 161)
        Me.B_NAA_Results.Name = "B_NAA_Results"
        Me.B_NAA_Results.Size = New System.Drawing.Size(269, 23)
        Me.B_NAA_Results.TabIndex = 173
        Me.B_NAA_Results.Text = "NAA results"
        Me.B_NAA_Results.UseVisualStyleBackColor = True
        '
        'B_Insert_All_Samples_Into_Sample_Set
        '
        Me.B_Insert_All_Samples_Into_Sample_Set.Location = New System.Drawing.Point(12, 44)
        Me.B_Insert_All_Samples_Into_Sample_Set.Name = "B_Insert_All_Samples_Into_Sample_Set"
        Me.B_Insert_All_Samples_Into_Sample_Set.Size = New System.Drawing.Size(269, 23)
        Me.B_Insert_All_Samples_Into_Sample_Set.TabIndex = 174
        Me.B_Insert_All_Samples_Into_Sample_Set.Text = "Insert all samples into sample set"
        Me.B_Insert_All_Samples_Into_Sample_Set.UseVisualStyleBackColor = True
        '
        'Button_ShowNotice
        '
        Me.Button_ShowNotice.Location = New System.Drawing.Point(12, 190)
        Me.Button_ShowNotice.Name = "Button_ShowNotice"
        Me.Button_ShowNotice.Size = New System.Drawing.Size(269, 23)
        Me.Button_ShowNotice.TabIndex = 175
        Me.Button_ShowNotice.Text = "Show Notice"
        Me.Button_ShowNotice.UseVisualStyleBackColor = True
        '
        'BShowSumAbEls
        '
        Me.BShowSumAbEls.Location = New System.Drawing.Point(12, 219)
        Me.BShowSumAbEls.Name = "BShowSumAbEls"
        Me.BShowSumAbEls.Size = New System.Drawing.Size(269, 23)
        Me.BShowSumAbEls.TabIndex = 176
        Me.BShowSumAbEls.Text = "Show elements summary"
        Me.BShowSumAbEls.UseVisualStyleBackColor = True
        '
        'Form_Samples_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 280)
        Me.Controls.Add(Me.BShowSumAbEls)
        Me.Controls.Add(Me.Button_ShowNotice)
        Me.Controls.Add(Me.B_Insert_All_Samples_Into_Sample_Set)
        Me.Controls.Add(Me.B_NAA_Results)
        Me.Controls.Add(Me.L_SS_Sample_Set_Index)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Samples_Preparation)
        Me.Controls.Add(Me.B_Correct_Information_About_Sample)
        Me.Controls.Add(Me.MaskedTextBox_New_Sample_ID)
        Me.Controls.Add(Me.L_Name_New_Sample_ID)
        Me.Controls.Add(Me.ListBox_Sample_ID)
        Me.Controls.Add(Me.L_Name_Sample_ID)
        Me.Controls.Add(Me.Label_Name_Code)
        Me.Controls.Add(Me.L_SS_Sample_Set_ID)
        Me.Controls.Add(Me.L_SS_Client_ID)
        Me.Controls.Add(Me.L_SS_Year)
        Me.Controls.Add(Me.L_SS_Country_Code)
        Me.Controls.Add(Me.B_Insert_New_Sample_Into_Sample_Set)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Samples_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Samples list"
        CType(Me.NAA_DB_EXPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_SampleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NAA_DB_EXPDataSet As NaaDB.NAA_DB_EXPDataSet
    Friend WithEvents Table_SampleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As NaaDB.NAA_DB_EXPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents B_Insert_New_Sample_Into_Sample_Set As System.Windows.Forms.Button
    Friend WithEvents Label_Name_Code As System.Windows.Forms.Label
    Friend WithEvents L_SS_Sample_Set_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Client_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Year As System.Windows.Forms.Label
    Friend WithEvents L_SS_Country_Code As System.Windows.Forms.Label
    Friend WithEvents ListBox_Sample_ID As System.Windows.Forms.ListBox
    Friend WithEvents L_Name_Sample_ID As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_New_Sample_ID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_Name_New_Sample_ID As System.Windows.Forms.Label
    Friend WithEvents B_Correct_Information_About_Sample As System.Windows.Forms.Button
    Friend WithEvents B_Samples_Preparation As System.Windows.Forms.Button
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents L_SS_Sample_Set_Index As System.Windows.Forms.Label
    Friend WithEvents Table_SampleTableAdapter As NaaDB.NAA_DB_EXPDataSetTableAdapters.table_Sample_TableAdapter
    Friend WithEvents B_NAA_Results As System.Windows.Forms.Button
    Friend WithEvents B_Insert_All_Samples_Into_Sample_Set As System.Windows.Forms.Button
    Friend WithEvents Button_ShowNotice As Button
    Friend WithEvents BShowSumAbEls As Button
End Class
