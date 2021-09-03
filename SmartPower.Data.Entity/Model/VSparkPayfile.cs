using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSparkPayfile
    {
        public string AccountNo { get; set; }
        public string MeterType { get; set; }
        public string InvNumber { get; set; }
        public string Blank1 { get; set; }
        public string Description { get; set; }
        public string ClientRef { get; set; }
        public string Gl { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string Blanks2 { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvOpeningBalance { get; set; }
    }
}
