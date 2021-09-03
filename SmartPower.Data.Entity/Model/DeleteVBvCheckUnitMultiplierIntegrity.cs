using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckUnitMultiplierIntegrity
    {
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public int TariffId { get; set; }
        public double? TTariffsUnitMultiplier { get; set; }
        public double? TInvoiceLinesUnitMultiplier { get; set; }
        public string Description { get; set; }
        public string TInvoiceLinesUnitMultiplierType { get; set; }
        public string UnitMultiplierType { get; set; }
        public string DataEntryNotes { get; set; }
    }
}
