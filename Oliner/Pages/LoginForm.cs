using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class LoginForm
    {
        public const string USERNAME_FIELD = "//input[@placeholder='Ник или e-mail']";
        public const string PASSWORD_FIELD = "//input[@placeholder='Пароль']";
        public const string LOGIN_BUTTON = "//div[@class='auth-form__control auth-form__control_condensed-additional']/button[@type='submit']";
        public const string REGISTRATION_BUTTON = "//a[@href='https://profile.onliner.by/registration']";
        public const string AUTH_FORM_TITLE = "//div[contains(@class,'auth-form__title')]";

        public MyWebElement UsernameField => new MyWebElement(By.XPath(USERNAME_FIELD));
        public MyWebElement PasswordField => new MyWebElement(By.XPath(PASSWORD_FIELD));
        public MyWebElement LoginButton => new MyWebElement(By.XPath(LOGIN_BUTTON));
        public MyWebElement RegistrationButton => new MyWebElement(By.XPath(REGISTRATION_BUTTON));
        public MyWebElement AuthFormTitle => new MyWebElement(By.XPath(AUTH_FORM_TITLE));


        public void FillLoginForm()
        {
            UsernameField.SendKeys(TestSettings.UserName);
            PasswordField.SendKeys(TestSettings.Password);
            LoginButton.Click();
        }

        public void OpenRegistrationPage()
        {
            RegistrationButton.Click();
        }
    }
}
