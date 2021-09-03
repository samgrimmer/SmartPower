using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSplitInvoicesResult
    {
        public int NewInvoice { get; set; }
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public string AccountNo { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public short? InvNoOfDays { get; set; }
    }
}
