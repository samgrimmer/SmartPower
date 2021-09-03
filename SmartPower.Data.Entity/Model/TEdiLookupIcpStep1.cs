using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEdiLookupIcpStep1
    {
        public int EdiLIcpId { get; set; }
        public string EdiLUserName { get; set; }
        public int? EdiLBatchNo { get; set; }
        public string EdiLIcp { get; set; }
        public string EdiLAccountNo { get; set; }
        public int? EdiLCountSiteNoIcp { get; set; }
        public string EdiLRetailerCode { get; set; }
    }
}
