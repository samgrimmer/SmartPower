using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoicesConsumptionWater1
    {
        public int SpinvNumber { get; set; }
        public double? SumOfUnitsUsed1 { get; set; }
        public string UnitType { get; set; }
        public string RateCategory { get; set; }
    }
}
