using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvChecksTouInvoiceGetNotMonth
    {
        public int SpinvNumber { get; set; }
        public string InvEndDate { get; set; }
        public string InvStartDate { get; set; }
        public string LastDayCurrentMonth { get; set; }
        public string FirstDayCurrentMonth { get; set; }
        public int? StartDateMonth { get; set; }
        public int? EndDateMonth { get; set; }
        public int? StartDateYear { get; set; }
        public int? EndDateYear { get; set; }
        public int GetNotMonth { get; set; }
    }
}
