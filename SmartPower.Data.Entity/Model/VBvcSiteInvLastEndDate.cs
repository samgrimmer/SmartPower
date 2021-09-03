using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSiteInvLastEndDate
    {
        public int SiteNo { get; set; }
        public DateTime? LastInvEndDate { get; set; }
        public DateTime? LastInvDate { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string ReadTypeCode { get; set; }
        public short? InvNoOfDays { get; set; }
    }
}
