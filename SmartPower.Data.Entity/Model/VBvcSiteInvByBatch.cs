using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSiteInvByBatch
    {
        public int? SiteNo { get; set; }
        public int? BatchNo { get; set; }
        public string ReadTypeCode { get; set; }
        public int? SpinvNumber { get; set; }
        public short? InvNoOfDays { get; set; }
    }
}
