using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoiceGroupBatchMonthSelection
    {
        public DateTime? BatchMonth { get; set; }
        public double? SumOfUnitTotal { get; set; }
    }
}
