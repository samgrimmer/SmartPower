using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VNoOfDaysPerSeason
    {
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate1 { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public string StartDayMonth { get; set; }
        public string StartMonth { get; set; }
        public string EndMonth { get; set; }
        public string EndDayMonth { get; set; }
        public int StartIsinWinter { get; set; }
        public int EndIsinWinter { get; set; }
        public int StartIsinSummer { get; set; }
        public int EndIsinSummer { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
    }
}
