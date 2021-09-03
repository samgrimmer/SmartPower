using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcEarliestDueDate
    {
        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public int NoOfInvoices { get; set; }
        public decimal? InvAmtToPay { get; set; }
        public bool? CreditInv { get; set; }
        public double? Kwh { get; set; }
        public decimal? Ppd { get; set; }
        public DateTime? InvDueDate { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public double? SumInvLinesTotalGstFree { get; set; }
    }
}
