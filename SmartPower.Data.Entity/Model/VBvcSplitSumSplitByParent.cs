using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSplitSumSplitByParent
    {
        public string SplitClientCode { get; set; }
        public int? SplitParentSite { get; set; }
        public double? SumOfSplitValue { get; set; }
    }
}
