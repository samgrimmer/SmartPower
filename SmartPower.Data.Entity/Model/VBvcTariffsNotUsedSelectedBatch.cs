using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcTariffsNotUsedSelectedBatch
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string SpidRetailerCode { get; set; }
        public int Spin { get; set; }
        public string SpinRetailerCode { get; set; }
        public int TariffId { get; set; }
        public string RateRetailerCode { get; set; }
        public string TariffDescription { get; set; }
        public int RateId { get; set; }
        public double? UnitCost { get; set; }
        public string Status { get; set; }
        public bool? PenaltyRate { get; set; }
    }
}
