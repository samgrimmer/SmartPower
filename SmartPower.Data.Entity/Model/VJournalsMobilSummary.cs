using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMobilSummary
    {
        public string Title { get; set; }
        public string ProducedBy { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string EmCompanyName { get; set; }
        public string Vendor { get; set; }
        public string VendorName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public string Currency { get; set; }
        public string BankAccount { get; set; }
        public string Key { get; set; }
        public string Data { get; set; }
    }
}
