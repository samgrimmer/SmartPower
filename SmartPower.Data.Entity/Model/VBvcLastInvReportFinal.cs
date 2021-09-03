using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcLastInvReportFinal
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string SiteType { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string MeterType { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? Lastinvoicedto { get; set; }
        public DateTime? Lastinvoicedate { get; set; }
        public string SiteStatus { get; set; }
        public string SiteComments { get; set; }
        public string InvNotes { get; set; }
        public short? InvNoOfDays { get; set; }
        public string BillingFrequency { get; set; }
        public bool Managed { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public double? UnitTotal { get; set; }
    }
}
