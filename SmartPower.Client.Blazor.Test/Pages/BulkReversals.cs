using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using SmartPower.Common;
using SmartPower.Domain.Service;

namespace SmartPower.Client.Blazor.Test.Pages
{
    [Category("Pages")]
    [Category("BulkReversals")]
    public class BulkReversals : FixtureBase
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
        public async Task Component_Behaviour_Expected_For_Bulk_Reversals_With_Confirmation()
        {
            var batchNumber = Create<int>();

            _bulkReversalService.Setup(b => b.GetReversalList(Constant.CurrentUser)).ReturnsAsync(_bulkReversalModels);
            _bulkReversalService.Setup(b => b.CreateReversals(Constant.CurrentUser)).ReturnsAsync(batchNumber);
            _bulkReversalService.Setup(b => b.ValidatePendingReversals(Constant.CurrentUser)).ReturnsAsync(true);

            _testContext.Services.AddScoped(x => Mapper);
            _testContext.Services.AddScoped(x => _bulkReversalService.Object);

            var component = _testContext.RenderComponent<Blazor.Pages.BulkReversals>();

            _bulkReversalService.Verify(b => b.GetReversalList(Constant.CurrentUser), Times.Once);

            var buttons = component.FindAll("button");

            Assert.IsTrue(buttons.Count > 0);

            var bulkReversalButton = buttons.FirstOrDefault(b => b.InnerHtml == "Bulk Reversal");

            bulkReversalButton.Click();

            _bulkReversalService.Verify(b => b.ValidatePendingReversals(Constant.CurrentUser), Times.Once);

            var buttonsAfterBulkReversal = component.FindAll("button");

            var bulkReversalConfirmationButton = buttonsAfterBulkReversal.FirstOrDefault(b => b.InnerHtml == "Continue Bulk Reversal");

            bulkReversalConfirmationButton.Click();

            _bulkReversalService.Verify(b => b.CreateReversals(Constant.CurrentUser), Times.Once);

            Assert.IsTrue(component.Markup.Contains(batchNumber.ToString()));
        }
    }
}
