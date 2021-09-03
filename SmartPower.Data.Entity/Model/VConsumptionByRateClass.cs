using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VConsumptionByRateClass
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public double? HeaderConsmption { get; set; }
        public double? Consumption { get; set; }
        public string UnitType { get; set; }
        public string RateCategory { get; set; }
        public string RateClass { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteType { get; set; }
    }
}
