using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebChartActual
    {
        public double? SumActualDollars { get; set; }
        public double? SumBudgetDollars { get; set; }
        public double? SumActualConsumption { get; set; }
        public double? SumBudgetConsumption { get; set; }
        public string MonthYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public string Month { get; set; }
        public string SUtilityType { get; set; }
    }
}
