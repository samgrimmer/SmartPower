using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VNoofDaysPerSeasonFinal
    {
        public int SpinvNumber { get; set; }
        public int? Winter1 { get; set; }
        public int? Summer1 { get; set; }
        public int? Winter { get; set; }
        public int? Summer { get; set; }
    }
}
