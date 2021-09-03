using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEnvSummaryMtreport
    {
        public int EsId { get; set; }
        public int? EsSiteId { get; set; }
        public int? EsMonth { get; set; }
        public int? EsYear { get; set; }
        public double? EsDollarsDailyAvg { get; set; }
        public int? EsConsumptionDailyAvg { get; set; }
        public int? EsDaysInMonth { get; set; }
        public int? EsNoOfInvDays { get; set; }
        public int? EsNoOfAccrualDays { get; set; }
        public double? EsActualDollars { get; set; }
        public int? EsActualConsumption { get; set; }
        public double? EsAccrualDollars { get; set; }
        public int? EsAccrualConsumption { get; set; }
        public byte[] SysSummaryMtreportTimestamp { get; set; }
    }
}
