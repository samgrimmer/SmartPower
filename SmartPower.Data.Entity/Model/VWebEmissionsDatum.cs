using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebEmissionsDatum
    {
        public int SiteNo { get; set; }
        public int? Scope { get; set; }
        public string Source { get; set; }
        public string Activity { get; set; }
        public double? Co2Factor { get; set; }
        public string Co2Code { get; set; }
        public DateTime? Co2Period { get; set; }
        public string ClientCode { get; set; }
    }
}
