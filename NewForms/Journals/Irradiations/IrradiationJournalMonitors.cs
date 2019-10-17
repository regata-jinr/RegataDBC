using System.Linq;
using System.Windows.Forms;
using NewForms.Models;
using System.Collections.Generic;
using System;

namespace NewForms
{
    // Monitors
    public partial class IrradiationJournal : Form
    {
        private void SetColumnVisiblesForMonitorsSet()
        {
            SetColumnsProperties(ref IrradiationJournalADGVMonitorsSets,
                               new string[]
                               { "Monitor_Set_Weight", "Monitor_Set_Purchasing_Date" },
                               new Dictionary<string, string>() {
                                    { "Monitor_Set_Name",   "Наименование" },
                                    { "Monitor_Set_Number", "Номер" },
                                    { "Monitor_Set_Type",   "Тип" }
                               },
                               new string[0] 
                               );

        }

        private string _currentWeightMonitorColumnName;

        private void ShowMonitors()
        {
            try
            {
                IrradiationJournalADGVMonitors.DataSource = null;

                if (IrradiationJournalADGVMonitorsSets.SelectedRows.Count == 0)
                    return;

                var selCells = IrradiationJournalADGVMonitorsSets.SelectedRows[0].Cells;
                List<MonitorInfo> MonitorList = null;
                using (var ic = new InfoContext())
                {
                    MonitorList = ic.Monitors.Where(s =>
                                                s.Monitor_Set_Name == selCells["Monitor_Set_Name"].Value.ToString() &&
                                                s.Monitor_Set_Number == selCells["Monitor_Set_Number"].Value.ToString() &&
                                                ((_type == "SLI" && (s.Monitor_SLI_Weight !=0 && s.Monitor_SLI_Weight.HasValue)) ||
                                                (_type.Contains("LLI") && s.Monitor_LLI_Weight != 0 && s.Monitor_LLI_Weight.HasValue))
                                                &&
                                                !_irradiationList.Select(i => i.ToString()).Contains(s.ToString())
                                                ).ToList();
                }

                if (MonitorList == null)
                    MonitorList = new List<MonitorInfo>();

                var advbindSource = new  AdvancedBindingSource<MonitorInfo>(MonitorList);
                IrradiationJournalADGVMonitors.SetDoubleBuffered();
                var bindingSource = advbindSource.GetBindingSource();
                IrradiationJournalADGVMonitors.DataSource = bindingSource;

                _currentWeightMonitorColumnName = _type.Contains("LLI") ? "Monitor_LLI_Weight" : "Monitor_SLI_Weight";

                var restWeightColumn = new List<string>(){ "Monitor_LLI_Weight", "Monitor_SLI_Weight" };
                restWeightColumn.Remove(_currentWeightMonitorColumnName);



                SetColumnsProperties(ref IrradiationJournalADGVMonitors,
                    new string[] { "Monitor_Set_Name", "Monitor_Set_Number", "Monitor_Set_Weight", restWeightColumn.First() },
                    new Dictionary<string, string>()
                    {
                    { "Monitor_Number",                "Номер"   },
                    { _currentWeightMonitorColumnName, "Вес"     }
                    },
                    new string[0]
                    );
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void AddIrradiationInfoFromMonitors()
        {
            if (IrradiationJournalADGVMonitorsSets.SelectedRows.Count != 1)
                throw new InvalidOperationException("Не выбрана ни одна партия стандартов!");

            if (IrradiationJournalADGVMonitors.SelectedRows.Count == 0)
                throw new ArgumentException("Не выбран ни один стандарт для добавления в журнал облучений!");

            if (_type == "SLI")
                AddMonitorsIrradiationInfoSLI();
            if (_type.Contains("LLI"))
                AddMonitorsIrradiationInfoLLI();
        }

        private void AddMonitorsIrradiationInfoSLI()
        {
            try
            {
                foreach (DataGridViewRow row in IrradiationJournalADGVMonitors.SelectedRows.OfType<DataGridViewRow>().Reverse())
                {
                    var drvSet = IrradiationJournalADGVMonitorsSets.SelectedRows[0];

                    var newIrr = new IrradiationInfo()
                    {
                        CountryCode   = "m",
                        ClientNumber  = "m",
                        Year          = "m",
                        SetNumber     = drvSet.Cells["Monitor_Set_Name"].Value.ToString(),
                        SetIndex      = drvSet.Cells["Monitor_Set_Number"].Value.ToString(),
                        SampleNumber  = row.Cells["Monitor_Number"].Value.ToString(),
                        Type          = _type,
                        DateTimeStart = _currentJournalDateTime.Date,
                        Weight        = string.IsNullOrEmpty(row.Cells[_currentWeightMonitorColumnName].Value.ToString()) ? 0 : decimal.Parse(row.Cells[_currentWeightMonitorColumnName].Value.ToString()),
                        Duration      = Duration,
                        Channel       = this.Channel,
                        Assistant     =  _user
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


        private void AddMonitorsIrradiationInfoLLI()
        {
            try
            {
                foreach (DataGridViewRow row in IrradiationJournalADGVMonitors.SelectedRows.OfType<DataGridViewRow>().Reverse())
                {
                    var drvSet = IrradiationJournalADGVMonitorsSets.SelectedRows[0];

                    var newIrr = new IrradiationInfo()
                    {
                        CountryCode   = "m",
                        ClientNumber  = "m",
                        Year          = "m",
                        SetNumber     = drvSet.Cells["Monitor_Set_Name"].Value.ToString(),
                        SetIndex      = drvSet.Cells["Monitor_Set_Number"].Value.ToString(),
                        SampleNumber  = row.Cells["Monitor_Number"].Value.ToString(),
                        Type          = _type,
                        DateTimeStart = _currentJournalDateTime.Date,
                        Weight        = string.IsNullOrEmpty(row.Cells[_currentWeightMonitorColumnName].Value.ToString()) ? 0 : decimal.Parse(row.Cells[_currentWeightMonitorColumnName].Value.ToString()),
                        Duration      = Duration,
                        Container     = ContainerNumber,
                        Position      = PositionInContainer,
                        Channel       = this.Channel,
                        LoadNumber    = _loadNumber,
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

    }
}
