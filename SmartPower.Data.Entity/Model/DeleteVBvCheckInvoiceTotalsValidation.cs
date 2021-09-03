using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoiceTotalsValidation
    {
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public double? OpeningBalanceExGst { get; set; }
        public double? OpeningBalanceGst { get; set; }
        public double? InvDiscountGst { get; set; }
        public double? InvDiscountExGst { get; set; }
        public double? InvAmountExGst { get; set; }
        public double? InvAmountGst { get; set; }
        public double? InvAmountToPayExGst { get; set; }
        public double? InvAmountToPayGst { get; set; }
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
