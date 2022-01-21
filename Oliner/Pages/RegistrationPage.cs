using Onliner.Utils;
using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class RegistrationPage
    {
        private const string EMAIL_FIELD = "//input[@type='email']";
        private const string PASSWORD_FIELD = "//input[@type='password']";
        private const string REPEAT_PASSWORD_FIELD = "(//input[@type='password'])[2]";
        private const string ACCEPT_PRIVACY_CHECK_BOX = "//span[@class='i-checkbox__faux']";
        private const string REGISRATION_BUTTON = "//button[@type='submit']";
        private const string REGISTRATION_FORM_TITLE = "//div[contains(@class,'auth-form__title')]";
        private const string EMAIL_FIELD_HIGHTLIGHTED_AND_GREEN = "//input[contains(@class,'auth-input_success')]";
        private const string PASSWORD_FIELD_HIGTLIGHTED_AND_RED = "//input[contains(@class,'auth-input_error')]";
        private const string PASSWORD_DESCRIPTION_ERROR = "//div[contains(@class,'auth-form__description_error')]";
        private const string PASSWORD_DESCRIPTION = "//div[contains(@class,'auth-form__description_tiny')]";
        private const string REGESTRATION_CONFIRMATION_TITLE = "//div[@class='auth-form__title auth-form__title_big auth-form__title_condensed-default']";
        private const string GO_TO_MAIL_BUTTON = "//a[contains(@class,'auth-button_appendant')]";

        private MyWebElement RegistrationFormTitle => new MyWebElement(By.XPath(REGISTRATION_FORM_TITLE));
        private MyWebElement EmailFieldHightLightedAndGreen => new MyWebElement(By.XPath(EMAIL_FIELD_HIGHTLIGHTED_AND_GREEN));
        private MyWebElement PasswordFieldHightLightedAndRed => new MyWebElement(By.XPath(PASSWORD_FIELD_HIGTLIGHTED_AND_RED));
        private MyWebElement PasswordDescriptionError => new MyWebElement(By.XPath(PASSWORD_DESCRIPTION_ERROR));
        private MyWebElement PasswordDescription => new MyWebElement(By.XPath(PASSWORD_DESCRIPTION));
        private MyWebElement RegestrationConfirmationTitle => new MyWebElement(By.XPath(REGESTRATION_CONFIRMATION_TITLE));
        private MyWebElement GoToMailButton => new MyWebElement(By.XPath(GO_TO_MAIL_BUTTON));
        private MyWebElement EmailField => new MyWebElement(By.XPath(EMAIL_FIELD));
        private MyWebElement PasswordField => new MyWebElement(By.XPath(PASSWORD_FIELD));
        private MyWebElement RepeatPasswordField => new MyWebElement(By.XPath(REPEAT_PASSWORD_FIELD));
        private MyWebElement AcceptPrivacyCheckBox => new MyWebElement(By.XPath(ACCEPT_PRIVACY_CHECK_BOX));
        private MyWebElement RegisrationButton => new MyWebElement(By.XPath(REGISRATION_BUTTON));

        public void ClickRegistrationButton() => RegisrationButton.Click();

        public bool IsEmailFieldHightLightedAndGreenPresent() => EmailFieldHightLightedAndGreen.IsPresent();

        public bool IsPasswordFieldHightLightedAndRedPresent() => PasswordFieldHightLightedAndRed.IsPresent();

        public bool IsPasswordDescriptionErrorPresent() => PasswordDescriptionError.IsPresent();

        public bool IsRegistrationFormTitlePresent() => RegistrationFormTitle.IsPresent();

        public string GetPasswordDescriptionText() => PasswordDescription.Text;

        public bool IsRegestrationConfirmationTitlePresent() => RegestrationConfirmationTitle.IsPresent();

        public bool IsGoToMailButtonPresent() => GoToMailButton.IsPresent();

        public void FillEmailField()
        {
            string randomString = RandomHelper.GetRandomString();
            EmailField.SendKeys($"{randomString}@mail.com");
        }

        public void FillPasswordFields()
        {
            PasswordField.SendKeys(TestSettings.PasswordRegistration);
            RepeatPasswordField.SendKeys(TestSettings.PasswordRegistration);
        }

        public void ClickAcceptPrivacyCheckBox()
        {
            AcceptPrivacyCheckBox.WaitForElementIsDisplayed();
            AcceptPrivacyCheckBox.Click();
        }
    }
}
