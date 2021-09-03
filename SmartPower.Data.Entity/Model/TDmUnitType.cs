using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TDmUnitType
    {
        public int DmutId { get; set; }
        public string CurrentUnitType { get; set; }
        public string NewUnitType { get; set; }
        public string UserName { get; set; }
    }
}
