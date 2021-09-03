using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcUnitMultiplierVerification
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public int Spib { get; set; }
        public int Spin { get; set; }
        public int? TariffId { get; set; }
        public string TariffDescription { get; set; }
        public string TariffUnitMultiplierType { get; set; }
        public int? InvNoOfDays { get; set; }
        public double? LinesUnitMultiplierTotalPerTariffId { get; set; }
        public double? LinesUnitMultiplierTotal { get; set; }
        public string InvNotes { get; set; }
    }
}
