using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoDaysMatchFinalOutput
    {
        public string ErrorDescription { get; set; }
        public int Spid { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int Spin { get; set; }
        public string ReadTypeCode { get; set; }
        public int? TariffId { get; set; }
        public short? HeaderNumberOfDays { get; set; }
        public double? LinesNumberOfDays { get; set; }
        public double? CalculatedLinesNumberOfDays { get; set; }
        public double? SplitValue { get; set; }
        public string SiteComments { get; set; }
        public string DataEntryNotes { get; set; }
        public int BatchNo { get; set; }
        public double? Test2 { get; set; }
    }
}
