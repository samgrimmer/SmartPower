using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VDetailedInvoiceLineInformation
    {
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string Product { get; set; }
        public string ProductSubCat { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? BatchMonth { get; set; }
        public DateTime? EnvironmentalMonth { get; set; }
        public int InvLineNo { get; set; }
        public string RateDescription { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitCost { get; set; }
        public double? InvLineTotal { get; set; }
    }
}
