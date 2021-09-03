using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvSiteNotInSite
    {
        public int SiteNo { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string AccountNo { get; set; }
        public DateTime? InvDate { get; set; }
        public decimal? InvTotal { get; set; }
    }
}
