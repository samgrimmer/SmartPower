using System.Threading.Tasks;
using SmartPower.Application.Entity.Model.Projection;

namespace SmartPower.Application.Entity.Repository
{
    public interface IInvoice
    {
        Task<InvoiceSummary> GetInvoice(int spInvoiceNumber);
    }
}