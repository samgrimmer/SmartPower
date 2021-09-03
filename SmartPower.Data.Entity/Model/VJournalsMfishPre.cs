using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMfishPre
    {
        public double? GstExclusive { get; set; }
        public decimal? GstInclusive { get; set; }
        public double? Gst { get; set; }
        public int? CountInvoices { get; set; }
        public int BatchNo { get; set; }
    }
}
