using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Actions;
using Onliner.Pages;
using OpenQA.Selenium;
using System.Threading;

namespace Onliner.Cases
{
    class BuyProduct
    {
        private string testName = "BuyProductTest";
        public  IWebDriver driver { get; set; }
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath, testName);
            driver = Initialize.InitializeDriver();
            Initialize.InitializeWait(driver);
        }

        [Test]
        public void BuyProductTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            NavigateTo.LoginForm(driver);
            ActionsLogin.FillLoginForm(driver);
            ActionsWait.WaitMethod(Menu.CATALOG_BUTTON);
            ActionsHomePage.ClickCatalogButton(driver);
            NavigateTo.TvPage(driver);
            ActionsWait.WaitMethod(TVPage.PRODUCT1);
            ActionsTvPage.ClickFirstProductButton(driver);
            ActionsProductPage.ClickSellersOfeersButton(driver);
            ActionsWait.WaitMethod(ProductPage.SELLER);
            ActionsProductPage.ClickSellerButton(driver);
            ActionsWait.WaitMethod(ProductPage.CONFIRM_CITY_BUTTON);
            ActionsProductPage.ClickCityButton(driver);
            ActionsWait.WaitMethod(ProductPage.CART);
            ActionsProductPage.ClickCratButton(driver);
            ActionsWait.WaitMethod(CartPage.ORDER_BUTTON);
            ActionsCartPage.ClickOrderButton(driver);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Reporter.extent.Flush();
            driver.Quit();
        }



    }
}
