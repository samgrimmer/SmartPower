using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcConsumptionVariance
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public double? SiteConsumptionVariance { get; set; }
        public int? ClientConsumptionVariance { get; set; }
        public string SiteStatus { get; set; }
    }
}
