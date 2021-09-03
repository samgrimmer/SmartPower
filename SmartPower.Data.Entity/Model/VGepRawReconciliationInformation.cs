using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VGepRawReconciliationInformation
    {
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string Utility { get; set; }
        public string MeterType { get; set; }
        public double? Consumption { get; set; }
        public string Icp { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? DateCeased { get; set; }
        public string SiteDescription { get; set; }
    }
}
