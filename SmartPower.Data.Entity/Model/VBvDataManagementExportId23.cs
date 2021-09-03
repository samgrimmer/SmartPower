using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvDataManagementExportId23
    {
        public string SiteType { get; set; }
        public int Spid { get; set; }
        public int Spin { get; set; }
        public double? TInvoicesUnitTotal { get; set; }
        public double? CalculatedConsumption { get; set; }
        public double? Difference { get; set; }
        public string InvoiceComments { get; set; }
        public string SiteComments { get; set; }
        public int BatchNo { get; set; }
    }
}
