using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsDccPayfile
    {
        public string InvoiceNumber { get; set; }
        public string SupplierNumber { get; set; }
        public string Company { get; set; }
        public decimal? GrossAmount { get; set; }
        public string BussinessUnit { get; set; }
        public string ObjectCode { get; set; }
        public double? NettAmount { get; set; }
        public string Narration { get; set; }
        public string Approver { get; set; }
        public string TaxExplanationCode { get; set; }
        public string SiteAddress { get; set; }
    }
}
