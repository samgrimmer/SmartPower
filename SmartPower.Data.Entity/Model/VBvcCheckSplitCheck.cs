using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VBvcCheckSplitCheck
    {
        public string RetailerCode { get; set; }
        public int? SplitParentSite { get; set; }
        public string AccountNo { get; set; }
        public string Icp { get; set; }
        public double? SumOfSplitShouldEqual1 { get; set; }
    }
}
