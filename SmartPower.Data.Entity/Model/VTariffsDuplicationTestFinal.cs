using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VTariffsDuplicationTestFinal
    {
        public string ClientCode { get; set; }
        public int TariffId { get; set; }
        public int SiteNo { get; set; }
        public int RateId { get; set; }
        public string TariffDescription { get; set; }
        public string Status { get; set; }
        public string MeterNo { get; set; }
        public string SupplierTariffCode { get; set; }
        public double? UnitCost { get; set; }
        public float? Multiplier { get; set; }
        public string Comments { get; set; }
        public short? TariffSort { get; set; }
        public bool? RateOverride { get; set; }
        public DateTime? DateCreated { get; set; }
        public string InvoiceType { get; set; }
        public int? Gstrate { get; set; }
        public bool? CurrentTariff { get; set; }
        public int? OrgId { get; set; }
        public bool Ppd { get; set; }
        public bool Gst { get; set; }
        public string UnitMultiplierType { get; set; }
        public double? UnitMultiplier { get; set; }
        public double? MaxDailyConsumption { get; set; }
    }
}
