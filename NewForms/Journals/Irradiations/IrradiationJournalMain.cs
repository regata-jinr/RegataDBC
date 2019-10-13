using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using NewForms.Models;

namespace NewForms
{
    // TODO: developments:
    //          1. lli
    //          2. add tests
    public partial class IrradiationJournal : Form
    {
        private BindingSource _bindingSource;
        private CheckBox _tabSamplesCheckBox;
        private List<string> ChosenSets;
        private List<IrradiationInfo> _irradiationList;
        private readonly string _type;
        private readonly string _user;
        private DateTime _currentJournalDateTime;
        private readonly Dictionary<string,string> typeEngRus;
        private readonly bool _IsAccessible;

        public IrradiationJournal(DateTime dateTime, string type, string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("select IS_Rolemember('operator') + IS_Rolemember('db_owner')", conn);
                    conn.Open();
                    object o = cmd.ExecuteScalar();
                    _IsAccessible = (o == null || DBNull.Value == o) ? false : ((int)o != 0);
                }

                typeEngRus = new Dictionary<string, string>() { { "SLI", "КЖИ" }, { "LLI", "ДЖИ" } };
                _currentJournalDateTime = dateTime;
                _type = type;
                var conStrBuild = new SqlConnectionStringBuilder(connectionString);
                InfoContext.ConnectionString = connectionString;
                _user = conStrBuild.UserID;
                InitializeComponent();
                SetPrivileges();

                IrradiationJournalNumericUpDownSeconds.ValueChanged += DurationHandler;
                IrradiationJournalNumericUpDownMinutes.ValueChanged += DurationHandler;
                IrradiationJournalNumericUpDownHours.ValueChanged += DurationHandler;

                Text = $"Журнал облучений {typeEngRus[type]} от {dateTime.ToShortDateString()} | {_user}";
                InitializeMainTable();


                _tabSamplesCheckBox = IrradiationJournalTabs.TabPages["IrradiationJournalTabPageSamples"].Controls["IrradiationJournalСheckBoxSetsFromJournal"] as CheckBox;

                if (_irradiationList.Any())
                    _tabSamplesCheckBox.Checked = true;
                else
                    _tabSamplesCheckBox.Checked = false;

                _tabSamplesCheckBox.CheckedChanged += _tabSamplesCheckBox_CheckedChanged;

                InitializeSampleSetTable();
                IrradiationJournalADGV.CellValueChanged += UpdateIrradiationJournal;
                IrradiationJournalADGV.SelectionChanged += IrradiationJournalADGV_SelectionChanged;

                foreach (var rb in IrradiationJournalGroupBoxChannel.Controls.OfType<RadioButton>().Select(r => r).ToArray())
                    rb.CheckedChanged += ChannelRadioButtonCheckedChanged;


                InitializeStandardSetTable();
                InitializeMonitorSetTable();
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void SetPrivileges()
        {
            if (_IsAccessible) return;

            IrradiationJournalADGV.ReadOnly = true;
            IrradiationJournalGroupBoxDuration.Enabled = false;
            IrradiationJournalGroupBoxChannel.Enabled = false;
            IrradiationJournalButtonAddSelectedToJournal.Enabled = false;
            IrradiationJournalButtonAddStartTime.Enabled = false;
            IrradiationJournalButtonRemoveSelectedFromJournal.Enabled = false;
            IrradiationJournalButtonRestoreSelectedFromJournal.Enabled = false;
            IrradiationJournalTabs.Enabled = false;
        }

        private void ChannelRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (IrradiationJournalADGV.SelectedCells.Count == 0) return;
                var colName = IrradiationJournalADGV.SelectedCells[0].OwningColumn.Name;
                if (colName != "Channel") return;

