using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckNullSiteStartDate
    {
        public int SiteNo { get; set; }
        public string SiteStatus { get; set; }
        public string RetailerName { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Comments { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FirstInvoiceStartDate { get; set; }
        public bool Managed { get; set; }
        public bool ManagedSite { get; set; }
    }
}
