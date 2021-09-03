using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TTariffsLookupCreateRate
    {
        public int TariffsEdiId { get; set; }
        public int? SiteNo { get; set; }
        public string Description { get; set; }
        public int? RateId { get; set; }
        public string SupplierTariffCode { get; set; }
        public double? UnitCost { get; set; }
        public float? Multiplier { get; set; }
        public string UnitType { get; set; }
        public DateTime? DateCreated { get; set; }
        public string InvoiceType { get; set; }
        public string TariffsUnitMultiplierType { get; set; }
        public double? TariffsUnitMultiplier { get; set; }
        public double? InvoiceLinesUnitMultiplier { get; set; }
        public double? NoOfDays { get; set; }
        public double? LinesUnitCost { get; set; }
        public bool? Ppd { get; set; }
        public bool? Gst { get; set; }
        public string Status { get; set; }
    }
}
