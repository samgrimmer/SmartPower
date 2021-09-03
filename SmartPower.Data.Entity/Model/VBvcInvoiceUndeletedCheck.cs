using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceUndeletedCheck
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int? SplitParentSite { get; set; }
        public int? NewInvoice { get; set; }
        public int SplitId { get; set; }
        public string SplitClientCode { get; set; }
        public string ChildSiteAccount { get; set; }
    }
}
