using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VImwcDatamanagementUpdateUnitMultiplierRate
    {
        public double? UnitMultiplier { get; set; }
        public string UnitMultiplierType { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public short? InvNoOfDays { get; set; }
        public int InvLineNo { get; set; }
        public int TariffId { get; set; }
        public string Description { get; set; }
        public string UnitType { get; set; }
        public double? EdiUnitCost { get; set; }
        public double? AddUnitMulitplier { get; set; }
    }
}
