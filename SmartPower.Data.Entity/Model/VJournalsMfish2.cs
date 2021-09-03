using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMfish2
    {
        public string DocumentType { get; set; }
        public string InvoiceNumber { get; set; }
        public string CustomerReference { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DateReceived { get; set; }
        public int SupplierNumber { get; set; }
        public string DueDate { get; set; }
        public decimal? InvoiceAmountGstincl { get; set; }
        public double? InvoiceAmountGstexcl { get; set; }
        public double? InvoiceAmountGst { get; set; }
        public string Narrative { get; set; }
        public int Narrative2 { get; set; }
        public int ContractNumber { get; set; }
        public int DocId { get; set; }
        public string LineNumber { get; set; }
        public string CostCentre { get; set; }
        public string NaturalAccount { get; set; }
        public string ActivityCode { get; set; }
        public double? TotalExclLineAmount { get; set; }
        public double? TotalGstLineAmount { get; set; }
        public string GstCode { get; set; }
        public string LineNarrative1 { get; set; }
        public string LineNarrative2 { get; set; }
        public int BatchNo { get; set; }
    }
}
