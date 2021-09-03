using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcDuplicateIcpInvoice
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public int? CountOfSpinvNumber { get; set; }
        public string SiteComments { get; set; }
        public string SiteType { get; set; }
        public string SiteStatus { get; set; }
    }
}
