using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TOutage
    {
        public int OutageId { get; set; }
        public int? SiteNo { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string NetworkReference { get; set; }
        public string ClientOutageId { get; set; }
        public string OutageType { get; set; }
        public string Reason { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string CancellationComments { get; set; }
        public DateTime? StartDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? AlternateSartDate { get; set; }
        public TimeSpan? AlternateStartTime { get; set; }
        public TimeSpan? AlternateEndTime { get; set; }
        public string Comments { get; set; }

        public virtual TSite SiteNoNavigation { get; set; }
    }
}
