using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcDateGapMain
    {
        public string ErrorDescription { get; set; }
        public int? SiteNo { get; set; }
        public string SiteStatus { get; set; }
        public string SpidRetailer { get; set; }
        public string SpidAccountNumber { get; set; }
        public string IcpMni { get; set; }
        public string SpinRetailerCode { get; set; }
        public string SpinAccountNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? NextStartDate { get; set; }
        public string DateGapFound { get; set; }
        public int? DgDateGap { get; set; }
        public int? BatchNo { get; set; }
        public int? SpinvNumber { get; set; }
        public int? NextInvoice { get; set; }
        public int? DgNextBachNo { get; set; }
        public string InvNotes { get; set; }
        public DateTime? DgLastEnd { get; set; }
        public int? DgLastInvoice { get; set; }
        public string ReadTypeCode { get; set; }
        public string RelationshipManager { get; set; }
        public string AccountManager { get; set; }
        public bool? InvArchived { get; set; }
        public string SiteType { get; set; }
        public string DgSiteType { get; set; }
    }
}
