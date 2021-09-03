using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VGepGroupedReconciliationInfoFinal
    {
        public string RetailerCode { get; set; }
        public string ProductSubCat { get; set; }
        public string MeterType { get; set; }
        public double? Consumption { get; set; }
    }
}
