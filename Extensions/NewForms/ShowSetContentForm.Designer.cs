using System.Windows.Forms;
using Regata.UITemplates;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
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
            }
            base.Dispose(disposing);
            _ic?.Dispose();
        }

        private Button ButtonSaveToDB;
        private Button ButtonAddSample;
        private Button ButtonClearSelection;
        private Label  SetKeyLabel;
        private ToolStripMenuItem MenuItemType;
        private ToolStripMenuItem MenuItemMenuCopyLinkToClip;
        private ToolStripMenuItem MenuItemMenuExportFromGoogle;
        private ToolStripMenuItem MenuItemMenuExportFromExcel;
        //private ToolStripMenuItem MenuItemMenuSubType;



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         
            MenuItemType = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuType", AutoSize = true };
            MenuItemMenuCopyLinkToClip = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuCopyLinkToClip", AutoSize = true };
            MenuItemMenuExportFromGoogle = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuExportFromGoogle", AutoSize = true };
            MenuItemMenuExportFromExcel = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuExportFromExcel", AutoSize = true };
            //MenuItemMenuSubType = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSubType", AutoSize = true };

            MenuStrip.Items.Add(MenuItemType);
            MenuItemMenu.DropDownItems.AddRange(new ToolStripItem[] { MenuItemMenuCopyLinkToClip, MenuItemMenuExportFromGoogle, MenuItemMenuExportFromExcel });
            MenuItemMenuCopyLinkToClip.Click += MenuItemMenuCopyLinkToClip_Click;
            
            //MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //MenuItemMenuType, MenuItemMenuSubType});

            this.Text = "Content of set: ";
            DataGridView.ReadOnly = false;
            MenuItemMenuExportFromGoogle.Click += ExportFromGoogleButton_Click;

            ButtonSaveToDB = new Button();
            ButtonSaveToDB.Name = "ButtonSaveToDB";
            ButtonSaveToDB.Click += ButtonSaveToDB_Click;
            ButtonSaveToDB.Enabled = false;

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
            AddButtonToLayout(ButtonSaveToDB);
            ButtonsLayoutPanel.Controls.Add(SetKeyLabel);

            DataGridView.ReadOnly = true;
            ButtonsLayoutPanel.Visible = false;
            MenuItemMenu.Visible = false;
            MenuItemType.Visible = false;
            FooterStatusStrip.Visible = false;

            DataGridView.Location = new System.Drawing.Point(18, 35);
            this.DataGridView.Size = new System.Drawing.Size(1162, 640);
            this.Icon = new System.Drawing.Icon("Resources/DBCLogo.ico");
        }
        
        private async Task GenerateTypeAndSubTypeMenuItems()
        {
            FillTypeMenu(ref MenuItemType, _types);
            //var subTypes = await _ic.Types.Where(t => t.Type == ).Select(s => s.A_Sample_Subtype).Distinct().ToArrayAsync();
            //FillTypeMenu(ref MenuItemMenuSubType, subTypes);
        }

        private void FillTypeMenu(ref ToolStripMenuItem item, string[] names)
        {
            ToolStripMenuItem[] tmis = new ToolStripMenuItem[names.Length];
            for (var i = 0; i < names.Length; ++i)
            {
                tmis[i] = new ToolStripMenuItem()
                {
                    Name = names[i],
                    AutoSize = true,
                    CheckOnClick = true
                };
                tmis[i].CheckedChanged += MenuItemMenuTypes_CheckedChanged;
            }
            item.DropDownItems.AddRange(tmis);
        }

        private void MatchType()
        {
            if (!Data.Any()) return;

            var lst = Data.Last();
            
            foreach (ToolStripMenuItem tm in MenuItemType.DropDownItems)
            {
                if (tm.Name == lst.A_Sample_Type)
                {
                    tm.Checked = true;
                    MenuItemMenuTypes_CheckedChanged(tm, null);
                }
            }
        }


        private void MenuItemMenuCopyLinkToClip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://docs.google.com/spreadsheets/d/1QWgYP694uad09Mac9AjvtSFWhUaJCALIWPc0pK9oYVc/edit?usp=sharing");
        }

        private void ButtonClearSelection_Click(object sender, EventArgs e)
        {
            DataGridView.ClearSelection();
        }

        #endregion
    }
}

