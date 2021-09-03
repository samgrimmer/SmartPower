using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSiteRetailerDiffToInvoice
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string InvoiceRetailerCode { get; set; }
        public string SiteRetailerCode { get; set; }
        public int? Test { get; set; }
    }
}
