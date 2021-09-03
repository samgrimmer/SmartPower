using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcExpectedSummaryFinal
    {
        public string ErrorDescription { get; set; }
        public string RetailerName { get; set; }
        public int SiteNo { get; set; }
        public bool Vacant { get; set; }
        public string SiteType { get; set; }
        public string ProductSubCat { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public DateTime? StartDate { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public short? InvNoOfDays { get; set; }
        public string ReadTypeCode { get; set; }
        public double? ActualHistory { get; set; }
        public double? Calculated { get; set; }
        public double? Difference { get; set; }
        public double? Variance { get; set; }
        public string InvNotes { get; set; }
        public int MaxConsumptionSpin { get; set; }
        public double? MaxConsumption { get; set; }
        public string MaxConsumptionReadTypeCode { get; set; }
        public string Comments { get; set; }
    }
}
