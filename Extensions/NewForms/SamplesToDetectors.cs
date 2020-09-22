using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Text;
using Extensions.Models;

namespace Extensions.NewForms
{
    public partial class SamplesToDetectors : Form
    {

        private readonly string ConString;
        private readonly int _loadNumber;
        private readonly List<CheckedListBox> DetectorsListBoxes;

        public SamplesToDetectors(int MaxContNumber, int loadNumber, string conString)
        {
            InitializeComponent();

            _loadNumber = loadNumber;
            ConString = conString;

            DetectorsListBoxes = new List<CheckedListBox>() { checkedListBoxD1, checkedListBoxD5, checkedListBoxD6, checkedListBoxD7 };

            foreach (CheckedListBox dlb in DetectorsListBoxes)
            {
                dlb.Items.Clear();
                dlb.Items.AddRange(Enumerable.Range(1,MaxContNumber).Select(i => i.ToString()).ToArray());
                dlb.ItemCheck += ListboxDetectors_SelectedIndexChanged;
            }
        }

        private void ListboxDetectors_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
            // FIXME: does it smell?
            var currentListBox = sender as CheckedListBox;

            if (currentListBox == null) return; // never?

            var currentItem = currentListBox.Items[e.Index];

            if (e.NewValue == CheckState.Checked)
            {
                foreach (var dlb in DetectorsListBoxes)
                {
                    if (dlb == currentListBox)
                        continue;
                    dlb.Items.Remove(currentItem);
                }
            }
            else
            {
                foreach (var dlb in DetectorsListBoxes)
                {
                    if (dlb == currentListBox)
                        continue;
                    dlb.Items.Add(currentItem);
                    SortCheckBoxList(dlb);
                }
            }
        }

        private void SortCheckBoxList(CheckedListBox chbl)
        {
            var checkedItems = chbl.CheckedItems.Cast<string>().ToArray();
            var sortedItems = chbl.Items.Cast<string>().OrderBy(s => s).ToArray();
            chbl.Items.Clear();
            chbl.Items.AddRange(sortedItems);

            foreach (var ci in checkedItems)
                chbl.SetItemCheckState(chbl.Items.IndexOf(ci), CheckState.Checked);
        }

        private void buttonExportToSC_Click(object sender, EventArgs e)
        {
            try
            {
                var cnt = 0;
                foreach (var dlb in DetectorsListBoxes)
                    cnt += dlb.CheckedItems.Count;

                if (cnt == 0)
                {
                    MessageBox.Show("Вы не распределили контейнеры по детекторам", "Ошибка при распределении контейнеров", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (var ic = new InfoContext(ConString))
                {
                    var recs = ic.Records.FromSqlInterpolated($"exec ContainersToDetector {_loadNumber}").ToList();
                    if (recs.Where(r => r.Container_Number == null).Any())
                    {
                        MessageBox.Show("В журнале не должно быть образцов, не принадлижащих ни одному из контейнеров!", "Ошибка при распределении контейнеров", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var res = folderBrowserDialog1.ShowDialog();
                    if (res == DialogResult.Cancel)
                        return;

                    foreach (var dlb in DetectorsListBoxes)
                    {
                        if (dlb.CheckedItems.Count == 0)
                            continue;

                        SaveRecordsToCSV(recs.Where(r => dlb.CheckedItems.Contains(r.Container_Number.ToString()) && !r.SampleSet.StartsWith("m-m")).ToList(), dlb.Name.Substring(dlb.Name.Length - 2));
                    }

                }
                //buttonExportToExcel.Enabled = true;
                MessageBox.Show("Распределение прошло успешно", "Распределение контейнеров по детекторам", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При распределении контейнеров произошла ошибка{Environment.NewLine}{ex.Message}", "Ошибка при распределении контейнеров", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRecordsToCSV(List<ScRecord> records, string dName)
        {
            if (!records.Any()) return;

            var fileName = Path.Combine(folderBrowserDialog1.SelectedPath, $"{dName}-{_loadNumber}.uso");
            if (File.Exists(fileName))
                File.Delete(fileName);

            for (short i = 1; i <= records.Count; ++i)
            {
                records[i - 1].RowNum = i;
                records[i - 1].Height = decimal.Parse(tableLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            }


            using (var writer = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                writer.WriteLine($"{dName} samples changer list - download {_loadNumber}");
                writer.WriteLine("LLI");
                writer.WriteLine("№\tSample set\tSamp.\tw., gr\th., sm\tIrr. beg. date\tIrr. beg. time\tIrr. fin. date\tIrr. fin. time");
                var csvopt = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
                csvopt.HasHeaderRecord = false;
                csvopt.Delimiter = "\t";
                using (var csv = new CsvWriter(writer, csvopt))
                {
                    csv.WriteRecords(records);
                }
            }

        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Возможность будет добавлена в следующем обновлении", "Распределение контейнеров по детекторам", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //string _dateStart  = "";
            //string _timeStart  = "";
            //string _dateFinish = "";
            //string _timeFinish = "";

            //var exapp = new Excel.Application();
            //exapp.Visible = true;
            //exapp.Workbooks.Open(@"C:\Users\bdrum\Desktop\228\228NEW\DownloadTemplate.xlsx");
            //var _ws = exapp.ActiveSheet as Excel._Worksheet;
            
            //_ws.Cells[1, "B"] = $"Загрузка {_loadNumber}";
            //_ws.Cells[3, "C"] = _dateStart;
            //_ws.Cells[5, "C"] = _dateStart;
            //_ws.Cells[5, "D"] = _timeStart;
            //_ws.Cells[7, "C"] = _dateFinish;
            //_ws.Cells[7, "D"] = _timeFinish;


        }
    }
}

