using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcTouInvoiceMonthFinal
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public string ReadTypeCode { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public string SiteType { get; set; }
        public string SiteTypeSubCat { get; set; }
        public int GetNotMonth { get; set; }
        public string ProductSubCat { get; set; }
        public DateTime? DateCeased { get; set; }
    }
}
