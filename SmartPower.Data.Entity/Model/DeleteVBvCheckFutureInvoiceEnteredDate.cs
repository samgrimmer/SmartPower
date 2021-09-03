using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckFutureInvoiceEnteredDate
    {
        public int SpinvNumber { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public DateTime? TodaysDate { get; set; }
        public string ErrorDescription { get; set; }
    }
}
