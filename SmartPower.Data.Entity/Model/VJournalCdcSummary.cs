using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalCdcSummary
    {
        public double? TotalExclusiveAmount { get; set; }
        public double? GstAmount { get; set; }
        public decimal? TotalInclusiveAmount { get; set; }
    }
}
