using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvSummaryMonthlyPivotMtreport
    {
        public int? Spid { get; set; }
        public string SiteName { get; set; }
        public int? Days { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public double? Dollars { get; set; }
        public double? Units { get; set; }
        public DateTime? Period { get; set; }
        public string EstimateActual { get; set; }
    }
}
