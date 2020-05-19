using System;
using System.Collections.Generic;
using Extensions.Models;
using System.IO;
using CsvHelper;
using System.Net;
using System.Threading.Tasks;
using System.Threading;

namespace Extensions
{
    public static class Exporter
    {
        public static async Task<Sample[]> ProcessFile(string link, string file, CancellationToken ct)
        {
            return await Task.Run(() =>
            {
                WebClient client = null;
                StreamReader reader = null;
                CsvReader csv = null;
                try
                {
                    var key = new Uri(link).AbsolutePath.Split('/')[3];
                    var performedLink = $"https://docs.google.com/spreadsheets/d/{key}/gviz/tq?tqx=out:csv&sheet=SamplesList";
                    client = new WebClient();
                    client.DownloadFile(performedLink, file);

                    reader = new StreamReader(file);

                    csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.BadDataFound = null;

                    return new List<Sample>(csv.GetRecords<Sample>()).ToArray();
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("Something wrong with provided link. Make sure the link contains the key i.e. file has shared access. For example, try to open it in non default browser in your system.");
                }
                catch (WebException)
                {
                    throw new WebException("Something wrong with provided link. Make sure the link contains the key i.e. file has shared access. For example, try to open it in non default browser in your system.");
                }
                catch (FileNotFoundException)
                {
                    throw new FileNotFoundException("Looks like link was processed correctly but provided information e.g. key for shared access is invalid. Make sure the link contains the key i.e. file has shared access. For example, try to open it in non default browser in your system.");
                }
                catch (CsvHelperException csvprocessing)
                {
                    throw new ArgumentException($"Something wrong with data inside provided file. See details in this message:  {csvprocessing.Message}");
                }
                finally
                {
                    client.Dispose();
                    reader.Dispose();
                    csv.Dispose();
                }
            }, ct);
        }
    }
}
