using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartPower.Application.Service.BulkReversal;

namespace SmartPower.Client.Blazor.Pages
{
    public class CsvExportModel : PageModel
    {
        private readonly ICsvExport _csvExport;

        public CsvExportModel(ICsvExport csvExport)
        {
            _csvExport = csvExport;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var stringBuilderExport = await _csvExport.GenerateCsvStringExport(Common.Constant.CurrentUser);

            return File(Encoding.UTF8.GetBytes(stringBuilderExport), 
                Common.Constant.BulkReversal.CsvExport.File.FileContentType, Common.Constant.BulkReversal.CsvExport.File.FileName);
        }
    }
}
