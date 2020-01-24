using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using Extensions.Models;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Extensions.Content
{
   public class SetContent : ISetContent
    {
        private readonly SqlConnectionStringBuilder conStr;
        public SetContent(string conString)
        {

            conStr = new SqlConnectionStringBuilder(conString);
            
        }
        string ISetContent.GeneralInfo { get; set; }
        string ISetContent.IrradiationInfo { get; set; }
        string ISetContent.NotesInfo { get; set; }
        BindingSource ISetContent.FormDataSet(string color)
        {
            DataSet ds = new DataSet();
            List<SamplesSetInfo> ssList = null;
            using (var ic = new InfoContext(conStr.ConnectionString))
                ssList = ic.Sets.FromSql("select Loggs from SamplesSetForNaaDB").ToList();

            if (ssList == null)
                ssList = new List<SamplesSetInfo>();

            var advbindSource = new AdvancedBindingSource<SamplesSetInfo>(ssList);
            return advbindSource.GetBindingSource();
        }
    }
}
