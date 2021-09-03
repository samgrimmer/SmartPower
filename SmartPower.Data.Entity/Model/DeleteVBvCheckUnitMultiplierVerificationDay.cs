using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckUnitMultiplierVerificationDay
    {
        public int Spid { get; set; }
        public int Spib { get; set; }
        public int Spin { get; set; }
        public int? TariffId { get; set; }
        public string TariffUnitMultiplierType { get; set; }
        public string InvNotes { get; set; }
        public double? SumOfUnitMulitiplier { get; set; }
        public int? InvNoOfDays { get; set; }
    }
}
