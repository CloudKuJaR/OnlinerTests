using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class LoginForm
    {
        private const string USERNAME_FIELD = "//input[@placeholder='Ник или e-mail']";
        private const string PASSWORD_FIELD = "//input[@placeholder='Пароль']";
        private const string LOGIN_BUTTON = "//div[@class='auth-form__control auth-form__control_condensed-additional']/button[@type='submit']";
        private const string REGISTRATION_BUTTON = "//a[@href='https://profile.onliner.by/registration']";
        private const string AUTH_FORM_TITLE = "//div[contains(@class,'auth-form__title')]";

        public MyWebElement AuthFormTitle => new MyWebElement(By.XPath(AUTH_FORM_TITLE));
        private MyWebElement UsernameField => new MyWebElement(By.XPath(USERNAME_FIELD));
        private MyWebElement PasswordField => new MyWebElement(By.XPath(PASSWORD_FIELD));
        private MyWebElement LoginButton => new MyWebElement(By.XPath(LOGIN_BUTTON));
        private MyWebElement RegistrationButton => new MyWebElement(By.XPath(REGISTRATION_BUTTON));

        public void OpenRegistrationPage() => RegistrationButton.Click();

        public void FillLoginForm()
        {
            UsernameField.SendKeys(TestSettings.UserName);
            PasswordField.SendKeys(TestSettings.Password);
            LoginButton.Click();
        }
    }
}
