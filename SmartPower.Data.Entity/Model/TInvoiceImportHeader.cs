using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportHeader
    {
        public int? HeaderId { get; set; }
        public int? SpinvNumber { get; set; }
        public int SpinvNumberOrig { get; set; }
        public int? BatchNo { get; set; }
        public int? SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string ReadTypeCode { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public string InvOpenBalType { get; set; }
        public decimal? Reversals { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public decimal? CostsUsage { get; set; }
        public decimal? CostsFees { get; set; }
        public decimal? CostsNetwork { get; set; }
        public decimal? SpotRate { get; set; }
        public double? Losses { get; set; }
        public decimal? OtherTransactions { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public int? InvDiscountPercent { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? InvAmountCalc { get; set; }
        public decimal? InvAmountSoa { get; set; }
        public bool? CreditInv { get; set; }
        public string InvNotes { get; set; }
        public double? NtwkVariable { get; set; }
        public double? NtwkFixed { get; set; }
        public double? FixedKva { get; set; }
        public float? NoOfStaff { get; set; }
        public double? SqMetresOccupied { get; set; }
        public double? SqMetresTotal { get; set; }
        public double? AcadjFactor { get; set; }
        public string SiteDesciption { get; set; }
        public string Icp { get; set; }
        public bool? Warning { get; set; }
        public string BillType { get; set; }
        public bool? HighlightRecord { get; set; }
        public bool? InvoiceChanged { get; set; }
        public string MeterNo { get; set; }
        public string RegisterNo { get; set; }
        public string Gxp { get; set; }
        public double? TotalConsumption { get; set; }
        public string NetwrokId { get; set; }
        public string TaxClass { get; set; }
        public byte[] SysImportHeadersTimestamp { get; set; }
    }
}
