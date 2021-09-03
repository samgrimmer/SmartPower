using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcPayeeDueDatePre2dp
    {
        public string Payee { get; set; }
        public decimal? ExGstAmountGstApplicableCharges { get; set; }
        public decimal? GstFreeCharges { get; set; }
        public decimal? GstAmount { get; set; }
        public decimal? InclGstAmount { get; set; }
        public double? KWh { get; set; }
        public int? InvoiceCount { get; set; }
        public decimal? Ppdvalue { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public string BankAccount { get; set; }
        public string Contactemail { get; set; }
        public string Particulars { get; set; }
        public string RetailerRef { get; set; }
        public string AnalysisCode { get; set; }
        public string Reference { get; set; }
    }
}
