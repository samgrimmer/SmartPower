using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcRepBatchSub
    {
        public string RetailerName { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string AccNo { get; set; }
        public string ReadType { get; set; }
        public string Icp { get; set; }
        public string MeterType { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public decimal? OpeningBal { get; set; }
        public decimal? Discount { get; set; }
        public string Region2 { get; set; }
        public string BankAccount { get; set; }
        public string ContactEmail { get; set; }
        public decimal? Ppdvalue { get; set; }
        public string Particulars { get; set; }
        public string RetailerRef { get; set; }
        public string AccountNo { get; set; }
        public int? CountOfNoOfInvoices { get; set; }
        public decimal? SumOfInvAmountToPay { get; set; }
        public double? SumOfKwh { get; set; }
        public DateTime? EarliestDueDate { get; set; }
        public string InvNumber { get; set; }
        public decimal? SumInvAmountToPayExGst { get; set; }
        public decimal? SumInvAmountToPayGst { get; set; }
        public decimal? SumInvLinesTotalGstFree { get; set; }
    }
}
