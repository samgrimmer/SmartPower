using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartPower.Domain.Service
{
    public interface IBulkReversal
    {
        Task<List<Data.Entity.Model.TReversalsBulkList>> GetReversalList(string userName);
        Task CreateReversal(string userName, int orgSpinvNumber);
        Task<bool> ValidatePendingReversals(string userName);
        Task<int> CreateReversals(string userName);
        Task<string> ReversalListStringExport(string userName);
        Task ClearReversals(string userName);
    }
}