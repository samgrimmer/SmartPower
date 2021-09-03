using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSumSplitByParent
    {
        public string SplitClientCode { get; set; }
        public int? SplitParentSite { get; set; }
        public double? SumOfSelectSplitIdFromMasterDbSharedStagingDboTSplitInvoicesConfig { get; set; }
    }
}
