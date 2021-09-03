using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckSitesNoInvoice
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public DateTime? LastInvEndDate { get; set; }
        public DateTime? LastInvStartDate { get; set; }
        public string SiteStatus { get; set; }
        public string Comments { get; set; }
        public string SiteType { get; set; }
        public int? Test { get; set; }
    }
}
