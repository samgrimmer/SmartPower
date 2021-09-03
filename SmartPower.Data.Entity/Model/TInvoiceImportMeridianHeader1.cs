using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportMeridianHeader1
    {
        public int? HeaderId { get; set; }
        public string CustCode { get; set; }
        public string Sitedescription { get; set; }
        public string Siteaddress1 { get; set; }
        public string Siteaddress2 { get; set; }
        public string Retailercode { get; set; }
        public string Customerno { get; set; }
        public string Accountno { get; set; }
        public string Readtype { get; set; }
        public string Invoicenumber { get; set; }
        public double? Internalinvoicenumber { get; set; }
        public string Statementnumber { get; set; }
        public DateTime? Invoicedate { get; set; }
        public double? Statementopeningbalance { get; set; }
        public double? Reversals { get; set; }
        public DateTime? Invoicestartdate { get; set; }
        public DateTime? Invoiceenddate { get; set; }
        public double? Totalconsumption { get; set; }
        public DateTime? Duedate { get; set; }
        public double? Invoicenoofdays { get; set; }
        public double? Spotrate { get; set; }
        public double? Othertransactions { get; set; }
        public double? Invoicesubtotal { get; set; }
        public double? Invoicetotal { get; set; }
        public double? Invoicegst { get; set; }
        public double? Invoicediscount { get; set; }
        public double? Invoicediscountpercent { get; set; }
        public double? Invoicecurrentcharges { get; set; }
        public string Invoicetype { get; set; }
        public string Invoicenotes { get; set; }
        public string Icp { get; set; }
        public string Gxp { get; set; }
        public string Lossrate { get; set; }
        public string Losspercentage { get; set; }
        public double? DiscountGranted { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
