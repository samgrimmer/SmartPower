using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TEdiLookupSiteType
    {
        public int EdiLSiteTypeId { get; set; }
        public string EdiLProductId { get; set; }
        public string EdiLProductSubCatCode { get; set; }
        public string EdiLUserName { get; set; }
    }
}
