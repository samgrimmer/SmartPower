using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvcNoOfInvoicesNetAmtDueDate
    {
        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public DateTime? InvDueDate { get; set; }
        public int? CountOfNoOfInvoices { get; set; }
        public decimal? SumOfInvAmtToPay { get; set; }
        public double? SumOfKwh { get; set; }
        public decimal? SumOfPpdValue { get; set; }
        public string AccountNo { get; set; }
        public string InvNumber { get; set; }
        public decimal? SumInvLinesTotalGstFree { get; set; }
        public decimal? SumInvAmountToPayExGst { get; set; }
        public decimal? SumInvAmountToPayGst { get; set; }
    }
}
