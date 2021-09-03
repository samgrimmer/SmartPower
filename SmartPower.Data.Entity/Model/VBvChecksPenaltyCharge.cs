using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvChecksPenaltyCharge
    {
        public string BatchMonth { get; set; }
        public string EnvironmentalMonth { get; set; }
        public int Spid { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public int Spin { get; set; }
        public DateTime? InvoiceStartDate { get; set; }
        public DateTime? InvoiceEndDate { get; set; }
        public int Spil { get; set; }
        public int RateId { get; set; }
        public string ChargeDescription { get; set; }
        public double? Units { get; set; }
        public double? ExGstBeforePpd { get; set; }
        public decimal? InvoicePpd { get; set; }
        public double? ExGstAfterPpd { get; set; }
        public string Product { get; set; }
        public string ProductSubCat { get; set; }
    }
}
