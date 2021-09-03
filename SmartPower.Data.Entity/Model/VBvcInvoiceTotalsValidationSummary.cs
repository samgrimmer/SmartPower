using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceTotalsValidationSummary
    {
        public string ErrorDescription { get; set; }
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public decimal? Test1ObExGst { get; set; }
        public decimal? Test2ObGst { get; set; }
        public decimal? Test3LineTotalExGst { get; set; }
        public decimal? Test4LineTotalGst { get; set; }
        public decimal? Test5LineTotalInclGst { get; set; }
        public decimal? Test6PpdExGst { get; set; }
        public decimal? Test7PpdGst { get; set; }
        public decimal? Test8PpdInclGst { get; set; }
        public decimal? Test9InvTotalExGst { get; set; }
        public decimal? Test10InvTotalGst { get; set; }
        public decimal? Test11InvTotalInclGst { get; set; }
        public decimal? Test12AmountToPayExGst { get; set; }
        public decimal? Test13AmountToPayGst { get; set; }
        public decimal? Test14AmountToPayInclGst { get; set; }
        public string InvNotes { get; set; }
    }
}
