using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckHeaderConsumptionNotMatchLine
    {
        public double? Difference { get; set; }
        public int BatchNo { get; set; }
        public string ProductSubCat { get; set; }
        public string ReadTypeCode { get; set; }
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public double? InvoicedUnits { get; set; }
        public string SiteType { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public string MeterType { get; set; }
        public string RetailerCode { get; set; }
        public double? CalculatedUnits { get; set; }
    }
}
