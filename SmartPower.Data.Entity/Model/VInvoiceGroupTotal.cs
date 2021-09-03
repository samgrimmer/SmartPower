using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VInvoiceGroupTotal
    {
        public string SiteDescription { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string SiteName { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string MeterType { get; set; }
        public string ClientRef { get; set; }
        public string ClientCc { get; set; }
        public string NetworkId { get; set; }
        public decimal? SumOfInvSubTotal { get; set; }
        public double? SumOfUnitTotal { get; set; }
        public double? TotalConsumptionAll { get; set; }
    }
}
