using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsWpacJournal
    {
        public int Batch { get; set; }
        public int ItemNumber { get; set; }
        public string Supplier { get; set; }
        public string Wp { get; set; }
        public string Site { get; set; }
        public string Energy { get; set; }
        public string Invoice { get; set; }
        public string Meter { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public short? Days { get; set; }
        public double? Kwh { get; set; }
        public decimal? InvoiceAmountInclGst { get; set; }
        public decimal? Discount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string InvOpenBalType { get; set; }
    }
}
