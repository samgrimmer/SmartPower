using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckMultipleInvoiceTest
    {
        public string RetailerCode { get; set; }
        public string RetailerInvNumber { get; set; }
        public string AccountNo { get; set; }
        public string Nmi { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string InvNotes { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string ReadTypeCode { get; set; }
        public int SpinvNumber { get; set; }
    }
}
