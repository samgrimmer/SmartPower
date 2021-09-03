using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VNoOfDaysPerSeasonStep2
    {
        public int SpinvNumber { get; set; }
        public int? Winter1 { get; set; }
        public int? Summer1 { get; set; }
        public short? InvNoOfDays { get; set; }
    }
}
