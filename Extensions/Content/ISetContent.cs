using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Extensions.Content
{
  public  interface ISetContent
    {
        string GeneralInfo     { get; set; }
        string IrradiationInfo { get; set; }
        string NotesInfo       { get; set; }
        BindingSource FormDataSet(string color);
    }
}
