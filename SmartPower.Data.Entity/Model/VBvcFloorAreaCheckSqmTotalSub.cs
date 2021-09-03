using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorAreaCheckSqmTotalSub
    {
        public string ClientRef { get; set; }
        public string SiteType { get; set; }
        public double MinSqmTotal { get; set; }
        public double AvgSqmTotal { get; set; }
    }
}
