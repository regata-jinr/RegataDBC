using System.Windows.Forms;
using NewForms.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace NewForms
{
    // Samples
    public partial class IrradiationJournal : Form
    {

        private void ShowSamples()
        {
            IrradiationJournalADGVSamples.DataSource = null;

            if (IrradiationJournalADGVSamplesSets.SelectedRows.Count == 0)
                return;

            var selCells = IrradiationJournalADGVSamplesSets.SelectedRows[0].Cells;
            List<SampleInfo> SampleList = null;
            using (var ic = new InfoContext())
            {
                SampleList = ic.Samples.Where(s =>
                                            s.F_Country_Code == selCells["Country_Code"].Value.ToString() &&
                                            s.F_Client_Id == selCells["Client_ID"].Value.ToString() &&
                                            s.F_Year == selCells["Year"].Value.ToString() &&
                                            s.F_Sample_Set_Id == selCells["Sample_Set_ID"].Value.ToString() &&
                                            s.F_Sample_Set_Index == selCells["Sample_Set_Index"].Value.ToString() &&
                                            !_irradiationList.Select(i => i.ToString()).Contains(s.SampleKey)
                                            ).ToList();
            }

            if (SampleList == null)
                SampleList = new List<SampleInfo>();

            var advbindSource = new  AdvancedBindingSource<SampleInfo>(SampleList);
            IrradiationJournalADGVSamples.SetDoubleBuffered();
            var bindingSource = advbindSource.GetBindingSource();
            IrradiationJournalADGVSamples.DataSource = bindingSource;

            SetColumnsProperties(ref IrradiationJournalADGVSamples,
                new string[] { "F_Country_Code", "F_Client_Id", "F_Year", "F_Sample_Set_Id", "F_Sample_Set_Index", "SetKey", "SampleKey", "P_Weighting_LLI", "P_Weighting_SLI" },
                new Dictionary<string, string>()
                {
                    { "A_Sample_ID",          "Номер" },
                    { "A_Client_Sample_ID",   "Клиентский номер" },
                    { "A_Sample_Type",        "Тип" }
                },
                new string[0]

                );

        }

        private void SetColumnVisiblesForSampleSet()
        {
            SetColumnsProperties(ref IrradiationJournalADGVSamplesSets,
                               new string[]
                               { "Sample_Set_Receipt_Date", "Sample_Set_Report_Date", "Received_By", "Notes_1", "Notes_2", "Notes_3", "Note", "Loggs", "PrepCompl", "SLICompl", "LLICompl", "ResCompl"},
                               new Dictionary<string, string>() {
                                    { "Country_Code",       "Код страны" },
                                    { "Client_Id",          "Номер клиента" },
                                    { "Year",               "Год" },
                                    { "Sample_Set_Id",      "Номер партии" },
                                    { "Sample_Set_Index",   "Индекс партии" }
                               },
                               new string[0]
                               );

        }
        private void AddIrradiationInfoFromSamples()
        {
            if (IrradiationJournalADGVSamplesSets.SelectedRows.Count != 1)
                throw new InvalidOperationException("Не выбрана ни одна партия!");

            if (IrradiationJournalADGVSamples.SelectedRows.Count == 0)
                throw new ArgumentException("Не выбран ни один образец для добавления в журнал облучений!");

            if (_type == "SLI")
                AddSLIIrradiationInfoToMainTable();
            else
                AddLLIIrradiationInfoToMainTable();
        }

    }
}
