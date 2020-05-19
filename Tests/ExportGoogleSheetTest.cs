using System;
using System.Net;
using Xunit;

namespace Tests
{
    public class ExportGoogleSheetTest
    {
        [Fact]
        public void LinkParsingTest()
        {
            Assert.ThrowsAsync<IndexOutOfRangeException>(() => Extensions.Exporter.ProcessFile("", "", new System.Threading.CancellationToken()));
            Assert.ThrowsAsync<IndexOutOfRangeException>(() => Extensions.Exporter.ProcessFile("123", "", new System.Threading.CancellationToken()));
            Assert.ThrowsAsync<WebException>(() => Extensions.Exporter.ProcessFile("123/123/123", "", new System.Threading.CancellationToken()));
            Assert.ThrowsAsync<WebException>(() => Extensions.Exporter.ProcessFile("https://docs.google.com/spreadsheets/d/1c7c-mlEbANl0Fszxj1ITaTwexJb-Z9KbAWChX_1aCk8/edit#gid=0", "", new System.Threading.CancellationToken()));
        }

        [Fact]
        public void SavingAsCSVTest()
        {
            Assert.ThrowsAsync<System.IO.FileNotFoundException>(() => Extensions.Exporter.ProcessFile("https://docs.google.com/spreadsheets/d/1xIBGcSt4omTQkg0c2XEV5uNxLzVa320HW3zGu1HL6NI/edit#gid=0", "123", new System.Threading.CancellationToken()));
            Assert.ThrowsAsync<CsvHelper.CsvHelperException>(() => Extensions.Exporter.ProcessFile("https://docs.google.com/spreadsheets/d/1xIBGcSt4omTQkg0c2XEV5uNxLzVa320HW3zGu1HL6NI/edit#gid=0", @"D:\Spectra\2020\02\dji-2\1207134.cnf", new System.Threading.CancellationToken()));
            try
            { Extensions.Exporter.ProcessFile("https://docs.google.com/spreadsheets/d/1xIBGcSt4omTQkg0c2XEV5uNxLzVa320HW3zGu1HL6NI/edit#gid=0", @"D:\Spectra\2020\02\dji-2\1207134.cnf", new System.Threading.CancellationToken());
            }
            catch (AggregateException ae)
            {
                foreach (var ie in ae.InnerExceptions)
                    Assert.Equal(typeof(WebException), ie.GetType());

            }
        }

        [Fact]
        public void LoadingCSVToList()
        {
        }

        [Fact]
        public void CancellingTest()
        {
        }
    }
}
