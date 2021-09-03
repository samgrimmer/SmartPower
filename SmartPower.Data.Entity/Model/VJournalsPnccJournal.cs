using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsPnccJournal
    {
        public string JobNumber { get; set; }
        public string GlCode { get; set; }
        public double? InvAmountToPayExGst { get; set; }
        public string Description { get; set; }
        public int BatchNo { get; set; }
        public string SiteStatus { get; set; }
        public string Month { get; set; }
        public int SiteNo { get; set; }
        public int SpinvNumber { get; set; }
    }
}
