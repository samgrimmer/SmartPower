using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VLatestNonZeroDate
    {
        public int? MaxOfSpinvNumber { get; set; }
        public DateTime? MaxOfInvEndDate { get; set; }
        public DateTime? MaxOfInvStartDate { get; set; }
        public int SiteNo { get; set; }
    }
}
