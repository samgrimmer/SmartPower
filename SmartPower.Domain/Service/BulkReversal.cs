using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartPower.Domain.Service
{
    public class BulkReversal : IBulkReversal
    {
        private readonly Data.Entity.Repository.IBulkReversal _bulkReversalRepository;

        public BulkReversal(Data.Entity.Repository.IBulkReversal bulkReversalRepository)
        {
            _bulkReversalRepository = bulkReversalRepository;
        }

        public async Task<List<Data.Entity.Model.TReversalsBulkList>> GetReversalList(string userName)
        {
            return await _bulkReversalRepository.GetReversalList(userName);
        }

        public async Task CreateReversal(string userName, int orgSpinvNumber)
        {
            await _bulkReversalRepository.CreateReversalListItem(userName, orgSpinvNumber);

            await _bulkReversalRepository.UpdateReversalStatus(userName);
        }

        public async Task<bool> ValidatePendingReversals(string userName)
        {
            return await _bulkReversalRepository.TestSuppliedInvoices(userName);
        }

        public async Task<int> CreateReversals(string userName)
        {
            return await _bulkReversalRepository.CreateReversals(userName);
        }

        public async Task ClearReversals(string userName)
        {
            await _bulkReversalRepository.ClearReversals(userName);
        }

        public async Task<string> ReversalListStringExport(string userName)
        {
            var bulkReversals = await GetReversalList(userName);

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(Common.Constant.BulkReversal.ExportStringHeaders);

            foreach (var bulkReversal in bulkReversals)
            {
                stringBuilder.AppendLine($"{bulkReversal.RevResults},{bulkReversal.RevStatus},{bulkReversal.NewSpInvNumber},{bulkReversal.OrgSpinvNumber}");
            }

            return stringBuilder.ToString();
        }
    }
}
