using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckPpdexGstcheckCalDi
    {
        public int SiteNo { get; set; }
        public string SiteTypeCode { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public double? InvoicePpdexGst { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public float DiscountPc { get; set; }
        public double? CalculatedDiscount { get; set; }
        public double? Difference { get; set; }
    }
}
