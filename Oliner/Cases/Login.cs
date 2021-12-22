using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Actions;
using OpenQA.Selenium;

namespace Onliner.Cases
{
    class Login
    {
        public IWebDriver driver { get; set; }
        private string testName = "LogInTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
            driver = Initialize.InitializeDriver();
            Initialize.InitializeWait(driver);
        }

        [Test]
        public void LogInTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            NavigateTo.LoginForm(driver);
            ActionsLogin.FillLoginForm(driver);
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
