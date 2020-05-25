using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Extensions.Classes
{
    public enum IrradiationType { SLI, LLI1, LLI2};
    public static class SpectraTools 
    {
        // TODO: two regimes:
        // TODO:    saving only one file by name
        // TODO:    saving all files of chosen types by set key including srms
        // TODO: fill file list from irrad. tables
        // TODO: prepare context and models
        // TODO: Downaloading of each file sohuld be the chaing of searching and the downloading tasks
        // TODO: add tests

        public static IrradiationType Type;
        public static string SetKey;
        public static string DirPath;

        private static List<string> ListOfSpectra;
        private static List<string> ListOfSrms;

        private static async Task GetListOfSamplesSpectra(CancellationToken ct)
        {
            
        }

        private static async Task GetListOfSRMsSpectra(CancellationToken ct)
        {

        }

        //private static async Task<string> SearchFileOnTheServer(string spectra, CancellationToken ct)
        //{

        //}

        public static async Task DownloadFiles()
        {
            
        }

        public static async Task DownloadBySpectraName(string spectra, CancellationToken ct)
        {
            
        }
    }
}
