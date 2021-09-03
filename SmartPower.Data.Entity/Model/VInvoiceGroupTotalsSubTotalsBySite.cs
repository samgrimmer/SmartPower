using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoiceGroupTotalsSubTotalsBySite
    {
        public int SiteNo { get; set; }
        public decimal? SumOfInvSubTotal { get; set; }
        public double? SumOfUnitTotal { get; set; }
    }
}
