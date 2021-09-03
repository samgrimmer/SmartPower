using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TImwAccrualsBase
    {
        public int BaseId { get; set; }
        public int? SiteNo { get; set; }
        public int? SpinvNumber { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public double? BlConsumption { get; set; }
        public decimal? BlDollars { get; set; }
        public DateTime? LastReadDate { get; set; }
        public DateTime? SecoundLastReadDate { get; set; }
        public int? Days { get; set; }
        public double? MeConsumption { get; set; }
        public decimal? MeDollars { get; set; }
        public int? ReadCount { get; set; }
        public string Status { get; set; }
        public bool? EstimatePreRead { get; set; }
        public string StatusDup { get; set; }
    }
}
