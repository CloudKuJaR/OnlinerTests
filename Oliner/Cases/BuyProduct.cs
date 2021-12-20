using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Actions;
using Onliner.Pages;
using System.Threading;

namespace Onliner.Cases
{
    class BuyProduct
    {
        private string testName = "BuyProductTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath, testName);
            Initialize.InitializeComponents();
        }

        [Test]
        public void BuyProductTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            NavigateTo.LoginForm();
            ActionsLogin.FillLoginForm();
            ActionsWait.WaitMethod(Menu.CATALOG_BUTTON);
            ActionsHomePage.ClickCatalogButton();
            NavigateTo.TvPage();
            ActionsWait.WaitMethod(TVPage.PRODUCT1);
            ActionsTvPage.ClickFirstProductButton();
            ActionsProductPage.ClickSellersOfeersButton();
            ActionsWait.WaitMethod(ProductPage.SELLER);
            ActionsProductPage.ClickSellerButton();
            ActionsWait.WaitMethod(ProductPage.CONFIRM_CITY_BUTTON);
            ActionsProductPage.ClickCityButton();
            ActionsWait.WaitMethod(ProductPage.CART);
            ActionsProductPage.ClickCratButton();
            ActionsWait.WaitMethod(CartPage.ORDER_BUTTON);
            ActionsCartPage.ClickOrderButton();
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Reporter.extent.Flush();
            Driver.driver.Quit();
        }



    }
}
