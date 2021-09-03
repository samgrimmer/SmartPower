using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebSummaryActual
    {
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public int? SFinancialYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public double? ActualDollars { get; set; }
        public double? ActualConsumption { get; set; }
        public double? EnvDollars { get; set; }
        public double? EnvConsumption { get; set; }
    }
}
