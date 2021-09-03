using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcNoObType
    {
        public string ErrorDescription { get; set; }
        public string RetailerName { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
        public string InvOpenBalType { get; set; }
        public decimal? InvOpeningBalance { get; set; }
    }
}
