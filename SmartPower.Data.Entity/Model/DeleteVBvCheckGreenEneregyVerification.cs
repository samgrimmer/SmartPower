using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckGreenEneregyVerification
    {
        public int Spid { get; set; }
        public string Utility { get; set; }
        public string MeterType { get; set; }
        public double? GreenEnergy { get; set; }
        public double? CalculatedGreenConsumption { get; set; }
        public int Spin { get; set; }
        public double? TotalConsumption { get; set; }
        public double? GreenConsumption { get; set; }
        public double? Difference { get; set; }
        public string SiteComments { get; set; }
        public string InvoiceNotes { get; set; }
        public int BatchNo { get; set; }
    }
}
