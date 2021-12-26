using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class LoginForm
    {
        public LoginForm(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = USERNAME_FIELD)]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.XPath, Using = PASSWORD_FIELD)]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = LOGIN_BUTTON)]
        public IWebElement loginButton { get; set; }

        public const string USERNAME_FIELD = "//input[@placeholder='Ник или e-mail']";
        public const string PASSWORD_FIELD = "//input[@placeholder='Пароль']";
        public const string LOGIN_BUTTON = "//div[@class='auth-form__control auth-form__control_condensed-additional']/button[@type='submit']";
    }
}
