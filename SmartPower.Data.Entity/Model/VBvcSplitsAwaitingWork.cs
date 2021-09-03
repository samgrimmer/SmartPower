using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSplitsAwaitingWork
    {
        public int SplitId { get; set; }
        public int? NewInvoice { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNumber { get; set; }
        public int? ParentSite { get; set; }
        public int? ChildSite { get; set; }
    }
}
