using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcLineTotalNotBalancing
    {
        public int Spil { get; set; }
        public int Spin { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitMultiplier { get; set; }
        public double? UnitCost1 { get; set; }
        public double? InvLineTotal { get; set; }
        public double? CalculatedLineTotal { get; set; }
        public string InvNotes { get; set; }
        public int BatchNo { get; set; }
        public string LineDescription { get; set; }
        public string UnitType { get; set; }
        public double? Ratio { get; set; }
        public short? SpinDays { get; set; }
        public string RetailerCode { get; set; }
        public string ProductId { get; set; }
        public string SiteType { get; set; }
        public double? UnitCost { get; set; }
        public string UtilityCode { get; set; }
        public int SiteNo { get; set; }
    }
}
