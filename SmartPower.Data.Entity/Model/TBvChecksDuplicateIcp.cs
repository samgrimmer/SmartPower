using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvChecksDuplicateIcp
    {
        public int DupId { get; set; }
        public string RetailerCode { get; set; }
        public int? SiteNo { get; set; }
        public string Icp { get; set; }
        public string Comments { get; set; }
        public string SiteType { get; set; }
        public string SiteStatus { get; set; }
        public string AccountNo { get; set; }
    }
}
