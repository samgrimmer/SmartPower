using System.Text;
using System.Threading.Tasks;

namespace SmartPower.Application.Service.BulkReversal
{
    public class CsvExport : ICsvExport
    {
        private readonly Entity.Repository.IBulkReversal _bulkReversalRepository;

        public CsvExport(Entity.Repository.IBulkReversal bulkReversalRepository)
        {
            _bulkReversalRepository = bulkReversalRepository;
        }

        public async Task<string> GenerateCsvStringExport(string userName)
        {
            var bulkReversals = await _bulkReversalRepository.GetBulkReversals(userName);

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
