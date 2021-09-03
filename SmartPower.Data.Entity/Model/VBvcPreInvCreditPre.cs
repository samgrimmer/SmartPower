using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcPreInvCreditPre
    {
        public string ErrorDescription { get; set; }
        public string SiteType { get; set; }
        public int? SiteNo { get; set; }
        public int? BatchNo { get; set; }
        public int? CurrentInv { get; set; }
        public int? PrevInv { get; set; }
        public DateTime? PrevEndDate { get; set; }
        public DateTime? PrevStartDate { get; set; }
        public double? PrevInvAmtToPay { get; set; }
        public DateTime? CurrentEndDate { get; set; }
        public DateTime? CurrentStartDate { get; set; }
        public bool? CreditInv { get; set; }
        public double? InvAmountToPay { get; set; }
        public double? InvOpeningBalance { get; set; }
        public double? Difference { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
        public bool? PrevCreditInv { get; set; }
    }
}
