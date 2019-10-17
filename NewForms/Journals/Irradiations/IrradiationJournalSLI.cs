using System.Collections.Generic;
using System.Windows.Forms;
using System;
using NewForms.Models;
using System.Linq;

namespace NewForms
{
    // SLI
    public partial class IrradiationJournal : Form
    {
        private void SetColumnProperties4SLI()
        {
            SetColumnsProperties(ref IrradiationJournalADGV,
                                new string[]
                                { "Id", "SetKey", "SampleKey", "Type", "Container", "Position", "LoadNumber", "Rehandler", "DateTimeFinish" },
                                new Dictionary<string, string>() {
                                    { "CountryCode",    "Код страны" },
                                    { "ClientNumber",   "Номер клиента" },
                                    { "Year",           "Год" },
                                    { "SetNumber",      "Номер партии" },
                                    { "SetIndex",       "Индекс партии" },
                                    { "SampleNumber",   "Номер образца" },
                                    { "Weight",         "Вес" },
                                    { "DateTimeStart",  "Дата и время начала облучения" },
                                    { "Duration",       "Продолжительность облучения" },
                                    { "Channel",        "Канал" },
                                    { "Assistant",      "Облучил" },
                                    { "Note",           "Примечание" } },
                                new string[]
                                { "CountryCode", "ClientNumber", "Year", "SetNumber", "SetIndex", "SampleNumber", "Weight", "Duration", "Channel", "Assistant" }
                                );

        }



        private void AddSLIIrradiationInfoToMainTable()
        {
            try
            {
                foreach (DataGridViewRow row in IrradiationJournalADGVSamples.SelectedRows.OfType<DataGridViewRow>().Reverse())
                {
                    var drvSet = IrradiationJournalADGVSamplesSets.SelectedRows[0];

                    var newIrr = new IrradiationInfo()
                    {
                        CountryCode  = drvSet.Cells["Country_Code"].Value.ToString(),
                        ClientNumber = drvSet.Cells["Client_Id"].Value.ToString(),
                        Year         = drvSet.Cells["Year"].Value.ToString(),
                        SetNumber    = drvSet.Cells["Sample_Set_Id"].Value.ToString(),
                        SetIndex     = drvSet.Cells["Sample_Set_Index"].Value.ToString(),
                        SampleNumber = row.Cells["A_Sample_ID"].Value.ToString(),
                        Type         = _type,
                        DateTimeStart = _currentJournalDateTime.Date,
                        Weight       = string.IsNullOrEmpty(row.Cells["P_Weighting_SLI"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["P_Weighting_SLI"].Value.ToString()),
                        Duration     = Duration,
                        Channel      = this.Channel,
                        Assistant    =  _user
                    };

                    _irradiationList.Add(newIrr);
                    using (var ic = new InfoContext())
                    {
                        ic.Irradiations.Add(newIrr);
                        ic.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void SetSLIVisibilities()
        {
            IrradiationJournalGoupBoxContainer.Visible = false;
            IrradiationJournalButtonRehandle.Visible = false;
        }
    }
}
