using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TReversalsBulkList
    {
        public int RevId { get; set; }
        public int? OrgSpinvNumber { get; set; }
        public string RevStatus { get; set; }
        public int? NewSpInvNumber { get; set; }
        public string RevResults { get; set; }
        public string UserName { get; set; }
    }
}
