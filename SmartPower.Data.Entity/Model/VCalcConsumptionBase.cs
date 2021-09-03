using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VCalcConsumptionBase
    {
        public int? SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public double? CalcUnits { get; set; }
        public string RateCategory { get; set; }
        public string UnitType { get; set; }
        public string UnitType1 { get; set; }
    }
}
