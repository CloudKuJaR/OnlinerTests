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
            Initialize.InitializeDriver();
            Initialize.InitializeWaitDriver();
        }


        [Test]
        public void ProductComparisonTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("test started");
            NavigateTo.Catalog();
            NavigateTo.TvPage();
            ActionsWait.WaitForProduct("Телевизор Samsung QE50LS01TAU");
            ActionsTvPage.ClickFirstProductButton();
            ActionsProductPage.ClickComparisonButton();
            ActionsProductPage.ClickTvCatalogButton();
            ActionsWait.WaitForProduct("Телевизор LG 55NANO926PB");
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
