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
using Regata.Core.Settings;
using System;
using System.Windows.Forms;

namespace Regata.Desktop.WinForms.Irradiations
{
    public partial class IrradiationRegister
    {
        private ToolStripMenuItem _changeRegisterDate;
        private ToolStripMenuItem _channelMenuStrip;

        private void InitMenuStrip()
        {
            try
            {
                mainForm.LangItem.CheckedChanged += () => Settings<IrradiationSettings>.CurrentSettings.CurrentLanguage = mainForm.LangItem.CheckedItem;
                mainForm.LangItem.CheckItem(Settings<IrradiationSettings>.CurrentSettings.CurrentLanguage);

                VerbosityItems.CheckItem(Settings<IrradiationSettings>.CurrentSettings.Verbosity);

                VerbosityItems.CheckedChanged += () =>
                {
                    Settings<IrradiationSettings>.CurrentSettings.Verbosity = VerbosityItems.CheckedItem;
                };

                _changeRegisterDate= new ToolStripMenuItem();
                _changeRegisterDate.Name = "ChangeDateMenu";
                _changeRegisterDate.Click += _changeRegisterDate_Click;

                _channelMenuStrip = new ToolStripMenuItem();
                _channelMenuStrip.Name = "ChannelMenuStrip";

                var ch1 = new ToolStripMenuItem() { Name = "1" };
                var ch2 = new ToolStripMenuItem() { Name = "2" };

                ch1.Click += (s,e) => mainForm.MainRDGV.FillDbSetValues("Channel", short.Parse(ch1.Name));
                ch2.Click += (s,e) => mainForm.MainRDGV.FillDbSetValues("Channel", short.Parse(ch2.Name));

                _channelMenuStrip.DropDownItems.Add(ch1);
                _channelMenuStrip.DropDownItems.Add(ch2);


                mainForm.MenuStrip.Items.Insert(0, VerbosityItems.EnumMenuItem);
                mainForm.MenuStrip.Items.Insert(0, _channelMenuStrip);
                mainForm.MenuStrip.Items.Insert(0, _changeRegisterDate);

              
            }
            catch (Exception ex)
            {
                Report.Notify(new RCM.Message(Codes.ERR_UI_WF_INI_MENU) { DetailedText = string.Join("--", ex.Message, ex?.InnerException?.Message) });
            }
        }

        private void _changeRegisterDate_Click(object sender, EventArgs e)
        {
            // TODO: support changing date for current register
        }
    } // public partial class IrradiationRegister
}     // namespace Regata.Desktop.WinForms.Irradiation
