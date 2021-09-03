using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcMaxDailyConsumptionExceeded
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string Utility { get; set; }
        public string Icp { get; set; }
        public string MeterType { get; set; }
        public string RetailerCode { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public string ReadTypeCode { get; set; }
        public int Spil { get; set; }
        public int RateId { get; set; }
        public int? TariffId { get; set; }
        public double? TariffMaxDailyConsumption { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public double? ConsumptionDay { get; set; }
        public double? Difference { get; set; }
    }
}
