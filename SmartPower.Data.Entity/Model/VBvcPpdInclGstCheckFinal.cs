using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcPpdInclGstCheckFinal
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public string SiteTypeCode { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public decimal? InvoicePpdInclGst { get; set; }
        public int BatchNo { get; set; }
        public double? CalculatedDiscount { get; set; }
        public double? Difference { get; set; }
        public bool? ApplySitePpd { get; set; }
    }
}
