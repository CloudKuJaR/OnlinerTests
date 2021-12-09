using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Onliner.Cases
{
    class Login
    {

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(); 
        }

        [Test]
        public void LogIn()
        {
            NavigateTo.LoginForm();
            Thread.Sleep(2000);
            Actions.FillLoginForm();
            Thread.Sleep(3000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
