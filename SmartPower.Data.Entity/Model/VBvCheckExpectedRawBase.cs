using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckExpectedRawBase
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
        public short? InvNoOfDays { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string InvNotes { get; set; }
        public double? UnitTotal { get; set; }
        public DateTime? InvStartDate { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
