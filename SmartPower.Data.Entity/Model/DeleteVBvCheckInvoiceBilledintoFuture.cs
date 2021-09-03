using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoiceBilledintoFuture
    {
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public int BatchNo { get; set; }
    }
}
