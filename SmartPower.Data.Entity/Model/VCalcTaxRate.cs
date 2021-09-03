using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VCalcTaxRate
    {
        public int SpinvNumber { get; set; }
        public string TaxClass { get; set; }
        public double? TaxRate { get; set; }
        public DateTime? InvDate { get; set; }
        public int Test { get; set; }
    }
}
