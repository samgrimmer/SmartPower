using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvDataManagementExportId30
    {
        public int SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public double? InvLineTotal { get; set; }
        public double? CalcLineTotalGst { get; set; }
        public double? CalcLineTotalIncGst { get; set; }
        public double? TaxRate { get; set; }
        public bool Gst { get; set; }
    }
}
