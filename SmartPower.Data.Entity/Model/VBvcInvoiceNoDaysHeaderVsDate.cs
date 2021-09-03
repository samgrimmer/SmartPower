using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysHeaderVsDate
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int Spin { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? HeaderNoDays { get; set; }
        public int? CalculatedNoDays { get; set; }
        public int? Difference { get; set; }
    }
}
