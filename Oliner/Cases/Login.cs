using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Actions;

namespace Onliner.Cases
{
    class Login
    {
        private string testName = "LogInTest";
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            string reportPath = Initialize.InitializePath();
            Initialize.InitializeReporter(reportPath,testName);
            Initialize.InitializeComponents();
        }

        [Test]
        public void LogInTest()
        {
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
            NavigateTo.LoginForm();
            ActionsLogin.FillLoginForm();
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
