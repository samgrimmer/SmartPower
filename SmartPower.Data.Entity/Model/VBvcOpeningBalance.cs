using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcOpeningBalance
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string InvOpenBalType { get; set; }
        public decimal? InvOpeningBalance { get; set; }
        public string InvNotes { get; set; }
        public string Comments { get; set; }
        public DateTime? SpininvoiceDate { get; set; }
        public int? PreviousSpin { get; set; }
        public DateTime? PreviousSpindueDate { get; set; }
        public decimal? PreviousSpinamounttoPay { get; set; }
        public decimal? PreviousSpinamounttoPayPpd { get; set; }
        public decimal? PreviousSpinPpd { get; set; }
        public string RegistryNetwork { get; set; }
        public string RetailerCode { get; set; }
    }
}
