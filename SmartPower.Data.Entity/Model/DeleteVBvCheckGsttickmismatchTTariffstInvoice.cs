using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckGsttickmismatchTTariffstInvoice
    {
        public int SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public string Description { get; set; }
        public int? TariffId { get; set; }
        public int BatchNo { get; set; }
        public bool GstInInvoiceLines { get; set; }
        public bool GstInTTariffs { get; set; }
        public string InvNotes { get; set; }
        public int SiteNo { get; set; }
    }
}
