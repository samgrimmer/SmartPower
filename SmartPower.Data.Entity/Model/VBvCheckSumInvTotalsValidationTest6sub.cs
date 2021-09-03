using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckSumInvTotalsValidationTest6sub
    {
        public double? SumInvLineTotal { get; set; }
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public string ReadTypeCode { get; set; }
        public double? ObExGst { get; set; }
        public double? ObGst { get; set; }
        public decimal? ObInclGst { get; set; }
        public decimal? LineTotalExGst { get; set; }
        public decimal? LineTotalGst { get; set; }
        public decimal? LineTotalInclGst { get; set; }
        public double? InvDiscountExGst { get; set; }
        public double? InvDiscountGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? CurrentChargesInclGst { get; set; }
        public double? CurrentChargesGst { get; set; }
        public double? CurrentChargesExGst { get; set; }
        public double? AmtToPayExGst { get; set; }
        public decimal? AmtToPayInclGst { get; set; }
        public double? AmtToPayGst { get; set; }
        public string InvNotes { get; set; }
        public decimal? InvSubTotal { get; set; }
        public double? TaxRate { get; set; }
        public bool Ppd { get; set; }
        public bool Gst { get; set; }
        public int? CountSpin { get; set; }
    }
}
