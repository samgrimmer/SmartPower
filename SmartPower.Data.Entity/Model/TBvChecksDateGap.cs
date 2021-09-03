using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvChecksDateGap
    {
        public int DgId { get; set; }
        public int? DgSiteNo { get; set; }
        public int? DgSpinvNumber { get; set; }
        public int? DgBatchNo { get; set; }
        public DateTime? DgInvStartDate { get; set; }
        public DateTime? DgInvEndDate { get; set; }
        public DateTime? DgNextStart { get; set; }
        public DateTime? DgLastEnd { get; set; }
        public int? DgLastSiteNo { get; set; }
        public int? DgLastInvoice { get; set; }
        public int? DgDateGap { get; set; }
        public int? DgNextInvoice { get; set; }
        public byte[] SysDateGapsTimestamp { get; set; }
        public int? DgNextBachNo { get; set; }
        public DateTime? DgNextEnd { get; set; }
        public string DgSiteType { get; set; }
    }
}
