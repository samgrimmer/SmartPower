using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcNegNoOfDaysNonReversal
    {
        public string ErrorDescription { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public double? UnitTotal { get; set; }
    }
}
