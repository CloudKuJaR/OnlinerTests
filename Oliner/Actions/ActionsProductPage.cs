using Onliner.Pages;
using OpenQA.Selenium;

namespace Onliner.Actions
{
    public static class ActionsProductPage
    {
        public static ProductPage productPage;
        public static void ClickSellersOfeersButton(IWebDriver driver)
        {
            productPage = new ProductPage(driver);
            productPage.sellersOffers.Click();
        }

        public static void ClickSellerButton(IWebDriver driver)
        {
            productPage = new ProductPage(driver);
            productPage.prodovec.Click();
        }

        public static void ClickCratButton(IWebDriver driver)
        {
            productPage = new ProductPage(driver);
            productPage.cart.Click();
        }

        public static void ClickComparisonButton(IWebDriver driver)
        {
            productPage = new ProductPage(driver);
            productPage.comparisonButton.Click();
        }

        public static void ClickTvCatalogButton(IWebDriver driver)
        {
            productPage = new ProductPage(driver);
            productPage.tvCatalogButton.Click();
        }

        public static void ClickCityButton(IWebDriver driver)
        {
            productPage = new ProductPage(driver);
            productPage.confirmCityButton.Click();
        }
    }
}
