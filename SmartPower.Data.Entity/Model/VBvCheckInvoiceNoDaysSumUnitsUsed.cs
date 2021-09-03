using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckInvoiceNoDaysSumUnitsUsed
    {
        public int SpinvNumber { get; set; }
        public double? SumofUnitsUsed { get; set; }
        public int BatchNo { get; set; }
        public string UnitType { get; set; }
        public int? TariffId { get; set; }
        public float? Multiplier { get; set; }
        public int? RateId { get; set; }
    }
}
