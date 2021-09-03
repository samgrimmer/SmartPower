using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckCalConsumptionPre2
    {
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string MeterType { get; set; }
        public double? LinesUnits { get; set; }
        public double? HeaderUnits { get; set; }
        public string RetailerCode { get; set; }
        public int BatchNo { get; set; }
        public string SiteType { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string ReadTypeCode { get; set; }
        public string Icp { get; set; }
        public string ProductSubCat { get; set; }
    }
}
