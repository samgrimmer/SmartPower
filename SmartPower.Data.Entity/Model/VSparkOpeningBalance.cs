using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSparkOpeningBalance
    {
        public int BatchNo { get; set; }
        public double? BatchTotal { get; set; }
        public DateTime? BatchMonth { get; set; }
        public decimal? SumOfInvOpeningBalance { get; set; }
    }
}
