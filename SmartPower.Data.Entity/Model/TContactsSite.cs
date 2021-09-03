using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TContactsSite
    {
        public int ContactSiteId { get; set; }
        public int? ContactId { get; set; }
        public int? SiteNo { get; set; }
        public string Status { get; set; }

        public virtual TContact Contact { get; set; }
        public virtual TSite SiteNoNavigation { get; set; }
        public virtual TContactsSitesPrimaryContact TContactsSitesPrimaryContact { get; set; }
    }
}
