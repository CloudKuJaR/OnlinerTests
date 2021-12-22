using Onliner.Pages;
using OpenQA.Selenium;

namespace Onliner.Actions
{
    public static class ActionsLogin
    {
        public static LoginForm loginForm;
        public static void FillLoginForm(IWebDriver driver)
        {
            loginForm = new LoginForm(driver);
            loginForm.UsernameField.SendKeys(Config.Credentials.userMail);
            loginForm.PasswordField.SendKeys(Config.Credentials.userPassword);
            loginForm.loginButton.Click();

        }
    }
}
