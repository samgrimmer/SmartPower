using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckSolarRebates4
    {
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public double? Consumption { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public int BatchNo { get; set; }
    }
}
