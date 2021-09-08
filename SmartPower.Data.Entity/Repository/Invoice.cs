using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPower.Data.Entity.Model.Projection;

namespace SmartPower.Data.Entity.Repository
{
    public class Invoice : IInvoice
    {
        private readonly DbContext _dbContext;

        public Invoice(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<InvoiceSummary> GetInvoice(int spInvoiceNumber)
        {
            return await _dbContext.TInvoices
                .AsNoTracking()
                    .Select(s => new InvoiceSummary
                    {
                        SpinvNumber = s.SpinvNumber,
                        BatchNo = s.BatchNo,
                        InvEndDate = s.InvEndDate,
                        InvNumber = s.InvNumber,
                        InvOpeningBalance = s.InvOpeningBalance,
                        InvStartDate = s.InvStartDate,
                        RetailerCode = s.RetailerCode,
                        SiteNo = s.SiteNo
                    })
                    .SingleOrDefaultAsync(i => i.SpinvNumber == spInvoiceNumber);
        }
    }
}
