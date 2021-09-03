using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckRateIdnotintRate
    {
        public int? SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public int RateId { get; set; }
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
    }
}
