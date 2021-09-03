using System.ComponentModel.DataAnnotations;

namespace SmartPower.Common.Enumeration
{
    public enum ReversalStatusResult
    {
        [Display(Name = "The original invoices exists")]
        Found,

        [Display(Name = "The readtypecode is either 'ORV' or 'RV', therefore it has already been reversed")]
        ReversalAlreadyExists,

        [Display(Name = "The supplied original invoice does not exist")]
        NotFound
    }
}
