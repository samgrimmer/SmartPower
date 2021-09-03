using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TActivityManagementAction
    {
        public int AmActionId { get; set; }
        public int? AmFuntionTypeId { get; set; }
        public int AmId { get; set; }
        public DateTime AmActionDate { get; set; }
        public string AmActionedBy { get; set; }
        public string AmComment { get; set; }
        public int? AmActionTypeId { get; set; }

        public virtual TActivityManagement Am { get; set; }
    }
}
