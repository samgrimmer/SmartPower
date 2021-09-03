using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcHeaderConsumptionIsZero
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public string Utility { get; set; }
        public string RetailerCode { get; set; }
        public string MeterType { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public int? DoLinesHaveRateUnitCodedConsumption { get; set; }
        public double? LinesUnits { get; set; }
        public double? HeaderUnits { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public string ReadTypeCode { get; set; }
        public bool? Vacant { get; set; }
        public string InvNotes { get; set; }
        public string SiteComments { get; set; }
        public int? NoOfDaysOfZeroConsumption { get; set; }
        public int? MaxSpinno { get; set; }
    }
}
