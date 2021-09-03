using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEdiLookupIcp1
    {
        public int EdiIcpId { get; set; }
        public string EdiUserName { get; set; }
        public int? EdiBatchNo { get; set; }
        public string EdiIcp { get; set; }
        public string EdiAccountNo { get; set; }
        public int? EdiCountSiteNoIcp { get; set; }
    }
}
