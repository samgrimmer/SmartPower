using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TTempEstimateCount
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string InvNotes { get; set; }
        public int SiteNo { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string ReadType { get; set; }
        public int ActualCount { get; set; }
        public long? RowNumber { get; set; }
    }
}
