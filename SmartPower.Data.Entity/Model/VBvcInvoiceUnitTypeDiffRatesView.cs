using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceUnitTypeDiffRatesView
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int RateId { get; set; }
        public string TariffDescription { get; set; }
        public int Spil { get; set; }
        public double? UnitsUsed { get; set; }
        public string UnitType { get; set; }
        public string RatesUnitType { get; set; }
    }
}
