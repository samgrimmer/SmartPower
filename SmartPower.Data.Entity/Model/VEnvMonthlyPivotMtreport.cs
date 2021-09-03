using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvMonthlyPivotMtreport
    {
        public int? EsSiteId { get; set; }
        public int? CountOfEsDay { get; set; }
        public int? EsMonth { get; set; }
        public int? EsYear { get; set; }
        public double? SumOfEsDollarsDailyAvg { get; set; }
        public double? SumOfEsConsumptionDailyAvg { get; set; }
        public string EsSourceType { get; set; }
    }
}
