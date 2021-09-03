using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvChecksMjToKwhTest
    {
        public int Spid { get; set; }
        public string Utility { get; set; }
        public int Spin { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public double CalculatedMj { get; set; }
        public string RatioMj { get; set; }
        public double? MjDifference { get; set; }
        public double CalculatedGj { get; set; }
        public string RatioGj { get; set; }
        public double? GjDifference { get; set; }
        public double? LinesMj { get; set; }
        public double? CalculatedKwh { get; set; }
        public double? HeaderKWh { get; set; }
        public double? Difference { get; set; }
    }
}
