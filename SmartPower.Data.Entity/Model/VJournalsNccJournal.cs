using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VJournalsNccJournal
    {
        public int InvNo { get; set; }
        public string Supplier { get; set; }
        public string Company { get; set; }
        public string BusinessUnit { get; set; }
        public string Object { get; set; }
        public string Subsidiary { get; set; }
        public double? Amount { get; set; }
        public string Remark { get; set; }
        public string Subledgertype { get; set; }
        public string Subledger { get; set; }
        public string AssetId { get; set; }
        public string Approved { get; set; }
        public string Uom { get; set; }
        public string Additionalcodetype1 { get; set; }
        public string Additionalcodetype2 { get; set; }
        public string Additionalcodetype3 { get; set; }
        public string Additionalcodetype4 { get; set; }
        public string Codevalue1 { get; set; }
        public string Codevalue2 { get; set; }
        public string Codevalue3 { get; set; }
        public string Codevalue4 { get; set; }
        public string Recoverable { get; set; }
        public string Leasenumber { get; set; }
        public string Unitnumber { get; set; }
        public string Suppliercontract { get; set; }
        public string RetailerRef { get; set; }
    }
}
