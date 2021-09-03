using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSitesLookupStep3
    {
        public int BatchNo { get; set; }
        public string EdiIcp { get; set; }
        public string EdiRetailerCode { get; set; }
        public string EdiAccountNo { get; set; }
        public int? CountSpid { get; set; }
    }
}
