using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TempInvoice
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
        public bool? InvArchived { get; set; }
        public bool? InvLinesArchived { get; set; }
        public byte[] SysInvoicesTimestamp { get; set; }
    }
}
