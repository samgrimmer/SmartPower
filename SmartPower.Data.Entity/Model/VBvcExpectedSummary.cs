using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcExpectedSummary
    {
        public DateTime? InvStartDate { get; set; }
        public int BatchNo { get; set; }
        public string RetailerName { get; set; }
        public string AccountNo { get; set; }
        public string SiteType { get; set; }
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public string ClientRef { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public short? InvNoOfDays { get; set; }
        public string ErrorDescription { get; set; }
        public string InvNotes { get; set; }
        public double? Calculated { get; set; }
        public double? Difference { get; set; }
        public string ClientCode { get; set; }
        public double? ConsumptionVariance { get; set; }
        public double? HistInvkWh { get; set; }
        public int? HistoryDays { get; set; }
        public double? ActualHistoryCalculatedByDays { get; set; }
        public double? ActualHistory { get; set; }
        public string Comments { get; set; }
        public string ReadTypeCode { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductId { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
