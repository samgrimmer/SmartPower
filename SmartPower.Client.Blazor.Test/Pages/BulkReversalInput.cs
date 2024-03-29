﻿using System.Threading.Tasks;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using SmartPower.Domain.Service;

namespace SmartPower.Client.Blazor.Test.Pages
{
    [Category("Pages")]
    [Category("BulkReversalInput")]
    public class BulkReversalInput : FixtureBase
    {
        private Mock<IBulkReversal> _bulkReversalService;
        private Mock<NavigationManager> _navigationManger;

        private Bunit.TestContext _testContext;
        private IRenderedComponent<Blazor.Pages.BulkReversalInput> _component;

        [OneTimeSetUp]
        public void Setup()
        {
            _testContext = new Bunit.TestContext();

            _bulkReversalService = new Mock<IBulkReversal>();
            _navigationManger = new Mock<NavigationManager>();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _testContext.Dispose();
        }

        [Test]
        public async Task Page_Is_Able_To_Submit_Bulk_Reversal()
        {
            var orgSpin = Create<int>();

            _bulkReversalService.Setup(b => b.CreateReversal(Common.Constant.CurrentUser, orgSpin));

            _testContext.Services.AddScoped(x => Mapper);
            _testContext.Services.AddScoped(x => _bulkReversalService.Object);

            _component = _testContext.RenderComponent<Blazor.Pages.BulkReversalInput>();

            Assert.IsTrue(_component.Markup.Contains("<h2>Bulk Reversal Input</h2>"));

            var submitButton = _component.FindAll("button.btn-primary");

            Assert.IsTrue(submitButton.Count == 1);

            var orgSpinInput = _component.Find("#orgSpin");
            orgSpinInput.Change(orgSpin.ToString());

            _component.Find("form").Submit();

            _bulkReversalService.Verify(b => b.CreateReversal(Common.Constant.CurrentUser, orgSpin), Times.Once);

            var navigationManager = _testContext.Services.GetRequiredService<NavigationManager>();

            Assert.IsTrue(navigationManager.Uri.Contains("bulk-reversals"));
        }
    }
}
