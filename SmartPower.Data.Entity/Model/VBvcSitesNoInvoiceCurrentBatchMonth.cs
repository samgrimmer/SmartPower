using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSitesNoInvoiceCurrentBatchMonth
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string SiteType { get; set; }
        public string Icp { get; set; }
        public string MeterType { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public int? BatchNo { get; set; }
        public int? Spin { get; set; }
        public string ReadType { get; set; }
        public DateTime? LastInvTo { get; set; }
        public DateTime? LastInvDate { get; set; }
        public string SiteStatus { get; set; }
        public string Comments { get; set; }
        public short? InvNoOfDays { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public bool Managed { get; set; }
    }
}
