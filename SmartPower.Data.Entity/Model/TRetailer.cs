using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TRetailer
    {
        public TRetailer()
        {
            TInvoices = new HashSet<TInvoice>();
            TSites = new HashSet<TSite>();
        }

        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public bool? Exclude { get; set; }
        public byte[] SysRetailersTimestamp { get; set; }
        public string RetailerRef { get; set; }
        public string AccountNo { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string ClientSupplierCode { get; set; }

        public virtual ICollection<TInvoice> TInvoices { get; set; }
        public virtual ICollection<TSite> TSites { get; set; }
    }
}
