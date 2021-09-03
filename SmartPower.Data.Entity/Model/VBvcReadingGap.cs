using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcReadingGap
    {
        public long? Rank1 { get; set; }
        public long? Rank2 { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public int BatchNo { get; set; }
        public int? Spin { get; set; }
        public int? PreviousSpin { get; set; }
        public int Spil { get; set; }
        public int PreviousSpil { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public double? PrevCurrReading { get; set; }
        public double? Difference { get; set; }
        public string InvNotes { get; set; }
        public string PrevInvNotes { get; set; }
        public int? TariffId { get; set; }
        public int? PrevTariffId { get; set; }
        public string ProductId { get; set; }
        public string UnitType { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? PrevInvStartDate { get; set; }
        public string RetailerName { get; set; }
        public string Icp { get; set; }
        public string MeterNo { get; set; }
        public string SiteNotes { get; set; }
    }
}
