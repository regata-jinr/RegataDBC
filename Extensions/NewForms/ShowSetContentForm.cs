using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Regata.UITemplates;
using System.Net;
using System.IO;
using CsvHelper;
using Extensions.Models;

namespace Extensions.NewForms
{
    // TODO: change design of class
    // TODO: change reference of templates to release
    // TODO: update packages
    // TODO: add async loading and filling
    // TODO: add saving to db and getting result
    // TODO: looks like range query doesn't work. see csv file
    // TODO: add russian and english labels to the all field
    // TODO: hide redundant columns by default
    // TODO: add set key to form text
    // TODO: add tests

    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        public readonly string SetKey;
        private readonly InfoContext _ic;
        private IDictionary<string, string> RussianLabels = new Dictionary<string, string>() { { "ExportFromGoogleSheet", $"Экспорт из {Environment.NewLine} GoogleSheet" }, {"fone", "фодин" } };
        //private const string ConString = "Data Source=RUMLAB\\REGATALOCAL;Initial Catalog=NAA_DB_TEST;Integrated Security=True;User ID=bdrum";

        public ShowSetContentForm(string setKey, string conString) : base("TestAssembly")
        {
            SetKey = setKey;
            var btn = new Button();
            btn.Name = "ExportFromGoogleSheet";
            btn.Click += Btn_Click;
            
            Labels.AddRussianLabels(ref RussianLabels);
            AddButtonToLayout(btn);

          

            var lst = new List<Sample>();
            var sk = setKey.Split('-');
            using (var _ic = new InfoContext(conString))
            {
                lst = _ic.SamplesNew.Where(s => s.F_Country_Code == sk[0] && s.F_Client_Id == sk[1] && s.F_Year == sk[2] && s.F_Sample_Set_Id == sk[3] && s.F_Sample_Set_Index == sk[4] ).ToList();
            }

            foreach (var l in lst)
                Data.Add(l);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var result = "";
            using (Prompt prompt = new Prompt($"Вставьте ссылку на таблицу Google.{Environment.NewLine}Убедитесь, что файл доступен для просмотра по ссылке.", "Export from Google Sheets"))
            {
                 result = prompt.Result;
            }
            var key = new Uri(result).AbsolutePath.Split('/')[3];
            var csvFile = $"{System.IO.Path.GetDirectoryName(SettingsPath)}\\{SetKey}.csv";
            using (var client = new WebClient())
            {
                var link = $"https://docs.google.com/spreadsheets/d/{key}/gviz/tq?tqx=out:csv&sheet=SamplesList$range=A:H";
                client.DownloadFile(link, csvFile);
            }

            List<Sample> samples = null;
            using (var reader = new StreamReader(csvFile))
            {
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.BadDataFound = null;
                    samples = new List<Sample>(csv.GetRecords<Sample>());
                    foreach (var l in samples)
                    {
                        if (string.IsNullOrEmpty(l.A_Client_Sample_ID)) break;
                        l.F_Country_Code = SetKey.Split('-')[0];
                        l.F_Client_Id = SetKey.Split('-')[1];
                        l.F_Year = SetKey.Split('-')[2];
                        l.F_Sample_Set_Id = SetKey.Split('-')[3];
                        l.F_Sample_Set_Index = SetKey.Split('-')[4];
                        l.A_Sample_ID = (samples.IndexOf(l)+1).ToString("d2");
                        Data.Add(l);
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _ic.SaveChanges();
        }
    }
}
