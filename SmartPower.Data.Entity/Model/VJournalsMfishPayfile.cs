using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsMfishPayfile
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string CostCentre { get; set; }
        public string NaturalAccount { get; set; }
        public string ActivityCode { get; set; }
        public double? ExGst { get; set; }
        public double? Gst { get; set; }
        public string AccountNo { get; set; }
        public string BuildingNo { get; set; }
        public string SiteName { get; set; }
        public int SiteNo { get; set; }
    }
}
