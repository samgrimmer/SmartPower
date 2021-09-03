using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VAnnualConsumptionFinal
    {
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string GridExitPoint { get; set; }
        public string ClientRef { get; set; }
        public string Product { get; set; }
        public string ProductSubCat { get; set; }
        public string MeterType { get; set; }
        public int? ActualNoOfDays { get; set; }
        public double? ActualKwh { get; set; }
        public double? AnnualisedkWh { get; set; }
    }
}
