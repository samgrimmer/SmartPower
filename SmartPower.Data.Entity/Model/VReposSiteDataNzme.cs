using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VReposSiteDataNzme
    {
        public string Retailer { get; set; }
        public string PricingType { get; set; }
        public string MeterType { get; set; }
        public string SiteDescription { get; set; }
        public string SiteLocation { get; set; }
        public string AccountNo { get; set; }
        public string ClientRef { get; set; }
        public string Icp { get; set; }
        public string SiteStatus { get; set; }
        public string SiteType { get; set; }
        public string NzmeOffice { get; set; }
        public string BusinessUnits { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Comments { get; set; }
    }
}
