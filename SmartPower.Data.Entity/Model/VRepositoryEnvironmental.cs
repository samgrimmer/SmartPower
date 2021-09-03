using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VRepositoryEnvironmental
    {
        public int Spid { get; set; }
        public string Region { get; set; }
        public string SiteStatus { get; set; }
        public double? GreenEnergyPercentage { get; set; }
        public int Spin { get; set; }
        public string ReadTypeCode { get; set; }
        public bool? CreditInv { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? InvEndDate { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? InvAmountToPay { get; set; }
        public double? UnitTotal { get; set; }
        public double? CalculatedSolarEnergyKWh { get; set; }
        public double? CalculatedSolarEnergy { get; set; }
        public double? CalculatedGreenEnergyKWh { get; set; }
        public double? CalculatedGreenEnergy { get; set; }
    }
}
