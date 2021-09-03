using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoicesBatchlockingLogic1
    {
        public int SpinvNumber { get; set; }
        public decimal? Difference { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public int BatchNo { get; set; }
        public decimal? InvAmountToPay { get; set; }
    }
}
