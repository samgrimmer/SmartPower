using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSumInvTotalsValidationChk
    {
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string ReadTypeCode { get; set; }
        public decimal? ObExGst { get; set; }
        public decimal? ObGst { get; set; }
        public decimal? ObInclGst { get; set; }
        public decimal? LineTotalExGst { get; set; }
        public decimal? LineTotalGst { get; set; }
        public decimal? LineTotalInclGst { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? CurrentChargesInclGst { get; set; }
        public decimal? CurrentChargesGst { get; set; }
        public decimal? CurrentChargesExGst { get; set; }
        public decimal? AmtToPayExGst { get; set; }
        public decimal? AmtToPayInclGst { get; set; }
        public decimal? AmtToPayGst { get; set; }
        public decimal? InvSubTotal { get; set; }
        public string InvNotes { get; set; }
        public double? TaxRate { get; set; }
        public int Test { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? AmountToPayExGst { get; set; }
        public decimal? AmountToPayGst { get; set; }
        public decimal? AmountToPayInclGst { get; set; }
        public bool? ObGst1 { get; set; }
        public bool? PpdGst { get; set; }
        public bool? ApplySitePpd { get; set; }
    }
}
