using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckReadingNilRev
    {
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public string InputTypeCode { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public DateTime? InvStartDate { get; set; }
    }
}
