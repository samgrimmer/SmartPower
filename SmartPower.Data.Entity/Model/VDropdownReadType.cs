using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VDropdownReadType
    {
        public string ReadTypeCode { get; set; }
        public string ReadTypeCalc { get; set; }
        public bool? Estimate { get; set; }
    }
}
