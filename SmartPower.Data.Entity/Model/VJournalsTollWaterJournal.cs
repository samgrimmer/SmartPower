using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsTollWaterJournal
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? DateOfInvoice { get; set; }
        public string SupplierRef { get; set; }
        public string ClientRef { get; set; }
        public string SiteDescription { get; set; }
        public string AccountNumber { get; set; }
        public string Icp { get; set; }
        public string Lease { get; set; }
        public string Oncharge { get; set; }
        public string ClientCc { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public double? CostsFees { get; set; }
        public double? InvoicedKL { get; set; }
        public decimal? InvAmountToPayInclGst { get; set; }
        public double? InvoiceAmountToPayExclGst { get; set; }
        public double? Gst { get; set; }
    }
}
