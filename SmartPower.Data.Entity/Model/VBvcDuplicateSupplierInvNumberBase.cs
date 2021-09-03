using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcDuplicateSupplierInvNumberBase
    {
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string InvNumber { get; set; }
        public int? Cnt { get; set; }
    }
}
