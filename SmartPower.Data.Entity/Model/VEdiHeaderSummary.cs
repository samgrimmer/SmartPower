using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEdiHeaderSummary
    {
        public int? HeaderId { get; set; }
        public decimal? OpeningBalGst { get; set; }
        public decimal? OpeningBalExGst { get; set; }
        public decimal? CurrentChargesGst { get; set; }
        public decimal? CurrentChargesExGst { get; set; }
        public decimal? ReversalsGst { get; set; }
        public decimal? ReversalsExGst { get; set; }
        public decimal? OtherTransactionsGst { get; set; }
        public decimal? OtherTransactionsExGst { get; set; }
        public decimal? PromptPatmentDiscountGst { get; set; }
        public decimal? PromptPatmentDiscountExGst { get; set; }
        public decimal? TotalAmountDueGst { get; set; }
        public decimal? TotalAmountDueExGst { get; set; }
        public decimal? DiscountedAmountDueGst { get; set; }
        public decimal? DiscountedAmountDueExGst { get; set; }
        public double? TotalConsumption { get; set; }
    }
}
