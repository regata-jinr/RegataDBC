using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Extensions.Models
{
    [Table("table_Sample")]
    public class SampleInfo
    {

        [Ignore]
        [Key]
        public string F_Country_Code { get; set; }
        [Ignore]
        [Key]
        public string F_Client_Id { get; set; }
        [Ignore]
        [Key]
        public string F_Year { get; set; }
        [Ignore]
        [Key]
        public string F_Sample_Set_Id { get; set; }
        [Ignore]
        [Key]
        public string F_Sample_Set_Index { get; set; }
        [Ignore]
        [Key]
        public string A_Sample_ID { get; set; }

        [NotMapped]
        [Index(0)]
        public int Number { get; set; }
        [Index(1)]
        public string A_Client_Sample_ID { get; set; }
        [Index(2)]
        public string A_Sample_Type { get; set; }
        [Index(3)]
        public string A_Sample_Subtype { get; set; }
        [Index(4)]
        public string A_Latitude { get; set; }
        [Index(5)]
        public string A_Longitude { get; set; }
        [Index(6)]
        public string A_Collection_Place { get; set; }
        [Index(7)]
        public string A_Determined_Elements { get; set; }
        [Index(8)]
        public string A_Halogens_Plan { get; set; }
        [Index(9)]
        public string A_Heavy_Metals_Plan { get; set; }
        [Index(10)]
        public bool A_Short_Lived_Plan { get; set; }
        [Index(11)]
        public bool A_Long_Lived_Plan { get; set; }
        [Index(12)]
        public bool A_F_Plan { get; set; }
        [Index(13)]
        public bool A_Na_Plan { get; set; }
        [Index(14)]
        public bool A_Mg_Plan { get; set; }
        [Index(15)]
        public bool A_Al_Plan { get; set; }
        [Index(16)]
        public bool A_Si_Plan { get; set; }
        [Index(17)]
        public bool A_S_Plan { get; set; }
        [Index(18)]
        public bool A_Cl_Plan { get; set; }
        [Index(19)]
        public bool A_K_Plan { get; set; }
        [Index(20)]
        public bool A_Ca_Plan { get; set; }
        [Index(21)]
        public bool A_Sc_Plan { get; set; }
        [Index(22)]
        public bool A_Ti_Plan { get; set; }
        [Index(23)]
        public bool A_V_Plan { get; set; }
        [Index(24)]
        public bool A_Cr_Plan { get; set; }
        [Index(25)]
        public bool A_Mn_Plan { get; set; }
        [Index(26)]
        public bool A_Fe_Plan { get; set; }
        [Index(27)]
        public bool A_Co_Plan { get; set; }
        [Index(28)]
        public bool A_Ni_Plan { get; set; }
        [Index(29)]
        public bool A_Cu_Plan { get; set; }
        [Index(30)]
        public bool A_Zn_Plan { get; set; }
        [Index(31)]
        public bool A_Ga_Plan { get; set; }
        [Index(32)]
        public bool A_Ge_Plan { get; set; }
        [Index(33)]
        public bool A_As_Plan { get; set; }
        [Index(34)]
        public bool A_Se_Plan { get; set; }
        [Index(35)]
        public bool A_Br_Plan { get; set; }
        [Index(36)]
        public bool A_Rb_Plan { get; set; }
        [Index(37)]
        public bool A_Sr_Plan { get; set; }
        [Index(38)]
        public bool A_Y_Plan { get; set; }
        [Index(39)]
        public bool A_Zr_Plan { get; set; }
        [Index(40)]
        public bool A_Nb_Plan { get; set; }
        [Index(41)]
        public bool A_Mo_Plan { get; set; }
        [Index(42)]
        public bool A_Ru_Plan { get; set; }
        [Index(43)]
        public bool A_Pd_Plan { get; set; }
        [Index(44)]
        public bool A_Ag_Plan { get; set; }
        [Index(45)]
        public bool A_Cd_Plan { get; set; }
        [Index(46)]
        public bool A_In_Plan { get; set; }
        [Index(47)]
        public bool A_Sn_Plan { get; set; }
        [Index(48)]
        public bool A_Sb_Plan { get; set; }
        [Index(49)]
        public bool A_I_Plan { get; set; }
        [Index(50)]
        public bool A_Cs_Plan { get; set; }
        [Index(51)]
        public bool A_Ba_Plan { get; set; }
        [Index(52)]
        public bool A_La_Plan { get; set; }
        [Index(53)]
        public bool A_Ce_Plan { get; set; }
        [Index(54)]
        public bool A_Pr_Plan { get; set; }
        [Index(55)]
        public bool A_Nd_Plan { get; set; }
        [Index(56)]
        public bool A_Sm_Plan { get; set; }
        [Index(57)]
        public bool A_Eu_Plan { get; set; }
        [Index(58)]
        public bool A_Gd_Plan { get; set; }
        [Index(59)]
        public bool A_Tb_Plan { get; set; }
        [Index(60)]
        public bool A_Dy_Plan { get; set; }
        [Index(61)]
        public bool A_Ho_Plan { get; set; }
        [Index(62)]
        public bool A_Er_Plan { get; set; }
        [Index(63)]
        public bool A_Tm_Plan { get; set; }
        [Index(64)]
        public bool A_Yb_Plan { get; set; }
        [Index(65)]
        public bool A_Lu_Plan { get; set; }
        [Index(66)]
        public bool A_Hf_Plan { get; set; }
        [Index(67)]
        public bool A_Ta_Plan { get; set; }
        [Index(68)]
        public bool A_W_Plan { get; set; }
        [Index(69)]
        public bool A_Re_Plan { get; set; }
        [Index(70)]
        public bool A_Os_Plan { get; set; }
        [Index(71)]
        public bool A_Ir_Plan { get; set; }
        [Index(72)]
        public bool A_Pt_Plan { get; set; }
        [Index(73)]
        public bool A_Au_Plan { get; set; }
        [Index(74)]
        public bool A_Hg_Plan { get; set; }
        [Index(75)]
        public bool A_Th_Plan { get; set; }
        [Index(76)]
        public bool A_U_Plan { get; set; }
        [Index(77)]
        public string A_Notes { get; set; }
    }
}
