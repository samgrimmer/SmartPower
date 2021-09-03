using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TInvoiceImportMeridianLine
    {
        public int MeridianId { get; set; }
        public int? HeaderId { get; set; }
        public string CustCode { get; set; }
        public string Invoicelinenumber { get; set; }
        public double? Accountno { get; set; }
        public string Invoicenumber { get; set; }
        public string Linedescription { get; set; }
        public double? Prevreading { get; set; }
        public double? Currreading { get; set; }
        public double? Consumptionused { get; set; }
        public double? Unitcost { get; set; }
        public double? Multiplier { get; set; }
        public double? Invoicelinetotal { get; set; }
        public string Utilitytype { get; set; }
        public string Unittype { get; set; }
        public string Metered { get; set; }
        public string Tariffid { get; set; }
        public string Siteid { get; set; }
        public string Meterno { get; set; }
        public string Icp { get; set; }
        public string Readtype { get; set; }
        public string Linetype { get; set; }
        public DateTime? Invoicedate { get; set; }
        public int? InternalInvoiceNumber { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
