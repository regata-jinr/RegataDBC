using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Regata.UITemplates;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;
using CsvHelper;
using System.Threading;
using Microsoft.EntityFrameworkCore.Internal;
using Extensions.Models;

namespace Extensions.Forms
{
    // TODO: seems from time to time settings file resets
    // TODO: add exceptions for wrong key, parsing error, save to db error
    // TODO: add listbox to type and subtype
    // TODO: in case of type is other subtype can't be empty
    // TODO: add exceptions and cancelling to async methods
    // TODO: in case of existing value was update in dgv: save button enabled and update instead savechanges.
    // TODO: add saving to db and getting saving status
    // TODO: looks like range query doesn't work. see csv file
    // TODO: add tests

    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        public readonly string SetKey;

        private const int TimeOutSeconds = 5;

        private Button ButtonExport;
        private Button ButtonSaveToDB;
        private Button ButtonAddSample;
        private readonly InfoContext _ic;

        public ShowSetContentForm(string ConString, string setKey) : base("TestAssembly")
        {
            SetKey = setKey;
            RussianLabels = new Dictionary<string, string>() {
                { "ButtonExport", $"Экспорт из {Environment.NewLine} GoogleSheet" },
                { "ButtonSaveToDB", "Сохранить" },
                { "ButtonAddSample", "Добавить образец" },
                { "FormText", $"Просмотр партии - {SetKey}" },
                { "MoreThan99Message", "В партии должно быть не более 99 образцов!"},
                { "ExportCancelledByTimeout", "Экспортирование было отменено по таймауту. Проверьте соединение с интернетом."},
                { "SuccessExport", "Экспортирование успешно завершено"}
            };

            EnglishLabels = new Dictionary<string, string>() {
                { "ButtonExport", $"Export from {Environment.NewLine} GoogleSheet" },
                { "ButtonSaveToDB", "Save" },
                { "ButtonAddSample", "Add sample" },
                { "FormText", $"Set content - {SetKey}" },
                { "MoreThan99Message", "Set can't contain more than 99 samples!"},
                { "ExportCancelledByTimeout", "Export has cancelled by timeout. Check internet connection."},
                { "SuccessExport", "Export has done"}
           };

            InitializeComponent();

            var lst = new List<Sample>();

            var sk = setKey.Split('-');
            _ic = new InfoContext(ConString);
            lst = _ic.Samples.Where(s => s.F_Country_Code == sk[0] && s.F_Client_Id == sk[1] && s.F_Year == sk[2] && s.F_Sample_Set_Id == sk[3] && s.F_Sample_Set_Index == sk[4]).ToList();

            Data.ListChanged += Data_ListChanged;

            DataGridView.ColumnHeaderMouseDoubleClick += DataGridView_ColumnHeaderMouseDoubleClick;

            foreach (var l in lst)
                Data.Add(l);

            ButtonSaveToDB.Enabled = false;
        }

        private void DataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridView.Columns[e.ColumnIndex].ValueType != typeof(bool)) return;

            if (!DataGridView.SelectedCells.Any())
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

        private void Data_ListChanged(object sender, ListChangedEventArgs e)
        {
            ButtonSaveToDB.Enabled = true;
        }

        private async void ButtonSaveToDB_Click(object sender, EventArgs e)
        {
            FooterStatusLabel.Text = "Сохранение данных в базу...";
            await _ic.Samples.AddRangeAsync(Data);
            await _ic.SaveChangesAsync();
            ButtonSaveToDB.Enabled = false;
            FooterStatusLabel.Text = "Сохранение успешно завершено";
        }


        private async void ExportButton_Click(object sender, EventArgs e)
        {
            FooterStatusProgressBar.Value = 0;
            FooterStatusLabel.Text = "Экспортирование файла...";
            Data.Clear();
            ButtonExport.Enabled = false;
            var result = "";
            using (Prompt prompt = new Prompt($"Вставьте ссылку на таблицу Google.{Environment.NewLine}Убедитесь, что файл доступен для просмотра по ссылке.", "Export from Google Sheets"))
            {
                 result = prompt.Result;
            }
            if (string.IsNullOrEmpty(result))
            {
                FooterStatusLabel.Text = "";
                return;
            }

            var key = new Uri(result).AbsolutePath.Split('/')[3];
            //string[5] { "", "spreadsheets", "d", "17CWptecsNCGHx8mrKkLKmVXxDmZWXasNoyziAqNKWd4", "edit" }
            var link = $"https://docs.google.com/spreadsheets/d/{key}/gviz/tq?tqx=out:csv&sheet=SamplesList$range=A:H";
            var csvFile = $"{System.IO.Path.GetDirectoryName(SettingsPath)}\\{SetKey}.csv";

            var _cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(TimeOutSeconds));

            try
            {
                var samples = await ProcessFile(link, csvFile, _cancellationTokenSource.Token);

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
                Data_ListChanged(null, null);
                FooterStatusProgressBar.Value = FooterStatusProgressBar.Maximum;
                ButtonExport.Enabled = true;
                FooterStatusLabel.Text = Labels.GetLabel("SuccessExport");
            }
            catch (OperationCanceledException)
            {
                FooterStatusLabel.Text = Labels.GetLabel("ExportCancelledByTimeout");
            }

        }

        private async Task<Sample[]> ProcessFile(string link, string file, CancellationToken ct)
        {
            return await Task.Run(() =>
            {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(link, file);
                    }

                    List<Sample> samples = null;
                    using (var reader = new StreamReader(file))
                    {
                        using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                        {
                            csv.Configuration.HasHeaderRecord = true;
                            csv.Configuration.Delimiter = ",";
                            csv.Configuration.BadDataFound = null;

                            samples = new List<Sample>(csv.GetRecords<Sample>());
                        }
                    }
                    return samples.ToArray();
            }, ct);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _ic.SaveChanges();
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
            Data_ListChanged(null, null);
        }
    }
}
