using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvcEstimatesCheck
    {
        public string ErrorDescription { get; set; }
        public bool? HasAnActual { get; set; }
        public string Retailer { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string ClientRef { get; set; }
        public DateTime? LastActualRead { get; set; }
        public string MeterType { get; set; }
        public int? EstimateCount { get; set; }
        public int? BatchNo { get; set; }
        public int? LatestSpin { get; set; }
        public string ReadTypeCode { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
        public int? CountOfActuals { get; set; }
        public int? InvoiceCount { get; set; }
    }
}
