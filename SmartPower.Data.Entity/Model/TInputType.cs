using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInputType
    {
        public string InputTypeCode { get; set; }
        public string InputType { get; set; }
        public string CustomerNo { get; set; }
        public short? Itsort { get; set; }
        public string EnvType { get; set; }
    }
}
