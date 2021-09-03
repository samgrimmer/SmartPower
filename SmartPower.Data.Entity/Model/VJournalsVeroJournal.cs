using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsVeroJournal
    {
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public int? SpinvNumberOrig { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteLocation { get; set; }
        public string Region2 { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? Kwh { get; set; }
        public string GlCode { get; set; }
        public string ClientCc { get; set; }
        public string ClientRef { get; set; }
        public decimal? SubtotalInclGst { get; set; }
        public decimal? InvDiscountInclGst { get; set; }
        public decimal? InvAmountToPayInclGst { get; set; }
        public double? InvoiceAmountToPayExclGst { get; set; }
        public double? Gst { get; set; }
    }
}
