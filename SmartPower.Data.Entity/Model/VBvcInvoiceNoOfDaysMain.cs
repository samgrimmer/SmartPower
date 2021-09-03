﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcInvoiceNoOfDaysMain
    {
        public string ErrorDescription { get; set; }
        public string RetailerCode { get; set; }
        public int SiteNo { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public int BatchNo { get; set; }
        public int SpinvNumber { get; set; }
        public string UnitType { get; set; }
        public int? CorrectUnits { get; set; }
        public double? CheckSum { get; set; }
        public short? InvNoOfDays { get; set; }
        public int? TariffId { get; set; }
        public string SiteComments { get; set; }
        public string DataEntryNotes { get; set; }
    }
}
