using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSitesSplit
    {
        public int SplitId { get; set; }
        public string SplitClientCode { get; set; }
        public int? SplitParentSite { get; set; }
        public string SplitAccountPostFix { get; set; }
        public double? SplitValue { get; set; }
        public string ChildSiteAccount { get; set; }
        public bool? Active { get; set; }
    }
}
