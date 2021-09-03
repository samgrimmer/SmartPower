using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckPpd
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvDiscount { get; set; }
        public double? CalculatedPpd { get; set; }
        public float? InvoicedPpd { get; set; }
        public double? Difference { get; set; }
    }
}
