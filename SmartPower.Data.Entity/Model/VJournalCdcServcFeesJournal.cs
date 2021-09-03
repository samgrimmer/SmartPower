using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalCdcServcFeesJournal
    {
        public string CreditorCode { get; set; }
        public string RetailerCode { get; set; }
        public string NameAddress1 { get; set; }
        public string NameAddress2 { get; set; }
        public string NameAddress3 { get; set; }
        public string NameAddress4 { get; set; }
        public string NameAddress5 { get; set; }
        public string GstNumber { get; set; }
        public string WithholdingTax { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string PurchaseOrder { get; set; }
        public string TotalExclusiveAmount { get; set; }
        public string WithHoldingAmount { get; set; }
        public string GstAmount { get; set; }
        public string TotalInclusiveAmount { get; set; }
        public string InvoiceText { get; set; }
    }
}
