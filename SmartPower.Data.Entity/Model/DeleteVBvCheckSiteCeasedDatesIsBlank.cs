using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckSiteCeasedDatesIsBlank
    {
        public int SiteNo { get; set; }
        public string RetailerName { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? DateCeased { get; set; }
        public string Comments { get; set; }
    }
}
