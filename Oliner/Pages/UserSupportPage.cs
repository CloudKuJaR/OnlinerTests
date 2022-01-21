﻿using Onliner.WebElementExtension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Onliner.Pages
{
    public class UserSupportPage
    {
        private const string USER_SUPPORT_PAGE_TITLE = "//h1[text()='Запрос в службу поддержки']";
        private const string USER_NAME_FIELD = "//input[@id='id_name']";
        private const string EMAIL_FIELD = "//input[@id='id_email']";
        private const string EMAIL_FIELD_ERROR = "//input[contains(@class,'i-p error')]";
        private const string DROP_DOWN_MENU_TYPE_OF_PROBLEM = "//select[@id='id_type']";
        private const string DROP_DOWN_MENU_WHERE = "//select[@id='id_project']";
        private const string SHORT_DISCRIPTON = "//input[@id='id_subject']";
        private const string DETAILED_DISCRIPTON = "//textarea[@id='id_description']";
        private const string CAPTCHA_FIELD = "//input[@id='id_captcha']";
        private const string CAPTCHA_IMG = "//img[@class='captcha']";
        private const string ADD_BUTTON = "//input[@type='image']";

        private MyWebElement EmailFieldError => new MyWebElement(By.XPath(EMAIL_FIELD_ERROR));
        private MyWebElement UserSupportPageTitle => new MyWebElement(By.XPath(USER_SUPPORT_PAGE_TITLE));
        private MyWebElement UserNameField => new MyWebElement(By.XPath(USER_NAME_FIELD));
        private MyWebElement EmailField => new MyWebElement(By.XPath(EMAIL_FIELD));
        private MyWebElement ShortDiscription => new MyWebElement(By.XPath(SHORT_DISCRIPTON));
        private MyWebElement DetailedDiscription => new MyWebElement(By.XPath(DETAILED_DISCRIPTON));
        private MyWebElement CaptchaField => new MyWebElement(By.XPath(CAPTCHA_FIELD));
        private MyWebElement CaptchaImg => new MyWebElement(By.XPath(CAPTCHA_IMG));
        private MyWebElement AddButton => new MyWebElement(By.XPath(ADD_BUTTON));
        private SelectElement DropDownMenuTypeOfProblem => new SelectElement(Driver.driver.FindElement(By.XPath(DROP_DOWN_MENU_TYPE_OF_PROBLEM)));
        private SelectElement DropDownMenuWhere => new SelectElement(Driver.driver.FindElement(By.XPath(DROP_DOWN_MENU_WHERE)));

        public bool IsUserSupportPageTitlePresent() => UserSupportPageTitle.IsPresent();

        public string GetUserNameFieldAttribute() => UserNameField.GetAttribute("value");

        public bool IsEmailFieldErrorPresent() => EmailFieldError.IsPresent();

        public bool IsEmailFieldErrorRemoved() => EmailFieldError.IsRemoved();

        // <FIX> Why hardcoded?
        public void FillUserNameField() => UserNameField.SendKeys("Colombus");

        public void ClearUserNameField() => UserNameField.Clear();

        public void FillEmailFieldWithInvalidCredentials() => EmailField.SendKeys("asd" + Keys.Tab);

        public void FillEmailFieldWithValidCredentials() => EmailField.SendKeys("sus@amogus.com" + Keys.Tab);

        public bool IsShortDiscriptionsPresent() => ShortDiscription.IsPresent();

        public bool IsDetaildDiscriptionPresent() => DetailedDiscription.IsPresent();

        public bool IsCaptchaFieldPresent() => CaptchaField.IsPresent();

        public bool IsCapthcaImgPresent() => CaptchaImg.IsPresent();

        public bool IsAddButtonPresent() => AddButton.IsPresent();

        public bool IsAddButtonEnable() => AddButton.Enabled;

        public bool DropDownMenusOptionsCount()
        {
            var typeOfProblemOptionsCount = DropDownMenuTypeOfProblem.Options;
            var whereOptionsCount = DropDownMenuWhere.Options;

            return typeOfProblemOptionsCount.Count > 1 | whereOptionsCount.Count > 1;
        }
    }
}
