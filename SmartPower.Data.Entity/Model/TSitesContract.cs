using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSitesContract
    {
        public int? SiteNo { get; set; }
        public int? ContractId { get; set; }
        public int SiteContractId { get; set; }

        public virtual TSite SiteNoNavigation { get; set; }
    }
}
