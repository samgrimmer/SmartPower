using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckTariffSiteNoMismatch
    {
        public string SiteType { get; set; }
        public int SpinvNumber { get; set; }
        public int InvoiceSpid { get; set; }
        public int TariffSpid { get; set; }
        public int TariffsRateId { get; set; }
        public int? TariffId { get; set; }
        public string Comments { get; set; }
        public int BatchNo { get; set; }
        public string AccountNo { get; set; }
        public string IsASplitInvoice { get; set; }
        public int Spil { get; set; }
        public int SpilRateId { get; set; }
        public int SiteNo { get; set; }
        public int SiteNo1 { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public string ProductId { get; set; }
    }
}
