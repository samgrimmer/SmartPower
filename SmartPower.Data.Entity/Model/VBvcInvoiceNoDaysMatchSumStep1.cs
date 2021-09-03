using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysMatchSumStep1
    {
        public int SpinvNumber { get; set; }
        public double UnitsUsed { get; set; }
        public int BatchNo { get; set; }
        public string UnitType { get; set; }
        public int? TariffId { get; set; }
        public float? Multiplier { get; set; }
        public int? RateId { get; set; }
        public string TariffDescription { get; set; }
        public int SiteNo { get; set; }
        public int? SiteNoForTariff { get; set; }
    }
}
