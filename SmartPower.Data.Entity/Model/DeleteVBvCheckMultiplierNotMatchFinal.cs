using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckMultiplierNotMatchFinal
    {
        public string SiteType { get; set; }
        public int Spid { get; set; }
        public int Spin { get; set; }
        public int Spil { get; set; }
        public int? TariffId { get; set; }
        public string TariffDescription { get; set; }
        public float? TariffMultiplier { get; set; }
        public float? SpilMultiplier { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public float? Diff { get; set; }
        public int BatchNo { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
    }
}
