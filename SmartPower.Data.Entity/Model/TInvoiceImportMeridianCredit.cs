using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportMeridianCredit
    {
        public int? HeaderId { get; set; }
        public string CustCode { get; set; }
        public string Statementnumber { get; set; }
        public string Invoicenumber { get; set; }
        public double? AccountNumber { get; set; }
        public string Description { get; set; }
        public double? Amountincgst { get; set; }
        public double? Gst { get; set; }
        public double? Test { get; set; }
    }
}
