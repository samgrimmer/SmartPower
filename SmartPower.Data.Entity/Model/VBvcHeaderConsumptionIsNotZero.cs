using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcHeaderConsumptionIsNotZero
    {
        public string ErrorDescription { get; set; }
        public int? Spid { get; set; }
        public string SiteType { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string RetailerCode { get; set; }
        public int? BatchNo { get; set; }
        public int? Spin { get; set; }
        public double? Consumption { get; set; }
        public string InvNotes { get; set; }
    }
}
