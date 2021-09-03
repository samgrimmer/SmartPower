using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckBatchOneOffFeeReview
    {
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string SiteType { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string LineDescription { get; set; }
        public string RateDescription { get; set; }
        public string UnitType { get; set; }
        public double? UnitsUsed { get; set; }
        public double? InvLineTotal { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public int? RateClass { get; set; }
    }
}
