using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcUnknownIcpActiveSite
    {
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string SiteName { get; set; }
        public string ClientRef { get; set; }
        public string Comments { get; set; }
        public string Icp { get; set; }
        public string SiteStatus { get; set; }
    }
}
