using NUnit.Framework;
using Onliner.Actions;
using Onliner.Pages;

namespace Onliner.Cases
{
    class ProductComparison
    {
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeComponents();
        }

        [Test]
        public void ProductComparisonTest()
        {
            NavigateTo.Catalog();
            NavigateTo.TvPage();
            ActionsWait.WaitMethod(TVPage.PRODUCT1);
            ActionsTvPage.ClickFirstProductButton();
            ActionsProductPage.ClickComparisonButton();
            ActionsProductPage.ClickTvCatalogButton();
            ActionsWait.WaitMethod(TVPage.PRODUCT2);
            ActionsTvPage.ClickSecondProductButton();
            ActionsProductPage.ClickComparisonButton();
            ActionsHomePage.ClickCompareButton();

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
