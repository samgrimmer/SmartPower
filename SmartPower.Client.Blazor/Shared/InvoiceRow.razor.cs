using Microsoft.AspNetCore.Components;
using SmartPower.Dto.Response;

namespace SmartPower.Client.Blazor.Shared
{
    public partial class InvoiceRow
    {
        [Parameter]
        public InvoiceSummary InvoiceSummary { get; set; }
    }
}
