﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VLastInvToDateSub
    {
        public DateTime? MaxOfInvStartDate { get; set; }
        public DateTime? MaxOfInvEndDate { get; set; }
        public int SiteNo { get; set; }
    }
}
