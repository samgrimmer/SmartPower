using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckInvoiceNoDaysHeaderVsDate
    {
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string UnitType { get; set; }
        public int? CorrectUnits { get; set; }
        public float? Multiplier { get; set; }
        public short? InvNoOfDays { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public int? Difference { get; set; }
        public int Spil { get; set; }
    }
}
