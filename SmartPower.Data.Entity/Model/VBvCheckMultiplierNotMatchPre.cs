using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckMultiplierNotMatchPre
    {
        public int SiteNo { get; set; }
        public int SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public float? Multiplier { get; set; }
        public int RateId { get; set; }
        public string InvNotes { get; set; }
        public int BatchNo { get; set; }
        public int? TariffId { get; set; }
        public string Description { get; set; }
    }
}
