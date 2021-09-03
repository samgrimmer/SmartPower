using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcAogCheck
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public int BatchNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public int Spin { get; set; }
        public double? AogCharges { get; set; }
        public double? CalculatedAogCharges { get; set; }
        public double? Difference { get; set; }
        public string InvoiceComments { get; set; }
    }
}
