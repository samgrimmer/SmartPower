using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSplitInvoicesSiteDetail
    {
        public int SplitId { get; set; }
        public string SplitClientCode { get; set; }
        public int? SplitParentSite { get; set; }
        public int? SplitAccountPostFix { get; set; }
        public double? SplitValue { get; set; }
        public string AccountNo { get; set; }
        public string ChildSiteAccount { get; set; }
        public string SiteNoResult { get; set; }
        public string SiteName { get; set; }
        public double? SplitTotal { get; set; }
    }
}
