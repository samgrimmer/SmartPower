using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysMatchSplitLookup
    {
        public int InvoiceSpid { get; set; }
        public int? ChildSpid { get; set; }
        public int? ParentSpid { get; set; }
        public int SpidToTariff { get; set; }
        public double SplitValue { get; set; }
        public string SplitType { get; set; }
    }
}
