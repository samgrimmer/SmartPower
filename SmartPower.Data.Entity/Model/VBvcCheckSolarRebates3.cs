using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCheckSolarRebates3
    {
        public int RateId { get; set; }
        public int? RateClass { get; set; }
        public int? SpinvNumber { get; set; }
        public int BatchNo { get; set; }
    }
}
