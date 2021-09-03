using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceReadTypeNotListView
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
