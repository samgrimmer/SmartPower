using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoiceGroupTotalsWithLinesSubTotalsBySite
    {
        public int SiteNo { get; set; }
        public double? SumOfInvLineTotal { get; set; }
    }
}
