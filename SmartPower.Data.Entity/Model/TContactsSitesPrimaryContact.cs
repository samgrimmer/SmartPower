using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TContactsSitesPrimaryContact
    {
        public int ContactSiteId { get; set; }

        public virtual TContactsSite ContactSite { get; set; }
    }
}
