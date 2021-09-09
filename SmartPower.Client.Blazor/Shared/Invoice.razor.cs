using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components;

namespace SmartPower.Client.Blazor.Shared
{
    public partial class Invoice
    {
        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public Application.Entity.Repository.IInvoice InvoiceRepository { get; set; }

        [Parameter]
        public List<int> InvoiceIds { get; set; }

        public List<Dto.Response.InvoiceSummary> InvoiceSummaryList { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if (InvoiceIds != null)
            {
                var invoices = await InvoiceRepository.GetInvoices(InvoiceIds);

                InvoiceSummaryList = Mapper.Map<List<Dto.Response.InvoiceSummary>>(invoices);
            }
        }
    }
}