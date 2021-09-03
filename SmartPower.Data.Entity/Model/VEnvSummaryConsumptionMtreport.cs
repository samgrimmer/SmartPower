using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvSummaryConsumptionMtreport
    {
        public int? EsSiteId { get; set; }
        public string Icp { get; set; }
        public string AccountNo { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteLocation { get; set; }
        public string EnergyType { get; set; }
        public string MeterType { get; set; }
        public double? SqMetresTotal { get; set; }
        public string RetailerCode { get; set; }
        public string CompanyCode { get; set; }
        public string Entity { get; set; }
        public string Region2 { get; set; }
        public string SiteStatus { get; set; }
        public string Comments { get; set; }
        public DateTime? EsPeriod { get; set; }
        public double? SumOfSumOfEsConsumptionDailyAvg { get; set; }
        public int? SumOfCountOfEsDay { get; set; }
    }
}
