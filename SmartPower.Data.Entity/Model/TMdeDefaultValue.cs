using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TMdeDefaultValue
    {
        public int MdeDefaultId { get; set; }
        public int? Spib { get; set; }
        public string RetailerCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public string ReadTypeCode { get; set; }
    }
}