                foreach (DataGridViewCell cell in IrradiationJournalADGV.SelectedCells)
                    cell.Value = short.Parse(IrradiationJournalGroupBoxChannel.Controls.OfType<RadioButton>().Where(r => r.Checked).First().Text);
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }

        }

        private void IrradiationJournalADGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (IrradiationJournalADGV.SelectedCells.Count == 0) return;

                var colName = IrradiationJournalADGV.SelectedCells[0].OwningColumn.Name;
                var firstCell =  IrradiationJournalADGV.SelectedCells[0];

                if (colName == "Duration")
                    Duration = (int)firstCell.Value;

                if (colName == "Channel")
                {
                    if (short.TryParse(firstCell.Value.ToString(), out _) && (short)firstCell.Value <= 2 && (short)firstCell.Value >= 1)
                        Channel = (short)firstCell.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private short Channel
        {
            get
            {
                return short.Parse(IrradiationJournalGroupBoxChannel.Controls.OfType<RadioButton>().Where(r => r.Checked).First().Text);
            }
            set
            {
                IrradiationJournalGroupBoxChannel.Controls.OfType<RadioButton>().Where(r => r.Text == value.ToString()).First().Checked = true;
            }
        }

        private int Duration
        {
            get
            {
                var ts = new TimeSpan((int)IrradiationJournalNumericUpDownHours.Value, (int)IrradiationJournalNumericUpDownMinutes.Value, (int)IrradiationJournalNumericUpDownSeconds.Value);

                return (int)ts.TotalSeconds;
            }
            set
            {
                var ts = TimeSpan.FromSeconds(value);
                IrradiationJournalNumericUpDownSeconds.Value = ts.Seconds;
                IrradiationJournalNumericUpDownMinutes.Value = ts.Minutes;
                IrradiationJournalNumericUpDownHours.Value = ts.Hours;
            }
        }

        private void DurationHandler(object sender, EventArgs e)
        {
            try
            {
                var ts = new TimeSpan((int)IrradiationJournalNumericUpDownHours.Value, (int)IrradiationJournalNumericUpDownMinutes.Value, (int)IrradiationJournalNumericUpDownSeconds.Value);

                IrradiationJournalNumericUpDownSeconds.Value = ts.Seconds;
                IrradiationJournalNumericUpDownMinutes.Value = ts.Minutes;
                IrradiationJournalNumericUpDownHours.Value = ts.Hours;

                if (IrradiationJournalADGV.SelectedCells.Count == 0) return;
                var colName = IrradiationJournalADGV.SelectedCells[0].OwningColumn.Name;
                if (colName != "Duration") return;

                foreach (DataGridViewCell cell in IrradiationJournalADGV.SelectedCells)
                    cell.Value = ts.TotalSeconds;
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }

        }

        private void InitializeMainTable()
        {
            try
            {
                ChosenSets = new List<string>();
                using (var ic = new InfoContext())
                {
                    _irradiationList = ic.Irradiations.Where(ir => ir.DateTimeStart.HasValue &&
                                                             ir.DateTimeStart.Value.Date == _currentJournalDateTime.Date &&
                                                             ir.Type == _type)
                                                      .ToList();
                }

                if (_irradiationList == null)
                    _irradiationList = new List<IrradiationInfo>();

                ChosenSets.AddRange(_irradiationList.Select(ir => ir.SetKey).Distinct().ToList());

                var advbindSource = new  AdvancedBindingSource<IrradiationInfo>(_irradiationList);
                IrradiationJournalADGV.SetDoubleBuffered();
                _bindingSource = advbindSource.GetBindingSource();
                IrradiationJournalADGV.DataSource = _bindingSource;


                SetColumnVisibles(_type);
                IrradiationJournalADGVSearchToolBar.SetColumns(IrradiationJournalADGV.Columns);

                var r = IrradiationJournalADGVSearchToolBar.Items[0];

                ShowSamples();
                ShowStandards();
                ShowMonitors();
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }


        }

        private void _tabSamplesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IrradiationJournalADGVSamplesSets.DataSource = null;
            InitializeSampleSetTable();
        }

        private void InitializeSampleSetTable()
        {
            try
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
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }

        }

        private void InitializeStandardSetTable()
        {
            try
            {
                List<StandardSetInfo> standardSetsList = null;
                using (var ic = new InfoContext())
                {
                    standardSetsList = ic.StandardSets.Select(ss => ss).OrderBy(ss => ss.SRM_Set_Name).ThenByDescending(ss => ss.SRM_Set_Number).ToList();
                }


                var advbindSource = new  AdvancedBindingSource<StandardSetInfo>(standardSetsList);
                IrradiationJournalADGVStandardsSets.SetDoubleBuffered();
                var _SSbindingSource = advbindSource.GetBindingSource();
                IrradiationJournalADGVStandardsSets.DataSource = _SSbindingSource;
                SetColumnVisiblesForStandardsSet();
                IrradiationJournalADGVStandardsSets.SelectionChanged += SelectStandardsSetHandler;
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void SelectStandardsSetHandler(object sender, EventArgs e)
        {
            ShowStandards();
        }

        private void InitializeMonitorSetTable()
        {
            try
            {
                List<MonitorSetInfo> MonitorSetsList = null;
                using (var ic = new InfoContext())
                {
                    MonitorSetsList = ic.MonitorSets.Select(ms => ms).OrderBy(ms => ms.Monitor_Set_Name).ThenByDescending(ms => ms.Monitor_Set_Number).ToList();
                }


                var advbindSource = new  AdvancedBindingSource<MonitorSetInfo>(MonitorSetsList);
                IrradiationJournalADGVMonitorsSets.SetDoubleBuffered();
                var _SSbindingSource = advbindSource.GetBindingSource();
                IrradiationJournalADGVMonitorsSets.DataSource = _SSbindingSource;
                SetColumnVisiblesForMonitorsSet();
                IrradiationJournalADGVMonitorsSets.SelectionChanged += SelectMonitorsSetHandler;
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void SelectMonitorsSetHandler(object sender, EventArgs e)
        {
            ShowMonitors();
        }

        private void SetColumnVisibles(string type)
        {
            if (type == "SLI")
                SetColumnProperties4SLI();
            if (type.Contains("LLI"))
                SetColumnProperties4LLI();
        }

        private void IrradiationJournalADGVSearchToolBar_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void SetColumnsProperties(ref Zuby.ADGV.AdvancedDataGridView adgv, string[] invisibles, Dictionary<string, string> columnHeaders, string[] readonlies)
        {
            try
            {
                foreach (var colName in invisibles)
                    adgv.Columns[colName].Visible = false;

                if (readonlies.Any())
                {
                    foreach (var colName in readonlies)
                        adgv.Columns[colName].ReadOnly = true;
                }
                else
                {
                    foreach (DataGridViewColumn col in adgv.Columns)
                        col.ReadOnly = true;
                }

                foreach (var colName in columnHeaders.Keys)
                    adgv.Columns[colName].HeaderText = columnHeaders[colName];
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void SelectSampleSetHandler(object sender, EventArgs e)
        {
            ShowSamples();
        }

      
        private void IrradiationJournalButtonAddSelectedToJournal_Click(object sender, EventArgs e)
        {
            try
            {
                if (IrradiationJournalTabs.SelectedTab.Tag.ToString() == "Samples")
                    AddIrradiationInfoFromSamples();

                if (IrradiationJournalTabs.SelectedTab.Tag.ToString() == "Standards")
                    AddIrradiationInfoFromStandards();

                if (IrradiationJournalTabs.SelectedTab.Tag.ToString() == "Monitors")
                    AddIrradiationInfoFromMonitors();

                InitializeMainTable();

                IrradiationJournalADGV.FirstDisplayedScrollingRowIndex = IrradiationJournalADGV.RowCount - 1;
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void IrradiationJournalButtonRemoveSelectedFromJournal_Click(object sender, EventArgs e)
        {
            try
            {
                if (IrradiationJournalADGV.SelectedCells.Count == 0)
                    throw new ArgumentException("Не выбран ни один образец для удаления из журнала облучений!");

                foreach (DataGridViewCell cell in IrradiationJournalADGV.SelectedCells)
                {

                    var row = cell.OwningRow;
                    var irr = _irradiationList.Where(ir => ir.Id == (int)row.Cells["Id"].Value).First();

                    using (var ic = new InfoContext())
                    {
                        ic.Irradiations.Remove(irr);
                        ic.SaveChanges();
                    }
                }

                InitializeMainTable();
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void UpdateIrradiationJournal(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= IrradiationJournalADGV.Rows.Count) return;

                if (!DataValidation(e)) return;

                using (var ic = new InfoContext())
                {
                    var currentIrr = ic.Irradiations.Where(ir => ir.Id == (int)IrradiationJournalADGV.Rows[e.RowIndex].Cells["Id"].Value).First();

                    System.Type irrInfo = typeof(IrradiationInfo);
                    var prop = irrInfo.GetProperty(IrradiationJournalADGV.Columns[e.ColumnIndex].Name);
                    prop.SetValue(currentIrr, IrradiationJournalADGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                    ic.Irradiations.Update(currentIrr);
                    ic.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private bool DataValidation(DataGridViewCellEventArgs e)
        {
            try
            {
                var isValidated = true;
                DataGridViewCell currentCell = IrradiationJournalADGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewColumn currentColumn = currentCell.OwningColumn;
                DataGridViewRow currentRow = currentCell.OwningRow;

                if (currentColumn.Name.Contains("DateTime"))
                    isValidated = DateTime.TryParse(currentCell.Value.ToString(), out _);

                if (currentColumn.Name == "Note")
                    isValidated = (currentCell.Value.ToString().Length < 300);

                if (!isValidated)
                    MessageBoxTemplates.WarningAsync($"Ошибка при валидации данных. Столбец - {currentColumn.Name}");

                return isValidated;
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
                return false;
            }
        }

        private void IrradiationJournalButtonAddStartTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (IrradiationJournalADGV.SelectedCells.Count == 0) return;
                var colName = IrradiationJournalADGV.SelectedCells[0].OwningColumn.Name;
                if (colName != "DateTimeStart" && colName != "DateTimeFinish") return;

                var firstCell = IrradiationJournalADGV.SelectedCells[0];

                _currentJournalDateTime = _currentJournalDateTime.Date.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second);

                firstCell.Value = _currentJournalDateTime;
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }
    }
}
