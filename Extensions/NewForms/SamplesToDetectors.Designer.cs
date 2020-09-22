namespace Extensions.NewForms
{
    partial class SamplesToDetectors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplesToDetectors));
            this.labelD1 = new System.Windows.Forms.Label();
            this.labelD5 = new System.Windows.Forms.Label();
            this.labelD6 = new System.Windows.Forms.Label();
            this.buttonExportToSC = new System.Windows.Forms.Button();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            this.labelD7 = new System.Windows.Forms.Label();
            this.labelExpl = new System.Windows.Forms.Label();
            this.checkedListBoxD1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxD5 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxD6 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxD7 = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelHeights = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelD1
            // 
            this.labelD1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.labelD1.Location = new System.Drawing.Point(11, 189);
            this.labelD1.Name = "labelD1";
            this.labelD1.Size = new System.Drawing.Size(62, 42);
            this.labelD1.TabIndex = 3;
            this.labelD1.Text = "D1";
            // 
            // labelD5
            // 
            this.labelD5.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.labelD5.Location = new System.Drawing.Point(95, 189);
            this.labelD5.Name = "labelD5";
            this.labelD5.Size = new System.Drawing.Size(62, 42);
            this.labelD5.TabIndex = 3;
            this.labelD5.Text = "D5";
            // 
            // labelD6
            // 
            this.labelD6.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.labelD6.Location = new System.Drawing.Point(179, 189);
            this.labelD6.Name = "labelD6";
            this.labelD6.Size = new System.Drawing.Size(62, 42);
            this.labelD6.TabIndex = 3;
            this.labelD6.Text = "D6";
            // 
            // buttonExportToSC
            // 
            this.buttonExportToSC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonExportToSC.Location = new System.Drawing.Point(9, 639);
            this.buttonExportToSC.Name = "buttonExportToSC";
            this.buttonExportToSC.Size = new System.Drawing.Size(321, 39);
            this.buttonExportToSC.TabIndex = 4;
            this.buttonExportToSC.Text = "Сохранить файлы для УСО";
            this.buttonExportToSC.UseVisualStyleBackColor = true;
            this.buttonExportToSC.Click += new System.EventHandler(this.buttonExportToSC_Click);
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.Enabled = false;
            this.buttonExportToExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonExportToExcel.Location = new System.Drawing.Point(10, 684);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(320, 28);
            this.buttonExportToExcel.TabIndex = 4;
            this.buttonExportToExcel.Text = "Экспорт списка образцов в Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = true;
            this.buttonExportToExcel.Click += new System.EventHandler(this.buttonExportToExcel_Click);
            // 
            // labelD7
            // 
            this.labelD7.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.labelD7.Location = new System.Drawing.Point(269, 189);
            this.labelD7.Name = "labelD7";
            this.labelD7.Size = new System.Drawing.Size(62, 42);
            this.labelD7.TabIndex = 3;
            this.labelD7.Text = "D7";
            // 
            // labelExpl
            // 
            this.labelExpl.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelExpl.Location = new System.Drawing.Point(0, 11);
            this.labelExpl.Name = "labelExpl";
            this.labelExpl.Size = new System.Drawing.Size(342, 178);
            this.labelExpl.TabIndex = 5;
            this.labelExpl.Text = "Для каждого детектора отметьте контейнеры, \r\nобразцы из которых будут измеряться " +
    "\r\nсоответствующим детектором.\r\nРаспределение контейнеров можно узнать у Вашего н" +
    "ачальника.";
            this.labelExpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelExpl.UseCompatibleTextRendering = true;
            // 
            // checkedListBoxD1
            // 
            this.checkedListBoxD1.CheckOnClick = true;
            this.checkedListBoxD1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.checkedListBoxD1.FormattingEnabled = true;
            this.checkedListBoxD1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.checkedListBoxD1.Location = new System.Drawing.Point(11, 234);
            this.checkedListBoxD1.Name = "checkedListBoxD1";
            this.checkedListBoxD1.Size = new System.Drawing.Size(62, 308);
            this.checkedListBoxD1.TabIndex = 6;
            // 
            // checkedListBoxD5
            // 
            this.checkedListBoxD5.CheckOnClick = true;
            this.checkedListBoxD5.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.checkedListBoxD5.FormattingEnabled = true;
            this.checkedListBoxD5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.checkedListBoxD5.Location = new System.Drawing.Point(95, 234);
            this.checkedListBoxD5.Name = "checkedListBoxD5";
            this.checkedListBoxD5.Size = new System.Drawing.Size(62, 308);
            this.checkedListBoxD5.TabIndex = 6;
            // 
            // checkedListBoxD6
            // 
            this.checkedListBoxD6.CheckOnClick = true;
            this.checkedListBoxD6.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.checkedListBoxD6.FormattingEnabled = true;
            this.checkedListBoxD6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.checkedListBoxD6.Location = new System.Drawing.Point(179, 234);
            this.checkedListBoxD6.Name = "checkedListBoxD6";
            this.checkedListBoxD6.Size = new System.Drawing.Size(62, 308);
            this.checkedListBoxD6.TabIndex = 6;
            // 
            // checkedListBoxD7
            // 
            this.checkedListBoxD7.CheckOnClick = true;
            this.checkedListBoxD7.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.checkedListBoxD7.FormattingEnabled = true;
            this.checkedListBoxD7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.checkedListBoxD7.Location = new System.Drawing.Point(269, 234);
            this.checkedListBoxD7.Name = "checkedListBoxD7";
            this.checkedListBoxD7.Size = new System.Drawing.Size(62, 308);
            this.checkedListBoxD7.TabIndex = 6;
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 49);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2.5";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(82, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 49);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "5";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(161, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 49);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(240, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 49);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "20";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelHeights
            // 
            this.labelHeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeights.Location = new System.Drawing.Point(9, 549);
            this.labelHeights.Name = "labelHeights";
            this.labelHeights.Size = new System.Drawing.Size(321, 23);
            this.labelHeights.TabIndex = 8;
            this.labelHeights.Text = "Выберите высоту над детектором";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton4, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 578);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 55);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // SamplesToDetectors
            // 
            this.AcceptButton = this.buttonExportToExcel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 724);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelHeights);
            this.Controls.Add(this.checkedListBoxD7);
            this.Controls.Add(this.checkedListBoxD6);
            this.Controls.Add(this.checkedListBoxD5);
            this.Controls.Add(this.checkedListBoxD1);
            this.Controls.Add(this.labelExpl);
            this.Controls.Add(this.labelD7);
            this.Controls.Add(this.buttonExportToExcel);
            this.Controls.Add(this.buttonExportToSC);
            this.Controls.Add(this.labelD6);
            this.Controls.Add(this.labelD5);
            this.Controls.Add(this.labelD1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SamplesToDetectors";
            this.Text = "Образцы на детекторах";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelD1;
        private System.Windows.Forms.Label labelD5;
        private System.Windows.Forms.Label labelD6;
        private System.Windows.Forms.Button buttonExportToSC;
        private System.Windows.Forms.Button buttonExportToExcel;
        private System.Windows.Forms.Label labelD7;
        private System.Windows.Forms.Label labelExpl;
        private System.Windows.Forms.CheckedListBox checkedListBoxD1;
        private System.Windows.Forms.CheckedListBox checkedListBoxD5;
        private System.Windows.Forms.CheckedListBox checkedListBoxD6;
        private System.Windows.Forms.CheckedListBox checkedListBoxD7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelHeights;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}