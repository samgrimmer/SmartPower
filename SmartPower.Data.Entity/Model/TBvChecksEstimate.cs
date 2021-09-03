using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvChecksEstimate
    {
        public int EsId { get; set; }
        public int? EsSiteId { get; set; }
        public int? EsEstimateCount { get; set; }
        public DateTime? EsLastactualReadDate { get; set; }
        public bool? EsHadActaulRead { get; set; }
        public byte[] SysEstimatesTimestamp { get; set; }
    }
}
