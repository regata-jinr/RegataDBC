using System;

namespace NewForms.Models
{
    public class LastSrmIrrInfo
    {
        public string    SRM_Set_Key              { get; set; }
        public string    SRM_Number               { get; set; }
        public DateTime? LastDateOfIrradiation    { get; set; }
        public int NumberOfIrradiations           { get; set; }

        public override string ToString()
        {
            return $"s-s-s-{SRM_Set_Key}-{SRM_Number}";
        }
    }
}
