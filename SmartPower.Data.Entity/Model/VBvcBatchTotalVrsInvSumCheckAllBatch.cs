using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcBatchTotalVrsInvSumCheckAllBatch
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public decimal? CalculatedBatchTotal { get; set; }
        public double? BatchTotal { get; set; }
        public double? BatchTotalCheck { get; set; }
        public DateTime? BatchDate { get; set; }
        public string ClientCode { get; set; }
        public string InputTypeCode { get; set; }
        public DateTime? BatchMonth { get; set; }
        public double? Test { get; set; }
    }
}
