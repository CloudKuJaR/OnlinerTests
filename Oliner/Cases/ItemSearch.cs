using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Actions;
using OpenQA.Selenium;
using System.Threading;

namespace Onliner.Cases
{
    class ItemSearch
    {
        public IWebDriver driver { get; set; }
        private string testName = "SeacrhItemTest";
        
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
            driver = Initialize.InitializeDriver();
            Initialize.InitializeWait(driver);

        }

        [Test]
        public void SeacrhItemTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            ActionsHomePage.FillSerachBar(driver);
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

