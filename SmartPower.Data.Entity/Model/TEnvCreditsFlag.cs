using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEnvCreditsFlag
    {
        public int ErCreditsFlagId { get; set; }
        public bool? ErCreditsToBeZeroed { get; set; }
    }
}
