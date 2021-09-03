using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoicesArchivedOld
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
        public double? InvOpeningBalance { get; set; }
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
        public double? InvSubTotal { get; set; }
        public double? InvTotal { get; set; }
        public double? InvGst { get; set; }
        public double? InvDiscount { get; set; }
        public double? InvAmount { get; set; }
        public double? InvAmountToPay { get; set; }
        public double? InvAmountCalc { get; set; }
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
        public int? UnitTotal { get; set; }
        public int? OrgId { get; set; }
        public byte[] SysInvoicesArchivedTimestamp { get; set; }
        public bool? Issue { get; set; }
        public double? GstFreeCharges { get; set; }
        public double? EdiId { get; set; }
        public string ParentAccNum { get; set; }
        public double? OpeningBalanceExGst { get; set; }
        public double? OpeningBalanceGst { get; set; }
        public double? InvDiscountExGst { get; set; }
        public double? InvDiscountGst { get; set; }
        public double? InvAmountExGst { get; set; }
        public double? InvAmountGst { get; set; }
        public double? InvAmountToPayExGst { get; set; }
        public double? InvAmountToPayGst { get; set; }
        public int? ParentSpin { get; set; }
        public double? Split { get; set; }
    }
}
