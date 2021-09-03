using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcHeaderConsumptionNotMatchLine
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public int SpinvNumber { get; set; }
        public double? CalculatedUnits { get; set; }
        public double? InvoicedUnits { get; set; }
        public double? Difference { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public int BatchNo { get; set; }
        public string ProductSubCat { get; set; }
        public string SiteType { get; set; }
        public string ReadTypeCode { get; set; }
        public string MeterType { get; set; }
        public string RetailerCode { get; set; }
    }
}
