using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regata.Core.DataBase;
using Regata.Core.Settings;
using Regata.Core.DataBase.Models;
using Regata.Core.UI.WinForms;
using Regata.Core.UI.WinForms.Forms;
using Regata.Core.UI.WinForms.Forms.Irradiations;
using Regata.Core.UI.WinForms.Controls;
using Microsoft.EntityFrameworkCore;

namespace Extensions.NewForms
{
    public class ChooseIrrRegForm : RegataBaseForm
    {
        public ControlsGroupBox _gbMain;
        public ControlsGroupBox _gbIrrSliList;
        public ControlsGroupBox _gbIrrLliList;

        public ToolStripMenuItem _openChoseRegister;
        public ToolStripMenuItem _createNewSliRegister;
        public ToolStripMenuItem _createNewLliRegister;

        public DataGridView _dgvIrrSli;
        public DataGridView _dgvIrrLli;


        public int? _currLoadNumber = null;
        public DateTime? _currDate = null;
        public IrradiationType _currType = 0;


        public ChooseIrrRegForm()
        {
            Name = "ChooseIrrRegForm";
            base.Name = "ChooseIrrRegForm";
            StatusStrip.Visible = false;

            _dgvIrrSli = CreateDGV("dgvIrrSli");
            _dgvIrrLli = CreateDGV("dgvIrrLli");

            _gbIrrSliList = new ControlsGroupBox(new Control[] { _dgvIrrSli }) {Name = "gbIrrSliList" };
            _gbIrrLliList = new ControlsGroupBox(new Control[] { _dgvIrrLli }) { Name = "gbIrrLliList" }; ;


            _gbMain = new ControlsGroupBox(new Control[] { _gbIrrSliList, _gbIrrLliList }, vertical: false) { Name = "gbMain" };

            base.Controls.Add(_gbMain);

            Load += ChooseIrrRegForm_Load;

            MinimumSize = new System.Drawing.Size(600, 600);

            _openChoseRegister = new ToolStripMenuItem();
            _openChoseRegister.Name = "openChoseRegister";
            _openChoseRegister.Click += _openChoseRegister_Click;

            _createNewSliRegister = new ToolStripMenuItem();
            _createNewSliRegister.Name = "createNewSliRegister";
            _createNewSliRegister.Click += (s, e) =>
            {
                Settings<IrradiationSettings>.AssemblyName = "IrradiationRegister";

                var f = new IrradiationRegister(DateTime.Now, IrradiationType.sli);
                f.mainForm.Show();
            };


            _createNewLliRegister = new ToolStripMenuItem();
            _createNewLliRegister.Name = "createNewLliRegister";
            _createNewLliRegister.Click += (s, e) =>
            {
                Settings<IrradiationSettings>.AssemblyName = "IrradiationRegister";
                var maxLn = (int)_dgvIrrLli.Rows[0].Cells[0].Value;
                var f = new IrradiationRegister(DateTime.Now, IrradiationType.lli, maxLn + 1);
                f.mainForm.Show();
            };


            MenuStrip.Items.Insert(0, _openChoseRegister);
            MenuStrip.Items.Insert(0, _createNewLliRegister);
            MenuStrip.Items.Insert(0, _createNewSliRegister);

        }

        private void _openChoseRegister_Click(object sender, EventArgs e)
        {
            Settings<IrradiationSettings>.AssemblyName = "IrradiationRegister";

            var f = new IrradiationRegister(_currDate.Value, _currType, _currLoadNumber);
            f.mainForm.Show();
            //f._samplesToDetectors.Click += (s,ee) => { var ff = new SamplesToDetectors(8, _currLoadNumber.Value, RegataContext.ConString); ff.Show(); };
        }


        private DataGridView CreateDGV(string name)
        {
            var dgv = new DataGridView();
            dgv.Name = name;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            return dgv;
        }

        private async void ChooseIrrRegForm_Load(object sender, EventArgs e)
        {
            await FillDGV(_dgvIrrSli, 0);
            await FillDGV(_dgvIrrLli, 1);

            _dgvIrrSli.Scroll += async (s, ee) =>
            {

                if (RowIsVisible(_dgvIrrSli.Rows[_dgvIrrSli.RowCount - 1]))
                    await FillDGV(_dgvIrrSli, 0);

            };

            _dgvIrrLli.Scroll += async (s, ee) =>
            {

                if (RowIsVisible(_dgvIrrLli.Rows[_dgvIrrLli.RowCount - 1]))
                    await FillDGV(_dgvIrrLli, 1);

            };

            _dgvIrrSli.ClearSelection();
            _dgvIrrLli.ClearSelection();

            _dgvIrrLli.SelectionChanged += (s, ee) => 
            { 
                _dgvIrrSli.ClearSelection(); 
                if (_dgvIrrLli.SelectedCells.Count <= 0) return;
                _currType = IrradiationType.lli;
                _currDate = (DateTime)_dgvIrrLli.SelectedCells[1].Value; 
                _currLoadNumber = (int)_dgvIrrLli.SelectedCells[0].Value;
            };
            _dgvIrrSli.SelectionChanged += (s, ee) => 
            {
                _dgvIrrLli.ClearSelection();
                if (_dgvIrrSli.SelectedCells.Count <= 0) return;
                _currLoadNumber = null;
                _currType = IrradiationType.sli; 
                _currDate = (DateTime)_dgvIrrSli.SelectedCells[1].Value; 
            };

            Labels.SetControlsLabels(this);

        }

        private async Task FillDGV(DataGridView dgv, int type)
        {

            using (var r = new RegataContext())
            {
                if (dgv.RowCount == await r.Irradiations.AsNoTracking()
                                            .Where(ir => ir.Type == type && ir.DateTimeStart != null)
                                            .Distinct().CountAsync()) return;
            }
           
            //if (dgv.FirstDisplayedScrollingRowIndex > 0)
            //    dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 10;

            using (var r = new RegataContext())
            {
                dgv.DataSource = await r.Irradiations.AsNoTracking().Where(ir => ir.DateTimeStart.HasValue && ir.Type == type).Select(ir => new { ir.LoadNumber, ir.DateTimeStart.Value.Date }).Distinct().OrderByDescending(ir => ir.Date).Take(dgv.RowCount + 100).ToListAsync();
            }

            if (type == 0 && dgv.ColumnCount > 0)
                dgv.Columns[0].Visible = false;
        }

        private bool RowIsVisible(DataGridViewRow row)
        {
            if (row.DataGridView == null) return false;

            DataGridView dgv = row.DataGridView;
            int firstVisibleRowIndex = dgv.FirstDisplayedCell.RowIndex;
            int lastVisibleRowIndex = firstVisibleRowIndex + dgv.DisplayedRowCount(false) - 1;
            return row.Index >= firstVisibleRowIndex && row.Index <= lastVisibleRowIndex;
        }
    }
}
