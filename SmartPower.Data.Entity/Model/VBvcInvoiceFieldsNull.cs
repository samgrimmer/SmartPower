using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceFieldsNull
    {
        public string ErrorDescription { get; set; }
        public int Spin { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? OpeningBalanceExGst { get; set; }
        public decimal? OpeningBalanceGst { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? InvAmountExGst { get; set; }
        public decimal? InvAmountGst { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public int BatchNo { get; set; }
    }
}
