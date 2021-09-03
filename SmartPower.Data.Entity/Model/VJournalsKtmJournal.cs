using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsKtmJournal
    {
        public int BatchNumber { get; set; }
        public int SpInvNumber { get; set; }
        public string Supplier { get; set; }
        public string Icp { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? LastActualReadDate { get; set; }
        public string ClientCc { get; set; }
        public string Site { get; set; }
        public string EnergyNo { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public short? NoOfDays { get; set; }
        public double? Kwh { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? InvTotalInclGst { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetInclGst { get; set; }
        public double? NetExclGst { get; set; }
        public double? Gst { get; set; }
        public DateTime? InvDueDate { get; set; }
    }
}
