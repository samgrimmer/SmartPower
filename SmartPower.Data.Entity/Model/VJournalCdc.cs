using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalCdc
    {
        public string CreditorCode { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int BatchNo { get; set; }
        public double? TotalExclusiveAmount { get; set; }
        public double? GstAmount { get; set; }
        public decimal? TotalInclusiveAmount { get; set; }
        public decimal? AmountPerAllocation { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string NameAddress1 { get; set; }
        public string NameAddress2 { get; set; }
        public string NameAddress3 { get; set; }
        public string NameAddress4 { get; set; }
        public string NameAddress5 { get; set; }
        public string GstNumber { get; set; }
        public string WithholdingTax { get; set; }
        public string PurchaseOrder { get; set; }
        public int? JobCostNumber { get; set; }
        public int? GeneralLedgerNumber { get; set; }
        public string WithHoldingAmount { get; set; }
        public int Quantity { get; set; }
        public string AllocationUser { get; set; }
        public string AllocationDepartment { get; set; }
        public string GstType { get; set; }
        public string JobCostNumber2 { get; set; }
        public string GeneralLedgerNumber2 { get; set; }
        public string AmountPerAllocation2 { get; set; }
        public string Quantity2 { get; set; }
        public string AllocationUser2 { get; set; }
        public string AllocationDepartment2 { get; set; }
        public string GstType2 { get; set; }
        public string JobCostNumber3 { get; set; }
        public string GeneralLedgerNumber3 { get; set; }
        public string AmountPerAllocation3 { get; set; }
        public string Quantity3 { get; set; }
        public string AllocationUser3 { get; set; }
        public string AllocationDepartment3 { get; set; }
        public string GstType3 { get; set; }
    }
}
