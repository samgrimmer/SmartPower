using System.ComponentModel.DataAnnotations;

namespace SmartPower.Common.Enumeration
{
    public enum AlertClass
    {
        [Display(Name = "success")]
        Success,

        [Display(Name = "danger")]
        Error
    }
}