using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components;

namespace SmartPower.Client.Blazor.Pages
{
    public partial class Invoice
    {
        [Inject] 
        public IMapper Mapper { get; set; }

        [Inject] 
        public SmartPower.Data.Entity.Repository.IInvoice InvoiceRepository { get; set; }

        [Parameter]
        public int SpInvoiceNumber { get; set; }

        public Dto.Response.InvoiceSummary InvoiceSummary { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            var invoice = await InvoiceRepository.GetInvoice(SpInvoiceNumber);

            InvoiceSummary = Mapper.Map<Dto.Response.InvoiceSummary>(invoice);
        }
    }
}
