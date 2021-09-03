using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckNullValueInvoiceLinesMeterReadingfield
    {
        public int InvLineNo { get; set; }
        public int? SpinvNumber { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public float? Multiplier { get; set; }
        public int BatchNo { get; set; }
        public int SiteNo { get; set; }
    }
}
