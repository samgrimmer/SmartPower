﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcChecksSplitSiteStatusMismatch
    {
        public int SiteNo { get; set; }
        public string SiteStatus { get; set; }
        public string SplitStatus { get; set; }
    }
}
