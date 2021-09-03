using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvEstimatesBaseAvgByMonthBySite
    {
        public int EsSiteId { get; set; }
        public string EsDay { get; set; }
        public string EsMonth { get; set; }
        public string EsYear { get; set; }
        public decimal? EsDollarsDailyAvg { get; set; }
        public double? EsConsumptionDailyAvg { get; set; }
        public string EsReadType { get; set; }
        public int EsSpinvNum { get; set; }
        public string EsInvNum { get; set; }
        public string EsCreditBalance { get; set; }
        public string EsSourceType { get; set; }
        public bool? EsCreditInvoice { get; set; }
        public bool? ReadyForUpload { get; set; }
    }
}
