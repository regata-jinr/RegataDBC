using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Regata.UITemplates;
using System.Threading;
using Extensions.Models;
using Microsoft.EntityFrameworkCore;
using Regata.Utilities;

namespace Extensions.NewForms
{
    // FIXME: add tests
    // TODO: before release sync databases (new UILabels table and UserRoles view)
    // TODO: add async spectra downloading + progress bar + cancelling
    // TODO: link help button to readme page
    // TODO: prepare detailed description for app 
    // TODO: close form in case of app has closed
    // TODO: add exporting from excel
    // TODO: type without listbox but with suggestions via warning

    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        public readonly string SetKey;
        private const int TimeOutSeconds = 5;
        private readonly InfoContext _ic;
        private readonly string[] _types;

        public ShowSetContentForm(string setKey) : base(typeof(ShowSetContentForm).Name)
        {
            SetKey = setKey;
            _ic = new InfoContext(Settings.ConnectionString);
            _types = _ic.Types.Select(t => t.Type).Distinct().ToArray();
            InitializeComponent();

            var sk = setKey.Split('-');
            var lst = _ic.Samples.Where(s => s.F_Country_Code == sk[0] && s.F_Client_Id == sk[1] && s.F_Year == sk[2] && s.F_Sample_Set_Id == sk[3] && s.F_Sample_Set_Index == sk[4]).ToList();

            DataGridView.CellValueChanged += DataGridView_CellValueChanged;
            DataGridView.RowsAdded += DataGridView_RowsAdded;
            DataGridView.ColumnHeaderMouseDoubleClick += DataGridView_ColumnHeaderMouseDoubleClick;
            Load += ShowSetContentForm_Load;
            Settings.LanguageChanged += Settings_LanguageChanged;
            DataGridView.CellValidating += DataGridView_CellValidating;

            foreach (var l in lst)
                Data.Add(l);

            ButtonSaveToDB.Enabled = false;
            HideColumnsWithIndexes(0, 1, 2, 3, 4);
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (DataGridView.Rows[e.RowIndex].IsNewRow) return;

            var column = DataGridView.Columns[e.ColumnIndex];

            if (column.Name == "A_Longitude" || column.Name == "A_Latitude")
            {
                if (e.FormattedValue.ToString().Length > 9)
                {
                    e.Cancel = true;
                    MessageBoxTemplates.InfoSync($"Value of {column.Name} is to long for db {e.FormattedValue.ToString().Length}. Should be 9.");
                }

                var reg = new System.Text.RegularExpressions.Regex(@"[-]{0,1}\d{1,2}.\d{1,6}");
                if (!reg.IsMatch(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    MessageBoxTemplates.InfoSync($"Format of {column.Name} doesn't match with template: <->00.00000<0>");
                }

                if (!double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBoxTemplates.InfoSync($"Format of {column.Name} doesn't match with template: <->00.00000<0>");
                }
            }
        }

        private void Settings_LanguageChanged()
        {
            SetKeyLabel.Text = SetKey;
            Text += SetKey;
        }

        private void MenuItemMenuTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (!Data.Any()) return;

            var curItem = sender as ToolStripMenuItem;
            if (!curItem.Checked) return;

            var ListOfSampleTypes = new List<DataGridViewCell>();


            if (DataGridView.SelectedCells.Count == 0)
            {
                ListOfSampleTypes.Add(DataGridView.Rows[DataGridView.Rows.GetLastRow(DataGridViewElementStates.None)].Cells["A_Sample_Type"]);
            }
            else
            {
                foreach (DataGridViewCell cell in DataGridView.SelectedCells)
                {
                    if (cell.OwningColumn.Name != "A_Sample_Type") continue;
                    ListOfSampleTypes.Add(cell);
                }
            }

            foreach (ToolStripMenuItem tm in MenuItemType.DropDownItems)
            {
                if (tm.Name == curItem.Name)
                {
                    if (curItem.Checked)
                    {
                        foreach (var cell in ListOfSampleTypes)
                            cell.Value = curItem.Name;
                    }
                    continue;
                }
                tm.Checked = false;
            }
        }

        private void SetVisibilityForUser()
        {
            if (UserRoles.Contains("inspector") || UserRoles.Contains("db_owner"))
            {
                DataGridView.Location = new System.Drawing.Point(18, 105);
                DataGridView.Size = new System.Drawing.Size(1164, 553);
                DataGridView.ReadOnly = false;
                ButtonsLayoutPanel.Visible = true;
                MenuItemMenu.Visible = true;
                MenuItemType.Visible = true;
                FooterStatusStrip.Visible = true;

                DataGridView.Columns["A_Sample_ID"].ReadOnly = true;
                DataGridView.Columns["A_Sample_Type"].ReadOnly = true;
                DataGridView.Columns["A_Sample_Subtype"].ReadOnly = true;
                DataGridView.Columns["P_Weighting_SLI"].ReadOnly = true;
                DataGridView.Columns["P_Weighting_LLI"].ReadOnly = true;
            }
        }

