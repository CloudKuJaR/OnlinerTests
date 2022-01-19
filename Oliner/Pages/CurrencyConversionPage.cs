using Onliner.Utils;
using Onliner.WebElementExtension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onliner.Pages
{
    public class CurrencyConversionPage
    {
        private string BUY_BUTTON = "//label[@for='buy']";
        private string AMOUNT_CURRENCY_FIELD = "//input[@id='amount-in']";
        private string CURRENCY_DROP_DOWN_MENU = "//select[@id='currency-in']";
        private string CONVERSION_RESULT = "//b[@class='js-cur-result']";
        private string CONVERSION_RESULT_TYPE_OF_CURRENCY = "//li[@class='result to-be-removed']//span";
        private string BANK_SELLING_PRICE = "(//table[@class='b-currency-table__best'])[2]//td[3]//b";
        private string CURRENCY_CONVERTION_PAGE_TITLE = "//div[@class='b-currency-main__top']//h1";
        private string DATE_CONTAINER = "//th[@class='th-first']";
        private string TYPE_OF_CURRENCY = "//p[@class='abbr rate']//b[text()='{0}']";

        public MyWebElement ConversionResultTypeOfCurrency => new MyWebElement(By.XPath(CONVERSION_RESULT_TYPE_OF_CURRENCY));
        private MyWebElement BuyButton => new MyWebElement(By.XPath(BUY_BUTTON));
        private MyWebElement AmountCurrencyField => new MyWebElement(By.XPath(AMOUNT_CURRENCY_FIELD));
        private MyWebElement ConversionResult => new MyWebElement(By.XPath(CONVERSION_RESULT));
        private MyWebElement BankSellingPrice => new MyWebElement(By.XPath(BANK_SELLING_PRICE));
        private MyWebElement DataContainer => new MyWebElement(By.XPath(DATE_CONTAINER));
        private MyWebElement CurrencyConversioPageTitle => new MyWebElement(By.XPath(CURRENCY_CONVERTION_PAGE_TITLE));
        private SelectElement CurrencyDropDownMenu => new SelectElement(Driver.driver.FindElement(By.XPath(CURRENCY_DROP_DOWN_MENU)));

        public void ClickBuyButton() => BuyButton.Click();

        public string GetAmountCurrencyFieldValue() => AmountCurrencyField.GetAttribute("value");

        public int GetRandomValue() => RandomHelper.GetRandomValue();

        public void ChooseTypeOfCurrency(string CurrencyType) => CurrencyDropDownMenu.SelectByValue(CurrencyType);

        public float GetBankSellingPrice() => float.Parse(BankSellingPrice.Text);

        public bool IsCurrencyTypePresent(string currencyTypeText) => new MyWebElement(By.XPath(string.Format(TYPE_OF_CURRENCY, currencyTypeText))).IsPresent();

        public string GetCurrecnyPageTitle() => CurrencyConversioPageTitle.Text;

        public float ConvertConversionResultStringToFloat() => float.Parse(Page.CurrencyConversionPage.ConversionResult.Text);

        public bool IsTheDateCorrect()
        {
            string currentDate = DateHelper.GetTodaysDateAndMonth();
            string dateFromOnliner = DataContainer.Text;

            return currentDate == dateFromOnliner;
        }

        public void FillAmountCurrencyFieldWithInvalidData()
        {
            string randomString = RandomHelper.GetRandomString();
            AmountCurrencyField.SendKeys(randomString);
        }

        public void FillAmountCurrencyFieldWithValidData(string randomValue)
        {
            AmountCurrencyField.Clear();
            AmountCurrencyField.SendKeys(randomValue);
        }
    }
}
