using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSiteInvLastStartDate
    {
        public int SiteNo { get; set; }
        public DateTime? LastInvStartDate { get; set; }
    }
}
