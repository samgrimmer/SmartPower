using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSparkNewSite
    {
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string ClientRef { get; set; }
        public string BuildingNo { get; set; }
        public string RegistryPoc { get; set; }
        public string SiteLocation { get; set; }
        public string RegistryNetwork { get; set; }
        public string SiteName { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public string SiteStatus { get; set; }
        public string MeterType { get; set; }
        public string ClientCc { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
