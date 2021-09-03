using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckKgVsCalculatedKWhPre
    {
        public int SiteNo { get; set; }
        public string UtilityCode { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public double? LinesKg { get; set; }
        public double? CalculatedKWhPre { get; set; }
        public double? HeaderKWh { get; set; }
        public double? KWhDifference { get; set; }
    }
}
