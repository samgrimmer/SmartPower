using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryConfig
    {
        public int SConfigId { get; set; }
        public bool? SZeroCredits { get; set; }
        public int? SFyeStartMonth { get; set; }
        public bool? SBudgetAuto { get; set; }
        public bool? SAccrualsAuto { get; set; }
        public bool? STrendAuto { get; set; }
    }
}
