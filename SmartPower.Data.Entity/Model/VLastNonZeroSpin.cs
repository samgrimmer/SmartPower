using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VLastNonZeroSpin
    {
        public DateTime? MaxOfInvEndDate { get; set; }
        public DateTime? MaxOfInvStartDate { get; set; }
        public int SiteNo { get; set; }
    }
}
