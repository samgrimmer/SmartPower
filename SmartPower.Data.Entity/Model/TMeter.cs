using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TMeter
    {
        public int MeterId { get; set; }
        public int? SiteId { get; set; }
        public string MeterNo { get; set; }
        public string RegisterNo { get; set; }
        public string CustCode { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
        public int MeterIndex { get; set; }
        public int Multiplier { get; set; }
        public int? Dials { get; set; }
        public bool? Active { get; set; }
        public string MeterLocation { get; set; }
    }
}
