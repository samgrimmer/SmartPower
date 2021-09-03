using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalCdcGstexemptSummary
    {
        public decimal? TotalExclusiveAmount { get; set; }
        public int? GstAmount { get; set; }
        public decimal? TotalInclusiveAmount { get; set; }
    }
}
