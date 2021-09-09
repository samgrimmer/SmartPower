using System.ComponentModel;

namespace SmartPower.Common.Enumeration
{
    public enum AlertClass
    {
        [Description("success")]
        Success,

        [Description("danger")]
        Error,

        [Description("warning")]
        Warning
    }
}