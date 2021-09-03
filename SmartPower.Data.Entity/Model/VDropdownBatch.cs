using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VDropdownBatch
    {
        public int BatchNo { get; set; }
        public DateTime? BatchDate { get; set; }
        public double? BatchTotal { get; set; }
        public string BatchComments { get; set; }
        public bool? Locked { get; set; }
        public DateTime? BatchMonth { get; set; }
        public int? NoOfInv { get; set; }
    }
}
