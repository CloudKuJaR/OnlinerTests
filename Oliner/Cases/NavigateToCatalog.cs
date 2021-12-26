using AventStack.ExtentReports;
using NUnit.Framework;

namespace Onliner.Cases
{
    class NavigateToCatalog
    {
        private string testName = "NavigateToCatalogTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
            Initialize.InitializeDriver();
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            NavigateTo.Catalog();
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
