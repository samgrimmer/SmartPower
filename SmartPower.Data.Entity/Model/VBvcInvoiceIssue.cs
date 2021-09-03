using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceIssue
    {
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public bool? Issue { get; set; }
        public string InvNotes { get; set; }
    }
}
