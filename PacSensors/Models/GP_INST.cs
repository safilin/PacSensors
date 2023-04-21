namespace PacSensors.Models
{
    public class GP_INST
    {
        public int id { get; set; }
        public string LocalTime { get; set; } = String.Empty;
        public string V_L1_V { get; set; } = String.Empty;
        public string V_L2_V { get; set; } = String.Empty;
        public string V_L3_V { get; set; } = String.Empty;
        public string V_L12_V { get; set; } = String.Empty;
        public string V_L23_V { get; set; } = String.Empty;
        public string V_L31_V { get; set; } = String.Empty;
        public string I_L1_A { get; set; } = String.Empty;
        public string I_L2_A { get; set; } = String.Empty;
        public string I_L3_A { get; set; } = String.Empty;
        public string VA_L1_kVA { get; set; } = String.Empty;
        public string VA_L2_kVA { get; set; } = String.Empty;
        public string VA_L3_kVA { get; set; } = String.Empty;
        public string P_L1_kW { get; set; } = String.Empty;
        public string P_L2_kW { get; set; } = String.Empty;
        public string P_L3_kW { get; set; } = String.Empty;
        public string VARQ1_L1_kvar { get; set; } = String.Empty;
        public string VARQ1_L2_kvar { get; set; } = String.Empty;
        public string VARQ1_L3_kvar { get; set; } = String.Empty;
        public string PF_L1 { get; set; } = String.Empty;
        public string PF_L2 { get; set; } = String.Empty;
        public string PF_L3 { get; set; } = String.Empty;
        public string FREQ_Hz { get; set; } = String.Empty;
        public string V_LN_AVG_V { get; set; } = String.Empty;
        public string V_LL_AVG_V { get; set; } = String.Empty;
        public string I_AVG_A { get; set; } = String.Empty;
        public string VA_SUM_kVA { get; set; } = String.Empty;
        public string P_SUM_kW { get; set; } = String.Empty;
        public string VARQ1_SUM_kvar { get; set; } = String.Empty;
        public string PF_SUM { get; set; } = String.Empty;
        public string I_N_SEL_A { get; set; } = String.Empty;
    }
}
