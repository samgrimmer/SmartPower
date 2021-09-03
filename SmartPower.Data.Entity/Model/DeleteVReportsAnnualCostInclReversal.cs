using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVReportsAnnualCostInclReversal
    {
        public int SiteNo { get; set; }
        public string MeterType { get; set; }
        public string Icp { get; set; }
        public string AccountNo { get; set; }
        public string SiteComments { get; set; }
        public string SiteStatus { get; set; }
        public string RetailerCode { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public int BatchNo { get; set; }
        public string ClientRef { get; set; }
        public string Entity { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? BatchDate { get; set; }
        public DateTime? InvDate { get; set; }
        public decimal? InvTotal { get; set; }
        public string ClientCode { get; set; }
        public DateTime? BatchMonth { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public int? OrgId { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public double? InvAmtToPayExGst { get; set; }
        public string BatchMonthYear { get; set; }
        public double? InvAmtToPayExGstZeroCredits { get; set; }
        public double? CalcTotalUnits { get; set; }
        public DateTime? InvStartDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public string InvNumber { get; set; }
        public string EnergyTypeCode { get; set; }
        public string EnergyType { get; set; }
        public string SiteTypeCode { get; set; }
        public string SiteType { get; set; }
        public bool? ReadyForUpload { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
