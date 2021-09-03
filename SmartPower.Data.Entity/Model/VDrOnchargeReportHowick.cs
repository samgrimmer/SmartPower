using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VDrOnchargeReportHowick
    {
        public int Spib { get; set; }
        public int Spin { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string Retailer { get; set; }
        public string AccountNumber { get; set; }
        public string NmiMirn { get; set; }
        public string SiteType { get; set; }
        public string ReadType { get; set; }
        public DateTime? InvoiceStartDate { get; set; }
        public DateTime? InvoiceEndDate { get; set; }
        public short? NoOfDays { get; set; }
        public double? Consumption { get; set; }
        public string ChargesGstFree { get; set; }
        public string ChargesExGst { get; set; }
        public string InvGst { get; set; }
        public string ToPayInclGst { get; set; }
        public string AccountCode { get; set; }
    }
}
