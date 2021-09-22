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
using Regata.Core.DataBase.Models;
using Regata.Core.Settings;
using Regata.Core.UI.WinForms;
using Regata.Core.UI.WinForms.Items;
using Regata.Core.UI.WinForms.Forms;
using System;
using System.Collections.Generic;

namespace Regata.Desktop.WinForms.Irradiations
{
    public partial class IrradiationRegister : IDisposable
    {
        // private Timer _timer;
        public RegisterForm<Irradiation> mainForm;
        private EnumItem<IrradiationType> IrradiationTypeItems;
        private EnumItem<Status> VerbosityItems;
        private IrradiationType _irrType;
        private DateTime _irrDateTime;
        private int? _loadNumber;


        public IrradiationRegister(DateTime dateTime,  IrradiationType irrType, int? loadNumber = null)
        {
            _loadNumber = loadNumber;
            _irrType = irrType;
            _irrDateTime = dateTime;
            mainForm = new RegisterForm<Irradiation>(tabsNum: 3) { Name = "IrradiationRegister", Text = "IrradiationRegister" };

            IrradiationTypeItems = new EnumItem<IrradiationType>();
            IrradiationTypeItems.CheckItem(irrType);
            VerbosityItems = new EnumItem<Status>();
            _chosenSamples = new List<Sample>();
            _chosenStandards = new List<Standard>();
            _chosenMonitors = new List<Monitor>();

            Settings<IrradiationSettings>.CurrentSettings.PropertyChanged += (s, e) =>
            {
                Labels.SetControlsLabels(mainForm);
            };

            mainForm.MainRDGV.RDGV_Set = Settings<IrradiationSettings>.CurrentSettings.MainTableSettings;

            Report.NotificationEvent += Report_NotificationEvent;

            InitMenuStrip();
            InitStatusStrip();
            InitCurrentRegister();
            InitSamplesRegisters();
            InitStandardsRegisters();
            InitMonitorsRegisters();
            InitializeRegFormingControls();
            InitializeIrradiationsParamsControls();

            mainForm.Load += MainForm_Load;

            Settings<IrradiationSettings>.Save();
        }

        private void Report_NotificationEvent(Core.Messages.Message msg)
        {
            PopUpMessage.Show(msg, Settings<IrradiationSettings>.CurrentSettings.DefaultPopUpMessageTimeoutSeconds);
        }

        private bool _isDisposed;

        ~IrradiationRegister()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (_isDisposed)
                return;

            if (isDisposing)
            {
                mainForm.Dispose();
            }

            _isDisposed = true;
            Settings<IrradiationSettings>.Save();

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await FillSamplesRegisters();
            await FillStandardsRegisters();
            await FillMonitorsRegisters();

            mainForm.buttonAddAllSamples.Enabled = true;
            mainForm.buttonAddSelectedSamplesToReg.Enabled = true;
            mainForm.buttonRemoveSelectedSamples.Enabled = true;
            mainForm.MainRDGV.HideColumns();
            //mainForm.MainRDGV.SetUpReadOnlyColumns();
            mainForm.MainRDGV.SetUpWritableColumns();

            ColorizeDGV(mainForm.MainRDGV);


            Labels.SetControlsLabels(mainForm);
        }

    } // public partial class MainForm
}     // namespace Regata.Desktop.WinForms.Measurements
