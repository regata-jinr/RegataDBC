using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewForms.Models;

namespace NewForms
{
    //SLI
    public partial class IrradiationJournal : Form
    {
        private BindingSource _bindingSource;
        private CheckBox _tabSamplesCheckBox;
        private List<string> ChosenSets;

        public IrradiationJournal(DateTime dateTime, string type, string connectionString)
        {
            var conStrBuild = new SqlConnectionStringBuilder(connectionString);
            InfoContext.ConnectionString = connectionString;
            InitializeComponent();
            Text = $"Журнал облучений {type} от {dateTime.ToShortDateString()} | {conStrBuild.UserID}";
            InitializeMainTable(dateTime, type);
            InitializeSampleSetTable();
        }

        private void InitializeMainTable(DateTime dateTime, string type)
        {
            var ic = new InfoContext();
            ChosenSets = new List<string>();
            
            var irList = ic.Irradiations.Where(ir => ir.DateTimeStart.HasValue && ir.DateTimeStart.Value.Date == dateTime.Date && ir.Type == type).ToList();

            ChosenSets.AddRange(irList.Select(ir => ir.SetKey).Distinct().ToList());
            
            var advbindSource = new  AdvancedBindingSource<IrradiationInfo>(irList);
            IrradiationJournalADGV.SetDoubleBuffered();
            _bindingSource = advbindSource.GetBindingSource();
            IrradiationJournalADGV.DataSource = _bindingSource;

            _tabSamplesCheckBox = IrradiationJournalTabs.TabPages["IrradiationJournalTabPageSamples"].Controls["IrradiationJournalСheckBoxSetsFromJournal"] as CheckBox;

            if (irList != null)
                _tabSamplesCheckBox.Checked = true;
            else
                _tabSamplesCheckBox.Checked = false;

            _tabSamplesCheckBox.CheckedChanged += _tabSamplesCheckBox_CheckedChanged;

            SetColumnVisibles(type);
            IrradiationJournalADGVSearchToolBar.SetColumns(IrradiationJournalADGV.Columns);

            var r = IrradiationJournalADGVSearchToolBar.Items[0];

        }

        private void _tabSamplesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitializeSampleSetTable()
        {
            var ic = new InfoContext();

            List<SampleSetInfo> ssList = null;
            if (_tabSamplesCheckBox.Checked && ChosenSets.Any())
                ssList = ic.table_Sample_set.Where(ss => ChosenSets.Contains(ss.ToString())).ToList();
            else
                ssList = ic.table_Sample_set.Select(ss => ss).OrderByDescending(ss => ss.Sample_Set_Receipt_Date).ThenByDescending(ss => ss.Sample_Set_Id).ToList();

            var advbindSource = new  AdvancedBindingSource<SampleSetInfo>(ssList);
            IrradiationJournalADGVSamplesSets.SetDoubleBuffered();
            var _SSbindingSource = advbindSource.GetBindingSource();
            IrradiationJournalADGVSamplesSets.DataSource = _SSbindingSource;

        }

        private void SetColumnVisibles(string type)
        {
            if (type == "SLI")
                SetColumnProperties4SLI();
            if (type.Contains("LLI"))
                SetColumnProperties4LLI();
        }

        private void SetColumnProperties4SLI()
        {
            SetColumnProperties4SLIAndMainTable();
        }
        private void SetColumnProperties4SLIAndMainTable()
        {
            IrradiationJournalADGV.Columns["Id"].Visible = false;
            IrradiationJournalADGV.Columns["SetKey"].Visible = false;
            IrradiationJournalADGV.Columns["SampleKey"].Visible = false;
            IrradiationJournalADGV.Columns["Type"].Visible = false;
            IrradiationJournalADGV.Columns["Container"].Visible = false;
            IrradiationJournalADGV.Columns["Position"].Visible = false;
            IrradiationJournalADGV.Columns["LoadNumber"].Visible = false;
            IrradiationJournalADGV.Columns["Rehandler"].Visible = false;

            IrradiationJournalADGV.Columns["CountryCode"].HeaderText = "Код страны";
            IrradiationJournalADGV.Columns["ClientNumber"].HeaderText = "Номер клиента";
            IrradiationJournalADGV.Columns["Year"].HeaderText = "Год";
            IrradiationJournalADGV.Columns["SetNumber"].HeaderText = "Номер партии";
            IrradiationJournalADGV.Columns["SetIndex"].HeaderText = "Индекс партии";
            IrradiationJournalADGV.Columns["SampleNumber"].HeaderText = "Номер образца";
            IrradiationJournalADGV.Columns["Weight"].HeaderText = "Вес";
            IrradiationJournalADGV.Columns["DateTimeStart"].HeaderText = "Дата и время начала облучения";
            IrradiationJournalADGV.Columns["Duration"].HeaderText = "Продолжительность облучения";
            IrradiationJournalADGV.Columns["DateTimeFinish"].HeaderText = "Дата и время конца облучения";
            IrradiationJournalADGV.Columns["Channel"].HeaderText = "Канал";
            IrradiationJournalADGV.Columns["Assistant"].HeaderText = "Облучил";
            IrradiationJournalADGV.Columns["Note"].HeaderText = "Примечание";

            IrradiationJournalADGV.Columns["CountryCode"].ReadOnly = true;
            IrradiationJournalADGV.Columns["ClientNumber"].ReadOnly = true;
            IrradiationJournalADGV.Columns["Year"].ReadOnly = true;
            IrradiationJournalADGV.Columns["SetNumber"].ReadOnly = true;
            IrradiationJournalADGV.Columns["SetIndex"].ReadOnly = true;
            IrradiationJournalADGV.Columns["SampleNumber"].ReadOnly = true;
            IrradiationJournalADGV.Columns["Weight"].ReadOnly = true;
            IrradiationJournalADGV.Columns["DateTimeStart"].ReadOnly = true;
            IrradiationJournalADGV.Columns["Duration"].ReadOnly = true;
            IrradiationJournalADGV.Columns["DateTimeFinish"].ReadOnly = true;
            IrradiationJournalADGV.Columns["Channel"].ReadOnly = true;
            IrradiationJournalADGV.Columns["Assistant"].ReadOnly = true;
            IrradiationJournalADGV.Columns["Note"].ReadOnly = false;
        }

        private void IrradiationJournalADGVSearchToolBar_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = IrradiationJournalADGV.CurrentCell.ColumnIndex + 1 >= IrradiationJournalADGV.ColumnCount;
                bool endrow = IrradiationJournalADGV.CurrentCell.RowIndex + 1 >= IrradiationJournalADGV.RowCount;

                if (endcol && endrow)
                {
                    startColumn = IrradiationJournalADGV.CurrentCell.ColumnIndex;
                    startRow = IrradiationJournalADGV.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : IrradiationJournalADGV.CurrentCell.ColumnIndex + 1;
                    startRow = IrradiationJournalADGV.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = IrradiationJournalADGV.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = IrradiationJournalADGV.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                IrradiationJournalADGV.CurrentCell = c;
        }


    }
}
