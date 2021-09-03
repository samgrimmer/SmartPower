using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class DeleteVBvCheckBudegtGapsBaseSub
    {
        public int BatchNo { get; set; }
        public DateTime? BatchMonth { get; set; }
        public string UtilityCode { get; set; }
        public int? LenUtilityCode { get; set; }
    }
}
