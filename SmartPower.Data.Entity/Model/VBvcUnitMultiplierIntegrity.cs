﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcUnitMultiplierIntegrity
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public int Spib { get; set; }
        public int Spin { get; set; }
        public int Spil { get; set; }
        public int TariffId { get; set; }
        public double? TariffUnitMultiplier { get; set; }
        public double? LinesUnitMultiplier { get; set; }
        public string UnitMultiplierType { get; set; }
        public double? InvLineTotal { get; set; }
        public string TariffDescription { get; set; }
        public string InvoiceComments { get; set; }
        public string LinesUnitType { get; set; }
        public string DataEntryNotes { get; set; }
    }
}
