using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMhjJournal
    {
        public string SmartPowerInvNumber { get; set; }
        public string SmartPowerInvoiceDate { get; set; }
        public int BatchNo { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? DateOfInvoice { get; set; }
        public string SupplierRef { get; set; }
        public string ClientCc { get; set; }
        public string ClientRef { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string InvoiceDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public decimal? SubTotalinclGst { get; set; }
        public decimal? InvDiscountinclGst { get; set; }
        public decimal? InvAmountToPayinclGst { get; set; }
        public double? Gst { get; set; }
        public int SiteNo { get; set; }
        public string ReadTypeCode { get; set; }
        public string _ { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
    }
}
