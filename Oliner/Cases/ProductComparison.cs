using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using Onliner.Actions;
using Onliner.Pages;
using OpenQA.Selenium;
using System;

namespace Onliner.Cases
{
    class ProductComparison
    {
        public IWebDriver driver { get; set; }
        private string testName = "ProductComparisonTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Reporter.extent.Flush();
        }

        [SetUp]
        public void SetUp()
        {
            driver = Initialize.InitializeDriver();
            Initialize.InitializeWait(driver);
        }


        [Test]
        public void ProductComparisonTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("test started");
            NavigateTo.Catalog(driver);
            NavigateTo.TvPage(driver);
            ActionsWait.WaitMethod(TVPage.PRODUCT1);
            ActionsTvPage.ClickFirstProductButton(driver);
            ActionsProductPage.ClickComparisonButton(driver);
            ActionsProductPage.ClickTvCatalogButton(driver);
            ActionsWait.WaitMethod(TVPage.PRODUCT2);
            ActionsTvPage.ClickSecondProductButton(driver);
            ActionsProductPage.ClickComparisonButton(driver);
            ActionsHomePage.ClickCompareButton(driver);
            Reporter.test.Log(Status.Pass, "test passed");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
