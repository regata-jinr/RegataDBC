using OldCore.UITemplates;
using OldCore.Models;
using OldCore.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extensions.NewForms
{
    public partial class ReweightsInfoForm : DataTableForm<ReweightInfo>
    {
        public ReweightsInfoForm(int loadNumber) : base(typeof(ReweightsInfoForm).Name)
        {
            InitializeComponent();
            ChangeLanguageOfControlsTexts(Controls);

            using (var ic = new InfoContext(Settings.ConnectionString))
            {
                DataGridView.DataSource = ic.Reweights.Where(r => r.loadNumber == loadNumber).ToList();
            }

        }

    }
}
