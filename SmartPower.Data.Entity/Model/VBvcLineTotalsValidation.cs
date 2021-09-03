using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcLineTotalsValidation
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public int Spil { get; set; }
        public string Description { get; set; }
        public double? UnitsUsed { get; set; }
        public string UnitType { get; set; }
        public double? UnitCost { get; set; }
        public double? UnitMultiplier { get; set; }
        public double? LineTotalExGst { get; set; }
        public double? LineTotalGst { get; set; }
        public double? LineTotalInclGst { get; set; }
        public double CalculatedLineTotalInclGst { get; set; }
    }
}
