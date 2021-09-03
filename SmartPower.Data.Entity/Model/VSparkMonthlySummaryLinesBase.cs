﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VSparkMonthlySummaryLinesBase
    {
        public string MeterType { get; set; }
        public int BatchNo { get; set; }
        public double? BatchTotal { get; set; }
        public DateTime? BatchMonth { get; set; }
        public int? RateClass { get; set; }
        public string RateClass1 { get; set; }
        public double? InvLineTotal { get; set; }
    }
}
