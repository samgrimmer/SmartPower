using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEdiRateCat
    {
        public int CatId { get; set; }
        public string CatLineDescription { get; set; }
        public string CatCategory { get; set; }
        public int? CatRateClass { get; set; }
    }
}
