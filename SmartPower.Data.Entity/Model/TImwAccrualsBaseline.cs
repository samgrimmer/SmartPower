using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TImwAccrualsBaseline
    {
        public int BaseId { get; set; }
        public int? SiteNo { get; set; }
        public DateTime? LastReadDate { get; set; }
        public DateTime? SecoundLastReadDate { get; set; }
        public int? Days { get; set; }
        public double? BlConsumption { get; set; }
        public decimal? BlDollars { get; set; }
        public double? BlKwhPerDay { get; set; }
        public double? BlCentsPerKwh { get; set; }
        public double? BlDollarsPerDay { get; set; }
        public double? MeConsumption { get; set; }
        public decimal? MeDollars { get; set; }
        public string Status { get; set; }
        public int? NoOfInvSite { get; set; }
    }
}
