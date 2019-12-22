using System.Linq;
using System.Windows.Forms;
using NewForms.Models;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace NewForms
{
    // Standards
    public partial class IrradiationJournal : Form
    {
        private void SetColumnVisiblesForStandardsSet()
        {
            SetColumnsProperties(ref IrradiationJournalADGVStandardsSets,
                               new string[]
                               { "SRM_Set_Weight", "SRM_Set_Purchasing_Date" },
                               new Dictionary<string, string>() {
                                    { "SRM_Set_Name",   "Наименование" },
                                    { "SRM_Set_Number", "Номер" },
                                    { "SRM_Set_Type",   "Тип" }
                               },
                               new string[0] 
                               );

        }

        //private string _currentWeightStandardColumnName;

        private void ShowStandards()
        {
            try
            {
                IrradiationJournalADGVStandards.DataSource = null;

                if (IrradiationJournalADGVStandardsSets.SelectedRows.Count == 0)
                    return;

                var selCells = IrradiationJournalADGVStandardsSets.SelectedRows[0].Cells;
                List<LastSrmIrrInfo> StandardList = null;
                using (var ic = new InfoContext())
                {
                    StandardList = ic.NewStandards.FromSqlRaw($"EXEC [NAA_DB_TEST].[dbo].srminfo '{selCells[0].Value}', '{selCells[1].Value}', '{_type}'").ToList();
                    //StandardList = ic.Standards.Where(s =>
                    //                            s.SRM_Set_Name == selCells["SRM_Set_Name"].Value.ToString() &&
                    //                            s.SRM_Set_Number == selCells["SRM_Set_Number"].Value.ToString() &&
                    //                            ((_type == "SLI" && (s.SRM_SLI_Weight != 0 && s.SRM_SLI_Weight.HasValue)) ||
                    //                            (_type.Contains("LLI") && s.SRM_LLI_Weight != 0 && s.SRM_LLI_Weight.HasValue))
                    //                            &&
                    //                            !_irradiationList.Select(i => i.ToString()).Contains(s.ToString())
                    //                            ).ToList();
                }

                if (StandardList == null)
                    StandardList = new List<LastSrmIrrInfo>();


                var advbindSource = new  AdvancedBindingSource<LastSrmIrrInfo>(StandardList);
                IrradiationJournalADGVStandards.SetDoubleBuffered();
                var bindingSource = advbindSource.GetBindingSource();
                IrradiationJournalADGVStandards.DataSource = bindingSource;

                //_currentWeightStandardColumnName = _type.Contains("LLI") ? "SRM_LLI_Weight" : "SRM_SLI_Weight";

                //var restWeightColumn = new List<string>(){ "SRM_LLI_Weight", "SRM_SLI_Weight" };
                //restWeightColumn.Remove(_currentWeightStandardColumnName);

                SetColumnsProperties(ref IrradiationJournalADGVStandards,
                    new string[0], //{"SRM_Set_Name", "SRM_Set_Number", "SRM_SLI_Weight", "SRM_LLI_Weight"},
                    new Dictionary<string, string>()
                    {
                        { "SRM_Number",                     "Номер"                    },
                        { "LastDateOfIrradiation",          "Дата последнего облучения"},
                        { "NumberOfIrradiations",           "Количество облучений"     }
                    },
                    new string[0]
                    );
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

        private void AddIrradiationInfoFromStandards()
        {
            if (IrradiationJournalADGVStandardsSets.SelectedRows.Count != 1)
                throw new InvalidOperationException("Не выбрана ни одна партия стандартов!");

            if (IrradiationJournalADGVStandards.SelectedRows.Count == 0)
                throw new ArgumentException("Не выбран ни один стандарт для добавления в журнал облучений!");

            if (_type == "SLI")
                AddStandardsIrradiationInfoSLI();
            if (_type.Contains("LLI"))
                AddStandardsIrradiationInfoLLI();
        }

        private void AddStandardsIrradiationInfoSLI()
        {
            try
            {
                foreach (DataGridViewRow row in IrradiationJournalADGVStandards.SelectedRows.OfType<DataGridViewRow>().Reverse())
                {
                    var drvSet = IrradiationJournalADGVStandardsSets.SelectedRows[0];

                    var newIrr = new IrradiationInfo()
                    {
                        CountryCode   = "s",
                        ClientNumber  = "s",
                        Year          = "s",
                        SetNumber     = drvSet.Cells["SRM_Set_Name"].Value.ToString(),
                        SetIndex      = drvSet.Cells["SRM_Set_Number"].Value.ToString(),
                        SampleNumber  = row.Cells["SRM_Number"].Value.ToString(),
                        Type          = _type,
                        DateTimeStart = _currentJournalDateTime.Date,
                        //Weight        = string.IsNullOrEmpty(row.Cells[_currentWeightStandardColumnName].Value.ToString()) ? 0 : decimal.Parse(row.Cells[_currentWeightStandardColumnName].Value.ToString()),
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


        private void AddStandardsIrradiationInfoLLI()
        {
            try
            {
                foreach (DataGridViewRow row in IrradiationJournalADGVStandards.SelectedRows.OfType<DataGridViewRow>().Reverse())
                {
                    var drvSet = IrradiationJournalADGVStandardsSets.SelectedRows[0];

                    var newIrr = new IrradiationInfo()
                    {
                        CountryCode   = "s",
                        ClientNumber  = "s",
                        Year          = "s",
                        SetNumber     = drvSet.Cells["SRM_Set_Name"].Value.ToString(),
                        SetIndex      = drvSet.Cells["SRM_Set_Number"].Value.ToString(),
                        SampleNumber  = row.Cells["SRM_Number"].Value.ToString(),
                        Type          = _type,
                        DateTimeStart = _currentJournalDateTime.Date,
                        //Weight        = string.IsNullOrEmpty(row.Cells[_currentWeightStandardColumnName].Value.ToString()) ? 0 : decimal.Parse(row.Cells[_currentWeightStandardColumnName].Value.ToString()),
                        Duration      = Duration,
                        Container     = ContainerNumber,
                        Position      = PositionInContainer,
                        Channel       = this.Channel,
                        LoadNumber    = _loadNumber
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
