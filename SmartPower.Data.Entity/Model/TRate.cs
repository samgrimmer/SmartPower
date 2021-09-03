using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TRate
    {
        public int RateId { get; set; }
        public string RetailerCode { get; set; }
        public string RateDescription { get; set; }
        public string RateCategory { get; set; }
        public string NetworkId { get; set; }
        public string InvoiceType { get; set; }
        public string UnitType { get; set; }
        public double? UnitCost { get; set; }
        public int? GreenhouseGasEmissions { get; set; }
        public int? Gstrate { get; set; }
        public string RateName { get; set; }
        public string RateFirstkWh { get; set; }
        public string RateSeason { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? RateClass { get; set; }
        public int? OrgId { get; set; }
        public byte[] SysRatesTimestamp { get; set; }
        public bool? PenaltyRate { get; set; }
        public double? MaxConsumption { get; set; }
        public string Status { get; set; }

        public virtual TRetailer RetailerCodeNavigation { get; set; }
    }
}
