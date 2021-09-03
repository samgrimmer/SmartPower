using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TMobilJournal
    {
        public int RowNumber { get; set; }
        public string S { get; set; }
        public int? L { get; set; }
        public string DateStamp { get; set; }
        public string CustNo { get; set; }
        public string Acc { get; set; }
        public int Type { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public decimal? Amount { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Remark { get; set; }
        public string VendorNo { get; set; }
        public string GLAccount { get; set; }
        public string Freq { get; set; }
        public string RelatedAccount { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public double? GstAfterDiscount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FullAmount { get; set; }
        public decimal? InvGst { get; set; }
        public string SiteName { get; set; }
        public string ClientRef { get; set; }
        public string DiscountTitle { get; set; }
        public string AccountNumber { get; set; }
    }
}
