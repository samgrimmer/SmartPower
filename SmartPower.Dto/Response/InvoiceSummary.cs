using System;

namespace SmartPower.Dto.Response
{
    public class InvoiceSummary
    {
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
    }
}
