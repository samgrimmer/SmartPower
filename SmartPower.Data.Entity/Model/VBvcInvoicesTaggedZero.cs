using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoicesTaggedZero
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public string ReadTypeCode { get; set; }
        public int SpinvNumber { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public bool? CreditInv { get; set; }
        public string SiteComments { get; set; }
        public string InvoiceComments { get; set; }
    }
}
