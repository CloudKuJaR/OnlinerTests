using Onliner.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onliner
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.baseUrl);
        }

        public static void FillLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.UsernameField.SendKeys(Config.Credentials.userMail);
            loginForm.PasswordField.SendKeys(Config.Credentials.userPassword);
            loginForm.loginButton.Click();
            
        }

        public static void FillSerachBar()
        {
            HomePage homePage = new HomePage();
            homePage.searchBar.SendKeys(Config.SearchInformation.searchItem);
        }
    }
}
