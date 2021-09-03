using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VImwcDatamanagementZeroObAndUpdateAmounttopay
    {
        public int SpinvNumber { get; set; }
        public int InvOpeningBalance { get; set; }
        public double? OpeningBalanceGst { get; set; }
        public int OpeningBalanceExGst { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public decimal? InvAmtToPay { get; set; }
    }
}
