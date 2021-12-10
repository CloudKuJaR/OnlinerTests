using NUnit.Framework;
using System.Threading;

namespace Onliner.Cases
{
    class NavigateToCatalog
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Thread.Sleep(2000);
            NavigateTo.Catalog();
            Thread.Sleep(3000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
