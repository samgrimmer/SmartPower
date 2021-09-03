using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSumInvTotalsValidationChkSummary
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string InvNotes { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string Test1ObExgst { get; set; }
        public double? Test2Obgst { get; set; }
        public double? Test3LineTotalExGst { get; set; }
        public double? Test4LineTotalGst { get; set; }
        public decimal? Test5SubTotal { get; set; }
        public double? Test6 { get; set; }
        public decimal? Test7 { get; set; }
        public decimal? Test8CurrentChargesExGst { get; set; }
        public decimal? Test9CurrentChargesGst { get; set; }
        public decimal? Test10CurrentChargesInclGst { get; set; }
        public decimal? Test11AmtToPayExGst { get; set; }
        public decimal? Test12AmountToPayGst { get; set; }
        public decimal? Test13AmtToPayInclGst { get; set; }
    }
}
