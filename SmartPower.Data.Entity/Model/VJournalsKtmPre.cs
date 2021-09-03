using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsKtmPre
    {
        public int BatchNumber { get; set; }
        public int SpInvNumber { get; set; }
        public DateTime? InvDate { get; set; }
        public decimal? InvTotalInclGst { get; set; }
        public decimal? NetInclGst { get; set; }
        public double? Gst { get; set; }
    }
}
