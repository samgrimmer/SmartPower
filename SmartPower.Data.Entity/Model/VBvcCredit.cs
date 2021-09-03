using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCredit
    {
        public string ErrorDescription { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public bool? CreditInv { get; set; }
        public string ReadTypeCode { get; set; }
        public string InvNotes { get; set; }
    }
}
