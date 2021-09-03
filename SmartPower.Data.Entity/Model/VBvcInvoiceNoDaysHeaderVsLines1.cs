using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysHeaderVsLines1
    {
        public int SiteNo { get; set; }
        public int? CountSpin { get; set; }
        public int SpinvNumber { get; set; }
        public double? CheckSum { get; set; }
        public int BatchNo { get; set; }
        public int? TariffId { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int? CorrectUnits { get; set; }
        public float? Multiplier { get; set; }
        public short? InvNoOfDays { get; set; }
        public string UnitType { get; set; }
    }
}
