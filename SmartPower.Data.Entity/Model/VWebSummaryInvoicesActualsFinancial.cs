using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebSummaryInvoicesActualsFinancial
    {
        public int SiteNo { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string EnergyType { get; set; }
        public double? ActualUnitsTotal { get; set; }
        public double? ActualDollars { get; set; }
        public double? BudgetUnitsTotal { get; set; }
        public double? BudgetDollars { get; set; }
    }
}
