using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSplitChildAmountToPayTestSum
    {
        public int SpinvNumber { get; set; }
        public int? SplitParentSite { get; set; }
        public int BatchNo { get; set; }
        public decimal? SumInvAmountToPay { get; set; }
        public decimal? SumInvAmountToPayExGst { get; set; }
        public decimal? SumInvAmountToPayGst { get; set; }
    }
}
