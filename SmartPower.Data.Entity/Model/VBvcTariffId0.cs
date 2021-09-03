using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcTariffId0
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public int Spil { get; set; }
        public int? TariffId { get; set; }
        public int RateId { get; set; }
        public string LineDescription { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitCost { get; set; }
        public double? InvLineTotal { get; set; }
        public int? RateClass { get; set; }
    }
}
