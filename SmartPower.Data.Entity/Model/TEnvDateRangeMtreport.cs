using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEnvDateRangeMtreport
    {
        public int ErDateRangeId { get; set; }
        public DateTime? ErStartDate { get; set; }
        public DateTime? ErEndDate { get; set; }
    }
}
