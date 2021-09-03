using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckExpectedRaw
    {
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public int SiteNoInvoices { get; set; }
        public string SiteDescription { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? UnitTotal { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public int? HistInvCount { get; set; }
        public DateTime? HistInvStart { get; set; }
        public DateTime? HistInvEnd { get; set; }
        public double? HistInvkWh { get; set; }
        public decimal? HistInvToPay { get; set; }
        public int? HistoryDays { get; set; }
        public string InvNotes { get; set; }
        public string Icp { get; set; }
        public string ClientRef { get; set; }
        public string ReadTypeCode { get; set; }
        public string Comments { get; set; }
        public double? ConsumptionVariance { get; set; }
    }
}
