using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckUnlockedBatch
    {
        public int Spib { get; set; }
        public string InputTypeCode { get; set; }
        public int? NoOfInv { get; set; }
        public double? BatchTotal { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string ClientCodeSp { get; set; }
    }
}
