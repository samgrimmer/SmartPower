using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsHdcPayfile
    {
        public int SpinvNumber { get; set; }
        public int BatchNo { get; set; }
        public string RetailerCode { get; set; }
        public string Description { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string Region2 { get; set; }
        public string ClientCc { get; set; }
        public string ClientRef { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? InvoicesKwh { get; set; }
        public decimal? InvAmtToPayInclGst { get; set; }
        public double? InvAmtToPayExclGst { get; set; }
        public double? Gst { get; set; }
        public string Active { get; set; }
    }
}
