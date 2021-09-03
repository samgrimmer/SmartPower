﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VTablesViewsInvoiceHeader
    {
        public int Spin { get; set; }
        public int Spib { get; set; }
        public int Spid { get; set; }
        public string Icp { get; set; }
        public string RetailerCode { get; set; }
        public string StatementNumber { get; set; }
        public string ParentAccNum { get; set; }
        public string AccountNo { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public string InvNumber { get; set; }
        public decimal? OpeningBalanceExGst { get; set; }
        public decimal? OpeningBalanceGst { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public string InvOpenBalType { get; set; }
        public bool? ObGst { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? InvGst { get; set; }
        public decimal? InvSubTotal { get; set; }
        public decimal? InvDiscountExGst { get; set; }
        public decimal? InvDiscountGst { get; set; }
        public decimal? InvDiscount { get; set; }
        public bool? PpdGst { get; set; }
        public bool? ApplySitePpd { get; set; }
        public decimal? InvAmountExGst { get; set; }
        public decimal? InvAmountGst { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPayExGst { get; set; }
        public decimal? InvAmountToPayGst { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public decimal? PdfInvAmountToPay { get; set; }
        public bool? ZeroDollars { get; set; }
        public string InvNotes { get; set; }
        public double? UnitTotal { get; set; }
        public bool? InvArchived { get; set; }
        public bool? IssuesToResolve { get; set; }
        public string TaxClass { get; set; }
        public bool Recharge { get; set; }
        public int? ParentSpin { get; set; }
        public string MeterType { get; set; }
    }
}
