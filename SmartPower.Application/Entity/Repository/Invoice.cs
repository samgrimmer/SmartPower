using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPower.Application.Entity.Model.Projection;

namespace SmartPower.Application.Entity.Repository
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

        public async Task<List<InvoiceSummary>> GetInvoices(List<int> spInvoiceNumbers)
        {
            return await _dbContext.TInvoices
                .AsNoTracking()
                    .Where(i => spInvoiceNumbers.Contains(i.SpinvNumber))
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
                        .ToListAsync();
        }
    }
}
