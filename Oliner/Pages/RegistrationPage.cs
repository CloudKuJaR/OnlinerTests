using Onliner.WebElementExtension;
using OpenQA.Selenium;
using System;

namespace Onliner.Pages
{
    public class RegistrationPage
    {
        public const string EMAIL_FIELD = "//input[@type='email']";
        public const string PASSWORD_FIELD = "//input[@type='password']";
        public const string REPEAT_PASSWORD_FIELD = "(//input[@type='password'])[2]";
        public const string CHECK_BOX = "//span[@class='i-checkbox__faux']";
        public const string REGISRATION_BUTTON = "//button[@type='submit']";
        public const string REGISTRATION_FORM_TITLE = "//div[contains(@class,'auth-form__title')]";
        public const string EMAIL_FIELD_HIGHTLIGHTED_AND_GREEN = "//input[contains(@class,'auth-input_success')]";
        public const string PASSWORD_FIELD_HIGTLIGHTED_AND_RED = "//input[contains(@class,'auth-input_error')]";
        public const string PASSWORD_DESCRIPTION_ERROR = "//div[contains(@class,'auth-form__description_error')]";
        public const string PASSWORD_DESCRIPTION = "//div[contains(@class,'auth-form__description_tiny')]";
        public const string REGESTRATION_CONFIRMATION_TITLE = "//div[@class='auth-form__title auth-form__title_big auth-form__title_condensed-default']";
        public const string GO_TO_MAIL_BUTTON = "//a[contains(@class,'auth-button_appendant')]";

        public MyWebElement EmailField => new MyWebElement(By.XPath(EMAIL_FIELD));
        public MyWebElement PasswordField  => new MyWebElement(By.XPath(PASSWORD_FIELD));
        public MyWebElement RepeatPasswordField => new MyWebElement(By.XPath(REPEAT_PASSWORD_FIELD));
        public MyWebElement CheckBox  => new MyWebElement(By.XPath(CHECK_BOX));
        public MyWebElement RegisrationButton => new MyWebElement(By.XPath(REGISRATION_BUTTON));
        public MyWebElement RegistrationFormTitle => new MyWebElement(By.XPath(REGISTRATION_FORM_TITLE));
        public MyWebElement EmailFieldHightLightedAndGreen => new MyWebElement(By.XPath(EMAIL_FIELD_HIGHTLIGHTED_AND_GREEN));
        public MyWebElement PasswordFieldHightLightedAndRed => new MyWebElement(By.XPath(PASSWORD_FIELD_HIGTLIGHTED_AND_RED));
        public MyWebElement PasswordDescriptionError => new MyWebElement(By.XPath(PASSWORD_DESCRIPTION_ERROR));
        public MyWebElement PasswordDescription => new MyWebElement(By.XPath(PASSWORD_DESCRIPTION));
        public MyWebElement RegestrationConfirmationTitle => new MyWebElement(By.XPath(REGESTRATION_CONFIRMATION_TITLE));
        public MyWebElement GoToMailButton => new MyWebElement(By.XPath(GO_TO_MAIL_BUTTON));

        public void FillEmailField()
        {
            char[] letters = "qwertyuiopasdfghzxcvb".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 4; i++)
            {
                randomString += letters[r.Next(0, 21)].ToString();
            }

            EmailField.SendKeys($"{randomString}@mail.com");
        }

        public void ClickRegistrationButton()
        {
            RegisrationButton.Click();
        }

        public void FillPasswordFields()
        {
            PasswordField.SendKeys(TestSettings.PasswordRegistration);
            RepeatPasswordField.SendKeys(TestSettings.PasswordRegistration);
        }

        public void ClickCheckBox()
        {
            CheckBox.WaitForElementIsDisplayed();
            CheckBox.Click();
        }
    }
}
