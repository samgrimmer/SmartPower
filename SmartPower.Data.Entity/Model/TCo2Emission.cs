using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TCo2Emission
    {
        public DateTime? Date { get; set; }
        public int? Factor { get; set; }
        public byte[] SysEmissionsTimestamp { get; set; }
    }
}
