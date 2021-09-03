using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoiceEndDateExceedsCeasedDate
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? DateCeased { get; set; }
        public string SiteType { get; set; }
        public string RetailerName { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string MeterType { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public string ProductSubCatCode { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
