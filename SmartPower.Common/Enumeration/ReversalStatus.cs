using System.ComponentModel;

namespace SmartPower.Common.Enumeration
{
    public enum ReversalStatus
    {
        [Description("Found Invoice")]
        Found,

        [Description("Reversal Already Exists")]
        ReversalAlreadyExists,

        [Description("Not Found")]
        NotFound
    }
}