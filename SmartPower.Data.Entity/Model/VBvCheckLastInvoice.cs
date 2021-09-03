using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckLastInvoice
    {
        public int SiteNo { get; set; }
        public DateTime? MaxOfInvEndDate { get; set; }
    }
}
