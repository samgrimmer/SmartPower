using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebRetailerLookupByInvoice
    {
        public string ClientCode { get; set; }
        public DateTime? BatchMonth { get; set; }
        public int SiteNo { get; set; }
        public string Retailer { get; set; }
    }
}
