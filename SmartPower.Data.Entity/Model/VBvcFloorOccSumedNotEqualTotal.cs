using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorOccSumedNotEqualTotal
    {
        public string ClientRef { get; set; }
        public string SiteType { get; set; }
        public double? SumOfSqMetresOccupied { get; set; }
        public double? SqMetresTotal { get; set; }
        public double? Test { get; set; }
    }
}
