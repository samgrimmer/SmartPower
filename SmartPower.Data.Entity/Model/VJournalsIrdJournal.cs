using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsIrdJournal
    {
        public string V { get; set; }
        public int _2096578 { get; set; }
        public string CostCentre { get; set; }
        public string BuildingNo { get; set; }
        public double? InvAmountToPayExGst { get; set; }
        public string InvoiceLineDescription { get; set; }
        public string TaxCode { get; set; }
        public string AllocationText { get; set; }
        public double? InvoiceKwh { get; set; }
        public string RetailerCode { get; set; }
        public decimal? InvAmountToPay { get; set; }
    }
}
