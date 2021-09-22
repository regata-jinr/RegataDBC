﻿/***************************************************************************
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
using RCM = Regata.Core.Messages;
using System;
using System.Windows.Forms;

namespace Regata.Desktop.WinForms.Irradiations
{
    public partial class IrradiationRegister
    {
        private void InitStatusStrip()
        {
            try
            {
                mainForm.StatusStrip.Items.Add(new ToolStripStatusLabel() { Name = _irrDateTime.ToShortDateString() });
                mainForm.StatusStrip.Items.Add(new ToolStripStatusLabel() { Name = _loadNumber.HasValue ? _loadNumber.Value.ToString() : "" });
                mainForm.StatusStrip.Items.Add(IrradiationTypeItems.EnumStatusLabel);
                mainForm.StatusStrip.Items.Add(VerbosityItems.EnumStatusLabel);
            }
            catch (Exception ex)
            {
                Report.Notify(new RCM.Message(Codes.ERR_UI_WF_INI_STAT) { DetailedText = ex.ToString() });
            }
        }
    } //public partial class MainForm
}     // namespace Regata.Desktop.WinForms.Measurements
