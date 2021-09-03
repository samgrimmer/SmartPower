using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckConsumptionCostBase
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public double? AmountExGst { get; set; }
        public double? CalcUnits { get; set; }
        public double? ConsumptionUnitsCents { get; set; }
        public string InvNumber { get; set; }
        public string TaxClass { get; set; }
        public DateTime? InvDate { get; set; }
        public double? TaxRate { get; set; }
        public int SiteNo { get; set; }
        public decimal? InvAmountExGst { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
