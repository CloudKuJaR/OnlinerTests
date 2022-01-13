using Onliner.ActionsWaits;
using Onliner.WebElementExtension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Onliner.Pages
{
    public class OrderPage
    {
        public const string ONLINER_BUTTON = "//a[@href='https://www.onliner.by']";

        private MyWebElement OnlinerButton => new MyWebElement(By.XPath(ONLINER_BUTTON));

        public void OpenCatalogButton()
        {
            OnlinerButton.Click();
        }

        public bool OrderPageIsOpend()
        {
            bool IsOpend = false;
            string currentUrl = Driver.driver.Url;
            string orderPageUrl = "https://cart.onliner.by/order";
            if (currentUrl == orderPageUrl)
            {
                IsOpend = true;
            }
            return IsOpend;
        }
    }
}
