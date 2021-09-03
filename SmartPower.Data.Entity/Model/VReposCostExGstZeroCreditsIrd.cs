using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VReposCostExGstZeroCreditsIrd
    {
        public int Spin { get; set; }
        public string CreditInv1 { get; set; }
        public int Spid { get; set; }
        public string Region { get; set; }
        public string Region2 { get; set; }
        public string EnergyType { get; set; }
        public DateTime? BatchMonth { get; set; }
        public double? HeaderKwh { get; set; }
        public double? CheckHeader { get; set; }
        public string CurrentRetailer { get; set; }
        public decimal? CorrectAmountPaidExGst { get; set; }
        public decimal? OpeningBalanceIncGst { get; set; }
        public string InvoiceRetailer { get; set; }
    }
}
