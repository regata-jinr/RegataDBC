using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Drawing.Text;
using System;

namespace Extensions.Models
{
    [Table("table_Sample")]
    public class Sample : INotifyPropertyChanged, ICloneable
    {
        public override string ToString() => $"{F_Country_Code}-{F_Client_Id}-{F_Year}-{F_Sample_Set_Id}-{F_Sample_Set_Index}";
        public Sample() { }

        public Sample(string setKey)
        {
            var sk = setKey.Split('-');

            // TODO: add exception to wrong key, cover by test!
            F_Country_Code = sk[0];
            F_Client_Id = sk[1];
            F_Year = sk[2];
            F_Sample_Set_Id = sk[3];
            F_Sample_Set_Index = sk[4];

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        private string _CountryCode;

        [Ignore]
        [Key]
        public string F_Country_Code
        {
            get { return _CountryCode; }
            set
            {
                _CountryCode = value;
                NotifyPropertyChanged("CountryCode");
            }
        }
        [Ignore]
        [Key]
        public string F_Client_Id           { get; set; }
        [Ignore]
        [Key]
        public string F_Year                { get; set; }
        [Ignore]
        [Key]
        public string F_Sample_Set_Id       { get; set; }
        [Ignore]
        [Key]
        public string F_Sample_Set_Index    { get; set; }
        [Ignore]
        [Key]
        public string A_Sample_ID           { get; set; }

        [Index(0)]
        public string A_Client_Sample_ID    { get; set; }
        [Index(1)]
        public string A_Sample_Type         { get; set; }
        [Index(2)]
        public string A_Sample_Subtype      { get; set; }
        [Index(3)]
        public string A_Latitude            { get; set; }
        [Index(4)]
        public string A_Longitude           { get; set; }
        [Index(5)]
        public string A_Collection_Place    { get; set; }
        [Index(6)]
        public string A_Notes               { get; set; }
        [Index(7)]
        public string A_Determined_Elements { get; set; }

        [Ignore]
        public bool A_Drying_Plan           { get; set; }
        [Ignore]
        public bool A_Evaporation_Plan      { get; set; }
        [Ignore]
        public bool A_Fragmentation_Plan    { get; set; }
        [Ignore]
        public bool A_Freeze_Drying_Plan    { get; set; }
        [Ignore]
        public bool A_Homogenizing_Plan     { get; set; }
        [Ignore]
        public bool A_Pelletization_Plan    { get; set; }
        [Ignore]
        public float P_Weighting_SLI        { get; set; }
        [Ignore]
        public float P_Weighting_LLI        { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string PropName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropName));
        }
    }
}

