using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VRatesLookupMain
    {
        public int BatchNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public string Description { get; set; }
        public double? UnitCost { get; set; }
        public string UnitType { get; set; }
        public int RateId { get; set; }
        public int? TariffId { get; set; }
        public string RateCategory { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string EdiRetailerCode { get; set; }
        public string EdiAccountNo { get; set; }
        public string EdiInvNumber { get; set; }
        public string EdiSiteDesciption { get; set; }
        public string EdiIcp { get; set; }
        public string EdiNetwrokId { get; set; }
        public int? RateClass { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? UnitMultiplier { get; set; }
    }
}
