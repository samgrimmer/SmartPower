using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorAreaTestSqmTotalConsistancy
    {
        public string ErrorDescription { get; set; }
        public string SiteType { get; set; }
        public int Spid { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string ClientRef { get; set; }
        public double? SqMetresTotal { get; set; }
        public double AvgSqmTotal { get; set; }
        public double SumSqmOccupied { get; set; }
        public double? SqMetresOccupied { get; set; }
        public string SiteComment { get; set; }
    }
}
