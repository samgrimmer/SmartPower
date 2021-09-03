using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcBpayCode
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public int Spid { get; set; }
        public string SpidRetailer { get; set; }
        public string SpidAccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public string SpidBpayCode { get; set; }
        public int Spin { get; set; }
        public string SpinRetailer { get; set; }
        public string SpinAccountNo { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
    }
}
