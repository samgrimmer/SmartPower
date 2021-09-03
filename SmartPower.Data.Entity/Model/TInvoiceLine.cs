using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceLine
    {
        public int InvLineNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int? SpinvNumberOrig { get; set; }
        public string Description { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitsUsedCheck { get; set; }
        public double? UnitCost { get; set; }
        public float? Multiplier { get; set; }
        public double? InvLineTotal { get; set; }
        public string ProductId { get; set; }
        public string UnitType { get; set; }
        public int RateId { get; set; }
        public string PriceType { get; set; }
        public bool? Metered { get; set; }
        public int? TariffId { get; set; }
        public string UtilityCode { get; set; }
        public int? CostCentreId { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int? Gstrate { get; set; }
        public byte[] SysInvoiceLinesTimestamp { get; set; }
        public double? EdiId { get; set; }
        public string LinesReference { get; set; }
        public bool? Ppd { get; set; }
        public bool? Gst { get; set; }
        public double? UnitMultiplier { get; set; }
        public double? InvLineTotalInclGst { get; set; }
        public double? InvLineTotalGst { get; set; }
    }
}
