using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorSumOcc
    {
        public string ClientRef { get; set; }
        public double? SumOfSqMetresOccupied { get; set; }
        public string SiteType { get; set; }
        public string SiteStatus { get; set; }
    }
}
