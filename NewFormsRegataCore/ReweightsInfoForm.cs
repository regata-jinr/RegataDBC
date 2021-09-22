using Regata.Core.DataBase;
using Regata.Core.DataBase.Models;
using Regata.Core.UI.WinForms.Forms;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Extensions.NewForms
{
    public static class ReweightsInfoForm 
    {
        public static RegisterForm<ReweightInfo> GetReweightsInfoForm(string cs, int loadNumber)
        {
            RegataContext.ConString = cs;

            using (var ic = new RegataContext())
            {
                var rf = new RegisterForm<ReweightInfo>();
                rf.MainRDGV.DataSource = ic.ReweightInfoes.AsNoTracking().Where(r => r.LoadNumber == loadNumber).ToList();
                rf.BottomLayoutPanel.Visible = false;
                return rf;
            }

        }

    }
}
