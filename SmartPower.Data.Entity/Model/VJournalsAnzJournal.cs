using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsAnzJournal
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string TaxExpl { get; set; }
        public string TaxRateArea { get; set; }
        public double? InvoiceLineAmountExclGst { get; set; }
        public double? InvoiceLineGst { get; set; }
        public decimal? InvoiceLineAmountInclGst { get; set; }
        public string Explanation { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public DateTime? InvDueDate { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public string InvNumber { get; set; }
        public double? InvoicedKwh { get; set; }
        public string Entity { get; set; }
        public decimal? Ppd { get; set; }
        public string Dvn { get; set; }
        public DateTime? InvDate { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string ClientCode { get; set; }
    }
}
