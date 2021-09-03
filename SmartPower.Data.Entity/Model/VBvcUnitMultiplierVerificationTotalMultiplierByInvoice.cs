using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcUnitMultiplierVerificationTotalMultiplierByInvoice
    {
        public int SpinvNumber { get; set; }
        public string UnitMultiplierType { get; set; }
        public double? SumOfUnitMulitiplier { get; set; }
    }
}
