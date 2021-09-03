using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvSpinHedge
    {
        public int Spin { get; set; }
        public int? BatchNo { get; set; }
        public bool? Selected { get; set; }
    }
}
