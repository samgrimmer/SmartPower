using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFirstInvoicePerSpid
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string Utility { get; set; }
        public string Icp { get; set; }
        public string MeterType { get; set; }
        public string RetailerCode { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public string ReadTypeCode { get; set; }
        public double? Consumption { get; set; }
        public decimal? AmountToPayInclGst { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public DateTime? StartDate1 { get; set; }
    }
}
