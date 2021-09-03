using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvCheckHasActualRead
    {
        public int? EsSiteId { get; set; }
        public bool? Actual { get; set; }
    }
}
