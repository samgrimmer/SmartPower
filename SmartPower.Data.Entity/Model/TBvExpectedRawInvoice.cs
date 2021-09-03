using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvExpectedRawInvoice
    {
        public int SpinvNumber { get; set; }
        public int? SiteNo { get; set; }
        public int? BatchNo { get; set; }
        public int? InvNoOfDays { get; set; }
        public double? InvoicedkWh { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string InvNotes { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
