using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcRepBatch
    {
        public int BatchNo { get; set; }
        public string Supplier { get; set; }
        public string AccountNo { get; set; }
        public string Site { get; set; }
        public bool? CreditInv { get; set; }
        public decimal? NetInclGst { get; set; }
        public DateTime? InvDueDate { get; set; }
        public int Spno { get; set; }
        public int SiteNo { get; set; }
        public string Icp { get; set; }
        public double? Kwh { get; set; }
        public DateTime? InvDate { get; set; }
        public string InvNumber { get; set; }
        public string BpayCode { get; set; }
        public string BpayReference { get; set; }
    }
}
