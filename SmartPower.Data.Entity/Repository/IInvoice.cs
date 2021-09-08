using System.Threading.Tasks;
using SmartPower.Data.Entity.Model.Projection;

namespace SmartPower.Data.Entity.Repository
{
    public interface IInvoice
    {
        Task<InvoiceSummary> GetInvoice(int spInvoiceNumber);
    }
}