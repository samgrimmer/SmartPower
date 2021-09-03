using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportCatLine
    {
        public int CatId { get; set; }
        public int? HeaderId { get; set; }
        public string CatChargeDescription { get; set; }
    }
}
