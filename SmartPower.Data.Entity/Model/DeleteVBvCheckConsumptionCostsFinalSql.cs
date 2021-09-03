using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckConsumptionCostsFinalSql
    {
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string SiteType { get; set; }
        public string MeterType { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public double? HeaderConsumption { get; set; }
        public double? AmountExGst { get; set; }
        public double? Consumption { get; set; }
        public string InvNotes { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string InputType { get; set; }
        public double? InvAmountExGst { get; set; }
    }
}
