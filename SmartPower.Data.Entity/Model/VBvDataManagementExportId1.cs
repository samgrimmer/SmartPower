using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvDataManagementExportId1
    {
        public int SpinvNumber { get; set; }
        public int InvOpeningBalance { get; set; }
        public double? OpeningBalanceGst { get; set; }
        public int OpeningBalanceExGst { get; set; }
        public double? InvAmountToPayExGst { get; set; }
        public double? InvAmountToPayGst { get; set; }
        public double? InvAmtToPay { get; set; }
    }
}
