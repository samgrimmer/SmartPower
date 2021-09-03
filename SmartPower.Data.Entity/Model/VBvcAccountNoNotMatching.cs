using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcAccountNoNotMatching
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public int Spid { get; set; }
        public string SiteRetailerCode { get; set; }
        public string SiteAccountNo { get; set; }
        public int Spin { get; set; }
        public string InvoiceRetailerCode { get; set; }
        public string InvoiceAccountNo { get; set; }
        public string InvNotes { get; set; }
    }
}
