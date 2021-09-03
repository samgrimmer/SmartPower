using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvFindParentAccountNo
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int? SplitChildSite { get; set; }
        public int? SplitParentSite { get; set; }
        public string Status { get; set; }
    }
}
