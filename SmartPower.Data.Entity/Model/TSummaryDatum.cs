using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryDatum
    {
        public int SDataId { get; set; }
        public string SClientCode { get; set; }
        public string SClientName { get; set; }
        public int? SSiteId { get; set; }
        public string SAccountNo { get; set; }
        public string SSiteName { get; set; }
        public string SRetailerCode { get; set; }
        public string SSiteIcp { get; set; }
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public string SUtilityType { get; set; }
        public string SClientReferance { get; set; }
        public string SSiteStatus { get; set; }
        public int? SFinancialYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public string SMonthYear { get; set; }
        public double? SBudgetDollar { get; set; }
        public double? SBudgetConsumption { get; set; }
        public double? SActualDollars { get; set; }
        public double? SActualConsumption { get; set; }
        public double? SAccrualDollars { get; set; }
        public double? SAccrualConsumption { get; set; }
        public double? SEnvDollars { get; set; }
        public double? SEnvConsumption { get; set; }
        public double? STrendDollars { get; set; }
        public double? STrendConsumption { get; set; }
        public double? SCo2 { get; set; }
        public string SUnitType { get; set; }
        public double? SSiteEui12MonthConsumption { get; set; }
        public double? SSquOcc { get; set; }
        public double? SSquTotal { get; set; }
        public int? SScope { get; set; }
        public string SSource { get; set; }
        public string SActivity { get; set; }
        public double? SCo2Factor { get; set; }
        public string SCo2Code { get; set; }
        public string SFilter1 { get; set; }
        public string SFilter2 { get; set; }
        public string SFilter3 { get; set; }
        public string SFilter4 { get; set; }
        public string SFilter5 { get; set; }
        public string SFilter6 { get; set; }
        public string SFilter7 { get; set; }
        public string SFilter8 { get; set; }
        public string SFilter9 { get; set; }
        public string SFilter10 { get; set; }
        public byte[] SysSummaryDataTimestamp { get; set; }
        public double? SCo2Act { get; set; }
        public double? SCo2Env { get; set; }
    }
}
