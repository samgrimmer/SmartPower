using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupExSplit
    {
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public string SiteType { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
    }
}
