using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcDisabledRateOrTariffUsed
    {
        public int Spid { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public int Spil { get; set; }
        public string Description { get; set; }
        public int RateId { get; set; }
        public string TRatesStatus { get; set; }
        public int? TariffId { get; set; }
        public string TTariffsStatus { get; set; }
        public string ErrorDescription { get; set; }
    }
}
