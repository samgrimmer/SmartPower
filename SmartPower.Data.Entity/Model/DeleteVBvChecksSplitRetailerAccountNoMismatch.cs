using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvChecksSplitRetailerAccountNoMismatch
    {
        public int? SplitParentSite { get; set; }
        public int? SplitChildSite { get; set; }
        public int ParentSiteNo { get; set; }
        public string ParentAccountNo { get; set; }
        public string ParentRetailer { get; set; }
        public int ChildSpid { get; set; }
        public string ChildAccountNo { get; set; }
        public string ChildRetailer { get; set; }
    }
}
