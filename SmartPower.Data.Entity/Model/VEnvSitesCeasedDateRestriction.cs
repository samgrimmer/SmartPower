using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvSitesCeasedDateRestriction
    {
        public int SiteNo { get; set; }
        public string ClientCode { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string Nmi { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteLocation { get; set; }
        public string SiteLocationDd { get; set; }
        public string Region { get; set; }
        public string Region2 { get; set; }
        public string SiteStatus { get; set; }
        public float? NoOfStaff { get; set; }
        public double? SqMetresOccupied { get; set; }
        public double? SqMetresTotal { get; set; }
        public bool? MainSite { get; set; }
        public string NetworkId { get; set; }
        public string SiteTypeCode { get; set; }
        public string OrderNumber { get; set; }
        public string Dvn { get; set; }
        public string ClientCc { get; set; }
        public string ClientRef { get; set; }
        public string BuildingNo { get; set; }
        public string RetailerSiteRef { get; set; }
        public string CompanyCode { get; set; }
        public string Entity { get; set; }
        public string AccountCode { get; set; }
        public float? RebatePc { get; set; }
        public float? DiscountPc { get; set; }
        public double? FixedKva { get; set; }
        public string GridExitPoint { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? TimeAdded { get; set; }
        public string InputType { get; set; }
        public string Comments { get; set; }
        public string ContactFloor { get; set; }
        public string ContactAddressLine1 { get; set; }
        public string ContactMailAddressLine1 { get; set; }
        public string ContactAddressLine2 { get; set; }
        public string ContactAddressCity { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }
        public string ContactPhone { get; set; }
        public string MeterType { get; set; }
        public double? Losses { get; set; }
        public bool? RedFlag { get; set; }
        public DateTime? LeaseExpiry { get; set; }
        public string SiteType { get; set; }
        public int? CalSqMetres { get; set; }
        public string TaxClass { get; set; }
        public DateTime? DateCeasedRestriction { get; set; }
        public string RetailId { get; set; }
        public string MeterNo { get; set; }
        public bool? NonContestable { get; set; }
        public string NetworkCompany { get; set; }
        public bool? MasterList { get; set; }
        public string Vhaaddress1 { get; set; }
        public string Vhaaddress2 { get; set; }
        public string Vhaaddress3 { get; set; }
        public int? Postcode { get; set; }
        public string MasterListSiteType { get; set; }
        public string EdiCreated { get; set; }
        public string SiteConsolidationFlag { get; set; }
        public string SubClientCode { get; set; }
        public string ParentCustomer { get; set; }
        public int? FloorUtilityFactor { get; set; }
        public int? OrgId { get; set; }
    }
}
