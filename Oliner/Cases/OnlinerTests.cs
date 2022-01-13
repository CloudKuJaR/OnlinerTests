using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.ActionsWaits;
using Onliner.Pages;
using System;
using System.Threading;

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
            Initialize.InitializeWaitDriver();
        }

        [SetUp]
        public void InitializeReporterForBuyProductTest()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath, BuyProduct);
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
            Page.Cart.ClickOrderButton();
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void SeacrhItemTest()
        {
            Reporter.test = Reporter.extent.CreateTest(SeacrhItem).Info("Test Started");
            Page.Menu.FillSerachBar();
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void LogInTest()
        {
            Reporter.test = Reporter.extent.CreateTest(LogIn).Info("Test Started");
            Login();
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Reporter.test = Reporter.extent.CreateTest(NavigateToCatalog).Info("Test Started");
            Page.Menu.OpenCatalogButton();          
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void ProductComparisonTest()
        {
            Reporter.test = Reporter.extent.CreateTest(ProductComparison).Info("test started");
            Page.Menu.CatalogButton.WaitForElementIsDisplayed();
            Page.Menu.OpenCatalogButton();
            Page.Catalog.NavigateToTvPage();
            Page.TVPage.ClickFirstProductButton();
            Page.ProductPage.ClickComparisonButton();
            Page.ProductPage.ClickTvCatalogButton();
            Page.TVPage.ClickSecondProductButton();
            Page.ProductPage.ClickComparisonButton();
            Page.Menu.OpenCompareButton();
            Reporter.test.Log(Status.Pass, "test passed");
        }

        [TearDown]
        public void CleanUpAfterTest()
        {
            //if (Page.OrderPage.OrderPageIsOpend() == true)
            //{
            //    Page.OrderPage.OpenCatalogButton();
            //}

            //if (Page.Menu.IsCartContains() == true)
            //{
            //    Page.Menu.ClickCartButton();
            //    Page.Cart.ClickDeleteButton();
            //    Page.Cart.ClickHomePageButton();
            //}

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
