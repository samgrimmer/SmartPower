using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvChecksDateGap
    {
        public int DgId { get; set; }
        public string LastInvoiceTest { get; set; }
        public string DateGapTest { get; set; }
        public string OverlapTest { get; set; }
    }
}
