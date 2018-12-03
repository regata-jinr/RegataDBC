<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_NAA_Results
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
        Me.B_Close = New System.Windows.Forms.Button()
        Me.B_Fill_In_From_File = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Fill_In_From_File_NAA_Results = New System.Windows.Forms.OpenFileDialog()
        Me.L_SS_Sample_Set_Index = New System.Windows.Forms.Label()
        Me.L_Name_Code = New System.Windows.Forms.Label()
        Me.L_SS_Sample_Set_ID = New System.Windows.Forms.Label()
        Me.L_SS_Client_ID = New System.Windows.Forms.Label()
        Me.L_SS_Year = New System.Windows.Forms.Label()
        Me.L_SS_Country_Code = New System.Windows.Forms.Label()
        Me.DataGridView_Table_Sample_NAA_Results = New System.Windows.Forms.DataGridView()
        Me.L_SS_Sample_ID = New System.Windows.Forms.Label()
        Me.B_Save = New System.Windows.Forms.Button()
        Me.ComboBox_Person = New System.Windows.Forms.ComboBox()
        Me.Clear_Table = New System.Windows.Forms.Button()
        Me.B_Save_Final_Report = New System.Windows.Forms.Button()
        Me.SaveFileDialog_Final_Report = New System.Windows.Forms.SaveFileDialog()
        Me.L_Name_Person = New System.Windows.Forms.Label()
        Me.ProgressBar_Fill_From_File = New System.Windows.Forms.ProgressBar()
        Me.Label_ProgressBar_Save_File_CON = New System.Windows.Forms.Label()
        Me.Panel_ProgressBar_Save_File_CON = New System.Windows.Forms.Panel()
        Me.HidBox = New System.Windows.Forms.GroupBox()
        Me.CBHideAll = New System.Windows.Forms.CheckBox()
        Me.CBCol5 = New System.Windows.Forms.CheckBox()
        Me.CBCol4 = New System.Windows.Forms.CheckBox()
        Me.CBCol3 = New System.Windows.Forms.CheckBox()
        Me.CBCol2 = New System.Windows.Forms.CheckBox()
        Me.CBCol1 = New System.Windows.Forms.CheckBox()
        Me.CBCol0 = New System.Windows.Forms.CheckBox()
        Me.HidEmptEl = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView_Table_Sample_NAA_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ProgressBar_Save_File_CON.SuspendLayout()
        Me.HidBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(853, 580)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(170, 23)
        Me.B_Close.TabIndex = 4
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'B_Fill_In_From_File
        '
        Me.B_Fill_In_From_File.Location = New System.Drawing.Point(149, 580)
        Me.B_Fill_In_From_File.Name = "B_Fill_In_From_File"
        Me.B_Fill_In_From_File.Size = New System.Drawing.Size(170, 23)
        Me.B_Fill_In_From_File.TabIndex = 176
        Me.B_Fill_In_From_File.Text = "Fill in from file"
        Me.B_Fill_In_From_File.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_Fill_In_From_File_NAA_Results
        '
        Me.OpenFileDialog_Fill_In_From_File_NAA_Results.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        '
        'L_SS_Sample_Set_Index
        '
        Me.L_SS_Sample_Set_Index.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_Index.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_SS_Sample_Set_Index.Location = New System.Drawing.Point(429, 22)
        Me.L_SS_Sample_Set_Index.Name = "L_SS_Sample_Set_Index"
        Me.L_SS_Sample_Set_Index.Size = New System.Drawing.Size(24, 25)
        Me.L_SS_Sample_Set_Index.TabIndex = 191
        '
        'L_Name_Code
        '
        Me.L_Name_Code.AutoSize = True
        Me.L_Name_Code.Location = New System.Drawing.Point(291, 9)
        Me.L_Name_Code.Name = "L_Name_Code"
        Me.L_Name_Code.Size = New System.Drawing.Size(177, 13)
        Me.L_Name_Code.TabIndex = 190
        Me.L_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
        '
        'L_SS_Sample_Set_ID
        '
        Me.L_SS_Sample_Set_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_Set_ID.Location = New System.Drawing.Point(399, 22)
        Me.L_SS_Sample_Set_ID.Name = "L_SS_Sample_Set_ID"
        Me.L_SS_Sample_Set_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Sample_Set_ID.TabIndex = 189
        '
        'L_SS_Client_ID
        '
        Me.L_SS_Client_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Client_ID.Location = New System.Drawing.Point(339, 22)
        Me.L_SS_Client_ID.Name = "L_SS_Client_ID"
        Me.L_SS_Client_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Client_ID.TabIndex = 188
        '
        'L_SS_Year
        '
        Me.L_SS_Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Year.Location = New System.Drawing.Point(369, 22)
        Me.L_SS_Year.Name = "L_SS_Year"
        Me.L_SS_Year.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Year.TabIndex = 187
        '
        'L_SS_Country_Code
        '
        Me.L_SS_Country_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Country_Code.Location = New System.Drawing.Point(305, 22)
        Me.L_SS_Country_Code.Name = "L_SS_Country_Code"
        Me.L_SS_Country_Code.Size = New System.Drawing.Size(26, 14)
        Me.L_SS_Country_Code.TabIndex = 186
        '
        'DataGridView_Table_Sample_NAA_Results
        '
        Me.DataGridView_Table_Sample_NAA_Results.AllowUserToAddRows = False
        Me.DataGridView_Table_Sample_NAA_Results.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Sample_NAA_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Table_Sample_NAA_Results.Location = New System.Drawing.Point(3, 85)
        Me.DataGridView_Table_Sample_NAA_Results.Name = "DataGridView_Table_Sample_NAA_Results"
        Me.DataGridView_Table_Sample_NAA_Results.RowHeadersVisible = False
        Me.DataGridView_Table_Sample_NAA_Results.RowHeadersWidth = 21
        Me.DataGridView_Table_Sample_NAA_Results.Size = New System.Drawing.Size(1188, 489)
        Me.DataGridView_Table_Sample_NAA_Results.TabIndex = 193
        Me.DataGridView_Table_Sample_NAA_Results.VirtualMode = True
        '
        'L_SS_Sample_ID
        '
        Me.L_SS_Sample_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_SS_Sample_ID.Location = New System.Drawing.Point(459, 22)
        Me.L_SS_Sample_ID.Name = "L_SS_Sample_ID"
        Me.L_SS_Sample_ID.Size = New System.Drawing.Size(24, 14)
        Me.L_SS_Sample_ID.TabIndex = 194
        Me.L_SS_Sample_ID.Visible = False
        '
        'B_Save
        '
        Me.B_Save.Location = New System.Drawing.Point(501, 580)
        Me.B_Save.Name = "B_Save"
        Me.B_Save.Size = New System.Drawing.Size(170, 23)
        Me.B_Save.TabIndex = 195
        Me.B_Save.Text = "Save into DB"
        Me.B_Save.UseVisualStyleBackColor = True
        '
        'ComboBox_Person
        '
        Me.ComboBox_Person.DisplayMember = "Received_By"
        Me.ComboBox_Person.FormattingEnabled = True
        Me.ComboBox_Person.Location = New System.Drawing.Point(489, 22)
        Me.ComboBox_Person.Name = "ComboBox_Person"
        Me.ComboBox_Person.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_Person.TabIndex = 198
        Me.ComboBox_Person.ValueMember = "Received_By"
        '
        'Clear_Table
        '
        Me.Clear_Table.Location = New System.Drawing.Point(325, 580)
        Me.Clear_Table.Name = "Clear_Table"
        Me.Clear_Table.Size = New System.Drawing.Size(170, 23)
        Me.Clear_Table.TabIndex = 201
        Me.Clear_Table.Text = "Clear table"
        Me.Clear_Table.UseVisualStyleBackColor = True
        '
        'B_Save_Final_Report
        '
        Me.B_Save_Final_Report.Location = New System.Drawing.Point(677, 580)
        Me.B_Save_Final_Report.Name = "B_Save_Final_Report"
        Me.B_Save_Final_Report.Size = New System.Drawing.Size(170, 23)
        Me.B_Save_Final_Report.TabIndex = 203
        Me.B_Save_Final_Report.Text = "Save final report"
        Me.B_Save_Final_Report.UseVisualStyleBackColor = True
        '
        'SaveFileDialog_Final_Report
        '
        Me.SaveFileDialog_Final_Report.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        '
        'L_Name_Person
        '
        Me.L_Name_Person.AutoSize = True
        Me.L_Name_Person.Location = New System.Drawing.Point(547, 6)
        Me.L_Name_Person.Name = "L_Name_Person"
        Me.L_Name_Person.Size = New System.Drawing.Size(40, 13)
        Me.L_Name_Person.TabIndex = 204
        Me.L_Name_Person.Text = "Person"
        '
        'ProgressBar_Fill_From_File
        '
        Me.ProgressBar_Fill_From_File.Location = New System.Drawing.Point(19, 28)
        Me.ProgressBar_Fill_From_File.Name = "ProgressBar_Fill_From_File"
        Me.ProgressBar_Fill_From_File.Size = New System.Drawing.Size(271, 23)
        Me.ProgressBar_Fill_From_File.TabIndex = 24
        Me.ProgressBar_Fill_From_File.Visible = False
        '
        'Label_ProgressBar_Save_File_CON
        '
        Me.Label_ProgressBar_Save_File_CON.AutoSize = True
        Me.Label_ProgressBar_Save_File_CON.Location = New System.Drawing.Point(69, 15)
        Me.Label_ProgressBar_Save_File_CON.Name = "Label_ProgressBar_Save_File_CON"
        Me.Label_ProgressBar_Save_File_CON.Size = New System.Drawing.Size(169, 13)
        Me.Label_ProgressBar_Save_File_CON.TabIndex = 25
        Me.Label_ProgressBar_Save_File_CON.Text = "Ждите, идет обработка данных!"
        Me.Label_ProgressBar_Save_File_CON.Visible = False
        '
        'Panel_ProgressBar_Save_File_CON
        '
        Me.Panel_ProgressBar_Save_File_CON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_ProgressBar_Save_File_CON.Controls.Add(Me.Label_ProgressBar_Save_File_CON)
        Me.Panel_ProgressBar_Save_File_CON.Controls.Add(Me.ProgressBar_Fill_From_File)
        Me.Panel_ProgressBar_Save_File_CON.Location = New System.Drawing.Point(438, 274)
        Me.Panel_ProgressBar_Save_File_CON.Name = "Panel_ProgressBar_Save_File_CON"
        Me.Panel_ProgressBar_Save_File_CON.Size = New System.Drawing.Size(313, 68)
        Me.Panel_ProgressBar_Save_File_CON.TabIndex = 202
        Me.Panel_ProgressBar_Save_File_CON.Visible = False
        '
        'HidBox
        '
        Me.HidBox.Controls.Add(Me.CBHideAll)
        Me.HidBox.Controls.Add(Me.CBCol5)
        Me.HidBox.Controls.Add(Me.CBCol4)
        Me.HidBox.Controls.Add(Me.CBCol3)
        Me.HidBox.Controls.Add(Me.CBCol2)
        Me.HidBox.Controls.Add(Me.CBCol1)
        Me.HidBox.Controls.Add(Me.CBCol0)
        Me.HidBox.Location = New System.Drawing.Point(21, 0)
        Me.HidBox.Name = "HidBox"
        Me.HidBox.Size = New System.Drawing.Size(264, 84)
        Me.HidBox.TabIndex = 206
        Me.HidBox.TabStop = False
        Me.HidBox.Text = "Скрыть"
        '
        'CBHideAll
        '
        Me.CBHideAll.AutoSize = True
        Me.CBHideAll.Location = New System.Drawing.Point(188, 16)
        Me.CBHideAll.Name = "CBHideAll"
        Me.CBHideAll.Size = New System.Drawing.Size(45, 17)
        Me.CBHideAll.TabIndex = 6
        Me.CBHideAll.Text = "Все"
        Me.CBHideAll.UseVisualStyleBackColor = True
        '
        'CBCol5
        '
        Me.CBCol5.AutoSize = True
        Me.CBCol5.Location = New System.Drawing.Point(102, 62)
        Me.CBCol5.Name = "CBCol5"
        Me.CBCol5.Size = New System.Drawing.Size(105, 17)
        Me.CBCol5.TabIndex = 5
        Me.CBCol5.Text = "Файл спектров"
        Me.CBCol5.UseVisualStyleBackColor = True
        '
        'CBCol4
        '
        Me.CBCol4.AutoSize = True
        Me.CBCol4.Location = New System.Drawing.Point(102, 39)
        Me.CBCol4.Name = "CBCol4"
        Me.CBCol4.Size = New System.Drawing.Size(70, 17)
        Me.CBCol4.TabIndex = 4
        Me.CBCol4.Text = "Заметки"
        Me.CBCol4.UseVisualStyleBackColor = True
        '
        'CBCol3
        '
        Me.CBCol3.AutoSize = True
        Me.CBCol3.Location = New System.Drawing.Point(102, 16)
        Me.CBCol3.Name = "CBCol3"
        Me.CBCol3.Size = New System.Drawing.Size(69, 17)
        Me.CBCol3.TabIndex = 3
        Me.CBCol3.Text = "Долгота"
        Me.CBCol3.UseVisualStyleBackColor = True
        '
        'CBCol2
        '
        Me.CBCol2.AutoSize = True
        Me.CBCol2.Location = New System.Drawing.Point(3, 62)
        Me.CBCol2.Name = "CBCol2"
        Me.CBCol2.Size = New System.Drawing.Size(64, 17)
        Me.CBCol2.TabIndex = 2
        Me.CBCol2.Text = "Широта"
        Me.CBCol2.UseVisualStyleBackColor = True
        '
        'CBCol1
        '
        Me.CBCol1.AutoSize = True
        Me.CBCol1.Location = New System.Drawing.Point(3, 39)
        Me.CBCol1.Name = "CBCol1"
        Me.CBCol1.Size = New System.Drawing.Size(91, 17)
        Me.CBCol1.TabIndex = 1
        Me.CBCol1.Text = "Место сбора"
        Me.CBCol1.UseVisualStyleBackColor = True
        '
        'CBCol0
        '
        Me.CBCol0.AutoSize = True
        Me.CBCol0.Location = New System.Drawing.Point(3, 16)
        Me.CBCol0.Name = "CBCol0"
        Me.CBCol0.Size = New System.Drawing.Size(100, 17)
        Me.CBCol0.TabIndex = 0
        Me.CBCol0.Text = "Клиентский №"
        Me.CBCol0.UseVisualStyleBackColor = True
        '
        'HidEmptEl
        '
        Me.HidEmptEl.AutoSize = True
        Me.HidEmptEl.Location = New System.Drawing.Point(305, 49)
        Me.HidEmptEl.Name = "HidEmptEl"
        Me.HidEmptEl.Size = New System.Drawing.Size(148, 30)
        Me.HidEmptEl.TabIndex = 207
        Me.HidEmptEl.Text = "Скрыть отсутствующие " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "элементы"
        Me.HidEmptEl.UseVisualStyleBackColor = True
        '
        'Form_NAA_Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 615)
        Me.Controls.Add(Me.HidEmptEl)
        Me.Controls.Add(Me.HidBox)
        Me.Controls.Add(Me.L_Name_Person)
        Me.Controls.Add(Me.B_Save_Final_Report)
        Me.Controls.Add(Me.Panel_ProgressBar_Save_File_CON)
        Me.Controls.Add(Me.Clear_Table)
        Me.Controls.Add(Me.ComboBox_Person)
        Me.Controls.Add(Me.B_Save)
        Me.Controls.Add(Me.L_SS_Sample_ID)
        Me.Controls.Add(Me.DataGridView_Table_Sample_NAA_Results)
        Me.Controls.Add(Me.L_SS_Sample_Set_Index)
        Me.Controls.Add(Me.L_Name_Code)
        Me.Controls.Add(Me.L_SS_Sample_Set_ID)
        Me.Controls.Add(Me.L_SS_Client_ID)
        Me.Controls.Add(Me.L_SS_Year)
        Me.Controls.Add(Me.L_SS_Country_Code)
        Me.Controls.Add(Me.B_Fill_In_From_File)
        Me.Controls.Add(Me.B_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_NAA_Results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NAA results"
        CType(Me.DataGridView_Table_Sample_NAA_Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ProgressBar_Save_File_CON.ResumeLayout(False)
        Me.Panel_ProgressBar_Save_File_CON.PerformLayout()
        Me.HidBox.ResumeLayout(False)
        Me.HidBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents B_Fill_In_From_File As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Fill_In_From_File_NAA_Results As System.Windows.Forms.OpenFileDialog
    Friend WithEvents L_SS_Sample_Set_Index As System.Windows.Forms.Label
    Friend WithEvents L_Name_Code As System.Windows.Forms.Label
    Friend WithEvents L_SS_Sample_Set_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Client_ID As System.Windows.Forms.Label
    Friend WithEvents L_SS_Year As System.Windows.Forms.Label
    Friend WithEvents L_SS_Country_Code As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Table_Sample_NAA_Results As System.Windows.Forms.DataGridView
    Friend WithEvents L_SS_Sample_ID As System.Windows.Forms.Label
    Friend WithEvents B_Save As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Person As System.Windows.Forms.ComboBox
    Friend WithEvents Clear_Table As System.Windows.Forms.Button
    Friend WithEvents B_Save_Final_Report As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_Final_Report As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RUFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RThFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RHgFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RAuFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RPtFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RIrFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RReFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RWFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RTaFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RHfFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RLuFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RYbFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RTmFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RErFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RDyFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RTbFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RGdFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents REuFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSmFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RNdFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCeFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RLaFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RBaFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCsFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RIFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSbFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSnFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RInFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCdFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RAgFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RRuFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RMoFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RNbFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RZrFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RYFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSrFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RRbFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RBrFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSeFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RAsFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RGaFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RZnFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCuFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCoFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RFeFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RFFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RNaFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RMgFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RAlFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSiFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RClFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RKFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCaFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RScFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RTiFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RVFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RCrFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RMnFactDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents L_Name_Person As System.Windows.Forms.Label
    Friend WithEvents ProgressBar_Fill_From_File As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_ProgressBar_Save_File_CON As System.Windows.Forms.Label
    Friend WithEvents Panel_ProgressBar_Save_File_CON As System.Windows.Forms.Panel
    Friend WithEvents HidBox As System.Windows.Forms.GroupBox
    Friend WithEvents CBCol5 As System.Windows.Forms.CheckBox
    Friend WithEvents CBCol4 As System.Windows.Forms.CheckBox
    Friend WithEvents CBCol3 As System.Windows.Forms.CheckBox
    Friend WithEvents CBCol2 As System.Windows.Forms.CheckBox
    Friend WithEvents CBCol1 As System.Windows.Forms.CheckBox
    Friend WithEvents CBCol0 As System.Windows.Forms.CheckBox
    Friend WithEvents CBHideAll As System.Windows.Forms.CheckBox
    Friend WithEvents HidEmptEl As System.Windows.Forms.CheckBox
End Class
