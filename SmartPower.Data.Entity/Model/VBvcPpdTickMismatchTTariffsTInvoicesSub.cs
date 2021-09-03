using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcPpdTickMismatchTTariffsTInvoicesSub
    {
        public int? SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public string Description { get; set; }
        public int TariffId { get; set; }
        public int BatchNo { get; set; }
        public bool PpdInInvoiceLines { get; set; }
        public bool PpdInTTariffs { get; set; }
        public string InvNotes { get; set; }
        public int SiteNo { get; set; }
    }
}
