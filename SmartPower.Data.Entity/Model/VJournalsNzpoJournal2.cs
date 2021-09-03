using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsNzpoJournal2
    {
        public string CompanyCode { get; set; }
        public string CreditorCode { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartDate { get; set; }
        public string InvReference { get; set; }
        public string InvDescription { get; set; }
        public string AccountCode { get; set; }
        public string PropertyCode { get; set; }
        public string ManualCode { get; set; }
        public string BusinessUnitCode { get; set; }
        public string AssetCode { get; set; }
        public string LineItemDescription { get; set; }
        public double? InvoicedKwh { get; set; }
        public decimal? Amount { get; set; }
        public string ExcludeFromRecharge { get; set; }
    }
}
