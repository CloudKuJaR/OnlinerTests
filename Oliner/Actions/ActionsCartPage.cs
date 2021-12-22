using Onliner.Pages;
using OpenQA.Selenium;

namespace Onliner.Actions
{
    public static class ActionsCartPage
    {
        public static CartPage cartPage;
        public static void ClickOrderButton(IWebDriver driver)
        {
            cartPage = new CartPage(driver);
            cartPage.orderButton.Click();
        }
    }
}
