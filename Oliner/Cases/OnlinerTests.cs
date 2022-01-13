using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Pages;
using System;

namespace Onliner.Cases
{
    class OnlinerTests
    {
        private string BuyProduct = "BuyProductTest";
        private string SeacrhItem = "SeacrhItemTest";
        private string LogIn = "LogInTest";
        private string NavigateToCatalog = "NavigateToCatalogTest";
        private string ProductComparison = "ProductComparisonTest";

        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeDriver();
        }

        [SetUp]
        public void InitializeReporterForBuyProductTest()
        {
            Initialize.GoToBaseUrl();
            string reportPath = Initialize.InitializePath();
            var testName = TestContext.CurrentContext.Test.Name;
            Initialize.InitializeReporter(reportPath, testName);
        }

        [Test]
        public void BuyProductTest()
        {
            Reporter.test = Reporter.extent.CreateTest(BuyProduct).Info("Test Started");
            Login();
            Page.Menu.OpenCatalogButton();
            Page.Catalog.NavigateToTvPage();
            Page.TVPage.ClickFirstProductButton();
            Page.ProductPage.ClickSellersOffersButton();
            Page.ProductPage.ClickSellerButton();
            //Page.ProductPage.SelectCity();
            Page.ProductPage.ClickCartButton();
            Page.Cart.TvName.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.Cart.TvName.Text, "Телевизор LG 65UP75006LF");
            Page.Cart.QuantityOfProduct.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.Cart.QuantityOfProduct.Text, "1 товар на сумму:");
            Page.Cart.ClickOrderButton();
            Page.OrderPage.Price.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.OrderPage.Price.Text, "1940,78 р.");
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void SeacrhItemTest()
        {
            Reporter.test = Reporter.extent.CreateTest(SeacrhItem).Info("Test Started");
            Page.Menu.FillSerachBar();
            Assert.IsTrue(Page.Menu.IsSearchItemContains(TestSettings.SearchItem));
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void LogInTest()
        {
            Reporter.test = Reporter.extent.CreateTest(LogIn).Info("Test Started");
            Login();
            Page.Menu.ClickUserMenuBatton();
            Assert.AreEqual(Page.Menu.AccName.Text, TestSettings.UserId);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Reporter.test = Reporter.extent.CreateTest(NavigateToCatalog).Info("Test Started");
            Page.Menu.OpenCatalogButton();
            Assert.AreEqual(Driver.driver.Title, "Каталог Onlíner");
            Assert.AreEqual(Page.Catalog.ElectronicsText.Text, "Электроника");
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void ProductComparisonTest()
        {
            Reporter.test = Reporter.extent.CreateTest(ProductComparison).Info("test started");
            Page.Menu.OpenCatalogButton();
            Page.Catalog.NavigateToTvPage();
            Page.TVPage.ClickFirstProductButton();
            Page.ProductPage.ClickComparisonButton();
            Page.ProductPage.ClickTvCatalogButton();
            Page.TVPage.ClickSecondProductButton();
            Page.ProductPage.ClickComparisonButton();
            Assert.AreEqual(Page.Menu.CompareText.Text, "2 товара");
            Page.Menu.OpenCompareButton();
            Assert.IsTrue(Page.ComparePage.AreDifferentParametersHighlighted());
            Reporter.test.Log(Status.Pass, "test passed");
        }

        [TearDown]
        public void CleanUpAfterTest()
        {
            if (Page.OrderPage.OrderText.IsPresent() == true)
            {
                Page.OrderPage.OpenCatalogButton();
            }

            if (Page.Menu.CartBanner.IsPresent() == true)
            {
                Page.Menu.ClickCartButton();
                Page.Cart.ClickToDeleteButton();
                Page.Cart.OpenHomePageButton();
                Console.WriteLine("Очистка Корзины удалась");
            }

            if (Page.Menu.UserMenu.IsPresent() == true)
            {
                Page.Menu.ClickUserMenuBatton();
                Page.Menu.ClickLogOutButton();
                Console.WriteLine("LogOut Удался");
            }
            Console.WriteLine("TearDown Удался");
            Reporter.extent.Flush();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

        private void Login()
        {
            Page.Menu.ClickLoginForm();
            Page.Login.FillLoginForm();
        }
    }
}
