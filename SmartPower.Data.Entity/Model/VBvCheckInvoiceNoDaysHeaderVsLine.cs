using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckInvoiceNoDaysHeaderVsLine
    {
        public int? TariffId { get; set; }
        public double? SumofUnitsUsed2 { get; set; }
        public double? CheckingSum { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int? CorrectUnits { get; set; }
        public float? Multiplier { get; set; }
        public double? SumOfDaysWhenUnitsDevidedByMultiplier { get; set; }
        public double? SumOfUnitsUsed { get; set; }
        public short? InvNoOfDays { get; set; }
        public double? Difference { get; set; }
        public string UnitType { get; set; }
        public int? RateId { get; set; }
    }
}
