using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSiteLocation
    {
        public string SiteLocation { get; set; }
        public string Region { get; set; }
        public byte[] SysSiteLocationsTimestamp { get; set; }
    }
}
