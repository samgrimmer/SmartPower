using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VImwcDatamanagementUpdateUnitType
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string UnitType { get; set; }
        public string NewUnitType { get; set; }
        public string CurrentUnitType { get; set; }
    }
}
