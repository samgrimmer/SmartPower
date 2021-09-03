using Bunit;
using NUnit.Framework;
using SmartPower.Common;

namespace SmartPower.Client.Blazor.Test.Components
{
    [Category("Component")]
    [Category("Toaster")]
    public class Toaster
    {
        private Bunit.TestContext _testContext;
        private IRenderedComponent<Shared.Toaster> _component;
        private string _message;

        [OneTimeSetUp]
        public void Setup()
        {
            _message = Constant.BulkReversal.Message.DirtyPendingReversals;

            _testContext = new Bunit.TestContext();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _testContext.Dispose();
        }

        [Test]
        public void Component_Renders_Expected__When_Message_Set()
        {
            _component = _testContext.RenderComponent<Shared.Toaster>(parameters => parameters
                .Add(p => p.Message, _message));

            var div = _component.Find("div.alert");

            Assert.IsNotNull(div);
            Assert.IsTrue(_component.Markup.Contains(_message));
        }

        [Test]
        public void Component_Is_Not_Rendered_When_Message_Not_Set()
        {
            _component = _testContext.RenderComponent<Shared.Toaster>();

            Assert.IsTrue(string.IsNullOrEmpty(_component.Markup));
        }
    }
}
