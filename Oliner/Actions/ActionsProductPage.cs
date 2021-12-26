using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsProductPage
    {
        //public static ProductPage productPage = new ProductPage();
        public static void ClickSellersOfeersButton()
        {
            ProductPage productPage = new ProductPage();
            productPage.sellersOffers.Click();
        }

        public static void ClickSellerButton()
        {
            ProductPage productPage = new ProductPage();
            productPage.prodovec.Click();
        }

        public static void ClickCratButton()
        {
            ProductPage productPage = new ProductPage();
            productPage.cart.Click();
        }

        public static void ClickComparisonButton()
        {
            ProductPage productPage = new ProductPage();
            productPage.comparisonButton.Click();
        }

        public static void ClickTvCatalogButton()
        {
            ProductPage productPage = new ProductPage();
            productPage.tvCatalogButton.Click();
        }

        public static void ClickCityButton()
        {
            ProductPage productPage = new ProductPage();
            productPage.confirmCityButton.Click();
        }
    }
}
