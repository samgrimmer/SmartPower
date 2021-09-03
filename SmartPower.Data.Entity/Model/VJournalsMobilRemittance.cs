using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMobilRemittance
    {
        public string Icp { get; set; }
        public string AccountNo { get; set; }
        public decimal? InvAmountToPay { get; set; }
    }
}
