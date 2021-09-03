using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoiceUnitTypeView
    {
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int RateId { get; set; }
        public string UnitType { get; set; }
        public int InvLineNo { get; set; }
        public string InvoiceUnitType { get; set; }
        public string Description { get; set; }
        public double? UnitsUsed { get; set; }
    }
}
