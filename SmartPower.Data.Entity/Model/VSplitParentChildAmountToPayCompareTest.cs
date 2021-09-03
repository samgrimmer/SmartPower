using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSplitParentChildAmountToPayCompareTest
    {
        public int SpinvNumber { get; set; }
        public decimal? DiffAmountToPayIncGst { get; set; }
        public decimal? DiffAmountToPayExclGst { get; set; }
        public decimal? DiffAmountToPayGst { get; set; }
        public int? NewInvoice { get; set; }
        public long? RowNumber { get; set; }
    }
}
