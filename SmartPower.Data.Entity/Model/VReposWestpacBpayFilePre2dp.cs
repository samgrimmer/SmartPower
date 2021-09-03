using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VReposWestpacBpayFilePre2dp
    {
        public string RetailerName { get; set; }
        public float? InvAmountToPay1 { get; set; }
        public string BpayCode { get; set; }
        public string BpayReference { get; set; }
    }
}
