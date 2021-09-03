using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCheckSolarRebates1Sub
    {
        public int SiteNo { get; set; }
        public int? SplitChildSite { get; set; }
        public string Status { get; set; }
        public int? SplitParentSite { get; set; }
    }
}
