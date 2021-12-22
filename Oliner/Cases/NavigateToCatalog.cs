using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Onliner.Cases
{
    class NavigateToCatalog
    {
        public IWebDriver driver { get; set; }
        private string testName = "NavigateToCatalogTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
            driver = Initialize.InitializeDriver();
            Initialize.InitializeWait(driver);
            
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            NavigateTo.Catalog(driver);
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
