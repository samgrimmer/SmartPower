using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsRepcoJournal
    {
        public int BatchNo { get; set; }
        public string SiteStatus { get; set; }
        public int Spno { get; set; }
        public string Supplier { get; set; }
        public string ClientRef { get; set; }
        public string AccNo { get; set; }
        public string Site { get; set; }
        public string EnergyNo { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string ReadTypeCode { get; set; }
        public short? NoDays { get; set; }
        public double? Kwh { get; set; }
        public decimal? OpeningBal { get; set; }
        public decimal? InvTotIncGst { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Net { get; set; }
        public DateTime? InvDueDate { get; set; }
    }
}
