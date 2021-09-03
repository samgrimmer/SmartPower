using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceTotalsValidation
    {
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public decimal? OpeningBalanceExGst { get; set; }
        public decimal? OpeningBalanceGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvAmountExGst { get; set; }
        public decimal? InvAmountGst { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string ReadTypeCode { get; set; }
        public decimal? InvTotal { get; set; }
        public string InvNotes { get; set; }
    }
}
