using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewForms.Models
{
    [Table("table_SRM")]
    public class StandardInfo
    {
        public string SRM_Set_Name   { get; set; }
        public string SRM_Set_Number { get; set; }
        public Single SRM_Set_Weight { get; set; }
        public string SRM_Number     { get; set; }
        public Single? SRM_SLI_Weight { get; set; }
        public Single? SRM_LLI_Weight { get; set; }

        public override string ToString()
        {
            return $"s-s-s-{SRM_Set_Name}-{SRM_Set_Number}-{SRM_Number}";
        }
    }
}
