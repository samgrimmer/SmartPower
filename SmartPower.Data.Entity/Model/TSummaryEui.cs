using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryEui
    {
        public int SEuiId { get; set; }
        public int? SSiteId { get; set; }
        public int? SEuiFy { get; set; }
        public double? SEuiValue { get; set; }
        public double? SSquareMeters { get; set; }
        public double? STotalAnnualConsumption { get; set; }
    }
}
