using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSummaryCo2Factor
    {
        public int SCo2Id { get; set; }
        public int? SMonth { get; set; }
        public int? SYear { get; set; }
        public DateTime? SBatchMonth { get; set; }
        public double? SCo2Factor { get; set; }
        public string SUtilityClass { get; set; }
        public string SUtilityCat { get; set; }
        public string SUtilitySubCat { get; set; }
        public string SCo2Region { get; set; }
        public byte[] SysSummaryCo2FactorsTimestamp { get; set; }
    }
}
