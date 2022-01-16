using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class UserSupportPage
    {
        public const string USER_SUPPORT_PAGE_TITLE = "//h1[text()='Запрос в службу поддержки']";
        public const string USER_NAME_FIELD = "//input[@id='id_name']";
        public const string EMAIL_FIELD = "//input[@id='id_email']";
        public const string EMAIL_FIELD_ERROR = "//input[contains(@class,'i-p error')]";
        public const string DROP_DOWN_MENU_TYPE_OF_PROBLEM = "";
        public const string DROP_DOWN_MENU_WHERE = "";
        public const string CAPTCHA_FIELD = "";
        public const string CAPTCHA_IMG = "";

        public MyWebElement UserSupportPageTitle => new MyWebElement(By.XPath(USER_SUPPORT_PAGE_TITLE));
        public MyWebElement UserNameField => new MyWebElement(By.XPath(USER_NAME_FIELD));
        public MyWebElement EmailField => new MyWebElement(By.XPath(EMAIL_FIELD));
        public MyWebElement EmailFieldError => new MyWebElement(By.XPath(EMAIL_FIELD_ERROR));
        

        public void FillUserNameField()
        {
            UserNameField.SendKeys("Colombus");
        }
        public void ClearUserNameField()
        {
            UserNameField.Clear();
        }

        public void FillEmailFieldWithInvalidCredentials()
        {
            EmailField.SendKeys("asd" + Keys.Tab);
        }

        public void FillEmailFieldWithValidCredentials()
        {
            EmailField.SendKeys("sus@amogus.com" + Keys.Tab);
        }
    }
}
