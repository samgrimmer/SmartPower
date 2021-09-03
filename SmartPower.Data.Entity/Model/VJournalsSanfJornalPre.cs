using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsSanfJornalPre
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string SupplierRef { get; set; }
        public string InvNumber { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string GlAccount { get; set; }
        public string Division { get; set; }
        public string CostCentre { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? InvoicedKwh { get; set; }
        public decimal? SubtotalInclGst { get; set; }
        public decimal? InvDiscountInclGst { get; set; }
        public decimal? InvAmountToPayInclGst { get; set; }
        public double? InvoiceAmountToPayExclGst { get; set; }
        public double? Gst { get; set; }
        public string Combined { get; set; }
        public string ReadType { get; set; }
        public string MeterType { get; set; }
        public bool? CreditInv { get; set; }
    }
}
