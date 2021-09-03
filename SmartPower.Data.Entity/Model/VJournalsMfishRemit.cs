using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMfishRemit
    {
        public int BatchNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public decimal? InvAmountToPay { get; set; }
    }
}
