using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSitesLookupCreateSite
    {
        public int CreateId { get; set; }
        public int? EdiSiteId { get; set; }
        public int? EdiId { get; set; }
        public int? EdiSpin { get; set; }
        public string EdiInvNumber { get; set; }
        public string EdiNetwrokId { get; set; }
        public string SitesMatchWarning { get; set; }
        public int? SiteIdCreated { get; set; }
        public string EdiClientCode { get; set; }
        public string EdiRetailerCode { get; set; }
        public string EdiAccountNo { get; set; }
        public string EdiIcp { get; set; }
        public string EdiSiteName { get; set; }
        public string EdiSiteDesciption { get; set; }
        public string EdiSiteStatus { get; set; }
        public string EdiSiteType { get; set; }
        public string EdiSiteSubType { get; set; }
        public DateTime? EdiDateAdded { get; set; }
        public DateTime? EdiTimeAdded { get; set; }
        public string EdiComments { get; set; }
        public bool? EdiRedFlag { get; set; }
        public string EdiTaxClass { get; set; }
    }
}
