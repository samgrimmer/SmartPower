using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebSiteDetail
    {
        public int SiteNo { get; set; }
        public string RetailerName { get; set; }
        public string AccountNo { get; set; }
        public string ClientRef { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteType { get; set; }
        public string SiteLocation { get; set; }
        public string Region { get; set; }
        public string SiteStatus { get; set; }
        public string Product { get; set; }
        public string ClientCode { get; set; }
        public string NetworkId { get; set; }
        public string GridExitPoint { get; set; }
        public double? SqMetresOccupied { get; set; }
        public double? SqMetresTotal { get; set; }
        public float? NoOfStaff { get; set; }
        public string ClientCc { get; set; }
        public string AccountCode { get; set; }
        public string RetailerSiteRef { get; set; }
        public float? RebatePc { get; set; }
        public float? DiscountPc { get; set; }
        public double? FixedKva { get; set; }
        public string InputType { get; set; }
        public string MeterType { get; set; }
        public string Dvn { get; set; }
        public string BuildingNo { get; set; }
        public string Comments { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? TimeAdded { get; set; }
        public string CompanyCode { get; set; }
        public string Region2 { get; set; }
        public double? Losses { get; set; }
    }
}
