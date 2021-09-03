using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsKtmReading
    {
        public DateTime? LastActualReadDate { get; set; }
        public string ReadTypeCode { get; set; }
        public int SiteNo { get; set; }
        public string Icp { get; set; }
    }
}
