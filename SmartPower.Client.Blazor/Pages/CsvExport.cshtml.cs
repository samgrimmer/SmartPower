using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartPower.Domain.Service;

namespace SmartPower.Client.Blazor.Pages
{
    public class CsvExportModel : PageModel
    {
        private readonly IBulkReversal _bulkReversalService;

        public CsvExportModel(IBulkReversal bulkReversalService)
        {
            _bulkReversalService = bulkReversalService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var stringBuilderExport = await _bulkReversalService.ReversalListStringExport(Common.Constant.CurrentUser);

            return File(Encoding.UTF8.GetBytes(stringBuilderExport), 
                Common.Constant.BulkReversal.CsvExport.File.FileContentType, Common.Constant.BulkReversal.CsvExport.File.FileName);
        }
    }
}
