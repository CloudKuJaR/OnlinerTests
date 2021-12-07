using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class LoginForm
    {
        public LoginForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Ник или e-mail']")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Пароль']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='auth-form__control auth-form__control_condensed-additional']/button[@type='submit']")]
        public IWebElement loginButton { get; set; }

    }
}
