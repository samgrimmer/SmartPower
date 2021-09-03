using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportMeridianSummary
    {
        public int? HeaderId { get; set; }
        public string CustCode { get; set; }
        public string Statementnumber { get; set; }
        public string Invoicenumber { get; set; }
        public double? Openingbalance { get; set; }
        public double? Othertransactions { get; set; }
        public double? Currentcharges { get; set; }
        public double? Promptpaymentdis { get; set; }
        public double? Totaldue { get; set; }
        public double? Distotaldue { get; set; }
        public string InternalInvoiceNumbers { get; set; }
    }
}
