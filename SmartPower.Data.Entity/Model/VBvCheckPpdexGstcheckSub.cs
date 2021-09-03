using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckPpdexGstcheckSub
    {
        public double? InvoicePpdexGst { get; set; }
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public bool Ppd { get; set; }
        public float DiscountPc { get; set; }
        public double? SumLineTotal { get; set; }
    }
}
