using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysMatchExpectedTariff
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public short? InvNoOfDays { get; set; }
        public string Status { get; set; }
        public string RatesUnitType { get; set; }
        public int? TariffId { get; set; }
        public int? SiteNoForTariff { get; set; }
        public double SplitValue { get; set; }
        public string SplitType { get; set; }
        public int? RateId { get; set; }
        public float? Multiplier { get; set; }
        public int SiteNo { get; set; }
        public int InvoiceSpid { get; set; }
        public int? ChildSpid { get; set; }
        public int? ParentSpid { get; set; }
        public int SpidToTariff { get; set; }
        public string TariffDescription { get; set; }
    }
}
