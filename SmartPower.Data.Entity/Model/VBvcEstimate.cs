using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcEstimate
    {
        public string ErrorDescription { get; set; }
        public bool? HasAnActual { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string ClientRef { get; set; }
        public string MeterType { get; set; }
        public int? EsEstimateCount { get; set; }
        public DateTime? EsLastactualReadDate { get; set; }
        public string Comments { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string InvNotes { get; set; }
    }
}
