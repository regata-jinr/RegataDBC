using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Extensions.Models
{
    public class SampleSetInfo
    {
        public string Country_Code { get; set; }
        public string Client_ID { get; set; }
        public string Year { get; set; }
        public string Sample_Set_ID { get; set; }
        public string Sample_Set_Index { get; set; }
        public string Country { get; set; }
        public string Organization { get; set; }
        public string Last_Name { get; set; }
        public int countOfSamples { get; set; }
        public string A_Sample_Type { get; set; }
        public DateTime SLIDate_Start { get; set; }
        public DateTime LLIDate_Start { get; set; }
        public string R_Processed_By { get; set; }
        public string Results { get; set; }
        public string SamplPrep { get; set; }
        public string SamplSLI { get; set; }
        public string SamplLLI { get; set; }
        public string color { get; set; }
        public string Loggs { get; set; }
        public DateTime Sample_Set_Receipt_Date { get; set; }
        public int ProcessedSamples { get; set; }
        public string Notes_3 { get; set; }
        public string Note { get; set; }
        public bool ResCompl { get; set; }
        public bool SLICompl { get; set; }
        public bool LLICompl { get; set; }
        public int rn { get; set; }

    }
}

