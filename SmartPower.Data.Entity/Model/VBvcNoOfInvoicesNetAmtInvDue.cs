using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcNoOfInvoicesNetAmtInvDue
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
    }
}
