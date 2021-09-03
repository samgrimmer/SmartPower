using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsSanfJournal
    {
        public string Combined { get; set; }
        public string GlAccount { get; set; }
        public string Division { get; set; }
        public string CostCentre { get; set; }
        public double? Kwh { get; set; }
        public double? ExclGst { get; set; }
        public double? SumOfGst { get; set; }
        public decimal? Total { get; set; }
    }
}
