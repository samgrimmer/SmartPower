using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsHealtPre
    {
        public int BatchNo { get; set; }
        public decimal? InvoiceAmountGstInc { get; set; }
        public double? InvoiceAmountGstEx { get; set; }
        public double? TotalGstForInvoice { get; set; }
    }
}
