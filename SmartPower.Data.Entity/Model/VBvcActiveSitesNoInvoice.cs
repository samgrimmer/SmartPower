﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcActiveSitesNoInvoice
    {
        public string ErrorDescription { get; set; }
        public int SiteNo { get; set; }
        public string SiteType { get; set; }
        public string RetailerCode { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteStatus { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? StartDate { get; set; }
        public string Comments { get; set; }
        public int? SpinvNumber { get; set; }
        public string SiteTypeSubCat { get; set; }
        public string ProductSubCat { get; set; }
        public bool? InvArchived { get; set; }
        public string ReadTypeCode { get; set; }
        public bool Managed { get; set; }
    }
}
