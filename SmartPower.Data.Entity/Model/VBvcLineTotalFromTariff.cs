using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcLineTotalFromTariff
    {
        public string ErrorDescription { get; set; }
        public string RetailerName { get; set; }
        public int? LtSiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string RegistryNetwork { get; set; }
        public string RegistryPriceCat { get; set; }
        public string MeterType { get; set; }
        public int? LtBatchNo { get; set; }
        public int? LtSpinvNumber { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public int? LtRateId { get; set; }
        public int? LtTariffId { get; set; }
        public int? LtInvLineNo { get; set; }
        public string LtTariffDescription { get; set; }
        public double? TariffValue { get; set; }
        public double? LineValue { get; set; }
        public double? Calculated { get; set; }
        public double? LineTotal { get; set; }
        public double? Difference { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
    }
}
