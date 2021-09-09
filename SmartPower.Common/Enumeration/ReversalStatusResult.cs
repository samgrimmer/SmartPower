using System.ComponentModel;

namespace SmartPower.Common.Enumeration
{
    public enum ReversalStatusResult
    {
        [Description("The original invoices exists")]
        Found,

        [Description("The readtypecode is either 'ORV' or 'RV', therefore it has already been reversed")]
        ReversalAlreadyExists,

        [Description("The supplied original invoice does not exist")]
        NotFound
    }
}
