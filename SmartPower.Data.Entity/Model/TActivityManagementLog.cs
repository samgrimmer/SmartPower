using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TActivityManagementLog
    {
        public DateTime AmLogDate { get; set; }
        public int? AmId { get; set; }
        public int? AmFuntionTypeId { get; set; }
        public string AmClientCode { get; set; }
        public DateTime? AmDateEntered { get; set; }
        public DateTime? AmDateClosed { get; set; }
        public DateTime? AmDateReminder { get; set; }
        public string AmEnteredBy { get; set; }
        public int? AmClass { get; set; }
        public int? AmCat { get; set; }
        public int? AmSubCat { get; set; }
        public string AmDescription { get; set; }
        public int? AmStatus { get; set; }
        public string AmAction { get; set; }
        public int? AmOutcomeType { get; set; }
        public int? AmSiteId { get; set; }
        public int? AmInvId { get; set; }
        public int? AmBatchId { get; set; }
        public int? AmType { get; set; }
        public string AmComments { get; set; }
        public decimal? AmSavingsDollars { get; set; }
        public double? AmSavingsKwh { get; set; }
        public int? AmManagedBy { get; set; }
        public string AmRetailCode { get; set; }
        public string AmClientContact { get; set; }
        public byte[] AmSysTimestamp { get; set; }
        public bool? AmAchieved { get; set; }
        public string AmOverview { get; set; }
        public bool? AmPendingSavings { get; set; }
    }
}
