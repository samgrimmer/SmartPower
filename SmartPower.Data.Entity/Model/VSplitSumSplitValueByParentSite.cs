using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSplitSumSplitValueByParentSite
    {
        public string SplitClientCode { get; set; }
        public int? SplitParentSite { get; set; }
        public double? SplitTotal { get; set; }
        public string Status { get; set; }
    }
}
