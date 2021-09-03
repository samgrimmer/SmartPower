using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcAogVerification
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string MeterType { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public string InvOpenBalType { get; set; }
        public decimal? InvAmount { get; set; }
        public string ExpectedAogCharge { get; set; }
        public string Difference { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public string ProductSubCat { get; set; }
    }
}
