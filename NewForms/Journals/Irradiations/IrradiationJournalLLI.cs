using System.Windows.Forms;
using NewForms.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace NewForms
{
    // LLI
    public partial class IrradiationJournal : Form
    {
        private void SetColumnProperties4LLI()
        {
            SetColumnsProperties(ref IrradiationJournalADGV,
                                new string[]
                                { "Id", "SetKey", "SampleKey", "Type", "LoadNumber" },
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
                                    { "DateTimeFinish", "Дата и время конца облучения" },
                                    { "Container",      "Контейнер" },
                                    { "Position",       "Позиция" },
                                    { "Channel",        "Канал" },
                                    { "Rehandler",      "Перепаковано" },
                                    { "Assistant",      "Облучил" },
                                    { "Note",           "Примечание" } },
                                new string[]
                                { "CountryCode", "ClientNumber", "Year", "SetNumber", "SetIndex", "SampleNumber", "Weight", "DateTimeStart", "Duration", "DateTimeFinish", "Channel", "Container", "Position", "Assistant", "Rehandler" }
                                );

        }

        private void AddLLIIrradiationInfoToMainTable()
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
                    Container    = ContainerNumber,
                    Position     = PositionInContainer,
                    LoadNumber   = _loadNumber
                };
                _irradiationList.Add(newIrr);

                using (var ic = new InfoContext())
                {
                    ic.Irradiations.Add(newIrr);
                    ic.SaveChanges();
                }
            }
        }

    }
}
