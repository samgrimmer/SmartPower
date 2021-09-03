﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcKwhSum
    {
        public int SpinvNumber { get; set; }
        public double? SumOfUnitsUsed { get; set; }
        public string UnitType { get; set; }
        public string RateCategory { get; set; }
        public double? HeaderKWh { get; set; }
    }
}
