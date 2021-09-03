using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcFloorTotalSameAccessCref
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public string ClientRef { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string Region { get; set; }
        public string Region2 { get; set; }
        public double? SqMetresOccupied { get; set; }
        public double? SqMetresTotal { get; set; }
        public string Comments { get; set; }
        public string SiteStatus { get; set; }
        public bool? SqmManaged { get; set; }
    }
}
