using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using SmartPower.Domain.Service;
using SmartPower.Client.Blazor.Pages;

namespace SmartPower.Client.Blazor.Test.Pages
{
    [Category("Page")]
    [Category("CsvExport")]
    public class CsvExport : FixtureBase
    {
        private Mock<IBulkReversal> _bulkReversalService;

        private CsvExportModel _sut;

        [OneTimeSetUp]
        public void Setup()
        {
            _bulkReversalService = new Mock<IBulkReversal>();
        }

        [Test]
        public async Task Page_Returns_Expected_FileContent_Result()
        {
            _bulkReversalService.Setup(b => b.ReversalListStringExport(Common.Constant.CurrentUser)).ReturnsAsync(Common.Constant.BulkReversal.ExportStringHeaders);

            _sut = new CsvExportModel(_bulkReversalService.Object);

            var result = await _sut.OnGetAsync();

            Assert.IsInstanceOf<FileContentResult>(result);

            var fileContentResult = result as FileContentResult;

            Assert.IsNotNull(fileContentResult);

            Assert.IsTrue(fileContentResult.ContentType == Common.Constant.BulkReversal.CsvExport.File.FileContentType);
            Assert.IsTrue(fileContentResult.FileDownloadName == Common.Constant.BulkReversal.CsvExport.File.FileName);

            Assert.IsTrue(fileContentResult.FileContents.Length > 0);

            _bulkReversalService.Verify(b => b.ReversalListStringExport(Common.Constant.CurrentUser), Times.Once);
        }
    }
}
