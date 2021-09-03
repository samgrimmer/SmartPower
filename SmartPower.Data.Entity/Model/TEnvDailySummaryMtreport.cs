using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEnvDailySummaryMtreport
    {
        public int EsId { get; set; }
        public int? EsSiteId { get; set; }
        public int? EsDay { get; set; }
        public int? EsMonth { get; set; }
        public int? EsYear { get; set; }
        public double? EsDollarsDailyAvg { get; set; }
        public double? EsConsumptionDailyAvg { get; set; }
        public string EsReadType { get; set; }
        public int? EsSpinvNum { get; set; }
        public string EsInvNum { get; set; }
        public string EsCreditBalance { get; set; }
        public DateTime? EsPeriod { get; set; }
        public string EsSourceType { get; set; }
        public int? EsEstimateInvCount { get; set; }
        public bool? EsCreditInvoice { get; set; }
        public DateTime? EsDateSiteAdded { get; set; }
        public DateTime? EsDateSiteCeased { get; set; }
        public byte[] SysDailySummaryMtreportTimestamp { get; set; }
    }
}
