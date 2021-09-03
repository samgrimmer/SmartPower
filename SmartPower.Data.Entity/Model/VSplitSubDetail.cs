using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSplitSubDetail
    {
        public int? ParentSite { get; set; }
        public int? ChildSite { get; set; }
        public int? AccountPostFix { get; set; }
        public string SubStatus { get; set; }
    }
}
