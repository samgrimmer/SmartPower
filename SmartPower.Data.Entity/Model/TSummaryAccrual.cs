using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryAccrual
    {
        public int SAccrualsId { get; set; }
        public int? SSiteId { get; set; }
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public decimal? SAccrualDollars { get; set; }
        public double? SAccrualConsumption { get; set; }
        public byte[] SysSummaryAccrualsTimestamp { get; set; }
    }
}
