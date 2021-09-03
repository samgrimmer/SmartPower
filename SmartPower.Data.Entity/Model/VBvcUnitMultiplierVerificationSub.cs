using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcUnitMultiplierVerificationSub
    {
        public int SpinvNumber { get; set; }
        public string UnitMultiplierType { get; set; }
        public double? SumOfUnitMulitiplier { get; set; }
        public int TariffId { get; set; }
    }
}
