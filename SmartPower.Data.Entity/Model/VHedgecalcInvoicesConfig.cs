using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VHedgecalcInvoicesConfig
    {
        public int? BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string ReadTypeCode { get; set; }
        public string InvNumber { get; set; }
        public bool? Selected { get; set; }
        public int Spin { get; set; }
        public double? UnitTotal { get; set; }
        public string MeterType { get; set; }
        public string SiteName { get; set; }
    }
}
