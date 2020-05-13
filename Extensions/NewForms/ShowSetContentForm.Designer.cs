using System.Windows.Forms;
using Regata.UITemplates;
using System.Collections.Generic;
using System;
using Extensions.Models;

namespace Extensions.Forms
{
    public partial class ShowSetContentForm : DataTableForm<Sample>
    {

        private IReadOnlyDictionary<string, string> RussianLabels;
        private IReadOnlyDictionary<string, string> EnglishLabels;
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
            _ic.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = "Content of set: ";
            DataGridView.ReadOnly = false;
            ButtonExport = new Button();
            ButtonExport.Name = "ButtonExport";
            ButtonExport.Click += ExportButton_Click;

            ButtonSaveToDB = new Button();
            ButtonSaveToDB.Name = "ButtonSaveToDB";
            ButtonSaveToDB.Click += ButtonSaveToDB_Click;
            ButtonSaveToDB.Enabled = false;

            ButtonAddSample = new Button();
            ButtonAddSample.Name = "ButtonAddSample";
            ButtonAddSample.Click += ButtonAddSample_Click;

            Labels.AddRussianLabels(ref RussianLabels);
            Labels.AddEnglishLabels(ref EnglishLabels);
            AddButtonToLayout(ButtonExport);
            AddButtonToLayout(ButtonSaveToDB);
            AddButtonToLayout(ButtonAddSample);

            HideColumnsWithIndexes(0, 1, 2, 3, 4);

            DataGridView.Columns[5].ReadOnly = true;
        }

     

        #endregion
    }
}

