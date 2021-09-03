using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcRedFlagAll
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public int? Spin { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public bool Managed { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string Comments { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DateCeased { get; set; }
        public bool? RedFlag { get; set; }
    }
}
