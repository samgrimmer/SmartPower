using System.Collections.Generic;
using System.Threading.Tasks;
using SmartPower.Application.Entity.Model.Projection;

namespace SmartPower.Application.Entity.Repository
{
    public interface IBulkReversal
    {
        Task<List<BulkReversalSummary>> GetBulkReversals(string userName);
        Task CreateReversalListItem(string userName, int orgSpinvNumber);
        Task ClearReversals(string userName);
        Task UpdateReversalStatus(string userName);
        Task<bool> TestSuppliedInvoices(string userName);
        Task<int> CreateReversals(string userName);
    }
}