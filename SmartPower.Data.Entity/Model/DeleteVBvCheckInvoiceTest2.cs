using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoiceTest2
    {
        public double? GstValue { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvSubTotal { get; set; }
        public bool? CurrentTaxRate { get; set; }
        public double? CalcGst { get; set; }
        public decimal? RInvGst { get; set; }
        public double? Test2Gst { get; set; }
    }
}
