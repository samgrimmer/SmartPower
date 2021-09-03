using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsHealtJournal
    {
        public int SupplierNumber { get; set; }
        public string SupplierSite { get; set; }
        public string DocumentType { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? InvoiceAmountGstInc { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double? TotalGstForInvoice { get; set; }
        public string RemittanceDescription { get; set; }
        public string LineNumber { get; set; }
        public int Company { get; set; }
        public string CostCentre { get; set; }
        public int ProjectCode { get; set; }
        public int ObjectCode { get; set; }
        public string PoNumber { get; set; }
        public string PoLineNumber { get; set; }
        public string DistributionSet { get; set; }
        public string Destination { get; set; }
        public double? TotalPreGst { get; set; }
        public string GstCode { get; set; }
        public string AccountNo { get; set; }
        public int SpinvNumber { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string RetailerCode { get; set; }
        public DateTime? InvDueDate { get; set; }
        public DateTime? InvDate { get; set; }
    }
}
