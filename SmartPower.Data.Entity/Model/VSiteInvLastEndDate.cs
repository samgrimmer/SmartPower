using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSiteInvLastEndDate
    {
        public int SiteNo { get; set; }
        public DateTime? LastInvEndDate { get; set; }
        public DateTime? LastInvDate { get; set; }
    }
}
