using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcMultipleInvBatch
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
    }
}
