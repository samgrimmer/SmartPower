using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcSplitInvoicesByBatch
    {
        public int SplitId { get; set; }
        public string SplitClientCode { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public string SplitAccountPostFix { get; set; }
        public int? SplitParentSite { get; set; }
        public string ChildSiteAccount { get; set; }
        public string AccountNo { get; set; }
        public int BatchNo { get; set; }
        public bool? ReadyForUpload { get; set; }
        public double? SplitSubTotal { get; set; }
        public double? SumOfSplitValue { get; set; }
        public string SiteSplitError { get; set; }
        public string SiteFixError { get; set; }
        public int? SiteNo { get; set; }
        public string SiteExitsError { get; set; }
        public string SiteCreateError { get; set; }
        public int? NewInvoice { get; set; }
        public short? InvNoOfDays { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
    }
}
