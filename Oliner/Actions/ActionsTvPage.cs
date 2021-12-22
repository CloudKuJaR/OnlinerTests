using Onliner.Pages;
using OpenQA.Selenium;

namespace Onliner.Actions
{
    public static class ActionsTvPage
    {
        public static TVPage tvPage;
        public static void ClickFirstProductButton(IWebDriver driver)
        {
            tvPage = new TVPage(driver);
            tvPage.product1.Click();
        }

        public static void ClickSecondProductButton(IWebDriver driver)
        {
            tvPage = new TVPage(driver);
            tvPage.product2.Click();
        }
    }
}
