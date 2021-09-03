using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VImwcDatamanagementDeleteOrphanLine
    {
        public int InvLineNo { get; set; }
        public int? SpinvNumber { get; set; }
        public string Description { get; set; }
        public string UnitType { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitCost { get; set; }
        public double? InvLineTotal { get; set; }
        public int RateId { get; set; }
        public string ProductId { get; set; }
        public int? TariffId { get; set; }
        public int? Expr1 { get; set; }
    }
}
