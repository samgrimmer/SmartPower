using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcQuerySavingsOutstanding
    {
        public int Quid { get; set; }
        public DateTime? DateAdded { get; set; }
        public string SiteName { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public bool? Managed { get; set; }
        public string ManagedBy { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public int? Spid { get; set; }
        public int? Spin { get; set; }
        public int? Spib { get; set; }
        public string Quclass { get; set; }
        public string QuOverview { get; set; }
        public string Comments { get; set; }
    }
}
