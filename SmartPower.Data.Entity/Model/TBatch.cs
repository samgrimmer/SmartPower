using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBatch
    {
        public int BatchNo { get; set; }
        public int? OrigBatchNo { get; set; }
        public DateTime? BatchDate { get; set; }
        public double? BatchTotal { get; set; }
        public string ClientCode { get; set; }
        public string InputTypeCode { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string BatchMonthDesc { get; set; }
        public string BatchMonthDraft { get; set; }
        public string BatchInvoice { get; set; }
        public bool? Archived { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public bool? ReadyForUpload { get; set; }
        public string ClientCodeSp { get; set; }
        public int? OrgId { get; set; }
        public byte[] SysBatchesTimestamp { get; set; }
        public bool? Verified { get; set; }
        public bool? Paid { get; set; }
        public string DataType { get; set; }
        public bool? IgnoreSiteDiscountPc { get; set; }

        public virtual TClient ClientCodeNavigation { get; set; }
    }
}
