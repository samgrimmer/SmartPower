using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcRateId0
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int RateId { get; set; }
        public int InvLineNo { get; set; }
        public string Description { get; set; }
        public double? UnitsUsed { get; set; }
        public string UnitType { get; set; }
        public double? UnitCost { get; set; }
        public double? InvLineTotal { get; set; }
    }
}
