using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckHeaderNonBlankField
    {
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int SiteNo { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string ReadTypeCode { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? InvEnteredDate { get; set; }
        public string InvNumber { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? UnitTotal { get; set; }
        public DateTime? InvDueDate { get; set; }
    }
}
