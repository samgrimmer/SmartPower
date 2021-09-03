using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryDatumDatum
    {
        public int SDatumId { get; set; }
        public int? SSiteId { get; set; }
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public decimal? SDatumDollar { get; set; }
        public double? SDatumConsumption { get; set; }
        public string SUnitType { get; set; }
        public byte[] SysTimestamp { get; set; }
    }
}
