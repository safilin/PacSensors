namespace PacSensors.Models
{
    public class GP_OVERVIEW
    {
        public int id {get; set;}
        public string LocalTime {get; set;} = String.Empty;
        public string AKZ {get; set;} = String.Empty;
        public string OKZ {get; set;} = String.Empty;
        public string Import_T1_kWh {get; set;} = String.Empty;
        public string Export_T1_kWh {get; set;} = String.Empty;
        public string Import_T2_kWh {get; set;} = String.Empty;
        public string Export_T2_kWh {get; set;} = String.Empty;
        public string Today_T1_kWh {get; set;} = String.Empty;
        public string Today_T2_kWh {get; set;} = String.Empty;
        public string ThisMonth_T1_kWh {get; set;} = String.Empty;
        public string ThisMonth_T2_kWh {get; set;} = String.Empty;
        public string DeviceState {get; set;} = String.Empty;
        public string P_L1_kW {get; set;} = String.Empty;
        public string P_L2_kW {get; set;} = String.Empty;
        public string P_L3_kW {get; set;} = String.Empty;
        public string P_SUM_kW {get; set;} = String.Empty;
        public string VA_SUM_kVA {get; set;} = String.Empty;
        public string VARQ1_SUM_kvar {get; set;} = String.Empty;
        public string PF_SUM { get; set; } = String.Empty;
    }
}
