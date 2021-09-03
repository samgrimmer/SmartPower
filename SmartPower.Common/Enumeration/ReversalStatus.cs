using System.ComponentModel.DataAnnotations;

namespace SmartPower.Common.Enumeration
{
    public enum ReversalStatus
    {
        [Display(Name = "Found")]
        Found,

        [Display(Name = "Reversal Already Exists")]
        ReversalAlreadyExists,

        [Display(Name = "Not Found")]
        NotFound
    }
}