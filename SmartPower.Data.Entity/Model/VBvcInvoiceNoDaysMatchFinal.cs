using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysMatchFinal
    {
        public string ErrorDescription { get; set; }
        public string InvNotes { get; set; }
        public string RetailerCode { get; set; }
        public int Spid { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int Spin { get; set; }
        public string UnitType { get; set; }
        public int? HeaderCorrectUnits { get; set; }
        public double? CheckSumDaysWhenUnitsDividedByMultiplierFromTariff { get; set; }
        public short? InvNoOfDays { get; set; }
        public int? TariffId { get; set; }
        public string SiteComments { get; set; }
        public string DataEntryNotes { get; set; }
        public double DaysUsedInLines { get; set; }
        public double? Expr1 { get; set; }
        public double SplitValue { get; set; }
        public double? LinesCorrectUnits { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
