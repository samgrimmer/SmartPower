using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSiteTypesReport
    {
        public string ClientName { get; set; }
        public int? ElectricityIcpSActive { get; set; }
        public int? GasIcpSActive { get; set; }
        public int? WaterAccountsActive { get; set; }
        public int? SplitsActive { get; set; }
    }
}
