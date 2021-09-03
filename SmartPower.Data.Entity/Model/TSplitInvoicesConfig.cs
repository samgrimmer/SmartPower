using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSplitInvoicesConfig
    {
        public int SplitId { get; set; }
        public string SplitClientCode { get; set; }
        public int? SplitParentSite { get; set; }
        public int? SplitChildSite { get; set; }
        public int? SplitAccountPostFix { get; set; }
        public double? SplitValue { get; set; }
        public string Status { get; set; }
    }
}
