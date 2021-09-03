using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TRatesLookupCreateRate
    {
        public int RatesEdiId { get; set; }
        public string Description { get; set; }
        public double? UnitCost { get; set; }
        public string UnitType { get; set; }
        public string RetailerCode { get; set; }
        public string RatesCat { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? RateClass { get; set; }
        public bool? Penalty { get; set; }
        public int? RateId { get; set; }
        public string Status { get; set; }
    }
}
