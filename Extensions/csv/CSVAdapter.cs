using System;
using System.Collections.Generic;
using CsvHelper;
using System.IO;
using System.Linq;
using Extensions.Models;

namespace Extensions.CSV
{
   public static class CSVAdapter
   {
        public static void LoadFileToDb(string pathToFile, string ConnectionString, string countryCode, string clientId, string year, string setId, string setIndex)
        {
            List<SampleInfo> samples = null;
            using (var reader = new StreamReader(pathToFile))
            using (var csv = new CsvReader(reader))
            {
                //csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                csv.Configuration.ShouldSkipRecord = row => row[0].StartsWith("0");
                csv.Configuration.Delimiter = "\t";
                try
                {
                    samples = new List<SampleInfo>(csv.GetRecords<SampleInfo>());

                    samples.ForEach(s => { s.F_Country_Code = countryCode; s.F_Client_Id = clientId; s.F_Year = year; s.F_Sample_Set_Id = setId; s.F_Sample_Set_Index = setIndex; s.A_Sample_ID = s.Number.ToString("d2"); });

                    using (var ic = new InfoContext(ConnectionString))
                    {
                        ic.Samples.AddRange(samples);
                        ic.SaveChanges();
                    }


                }
                catch (Exception ex)
                {
                    ;
                }
            }

        }
   }
}
