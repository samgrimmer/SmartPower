using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupIcpByEdiid
    {
        public int? EdiId { get; set; }
        public string EdiInvNumber { get; set; }
        public string EdiIcp { get; set; }
    }
}
