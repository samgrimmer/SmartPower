using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartPower.Data.Entity.Repository
{
    public interface IBulkReversal
    {
        Task<List<Model.TReversalsBulkList>> GetReversalList(string userName);
        Task CreateReversalListItem(string userName, int orgSpinvNumber);
        Task ClearReversals(string userName);
        Task UpdateReversalStatus(string userName);
        Task<bool> TestSuppliedInvoices(string userName);
        Task<int> CreateReversals(string userName);
    }
}