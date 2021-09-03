using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvCheckLineTotalsFromTariff
    {
        public int LtId { get; set; }
        public int? LtSiteNo { get; set; }
        public int? LtBatchNo { get; set; }
        public int? LtSpinvNumber { get; set; }
        public int? LtRateId { get; set; }
        public int? LtTariffId { get; set; }
        public int? LtInvLineNo { get; set; }
        public string LtTariffDescription { get; set; }
        public double? LtTariffValue { get; set; }
        public double? LtLineValue { get; set; }
        public double? LtCalculated { get; set; }
        public double? LtInvLineTotal { get; set; }
        public double? LtDifference { get; set; }
        public double? LtCalcResults { get; set; }
        public byte[] SysLineTotalsTimestamp { get; set; }
    }
}
