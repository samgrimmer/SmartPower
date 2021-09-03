using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcMultipleInvoicesByBatchFinal
    {
        public string ErrorDescription { get; set; }
        public int BatchNo { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string SiteType { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime Date { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
    }
}
