using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Application.Entity.Model
{
    public partial class TInvoice
    {
        public int SpinvNumber { get; set; }
        public int? SpinvNumberOrig { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public string InvNumber { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public string InvOpenBalType { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? CostsUsage { get; set; }
        public double? CostsFees { get; set; }
        public double? CostsNetwork { get; set; }
        public double? SpotRate { get; set; }
        public double? Losses { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public double? InvAmountSoa { get; set; }
        public bool? CreditInv { get; set; }
        public string InvNotes { get; set; }
        public double? NtwkVariable { get; set; }
        public double? NtwkFixed { get; set; }
        public double? FixedKva { get; set; }
        public float? NoOfStaff { get; set; }
        public double? SqMetresOccupied { get; set; }
        public double? SqMetresTotal { get; set; }
        public double? AcadjFactor { get; set; }
        public int? InvNoPayfile { get; set; }
        public string Obnotes { get; set; }
        public string StatementNumber { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public double? UnitTotal { get; set; }
        public int? OrgId { get; set; }
        public bool? InvArchived { get; set; }
        public bool? InvLinesArchived { get; set; }
        public byte[] SysInvoicesTimestamp { get; set; }
        public bool? Issue { get; set; }
        public double? GstFreeCharges { get; set; }
        public double? EdiId { get; set; }
        public string ParentAccNum { get; set; }
        public decimal? OpeningBalanceExGst { get; set; }
        public decimal? OpeningBalanceGst { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? InvAmountExGst { get; set; }
        public decimal? InvAmountGst { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public string ClientCode { get; set; }
        public bool Recharge { get; set; }
        public int? ParentSpin { get; set; }
        public double? Split { get; set; }
        public decimal? PdfInvAmountToPay { get; set; }
        public bool? ObGstFree { get; set; }
        public bool? PpdGstFree { get; set; }
        public bool? PpdIgnoreSiteDiscount { get; set; }
        public bool? ObGst { get; set; }
        public bool? PpdGst { get; set; }
        public bool? ApplySitePpd { get; set; }
    }
}
