﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCalcInvoiceFunctionSelect
    {
        public string ClientCode { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public float DiscountPc { get; set; }
        public decimal? CalcInvTotal { get; set; }
        public decimal? CalcInvGst { get; set; }
        public double? CalcInvSubTotal { get; set; }
        public decimal? CalcInvDiscountGst { get; set; }
        public decimal? CalcInvDiscountExGst { get; set; }
        public double? CalcInvDiscount { get; set; }
        public decimal? CalcInvAmountCalc { get; set; }
        public decimal? CalcInvAmount { get; set; }
        public decimal? CalcInvAmountToPay { get; set; }
        public decimal? CalcOpeningBalanceGst { get; set; }
        public decimal? CalcOpeningBalanceExGst { get; set; }
        public decimal? CalcInvAmountExGst { get; set; }
        public decimal? CalcInvAmountGst { get; set; }
        public decimal? CalcInvAmountToPayExGst { get; set; }
        public decimal? CalcInvAmountToPayGst { get; set; }
    }
}
