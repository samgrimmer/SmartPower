using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvChecksReadingGap
    {
        public int RgId { get; set; }
        public int? RgSiteNo { get; set; }
        public int? RgSpinvNumber { get; set; }
        public int? RgBatchNo { get; set; }
        public double? RgInvReadStart { get; set; }
        public double? RgInvReadEnd { get; set; }
        public double? RgInvReadNextStart { get; set; }
        public double? RgInvReadLastEnd { get; set; }
        public int? RgLastSiteNo { get; set; }
        public int? RgLastInvoice { get; set; }
        public int? RgReadGap { get; set; }
        public int? RgNextInvoice { get; set; }
        public int? RgPrevInvoice { get; set; }
        public byte[] SysReadingGapsTimestamp { get; set; }
    }
}
