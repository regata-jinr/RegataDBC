﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Regata.UITemplates;
using System.Threading;
using Extensions.Models;

namespace Extensions.NewForms
{
    // TODO: add tests
    // TODO: add data validation before saving
    // TODO: access right. users without inspector roles should jst view the table
    // TODO: close form in case of app has closed
    // TODO: add exporting from excel
    // TODO: move export buttons to menu
    // TODO: in case of other type has been chosen in excel or gs show warning that note must be filled
    // TODO: increase font for setkey in window title or add label in right empty field of buttonlayoutpanel
    // TODO: move save button to the end of the list
    // TODO: add data validation. e.g in case of longitude or latitude length more than 10, but required 9.
    // TODO: add exception handling for saving data to db
    // TODO: add link to template in shared place? Menu? Copy link for template file to clipboard
    // TODO: change column indexes to names
    // TODO: change translation base to db
    // TODO: what if in db create talbe LangDBC that contains keys - name of controls and rus and eng translation?
    // TODO: subtype mechanic the same as type, but depends on it. in case of some type has chosen subtype filled.
    // TODO: in case of type is other subtype can't be empty or notes? it will crash changes for existed samples
    // TODO: how to check it? before saving or during exporting?

    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        public readonly string SetKey;
        private const int TimeOutSeconds = 5;
        private readonly InfoContext _ic;
        private readonly string[] _types;

        public ShowSetContentForm(string ConString, string setKey) : base("RegataDBC", "ShowSetContentForm")
        {
            SetKey = setKey;
            _ic = new InfoContext(ConString);
            _types = _ic.Types.Select(t => t.Type).Distinct().ToArray();

            InitializeComponent();

            var sk = setKey.Split('-');
            var lst = _ic.Samples.Where(s => s.F_Country_Code == sk[0] && s.F_Client_Id == sk[1] && s.F_Year == sk[2] && s.F_Sample_Set_Id == sk[3] && s.F_Sample_Set_Index == sk[4]).ToList();

            DataGridView.CellValueChanged += DataGridView_CellValueChanged;
            DataGridView.RowsAdded += DataGridView_RowsAdded;
            DataGridView.ColumnHeaderMouseDoubleClick += DataGridView_ColumnHeaderMouseDoubleClick;
            Load += ShowSetContentForm_Load;

            foreach (var l in lst)
                Data.Add(l);

            ButtonSaveToDB.Enabled = false;
            HideColumnsWithIndexes(0, 1, 2, 3, 4);
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

        private async void ShowSetContentForm_Load(object sender, EventArgs e)
        {
            await GenerateTypeAndSubTypeMenuItems();
            ChangeLanguageOfControlsTexts(Controls);
            MatchType();
            DataGridView.ClearSelection();
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
                FooterStatusLabel.Text = Labels.GetLabel("InitSavingToDb");
                await _ic.SaveChangesAsync(_cancellationTokenSource.Token);
                FooterStatusLabel.Text = Labels.GetLabel("SavedToDbSuccessfuly");
                FooterStatusProgressBar.Value = FooterStatusProgressBar.Maximum;
            }
            catch (OperationCanceledException)
            {
                FooterStatusLabel.Text = Labels.GetLabel("ExportCancelledByTimeout");
            }
            finally
            {
                ButtonSaveToDB.Enabled = true;
                _cancellationTokenSource.Dispose();
            }
        }

        private async void ExportFromGoogleButton_Click(object sender, EventArgs e)
        {
            FooterStatusProgressBar.Value = 0;
            FooterStatusLabel.Text = Labels.GetLabel("InitialExport");

            if (Data.Any())
            {
                var res = MessageBox.Show(Labels.GetLabel("DeleteFromDB"), Labels.GetLabel("HelpCaptionPromt"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No) return;
                _ic.Samples.RemoveRange(Data);
            }

            Data.Clear();
            var result = "";
            using (Prompt prompt = new Prompt(Labels.GetLabel("HelpMessagePromt"), Labels.GetLabel("HelpCaptionPromt")))
            {
                result = prompt.Result;
            }

            if (string.IsNullOrEmpty(result))
            {
                FooterStatusLabel.Text = "";
                return;
            }

            var csvFile = $"{System.IO.Path.GetDirectoryName(SettingsPath)}\\{SetKey}.csv";

            var _cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(TimeOutSeconds));

            try
            {
                var samples = await Exporter.ProcessFile(result, csvFile, _cancellationTokenSource.Token);

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
                FooterStatusLabel.Text = Labels.GetLabel("SuccessExport");
                await _ic.Samples.AddRangeAsync(Data);
                //await _ic.SaveChangesAsync();
            }
            catch (NullReferenceException nre)
            {
                Extensions.MessageBoxTemplates.WrapExceptionToMessageBox(new Extensions.ExceptionEventsArgs() { exception=nre, Level = ExceptionLevel.Error });
            }
            catch (OperationCanceledException)
            {
                FooterStatusLabel.Text = Labels.GetLabel("ExportCancelledByTimeout");
            }
            catch (AggregateException ae)
            {
                foreach (var ie in ae.InnerExceptions)
                {
                    Extensions.MessageBoxTemplates.WrapExceptionToMessageBox(new Extensions.ExceptionEventsArgs() { exception = ie, Level = ExceptionLevel.Error });
                }
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
                    MessageBox.Show(Labels.GetLabel("MoreThan99Message"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
