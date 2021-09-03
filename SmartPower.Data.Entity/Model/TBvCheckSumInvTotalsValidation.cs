using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvCheckSumInvTotalsValidation
    {
        public int SpinvNumber { get; set; }
        public string RetailerCode { get; set; }
        public int? SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string InvNotes { get; set; }
        public int? BatchNo { get; set; }
        public float? Test1ObExgst { get; set; }
        public float? Test2Obgst { get; set; }
        public float? Test3LineTotalExGst { get; set; }
        public float? Test4LineTotalGst { get; set; }
        public float? Test5SubTotal { get; set; }
        public float? Test6 { get; set; }
        public float? Test7 { get; set; }
        public float? Test8CurrentChargesExGst { get; set; }
        public float? Test9CurrentChargesGst { get; set; }
        public float? Test10CurrentChargesInclGst { get; set; }
        public float? Test11AmtToPayExGst { get; set; }
        public float? Test12AmountToPayGst { get; set; }
        public float? Test13AmtToPayInclGst { get; set; }
    }
}
