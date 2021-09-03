using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvResultsMtreportPivot
    {
        public int? SiteId { get; set; }
        public string SiteName { get; set; }
        public int? Days { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public double? Dollars { get; set; }
        public double? Units { get; set; }
    }
}
