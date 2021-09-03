using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcEstimatesAllPre
    {
        public int LiId { get; set; }
        public int? LiSiteNo { get; set; }
        public int? LiSpInvoiceNo { get; set; }
        public string LiReadTypeCode { get; set; }
        public DateTime? InvEndDate { get; set; }
        public bool? LiEstimate { get; set; }
    }
}
