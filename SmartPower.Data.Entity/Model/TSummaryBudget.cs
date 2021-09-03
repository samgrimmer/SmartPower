using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryBudget
    {
        public int SDataId { get; set; }
        public int? SSiteId { get; set; }
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public decimal? SBudgetDollar { get; set; }
        public double? SBudgetConsumption { get; set; }
        public byte[] SysSummaryBudgetTimestamp { get; set; }
    }
}
