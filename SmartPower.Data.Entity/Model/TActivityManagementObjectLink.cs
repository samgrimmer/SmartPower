using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TActivityManagementObjectLink
    {
        public int AmLinkedId { get; set; }
        public int? AmId { get; set; }
        public int? AmObjectTypeId { get; set; }
        public int? AmObjectTypeReferenceId { get; set; }
        public DateTime? AmObjectLinkedDate { get; set; }
        public string AmObjectLinkedDescription { get; set; }
    }
}
