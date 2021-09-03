﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInputtypesMismatch
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public int BatchNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteDescription { get; set; }
        public int Spin { get; set; }
        public string ReadTypeCode { get; set; }
        public string SpidInputType { get; set; }
        public string SpinInputType { get; set; }
        public string InvNotes { get; set; }
        public string SiteName { get; set; }
        public string Comments { get; set; }
    }
}
