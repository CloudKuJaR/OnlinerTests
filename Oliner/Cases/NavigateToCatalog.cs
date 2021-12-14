using NUnit.Framework;

namespace Onliner.Cases
{
    class NavigateToCatalog
    {
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeComponents();
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            NavigateTo.Catalog();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
