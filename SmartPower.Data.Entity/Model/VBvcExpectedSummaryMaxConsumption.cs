using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcExpectedSummaryMaxConsumption
    {
        public double? MaxConsumption { get; set; }
        public int SiteNo { get; set; }
        public int? SpinvNumber { get; set; }
    }
}
