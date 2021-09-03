using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckLineTotalsFromTariff
    {
        public string ErrorDescription { get; set; }
        public string RetailerName { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int RateId { get; set; }
        public int TariffId { get; set; }
        public int InvLineNo { get; set; }
        public string TariffDescription { get; set; }
        public double? TariffValue { get; set; }
        public double? LineValue { get; set; }
        public double? Calculated { get; set; }
        public double? InvLineTotal { get; set; }
        public double? Difference { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
        public string InputTypeCode { get; set; }
        public double? Test { get; set; }
    }
}
