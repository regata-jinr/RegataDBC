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
        private List<IrradiationInfo> _irradiationList;
        private readonly string _type;

        public IrradiationJournal(DateTime dateTime, string type, string connectionString)
        {
            _type = type;
            var conStrBuild = new SqlConnectionStringBuilder(connectionString);
            InfoContext.ConnectionString = connectionString;
            InitializeComponent();
            Text = $"Журнал облучений {type} от {dateTime.ToShortDateString()} | {conStrBuild.UserID}";
            InitializeMainTable(dateTime, type);
            InitializeSampleSetTable();
        }

        private void InitializeMainTable(DateTime dateTime, string type)
        {
            ChosenSets = new List<string>();
            using(var ic = new InfoContext())
            {
                _irradiationList = ic.Irradiations.Where(ir => ir.DateTimeStart.HasValue && ir.DateTimeStart.Value.Date == dateTime.Date && ir.Type == type).ToList();
            }

            ChosenSets.AddRange(_irradiationList.Select(ir => ir.SetKey).Distinct().ToList());
            
            var advbindSource = new  AdvancedBindingSource<IrradiationInfo>(_irradiationList);
            IrradiationJournalADGV.SetDoubleBuffered();
            _bindingSource = advbindSource.GetBindingSource();
            IrradiationJournalADGV.DataSource = _bindingSource;

            _tabSamplesCheckBox = IrradiationJournalTabs.TabPages["IrradiationJournalTabPageSamples"].Controls["IrradiationJournalСheckBoxSetsFromJournal"] as CheckBox;

            if (_irradiationList != null)
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
            IrradiationJournalADGVSamplesSets.DataSource = null;
            InitializeSampleSetTable();
        }

        private void InitializeSampleSetTable()
        {
            List<SampleSetInfo> ssList = null;
            using (var ic = new InfoContext())
            {

                if (_tabSamplesCheckBox.Checked && ChosenSets.Any())
                    ssList = ic.SampleSets.Where(ss => ChosenSets.Contains(ss.ToString())).ToList();
                else
                    ssList = ic.SampleSets.Select(ss => ss).OrderByDescending(ss => ss.Sample_Set_Receipt_Date).ThenByDescending(ss => ss.Sample_Set_Id).ToList();
            }

            if (ssList == null)
                ssList = new List<SampleSetInfo>();

            var advbindSource = new  AdvancedBindingSource<SampleSetInfo>(ssList);
            IrradiationJournalADGVSamplesSets.SetDoubleBuffered();
            var _SSbindingSource = advbindSource.GetBindingSource();
            IrradiationJournalADGVSamplesSets.DataSource = _SSbindingSource;
            SetColumnVisiblesForSampleSet();
            IrradiationJournalADGVSamplesSets.SelectionChanged += SelectSampleSetHandler;

        }

        private void ShowSamples()
        {
            IrradiationJournalADGVSamples.DataSource = null;

            if (IrradiationJournalADGVSamplesSets.SelectedRows.Count == 0)
                return;

            var selCells = IrradiationJournalADGVSamplesSets.SelectedRows[0].Cells;
            List<SampleInfo> SampleList = null;
            using (var ic = new InfoContext())
            {
                SampleList = ic.Samples.Where(s =>
                                            s.F_Country_Code == selCells["Country_Code"].Value.ToString() &&
                                            s.F_Client_Id == selCells["Client_ID"].Value.ToString() &&
                                            s.F_Year == selCells["Year"].Value.ToString() &&
                                            s.F_Sample_Set_Id == selCells["Sample_Set_ID"].Value.ToString() &&
                                            s.F_Sample_Set_Index == selCells["Sample_Set_Index"].Value.ToString() &&
                                            !_irradiationList.Select(i => i.ToString()).Contains(s.SampleKey)
                                            ).ToList();
            }

            if (SampleList == null)
                SampleList = new List<SampleInfo>();

            var advbindSource = new  AdvancedBindingSource<SampleInfo>(SampleList);
            IrradiationJournalADGVSamples.SetDoubleBuffered();
            var bindingSource = advbindSource.GetBindingSource();
            IrradiationJournalADGVSamples.DataSource = bindingSource;

            SetColumnsProperties(ref IrradiationJournalADGVSamples,
                new string[] { "F_Country_Code", "F_Client_Id", "F_Year", "F_Sample_Set_Id", "F_Sample_Set_Index", "SetKey", "SampleKey" },
                new Dictionary<string, string>() 
                {
                    { "A_Sample_ID",       "Номер" },
                    { "A_Client_Sample_ID", "Клиентский номер" },
                    { "A_Sample_Type", "Тип" }
                },
                new string[] { "A_Sample_ID", "A_Client_Sample_ID", "A_Sample_Type" }

                );

        }

        private void SetColumnVisiblesForSampleSet()
        {
            SetColumnsProperties(ref IrradiationJournalADGVSamplesSets,
                               new string[]
                               { "Sample_Set_Receipt_Date", "Sample_Set_Report_Date", "Received_By", "Notes_1", "Notes_2", "Notes_3", "Note", "Loggs", "PrepCompl", "SLICompl", "LLICompl", "ResCompl"},
                               new Dictionary<string, string>() {
                                    { "Country_Code",       "Код страны" },
                                    { "Client_Id",          "Номер клиента" },
                                    { "Year",               "Год" },
                                    { "Sample_Set_Id",      "Номер партии" },
                                    { "Sample_Set_Index",   "Индекс партии" }
                               },
                               new string[]{ "Country_Code", "Client_Id", "Year", "Sample_Set_Id", "Sample_Set_Index" }
                               );

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

            SetColumnsProperties(ref IrradiationJournalADGV, 
                                new string[] 
                                { "Id", "SetKey", "SampleKey", "Type", "Container", "Position", "LoadNumber", "Rehandler" },
                                new Dictionary<string, string>() { 
                                    { "CountryCode",    "Код страны" },
                                    { "ClientNumber",   "Номер клиента" },
                                    { "Year",           "Год" },
                                    { "SetNumber",      "Номер партии" },
                                    { "SetIndex",       "Индекс партии" },
                                    { "SampleNumber",   "Номер образца" },
                                    { "Weight",         "Вес" },
                                    { "DateTimeStart",  "Дата и время начала облучения" },
                                    { "Duration",       "Продолжительность облучения" },
                                    { "DateTimeFinish", "Дата и время конца облучения" },
                                    { "Channel",        "Канал" },
                                    { "Assistant",      "Облучил" },
                                    { "Note",           "Примечание" } },
                                new string[] 
                                { "CountryCode", "ClientNumber", "Year", "SetNumber", "SetIndex", "SampleNumber", "Weight", "DateTimeStart", "Duration", "DateTimeFinish", "Channel", "Assistant" }
                                );

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

        private void SetColumnsProperties(ref Zuby.ADGV.AdvancedDataGridView adgv, string[] invisibles, Dictionary<string, string> columnHeaders, string[] readonlies)
        {
            foreach(var colName in invisibles)
                adgv.Columns[colName].Visible = false;

            foreach (var colName in readonlies)
                adgv.Columns[colName].ReadOnly = true;

            foreach (var colName in columnHeaders.Keys)
                adgv.Columns[colName].HeaderText = columnHeaders[colName];
        }

        private void SelectSampleSetHandler(object sender, EventArgs e)
        {
            ShowSamples();
        }

        private void IrradiationJournalButtonAddSelectedToJournal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("The function is not implemented yet.");
            if (IrradiationJournalADGVSamplesSets.SelectedRows.Count != 1)
                throw new InvalidOperationException("Не выбрана ни одна партия!");

            if (IrradiationJournalADGVSamples.SelectedRows.Count == 0)
                throw new ArgumentException("Не выбран ни один образец для добавления в журнал облучений!");

            foreach (DataGridViewRow row in IrradiationJournalADGVSamples.SelectedRows)
            {
                var drvSet = IrradiationJournalADGVSamplesSets.SelectedRows[0];
                //var newIrr = new IrradiationInfo()
                //{
                //    CountryCode = drvSet.Cells["Country_Code"].Value.ToString(),
                //    ClientNumber = drvSet.Cells["Client_Id"].Value.ToString(),
                //    Year = drvSet.Cells["Year"].Value.ToString(),
                //    SetNumber = drvSet.Cells["Sample_Set_Id"].Value.ToString(),
                //    SetIndex = drvSet.Cells["Sample_Set_Index"].Value.ToString(),
                //    SampleNumber = row.Cells["A_Sample_ID"].Value.ToString(),
                //    Type = _type,
                //    Weight = ,
                //    Duration = ,
                //    Container = ,
                //    Position = ,
                //    Channel = ,
                //    LoadNumber = ,
                //    Assistant =
                //};
            }



        }
    }
}
