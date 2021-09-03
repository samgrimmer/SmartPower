using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSplitParentAmountToPayTest
    {
        public int SpinvNumber { get; set; }
        public int? SplitParentSite { get; set; }
        public int BatchNo { get; set; }
        public int? NewInvoice { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
    }
}