        private async void ShowSetContentForm_Load(object sender, EventArgs e)
        {
            await GenerateTypeAndSubTypeMenuItems();
            ChangeLanguageOfControlsTexts(Controls);
            MatchType();
            DataGridView.ClearSelection();
            SetKeyLabel.Text = SetKey;
            Text += SetKey;
            SetVisibilityForUser();
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ButtonSaveToDB.Enabled = true;
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ButtonSaveToDB.Enabled = true;
        }

        private void DataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridView.Columns[e.ColumnIndex].ValueType != typeof(bool)) return;

            if (DataGridView.SelectedCells.Count == 0)
            {
                foreach (DataGridViewRow row in DataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != e.ColumnIndex) continue;
                        cell.Value = ((bool)cell.Value) ? false : true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewCell cell in DataGridView.SelectedCells)
                {
                    if (cell.ValueType != typeof(bool)) continue;
                    cell.Value = ((bool)cell.Value) ? false : true;
                }
            }
            DataGridView.ClearSelection();
        }

        private async void ButtonSaveToDB_Click(object sender, EventArgs e)
        {
            FooterStatusProgressBar.Value = 0;
            var _cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(TimeOutSeconds));
            try
            {
                ButtonSaveToDB.Enabled = false;
                FooterStatusLabel.Text = _labels.GetLabel("InitSavingToDb");
                await _ic.SaveChangesAsync(_cancellationTokenSource.Token);
                FooterStatusLabel.Text = _labels.GetLabel("SavedToDbSuccessfuly");
                FooterStatusProgressBar.Value = FooterStatusProgressBar.Maximum;
            }
            catch (OperationCanceledException)
            {
                FooterStatusLabel.Text = _labels.GetLabel("ExportCancelledByTimeout");
            }
            catch (DbUpdateException tie)
            {
                    MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = tie.InnerException, Level = ExceptionLevel.Warn });
            }
            finally
            {
                ButtonSaveToDB.Enabled = true;
                _cancellationTokenSource.Dispose();
            }
        }


        private async void ExportFromExcelButton_Click(object sender, EventArgs e)
        {
            MessageBoxTemplates.InfoSync("Functional would soon be added");
        }
        private async void ExportFromGoogleButton_Click(object sender, EventArgs e)
        {
            FooterStatusProgressBar.Value = 0;
            FooterStatusLabel.Text = _labels.GetLabel("InitialExport");

            if (Data.Any())
            {
                var res = MessageBox.Show(_labels.GetLabel("DeleteFromDB"), _labels.GetLabel("HelpCaptionPromt"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No) return;
                _ic.Samples.RemoveRange(Data);
            }

            Data.Clear();
            var result = "";
            using (Prompt prompt = new Prompt(_labels.GetLabel("HelpMessagePromt"), _labels.GetLabel("HelpCaptionPromt")))
            {
                result = prompt.Result;
            }

            if (string.IsNullOrEmpty(result))
            {
                FooterStatusLabel.Text = "";
                return;
            }

            var _cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(TimeOutSeconds));

            try
            {
                var samples = await ExportData.FromGoogleSheet<Sample>(result, _cancellationTokenSource.Token);

                FooterStatusProgressBar.Maximum = samples.Length;
                foreach (var l in samples)
                {
                    if (string.IsNullOrEmpty(l.A_Client_Sample_ID)) break;
                    l.F_Country_Code = SetKey.Split('-')[0];
                    l.F_Client_Id = SetKey.Split('-')[1];
                    l.F_Year = SetKey.Split('-')[2];
                    l.F_Sample_Set_Id = SetKey.Split('-')[3];
                    l.F_Sample_Set_Index = SetKey.Split('-')[4];
                    l.A_Sample_ID = (Array.IndexOf(samples, l) + 1).ToString("d2");
                    Data.Add(l);
                    FooterStatusProgressBar.Value++;
                }
                FooterStatusProgressBar.Value = FooterStatusProgressBar.Maximum;
                FooterStatusLabel.Text = _labels.GetLabel("SuccessExport");
                await _ic.Samples.AddRangeAsync(Data);
                //await _ic.SaveChangesAsync();
            }
            catch (NullReferenceException nre)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = nre, Level = ExceptionLevel.Error });
            }
            catch (OperationCanceledException)
            {
                FooterStatusLabel.Text = _labels.GetLabel("ExportCancelledByTimeout");
            }
            catch (AggregateException ae)
            {
                foreach (var ie in ae.InnerExceptions)
                {
                    MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ie, Level = ExceptionLevel.Error });
                }
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
            finally
            {
                _cancellationTokenSource.Dispose();
            }
        }

      

        private void ButtonAddSample_Click(object sender, System.EventArgs e)
        {
            var newSamp = new Sample(SetKey);
            if (Data.Any())
            {
                newSamp = Data.Last().Clone() as Sample;
                newSamp.A_Sample_ID = (int.Parse(newSamp.A_Sample_ID) + 1).ToString("d2");

                if (int.Parse(newSamp.A_Sample_ID) > 99)
                {
                    MessageBox.Show(_labels.GetLabel("MoreThan99Message"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                newSamp.A_Sample_ID = "01";
            }
            Data.Add(newSamp);
            _ic.Samples.Add(newSamp);
        }

    }
}
