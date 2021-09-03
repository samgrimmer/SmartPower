using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoicesGstVsTariffsGst
    {
        public int? SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public string Description { get; set; }
        public int? TariffId { get; set; }
        public int BatchNo { get; set; }
        public bool TariffsGst { get; set; }
        public bool InvoiceLinesGst { get; set; }
    }
}
