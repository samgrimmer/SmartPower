using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvChecksExpectedRaw
    {
        public int TSitesSiteNo { get; set; }
        public byte[] AccountNo { get; set; }
        public int? TInvoicesSiteNo { get; set; }
        public byte[] SiteDescription { get; set; }
        public int? BatchNo { get; set; }
        public int? Spinv { get; set; }
        public int? InvNoOfDays { get; set; }
        public double? InvoicedkWh { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public int? HistInvCount { get; set; }
        public DateTime? HistInvStart { get; set; }
        public DateTime? HistInvEnd { get; set; }
        public double? HistInvkWh { get; set; }
        public decimal? HistInvToPay { get; set; }
        public int? HistoryDays { get; set; }
        public byte[] InvNotes { get; set; }
        public byte[] Icp { get; set; }
        public byte[] ClientRef { get; set; }
        public byte[] ReadTypeCode { get; set; }
        public byte[] Comments { get; set; }
    }
}
