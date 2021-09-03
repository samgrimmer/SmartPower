using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckMeterReadFinal
    {
        public string SiteType { get; set; }
        public int SiteNo { get; set; }
        public int SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public double? CurrReading { get; set; }
        public double? UnitsUsed { get; set; }
        public int BatchNo { get; set; }
        public double? ReadingUnits { get; set; }
        public double? Diff { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public string UnitType { get; set; }
        public double? PrevReading { get; set; }
        public string TariffDescription { get; set; }
        public float? Multiplier { get; set; }
        public string SiteTypeSubCat { get; set; }
    }
}
