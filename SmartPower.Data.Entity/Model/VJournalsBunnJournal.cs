using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsBunnJournal
    {
        public int BatchNumber { get; set; }
        public int SpInvNumber { get; set; }
        public string Supplier { get; set; }
        public string RetailerInvNumber { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string GlCode { get; set; }
        public string Region { get; set; }
        public string CostCentre { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public short? NoOfDays { get; set; }
        public double? Kwh { get; set; }
        public decimal? SubtotalinclGst { get; set; }
        public decimal? InvDiscountinclGst { get; set; }
        public decimal? InvAmtToPayinclGst { get; set; }
        public double? InvAmtToPayExclGst { get; set; }
        public double? Gst { get; set; }
    }
}
