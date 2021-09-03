using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TClient
    {
        public TClient()
        {
            TBatches = new HashSet<TBatch>();
            TCostCentres = new HashSet<TCostCentre>();
            TSites = new HashSet<TSite>();
        }

        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public double? ClientVariance { get; set; }

        public virtual ICollection<TBatch> TBatches { get; set; }
        public virtual ICollection<TCostCentre> TCostCentres { get; set; }
        public virtual ICollection<TSite> TSites { get; set; }
    }
}
