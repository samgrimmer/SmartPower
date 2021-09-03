using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class TContact
    {
        public TContact()
        {
            TContactsSites = new HashSet<TContactsSite>();
        }

        public int ContactId { get; set; }
        public string ContactNameFirst { get; set; }
        public string ContactNameLast { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone1 { get; set; }
        public string ContactPhone2 { get; set; }
        public string ContactRole { get; set; }
        public string ContactAddPhysical { get; set; }
        public string ContactAddPostal { get; set; }
        public string ContactAddComments { get; set; }
        public string ContactCompanyName { get; set; }
        public byte[] SysSitesContactTimestamp { get; set; }
        public bool? Active { get; set; }
        public string Salutation { get; set; }

        public virtual ICollection<TContactsSite> TContactsSites { get; set; }
    }
}
