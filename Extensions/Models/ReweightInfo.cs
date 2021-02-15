using System.ComponentModel.DataAnnotations.Schema;

namespace Extensions.Models
{
    [Table("reweightInfo")]
    public class ReweightInfo
    {
        public int      loadNumber         { get; set; }
        public string   Country_Code       { get; set; }
        public string   Client_ID          { get; set; }
        public string   Year               { get; set; }
        public string   Sample_Set_ID      { get; set; }
        public string   Sample_Set_Index   { get; set; }
        public string   Sample_ID          { get; set; }
        public short    Container_Number   { get; set; }
        public short    Position_Number    { get; set; }
        public float?   InitWght           { get; set; }
        public float?   EmptyContWght      { get; set; }
        public float?   ContWithSampleWght { get; set; }
        public float?   ARepackWght        { get; set; }
        public float?   Diff               { get; set; }

    }
}
