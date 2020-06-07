using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Regata.UITemplates;
using System.Threading;
using Extensions.Models;
using Microsoft.EntityFrameworkCore;
using Regata.Utilities;
using System.Threading.Tasks;

namespace Extensions.NewForms
{
    // TODO: add background downloading
    // TODO: test on win7 vm and win10sandbox
    // TODO: add exporting from excel the same as from google sheet

    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        public readonly string SetKey;
        private const int TimeOutSeconds = 5;
        private readonly InfoContext _ic;
        private CancellationTokenSource _cts;

        public ShowSetContentForm(string setKey) : base(typeof(ShowSetContentForm).Name)
        {
            SetKey = setKey;
            _ic = new InfoContext(Settings.ConnectionString);
            InitializeComponent();

            var sk = setKey.Split('-');
            var lst = _ic.Samples.Where(s => s.F_Country_Code == sk[0] && s.F_Client_Id == sk[1] && s.F_Year == sk[2] && s.F_Sample_Set_Id == sk[3] && s.F_Sample_Set_Index == sk[4]).ToList();

            DataGridView.RowsAdded += DataGridView_RowsAdded;
            DataGridView.ColumnHeaderMouseDoubleClick += DataGridView_ColumnHeaderMouseDoubleClick;
            Load += ShowSetContentForm_Load;
            Settings.LanguageChanged += Settings_LanguageChanged;
            //DataGridView.CellValidating += DataGridView_CellValidating;
            DataGridView.CellValueChanged += DataGridView_CellValueChanged;

            foreach (var l in lst)
                Data.Add(l);

            ButtonSaveToDB.Enabled = false;
            HideColumnsWithIndexes(0, 1, 2, 3, 4);
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ButtonSaveToDB.Enabled = true;
            if (DataGridView.Rows[e.RowIndex].IsNewRow) return;

            var cell = DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            var column = DataGridView.Columns[e.ColumnIndex];

            if (column.Name == "A_Longitude" || column.Name == "A_Latitude")
            {
                if (cell.Value == null)
                {
                    MessageBoxTemplates.InfoSync($"Value of {column.Name} is empty and doesn't match with template: <->00.00000<0>");
                    return;
                }
                if (cell.Value.ToString().Length > 9)
                {
                    MessageBoxTemplates.InfoSync($"Value of {column.Name} is to long for db {cell.Value.ToString().Length}. Should be 9.");
                    return;
                }

                var reg = new System.Text.RegularExpressions.Regex(@"[-]{0,1}\d{1,2}.\d{1,6}");
                if (!reg.IsMatch(cell.Value.ToString()))
                {
                    MessageBoxTemplates.InfoSync($"Format of {column.Name} doesn't match with template: <->00.00000<0>");
                    return;
                }

                if (!double.TryParse(cell.Value.ToString(), out _))
                {
                    MessageBoxTemplates.InfoSync($"Format of {column.Name} doesn't match with template: <->00.00000<0>");
                    return;
                }
            }
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

        private void SetVisibilityForUser()
        {
            if (UserRoles.Contains("inspector") || UserRoles.Contains("db_owner"))
            {
                DataGridView.Location = new System.Drawing.Point(18, 105);
                DataGridView.Size = new System.Drawing.Size(1164, 553);
                DataGridView.ReadOnly = false;
                ButtonsLayoutPanel.Visible = true;
                MenuItemMenu.Visible = true;
                FooterStatusStrip.Visible = true;

                DataGridView.Columns["A_Sample_ID"].ReadOnly = true;
                DataGridView.Columns["P_Weighting_SLI"].ReadOnly = true;
                DataGridView.Columns["P_Weighting_LLI"].ReadOnly = true;
            }
        }

        private async void ShowSetContentForm_Load(object sender, EventArgs e)
        {
            ChangeLanguageOfControlsTexts(Controls);
            DataGridView.ClearSelection();
            SetKeyLabel.Text = SetKey;
            Text += SetKey;
            SetVisibilityForUser();
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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

        private async void MenuItemMenuSpectraSLI_Click(object sender, EventArgs e)
        {
            if (_folderDialog.ShowDialog() != DialogResult.OK) return;

            ButtonCancel.Enabled = true;
            try
            {
                _cts = new CancellationTokenSource();
                FooterStatusProgressBar.Value = 0;
                FooterStatusProgressBar.Maximum = 1;
                var i = 0;

                await foreach (var ssi in SpectraTools.SLISetSpectrasAsync(SetKey, _cts.Token).WithCancellation(_cts.Token))
                {
                    if (_cts == null) _cts = new CancellationTokenSource();
                    i++;
                    if (i % 2 == 0)
                        FooterStatusProgressBar.Value = 0;

                    FooterStatusLabel.Text = $"{_labels.GetLabel("DownloadingFile")}{ssi.SampleSpectra}";
                    await WebDavClientApi.DownloadFile(ssi.token, Path.Combine(_folderDialog.SelectedPath, SetKey, "SLI", ssi.SampleType, $"{ssi.SampleSpectra}.cnf"), _cts.Token);
                    FooterStatusProgressBar.Value = 1;
                }

                if (i == 0) throw new IndexOutOfRangeException();

                FooterStatusLabel.Text = $"{_labels.GetLabel("DownloadingHasDone")}{i}";
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(_labels.GetLabel("SpectraNotFound"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (OperationCanceledException ose)
            {
                FooterStatusProgressBar.Value = 0;
                FooterStatusLabel.Text = _labels.GetLabel("CancelOperation");
            }
            catch (AggregateException ae)
            {
                foreach (var ie in ae.InnerExceptions)
                    MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ie, Level = ExceptionLevel.Error });
            }
            finally
            {
                ButtonCancel.Enabled = false;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private async void MenuItemMenuSpectraLLI_Click(object sender, EventArgs e)
        {
            if (_folderDialog.ShowDialog() != DialogResult.OK) return;

            var objName = (sender as ToolStripMenuItem)?.Name;

            var type = objName.Contains("LLI1") ? IrradiationType.LLI1 : IrradiationType.LLI2;

            _cts = new CancellationTokenSource();
            ButtonCancel.Enabled = true;
            try
            {
                FooterStatusProgressBar.Value = 0;
                FooterStatusProgressBar.Maximum = 1;
                var i = 0;

                await foreach (var ssi in SpectraTools.LLISetSpectrasAsync(SetKey, type, _cts.Token).WithCancellation(_cts.Token))
                {
                    if (_cts == null) _cts = new CancellationTokenSource();
                    i++;
                    if (i % 2 == 0)
                        FooterStatusProgressBar.Value = 0;

                    FooterStatusLabel.Text = $"{_labels.GetLabel("DownloadingFile")}{ssi.SampleSpectra}";
                    await WebDavClientApi.DownloadFile(ssi.token, Path.Combine(_folderDialog.SelectedPath, SetKey, SpectraTools.IrradiationTypeMap[type], ssi.LoadNumber.ToString(), $"c-{ssi.Container}", ssi.SampleType, $"{ssi.SampleSpectra}.cnf"), _cts.Token);
                    FooterStatusProgressBar.Value = 1;
                }

                if (i == 0) throw new IndexOutOfRangeException();

                FooterStatusLabel.Text = $"{_labels.GetLabel("DownloadingHasDone")}{i}";
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(_labels.GetLabel("SpectraNotFound"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (OperationCanceledException ose)
            {
                FooterStatusProgressBar.Value = 0;
                FooterStatusLabel.Text = _labels.GetLabel("CancelOperation");
            }
            catch (AggregateException ae)
            {
                foreach (var ie in ae.InnerExceptions)
                    MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ie, Level = ExceptionLevel.Error });
            }
            finally
            {
                ButtonCancel.Enabled = false;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private async void MenuItemMenuSpectraAll_Click(object sender, EventArgs e)
        {
            if (_folderDialog.ShowDialog() != DialogResult.OK) return;
            _cts = new CancellationTokenSource();
        
            FooterStatusLabel.Text = $"{_labels.GetLabel("InitAllSpectraDownloading")}";
            FooterStatusProgressBar.Value = 0;
            ButtonCancel.Enabled = true;
            try
            {
                _cts = new CancellationTokenSource();
                var sliSpectras = SpectraTools.SLISetSpectrasAsync(SetKey, _cts.Token).WithCancellation(_cts.Token);
                var lli1Spectras = SpectraTools.LLISetSpectrasAsync(SetKey, IrradiationType.LLI1, _cts.Token).WithCancellation(_cts.Token);
                var lli2Spectras = SpectraTools.LLISetSpectrasAsync(SetKey, IrradiationType.LLI2, _cts.Token).WithCancellation(_cts.Token);

                var taskSli = Task.Run(async () =>
                {
                    await foreach (var ssi in sliSpectras.WithCancellation(_cts.Token))
                    {
                        if (_cts == null) _cts = new CancellationTokenSource();
                        await WebDavClientApi.DownloadFile(ssi.token, Path.Combine(_folderDialog.SelectedPath, SetKey, "SLI", ssi.SampleType, $"{ssi.SampleSpectra}.cnf"), _cts.Token);
                    }
                });

                var taskLLI1 = Task.Run(async () =>
                {
                    await foreach (var ssi in lli1Spectras.WithCancellation(_cts.Token))
                    {
                        if (_cts == null) _cts = new CancellationTokenSource();
                        await WebDavClientApi.DownloadFile(ssi.token, Path.Combine(_folderDialog.SelectedPath, SetKey, SpectraTools.IrradiationTypeMap[IrradiationType.LLI1], ssi.LoadNumber.ToString(), $"c-{ssi.Container}", ssi.SampleType, $"{ssi.SampleSpectra}.cnf"), _cts.Token);
                    }

                });

                var taskLLI2 = Task.Run(async () =>
                {
                    await foreach (var ssi in lli2Spectras.WithCancellation(_cts.Token))
                    {
                        if (_cts == null) _cts = new CancellationTokenSource();
                        await WebDavClientApi.DownloadFile(ssi.token, Path.Combine(_folderDialog.SelectedPath, SetKey, SpectraTools.IrradiationTypeMap[IrradiationType.LLI2], ssi.LoadNumber.ToString(), $"c-{ssi.Container}", ssi.SampleType, $"{ssi.SampleSpectra}.cnf"), _cts.Token);
                    }
                });

                await Task.WhenAll(taskSli, taskLLI1, taskLLI2);

                FooterStatusLabel.Text = $"{_labels.GetLabel("AllSpectraDownldCompl")}";
                FooterStatusProgressBar.Value = FooterStatusProgressBar.Maximum;

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(_labels.GetLabel("SpectraNotFound"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (OperationCanceledException ose)
            {
                FooterStatusProgressBar.Value = 0;
                FooterStatusLabel.Text = _labels.GetLabel("CancelOperation");
            }
            catch (AggregateException ae)
            {
                foreach (var ie in ae.InnerExceptions)
                    MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ie, Level = ExceptionLevel.Error });
            }
            finally
            {
                ButtonCancel.Enabled = false;
                _cts.Dispose();
                _cts = null;
            }

        }

    } //  public partial class ShowSetContentForm : DataTableForm<Sample>
} // namespace Extensions.NewForms
