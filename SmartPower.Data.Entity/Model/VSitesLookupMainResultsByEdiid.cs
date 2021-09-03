using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupMainResultsByEdiid
    {
        public int BatchNo { get; set; }
        public int EdiSiteId { get; set; }
        public int SiteNo { get; set; }
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string EdiRetailerCode { get; set; }
        public string EdiAccountNo { get; set; }
        public string EdiInvNumber { get; set; }
        public string EdiSiteDesciption { get; set; }
        public string EdiIcp { get; set; }
        public string EdiNetwrokId { get; set; }
        public int? EdiId { get; set; }
        public int Results { get; set; }
        public string Action { get; set; }
    }
}
