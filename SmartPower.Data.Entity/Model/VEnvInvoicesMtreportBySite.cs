using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvInvoicesMtreportBySite
    {
        public int SiteNo { get; set; }
        public string EsDay { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvDate { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDateRange { get; set; }
        public DateTime? InvEndDateRange { get; set; }
        public int? Days { get; set; }
        public double? CalcUnitsUsed { get; set; }
        public bool? ReadyForUpload { get; set; }
        public double? DailyAvgConsumption { get; set; }
        public decimal? DailyAvgDollars { get; set; }
        public decimal? AmountInclGst { get; set; }
        public string CreditBalance { get; set; }
        public decimal? AmountExclGst { get; set; }
        public bool? CreditInv { get; set; }
        public DateTime? ErStartDate { get; set; }
    }
}
