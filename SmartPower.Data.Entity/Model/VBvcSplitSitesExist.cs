using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSplitSitesExist
    {
        public int SplitId { get; set; }
        public int? SplitParentSite { get; set; }
        public string ChildSiteAccount { get; set; }
        public int? SiteNo { get; set; }
    }
}
