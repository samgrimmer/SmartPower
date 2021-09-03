using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcRateTariffMismatch
    {
        public string ErrorDescription { get; set; }
        public string SiteType { get; set; }
        public int SpinvNumber { get; set; }
        public int InvoiceSpid { get; set; }
        public int TariffSpid { get; set; }
        public int InvoiceLinesRateId { get; set; }
        public int TariffsRateId { get; set; }
        public string Comments { get; set; }
        public int BatchNo { get; set; }
        public int Spil { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
    }
}
