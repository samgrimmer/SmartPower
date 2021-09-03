using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VDollarsConsumptionReportSub
    {
        public DateTime? BatchMonth { get; set; }
        public bool? ReadyForUpload { get; set; }
        public string Dvn { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string ClientRef { get; set; }
        public string AccountNo { get; set; }
        public string SiteType { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string Region { get; set; }
        public string Icp { get; set; }
        public string Region2 { get; set; }
        public string SiteLocationDd { get; set; }
        public string ClientCc { get; set; }
        public string EnergyType { get; set; }
        public string MeterType { get; set; }
        public double? SqMetresTotal { get; set; }
        public string RetailerCode { get; set; }
        public string SiteStatus { get; set; }
        public string MonthSorting { get; set; }
        public decimal? TotalExclGst { get; set; }
        public double? UnitTotal { get; set; }
        public short? InvNoOfDays { get; set; }
        public DateTime? InvStartDate { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
