using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvChecksSplitsUndeletedCheck
    {
        public int SplitId { get; set; }
        public string SplitClientCode { get; set; }
        public int SpinvNumber { get; set; }
        public string InvNumber { get; set; }
        public int? SplitAccountPostFix { get; set; }
        public int? SplitParentSite { get; set; }
        public int? SplitChildSite { get; set; }
        public string ChildSiteAccount { get; set; }
        public string AccountNo { get; set; }
        public int BatchNo { get; set; }
        public double? SplitSubTotal { get; set; }
        public int SiteNo { get; set; }
        public int? NewInvoice { get; set; }
        public short? InvNoOfDays { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public DateTime? InvDueDate { get; set; }
        public int? ParentSpin { get; set; }
        public double? SplitTotal { get; set; }
        public string SiteSplitError { get; set; }
        public string SiteFixError { get; set; }
        public string SiteExistsError { get; set; }
        public string SiteCreateError { get; set; }
        public bool? ReadyForUpload { get; set; }
        public string NewInvoiceNo { get; set; }
    }
}
