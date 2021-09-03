using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvChecksLastInvoiceEstimate
    {
        public int LiId { get; set; }
        public int? LiSiteNo { get; set; }
        public int? LiSpInvoiceNo { get; set; }
        public string LiReadTypeCode { get; set; }
        public string LiInvEndDate { get; set; }
        public bool? LiEstimate { get; set; }
        public byte[] SysLastInvoiceTimestamp { get; set; }
    }
}
