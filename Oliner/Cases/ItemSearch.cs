using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Actions;
using System.Threading;

namespace Onliner.Cases
{
    class ItemSearch
    {
        private string testName = "SeacrhItemTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
            Initialize.InitializeComponents();
        }

        [Test]
        public void SeacrhItemTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            ActionsHomePage.FillSerachBar();
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

