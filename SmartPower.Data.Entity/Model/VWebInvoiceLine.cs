using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebInvoiceLine
    {
        public int InvLineNo { get; set; }
        public int? SpinvNumber { get; set; }
        public string Description { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitCost { get; set; }
        public float? Multiplier { get; set; }
        public double? InvLineTotal { get; set; }
        public string ProductId { get; set; }
        public string UnitType { get; set; }
    }
}
