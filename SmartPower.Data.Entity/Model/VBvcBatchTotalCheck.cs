using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcBatchTotalCheck
    {
        public int BatchNo { get; set; }
        public double? BatchTotal { get; set; }
        public decimal? CalculatedBatchTotal { get; set; }
        public bool? InvArchived { get; set; }
        public bool? CreditInv { get; set; }
    }
}
