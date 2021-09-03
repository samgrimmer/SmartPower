using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEdiHeader
    {
        public int SpinvNumberOrig { get; set; }
        public int? BatchNo { get; set; }
        public int? SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string ReadTypeCode { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvDateSql { get; set; }
        public DateTime? InvEnteredDateSql { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public string InvOpenBalType { get; set; }
        public DateTime? InvStartDateSql { get; set; }
        public DateTime? InvEndDateSql { get; set; }
        public DateTime? InvDueDateSql { get; set; }
        public short? InvNoOfDays { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? InvAmountCalc { get; set; }
        public decimal? InvAmountSoa { get; set; }
        public bool? CreditInv { get; set; }
        public string InvNotes { get; set; }
        public double? TotalConsumption { get; set; }
    }
}
