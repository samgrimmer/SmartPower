using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvSitesListMtreportBySite
    {
        public int SiteNo { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateCeasedRestriction { get; set; }
        public string SiteStatus { get; set; }
    }
}
