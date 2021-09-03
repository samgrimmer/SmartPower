using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckReadingGapsSubOld
    {
        public long? RowNum { get; set; }
        public long? Rank1 { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public int? TariffId { get; set; }
        public string AccountNo { get; set; }
        public string InvNotes { get; set; }
        public string ProductId { get; set; }
        public string UnitType { get; set; }
        public DateTime? InvStartDate { get; set; }
        public string RetailerCode { get; set; }
        public string MeterNo { get; set; }
    }
}
