using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCheckDollarsInternalConsistency
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public decimal? AmountToPay1 { get; set; }
        public decimal? AmountToPay2 { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? OpeningBalanceExGst { get; set; }
        public decimal? OpeningBalanceGst { get; set; }
        public decimal? Ob1 { get; set; }
        public decimal? Ob2 { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? Lines1 { get; set; }
        public decimal? Lines2 { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? Ppd1 { get; set; }
        public decimal? Ppd2 { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountExGst { get; set; }
        public decimal? InvAmountGst { get; set; }
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal? InclGstObLinesPpdToAmountToPay1 { get; set; }
        public decimal? ExGstObLinesPpdToAmountToPay2 { get; set; }
        public decimal? PdfInvAmountToPay { get; set; }
        public bool? ObGst { get; set; }
        public bool? PpdGst { get; set; }
        public bool? ApplySitePpd { get; set; }
    }
}
