using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesActiveWithInv
    {
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteLocation { get; set; }
        public string Region { get; set; }
        public string Icp { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? DateAdded { get; set; }
        public string SiteTypeCode { get; set; }
    }
}
