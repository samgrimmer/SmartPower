using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSpidNotFound
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
    }
}
