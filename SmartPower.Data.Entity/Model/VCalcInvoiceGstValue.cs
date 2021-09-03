using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VCalcInvoiceGstValue
    {
        public string TaxClass { get; set; }
        public double? TaxRate { get; set; }
        public DateTime? TaxPeriodStart { get; set; }
        public DateTime? TaxPeriodEnd { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? LineTotal { get; set; }
        public double? InvAmtToPayCalcGstValue { get; set; }
        public double? InvAmtToPayExGst { get; set; }
        public double? InvAmntLExclGst { get; set; }
        public double? InvAmtToCalcGstValue { get; set; }
        public double? InvAmtToPayExGstZeroCredits { get; set; }
        public bool? CreditInv { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
