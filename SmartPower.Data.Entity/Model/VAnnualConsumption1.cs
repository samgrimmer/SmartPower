using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VAnnualConsumption1
    {
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string GridExitPoint { get; set; }
        public string ClientRef { get; set; }
        public string MeterType { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? InvoiceKwh { get; set; }
        public string Product { get; set; }
        public string ProductSubCat { get; set; }
        public bool? ReadyForUpload { get; set; }
        public string SiteStatus { get; set; }
    }
}
