using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryTrend
    {
        public int STrendId { get; set; }
        public int? SSiteId { get; set; }
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public decimal? STrendDollars { get; set; }
        public double? STrendConsumption { get; set; }
        public byte[] SysSummaryTrendTimestamp { get; set; }
    }
}
