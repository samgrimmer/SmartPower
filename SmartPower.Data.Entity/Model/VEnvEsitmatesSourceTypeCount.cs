﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VEnvEsitmatesSourceTypeCount
    {
        public int? EsSiteId { get; set; }
        public int? EsDay { get; set; }
        public int? EsMonth { get; set; }
        public int? EsYear { get; set; }
        public int? CountOfSource { get; set; }
    }
}
