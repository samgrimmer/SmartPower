using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckLastInvoiceWithSpin
    {
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public DateTime? MaxOfInvEndDate { get; set; }
    }
}
