using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoiceGroupTotalsWithLine
    {
        public string SiteDescription { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string SiteName { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public string Description { get; set; }
        public int RateId { get; set; }
        public string RateCategory { get; set; }
        public string MeterType { get; set; }
        public string ClientRef { get; set; }
        public string ClientCc { get; set; }
        public string NetworkId { get; set; }
        public double? UnitTotal { get; set; }
        public int? RateClass { get; set; }
        public double? BatchTotal { get; set; }
        public bool? ReadyForUpload { get; set; }
        public double? TotalDollarsAll { get; set; }
        public double? InvLineTotal { get; set; }
    }
}
