using NUnit.Framework;
using Onliner.Pages;
using System.Threading;

namespace Onliner.Cases
{
    class ProductComparison
    {

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ProductComparisonTest()
        {
            CatalogPage catalogPage = new CatalogPage();
            TVPage tvPage = new TVPage();
            ProductPage productPage = new ProductPage();
            Menu menu = new Menu();
            NavigateTo.Catalog();
            NavigateTo.TvPage();
            Thread.Sleep(1000);
            Actions.ClickFirstProductButton();
            Actions.ClickComparisonButton();
            Thread.Sleep(1000);
            Actions.ClickTvCatalogButton();
            Thread.Sleep(500);
            Actions.ClickSecondProductButton();
            Thread.Sleep(500);
            Actions.ClickComparisonButton();
            Thread.Sleep(1000);
            Actions.ClickCompareButton();
            Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
