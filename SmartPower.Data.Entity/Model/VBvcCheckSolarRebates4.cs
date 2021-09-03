using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCheckSolarRebates4
    {
        public string ErrorDesciption { get; set; }
        public int Spin { get; set; }
        public int Spid { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public double? Consumption { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public int BatchNo { get; set; }
    }
}
