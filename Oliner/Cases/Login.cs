using NUnit.Framework;
using Onliner.Actions;

namespace Onliner.Cases
{
    class Login
    {

        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeComponents();
        }

        [Test]
        public void LogIn()
        {
            NavigateTo.LoginForm();
            ActionsLogin.FillLoginForm();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
