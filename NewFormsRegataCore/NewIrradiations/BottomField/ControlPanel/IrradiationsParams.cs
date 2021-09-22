/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2021, REGATA Experiment at FLNP|JINR                       *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 *                                                                         *
 * The REGATA Experiment team license this file to you under the           *
 * GNU GENERAL PUBLIC LICENSE                                              *
 *                                                                         *
 ***************************************************************************/

using Regata.Core;
using Regata.Core.Settings;
using Regata.Core.DataBase.Models;
using RCM = Regata.Core.Messages;
using Regata.Core.UI.WinForms.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Regata.Desktop.WinForms.Irradiations
{
    public partial class IrradiationRegister
    {
        public ControlsGroupBox controlsIrrParams;
        public CheckedArrayControl<short?> CheckedContainerArrayControl;
        public Button buttonRehandle;
        public Button buttonAssingNowDateTime;
        public DurationControl DurationControl;

        private void InitializeIrradiationsParamsControls()
        {
            try
            {
                DurationControl = new DurationControl();
                CheckedContainerArrayControl = new CheckedArrayControl<short?>(new short?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, multiSelection: false) { Name = "CheckedArrayControlContainers" };
                buttonAssingNowDateTime = new Button() { AutoSize = false, Dock = DockStyle.Fill, Name = "buttonAssingNowDateTime", Enabled = false };
                CheckedContainerArrayControl.SelectItem(1);
                CheckedContainerArrayControl.checkedListBox.ColumnWidth = 70;
                controlsIrrParams = new ControlsGroupBox(new Control[] { DurationControl, CheckedContainerArrayControl, buttonAssingNowDateTime }) { Name = "controlsIrrParams" };
                controlsIrrParams._tableLayoutPanel.RowStyles[0].Height = 35F;
                controlsIrrParams._tableLayoutPanel.RowStyles[1].Height = 45F;
                controlsIrrParams._tableLayoutPanel.RowStyles[2].Height = 20F;
                mainForm.FunctionalLayoutPanel.Controls.Add(controlsIrrParams, 1, 0);

                DurationControl.DurationChanged += (s, e) =>
                    {
                        mainForm.MainRDGV.FillDbSetValues("Duration", (int)DurationControl.Duration.TotalSeconds);
                        FillDateTimeFinish();
                    };
                CheckedContainerArrayControl.SelectionChanged += (s, e) => mainForm.MainRDGV.FillDbSetValues("Container", CheckedContainerArrayControl.SelectedItem);

                DurationControl.Duration = _irrType switch
                {
                    IrradiationType.sli => TimeSpan.FromSeconds(Settings<IrradiationSettings>.CurrentSettings.DefaultSLITime),
                    IrradiationType.lli => TimeSpan.FromSeconds(Settings<IrradiationSettings>.CurrentSettings.DefaultLLITime),
                    _ => TimeSpan.FromSeconds(0),
                };

                CheckedContainerArrayControl.SelectItem(1);

                // TODO: add rehandler column and mapping from name to int
                buttonAssingNowDateTime.Click += (s, e) =>
                {
                    mainForm.MainRDGV.FillDbSetValues("DateTimeStart", DateTime.Now);
                    FillDateTimeFinish();

                };
            }
            catch (Exception ex)
            {
                Report.Notify(new RCM.Message(Codes.ERR_UI_WF_INI_MEAS_PARAMS)
                {
                    DetailedText = ex.ToString()
                });
            }
        }

        private void FillDateTimeFinish()
        {
            foreach (var i in mainForm.MainRDGV.SelectedCells.OfType<DataGridViewCell>().Select(c => c.RowIndex).Where(c => c >= 0).Distinct())
            {
                var m = mainForm.MainRDGV.CurrentDbSet.Where(m => m.Id == (int)mainForm.MainRDGV.Rows[i].Cells["Id"].Value).FirstOrDefault();
                if (m == null || !m.DateTimeStart.HasValue) continue;
                m.DateTimeFinish = m.DateTimeStart.Value.AddSeconds(DurationControl.Duration.TotalSeconds);
                mainForm.MainRDGV.CurrentDbSet.Update(m);

            }
            mainForm.MainRDGV.Refresh();
            mainForm.MainRDGV.SaveChanges();
        }

    } //public partial class MainForm
}     // namespace Regata.Desktop.WinForms.Measurements
