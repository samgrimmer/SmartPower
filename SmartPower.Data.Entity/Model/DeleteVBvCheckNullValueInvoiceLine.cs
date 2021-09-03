using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckNullValueInvoiceLine
    {
        public string ErrorDescription { get; set; }
        public int InvLineNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int RateId { get; set; }
        public int? TariffId { get; set; }
        public string Description { get; set; }
        public double? UnitUsed { get; set; }
        public double? UnitCost { get; set; }
        public string UnitType { get; set; }
        public double? InvLineTotal { get; set; }
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
    }
}
