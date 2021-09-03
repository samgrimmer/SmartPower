using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupIcp
    {
        public int BatchNo { get; set; }
        public string EdiIcp { get; set; }
        public int? IcpCount { get; set; }
        public string EdiInvNumber { get; set; }
    }
}
