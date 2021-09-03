using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcRedFlag
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public int Spin { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public bool Managed { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string Comments { get; set; }
        public int Spib { get; set; }
        public string Region { get; set; }
        public string Region2 { get; set; }
        public string ClientRef { get; set; }
        public string ClientCc { get; set; }
        public string SiteType { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public string MeterType { get; set; }
        public string InvNotes { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DateCeased { get; set; }
    }
}
