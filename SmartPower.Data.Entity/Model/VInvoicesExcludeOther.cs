using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoicesExcludeOther
    {
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string InvNumber { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
