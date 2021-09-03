using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VReposWestpacBpayFileCheck
    {
        public string RetailerName { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string BpayCode { get; set; }
        public string BpayReference { get; set; }
    }
}
