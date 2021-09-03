using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvEstimatesSumBySite
    {
        public int EsSiteId { get; set; }
        public double? SumOfEsDollarsDailyAvg { get; set; }
        public double? SumOfEsConsumptionDailyAvg { get; set; }
        public int? CountOfEsSiteId { get; set; }
    }
}
