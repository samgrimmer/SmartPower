using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VReposTouMonthlyReport
    {
        public string InvNumber { get; set; }
        public string Icp { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvSubTotal { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string Description { get; set; }
        public string Product { get; set; }
        public string UnitType { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitCost { get; set; }
        public double? InvLineTotal { get; set; }
    }
}
