using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorAreaCheckSumOccupied
    {
        public string ClientRef { get; set; }
        public string SiteType { get; set; }
        public double SumSqmOccupied { get; set; }
    }
}
