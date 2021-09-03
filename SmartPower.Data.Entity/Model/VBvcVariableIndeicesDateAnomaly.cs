using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcVariableIndeicesDateAnomaly
    {
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public int? Rank1 { get; set; }
        public int? Rank2 { get; set; }
        public int? SiteNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate2 { get; set; }
        public DateTime? EndDate2 { get; set; }
        public string IndexType { get; set; }
        public string IndexType2 { get; set; }
        public float? Value { get; set; }
        public float? Value2 { get; set; }
    }
}
