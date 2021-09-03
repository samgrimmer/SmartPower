using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCalcInvoiceFunctionSelectBase
    {
        public string ClientCode { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public int SpinvNumber { get; set; }
        public bool? IgnoreSiteDiscountPc { get; set; }
        public int BatchNo { get; set; }
        public float DiscountPc { get; set; }
        public double? BInvTotal { get; set; }
        public double? BInvGst { get; set; }
        public double? BOpeningBalanceGst { get; set; }
        public double? BOpeningBalanceExGst { get; set; }
        public double? BInvDiscountExGst { get; set; }
        public double? BInvDiscountGst { get; set; }
    }
}
