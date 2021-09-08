using System.Threading.Tasks;

namespace SmartPower.Application.Service.BulkReversal
{
    public interface ICsvExport
    {
        Task<string> GenerateCsvStringExport(string userName);
    }
}