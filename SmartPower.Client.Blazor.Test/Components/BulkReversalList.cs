using System.Collections.Generic;
using System.Threading.Tasks;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using SmartPower.Domain.Service;

namespace SmartPower.Client.Blazor.Test.Components
{
    [Category("Component")]
    [Category("BulkReversalList")]
    public class BulkReversalList : FixtureBase
    {
        private Mock<IBulkReversal> _bulkReversalService;
        private List<SmartPower.Data.Entity.Model.TReversalsBulkList> _bulkReversalModels;

        private Bunit.TestContext _testContext;

        [OneTimeSetUp]
        public void Setup()
        {
            _testContext = new Bunit.TestContext();

            _bulkReversalService = new Mock<IBulkReversal>();
            _bulkReversalModels = CreateMany<SmartPower.Data.Entity.Model.TReversalsBulkList>(Common.Constant.ItemCount);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _testContext.Dispose();
        }

        [Test]
        public async Task Component_Renders_Expected_Reversals()
        {
            _bulkReversalService.Setup(b => b.GetReversalList(Common.Constant.CurrentUser)).ReturnsAsync(_bulkReversalModels);

            _testContext.Services.AddScoped(x => Mapper);
            _testContext.Services.AddScoped(x => _bulkReversalService.Object);

            var component = _testContext.RenderComponent<Blazor.Pages.BulkReversals>();

            const int tableHeaderRow = 1;
            var tableRows = component.FindAll("table tr");

            Assert.IsTrue(tableRows.Count == Common.Constant.ItemCount + tableHeaderRow);

            _bulkReversalService.Verify(b => b.GetReversalList(Common.Constant.CurrentUser), Times.Once);
        }
    }
}
