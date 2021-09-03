using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckUnitMultiplierVerificationLossFactor
    {
        public int Spid { get; set; }
        public int Spib { get; set; }
        public int Spin { get; set; }
        public int Spil { get; set; }
        public int? TariffId { get; set; }
        public string TariffUnitMultiplierType { get; set; }
        public double? TariffUnitMultiplier { get; set; }
        public double? LinesUnitMultiplier { get; set; }
        public string InvNotes { get; set; }
        public short? InvNoOfDays { get; set; }
    }
}
