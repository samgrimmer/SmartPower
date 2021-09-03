using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEsmartActualCompare
    {
        public int SiteNo { get; set; }
        public DateTime? BatchMonth { get; set; }
        public decimal? Dollars { get; set; }
        public double? Consumption { get; set; }
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
    }
}
