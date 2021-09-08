using System.Collections.Generic;
using System.Threading.Tasks;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using SmartPower.Application.Entity.Repository;

namespace SmartPower.Client.Blazor.Test.Components
{
    [Category("Component")]
    [Category("BulkReversalList")]
    public class BulkReversalList : FixtureBase
    {
        private Mock<IBulkReversal> _bulkReversalRepository;
        private List<Application.Entity.Model.Projection.BulkReversalSummary> _bulkReversalModels;

        private Bunit.TestContext _testContext;

        [OneTimeSetUp]
        public void Setup()
        {
            _testContext = new Bunit.TestContext();

            _bulkReversalRepository = new Mock<IBulkReversal>();
            _bulkReversalModels = CreateMany<Application.Entity.Model.Projection.BulkReversalSummary>(Common.Constant.ItemCount);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _testContext.Dispose();
        }

        [Test]
        public async Task Component_Renders_Expected_Reversals()
        {
            _bulkReversalRepository.Setup(b => b.GetBulkReversals(Common.Constant.CurrentUser)).ReturnsAsync(_bulkReversalModels);

            _testContext.Services.AddScoped(x => Mapper);
            _testContext.Services.AddScoped(x => _bulkReversalRepository.Object);

            var component = _testContext.RenderComponent<Blazor.Pages.BulkReversals>();

            const int tableHeaderRow = 1;
            var tableRows = component.FindAll("table tr");

            Assert.IsTrue(tableRows.Count == Common.Constant.ItemCount + tableHeaderRow);

            _bulkReversalRepository.Verify(b => b.GetBulkReversals(Common.Constant.CurrentUser), Times.Once);
        }
    }
}
