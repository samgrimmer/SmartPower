using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TCostCentre
    {
        public string ClientCode { get; set; }
        public string CostCentre { get; set; }
        public string Ccdescription { get; set; }
        public string ClientCodeSp { get; set; }
        public byte[] SysTimestamp { get; set; }

        public virtual TClient ClientCodeNavigation { get; set; }
    }
}
