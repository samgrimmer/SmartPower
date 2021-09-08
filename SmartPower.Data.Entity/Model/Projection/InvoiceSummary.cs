using System;

namespace SmartPower.Data.Entity.Model.Projection
{
    public class InvoiceSummary
    {
        public string InvNumber { get; set; }
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
    }
}
