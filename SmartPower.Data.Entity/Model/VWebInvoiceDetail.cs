using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VWebInvoiceDetail
    {
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public int SiteNo { get; set; }
        public string ClientRef { get; set; }
        public int SpinvNumber { get; set; }
        public int InvLineNo { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public double? UnitTotal { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvDiscount { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string InvNotes { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrReading { get; set; }
        public double? UnitsUsed { get; set; }
        public double? UnitCost { get; set; }
        public float? Multiplier { get; set; }
        public double? InvLineTotal { get; set; }
        public string ProductId { get; set; }
        public string UnitType { get; set; }
    }
}
