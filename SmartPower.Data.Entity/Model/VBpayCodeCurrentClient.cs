using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBpayCodeCurrentClient
    {
        public int BpayId { get; set; }
        public string ClientCode { get; set; }
        public string RetailerCode { get; set; }
        public string BpayCode { get; set; }
    }
}
