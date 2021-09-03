using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TDuplicateInvoice
    {
        public int DupId { get; set; }
        public int? SpinvNumber { get; set; }
        public int? BatchNo { get; set; }
        public int? SiteNo { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string InvNumber { get; set; }
        public string ReadTypeCode { get; set; }
        public double? InvSubTotal { get; set; }
        public double? InvTotal { get; set; }
        public double? InvGst { get; set; }
        public double? InvDiscount { get; set; }
        public double? InvAmount { get; set; }
        public double? InvAmountToPay { get; set; }
        public string InvNotes { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public double? InvOpeningBalance { get; set; }
        public bool? CreditInv { get; set; }
    }
}
