using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebSummaryInvoicesActualsFinancialBase
    {
        public int SiteNo { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string EnergyType { get; set; }
        public string SiteType { get; set; }
        public double? ActualUnitsTotal { get; set; }
        public decimal? ActualDollars { get; set; }
        public double? BudgetUnitsTotal { get; set; }
        public decimal? BudgetDollars { get; set; }
        public string ReadTypeCode { get; set; }
        public int SpinvNumber { get; set; }
    }
}
