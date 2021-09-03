using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceOpeningBalanceTypeInvalid
    {
        public string ErrorDescription { get; set; }
        public string InvOpenBalType { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
    }
}
