using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorTotal
    {
        public string ClientRef { get; set; }
        public double? SqMetresTotal { get; set; }
        public string SiteType { get; set; }
        public string SiteStatus { get; set; }
    }
}
