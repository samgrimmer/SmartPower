using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VTariffsDuplicationTest
    {
        public int SiteNo { get; set; }
        public int RateId { get; set; }
        public string TariffDescription { get; set; }
        public int? CountOccurence { get; set; }
    }
}
