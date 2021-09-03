using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvDataManagementExportId11
    {
        public int? SpinvNumber { get; set; }
        public string Description { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitMultiplier { get; set; }
        public int TariffId { get; set; }
        public string TariffDescription { get; set; }
        public double? TariffsUnitMultiplier { get; set; }
    }
}
