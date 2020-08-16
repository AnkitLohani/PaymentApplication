using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaymentApp.TestProject
{
    [TestClass]
    public class TestInitializeBase
    {
        protected ServiceProvider serviceProvider;

        [TestInitialize]
        public void TestInitialize()
        {
            this.serviceProvider = DependencyResolver.ResolveDependency();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.serviceProvider.Dispose();
        }
    }
}
