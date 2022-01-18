using Onliner.Utils;
using Onliner.WebElementExtension;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onliner.Pages
{
    public class CurrencyConversionPage
    {
        public string BUY_BUTTON = "//label[@for='buy']";
        public string AMOUNT_CURRENCY_FIELD = "//input[@id='amount-in']";

        public MyWebElement BuyButton => new MyWebElement(By.XPath(BUY_BUTTON));
        public MyWebElement AmountCurrencyField => new MyWebElement(By.XPath(AMOUNT_CURRENCY_FIELD));

        public void ClickBuyButton()
        {
            BuyButton.Click();
        }

        public void FillAmountCurrencyField()
        {
            string randomString = RandomHelper.GetRandomString();
            AmountCurrencyField.SendKeys(randomString);
        }

        public string GetAmountCurrencyFieldValue()
        {
            return AmountCurrencyField.GetAttribute("value");
        }
    }
}
