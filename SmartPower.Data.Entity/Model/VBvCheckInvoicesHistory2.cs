using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckInvoicesHistory2
    {
        public int Spid { get; set; }
        public string Icp { get; set; }
        public string Entity { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string ClientRef { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public int BatchNo { get; set; }
        public DateTime? BatchMonth { get; set; }
        public int Spin { get; set; }
        public string SupplierInvNo { get; set; }
        public bool? Locked { get; set; }
        public bool? InvArchived { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? Days { get; set; }
        public string ReadTypeCode { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitsDay { get; set; }
        public decimal? Ob { get; set; }
        public string ObType { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvSubTotalInclGst { get; set; }
        public decimal? DiscountInclGst { get; set; }
        public decimal? InvAmountInclGst { get; set; }
        public decimal? InvoiceAmountToPayInclGst { get; set; }
        public decimal? InvoiceAmountToPayExGst { get; set; }
        public decimal? InvoiceAmountToPayGst { get; set; }
        public string Notes { get; set; }
        public bool? ZeroDollars { get; set; }
        public bool Recharge { get; set; }
    }
}
