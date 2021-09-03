using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebSummaryBudgetDollarsConsumption
    {
        public int? EsSiteId { get; set; }
        public int? EsMonth { get; set; }
        public int? EsYear { get; set; }
        public DateTime? EsPeriod { get; set; }
        public double? EsDollarsDailyAvg { get; set; }
        public double? EsConsumptionDailyAvg { get; set; }
    }
}
