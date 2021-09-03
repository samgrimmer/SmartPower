using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportLine
    {
        public int? HeaderId { get; set; }
        public string ConsumerNo { get; set; }
        public int InvLineNo { get; set; }
        public string InvNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int? SpinvNumberOrig { get; set; }
        public string Description { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitsUsedCheck { get; set; }
        public double? UnitCost { get; set; }
        public float? Multiplier { get; set; }
        public decimal? InvLineTotal { get; set; }
        public string ProductId { get; set; }
        public string UnitType { get; set; }
        public int? RateId { get; set; }
        public string PriceType { get; set; }
        public short? RegisterNo { get; set; }
        public bool? Metered { get; set; }
        public int? TariffId { get; set; }
        public string ChargeLineId { get; set; }
        public string ChargeLineType { get; set; }
        public int? SiteId { get; set; }
        public string MeterNo { get; set; }
        public string Icp { get; set; }
        public string NetworkId { get; set; }
        public string ChargeLineDesc { get; set; }
        public string ReadType { get; set; }
        public string LineType { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? HighlightRecord { get; set; }
        public string UtilityCode { get; set; }
        public int? CostCentreId { get; set; }
        public bool? Exclude { get; set; }
        public string RateDescription { get; set; }
        public string RateCategory { get; set; }
        public int? RateClass { get; set; }
        public byte[] SysImportLinesTimestamp { get; set; }
    }
}
