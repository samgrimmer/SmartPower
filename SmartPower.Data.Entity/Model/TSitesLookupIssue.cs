using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TSitesLookupIssue
    {
        public int Id { get; set; }
        public int? EdiId { get; set; }
        public int? Spin { get; set; }
    }
}
