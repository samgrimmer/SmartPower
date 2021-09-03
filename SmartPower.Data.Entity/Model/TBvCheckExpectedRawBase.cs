using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TBvCheckExpectedRawBase
    {
        public int ErId { get; set; }
        public int? ErSpinvNumber { get; set; }
        public int? ErBatchNo { get; set; }
        public int? ErSiteNo { get; set; }
        public short? ErInvNoOfDays { get; set; }
        public decimal? ErInvAmountToPay { get; set; }
        public string ErInvNotes { get; set; }
        public double? ErUnitTotal { get; set; }
        public DateTime? ErInvStartDate { get; set; }
        public string ErReadTypeCode { get; set; }
        public string ErAccountNo { get; set; }
        public int? ErSiteNoInvoices { get; set; }
        public string ErSiteDescription { get; set; }
        public string ErIcp { get; set; }
        public string ErClientRef { get; set; }
        public string ErComments { get; set; }
        public double? ErConsumptionVariance { get; set; }
    }
}
