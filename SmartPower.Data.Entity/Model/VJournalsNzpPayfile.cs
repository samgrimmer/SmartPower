using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsNzpPayfile
    {
        public int BatchNo { get; set; }
        public string Nzpcostcentre { get; set; }
        public string Nzpsitecode { get; set; }
        public string RetailerName { get; set; }
        public string Consumer { get; set; }
        public string Icp { get; set; }
        public string Inv { get; set; }
        public string InvoiceCredit { get; set; }
        public string ReadTypeCode { get; set; }
        public string SiteDescription { get; set; }
        public string SiteLocation { get; set; }
        public string MeterType { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? TotalkWh { get; set; }
        public decimal? SubtotalinclGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmounttopayxGst { get; set; }
        public double? Gst { get; set; }
        public string AccountCode { get; set; }
        public DateTime? InvDate { get; set; }
    }
}
