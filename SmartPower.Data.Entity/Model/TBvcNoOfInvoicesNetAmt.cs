using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvcNoOfInvoicesNetAmt
    {
        public int InvId { get; set; }
        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public int? NoOfInvoices { get; set; }
        public decimal? SumOfInvAmountToPay { get; set; }
        public double? Kwh { get; set; }
        public DateTime? EarliestDueDate { get; set; }
        public decimal? Ppdvalue { get; set; }
        public decimal? SumInvLinesTotalGstFree { get; set; }
        public decimal? SumInvAmountToPayExGst { get; set; }
        public decimal? SumInvAmountToPayGst { get; set; }
    }
}
