using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCeasedSite
    {
        public string ErrorDescription { get; set; }
        public string RetailerName { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? AmountToPay { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public DateTime? DateCeased { get; set; }
        public string SiteStatus { get; set; }
    }
}
