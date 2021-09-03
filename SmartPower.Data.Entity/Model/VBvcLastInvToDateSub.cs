using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcLastInvToDateSub
    {
        public DateTime? MaxInvStartDate { get; set; }
        public DateTime? MaxInvEndDate { get; set; }
        public int SiteNo { get; set; }
    }
}
