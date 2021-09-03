using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoiceHistoryMain
    {
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public int BatchNo { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string ClientRef { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string InvNotes { get; set; }
        public double? CalcTotalUnits { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string InvNumber { get; set; }
        public bool? InvArchived { get; set; }
        public bool? ReadyForUpload { get; set; }
        public short? InvNoOfDays { get; set; }
        public string InvOpenBalType { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public bool? CreditInv { get; set; }
        public bool Recharge { get; set; }
        public string Entity { get; set; }
        public string ClientCode { get; set; }
    }
}
