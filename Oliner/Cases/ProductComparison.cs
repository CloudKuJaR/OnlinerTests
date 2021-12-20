using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using Onliner.Actions;
using Onliner.Pages;
using System;

namespace Onliner.Cases
{
    class ProductComparison
    {
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
            Initialize.InitializeComponents();
        }


        [Test]
        public void ProductComparisonTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("test started");
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
            Reporter.test.Log(Status.Pass, "test passed");

        }

        [TearDown]
        public void TearDown()
        {
            Driver.driver.Quit();
        }
    }
}
