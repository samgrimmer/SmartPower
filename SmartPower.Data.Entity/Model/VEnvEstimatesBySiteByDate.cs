﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvEstimatesBySiteByDate
    {
        public int? EsSiteId { get; set; }
        public DateTime? DataDate { get; set; }
        public string EsSourceType { get; set; }
    }
}
