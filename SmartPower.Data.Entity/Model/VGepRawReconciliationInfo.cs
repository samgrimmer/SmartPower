using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VGepRawReconciliationInfo
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string ProductSubCat { get; set; }
        public string MeterType { get; set; }
        public double? Consumption { get; set; }
        public string Icp { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? DateCeased { get; set; }
        public string SiteDescription { get; set; }
    }
}
