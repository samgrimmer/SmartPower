using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupStep2
    {
        public int BatchNo { get; set; }
        public string EdiIcp { get; set; }
        public string EdiRetailerCode { get; set; }
        public int? CountSpid { get; set; }
    }
}
