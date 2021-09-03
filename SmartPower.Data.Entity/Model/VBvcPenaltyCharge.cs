using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcPenaltyCharge
    {
        public string ErrorDescription { get; set; }
        public bool? PenaltyRate { get; set; }
        public string SiteType { get; set; }
        public int Spid { get; set; }
        public int Spin { get; set; }
        public int Spil { get; set; }
        public int RateId { get; set; }
        public double? UnitsUsed { get; set; }
        public double? PenaltyCharge { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public int BatchNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string TariffDescription { get; set; }
        public string ReadTypeCode { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string PowerFactor { get; set; }
    }
}
