using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupEdiSitesDetail
    {
        public int EdiSiteId { get; set; }
        public int? EdiId { get; set; }
        public string EdiRetailerCode { get; set; }
        public string EdiAccountNo { get; set; }
        public string EdiInvNumber { get; set; }
        public string EdiSiteDesciption { get; set; }
        public string EdiIcp { get; set; }
        public string EdiNetwrokId { get; set; }
        public string EdSiteType { get; set; }
        public string EdSiteSubType { get; set; }
    }
}
