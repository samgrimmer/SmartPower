using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSumInvTotalsValidationTest4Sub
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public decimal? LineTotalGst { get; set; }
        public double? SumInvLineTotal { get; set; }
        public double? TaxRate { get; set; }
        public decimal? InvGst { get; set; }
        public bool Gst { get; set; }
        public double? InvLineTotal { get; set; }
    }
}
