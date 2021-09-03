using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcDuplicateSupplierInvNumber
    {
        public string ErrorDescription { get; set; }
        public int Spib { get; set; }
        public int Spin { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string InvNumber { get; set; }
        public string InvNotes { get; set; }
    }
}
