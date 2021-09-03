using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcTariffUnitCostCheck
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string RegistryNetwork { get; set; }
        public string RegistryPriceCat { get; set; }
        public string MeterType { get; set; }
        public int Spib { get; set; }
        public int Spin { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public int Spil { get; set; }
        public int RateId { get; set; }
        public int? TariffId { get; set; }
        public string TariffDescription { get; set; }
        public double? TariffUnitCost { get; set; }
        public double? LinesUnitCost { get; set; }
        public decimal? CalculatedInvLineTotal { get; set; }
        public decimal? ActualInvLineTotal { get; set; }
        public decimal? Difference { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
    }
}
