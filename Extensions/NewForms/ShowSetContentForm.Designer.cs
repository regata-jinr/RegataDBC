using System.Windows.Forms;
using Regata.UITemplates;
using System;
using Extensions.Models;

namespace Extensions.NewForms
{
    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _folderDialog?.Dispose();
                _cts?.Dispose();
                _ic?.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button ButtonSaveToDB;
        private Button ButtonCancel;
        private Button ButtonAddSample;
        private Button ButtonClearSelection;
        private Label  SetKeyLabel;
        private ToolStripMenuItem MenuItemMenuCopyLinkToClip;
        private ToolStripMenuItem MenuItemMenuExportFromGoogle;
        private ToolStripMenuItem MenuItemMenuExportFromExcel;
        private ToolStripMenuItem MenuItemMenuSpectra;
        private ToolStripMenuItem MenuItemMenuSpectraSLI;
        private ToolStripMenuItem MenuItemMenuSpectraLLI1;
        private ToolStripMenuItem MenuItemMenuSpectraLLI2;
        private ToolStripMenuItem MenuItemMenuSpectraBgrnd;
        private ToolStripMenuItem MenuItemMenuSpectraAll;
        private FolderBrowserDialog _folderDialog;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSetContentForm));
            MenuItemMenuCopyLinkToClip = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuCopyLinkToClip", AutoSize = true };
            MenuItemMenuExportFromGoogle = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuExportFromGoogle", AutoSize = true };
            MenuItemMenuExportFromExcel = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuExportFromExcel", AutoSize = true };
            MenuItemMenuSpectra = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSpectra", AutoSize = true };
            MenuItemMenuSpectraSLI = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSpectraSLI", AutoSize = true };
            MenuItemMenuSpectraLLI1 = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSpectraLLI1", AutoSize = true };
            MenuItemMenuSpectraLLI2 = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSpectraLLI2", AutoSize = true };
            MenuItemMenuSpectraBgrnd = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSpectraBgrnd", AutoSize = true };
            MenuItemMenuSpectraAll = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSpectraAll", AutoSize = true };

            _folderDialog = new FolderBrowserDialog();           

            MenuItemMenu.DropDownItems.AddRange(new ToolStripItem[] { MenuItemMenuCopyLinkToClip, MenuItemMenuExportFromGoogle, MenuItemMenuExportFromExcel, MenuItemMenuSpectra });
            MenuItemMenuCopyLinkToClip.Click += MenuItemMenuCopyLinkToClip_Click;

            MenuItemMenuSpectra.DropDownItems.AddRange((new ToolStripItem[] { MenuItemMenuSpectraSLI, MenuItemMenuSpectraLLI1, MenuItemMenuSpectraLLI2, MenuItemMenuSpectraBgrnd, MenuItemMenuSpectraAll }));
            
            this.Text = "Content of set: ";
            MenuItemMenuExportFromGoogle.Click += ExportFromGoogleButton_Click;
            MenuItemMenuExportFromExcel.Click += ExportFromExcelButton_Click;

            MenuItemMenuSpectraSLI.Click += MenuItemMenuSpectraSLI_Click;
            MenuItemMenuSpectraLLI1.Click += MenuItemMenuSpectraLLI_Click;
            MenuItemMenuSpectraLLI2.Click += MenuItemMenuSpectraLLI_Click;
            MenuItemMenuSpectraAll.Click += MenuItemMenuSpectraAll_Click;

            ButtonSaveToDB = new Button();
            ButtonSaveToDB.Name = "ButtonSaveToDB";
            ButtonSaveToDB.Click += ButtonSaveToDB_Click;
            ButtonSaveToDB.Enabled = false;

            ButtonCancel = new Button();
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Click += ButtonCancel_Click; ;
            ButtonCancel.Enabled = false;

            ButtonClearSelection = new Button();
            ButtonClearSelection.Name = "ButtonClearSelection";
            ButtonClearSelection.Click += ButtonClearSelection_Click;

            ButtonAddSample = new Button();
            ButtonAddSample.Name = "ButtonAddSample";
            ButtonAddSample.Click += ButtonAddSample_Click;

            SetKeyLabel = new Label();
            SetKeyLabel.Name = "SetKeyLabel";
            SetKeyLabel.Text = SetKey;
            SetKeyLabel.Font = new System.Drawing.Font("Arial", 14);
            SetKeyLabel.AutoSize = true;

            AddButtonToLayout(ButtonAddSample);
            AddButtonToLayout(ButtonClearSelection);
            AddButtonToLayout(ButtonCancel);
            AddButtonToLayout(ButtonSaveToDB);
            ButtonsLayoutPanel.Controls.Add(SetKeyLabel);

            DataGridView.ReadOnly = true;
            ButtonsLayoutPanel.Visible = false;
            MenuItemMenuCopyLinkToClip.Visible = false;
            MenuItemMenuExportFromGoogle.Visible = false;
            MenuItemMenuExportFromExcel.Visible = false;
      
            DataGridView.Location = new System.Drawing.Point(18, 35);
            this.DataGridView.Size = new System.Drawing.Size(1162, 615);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            FormClosing += ShowSetContentForm_FormClosing;
        }

        private void MenuItemMenuCopyLinkToClip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_labels.GetLabel("SharedLinkToGoogleSheet"));
        }

        private void ButtonClearSelection_Click(object sender, EventArgs e)
        {
            DataGridView.ClearSelection();
        }
        #endregion
    }
}

